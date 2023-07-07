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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // saveScreenshot
            // 
            resources.ApplyResources(saveScreenshot, "saveScreenshot");
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // ENbutton2
            // 
            resources.ApplyResources(ENbutton2, "ENbutton2");
            ENbutton2.Name = "ENbutton2";
            ENbutton2.UseVisualStyleBackColor = true;
            ENbutton2.Click += button2_Click;
            // 
            // UAbutton3
            // 
            resources.ApplyResources(UAbutton3, "UAbutton3");
            UAbutton3.Name = "UAbutton3";
            UAbutton3.UseVisualStyleBackColor = true;
            UAbutton3.Click += button3_Click;
            // 
            // PLbutton4
            // 
            resources.ApplyResources(PLbutton4, "PLbutton4");
            PLbutton4.Name = "PLbutton4";
            PLbutton4.UseVisualStyleBackColor = true;
            PLbutton4.Click += button4_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PLbutton4);
            Controls.Add(UAbutton3);
            Controls.Add(ENbutton2);
            Controls.Add(button1);
            Name = "Form1";
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