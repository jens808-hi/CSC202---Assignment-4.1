// Using built-in libraries for Windows Forms and the tools within the app, including labels, buttons, text boxes, lists, images, message boxes, links, etc
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name of my project where all my forms and code is stored
namespace WindowsFormsApp2
{
    // Represents the GUI's Main/starting window of my project
    public partial class SanrioMain : Form
    {
        // Variable used to a store number recieved by user input
        int number1;
        // Variabe used to track correct answers for score card
        int correctCount = 0;
        // Variable used to track wrong answers for score card
        int wrongCount = 0;

        // Creates a SoundPlayer object named bgMusic that will load and play the .wav for background music  
        private SoundPlayer bgMusic = new SoundPlayer("opening-cartooon-sound.wav");
        // Plays mouse clikcing sound 
        SoundPlayer player1 = new SoundPlayer("mouse-clicking-sound.wav");
        // Plays alert sound 
        SoundPlayer player2 = new SoundPlayer("alert-sound.wav");

        // Boolean variables tracks whether each question on the Main Quiz window has been answered
        // Hello Kitty button
        bool btnAns1Answered = false; // New addition to my orginal code 
        // Pompompurin button
        bool btnAns2Answered = false;  // New addition to my orginal code 
        // Cinnamonroll button 
        bool btnAns3Answered = false;  // New addition to my orginal code 
        // Year textbox, checked by btnYr  
        bool numBoxAnswered = false;  // New addition to my orginal code 
        // Checkbox 2
        bool chckbox2Answered = false;  // New addition to my orginal code 
        // Numeric Up/Down control
        bool NumUpDown1Answered = false; // New addition to my orginal code 
        // ComboBox
        bool nameBoxAnswered = false;  // New addition to my orginal code 

        // Runs first when the form is initially created 
        public SanrioMain()
        {
            // Sets up all the buttons, labels, textboxes, and controls
            InitializeComponent();
        }
        // Method that disables all the answer buttons for question 1 to prevent the user from changing their selection after answering
        private void DisableQuestion1Buttons()  // New addition to my orginal code 
        {
            // Disables the button for question 1 to prevent the user from clicking the button again
            btnAns1.Enabled = false;  // New addition to my orginal code 
            // Disables the button for question 1 to prevent the user from clicking the button again
            btnAns2.Enabled = false; // New addition to my orginal code 
            // Disables the button for question 1 to prevent the user from clicking the button again
            btnAns3.Enabled = false; // New addition to my orginal code 
        }
        // Method that hides both message labels (correct and wrong message labels) so that only 1 answer message is displayed at a time
        private void ResetMessageLabels() // New addition to my orginal code 
        {
            // Hides the correct message label 
            lblMessage1.Visible = false;  // New addition to my orginal code 
            // Hides the wrong message label 
            lblMessage2.Visible = false;  // New addition to my orginal code 
        }

        private void IncrementCorrect(string message)
        {
            // Hides the message label
            ResetMessageLabels();  // New addition to my orginal code 
            // Increments the number of correct answers by 1
            correctCount++;
           
            // Shows output in the label to user
            lblMessage1.Text = message;  // New addition to my orginal code 
            // Makes the label visible
            lblMessage1.Visible = true;  // New addition to my orginal code 
        }

        private void IncrementWrong(string message)
        {
            // Hides the message label
            ResetMessageLabels();  // New addition to my orginal code 
            // Increments the number of correct answers by 1
            wrongCount++;
            
            // Shows output in the label to user
            lblMessage2.Text = message;  // New addition to my orginal code 
            // Makes the label visible
            lblMessage2.Visible = true;  // New addition to my orginal code 
        }

        // Runs when the correct button is clicked for Question 1
        private void PushMe_Click(object sender, EventArgs e)
        {
            // Checks if question 1 has been answered, exit the method to prevent repeated scoring 
            if (btnAns1Answered) return; // New addition to orginal code for question tracking 
            // Output to user that they are correct 
            IncrementCorrect("You are Correct!");
            // Marks question 1 as answered so the user cannot click on the answer button again
            btnAns1Answered = true; // New addition to original code for question tracking
            // Method called to disable all buttons for question 1 once a button is pressed so that the user cannot change their answer
            DisableQuestion1Buttons(); // New addition to my orginal code 
        }

        // Runs when the wrong answer button is clicked for Question 1
        private void PushMe_Clck2(object sender, EventArgs e)
        {
            // Checks if question 1 has been answered, exit the method to prevent repeated scoring 
            if (btnAns1Answered) return; // New addition to orginal code for question tracking 
            // Output to user that they are wrong 
            IncrementWrong("Wrong Answer!");
            // Marks question 1 as answered so the user cannot click on the answer button again
            btnAns1Answered = true; // New addition to original code for question tracking
            // Method called to disable all buttons for question 1 once a button is pressed so that the user cannot change their answer
            DisableQuestion1Buttons(); // New addition to my orginal code 
        }

