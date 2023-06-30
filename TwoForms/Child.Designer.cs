namespace TwoForms
{
    partial class Child
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
            textBoxChild = new TextBox();
            SuspendLayout();
            // 
            // textBoxChild
            // 
            textBoxChild.Location = new Point(145, 471);
            textBoxChild.Name = "textBoxChild";
            textBoxChild.Size = new Size(715, 23);
            textBoxChild.TabIndex = 0;
            textBoxChild.TextChanged += textBoxChild_TextChanged;
            // 
            // Child
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.child;
            ClientSize = new Size(599, 430);
            Controls.Add(textBoxChild);
            Location = new Point(1000, 500);
            Name = "Child";
            StartPosition = FormStartPosition.Manual;
            Text = "Child";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxChild;
    }
}