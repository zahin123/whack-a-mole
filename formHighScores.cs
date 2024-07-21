using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Windows.Forms;

namespace GNS.Games.WackAMole
{
    public partial class formHighScores : Form
    {
        private Player player = new Player();

        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        public formHighScores(int currentUserScore, string currentUserDifficulty)
        {
            try
            {
                InitializeComponent();
                Player.Score = currentUserScore;
                Player.Difficulty = currentUserDifficulty;
                scoreChecker();
                main();
            }
            catch (Exception)
            {

                MessageBox.Show("Sorry there was an error");
            }
        }

        public void scoreChecker()
        {
            //This function will see if the user's score is high enough
            //to make the top 5.  Executed on form load.
            XDocument xd = XDocument.Load("scores.xml");

            var users = from user in xd.Descendants("user")
                        orderby user.Element("score").Value descending
                        select new
                        {
                            name = user.Element("name").Value,
                            score = user.Element("score").Value,
                            difficulty = user.Element("diff").Value,
                        };

            foreach (var user in users)
            {
                // Check player's score against each node in the XML file.
                // If player's score is greater than current node and was earned at the same difficulty setting, 
                // insert here.
                if (Player.Score > Convert.ToInt32(user.score) && Player.Difficulty == user.difficulty)
                {
                    //user.
                }
            }
        }

        public void ListViewPopulator()
        {
            /*This module sizes up the columns in the listview,
             * then it loads in the xml file and populates the listview.*/
            usersListView.Columns.Add("User", 200, HorizontalAlignment.Left);
            usersListView.Columns.Add("Score", 50, HorizontalAlignment.Right);
            usersListView.Columns.Add("Difficulty Level", 100, HorizontalAlignment.Right);

            XDocument xd = XDocument.Load("scores.xml");

            var users = from user in xd.Descendants("user")
                        orderby user.Element("score").Value descending
                        select new
                        {
                            name = user.Element("name").Value,
                            score = user.Element("score").Value,
                            difficulty = user.Element("diff").Value,
                        };

            foreach (var user in users)
            {
                ListViewItem theItem = new ListViewItem(user.name);
                theItem.SubItems.Add(user.score);
                theItem.SubItems.Add(user.difficulty);

                this.usersListView.Items.Add(theItem);
            }
        }

        public void main()
        {
            ListViewPopulator();
        }

        public void fileCreator()
        {
            //This creates an HTML file formatted to look ok as a printout, and opens it in
            //the system's default browser.
            TextWriter tw = new StreamWriter("printData.html");
            tw.WriteLine("<html><title>Whack-A-Mole Achievement</title><body>");
            tw.WriteLine("<h1 align=center>Whack-A-Mole</h1>");
            tw.WriteLine("<tr><td><h2 align=center><em>" + Player.Name + "</em></h2></td>");

            if (Player.Difficulty == "Insane" && Player.Score > 0)
            {
                tw.WriteLine("<p align=\"center\">Congratulations, you are one of only a few to even get a few points on Insane.</p>");
            }
            tw.WriteLine("<td><p align=\"center\">" + Player.Score + " points achieved at a difficulty of level ");
            tw.WriteLine((Player.Difficulty) + "</p></td>");
            tw.WriteLine("</table></body></html>");
            tw.Close();

            System.Diagnostics.Process.Start("printData.html");
        }

        private void printLabel_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                formNameEntry entryForm = new formNameEntry();

                //This code makes sure that the user enters a name, and if they choose to cancel the whole
                //process, they now can.
                while (success == false)
                {
                    entryForm.ShowDialog();
                    if (entryForm.PlayerName == "")
                    {
                        if (entryForm.Cancellation == true)
                        {
                            success = true;
                        }
                        else
                        {
                            MessageBox.Show("Please enter your name in the text box.");
                        }
                    }
                    else
                    {
                        success = true;
                        Player.Name = entryForm.PlayerName;
                        fileCreator();
                    }
                };

                this.Show();
                entryForm.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Sorry, there was an error");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void backToMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