        // Runs when the wrong answer button is clicked for Question 1
        private void PushMe_Clck3(object sender, EventArgs e)
        {
            // Checks if question 1 has been answered, exit the method to prevent repeated scoring 
            if (btnAns1Answered) return; // New addition to orginal code for question tracking 
            // Output to user that they are wrong 
            IncrementWrong("Wrong Answer!");
            // Marks question 1 as answered so the user cannot click on the answer button again
            btnAns1Answered = true; // New addition to original code for question tracking
            // Method called to disable all buttons for question 1 once a button is pressed so that the user cannot change their answer
            DisableQuestion1Buttons(); // New addition to my orginal code 
        }

        // Runs when the user checks the Year to question 2
        private void CheckInt_Click(object sender, EventArgs e)
        {
            // Converts the text recieved by user input into a number
            if (int.TryParse(NumBox.Text, out number1))
            {
                // If the number is equal to 1974, then the answer is correct 
                if (number1 == 1974)
                {
                    // Output to user that they are correct 
                    IncrementCorrect("Yes, that's correct! The year is " + NumBox.Text + "!");
                }
                else
                {
                    // Output to user that they are wrong
                    IncrementWrong("Nope, that is the WRONG year, Try Again!");
                    // Clears the textbox so user can try again
                    numBoxAnswered = true;
                }
            } // end outer if
            else
            {
                // Output to the user that their input is not an integer
                IncrementWrong("Not a valid integer");
                // Clears the textbox so user can try again
                NumBox.Clear();
                // Question 2 is NOT answered if invalid input
                numBoxAnswered = false;
            }   // end else
        }

        // Runs when the wrong checkbox 3 is clicked
        private void Check3(object sender, EventArgs e)
        {
            // if both checkbox 3 and checkbox 1 are checked 
            if (chckBox3.Checked || chckBox1.Checked)  // New addition to orginal code to clear the message box after only one click 
            {
                // Output to user that they are wrong
                IncrementWrong("Nope, wrong answer, Try Again!");
                // Unchecks Checkbox 3 to clear the user's selection 
                chckBox3.Checked = false;
                // Question tracking with boolean variable to see if Question 3 has been answered
                chckbox2Answered = true; // New addition to my orginal code 
            }
        }
        // Runs when the wrong checkbox 1 is clicked
        private void Check1(object sender, EventArgs e)
        {
            // if both checkbox 3 and checkbox 1 are checked
            if (chckBox3.Checked || chckBox1.Checked)  // New addition to orginal code to clear the message box after only one click 
            {
                // Output to user that they are wrong
                IncrementWrong("Nope, wrong answer, Try Again!");
                // Unchecks Checkbox 1 to clear the user's selection 
                chckBox1.Checked = false;
                // Question tracking with boolean variable to see if Question 3 has been answered
                chckbox2Answered = true; // New addition to my orginal code 
            }
        }
        // Runs when the correct checkbox 2 is clicked for question 3
        private void Check2(object sender, EventArgs e)
        {
            // Output to user that they are correct 
            IncrementCorrect("Yes, that's Correct");
            // Leaves checkbox 2 checked
            chckBox2.Checked = true;
            // Question tracking with boolean variable to see if Question 3 has been answered
            chckbox2Answered = true; // New addition to my orginal code 
        }

        // Runs when user checks the weight to question 4
        private void CheckInt_Click2(object sender, EventArgs e)
        {
            // Retrieves the number selected by user in the up/down numeric control 
            int selectedWeight = (int)NumUpDown1.Value;
            // If the weight is 3, then the answer is correct
            if (selectedWeight == 3)
            {
                // Output to user that they are correct
                IncrementCorrect("Yes, that is the correct weight!");
            }
            else
            {
                // Output to user that they are wrong
                IncrementWrong("That is the wrong weight!, Try Again!");
            }
            // Marks question 4, Hello Kitty's wieght (numeric up/down question ) as answered so it can be tracked in the quiz
            NumUpDown1Answered = true; // New addition to my orginal code 
        }

        // Runs when checking the combo box selection to question 5
        private void CheckInt_Click3(object sender, EventArgs e)
        {
            // Retrieves the name selected by user and removes extra spaces
            String selectedName = nameBox.Text.Trim();
            // Checks if the selected name is "Dear Daniel"
            if (string.Equals(selectedName, "Dear Daniel", StringComparison.OrdinalIgnoreCase))
            {
                // Output to user that they are correct
                IncrementCorrect("Yes, Dear Daniel is Hello Kitty's boyfriend!");
            }
            else
            {
                // Output to user that they are wrong
                IncrementWrong("No, that is NOT Hello Kitty's boyfriend, Try Again!");
            }
            // Marks question 5, Hello Kitty's boyfriend (ComboBox) as answered so it can be tracked in the quiz
            nameBoxAnswered = true; // New addition to my orginal code 
        }

