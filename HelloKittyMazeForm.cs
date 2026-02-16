// Using built-in libraries for Windows Forms and the tools within the app, including labels, buttons, images, list boxes, message boxes, sound effects and external links
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name of my project where all my forms and code is stored
namespace WindowsFormsApp2
{
    // Represents the GUI's Main/starting window of my project
    public partial class HelloKittyMazeForm : Form
    {
        // Dictionary that stores recipes names as keys and thier correspoinding list of required ingredients as values
        Dictionary<string, List<string>> recipes;
        // Stores the name of the currently generated recipe
        string currentRecipe;
        // Stores the correct list of ingredients for the current recipe 
        List<string> correctIngredients;
        // Tracks how many tries the user has made, using a 3-try game loop counter 
        int tries = 0;
        // Random number generator used to randomly select recipe from the dictionary 
        private Random rand = new Random();

        // Creates a SoundPlayer object named bgMusic that will load and play the .wav for background music  
        private SoundPlayer bgMusic = new SoundPlayer("opening-cartooon-sound.wav");
        // Plays mouse clikcing sound 
        SoundPlayer player1 = new SoundPlayer("mouse-clicking-sound.wav");
        // Plays alert sound 
        SoundPlayer player2 = new SoundPlayer("alert-sound.wav");

        // Runs first when the form is initially created 
        public HelloKittyMazeForm()
        {
            // Sets up all the buttons, labels, textboxes, and controls
            InitializeComponent();

            // Disables submit button until a recipe is generated, prevents user from submittin before starting a round
            btnSubmit.Enabled = false;

            // Runs the dictionary and populates all available recipes, each recipe matches to a a list of correct ingredients
            recipes = new Dictionary<string, List<string>>()
            {
                { "Strawberry Shortcake", new List<string> { "strawberry", "eggs", "milk", "cake" }},
                { "Matcha Cream Cake", new List<string> { "eggs", "milk", "cake", "green tea" }},
                { "Matcha Green Tea Shortbread", new List<string> { "eggs", "milk", "cookies","green tea" }},
                { "Strawberry Matcha Ice Cream", new List<string> { "ice cream","milk", "green tea", "strawberry" }},
                { "Strawberry Tres Leches cake", new List<string> { "eggs", "milk", "cake", "strawberry" }},
                { "Watermelon Boba Milk Tea", new List<string> { "milk", "tea", "boba", "watermelon" }},
                { "Strawberry Watermelon Ice Cream", new List<string> {"ice cream", "strawberry", "watermelon" }},
                { "Strawberry Papaya Milk Tea", new List<string> { "milk", "papaya", "strawberry", "tea" }},
                { "Strawberry Boba Milk Shake", new List<string> { "ice cream", "milk", "strawberry", "boba" }},
            };
        }
        // Resets the game after a win or after 3 failed attemps 
        private void ResetGame()
        {
            // Resets the counter back to zero
            tries = 0;
            // Clears the current recipe so user has to generate a new one
            correctIngredients = null;
            // Removes all selected items from the ingredient list box
            lstIngredients.ClearSelected();
            // Disables submit button until a new recipe is generated 
            btnSubmit.Enabled = false;
            // Re-enables the generate button so user can start a new round
            btnGenerate.Enabled = true;
        }
        // Runs when the form first appears on the screen 
        private void HelloKittyMazeForm_Load_1(object sender, EventArgs e)
        {
            // Populates a listbox with all ingredient options, which also represent shelves in the grocery maze
            lstIngredients.Items.AddRange(new string[]
            {
                "ice cream",
                "eggs",
                "milk",
                "tea",
                "cake",
                "strawberry",
                "papaya",
                "green tea",
                "boba",
                "cookies",
                "watermelon"
            });
        }
        // Button that generates the recipe and starts a new round
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Resets attempt counter at the start of a new round
            tries = 0;

            // Randomly selects a recipe from dictionary 
            var recipe = recipes.ElementAt(rand.Next(recipes.Count));
            // Stores the selected recipe name
            currentRecipe = recipe.Key;
            // Stores the correct ingredient list 
            correctIngredients = recipe.Value;

            // Displays the recipe name to user
            lblRecipe.Text = "Recipe: " + currentRecipe;
            // Tells the user to start selecting ingredients
            lblStatus.Text = "Select ingredients!";
            // Changes the status text color to blue violet
            lblStatus.ForeColor = Color.BlueViolet;

            // Clears the previous selections
            lstIngredients.ClearSelected();

            // Disables generate button during an active round
            btnGenerate.Enabled = false;

            // Enables submit buttom after recipe is generated
            btnSubmit.Enabled = true;
        }

