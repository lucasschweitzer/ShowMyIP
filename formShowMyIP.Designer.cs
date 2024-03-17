namespace ShowMyIP
{
    partial class formShowMyIP
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
            btnShowIP = new Button();
            SuspendLayout();
            // 
            // btnShowIP
            // 
            btnShowIP.BackColor = SystemColors.ControlDark;
            btnShowIP.Location = new Point(12, 12);
            btnShowIP.Name = "btnShowIP";
            btnShowIP.Size = new Size(96, 49);
            btnShowIP.TabIndex = 0;
            btnShowIP.Text = "Mostrar IP";
            btnShowIP.UseVisualStyleBackColor = false;
            btnShowIP.Click += btnShowIP_Click;
            // 
            // formShowMyIP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(297, 193);
            Controls.Add(btnShowIP);
            Name = "formShowMyIP";
            Text = "Show My IP";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowIP;
    }
}
