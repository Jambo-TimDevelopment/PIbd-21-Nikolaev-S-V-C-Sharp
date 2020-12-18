namespace WindowsFormsPlane
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.GetCar = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PlaceParking = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.buttonDelParking = new System.Windows.Forms.Button();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddPlane = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.butnSortParking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 46);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(850, 637);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox.Controls.Add(this.GetCar);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.PlaceParking);
            this.groupBox.Location = new System.Drawing.Point(860, 542);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(182, 152);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Забрать самолет";
            // 
            // GetCar
            // 
            this.GetCar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GetCar.Location = new System.Drawing.Point(46, 108);
            this.GetCar.Name = "GetCar";
            this.GetCar.Size = new System.Drawing.Size(100, 28);
            this.GetCar.TabIndex = 2;
            this.GetCar.Text = "Забрать";
            this.GetCar.UseVisualStyleBackColor = true;
            this.GetCar.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskedTextBox.Location = new System.Drawing.Point(80, 57);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(66, 26);
            this.maskedTextBox.TabIndex = 1;
            // 
            // PlaceParking
            // 
            this.PlaceParking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlaceParking.AutoSize = true;
            this.PlaceParking.Location = new System.Drawing.Point(16, 63);
            this.PlaceParking.Name = "PlaceParking";
            this.PlaceParking.Size = new System.Drawing.Size(57, 20);
            this.PlaceParking.TabIndex = 0;
            this.PlaceParking.Text = "Место";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.ItemHeight = 20;
            this.listBoxParkings.Location = new System.Drawing.Point(860, 218);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(182, 84);
            this.listBoxParkings.TabIndex = 5;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(860, 309);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(182, 32);
            this.buttonDelParking.TabIndex = 6;
            this.buttonDelParking.Text = "Удалить парковку";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(860, 175);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(182, 35);
            this.buttonAddParking.TabIndex = 7;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(860, 145);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(182, 26);
            this.textBoxNewLevelName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(910, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Парковки";
            // 
            // buttonAddPlane
            // 
            this.buttonAddPlane.Location = new System.Drawing.Point(860, 347);
            this.buttonAddPlane.Name = "buttonAddPlane";
            this.buttonAddPlane.Size = new System.Drawing.Size(182, 58);
            this.buttonAddPlane.TabIndex = 10;
            this.buttonAddPlane.Text = "Добавить самолет";
            this.buttonAddPlane.UseVisualStyleBackColor = true;
            this.buttonAddPlane.Click += new System.EventHandler(this.buttonAddPlane_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem1,
            this.загрузитьToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(200, 34);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem1
            // 
            this.загрузитьToolStripMenuItem1.Name = "загрузитьToolStripMenuItem1";
            this.загрузитьToolStripMenuItem1.Size = new System.Drawing.Size(200, 34);
            this.загрузитьToolStripMenuItem1.Text = "Загрузить";
            this.загрузитьToolStripMenuItem1.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // butnSortParking
            // 
            this.butnSortParking.Location = new System.Drawing.Point(860, 452);
            this.butnSortParking.Name = "butnSortParking";
            this.butnSortParking.Size = new System.Drawing.Size(182, 39);
            this.butnSortParking.TabIndex = 12;
            this.butnSortParking.Text = "Сортировать";
            this.butnSortParking.UseVisualStyleBackColor = true;
            this.butnSortParking.Click += new System.EventHandler(this.butnSortParking_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 695);
            this.Controls.Add(this.butnSortParking);
            this.Controls.Add(this.buttonAddPlane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button GetCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label PlaceParking;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button buttonDelParking;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddPlane;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem1;
        private System.Windows.Forms.Button butnSortParking;
    }
}