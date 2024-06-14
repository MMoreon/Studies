using System.Windows.Forms;

namespace Lab._5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������� ������? �������� ��� ��� � textBox1:
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear(); // ������� ���������
                                     // ��� ��������� �������� ����� �� textBox1:
            string DirRoot = textBox1.Text;
            if (!Directory.Exists(DirRoot))
                MessageBox.Show("������� " + DirRoot + " �� ������!", "��������");
            else
            { // �������� ����������:
                treeView1.BeginUpdate();
                // ������� ����� ����:
                TreeNode TN = new TreeNode(DirRoot);
                //�������� ��������� ������������ ������:
                ProcessDirectory(DirRoot, TN);
                treeView1.Nodes.Add(TN); // ��������� ����
                treeView1.Nodes[0].Expand();//���������� ���
                treeView1.Select(); // �������� ���
                treeView1.EndUpdate();//��������� ����������
                label1.Text = "";
            }
        }

        /* ��� ���������- �� ���������� �������. ����� ��������� �������: */
        private void ProcessDirectory(string Dir, TreeNode Node)
        // Dir � ������� �������, Node-����� ������ ����
        {
            string[] SubDir; // ������ ��� ���� ������������
                             // ��������� ���� ������
            SubDir = Directory.GetDirectories(Dir);
            // ������������� ��� �����������:
            foreach (string SB in SubDir)
            {// ���������� ��� �������� ��������
                label1.Text = SB;
                // ���������������� �� ����������
                Application.DoEvents();
                // ������� ����
                TreeNode tempNode = new TreeNode(SB);
                // ���������� ��� ���������
                ProcessDirectory(SB, tempNode);
                // ��������� ����
                Node.Nodes.Add(tempNode);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listBox1.Items.Clear();
            string[] FileList; // ������ ���� ������
                               // ��������� ������:
            FileList = Directory.GetFiles(treeView1.SelectedNode.Text);
            // �������� ����� � ������ ListBox:
            foreach (string fileName in FileList)
                listBox1.Items.Add((Path.GetFileName(fileName)).ToLower());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�� ������������� ������ ����� ? ", "�����", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }
    }
}