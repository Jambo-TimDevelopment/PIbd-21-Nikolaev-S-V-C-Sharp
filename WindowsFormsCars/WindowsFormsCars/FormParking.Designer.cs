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
            this.buttonSetPlane = new System.Windows.Forms.Button();
            this.buttonSetRadarPlane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(850, 424);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox.Controls.Add(this.GetCar);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.PlaceParking);
            this.groupBox.Location = new System.Drawing.Point(862, 177);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(136, 153);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Забрать самолет";
            // 
            // GetCar
            // 
            this.GetCar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GetCar.Location = new System.Drawing.Point(23, 108);
            this.GetCar.Name = "GetCar";
            this.GetCar.Size = new System.Drawing.Size(100, 27);
            this.GetCar.TabIndex = 2;
            this.GetCar.Text = "Забрать";
            this.GetCar.UseVisualStyleBackColor = true;
            this.GetCar.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskedTextBox.Location = new System.Drawing.Point(57, 57);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(66, 26);
            this.maskedTextBox.TabIndex = 1;
            // 
            // PlaceParking
            // 
            this.PlaceParking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlaceParking.AutoSize = true;
            this.PlaceParking.Location = new System.Drawing.Point(-6, 63);
            this.PlaceParking.Name = "PlaceParking";
            this.PlaceParking.Size = new System.Drawing.Size(57, 20);
            this.PlaceParking.TabIndex = 0;
            this.PlaceParking.Text = "Место";
            // 
            // buttonSetPlane
            // 
            this.buttonSetPlane.Location = new System.Drawing.Point(862, 3);
            this.buttonSetPlane.Name = "buttonSetPlane";
            this.buttonSetPlane.Size = new System.Drawing.Size(136, 90);
            this.buttonSetPlane.TabIndex = 3;
            this.buttonSetPlane.Text = "Припарковать самолет";
            this.buttonSetPlane.UseVisualStyleBackColor = true;
            this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // buttonSetRadarPlane
            // 
            this.buttonSetRadarPlane.Location = new System.Drawing.Point(862, 99);
            this.buttonSetRadarPlane.Name = "buttonSetRadarPlane";
            this.buttonSetRadarPlane.Size = new System.Drawing.Size(136, 72);
            this.buttonSetRadarPlane.TabIndex = 4;
            this.buttonSetRadarPlane.Text = "Припарковать самолет с радаром";
            this.buttonSetRadarPlane.UseVisualStyleBackColor = true;
            this.buttonSetRadarPlane.Click += new System.EventHandler(this.buttonSetRadarPlane_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 427);
            this.Controls.Add(this.buttonSetRadarPlane);
            this.Controls.Add(this.buttonSetPlane);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button GetCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label PlaceParking;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.Button buttonSetRadarPlane;
    }
}