        // Runs when the link is clicked
        private void lblHk_Bf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            // Opens Internet Explorer and goes to the video link 
            System.Diagnostics.Process.Start("IExplore", "https://www.bing.com/videos/riverview/relatedvideo?q=dear%20daniel%20hello%20kitty&mid=429998C9548B77833FBF429998C9548B77833FBF&ajaxhist=0");
        }

        // Builds the form and runs when the window intially opens it before any user input
        private void SanrioMain_Load(object sender, EventArgs e)
        {
            // Plays sound in a loop until it's stopped

        }

        // Runs when the "Check to View Score" button is clicked
        private void btnCheckScore_Click(object sender, EventArgs e)
        {
            // Checks if Question 2 (year textbox) is answered
            bool numBoxAnswered = !string.IsNullOrWhiteSpace(NumBox.Text); // New addition to my orginal code

            // Checks if Question 3 (checkbox question) is answered
            bool chckbox2Answered = chckBox2.Checked; // New addition to my orginal code

            // Checks if Question 4 (numeric up/down control) was changed
            bool NumUpDown1Answered = NumUpDown1.Value != 0; // New addition to my orginal code

            // Checks if Question 5 (combo box) has a selection
            bool nameBoxAnswered = !string.IsNullOrWhiteSpace(nameBox.Text); // New addition to my orginal code

            // Checks to see if any of the quiz questions haven't been answered. If so, the user isn't allowed to view their score until they answer all questions
            if (!btnAns1Answered || !numBoxAnswered || !chckbox2Answered || !NumUpDown1Answered || !nameBoxAnswered) // New addition to my orginal code

            {
                // Displays a pop-up message telling the user that they must complete all quiz questions before they can view their score
                MessageBox.Show("Please answer ALL quiz questions before viewing your score."); // New addition to my orginal code
                // Exits the method when all quiz questions have been answered
                return; // New addition to my orginal code
            }

            // Stops looping background music
            bgMusic.Stop();

            // Creates a new pop up window to generate the totals of correct and wrong answers 
            scoreCard scoreCard = new scoreCard(correctCount, wrongCount);
            // If everything is answered, show score card window to user
            scoreCard.ShowDialog();
        }

        // Creates a new pop up window to generate another game (Sanrio Mart), when "Go Shopping with Hello Kitty" button is clicked
        private void btnSanrioMart_Click(object sender, EventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            // Creates a new copy of the Sanrio Grocery form 
            SanrioGroceryForm sanrioGrocery = new SanrioGroceryForm();

            // Shows the Sanrio Grocery form 
            sanrioGrocery.ShowDialog();
            // Closes the SanrioMain form
            this.Close();
        }

        // Runs when the user clicks the "Grocery Shopping" menu option in the toolbar
        private void groceryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            // Creates a new copy of the Sanrio Grocery form 
            SanrioGroceryForm sanrioGrocery = new SanrioGroceryForm();

            // Hides the current form view
            this.Hide();
            // Shows the Sanrio Grocery form 
            sanrioGrocery.ShowDialog();
            // After the new form is closed, shows the orginal form again
            this.Show();
        }
        // Runs when the user clicks the "YouTube Link" menu option in the toolbar
        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            // Stores the URL of the YouTube/Bing video link 
            string url = "https://www.bing.com/videos/riverview/relatedvideo?q=dear%20daniel%20hello%20kitty&mid=429998C9548B77833FBF429998C9548B77833FBF&ajaxhist=0";

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

        // Runs when the user clicks "Return to Sanrio Menu" in the toolbar
        private void ReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            // Creates a new copy of the NewSanrioGUI form 
            NewSanrioGUI sanrioGUI = new NewSanrioGUI();

            // Hides the current form view
            this.Hide();
            // Opens the new SanrioGuI form and waits until the user is done with it 
            sanrioGUI.ShowDialog();
            // After the new form is closed, shows the orginal form again 
            this.Show();
        }

        // Runs when the user clicks "Return to Sanrio Menu" in the toolbar
        private void mazeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            // Creates a new copy of the HelloKittyMaze form 
            HelloKittyMazeForm mazeForm = new HelloKittyMazeForm();

            // Hides the current form view
            this.Hide();
            // Opens the new HellloKittyMaze form and waits until the user is done with it 
            mazeForm.ShowDialog();
            // After the new form is closed, shows the orginal form again 
            this.Show();
        }

        // Runs when the user clicks the "Sanrio Store" menu option in the toolbar
        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

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
                    // Tells Windows to open the url using the default browser 
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

        // Runs when the user clicks the "Exit" menu option in the toolbar
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Creates a message box asking the user for confirmation before exiting the application 
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
                // Closes all forms and shuts down the entire application 
                Application.Exit();   // New addition to orginal code
            }
        }
    }
}
   
