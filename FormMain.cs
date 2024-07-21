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
    public partial class FormMain : Form
    {
        /// <summary>
        /// Global variables.
        /// </summary>
        #region Globals

        enum DifficultyLevel { Insane=1, Expert, Hard, Moderate, Normal, Easy, Beginner }
        enum Stage { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten }

        DifficultyLevel difficulty = DifficultyLevel.Beginner;
        Stage stage = Stage.One;
        Random rand = new Random(System.DateTime.Now.Second);
        List<Control> buttonList = new List<Control>();

        const int INTERVAL = 350;

        int score = 0;
        int lives = 3;
        int elapsedtime = 0;
        bool timedGame = false;

        #endregion


        /*
         *  2009.07.15
         *  TODO:
         *      1) Add High Score code => I suggest building a Player class with Name, Date, Difficulty, Level, & Score attributes.    
         *      2) Add code to write changes to the High Scores file. --This will be done by Tieson.
         *      3) Allow user to see what the time is on a timed game. --This will be done by Tieson.
         *  DONE:
         *      1) Add code to Reset method to reset Difficulty to the level checked in the menu. --Tieson
         *      2) Add code to allow only one Difficulty level to be selected at once in the menu. --Tieson
         *      3) Add code so that the user can make a printout of their game's info to show their gaming prowess. --Casey
         *      4) Add code to read in a high scores file.  --Casey
         *      5) Add code so that the user can play a timed game. --Casey.
         *      6) Bug fixed - Player can pause the game when not playing (game over, not started yet)
         *      7) Feature Added/Bug Fixed - When the player beats a difficulty the label at the top of garden area
         *         changes --David
         *      8) Bug fixed - The exception that came up when a player tries to print the high scores now has a try
         *         catch block around it --David
         *      9) Bug fixed - The bug that allowed the user to level up with then score ends in a 90 is fixed --David
         *      10)Bug fixed/feature added - An end menu item was created so the player can't change difficulty while
         *        the game is still running --David
         *      11)Bug fixed - The bug where the counter went negative is fixed --David
         */

        /// <summary>
        /// Main entry point for the application.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            this.Text = this.ProductName;
            // Manually added click eventhandler for groupbox - not available in Properties window.
            this.grpGardenArea.Click += new EventHandler(this.Whack);
            this.tsslScore.Text = String.Format("Score: {0}", score);
            this.pauseToolStripMenuItem.Enabled = false;
            this.endToolStripMenuItem.Enabled = false;
            LevelUp();
            foreach (Control ctrl in this.grpGardenArea.Controls)
            {
                buttonList.Add(ctrl);
            }
        }

        /// <summary>
        /// Timer method to hide/show the mole.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event that raised the eventhandler.</param>
        private void timerMole_Tick(object sender, EventArgs e)
        {
            ClearBoard();
            int r = rand.Next(1, 9);
            if (grpGardenArea.Controls.Contains(buttonList[r]))
            {
                buttonList[r].Visible = true;
            }

        }

        /// <summary>
        /// Reset the visible area of the groupbox.
        /// </summary>
        private void ClearBoard()
        {
            foreach (Button btn in this.grpGardenArea.Controls)
            {
                btn.ResetText();
                btn.Visible = false;
            }
            this.tsslLives.Text = String.Format("Lives left: {0}", lives);
        }

        /// <summary>
        /// Start the game.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event that raised the eventhandler.</param>
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.endToolStripMenuItem.Enabled = true;
                this.fileToolStripMenuItem.Enabled = false;
                this.pauseToolStripMenuItem.Enabled = true;
                this.grpGardenArea.Enabled = true;
                startToolStripMenuItem.Enabled = false;
                timerMole.Enabled = true;
                if (timedGame == true)
                {
                    gameTimer.Start();
                    timerElapsedTime.Start();
                    LevelUp();
                }
        }

        /// <summary>
        /// Event called when user attempts to "whack" the mole.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event that raised the eventhandler.</param>
        private void Whack(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Name != "grpGardenArea")
           {
                
                if (ctrl.Text == "X")
                {
                }
                else
                {
                    ctrl.Text = "X";
                    score += 10;

                    if (score % 100 == 0)
                    {
                        stage++;
                        if (stage > Stage.Ten)
                        {
                            if (difficulty > DifficultyLevel.Insane)
                            {
                                difficulty--;
                                this.grpGardenArea.Text = "Difficulty: " + difficulty.ToString();
                            }
                            else
                            {
                                timerMole.Stop();
                                MessageBox.Show("Congratulations! You have reached the maximum level! You win!",
                                this.ProductName,
                                MessageBoxButtons.OK);
                                this.pauseToolStripMenuItem.Enabled = false;
                            }
                            ClearBoard();
                            stage = Stage.One;
                            this.timerMole.Start();
                        }
                        LevelUp();
                    }
                }
                this.tsslScore.Text = String.Format("Score: {0}", score);
            }

            else
            {
                lives--;
                this.tsslLives.Text = String.Format("Lives left: {0}", lives);
            }
            
            if (lives == 0)
            {
                this.timerMole.Stop();
                ClearBoard();
                MessageBox.Show("Game Over!", this.ProductName, MessageBoxButtons.OK);
                this.pauseToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Method called to set/update the timer interval and update the form labels.
        /// </summary>
        private void LevelUp()
        {
            this.timerMole.Interval = (int)difficulty * INTERVAL - (int)stage * (INTERVAL / 10);
            this.tsslScore.Text = String.Format("Score: {0}", score);
            this.tsslLives.Text = String.Format("Lives left: {0}", lives);
            this.tsslLevel.Text = String.Format("Level: {0}", stage);
                this.grpGardenArea.Text = String.Format("Difficulty: {0}", difficulty);

            if (timedGame)
            {
                this.tsslCounter.Text = String.Format("Time Left: {0}", elapsedtime);
//                if (elapsedtime == 0)
  //                  this.pauseToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Pause the game.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event that raised the eventhandler.</param>
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timedGame)
            {
                this.gameTimer.Stop();
                this.timerElapsedTime.Stop();
            }
            this.timerMole.Stop();
            this.startToolStripMenuItem.Enabled = true;
            this.pauseToolStripMenuItem.Enabled = false;
            this.grpGardenArea.Enabled = false;
        }

        /// <summary>
        /// Set the starting difficulty level.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event that raised the eventhandler.</param>
        private void SetDifficultyLevel(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;

            if (mi.Checked)
            {
                foreach (ToolStripMenuItem itm in difficultyToolStripMenuItem.DropDownItems)
                {
                    if (itm != mi)
                    {
                        itm.Checked = false;
                    }
                }
                SetLevel(mi.Text); 
            }
        }

        /// <summary>
        /// Set the game&#39;s difficulty level.
        /// </summary>
        /// <param name="str">The name of the level.</param>
        private void SetLevel(String str)
        {
            switch (str)
            {
                case "Beginner":
                    difficulty = DifficultyLevel.Beginner;
                    break;
                case "Easy":
                    difficulty = DifficultyLevel.Easy;
                    break;
                case "Normal":
                    difficulty = DifficultyLevel.Normal;
                    break;
                case "Moderate":
                    difficulty = DifficultyLevel.Moderate;
                    break;
                case "Hard":
                    difficulty = DifficultyLevel.Hard;
                    break;
                case "Expert":
                    difficulty = DifficultyLevel.Expert;
                    break;
                case "Insane!":
                    difficulty = DifficultyLevel.Insane;
                    break;
                default:
                    difficulty = DifficultyLevel.Beginner;
                    break;
            }
            LevelUp();
        }

        /// <summary>
        /// Exit the application.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event that raised the eventhandler.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Menu item to view the High Scores list.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event that raised the eventhandler.</param>
        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Hide();
                formHighScores frmScores = new formHighScores(score, difficulty.ToString());
                frmScores.ShowDialog();
                this.Show();
                frmScores.Close();
        }

        /// <summary>
        /// Reset the form to it&#39;s initial state.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event that raised the eventhandler.</param>
        private void resetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            timerMole.Stop();
            gameTimer.Stop();
            timerElapsedTime.Stop();
            lives = 3;
            score = 0;
            stage = Stage.One;
            ClearBoard();
            foreach (ToolStripMenuItem tsmi in difficultyToolStripMenuItem.DropDownItems)
            {
                if (tsmi.Checked)
                {
                    SetLevel(tsmi.Text);
                    continue;
                }
            }

            foreach (ToolStripMenuItem mi in playTimedGameToolStripMenuItem.DropDownItems)
            {
                if (mi.Checked)
                {
                    SetGameTimer(mi.Text);
                    continue;
                }
            }

            startToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Set the time limit of a timed game.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event that raised the eventhandler.</param>
        private void gameTimerSetter(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;

            if (tsmi.Checked)
            {
                foreach (ToolStripMenuItem itm in playTimedGameToolStripMenuItem.DropDownItems)
                {
                    if (itm != tsmi)
                    {
                        itm.Checked = false;
                    }
                }
                SetGameTimer(tsmi.Text);
            }

        }

        /// <summary>
        /// Helper method for setting the time limit of a timed game.
        /// </summary>
        /// <param name="button">The Text property value of the currently selected drop-down menu item.</param>
        private int SetGameTimer(string button)
        {
            int gameSeconds=1;
            switch (button)
            {
                case "&30 Seconds":
                    gameSeconds = 30;
                    break;
                case "&1 Minute":
                    gameSeconds = 60;
                    break;
                case "&2 Minutes":
                    gameSeconds = 120;
                    break;
                case "&Unlimited":
                    gameSeconds = 121;
                    break;
                default:
                    gameSeconds = 121;
                    break;
            }
            elapsedtime = gameSeconds - 1;

            if (gameSeconds == 121)
            {
                timedGame = false;
            }
            else
            {
                timedGame = true;
                gameTimer.Interval = 1000 * gameSeconds;
            }
            return gameSeconds;
        }

        /// <summary>
        /// Game timer.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event that raised the eventhandler.</param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            lives = 0;
            timerMole.Stop();
            gameTimer.Stop();
            timerElapsedTime.Stop();
            ClearBoard();
            MessageBox.Show("Time's Up - Game Over!", this.ProductName, MessageBoxButtons.OK);
            this.pauseToolStripMenuItem.Enabled = false;
            this.fileToolStripMenuItem.Enabled = true;
            this.endToolStripMenuItem.Enabled = false;
            foreach (ToolStripMenuItem mi in playTimedGameToolStripMenuItem.DropDownItems)
            {
                if (mi.Checked)
                {
                    SetGameTimer(mi.Text);
                    continue;
                }
            }
            
        }

        /// <summary>
        /// Elapsed time timer.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event that raised the eventhandler.</param>
        private void timerElapsedTime_Tick(object sender, EventArgs e)
        {
            --elapsedtime;
            this.tsslCounter.Text = String.Format("Time Left: {0}", elapsedtime);
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {

            timerMole.Stop();
            gameTimer.Stop();
            timerElapsedTime.Stop();
            lives = 3;
            score = 0;
            stage = Stage.One;
            ClearBoard();
            foreach (ToolStripMenuItem tsmi in difficultyToolStripMenuItem.DropDownItems)
            {
                if (tsmi.Checked)
                {
                    SetLevel(tsmi.Text);
                    continue;
                }
            }

            foreach (ToolStripMenuItem mi in playTimedGameToolStripMenuItem.DropDownItems)
            {
                if (mi.Checked)
                {
                    SetGameTimer(mi.Text);
                    continue;
                }
            }

            startToolStripMenuItem.Enabled = true;
        }

    }
}
