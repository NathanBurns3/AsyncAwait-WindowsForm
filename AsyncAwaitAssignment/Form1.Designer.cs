namespace AsyncAwaitAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBook1 = new System.Windows.Forms.Label();
            this.lblBook2 = new System.Windows.Forms.Label();
            this.tbBook1 = new System.Windows.Forms.TextBox();
            this.tbBook2 = new System.Windows.Forms.TextBox();
            this.lbBook1 = new System.Windows.Forms.ListBox();
            this.lbBook2 = new System.Windows.Forms.ListBox();
            this.btnBook1Browse = new System.Windows.Forms.Button();
            this.btnBook2Browse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblBook1
            // 
            this.lblBook1.AutoSize = true;
            this.lblBook1.Location = new System.Drawing.Point(50, 69);
            this.lblBook1.Name = "lblBook1";
            this.lblBook1.Size = new System.Drawing.Size(88, 32);
            this.lblBook1.TabIndex = 0;
            this.lblBook1.Text = "Book 1";
            // 
            // lblBook2
            // 
            this.lblBook2.AutoSize = true;
            this.lblBook2.Location = new System.Drawing.Point(801, 69);
            this.lblBook2.Name = "lblBook2";
            this.lblBook2.Size = new System.Drawing.Size(88, 32);
            this.lblBook2.TabIndex = 1;
            this.lblBook2.Text = "Book 2";
            // 
            // tbBook1
            // 
            this.tbBook1.Location = new System.Drawing.Point(134, 66);
            this.tbBook1.Name = "tbBook1";
            this.tbBook1.Size = new System.Drawing.Size(407, 39);
            this.tbBook1.TabIndex = 2;
            // 
            // tbBook2
            // 
            this.tbBook2.Location = new System.Drawing.Point(885, 66);
            this.tbBook2.Name = "tbBook2";
            this.tbBook2.Size = new System.Drawing.Size(407, 39);
            this.tbBook2.TabIndex = 3;
            // 
            // lbBook1
            // 
            this.lbBook1.FormattingEnabled = true;
            this.lbBook1.ItemHeight = 32;
            this.lbBook1.Location = new System.Drawing.Point(50, 244);
            this.lbBook1.Name = "lbBook1";
            this.lbBook1.Size = new System.Drawing.Size(647, 580);
            this.lbBook1.TabIndex = 4;
            // 
            // lbBook2
            // 
            this.lbBook2.FormattingEnabled = true;
            this.lbBook2.ItemHeight = 32;
            this.lbBook2.Location = new System.Drawing.Point(801, 244);
            this.lbBook2.Name = "lbBook2";
            this.lbBook2.Size = new System.Drawing.Size(647, 580);
            this.lbBook2.TabIndex = 5;
            // 
            // btnBook1Browse
            // 
            this.btnBook1Browse.Location = new System.Drawing.Point(547, 62);
            this.btnBook1Browse.Name = "btnBook1Browse";
            this.btnBook1Browse.Size = new System.Drawing.Size(150, 46);
            this.btnBook1Browse.TabIndex = 6;
            this.btnBook1Browse.Text = "Browse";
            this.btnBook1Browse.UseVisualStyleBackColor = true;
            this.btnBook1Browse.Click += new System.EventHandler(this.btnBook1Browse_Click);
            // 
            // btnBook2Browse
            // 
            this.btnBook2Browse.Location = new System.Drawing.Point(1298, 62);
            this.btnBook2Browse.Name = "btnBook2Browse";
            this.btnBook2Browse.Size = new System.Drawing.Size(150, 46);
            this.btnBook2Browse.TabIndex = 7;
            this.btnBook2Browse.Text = "Browse";
            this.btnBook2Browse.UseVisualStyleBackColor = true;
            this.btnBook2Browse.Click += new System.EventHandler(this.btnBook2Browse_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 155);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(801, 155);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 46);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 907);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBook2Browse);
            this.Controls.Add(this.btnBook1Browse);
            this.Controls.Add(this.lbBook2);
            this.Controls.Add(this.lbBook1);
            this.Controls.Add(this.tbBook2);
            this.Controls.Add(this.tbBook1);
            this.Controls.Add(this.lblBook2);
            this.Controls.Add(this.lblBook1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBook1;
        private Label lblBook2;
        private TextBox tbBook1;
        private TextBox tbBook2;
        private ListBox lbBook1;
        private ListBox lbBook2;
        private Button btnBook1Browse;
        private Button btnBook2Browse;
        private Button btnExit;
        private Button btnSubmit;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
    }
}