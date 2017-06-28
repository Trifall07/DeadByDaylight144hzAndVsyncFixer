namespace DeadByDaylight144hz
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pathLabel = new System.Windows.Forms.Label();
            this.instructionLabel1 = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.pathDisplayBox = new System.Windows.Forms.TextBox();
            this.changePathButton = new System.Windows.Forms.Button();
            this.editFileButton1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 65);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(72, 13);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Current Path :";
            // 
            // instructionLabel1
            // 
            this.instructionLabel1.AutoSize = true;
            this.instructionLabel1.Location = new System.Drawing.Point(270, 9);
            this.instructionLabel1.Name = "instructionLabel1";
            this.instructionLabel1.Size = new System.Drawing.Size(196, 13);
            this.instructionLabel1.TabIndex = 1;
            this.instructionLabel1.Text = "Select Dead By Daylight Engine.ini Path";
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(96, 34);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(546, 13);
            this.helpLabel.TabIndex = 2;
            this.helpLabel.Text = "(Commonly: C:\\Users\\USERNAME\\AppData\\Local\\DeadByDaylight\\Saved\\Config\\WindowsNoE" +
    "ditor\\Engine.ini)";
            // 
            // pathDisplayBox
            // 
            this.pathDisplayBox.Enabled = false;
            this.pathDisplayBox.Location = new System.Drawing.Point(81, 62);
            this.pathDisplayBox.Name = "pathDisplayBox";
            this.pathDisplayBox.ReadOnly = true;
            this.pathDisplayBox.Size = new System.Drawing.Size(560, 20);
            this.pathDisplayBox.TabIndex = 3;
            this.pathDisplayBox.Text = "No Path Selected";
            // 
            // changePathButton
            // 
            this.changePathButton.Location = new System.Drawing.Point(647, 60);
            this.changePathButton.Name = "changePathButton";
            this.changePathButton.Size = new System.Drawing.Size(82, 23);
            this.changePathButton.TabIndex = 4;
            this.changePathButton.Text = "Change Path";
            this.changePathButton.UseVisualStyleBackColor = true;
            this.changePathButton.Click += new System.EventHandler(this.changePathButton_Click);
            // 
            // editFileButton1
            // 
            this.editFileButton1.Location = new System.Drawing.Point(293, 100);
            this.editFileButton1.Name = "editFileButton1";
            this.editFileButton1.Size = new System.Drawing.Size(137, 23);
            this.editFileButton1.TabIndex = 5;
            this.editFileButton1.Text = "Set 144hz and No VSync";
            this.editFileButton1.UseVisualStyleBackColor = true;
            this.editFileButton1.Click += new System.EventHandler(this.editFileButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 135);
            this.Controls.Add(this.editFileButton1);
            this.Controls.Add(this.changePathButton);
            this.Controls.Add(this.pathDisplayBox);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.instructionLabel1);
            this.Controls.Add(this.pathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 174);
            this.MinimumSize = new System.Drawing.Size(750, 174);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dead By Daylight 144hz & VSync Disable | Made By Trifall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label instructionLabel1;
        private System.Windows.Forms.Label helpLabel;
        public System.Windows.Forms.TextBox pathDisplayBox;
        private System.Windows.Forms.Button changePathButton;
        private System.Windows.Forms.Button editFileButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

