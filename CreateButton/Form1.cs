namespace CreateButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Task1_MouseClick(object sender, MouseEventArgs e)
        {
            Form_tsk1 frm = new Form_tsk1();
            frm.Show();

        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            Form_tsk2 frm = new Form_tsk2();
            frm.Show();

        }

        private void button_task3_Click(object sender, EventArgs e)
        {
            Form_task3 frm = new Form_task3();
            frm.Show();
        }

        private void button_task4_Click(object sender, EventArgs e)
        {
            Form_task4 frm = new Form_task4();
            frm.Show();
        }
    }
}