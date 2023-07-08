namespace Screnshot_Localz
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            saveScreenshot = new SaveFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            ENbutton2 = new Button();
            UAbutton3 = new Button();
            PLbutton4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 31);
            button1.Name = "button1";
            button1.Size = new Size(132, 52);
            button1.TabIndex = 0;
            button1.Text = "capture";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // saveScreenshot
            // 
            saveScreenshot.Filter = "PNG File|*.png";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // ENbutton2
            // 
            ENbutton2.Location = new Point(185, 10);
            ENbutton2.Name = "ENbutton2";
            ENbutton2.Size = new Size(31, 23);
            ENbutton2.TabIndex = 1;
            ENbutton2.Text = "EN";
            ENbutton2.UseVisualStyleBackColor = true;
            ENbutton2.Click += button2_Click;
            // 
            // UAbutton3
            // 
            UAbutton3.Location = new Point(185, 46);
            UAbutton3.Name = "UAbutton3";
            UAbutton3.Size = new Size(31, 23);
            UAbutton3.TabIndex = 1;
            UAbutton3.Text = "UA";
            UAbutton3.UseVisualStyleBackColor = true;
            UAbutton3.Click += button3_Click;
            // 
            // PLbutton4
            // 
            PLbutton4.Location = new Point(185, 85);
            PLbutton4.Name = "PLbutton4";
            PLbutton4.Size = new Size(31, 23);
            PLbutton4.TabIndex = 1;
            PLbutton4.Text = "PL";
            PLbutton4.UseVisualStyleBackColor = true;
            PLbutton4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 125);
            Controls.Add(PLbutton4);
            Controls.Add(UAbutton3);
            Controls.Add(ENbutton2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private SaveFileDialog saveScreenshot;
        FolderBrowserDialog dlg = new FolderBrowserDialog();
        private int count;
        private System.Windows.Forms.Timer timer1;
        private string str;
        private Button ENbutton2;
        private Button UAbutton3;
        private Button PLbutton4;
    }
}