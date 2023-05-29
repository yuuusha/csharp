namespace PLWindows
{
    partial class PLCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PLCatalog));
            menuStrip1 = new MenuStrip();
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            показатьToolStripMenuItem = new ToolStripMenuItem();
            показатьДискToolStripMenuItem = new ToolStripMenuItem();
            показатьКаталогToolStripMenuItem = new ToolStripMenuItem();
            скрытьToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            добавитьДискToolStripMenuItem = new ToolStripMenuItem();
            добавитьПеснюToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьДискToolStripMenuItem = new ToolStripMenuItem();
            удалитьПеснюToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            отсортироватьToolStripMenuItem = new ToolStripMenuItem();
            поПеснямToolStripMenuItem = new ToolStripMenuItem();
            поИсполнителямToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem, показатьToolStripMenuItem, добавитьToolStripMenuItem, удалитьToolStripMenuItem, поискToolStripMenuItem, отсортироватьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, выходToolStripMenuItem });
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(59, 24);
            открытьФайлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Image = (Image)resources.GetObject("создатьToolStripMenuItem.Image");
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(224, 26);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(224, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(224, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьКакToolStripMenuItem.Image");
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(224, 26);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            сохранитьКакToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(224, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // показатьToolStripMenuItem
            // 
            показатьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { показатьДискToolStripMenuItem, показатьКаталогToolStripMenuItem, скрытьToolStripMenuItem });
            показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            показатьToolStripMenuItem.Size = new Size(49, 24);
            показатьToolStripMenuItem.Text = "Вид";
            // 
            // показатьДискToolStripMenuItem
            // 
            показатьДискToolStripMenuItem.Image = (Image)resources.GetObject("показатьДискToolStripMenuItem.Image");
            показатьДискToolStripMenuItem.Name = "показатьДискToolStripMenuItem";
            показатьДискToolStripMenuItem.Size = new Size(224, 26);
            показатьДискToolStripMenuItem.Text = "Показать диск";
            показатьДискToolStripMenuItem.Click += показатьДискToolStripMenuItem_Click;
            // 
            // показатьКаталогToolStripMenuItem
            // 
            показатьКаталогToolStripMenuItem.Image = (Image)resources.GetObject("показатьКаталогToolStripMenuItem.Image");
            показатьКаталогToolStripMenuItem.Name = "показатьКаталогToolStripMenuItem";
            показатьКаталогToolStripMenuItem.Size = new Size(224, 26);
            показатьКаталогToolStripMenuItem.Text = "Показать каталог";
            показатьКаталогToolStripMenuItem.Click += показатьКаталогToolStripMenuItem_Click;
            // 
            // скрытьToolStripMenuItem
            // 
            скрытьToolStripMenuItem.Image = (Image)resources.GetObject("скрытьToolStripMenuItem.Image");
            скрытьToolStripMenuItem.Name = "скрытьToolStripMenuItem";
            скрытьToolStripMenuItem.Size = new Size(224, 26);
            скрытьToolStripMenuItem.Text = "Скрыть";
            скрытьToolStripMenuItem.Click += скрытьToolStripMenuItem_Click;
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьДискToolStripMenuItem, добавитьПеснюToolStripMenuItem });
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(90, 24);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // добавитьДискToolStripMenuItem
            // 
            добавитьДискToolStripMenuItem.Image = (Image)resources.GetObject("добавитьДискToolStripMenuItem.Image");
            добавитьДискToolStripMenuItem.Name = "добавитьДискToolStripMenuItem";
            добавитьДискToolStripMenuItem.Size = new Size(224, 26);
            добавитьДискToolStripMenuItem.Text = "Добавить диск";
            добавитьДискToolStripMenuItem.Click += добавитьДискToolStripMenuItem_Click;
            // 
            // добавитьПеснюToolStripMenuItem
            // 
            добавитьПеснюToolStripMenuItem.Image = (Image)resources.GetObject("добавитьПеснюToolStripMenuItem.Image");
            добавитьПеснюToolStripMenuItem.Name = "добавитьПеснюToolStripMenuItem";
            добавитьПеснюToolStripMenuItem.Size = new Size(224, 26);
            добавитьПеснюToolStripMenuItem.Text = "Добавить песню";
            добавитьПеснюToolStripMenuItem.Click += добавитьПеснюToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { удалитьДискToolStripMenuItem, удалитьПеснюToolStripMenuItem });
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(79, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // удалитьДискToolStripMenuItem
            // 
            удалитьДискToolStripMenuItem.Image = (Image)resources.GetObject("удалитьДискToolStripMenuItem.Image");
            удалитьДискToolStripMenuItem.Name = "удалитьДискToolStripMenuItem";
            удалитьДискToolStripMenuItem.Size = new Size(224, 26);
            удалитьДискToolStripMenuItem.Text = "Удалить диск";
            удалитьДискToolStripMenuItem.Click += удалитьДискToolStripMenuItem_Click;
            // 
            // удалитьПеснюToolStripMenuItem
            // 
            удалитьПеснюToolStripMenuItem.Image = (Image)resources.GetObject("удалитьПеснюToolStripMenuItem.Image");
            удалитьПеснюToolStripMenuItem.Name = "удалитьПеснюToolStripMenuItem";
            удалитьПеснюToolStripMenuItem.Size = new Size(224, 26);
            удалитьПеснюToolStripMenuItem.Text = "Удалить песню";
            удалитьПеснюToolStripMenuItem.Click += удалитьПеснюToolStripMenuItem_Click;
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(66, 24);
            поискToolStripMenuItem.Text = "Поиск";
            поискToolStripMenuItem.Click += поискToolStripMenuItem_Click;
            // 
            // отсортироватьToolStripMenuItem
            // 
            отсортироватьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поПеснямToolStripMenuItem, поИсполнителямToolStripMenuItem });
            отсортироватьToolStripMenuItem.Name = "отсортироватьToolStripMenuItem";
            отсортироватьToolStripMenuItem.Size = new Size(128, 24);
            отсортироватьToolStripMenuItem.Text = "Отсортировать";
            // 
            // поПеснямToolStripMenuItem
            // 
            поПеснямToolStripMenuItem.Image = (Image)resources.GetObject("поПеснямToolStripMenuItem.Image");
            поПеснямToolStripMenuItem.Name = "поПеснямToolStripMenuItem";
            поПеснямToolStripMenuItem.Size = new Size(224, 26);
            поПеснямToolStripMenuItem.Text = "По песням";
            поПеснямToolStripMenuItem.Click += поПеснямToolStripMenuItem_Click;
            // 
            // поИсполнителямToolStripMenuItem
            // 
            поИсполнителямToolStripMenuItem.Image = (Image)resources.GetObject("поИсполнителямToolStripMenuItem.Image");
            поИсполнителямToolStripMenuItem.Name = "поИсполнителямToolStripMenuItem";
            поИсполнителямToolStripMenuItem.Size = new Size(224, 26);
            поИсполнителямToolStripMenuItem.Text = "По исполнителям";
            поИсполнителямToolStripMenuItem.Click += поИсполнителямToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 31);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 407);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // PLCatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "PLCatalog";
            Text = "Каталог дисков";
            FormClosing += PLCatalog_FormClosing;
            Load += Form1_Load;
            SizeChanged += PLCatalog_SizeChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem добавитьДискToolStripMenuItem;
        private ToolStripMenuItem добавитьПеснюToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem удалитьДискToolStripMenuItem;
        private ToolStripMenuItem удалитьПеснюToolStripMenuItem;
        private ToolStripMenuItem показатьToolStripMenuItem;
        private ToolStripMenuItem показатьДискToolStripMenuItem;
        private ToolStripMenuItem показатьКаталогToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem отсортироватьToolStripMenuItem;
        private ToolStripMenuItem поПеснямToolStripMenuItem;
        private ToolStripMenuItem поИсполнителямToolStripMenuItem;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem скрытьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}