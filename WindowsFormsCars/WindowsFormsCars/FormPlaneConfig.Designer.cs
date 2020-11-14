namespace WindowsFormsPlane
{
    partial class FormPlaneConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_PlaneMass = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_PlaneSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Engine = new System.Windows.Forms.CheckBox();
            this.checkBox_Antena = new System.Windows.Forms.CheckBox();
            this.checkBox_Radar = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelRadarPlane = new System.Windows.Forms.Label();
            this.labelBasePlane = new System.Windows.Forms.Label();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelColor_Black = new System.Windows.Forms.Panel();
            this.panelColor_Green = new System.Windows.Forms.Panel();
            this.panelColor_Cyan = new System.Windows.Forms.Panel();
            this.panelColor_Red = new System.Windows.Forms.Panel();
            this.panelColor_Blue = new System.Windows.Forms.Panel();
            this.panelColor_White = new System.Windows.Forms.Panel();
            this.panelColor_Olive = new System.Windows.Forms.Panel();
            this.panelColor_Brown = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PlaneMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PlaneSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_PlaneMass);
            this.groupBox1.Controls.Add(this.numericUpDown_PlaneSpeed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox_Engine);
            this.groupBox1.Controls.Add(this.checkBox_Antena);
            this.groupBox1.Controls.Add(this.checkBox_Radar);
            this.groupBox1.Location = new System.Drawing.Point(11, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // numericUpDown_PlaneMass
            // 
            this.numericUpDown_PlaneMass.Location = new System.Drawing.Point(74, 108);
            this.numericUpDown_PlaneMass.Name = "numericUpDown_PlaneMass";
            this.numericUpDown_PlaneMass.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown_PlaneMass.TabIndex = 6;
            // 
            // numericUpDown_PlaneSpeed
            // 
            this.numericUpDown_PlaneSpeed.Location = new System.Drawing.Point(74, 52);
            this.numericUpDown_PlaneSpeed.Name = "numericUpDown_PlaneSpeed";
            this.numericUpDown_PlaneSpeed.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown_PlaneSpeed.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вес авто";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Макс. скорость";
            // 
            // checkBox_Engine
            // 
            this.checkBox_Engine.AutoSize = true;
            this.checkBox_Engine.Location = new System.Drawing.Point(254, 85);
            this.checkBox_Engine.Name = "checkBox_Engine";
            this.checkBox_Engine.Size = new System.Drawing.Size(118, 24);
            this.checkBox_Engine.TabIndex = 2;
            this.checkBox_Engine.Text = "Двигатели";
            this.checkBox_Engine.UseVisualStyleBackColor = true;
            // 
            // checkBox_Antena
            // 
            this.checkBox_Antena.AutoSize = true;
            this.checkBox_Antena.Location = new System.Drawing.Point(254, 55);
            this.checkBox_Antena.Name = "checkBox_Antena";
            this.checkBox_Antena.Size = new System.Drawing.Size(95, 24);
            this.checkBox_Antena.TabIndex = 1;
            this.checkBox_Antena.Text = "Антена ";
            this.checkBox_Antena.UseVisualStyleBackColor = true;
            // 
            // checkBox_Radar
            // 
            this.checkBox_Radar.AutoSize = true;
            this.checkBox_Radar.Location = new System.Drawing.Point(254, 25);
            this.checkBox_Radar.Name = "checkBox_Radar";
            this.checkBox_Radar.Size = new System.Drawing.Size(83, 24);
            this.checkBox_Radar.TabIndex = 0;
            this.checkBox_Radar.Text = "Радар";
            this.checkBox_Radar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRadarPlane);
            this.groupBox2.Controls.Add(this.labelBasePlane);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 140);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип корпуса";
            // 
            // labelRadarPlane
            // 
            this.labelRadarPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRadarPlane.Location = new System.Drawing.Point(0, 80);
            this.labelRadarPlane.Name = "labelRadarPlane";
            this.labelRadarPlane.Size = new System.Drawing.Size(175, 36);
            this.labelRadarPlane.TabIndex = 4;
            this.labelRadarPlane.Text = "Самолет с радаром";
            this.labelRadarPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelRadarPlame_MouseDown);
            // 
            // labelBasePlane
            // 
            this.labelBasePlane.AllowDrop = true;
            this.labelBasePlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBasePlane.Location = new System.Drawing.Point(1, 35);
            this.labelBasePlane.Name = "labelBasePlane";
            this.labelBasePlane.Size = new System.Drawing.Size(174, 34);
            this.labelBasePlane.TabIndex = 3;
            this.labelBasePlane.Text = "Обычный самолет";
            this.labelBasePlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBasePlane_MouseDown);
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Location = new System.Drawing.Point(201, 12);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(490, 298);
            this.panelPlane.TabIndex = 8;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.planePlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.Location = new System.Drawing.Point(42, 18);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(409, 263);
            this.pictureBoxPlane.TabIndex = 0;
            this.pictureBoxPlane.TabStop = false;
            this.pictureBoxPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.planePlane_DragDrop);
            this.pictureBoxPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelColor_Black);
            this.groupBox3.Controls.Add(this.panelColor_Green);
            this.groupBox3.Controls.Add(this.panelColor_Cyan);
            this.groupBox3.Controls.Add(this.panelColor_Red);
            this.groupBox3.Controls.Add(this.panelColor_Blue);
            this.groupBox3.Controls.Add(this.panelColor_White);
            this.groupBox3.Controls.Add(this.panelColor_Olive);
            this.groupBox3.Controls.Add(this.panelColor_Brown);
            this.groupBox3.Controls.Add(this.labelDopColor);
            this.groupBox3.Controls.Add(this.labelBaseColor);
            this.groupBox3.Location = new System.Drawing.Point(697, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 140);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // panelColor_Black
            // 
            this.panelColor_Black.AllowDrop = true;
            this.panelColor_Black.BackColor = System.Drawing.Color.Black;
            this.panelColor_Black.Location = new System.Drawing.Point(160, 92);
            this.panelColor_Black.Name = "panelColor_Black";
            this.panelColor_Black.Size = new System.Drawing.Size(35, 34);
            this.panelColor_Black.TabIndex = 9;
            this.panelColor_Black.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panelColor_Green
            // 
            this.panelColor_Green.AllowDrop = true;
            this.panelColor_Green.BackColor = System.Drawing.Color.Chartreuse;
            this.panelColor_Green.Location = new System.Drawing.Point(65, 92);
            this.panelColor_Green.Name = "panelColor_Green";
            this.panelColor_Green.Size = new System.Drawing.Size(35, 34);
            this.panelColor_Green.TabIndex = 5;
            this.panelColor_Green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor_Cyan
            // 
            this.panelColor_Cyan.AllowDrop = true;
            this.panelColor_Cyan.BackColor = System.Drawing.Color.Cyan;
            this.panelColor_Cyan.Location = new System.Drawing.Point(113, 92);
            this.panelColor_Cyan.Name = "panelColor_Cyan";
            this.panelColor_Cyan.Size = new System.Drawing.Size(35, 34);
            this.panelColor_Cyan.TabIndex = 8;
            // 
            // panelColor_Red
            // 
            this.panelColor_Red.AllowDrop = true;
            this.panelColor_Red.BackColor = System.Drawing.Color.Red;
            this.panelColor_Red.Location = new System.Drawing.Point(15, 92);
            this.panelColor_Red.Name = "panelColor_Red";
            this.panelColor_Red.Size = new System.Drawing.Size(35, 34);
            this.panelColor_Red.TabIndex = 4;
            this.panelColor_Red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor_Blue
            // 
            this.panelColor_Blue.AllowDrop = true;
            this.panelColor_Blue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelColor_Blue.Location = new System.Drawing.Point(160, 49);
            this.panelColor_Blue.Name = "panelColor_Blue";
            this.panelColor_Blue.Size = new System.Drawing.Size(35, 34);
            this.panelColor_Blue.TabIndex = 7;
            // 
            // panelColor_White
            // 
            this.panelColor_White.AllowDrop = true;
            this.panelColor_White.BackColor = System.Drawing.Color.Snow;
            this.panelColor_White.Location = new System.Drawing.Point(113, 49);
            this.panelColor_White.Name = "panelColor_White";
            this.panelColor_White.Size = new System.Drawing.Size(35, 34);
            this.panelColor_White.TabIndex = 6;
            // 
            // panelColor_Olive
            // 
            this.panelColor_Olive.AllowDrop = true;
            this.panelColor_Olive.BackColor = System.Drawing.Color.OliveDrab;
            this.panelColor_Olive.Location = new System.Drawing.Point(65, 49);
            this.panelColor_Olive.Name = "panelColor_Olive";
            this.panelColor_Olive.Size = new System.Drawing.Size(35, 34);
            this.panelColor_Olive.TabIndex = 3;
            this.panelColor_Olive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor_Brown
            // 
            this.panelColor_Brown.AllowDrop = true;
            this.panelColor_Brown.BackColor = System.Drawing.Color.Sienna;
            this.panelColor_Brown.Location = new System.Drawing.Point(15, 49);
            this.panelColor_Brown.Name = "panelColor_Brown";
            this.panelColor_Brown.Size = new System.Drawing.Size(35, 34);
            this.panelColor_Brown.TabIndex = 2;
            this.panelColor_Brown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(113, 19);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(82, 27);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(15, 18);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(85, 27);
            this.labelBaseColor.TabIndex = 0;
            this.labelBaseColor.Text = "Осн цвет";
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(697, 158);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 29);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(697, 213);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 27);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 468);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPlaneConfig";
            this.Text = "FormPlaneConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PlaneMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PlaneSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelPlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_PlaneMass;
        private System.Windows.Forms.NumericUpDown numericUpDown_PlaneSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Engine;
        private System.Windows.Forms.CheckBox checkBox_Antena;
        private System.Windows.Forms.CheckBox checkBox_Radar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelRadarPlane;
        private System.Windows.Forms.Label labelBasePlane;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panelColor_Black;
        private System.Windows.Forms.Panel panelColor_Green;
        private System.Windows.Forms.Panel panelColor_Cyan;
        private System.Windows.Forms.Panel panelColor_Red;
        private System.Windows.Forms.Panel panelColor_Blue;
        private System.Windows.Forms.Panel panelColor_White;
        private System.Windows.Forms.Panel panelColor_Olive;
        private System.Windows.Forms.Panel panelColor_Brown;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}