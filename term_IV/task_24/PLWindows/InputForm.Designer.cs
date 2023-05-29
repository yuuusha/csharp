namespace PLWindows
{
    partial class InputForm
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
            nameSinger = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nameSong = new TextBox();
            button1 = new Button();
            label3 = new Label();
            nameDisk = new TextBox();
            SuspendLayout();
            // 
            // nameSinger
            // 
            nameSinger.Location = new Point(12, 131);
            nameSinger.Name = "nameSinger";
            nameSinger.Size = new Size(410, 27);
            nameSinger.TabIndex = 0;
            nameSinger.KeyDown += nameSinger_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите имя исполнителя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 191);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 3;
            label2.Text = "Введите название песни:";
            // 
            // nameSong
            // 
            nameSong.Location = new Point(12, 214);
            nameSong.Name = "nameSong";
            nameSong.Size = new Size(410, 27);
            nameSong.TabIndex = 2;
            nameSong.KeyDown += nameSong_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(162, 270);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 4;
            button1.Text = "Продолжить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 30);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 6;
            label3.Text = "Введите название диска:";
            // 
            // nameDisk
            // 
            nameDisk.Location = new Point(12, 53);
            nameDisk.Name = "nameDisk";
            nameDisk.Size = new Size(410, 27);
            nameDisk.TabIndex = 5;
            nameDisk.KeyDown += nameDisk_KeyDown;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 323);
            Controls.Add(label3);
            Controls.Add(nameDisk);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(nameSong);
            Controls.Add(label1);
            Controls.Add(nameSinger);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "InputForm";
            Text = "Ввод исполнителя";
            Load += InputForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameSinger;
        private Label label1;
        private Label label2;
        private TextBox nameSong;
        private Button button1;
        private Label label3;
        private TextBox nameDisk;
    }
}