
namespace PremiumCarsRacing
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.betstore = new System.Windows.Forms.GroupBox();
            this.race_run_button = new System.Windows.Forms.Button();
            this.lockevery_button = new System.Windows.Forms.Button();
            this.Bet_selector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rao_pl = new System.Windows.Forms.CheckBox();
            this.Manki_pl = new System.Windows.Forms.CheckBox();
            this.ghumble_pl = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.masserti_pl = new System.Windows.Forms.CheckBox();
            this.bmw_pl = new System.Windows.Forms.CheckBox();
            this.ferrari_car = new System.Windows.Forms.CheckBox();
            this.logonda_car = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.logonda1 = new System.Windows.Forms.PictureBox();
            this.ferrari2 = new System.Windows.Forms.PictureBox();
            this.masserti3 = new System.Windows.Forms.PictureBox();
            this.bmw4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.betstore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logonda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferrari2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masserti3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmw4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // betstore
            // 
            this.betstore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.betstore.Controls.Add(this.race_run_button);
            this.betstore.Controls.Add(this.lockevery_button);
            this.betstore.Controls.Add(this.Bet_selector);
            this.betstore.Controls.Add(this.label2);
            this.betstore.Controls.Add(this.rao_pl);
            this.betstore.Controls.Add(this.Manki_pl);
            this.betstore.Controls.Add(this.ghumble_pl);
            this.betstore.Controls.Add(this.label1);
            this.betstore.Controls.Add(this.masserti_pl);
            this.betstore.Controls.Add(this.bmw_pl);
            this.betstore.Controls.Add(this.ferrari_car);
            this.betstore.Controls.Add(this.logonda_car);
            this.betstore.Controls.Add(this.label);
            this.betstore.Location = new System.Drawing.Point(12, 12);
            this.betstore.Name = "betstore";
            this.betstore.Size = new System.Drawing.Size(729, 232);
            this.betstore.TabIndex = 0;
            this.betstore.TabStop = false;
            this.betstore.Text = "Betting Area";
            // 
            // race_run_button
            // 
            this.race_run_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.race_run_button.Enabled = false;
            this.race_run_button.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race_run_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.race_run_button.Location = new System.Drawing.Point(586, 160);
            this.race_run_button.Name = "race_run_button";
            this.race_run_button.Size = new System.Drawing.Size(123, 53);
            this.race_run_button.TabIndex = 12;
            this.race_run_button.Text = "Run a Race";
            this.race_run_button.UseVisualStyleBackColor = false;
            this.race_run_button.Click += new System.EventHandler(this.race_run_button_Click);
            // 
            // lockevery_button
            // 
            this.lockevery_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lockevery_button.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockevery_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lockevery_button.Location = new System.Drawing.Point(586, 101);
            this.lockevery_button.Name = "lockevery_button";
            this.lockevery_button.Size = new System.Drawing.Size(123, 53);
            this.lockevery_button.TabIndex = 11;
            this.lockevery_button.Text = "Lock All Conditions";
            this.lockevery_button.UseVisualStyleBackColor = false;
            this.lockevery_button.Click += new System.EventHandler(this.lockevery_button_Click);
            // 
            // Bet_selector
            // 
            this.Bet_selector.FormattingEnabled = true;
            this.Bet_selector.Location = new System.Drawing.Point(482, 64);
            this.Bet_selector.Name = "Bet_selector";
            this.Bet_selector.Size = new System.Drawing.Size(107, 21);
            this.Bet_selector.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Bet Amount";
            // 
            // rao_pl
            // 
            this.rao_pl.AutoSize = true;
            this.rao_pl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rao_pl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rao_pl.Location = new System.Drawing.Point(209, 145);
            this.rao_pl.Name = "rao_pl";
            this.rao_pl.Size = new System.Drawing.Size(197, 26);
            this.rao_pl.TabIndex = 8;
            this.rao_pl.Text = "Mr. Rao  has $50 to Bet";
            this.rao_pl.UseVisualStyleBackColor = true;
            this.rao_pl.CheckedChanged += new System.EventHandler(this.rao_pl_CheckedChanged);
            // 
            // Manki_pl
            // 
            this.Manki_pl.AutoSize = true;
            this.Manki_pl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manki_pl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Manki_pl.Location = new System.Drawing.Point(209, 101);
            this.Manki_pl.Name = "Manki_pl";
            this.Manki_pl.Size = new System.Drawing.Size(215, 26);
            this.Manki_pl.TabIndex = 7;
            this.Manki_pl.Text = "Dr. Manki  has $50 to Bet";
            this.Manki_pl.UseVisualStyleBackColor = true;
            this.Manki_pl.CheckedChanged += new System.EventHandler(this.Manki_pl_CheckedChanged);
            // 
            // ghumble_pl
            // 
            this.ghumble_pl.AutoSize = true;
            this.ghumble_pl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghumble_pl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ghumble_pl.Location = new System.Drawing.Point(209, 59);
            this.ghumble_pl.Name = "ghumble_pl";
            this.ghumble_pl.Size = new System.Drawing.Size(231, 26);
            this.ghumble_pl.TabIndex = 6;
            this.ghumble_pl.Text = "Sir Ghumble has $50 to Bet";
            this.ghumble_pl.UseVisualStyleBackColor = true;
            this.ghumble_pl.CheckedChanged += new System.EventHandler(this.ghumble_pl_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Player Below";
            // 
            // masserti_pl
            // 
            this.masserti_pl.AutoSize = true;
            this.masserti_pl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masserti_pl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.masserti_pl.Location = new System.Drawing.Point(21, 145);
            this.masserti_pl.Name = "masserti_pl";
            this.masserti_pl.Size = new System.Drawing.Size(115, 26);
            this.masserti_pl.TabIndex = 4;
            this.masserti_pl.Text = "Masserti (3)";
            this.masserti_pl.UseVisualStyleBackColor = true;
            this.masserti_pl.CheckedChanged += new System.EventHandler(this.masserti_pl_CheckedChanged);
            // 
            // bmw_pl
            // 
            this.bmw_pl.AutoSize = true;
            this.bmw_pl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmw_pl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bmw_pl.Location = new System.Drawing.Point(21, 187);
            this.bmw_pl.Name = "bmw_pl";
            this.bmw_pl.Size = new System.Drawing.Size(94, 26);
            this.bmw_pl.TabIndex = 3;
            this.bmw_pl.Text = "BMW (4)";
            this.bmw_pl.UseVisualStyleBackColor = true;
            this.bmw_pl.CheckedChanged += new System.EventHandler(this.bmw_pl_CheckedChanged);
            // 
            // ferrari_car
            // 
            this.ferrari_car.AutoSize = true;
            this.ferrari_car.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ferrari_car.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ferrari_car.Location = new System.Drawing.Point(21, 101);
            this.ferrari_car.Name = "ferrari_car";
            this.ferrari_car.Size = new System.Drawing.Size(102, 26);
            this.ferrari_car.TabIndex = 2;
            this.ferrari_car.Text = "Ferrari (2)";
            this.ferrari_car.UseVisualStyleBackColor = true;
            this.ferrari_car.CheckedChanged += new System.EventHandler(this.ferrari_car_CheckedChanged);
            // 
            // logonda_car
            // 
            this.logonda_car.AutoSize = true;
            this.logonda_car.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logonda_car.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logonda_car.Location = new System.Drawing.Point(21, 59);
            this.logonda_car.Name = "logonda_car";
            this.logonda_car.Size = new System.Drawing.Size(116, 26);
            this.logonda_car.TabIndex = 1;
            this.logonda_car.Text = "Logonda (1)";
            this.logonda_car.UseVisualStyleBackColor = true;
            this.logonda_car.CheckedChanged += new System.EventHandler(this.logonda_car_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(6, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(168, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Select Your Car Below";
            // 
            // logonda1
            // 
            this.logonda1.Image = global::PremiumCarsRacing.Properties.Resources.race1;
            this.logonda1.Location = new System.Drawing.Point(12, 267);
            this.logonda1.Name = "logonda1";
            this.logonda1.Size = new System.Drawing.Size(148, 81);
            this.logonda1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logonda1.TabIndex = 1;
            this.logonda1.TabStop = false;
            // 
            // ferrari2
            // 
            this.ferrari2.Image = global::PremiumCarsRacing.Properties.Resources.race2;
            this.ferrari2.Location = new System.Drawing.Point(12, 373);
            this.ferrari2.Name = "ferrari2";
            this.ferrari2.Size = new System.Drawing.Size(148, 81);
            this.ferrari2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ferrari2.TabIndex = 2;
            this.ferrari2.TabStop = false;
            // 
            // masserti3
            // 
            this.masserti3.Image = global::PremiumCarsRacing.Properties.Resources.race3;
            this.masserti3.Location = new System.Drawing.Point(12, 478);
            this.masserti3.Name = "masserti3";
            this.masserti3.Size = new System.Drawing.Size(148, 81);
            this.masserti3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.masserti3.TabIndex = 3;
            this.masserti3.TabStop = false;
            // 
            // bmw4
            // 
            this.bmw4.Image = global::PremiumCarsRacing.Properties.Resources.race4;
            this.bmw4.Location = new System.Drawing.Point(12, 580);
            this.bmw4.Name = "bmw4";
            this.bmw4.Size = new System.Drawing.Size(148, 81);
            this.bmw4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bmw4.TabIndex = 4;
            this.bmw4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(7, 462);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(955, 10);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(7, 354);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(955, 10);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(7, 564);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(955, 10);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PremiumCarsRacing.Properties.Resources.cars_race;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 664);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.bmw4);
            this.Controls.Add(this.masserti3);
            this.Controls.Add(this.ferrari2);
            this.Controls.Add(this.logonda1);
            this.Controls.Add(this.betstore);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.betstore.ResumeLayout(false);
            this.betstore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logonda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferrari2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masserti3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmw4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox betstore;
        private System.Windows.Forms.Label label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox logonda1;
        private System.Windows.Forms.PictureBox ferrari2;
        private System.Windows.Forms.PictureBox masserti3;
        private System.Windows.Forms.PictureBox bmw4;
        private System.Windows.Forms.CheckBox masserti_pl;
        private System.Windows.Forms.CheckBox bmw_pl;
        private System.Windows.Forms.CheckBox ferrari_car;
        private System.Windows.Forms.CheckBox logonda_car;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button race_run_button;
        private System.Windows.Forms.Button lockevery_button;
        private System.Windows.Forms.ComboBox Bet_selector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rao_pl;
        private System.Windows.Forms.CheckBox Manki_pl;
        private System.Windows.Forms.CheckBox ghumble_pl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}