namespace Maze
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Helth_point_bar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.scoreImgn = new System.Windows.Forms.ToolStripStatusLabel();
            this.scoreStLabl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolsStep = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLook = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Helth_point_bar,
            this.toolStripStatusLabel2,
            this.scoreImgn,
            this.scoreStLabl,
            this.toolsStep,
            this.timeLook});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(511, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::Maze.Properties.Resources.hp;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            // 
            // Helth_point_bar
            // 
            this.Helth_point_bar.Name = "Helth_point_bar";
            this.Helth_point_bar.Size = new System.Drawing.Size(100, 16);
            this.Helth_point_bar.Value = 100;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // scoreImgn
            // 
            this.scoreImgn.Image = global::Maze.Properties.Resources.star;
            this.scoreImgn.Name = "scoreImgn";
            this.scoreImgn.Size = new System.Drawing.Size(16, 17);
            // 
            // scoreStLabl
            // 
            this.scoreStLabl.Name = "scoreStLabl";
            this.scoreStLabl.Size = new System.Drawing.Size(73, 17);
            this.scoreStLabl.Text = "none/empty";
            // 
            // toolsStep
            // 
            this.toolsStep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolsStep.Name = "toolsStep";
            this.toolsStep.Size = new System.Drawing.Size(54, 17);
            this.toolsStep.Text = "non/non";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLook
            // 
            this.timeLook.BackColor = System.Drawing.Color.GreenYellow;
            this.timeLook.Name = "timeLook";
            this.timeLook.Size = new System.Drawing.Size(45, 17);
            this.timeLook.Text = "timOut";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 397);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar Helth_point_bar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel scoreImgn;
        private System.Windows.Forms.ToolStripStatusLabel scoreStLabl;
        private System.Windows.Forms.ToolStripStatusLabel toolsStep;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel timeLook;
    }
}

