namespace CreateButton
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
            button_Task1 = new Button();
            buttonTask2 = new Button();
            button_task3 = new Button();
            button_task4 = new Button();
            SuspendLayout();
            // 
            // button_Task1
            // 
            button_Task1.Location = new Point(24, 24);
            button_Task1.Name = "button_Task1";
            button_Task1.Size = new Size(141, 73);
            button_Task1.TabIndex = 0;
            button_Task1.Text = "Task #1";
            button_Task1.UseVisualStyleBackColor = true;
            button_Task1.Click += button1_Click;
            button_Task1.MouseClick += button_Task1_MouseClick;
            // 
            // buttonTask2
            // 
            buttonTask2.Location = new Point(204, 24);
            buttonTask2.Name = "buttonTask2";
            buttonTask2.Size = new Size(135, 73);
            buttonTask2.TabIndex = 1;
            buttonTask2.Text = "Task #2";
            buttonTask2.UseVisualStyleBackColor = true;
            buttonTask2.Click += buttonTask2_Click;
            // 
            // button_task3
            // 
            button_task3.Location = new Point(30, 147);
            button_task3.Name = "button_task3";
            button_task3.Size = new Size(135, 73);
            button_task3.TabIndex = 3;
            button_task3.Text = "Task #3";
            button_task3.UseVisualStyleBackColor = true;
            button_task3.Click += button_task3_Click;
            // 
            // button_task4
            // 
            button_task4.Location = new Point(204, 147);
            button_task4.Name = "button_task4";
            button_task4.Size = new Size(135, 73);
            button_task4.TabIndex = 4;
            button_task4.Text = "Task #4";
            button_task4.UseVisualStyleBackColor = true;
            button_task4.Click += button_task4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(406, 263);
            Controls.Add(button_task4);
            Controls.Add(button_task3);
            Controls.Add(buttonTask2);
            Controls.Add(button_Task1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_Task1;
        private Button buttonTask2;
        private Button button_task3;
        private Button button_task4;
    }
}