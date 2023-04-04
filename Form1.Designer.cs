namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ConditionInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SunriseInfo = new System.Windows.Forms.Label();
            this.SunsetInfo = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TempInfo = new System.Windows.Forms.Label();
            this.HumInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(79, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBCity.Location = new System.Drawing.Point(185, 57);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(362, 52);
            this.TBCity.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConditionInfo
            // 
            this.ConditionInfo.AutoSize = true;
            this.ConditionInfo.BackColor = System.Drawing.Color.Transparent;
            this.ConditionInfo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConditionInfo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.ConditionInfo.Location = new System.Drawing.Point(58, 154);
            this.ConditionInfo.Name = "ConditionInfo";
            this.ConditionInfo.Size = new System.Drawing.Size(207, 54);
            this.ConditionInfo.TabIndex = 3;
            this.ConditionInfo.Text = "Condition:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(45, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sunrise:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Location = new System.Drawing.Point(45, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sunset:";
            // 
            // SunriseInfo
            // 
            this.SunriseInfo.AutoSize = true;
            this.SunriseInfo.BackColor = System.Drawing.Color.Transparent;
            this.SunriseInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SunriseInfo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.SunriseInfo.Location = new System.Drawing.Point(151, 245);
            this.SunriseInfo.Name = "SunriseInfo";
            this.SunriseInfo.Size = new System.Drawing.Size(25, 35);
            this.SunriseInfo.TabIndex = 6;
            this.SunriseInfo.Text = "-";
            // 
            // SunsetInfo
            // 
            this.SunsetInfo.AutoSize = true;
            this.SunsetInfo.BackColor = System.Drawing.Color.Transparent;
            this.SunsetInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SunsetInfo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.SunsetInfo.Location = new System.Drawing.Point(151, 280);
            this.SunsetInfo.Name = "SunsetInfo";
            this.SunsetInfo.Size = new System.Drawing.Size(25, 35);
            this.SunsetInfo.TabIndex = 7;
            this.SunsetInfo.Text = "-";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(271, 142);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(161, 93);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 8;
            this.picIcon.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Location = new System.Drawing.Point(45, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Temp: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label6.Location = new System.Drawing.Point(45, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "Humidity:";
            // 
            // TempInfo
            // 
            this.TempInfo.AutoSize = true;
            this.TempInfo.BackColor = System.Drawing.Color.Transparent;
            this.TempInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TempInfo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.TempInfo.Location = new System.Drawing.Point(151, 315);
            this.TempInfo.Name = "TempInfo";
            this.TempInfo.Size = new System.Drawing.Size(25, 35);
            this.TempInfo.TabIndex = 11;
            this.TempInfo.Text = "-";
            // 
            // HumInfo
            // 
            this.HumInfo.AutoSize = true;
            this.HumInfo.BackColor = System.Drawing.Color.Transparent;
            this.HumInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HumInfo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.HumInfo.Location = new System.Drawing.Point(172, 350);
            this.HumInfo.Name = "HumInfo";
            this.HumInfo.Size = new System.Drawing.Size(25, 35);
            this.HumInfo.TabIndex = 12;
            this.HumInfo.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HumInfo);
            this.Controls.Add(this.TempInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.SunsetInfo);
            this.Controls.Add(this.SunriseInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConditionInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TBCity;
        private Button button1;
        private Label ConditionInfo;
        private Label label3;
        private Label label4;
        private Label SunriseInfo;
        private Label SunsetInfo;
        private PictureBox picIcon;
        private Label label5;
        private Label label6;
        private Label TempInfo;
        private Label HumInfo;
    }
}