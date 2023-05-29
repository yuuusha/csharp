using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLWindows
{
    public partial class InputForm : Form
    {
        string name_Singer;
        string name_Song;
        string name_Disk;

        public string Name_Singer
        {
            get => name_Singer;
            set { name_Singer = value; }
        }

        public string Name_Song
        {
            get => name_Song;
            set { name_Song = value; }
        }

        public string Name_Disk
        {
            get => name_Disk;
            set { name_Disk = value; }
        }

        public InputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name_Singer = nameSinger.Text;
            name_Song = nameSong.Text;
            name_Disk = nameDisk.Text;
            Close();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            ActiveControl = nameDisk;
        }

        private void nameDisk_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    nameSinger.Focus();
                    break;
                default:
                    break;
            }
        }

        private void nameSinger_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    nameSong.Focus();
                    break;
                default:
                    break;
            }
        }

        private void nameSong_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    button1_Click(sender, e);
                    break;
                default:
                    break;
            }
        }
    }
}
