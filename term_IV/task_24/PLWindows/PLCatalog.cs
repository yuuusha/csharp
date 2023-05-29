using System.Data.Common;

namespace PLWindows
{
    using CIAKOD24;
    using Microsoft.VisualBasic;
    using System.Diagnostics;

    public partial class PLCatalog : Form
    {
        ICatalogLogic catalog;
        SaveFileDialog saveFileDialog;
        OpenFileDialog openFileDialog;
        bool isShown;
        string onlyOneDisk;

        public PLCatalog()
        {
            catalog = DependencyResolver.CatalogLogic;
            InitializeComponent();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "��� ��������.dat";
            saveFileDialog.Filter = "Text (*.dat)|* .dat";
            openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "��� ��������.dat";
            openFileDialog.Filter = "Text (*.dat)|* .dat";
            isShown = false;
            onlyOneDisk = "";
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nameSong = Interaction.InputBox("������� ��� �����������: ", "��� �����������");

            try
            {
                string s = catalog.SearchSongs(nameSong);
                richTextBox1.Text = s;
                isShown = false;
                onlyOneDisk = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "�����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    catalog = DependencyResolver.OpenFile(openFileDialog.FileName);
                    ������ToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("������� �������", "��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ��������", "��������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = catalog.ShowCatalog();
            richTextBox1.Text = s;
            isShown = true;
            onlyOneDisk = "";
            if (s == "\n")
            {
                MessageBox.Show("������� ���� ��� �� ��������", "�������� �������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isShown = false;
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog = DependencyResolver.CreateFile();
            MessageBox.Show("������� �������", "��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.FileName != "��� ��������.dat")
                {
                    catalog.Save(openFileDialog.FileName);
                    MessageBox.Show("������� ���������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (saveFileDialog.FileName == "��� ��������.dat")
                {
                    ������������ToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    catalog.Save(saveFileDialog.FileName);
                    MessageBox.Show("������� ���������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    catalog.Save(saveFileDialog.FileName);
                    MessageBox.Show("������� ���������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ����������: ", "���������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "\n";
            onlyOneDisk = "";
            isShown = false;
        }

        private void PLCatalog_SizeChanged(object sender, EventArgs e)
        {
            richTextBox1.Size = new Size(ClientRectangle.Width - 25, ClientRectangle.Height - 45);
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog.SortBySongs();
            string s = catalog.ShowCatalog();
            if (s == "\n")
            {
                MessageBox.Show("������� ���� ��� �� ��������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (onlyOneDisk != "") richTextBox1.Text = catalog.ShowDisk(onlyOneDisk);
                else if (isShown) richTextBox1.Text = s;
                else if (!isShown) richTextBox1.Text = "\n";
                MessageBox.Show("������� �������������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog.SortBySingers();
            string s = catalog.ShowCatalog();
            if (s == "\n")
            {
                MessageBox.Show("������� ���� ��� �� ��������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (onlyOneDisk != "") richTextBox1.Text = catalog.ShowDisk(onlyOneDisk);
                else if (isShown) richTextBox1.Text = s;
                else if (!isShown) richTextBox1.Text = "\n";
                MessageBox.Show("������� �������������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nameDisk = Interaction.InputBox("������� �������� �����: ", "�������� �����");
            try
            {
                richTextBox1.Text = catalog.ShowDisk(nameDisk);
                onlyOneDisk = nameDisk;
                isShown = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "�������� �����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isShown = true;
            }

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PLCatalog_FormClosing(sender, e);
        }

        private void PLCatalog_FormClosing(object sender, EventArgs e)
        {
            if (MessageBox.Show("��������� ����?", "��������", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ���������ToolStripMenuItem_Click(sender, e);
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nameDisk = Interaction.InputBox("������� �������� �����: ", "�������� �����");
            try
            {
                catalog.AddDisk(nameDisk);
                MessageBox.Show("������� ���������", "�������� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isShown) richTextBox1.Text = catalog.ShowCatalog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "�������� �����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm form = new InputForm();
            form.ShowDialog();

            try
            {
                catalog.AddSong(form.Name_Disk, form.Name_Song, form.Name_Singer);
                MessageBox.Show("������� ���������", "�������� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isShown) richTextBox1.Text = catalog.ShowCatalog();
                else if (onlyOneDisk != "") richTextBox1.Text = catalog.ShowDisk(onlyOneDisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ����������: " + ex.Message, "����������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nameDisk = Interaction.InputBox("������� �������� �����: ", "�������� �����");
            try
            {
                catalog.DeleteDisk(nameDisk);
                MessageBox.Show("������� �������", "������� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isShown) richTextBox1.Text = catalog.ShowCatalog();
                if (onlyOneDisk == nameDisk) richTextBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "�������� �����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm form = new InputForm();
            form.ShowDialog();

            try
            {
                catalog.DeleteSong(form.Name_Disk, form.Name_Song, form.Name_Singer);
                MessageBox.Show("������� �������", "������� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isShown) richTextBox1.Text = catalog.ShowCatalog();
                else if (onlyOneDisk != "") richTextBox1.Text = catalog.ShowDisk(onlyOneDisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��������: " + ex.Message, "��������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}