        // Validates the user's ingredient selection, compares them to the correct recipe, and implements the 3 try game loop logic using an incremented counter
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensures recipe has been generated before enabling submit button 
                if (correctIngredients == null)
                    // Throws an exception if the user tries to submit before generating a recipe, triggers the catch block for to handle the error
                    throw new Exception("Generate a recipe first!");

                // Ensures the user has selected at least one ingredient
                if (lstIngredients.SelectedItems.Count == 0)
                    // Throws an exception if the users clicks submit without selectin any ingredients, preventing empty submissions and triggers the error handling 
                    throw new Exception("You must select ingredients!");

                // Increases the attempt counter by 1 each time the user clicks submit
                tries++;

                // Stores the ingredients the user selected and compares it to the correct recipe regardless of order and prevents duplicates
                HashSet<string> userSelection = new HashSet<string>();

                // Adds all selected items to Hashset
                foreach (var item in lstIngredients.SelectedItems)
                {
                    // Converts the selected listbox item to a string and stores it in the user's ingredient collection for comparison
                    userSelection.Add(item.ToString());
                }
                // Checks if user selection matches exactly to recipe ingredients 
                if (userSelection.SetEquals(correctIngredients))
                {
                    // Displays a message to user when the correct ingredients are selected
                    lblStatus.Text = "That's Correct! Hello Kitty reached the flag!";
                    // Changes the status text color to green to indicate the answer is correct 
                    lblStatus.ForeColor = Color.Green;

                    // Ends the loop after 3 tries
                    ResetGame();
                    // Exits the round
                    return;
                }

                {
                    // Checks if the user has used less than 3 attempts, if so the condition becomes true and the game continues 
                    if (tries < 3)
                    {
                        // Updates the status label to tell the user their guess is wrong,
                        // then calculates how many attempts they have left using the $ symbol to insert it directly inside the string
                        lblStatus.Text = $"Wrong! {3 - tries} tries left";
                        // Changes the text color to dark orange to indicate the answer is wrong but the game isn't over just yet 
                        lblStatus.ForeColor = Color.DarkOrange;

                        // Clears selections for the next attempt
                        lstIngredients.ClearSelected();
                    }
                    else
                    {
                        // 3rd failed attempt
                        lblStatus.Text = "Game Over! Generate a new recipe.";
                        // Changes the status text color to red to indicate the answer is wrong 
                        lblStatus.ForeColor = Color.Red;

                        // Ends the loop after 3 tries
                        ResetGame();
                    }
                }
            }
            // Runs if an error occurs inside the try block
            catch (Exception ex)
            {
                // Displays error message if validation fails
                lblStatus.Text = "Error!: " + ex.Message;
                // Changes the label text color to red to indicate an error warning
                lblStatus.ForeColor = Color.Red;

                // Clears the selection after an error
                lstIngredients.ClearSelected();
            }
        }

        // Runs when the user clicks "Return to Sanrio Menu" in the toolbar
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            //Returns the user to the NewSanrioGUI form 
            NewSanrioGUI sanrioGUI = new NewSanrioGUI();

            // Hides the HelloKittyMaze Form while playing
            this.Hide();
            // Shows the NewSanrioGUI form
            sanrioGUI.ShowDialog();
            // Closes the Maze form
            this.Show();
        }

        // Runs when the user clicks the "Exit" menu option in the toolbar
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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
                // Closes all forms and shuts down the entire application 
                Application.Exit();
            }
        }

        // Runs when the user clicks the "Sanrio Quiz" menu option in the toolbar
        private void QuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Returns the user to the new Sanrio Main form 
            SanrioMain sanrioMain = new SanrioMain();

            // Hides the menu while playing 
            this.Hide();
            // Shows the Sanrio Main form
            sanrioMain.ShowDialog();
            // Shows the menu again when done taking quiz
            this.Show();
        }

        // Runs when the user clicks the "Grocery Shopping" menu option in the toolbar
        private void groceryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Stops looping background music 
            bgMusic.Stop();

            //Returns the user to the new Sanrio Grocery form 
            SanrioGroceryForm sanrioGrocery = new SanrioGroceryForm();

            this.Hide();
            // Shows the Sanrio Grocery form 
            sanrioGrocery.ShowDialog();
            // Closes the Sanrio Main form
            this.Show();
        }

        // Runs when the user clicks the "YouTube Link" menu option in the toolbar
        private void youTubeLinkToolStripMenuItem_Click(object sender, EventArgs e)
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

        // Runs when the user clicks the "Sanrio Store" menu option in the toolbar
        private void storeToolStripMenuItem_Click_1(object sender, EventArgs e)
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
    }
}

