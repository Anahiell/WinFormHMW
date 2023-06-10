namespace CreateButton
{
    partial class Form_tsk2
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
            button_catch = new Button();
            textBox1 = new TextBox();
            button_exit = new Button();
            SuspendLayout();
            // 
            // button_catch
            // 
            button_catch.Location = new Point(447, 184);
            button_catch.Name = "button_catch";
            button_catch.Size = new Size(113, 67);
            button_catch.TabIndex = 0;
            button_catch.Text = "NO";
            button_catch.UseVisualStyleBackColor = true;
            button_catch.MouseEnter += button_catch_MouseEnter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(204, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 29);
            textBox1.TabIndex = 1;
            textBox1.Text = "Эта таска тянет на 12?";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(138, 184);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(113, 67);
            button_exit.TabIndex = 2;
            button_exit.Text = "YES";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // Form_tsk2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 492);
            Controls.Add(button_exit);
            Controls.Add(textBox1);
            Controls.Add(button_catch);
            Name = "Form_tsk2";
            Text = "Form_tsk2";
            Load += Form_tsk2_Load;
            Enter += Form_tsk2_Enter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_catch;
        private TextBox textBox1;
        private Button button_exit;
    }
}