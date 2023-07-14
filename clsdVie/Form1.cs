namespace clsdVie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListView listView = new ListView();
            listView.Bounds = new Rectangle(new Point(10, 10), new Size(400, 200));
            listView.View = View.Details;
            listView.LabelEdit = true;
            listView.AllowColumnReorder = true;
            listView.CheckBoxes = true;

            ListViewItem[] items = new ListViewItem[5];
            for (int i=0;i<5;i++)
            {
                items[i]=new ListViewItem();
            }
            items[0]=new ListViewItem("������� �� ����", 0);
            items[0].Checked = true;
            items[0].SubItems.Add("� ������");
            items[0].SubItems.Add("0");

            items[1]= new ListViewItem("����� ����� �� �����", 1);
            items[1].SubItems.Add("�� ��� ������ �������");
            items[1].SubItems.Add("150");

            items[2] = new ListViewItem("����", 2);
            items[2].SubItems.Add("���� ���� �...");
            items[2].SubItems.Add("5���");

            items[3] = new ListViewItem("����� ��������", 3);
            items[3].SubItems.Add("Honda SBR 1000RR");
            items[3].SubItems.Add("125000");

            items[4]= new ListViewItem("��������",4);
            items[4].SubItems.Add("������� �����");
            items[4].SubItems.Add("0");

            listView.Columns.Add("�������", 170, HorizontalAlignment.Left);
            listView.Columns.Add("Comments", 120, HorizontalAlignment.Left);
            listView.Columns.Add("Price", 100, HorizontalAlignment.Left);


            listView.Items.AddRange(items);

            ImageList imgSmall = new ImageList();
            ImageList imgLarge = new ImageList();

            imgSmall.Images.Add(Bitmap.FromFile("�����.png"));
            imgSmall.Images.Add(Bitmap.FromFile("�����.png"));
            imgSmall.Images.Add(Bitmap.FromFile("����.png"));
            imgSmall.Images.Add(Bitmap.FromFile("��������.png"));
            imgSmall.Images.Add(Bitmap.FromFile("��������.png"));

            listView.SmallImageList = imgSmall;
            listView.LargeImageList = imgLarge;

            this.Controls.Add(listView);
            Width = 430;
            Height = 255;
        }
    }
}