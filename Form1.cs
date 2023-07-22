using System.IO.Enumeration;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//��� ������� ���������� ���� � �������� �����(�������������� �� ����� ������������)
            TreeNode n = new TreeNode("Deckstop");
            treeView1.Nodes.Add(n);
           AddNodes(pathDesktop, n);
        }
        private void AddNodes(string dirPath, TreeNode parentNode)
        {
            //Directory.GetDirectories ���������� ����� ����� �� ������� �����
            string[] direct = Directory.GetDirectories(dirPath);
            //� ��� ���������� ����� ������
            string[] files = Directory.GetFiles(dirPath);

            //��������
            foreach (string dir in direct)
            {
                TreeNode directNode = new TreeNode(Path.GetFileName(dir), 1, 1);
                parentNode.Nodes.Add(directNode);
                AddNodes(dir, directNode);
            }

            foreach (string file in files)
            {
                TreeNode fileNode = new TreeNode(Path.GetFileName(file), 2, 2);
                parentNode.Nodes.Add(fileNode);
            }
        }
    }
}