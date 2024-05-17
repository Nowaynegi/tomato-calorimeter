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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            TempOfMetalTextbox = new TextBox();
            label1 = new Label();
            MetalComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            RoomTemperatureTextbox = new TextBox();
            label4 = new Label();
            MassOfWaterTextbox = new TextBox();
            label5 = new Label();
            WaterSpecificHeatTextbox = new TextBox();
            button1 = new Button();
            label6 = new Label();
            MassOfMetalTextbox = new TextBox();
            SpecificUnit = new ComboBox();
            CalculatedHeat = new Label();
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
            // TempOfMetalTextbox
            // 
            TempOfMetalTextbox.BackColor = Color.PaleTurquoise;
            TempOfMetalTextbox.Location = new Point(310, 21);
            TempOfMetalTextbox.Name = "TempOfMetalTextbox";
            TempOfMetalTextbox.Size = new Size(100, 23);
            TempOfMetalTextbox.TabIndex = 1;
            TempOfMetalTextbox.Text = "22";
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
            // MetalComboBox
            // 
            MetalComboBox.FormattingEnabled = true;
            MetalComboBox.Items.AddRange(new object[] { "Tungstun", "Titanium", "Copper", "Zinc", "Iron" });
            MetalComboBox.Location = new Point(515, 21);
            MetalComboBox.Name = "MetalComboBox";
            MetalComboBox.Size = new Size(121, 23);
            MetalComboBox.TabIndex = 3;
            MetalComboBox.Text = "nyanya";
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
            RoomTemperatureTextbox.BackColor = Color.Violet;
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
            label4.Size = new Size(100, 15);
            label4.TabIndex = 8;
            label4.Text = "Mass of Water (g)";
            // 
            // MassOfWaterTextbox
            // 
            MassOfWaterTextbox.BackColor = Color.LightCoral;
            MassOfWaterTextbox.Location = new Point(13, 66);
            MassOfWaterTextbox.Name = "MassOfWaterTextbox";
            MassOfWaterTextbox.Size = new Size(100, 23);
            MassOfWaterTextbox.TabIndex = 7;
            MassOfWaterTextbox.Text = "100";
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(689, 52);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 15;
            label6.Text = "Mass of Metal (g)";
            // 
            // MassOfMetalTextbox
            // 
            MassOfMetalTextbox.BackColor = Color.PaleTurquoise;
            MassOfMetalTextbox.Location = new Point(688, 66);
            MassOfMetalTextbox.Name = "MassOfMetalTextbox";
            MassOfMetalTextbox.Size = new Size(100, 23);
            MassOfMetalTextbox.TabIndex = 14;
            MassOfMetalTextbox.Text = "20";
            // 
            // SpecificUnit
            // 
            SpecificUnit.BackColor = Color.LightCoral;
            SpecificUnit.FlatStyle = FlatStyle.System;
            SpecificUnit.ForeColor = SystemColors.WindowText;
            SpecificUnit.FormattingEnabled = true;
            SpecificUnit.Items.AddRange(new object[] { "Joule", "calorie" });
            SpecificUnit.Location = new Point(110, 112);
            SpecificUnit.Name = "SpecificUnit";
            SpecificUnit.Size = new Size(35, 23);
            SpecificUnit.TabIndex = 12;
            SpecificUnit.Click += SpecificUnit_Click;
            // 
            // CalculatedHeat
            // 
            CalculatedHeat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CalculatedHeat.AutoSize = true;
            CalculatedHeat.BackColor = Color.FromArgb(255, 192, 192);
            CalculatedHeat.Location = new Point(669, 423);
            CalculatedHeat.Name = "CalculatedHeat";
            CalculatedHeat.Size = new Size(32, 15);
            CalculatedHeat.TabIndex = 16;
            CalculatedHeat.Text = "Heat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CalculatedHeat);
            Controls.Add(label6);
            Controls.Add(MassOfMetalTextbox);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(SpecificUnit);
            Controls.Add(label3);
            Controls.Add(RoomTemperatureTextbox);
            Controls.Add(WaterSpecificHeatTextbox);
            Controls.Add(label4);
            Controls.Add(MassOfWaterTextbox);
            Controls.Add(label2);
            Controls.Add(MetalComboBox);
            Controls.Add(label1);
            Controls.Add(TempOfMetalTextbox);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TempOfMetalTextbox;
        private Label label1;
        private ComboBox MetalComboBox;
        private Label label2;
        private Label label3;
        private TextBox RoomTemperatureTextbox;
        private Label label4;
        private TextBox MassOfWaterTextbox;
        private Label label5;
        private TextBox WaterSpecificHeatTextbox;
        private Button button1;
        private Label label6;
        private TextBox MassOfMetalTextbox;
        private ComboBox SpecificUnit;
        private Label CalculatedHeat;
    }
}
