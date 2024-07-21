using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GNS.Games.WackAMole
{
    public partial class formNameEntry : Form
    {
        private string playerName;
        private bool cancellation;

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public bool Cancellation
        {
            get { return cancellation; }
            set { cancellation = value; }
        }

        public formNameEntry()
        {
            InitializeComponent();
            PlayerName = "";
            Cancellation = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            PlayerName = nameTextBox.Text;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to cancel?", "Cancel?", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Cancellation = true;
            }
            this.Close();
        }
    }
}
