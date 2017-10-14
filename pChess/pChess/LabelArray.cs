using System;
using System.Collections.Generic;
using System.Text;

namespace pChess
{
    public class LabelArray : System.Collections.CollectionBase
    {
        private readonly System.Windows.Forms.Form HostForm;
        
        public System.Windows.Forms.Label NewLabel()
        {
            // Create a new instance of the Label class.
            System.Windows.Forms.Label aLabel = new
               System.Windows.Forms.Label();
            // Add the label to the collection's internal list.
            this.List.Add(aLabel);
            // Add the label to the controls collection of the form 
            // referenced by the HostForm field.
            HostForm.Controls.Add(aLabel);
            // Set intial properties for the label object.
            aLabel.Top = Count * 25;
            aLabel.Left = 100;
            aLabel.Tag = this.Count;
            aLabel.Text = "Label " + this.Count.ToString();
            aLabel.Click += new System.EventHandler(ClickHandler);
            return aLabel;
        }

        // The constructor hack
        public LabelArray(System.Windows.Forms.Form host)
        {
            HostForm = host;
            this.NewLabel();
        }

        // The default property
        public System.Windows.Forms.Label this[int Index]
        {
            get
            {
                return (System.Windows.Forms.Label)this.List[Index];
            }
        }

        // The remove method
        public void Remove()
        {
            // Check to be sure there is a label to remove.
            if (this.Count > 0)
            {
                // Remove the last label added to the array from the host form 
                // controls collection. Note the use of the indexer in accessing 
                // the array.
                HostForm.Controls.Remove(this[this.Count - 1]);
                this.List.RemoveAt(this.Count - 1);
            }
        }

        // Our goal - the common event handler
        public void ClickHandler(Object sender, System.EventArgs e)
        {
            Form1.tileClicked = ((System.Windows.Forms.Label)sender);
            Form1.tileClickedNum = Convert.ToInt32(((System.Windows.Forms.Label)sender).Tag.ToString());
        }
    }

    public class PBoxArray : System.Collections.CollectionBase
    {
        private readonly System.Windows.Forms.Form HostForm;

        public System.Windows.Forms.PictureBox NewPBox()
        {
            // Create a new instance of the pbox class.
            System.Windows.Forms.PictureBox aPBox = new
               System.Windows.Forms.PictureBox();
            // Add the pbox to the collection's internal list.
            this.List.Add(aPBox);
            // Add the pbox to the controls collection of the form 
            // referenced by the HostForm field.
            HostForm.Controls.Add(aPBox);
            // Set intial properties for the pbox object.
            aPBox.Top = Count * 25;
            aPBox.Left = 100;
            aPBox.Tag = this.Count;
            aPBox.Click += new System.EventHandler(ClickHandler);
            return aPBox;
        }

        // The constructor hack
        public PBoxArray(System.Windows.Forms.Form host)
        {
            HostForm = host;
            this.NewPBox();
        }

        // The default property
        public System.Windows.Forms.PictureBox this[int Index]
        {
            get
            {
                return (System.Windows.Forms.PictureBox)this.List[Index];
            }
        }

        // The remove method
        public void Remove()
        {
            // Check to be sure there is a pbox to remove.
            if (this.Count > 0)
            {
                // Remove the last pbox added to the array from the host form 
                // controls collection. Note the use of the indexer in accessing 
                // the array.
                HostForm.Controls.Remove(this[this.Count - 1]);
                this.List.RemoveAt(this.Count - 1);
            }
        }

        // Our goal - the common event handler
        public void ClickHandler(Object sender, System.EventArgs e)
        {
            Form1.sprClicked = ((System.Windows.Forms.PictureBox)sender);
            Form1.sprClickedNum = Convert.ToInt32(((System.Windows.Forms.PictureBox)sender).Tag.ToString()); ;
        }
    }
}
