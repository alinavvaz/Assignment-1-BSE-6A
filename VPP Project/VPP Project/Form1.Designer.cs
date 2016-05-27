namespace VPP_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Note = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Extract = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(12, 19);
            this.DataTextBox.Multiline = true;
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(298, 122);
            this.DataTextBox.TabIndex = 1;
            this.DataTextBox.TextChanged += new System.EventHandler(this.DataTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearScreenToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearScreenToolStripMenuItem
            // 
            this.clearScreenToolStripMenuItem.Name = "clearScreenToolStripMenuItem";
            this.clearScreenToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clearScreenToolStripMenuItem.Text = "Clear Screen";
            this.clearScreenToolStripMenuItem.Click += new System.EventHandler(this.clearScreenToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openToolStripMenuItem.Text = "Open Image";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveToolStripMenuItem.Image = global::VPP_Project.Properties.Resources.save_png_16x16;
            this.saveToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveToolStripMenuItem.Text = "Save Image";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.Location = new System.Drawing.Point(12, 279);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(50, 16);
            this.Note.TabIndex = 6;
            this.Note.Text = "Note:";
            this.Note.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.Extract);
            this.groupBox1.Controls.Add(this.DataTextBox);
            this.groupBox1.Controls.Add(this.Hide);
            this.groupBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(360, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 265);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(227, 223);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(83, 29);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // Extract
            // 
            this.Extract.Image = global::VPP_Project.Properties.Resources.Pictogram_output_png_24x24;
            this.Extract.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Extract.Location = new System.Drawing.Point(168, 170);
            this.Extract.Name = "Extract";
            this.Extract.Size = new System.Drawing.Size(142, 35);
            this.Extract.TabIndex = 3;
            this.Extract.Text = "EXTRACT";
            this.Extract.UseVisualStyleBackColor = true;
            this.Extract.Click += new System.EventHandler(this.Extract_Click);
            // 
            // Hide
            // 
            this.Hide.Image = global::VPP_Project.Properties.Resources.Pictogram_input_png_24x24;
            this.Hide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Hide.Location = new System.Drawing.Point(12, 170);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(142, 35);
            this.Hide.TabIndex = 2;
            this.Hide.Text = "HIDE";
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImagePictureBox);
            this.groupBox2.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 221);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ImagePictureBox.Image")));
            this.ImagePictureBox.Location = new System.Drawing.Point(12, 19);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(307, 186);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePictureBox.TabIndex = 0;
            this.ImagePictureBox.TabStop = false;
            this.ImagePictureBox.Click += new System.EventHandler(this.ImagePictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(701, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Steganograph - Hide a secret message in an image!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Button Extract;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ToolStripMenuItem clearScreenToolStripMenuItem;
    }
}

