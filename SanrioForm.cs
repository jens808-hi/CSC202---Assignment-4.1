// Using built-in libraries for Windows Forms and the tools within the app, including labels, buttons, text boxes, message boxes, links, etc
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media; // New addition, plays a sound
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name of my project where all my forms and code is stored
namespace WindowsFormsApp2
{

    // Represents an additional form in my project
    public partial class NewSanrioGUI : Form
    {
        // Creates a SoundPlayer object named bgMusic that will load and play the .wav for background music  
        private SoundPlayer bgMusic = new SoundPlayer("opening-cartoon-sound.wav");


        // Plays mouse clikcing sound 
        SoundPlayer player1 = new SoundPlayer("mouse-clicking-sound.wav");

        // Plays alert sound 
        SoundPlayer player2 = new SoundPlayer("alert-sound.wav");


        // Runs first when the form is initially created 
        public NewSanrioGUI()

        {
            // Sets up all the buttons, labels, textboxes, and controls
            InitializeComponent();
            // Disables the reset button when the program first starts to prevent user from pressing it before playing. Main purpose is for it is after game cycles once
            btnResetGUI.Visible = false; // New addition to orginal code
        }

        // Runs when the user clicks the "Take Sanrio Quiz" button 
        private void Open_NewWin(object sender, EventArgs e)
        {
            // Creates a new window for the main Sanrio window
            SanrioMain sanrioMain = new SanrioMain();
            // When main Sanrio window finishes closing also run this code 
            sanrioMain.FormClosed += (s, EventArgs) => // New addition to orginal code 
            {
                // Shows the reset button
                btnResetGUI.Visible = true; // New addtion to original code 
                // Hides the Click Me to Play button 
                PushMe_Click1.Visible = false;   // New addition to orginal code
            };
            // Displays the main window of Sanrio GUI to user
            sanrioMain.Show();

            // Plays sound(background music) on a loop until its stopped 
            bgMusic.PlayLooping();

            // Disables the button so it can only be clicked once
            PushMe_Click1.Enabled = false;

        }
        // This method will run later when the form initially loads
        private void NewSanrioGUI_Load(object sender, EventArgs e)
        {
            // not using this yet
        }

        // Runs when the user clicks the "Sanrio Quiz" menu option in the toolbar
        private void btnSanrioMain_Click(object sender, EventArgs e)
        {
            //Returns the user to the new Sanrio Main form 
            SanrioMain sanrioMain = new SanrioMain();

            // Hides the menu while playing 
            this.Hide();
            // Opens the new form and waits until the user is done with it 
            sanrioMain.ShowDialog();
            // Shows the menu again when done taking quiz
            this.Show();
        }

        // Runs when the user clicks the "Sanrio Store" button 
        private void btnStore_Click(object sender, EventArgs e)
        {
            // Stores the URL of the stores link 
            string url = "https://www.sanrio.com/";

            // Attempts to open the URL in the default web browser
            try
            {
                // Creates a ProcessStartInfo object to open the link in the default browser
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    // The property that holds the URL to open
                    FileName = url,
                    // Tells Windows to open the url using the default browser safely 
                    UseShellExecute = true,
                };
                // Starts the process of opening the web browser using the specified URL
                Process.Start(processStartInfo);
            }
            // Catches any exceptions/errors that occur while tyring to open the URL 
            catch (Exception ex)
            {
                // Displays the error message from the exception
                MessageBox.Show("Unable to open YouTube link.\n" + ex.Message);
            }
        }
        // Runs when user clicks the "Go Grocery Shopping" button 
        private void btnSanrioMart_Click_1(object sender, EventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            //Returns the user to the new Sanrio Grocery form 
            SanrioGroceryForm sanrioGrocery = new SanrioGroceryForm();

            // Shows the Sanrio Grocery form 
            sanrioGrocery.ShowDialog();
            // Closes the Sanrio Main form
            this.Close();
        }

       // Runs when user clicks the "Play Maze" button
        private void btnMaze_Click_1(object sender, EventArgs e)
        {
            // Creates a new copy of the HelloKittyMaze form
            HelloKittyMazeForm mazeForm = new HelloKittyMazeForm();

            // Hides the menu while playing 
            this.Hide();
            // Shows the Hello Kitty Maze form 
            mazeForm.ShowDialog();
            // Shows the menu again when done playing 
            this.Show();
        }

        // Runs when the user clicks the "Exit" button
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // Creates a a message box asking the user for confirmation before exiting the application 
            DialogResult result = MessageBox.Show(
               "Are you sure you want to exit the application?",
               "Quit",
               // Displays two buttons on the message box, Yes and No
               MessageBoxButtons.YesNo,
               // Displays a question mark icon
               MessageBoxIcon.Question
            );

            // Plays mouse clicking sound
            player1.Play();

            // Asks the user to make a decision 
            if (result == DialogResult.Yes)
            {
                // Plays alert sound 
                player2.Play();
                // Closes the form and shuts down the entire application 
                Application.Exit();
            }
        }


    }
}
