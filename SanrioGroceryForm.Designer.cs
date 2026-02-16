namespace WindowsFormsApp2
{
    partial class SanrioGroceryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanrioGroceryForm));
            this.btnCheckout = new System.Windows.Forms.Button();
            this.checkedListBoxGroceries = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShopAgain = new System.Windows.Forms.Button();
            this.btnStopShopping = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mazeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCheckout.Font = new System.Drawing.Font("Liberation Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.MistyRose;
            this.btnCheckout.Location = new System.Drawing.Point(593, 484);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(218, 70);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Checkout ";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // checkedListBoxGroceries
            // 
            this.checkedListBoxGroceries.AllowDrop = true;
            this.checkedListBoxGroceries.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkedListBoxGroceries.BackColor = System.Drawing.Color.Bisque;
            this.checkedListBoxGroceries.CheckOnClick = true;
            this.checkedListBoxGroceries.ColumnWidth = 230;
            this.checkedListBoxGroceries.Font = new System.Drawing.Font("Liberation Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxGroceries.ForeColor = System.Drawing.Color.RosyBrown;
            this.checkedListBoxGroceries.FormattingEnabled = true;
            this.checkedListBoxGroceries.HorizontalScrollbar = true;
            this.checkedListBoxGroceries.Items.AddRange(new object[] {
            "Apple Pie",
            "Apples",
            "Baking Flour",
            "Blueberry Cheesecake",
            "Butter",
            "Chocolate Pudding",
            "Cookies ",
            "Eggs",
            "Glazed Donuts",
            "Green Tea Ice Cream",
            "Green Tea Matcha",
            "Kiwi",
            "Lemon Tarts",
            "Maple Syrup",
            "Milk",
            "Pancake Mix",
            "Strawberries",
            "Sugar",
            "Sushi Bento",
            "Watermelon Lemonade",
            "Whipped Cream"});
            this.checkedListBoxGroceries.Location = new System.Drawing.Point(54, 241);
            this.checkedListBoxGroceries.MultiColumn = true;
            this.checkedListBoxGroceries.Name = "checkedListBoxGroceries";
            this.checkedListBoxGroceries.ScrollAlwaysVisible = true;
            this.checkedListBoxGroceries.Size = new System.Drawing.Size(491, 355);
            this.checkedListBoxGroceries.TabIndex = 1;
            this.checkedListBoxGroceries.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxGroceries_ItemCheck);
            this.checkedListBoxGroceries.Click += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Liberation Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Sanrio Mart!";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(107, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please select your grocery items below and note that you can only select up to 10" +
    " items per purchase. If an item is out of stock, please select another item.";
            // 
            // btnShopAgain
            // 
            this.btnShopAgain.BackColor = System.Drawing.Color.PowderBlue;
            this.btnShopAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopAgain.Location = new System.Drawing.Point(636, 313);
            this.btnShopAgain.Name = "btnShopAgain";
            this.btnShopAgain.Size = new System.Drawing.Size(129, 36);
            this.btnShopAgain.TabIndex = 4;
            this.btnShopAgain.Text = "Shop Again";
            this.btnShopAgain.UseVisualStyleBackColor = false;
            this.btnShopAgain.Click += new System.EventHandler(this.btnShopAgain_Click);
            // 
            // btnStopShopping
            // 
            this.btnStopShopping.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStopShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopShopping.Location = new System.Drawing.Point(640, 391);
            this.btnStopShopping.Name = "btnStopShopping";
            this.btnStopShopping.Size = new System.Drawing.Size(124, 36);
            this.btnStopShopping.TabIndex = 5;
            this.btnStopShopping.Text = "Stop Shopping";
            this.btnStopShopping.UseVisualStyleBackColor = false;
            this.btnStopShopping.Click += new System.EventHandler(this.btnStopShopping_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.extrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.returnToolStripMenuItem.Text = "Return to Sanrio Menu";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quizToolStripMenuItem,
            this.mazeToolStripMenuItem});
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.gamesToolStripMenuItem.Text = "Games";
            // 
            // quizToolStripMenuItem
            // 
            this.quizToolStripMenuItem.Name = "quizToolStripMenuItem";
            this.quizToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quizToolStripMenuItem.Text = "Sanrio Quiz";
            this.quizToolStripMenuItem.Click += new System.EventHandler(this.quizToolStripMenuItem_Click);
            // 
            // mazeToolStripMenuItem
            // 
            this.mazeToolStripMenuItem.Name = "mazeToolStripMenuItem";
            this.mazeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mazeToolStripMenuItem.Text = "Maze Game";
            this.mazeToolStripMenuItem.Click += new System.EventHandler(this.mazeToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youTubeLinkToolStripMenuItem,
            this.storeToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // youTubeLinkToolStripMenuItem
            // 
            this.youTubeLinkToolStripMenuItem.Name = "youTubeLinkToolStripMenuItem";
            this.youTubeLinkToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.youTubeLinkToolStripMenuItem.Text = "Hello Kitty YouTube Link";
            this.youTubeLinkToolStripMenuItem.Click += new System.EventHandler(this.youTubeLinkToolStripMenuItem_Click);
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.storeToolStripMenuItem.Text = "Sanrio Store";
            this.storeToolStripMenuItem.Click += new System.EventHandler(this.storeToolStripMenuItem_Click);
            // 
            // SanrioGroceryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 668);
            this.Controls.Add(this.btnStopShopping);
            this.Controls.Add(this.btnShopAgain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxGroceries);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SanrioGroceryForm";
            this.Text = "Sanrio Mart";
            this.Load += new System.EventHandler(this.SanrioGroceryForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.CheckedListBox checkedListBoxGroceries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShopAgain;
        private System.Windows.Forms.Button btnStopShopping;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mazeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youTubeLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
    }
}