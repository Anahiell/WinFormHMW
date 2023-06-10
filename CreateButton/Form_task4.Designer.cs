namespace CreateButton
{
    partial class Form_task4
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
            components = new System.ComponentModel.Container();
            buttonStart = new Button();
            richTextBox1 = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            richTextFinish2 = new RichTextBox();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.MediumSpringGreen;
            buttonStart.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(264, 185);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(240, 48);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(233, 64);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(301, 92);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "                                Игра\n         Быстрый палец на диком западе\n                      у тебя 20 сек\n";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // richTextFinish2
            // 
            richTextFinish2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextFinish2.Location = new Point(233, 239);
            richTextFinish2.Name = "richTextFinish2";
            richTextFinish2.Size = new Size(301, 50);
            richTextFinish2.TabIndex = 1;
            richTextFinish2.Text = "";
            richTextFinish2.Visible = false;
            // 
            // Form_task4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextFinish2);
            Controls.Add(richTextBox1);
            Controls.Add(buttonStart);
            Name = "Form_task4";
            Text = "Form_task4";
            MouseClick += Form_task4_MouseClick;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart;
        private RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox richTextFinish2;
    }
}