namespace WinReadCSV
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
            btnReadCSV = new Button();
            btnCreateCSV = new Button();
            SuspendLayout();
            // 
            // btnReadCSV
            // 
            btnReadCSV.Location = new Point(291, 137);
            btnReadCSV.Name = "btnReadCSV";
            btnReadCSV.Size = new Size(112, 62);
            btnReadCSV.TabIndex = 0;
            btnReadCSV.Text = "Read CSV";
            btnReadCSV.UseVisualStyleBackColor = true;
            btnReadCSV.Click += btnReadCSV_Click;
            // 
            // btnCreateCSV
            // 
            btnCreateCSV.Location = new Point(291, 59);
            btnCreateCSV.Name = "btnCreateCSV";
            btnCreateCSV.Size = new Size(112, 62);
            btnCreateCSV.TabIndex = 1;
            btnCreateCSV.Text = "Create CSV";
            btnCreateCSV.UseVisualStyleBackColor = true;
            btnCreateCSV.Click += btnCreateCSV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 261);
            Controls.Add(btnCreateCSV);
            Controls.Add(btnReadCSV);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReadCSV;
        private Button btnCreateCSV;
    }
}
