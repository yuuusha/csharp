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
            saveFileDialog.FileName = "Без названия.dat";
            saveFileDialog.Filter = "Text (*.dat)|* .dat";
            openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Без названия.dat";
            openFileDialog.Filter = "Text (*.dat)|* .dat";
            isShown = false;
            onlyOneDisk = "";
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nameSong = Interaction.InputBox("Введите имя исполнителя: ", "Имя исполнителя");

            try
            {
                string s = catalog.SearchSongs(nameSong);
                richTextBox1.Text = s;
                isShown = false;
                onlyOneDisk = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    catalog = DependencyResolver.OpenFile(openFileDialog.FileName);
                    скрытьToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("Успешно открыто", "Открытие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии", "Открытие", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void показатьКаталогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = catalog.ShowCatalog();
            richTextBox1.Text = s;
            isShown = true;
            onlyOneDisk = "";
            if (s == "\n")
            {
                MessageBox.Show("Каталог пуст или не загружен", "Показать каталог", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isShown = false;
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog = DependencyResolver.CreateFile();
            MessageBox.Show("Успешно создано", "Создание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.FileName != "Без названия.dat")
                {
                    catalog.Save(openFileDialog.FileName);
                    MessageBox.Show("Успешно сохранено", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (saveFileDialog.FileName == "Без названия.dat")
                {
                    сохранитьКакToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    catalog.Save(saveFileDialog.FileName);
                    MessageBox.Show("Успешно сохранено", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении", "Сохранить", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    catalog.Save(saveFileDialog.FileName);
                    MessageBox.Show("Успешно сохранено", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: ", "Сохранить", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void скрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "\n";
            onlyOneDisk = "";
            isShown = false;
        }

        private void PLCatalog_SizeChanged(object sender, EventArgs e)
        {
            richTextBox1.Size = new Size(ClientRectangle.Width - 25, ClientRectangle.Height - 45);
        }

        private void поПеснямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog.SortBySongs();
            string s = catalog.ShowCatalog();
            if (s == "\n")
            {
                MessageBox.Show("Каталог пуст или не загружен", "Сортировка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (onlyOneDisk != "") richTextBox1.Text = catalog.ShowDisk(onlyOneDisk);
                else if (isShown) richTextBox1.Text = s;
                else if (!isShown) richTextBox1.Text = "\n";
                MessageBox.Show("Успешно отсортировано", "Сортировка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void поИсполнителямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog.SortBySingers();
            string s = catalog.ShowCatalog();
            if (s == "\n")
            {
                MessageBox.Show("Каталог пуст или не загружен", "Сортировка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (onlyOneDisk != "") richTextBox1.Text = catalog.ShowDisk(onlyOneDisk);
                else if (isShown) richTextBox1.Text = s;
                else if (!isShown) richTextBox1.Text = "\n";
                MessageBox.Show("Успешно отсортировано", "Сортировка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void показатьДискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nameDisk = Interaction.InputBox("Введите название диска: ", "Название диска");
            try
            {
                richTextBox1.Text = catalog.ShowDisk(nameDisk);
                onlyOneDisk = nameDisk;
                isShown = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Название диска", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isShown = true;
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PLCatalog_FormClosing(sender, e);
        }

        private void PLCatalog_FormClosing(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить файл?", "Закрытие", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                сохранитьToolStripMenuItem_Click(sender, e);
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        private void добавитьДискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nameDisk = Interaction.InputBox("Введите название диска: ", "Название диска");
            try
            {
                catalog.AddDisk(nameDisk);
                MessageBox.Show("Успешно добавлено", "Добавить диск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isShown) richTextBox1.Text = catalog.ShowCatalog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Название диска", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void добавитьПеснюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm form = new InputForm();
            form.ShowDialog();

            try
            {
                catalog.AddSong(form.Name_Disk, form.Name_Song, form.Name_Singer);
                MessageBox.Show("Успешно добавлено", "Добавить песню", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isShown) richTextBox1.Text = catalog.ShowCatalog();
                else if (onlyOneDisk != "") richTextBox1.Text = catalog.ShowDisk(onlyOneDisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления: " + ex.Message, "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void удалитьДискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nameDisk = Interaction.InputBox("Введите название диска: ", "Название диска");
            try
            {
                catalog.DeleteDisk(nameDisk);
                MessageBox.Show("Успешно удалено", "Удалить диск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isShown) richTextBox1.Text = catalog.ShowCatalog();
                if (onlyOneDisk == nameDisk) richTextBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Название диска", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void удалитьПеснюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm form = new InputForm();
            form.ShowDialog();

            try
            {
                catalog.DeleteSong(form.Name_Disk, form.Name_Song, form.Name_Singer);
                MessageBox.Show("Успешно удалено", "Удалить песню", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isShown) richTextBox1.Text = catalog.ShowCatalog();
                else if (onlyOneDisk != "") richTextBox1.Text = catalog.ShowDisk(onlyOneDisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}