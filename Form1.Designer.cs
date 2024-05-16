namespace tomato_calorimeter
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            RoomTemperatureTextbox = new TextBox();
            label4 = new Label();
            MassOfWaterTextbox = new TextBox();
            label5 = new Label();
            WaterSpecificHeatTextbox = new TextBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.practice604;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCoral;
            textBox1.Location = new Point(310, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "temp of metal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(311, 7);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "T of Metal";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tungstun", "Titanium", "Copper", "Zinc" });
            comboBox1.Location = new Point(515, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "nyanya";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(13, 7);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 6;
            label3.Text = "Room Temperature";
            // 
            // RoomTemperatureTextbox
            // 
            RoomTemperatureTextbox.BackColor = Color.LightCoral;
            RoomTemperatureTextbox.Location = new Point(12, 21);
            RoomTemperatureTextbox.Name = "RoomTemperatureTextbox";
            RoomTemperatureTextbox.Size = new Size(100, 23);
            RoomTemperatureTextbox.TabIndex = 5;
            RoomTemperatureTextbox.Text = "22";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(14, 52);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 8;
            label4.Text = "Mass of Water";
            // 
            // MassOfWaterTextbox
            // 
            MassOfWaterTextbox.BackColor = Color.LightCoral;
            MassOfWaterTextbox.Location = new Point(13, 66);
            MassOfWaterTextbox.Name = "MassOfWaterTextbox";
            MassOfWaterTextbox.Size = new Size(100, 23);
            MassOfWaterTextbox.TabIndex = 7;
            MassOfWaterTextbox.Text = "100g";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Location = new Point(13, 98);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 10;
            label5.Text = "Specific Heat of Water";
            // 
            // WaterSpecificHeatTextbox
            // 
            WaterSpecificHeatTextbox.BackColor = Color.LightCoral;
            WaterSpecificHeatTextbox.Location = new Point(12, 112);
            WaterSpecificHeatTextbox.Name = "WaterSpecificHeatTextbox";
            WaterSpecificHeatTextbox.Size = new Size(100, 23);
            WaterSpecificHeatTextbox.TabIndex = 9;
            WaterSpecificHeatTextbox.Text = "1.00";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LightCoral;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.ForeColor = SystemColors.WindowText;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "°C", "°F", "K" });
            comboBox2.Location = new Point(110, 21);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(35, 23);
            comboBox2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(RoomTemperatureTextbox);
            Controls.Add(label5);
            Controls.Add(WaterSpecificHeatTextbox);
            Controls.Add(label4);
            Controls.Add(MassOfWaterTextbox);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox RoomTemperatureTextbox;
        private Label label4;
        private TextBox MassOfWaterTextbox;
        private Label label5;
        private TextBox WaterSpecificHeatTextbox;
        private ComboBox comboBox2;
    }
}
