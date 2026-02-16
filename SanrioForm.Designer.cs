namespace WindowsFormsApp2
{
    partial class NewSanrioGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSanrioGUI));
            this.PushMe_Click1 = new System.Windows.Forms.Button();
            this.btnResetGUI = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnSanrioMart = new System.Windows.Forms.Button();
            this.btnMaze = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PushMe_Click1
            // 
            this.PushMe_Click1.BackColor = System.Drawing.Color.LightPink;
            this.PushMe_Click1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PushMe_Click1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushMe_Click1.Location = new System.Drawing.Point(54, 161);
            this.PushMe_Click1.Name = "PushMe_Click1";
            this.PushMe_Click1.Size = new System.Drawing.Size(201, 80);
            this.PushMe_Click1.TabIndex = 0;
            this.PushMe_Click1.Text = "Take Sanrio Quiz";
            this.PushMe_Click1.UseVisualStyleBackColor = false;
            this.PushMe_Click1.Click += new System.EventHandler(this.Open_NewWin);
            // 
            // btnResetGUI
            // 
            this.btnResetGUI.BackColor = System.Drawing.Color.Plum;
            this.btnResetGUI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetGUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGUI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResetGUI.Location = new System.Drawing.Point(669, 31);
            this.btnResetGUI.Name = "btnResetGUI";
            this.btnResetGUI.Size = new System.Drawing.Size(164, 44);
            this.btnResetGUI.TabIndex = 1;
            this.btnResetGUI.Text = "Reset to Play Again!";
            this.btnResetGUI.UseVisualStyleBackColor = false;
            this.btnResetGUI.Click += new System.EventHandler(this.Open_NewWin);
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStore.Location = new System.Drawing.Point(630, 378);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(183, 58);
            this.btnStore.TabIndex = 2;
            this.btnStore.Text = "Sanrio Store ";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnSanrioMart
            // 
            this.btnSanrioMart.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSanrioMart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSanrioMart.Location = new System.Drawing.Point(272, 12);
            this.btnSanrioMart.Name = "btnSanrioMart";
            this.btnSanrioMart.Size = new System.Drawing.Size(210, 54);
            this.btnSanrioMart.TabIndex = 3;
            this.btnSanrioMart.Text = "Go Grocery Shopping";
            this.btnSanrioMart.UseVisualStyleBackColor = false;
            this.btnSanrioMart.Click += new System.EventHandler(this.btnSanrioMart_Click_1);
            // 
            // btnMaze
            // 
            this.btnMaze.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMaze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaze.Location = new System.Drawing.Point(83, 358);
            this.btnMaze.Name = "btnMaze";
            this.btnMaze.Size = new System.Drawing.Size(172, 55);
            this.btnMaze.TabIndex = 4;
            this.btnMaze.Text = "Play Maze Game";
            this.btnMaze.UseVisualStyleBackColor = false;
            this.btnMaze.Click += new System.EventHandler(this.btnMaze_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(744, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // NewSanrioGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 690);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMaze);
            this.Controls.Add(this.btnSanrioMart);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnResetGUI);
            this.Controls.Add(this.PushMe_Click1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewSanrioGUI";
            this.Text = "Sanrio GUI 1.5";
            this.Load += new System.EventHandler(this.NewSanrioGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PushMe_Click1;
        private System.Windows.Forms.Button btnResetGUI;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnSanrioMart;
        private System.Windows.Forms.Button btnMaze;
        private System.Windows.Forms.Button btnExit;
    }
}

