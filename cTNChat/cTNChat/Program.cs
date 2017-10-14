using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace cTNChat
{
    class Server
    {
        const int PortNumber = 31337;
        const int BacklogSize = 20;

        static void Main(string[] args)
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(new IPEndPoint(IPAddress.Any, PortNumber));
            server.Listen(BacklogSize);
            while (true)
            {
                Socket conn = server.Accept();
                new Connection(conn);
            }
        }
    }

    class Connection
    {
        static object BigLock = new object();
        Socket socket;
        public StreamReader Reader;
        public StreamWriter Writer;
        static ArrayList connections = new ArrayList();

        public Connection(Socket socket)
        {
            this.socket = socket;
            Reader = new StreamReader(new NetworkStream(socket, false));
            Writer = new StreamWriter(new NetworkStream(socket, true));
            new Thread(ClientLoop).Start();
        }

        void ClientLoop()
        {
            try
            {
                lock (BigLock)
                {
                    OnConnect();
                }
                while (true)
                {
                    lock (BigLock)
                    {
                        foreach (Connection conn in connections)
                        {
                            conn.Writer.Flush();
                        }
                    }
                    string line = Reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    lock (BigLock)
                    {
                        ProcessLine(line);
                    }
                }
            }
            finally
            {
                lock (BigLock)
                {
                    socket.Close();
                    OnDisconnect();
                }
            }
        }

        void OnConnect()
        {
            Writer.WriteLine(" Welcome to cTNChat, Anonymous.");
            BCast("Anon joined");
            connections.Add(this);
        }

        void OnDisconnect()
        {
            connections.Remove(this);
            BCast("Anon parted");
        }

        void ProcessLine(string line)
        {
            BCast("<Anon> " + line.Trim());
        }

        void BCast(string str)
        {
            while (str.Length > 80-17)
            {
                str += str.Substring(0, 80-17) + "\r\n" + Space(17) + str.Substring(80-17+1);
            }
            foreach (Connection conn in connections)
            {
                conn.Writer.WriteLine(" " + System.DateTime.Now.ToLongTimeString() + " " + str);
            }
        }

        string Space(int vl)
        {
            string ret = "";
            for (int a = 0; a < vl; a++) ret += " ";
            return ret;
        }
    }
}