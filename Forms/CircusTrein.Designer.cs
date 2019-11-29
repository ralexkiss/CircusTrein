﻿namespace CircusTrein
{
    partial class CircusTrein
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
            this.createdAnimalsBox = new System.Windows.Forms.ListBox();
            this.filledAnimalsBox = new System.Windows.Forms.ListBox();
            this.AnimalTypeBox = new System.Windows.Forms.ComboBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.SizeBox = new System.Windows.Forms.ComboBox();
            this.ConsumptionTypeBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.createdAnimalsLabel = new System.Windows.Forms.Label();
            this.filledAnimalsLabel = new System.Windows.Forms.Label();
            this.ConsumptionTypeLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AnimalTypeLabel = new System.Windows.Forms.Label();
            this.runAlgoritmButton = new System.Windows.Forms.Button();
            this.generateMockDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createdAnimalsBox
            // 
            this.createdAnimalsBox.FormattingEnabled = true;
            this.createdAnimalsBox.Location = new System.Drawing.Point(293, 34);
            this.createdAnimalsBox.Name = "createdAnimalsBox";
            this.createdAnimalsBox.Size = new System.Drawing.Size(414, 329);
            this.createdAnimalsBox.TabIndex = 1;
            // 
            // filledAnimalsBox
            // 
            this.filledAnimalsBox.FormattingEnabled = true;
            this.filledAnimalsBox.Location = new System.Drawing.Point(728, 34);
            this.filledAnimalsBox.Name = "filledAnimalsBox";
            this.filledAnimalsBox.Size = new System.Drawing.Size(487, 329);
            this.filledAnimalsBox.TabIndex = 2;
            this.filledAnimalsBox.SelectedIndexChanged += new System.EventHandler(this.filledAnimalsBox_SelectedIndexChanged);
            // 
            // AnimalTypeBox
            // 
            this.AnimalTypeBox.FormattingEnabled = true;
            this.AnimalTypeBox.Location = new System.Drawing.Point(115, 108);
            this.AnimalTypeBox.Name = "AnimalTypeBox";
            this.AnimalTypeBox.Size = new System.Drawing.Size(121, 21);
            this.AnimalTypeBox.TabIndex = 3;
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Location = new System.Drawing.Point(115, 163);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(121, 21);
            this.GenderBox.TabIndex = 4;
            // 
            // SizeBox
            // 
            this.SizeBox.FormattingEnabled = true;
            this.SizeBox.Location = new System.Drawing.Point(115, 218);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(121, 21);
            this.SizeBox.TabIndex = 5;
            // 
            // ConsumptionTypeBox
            // 
            this.ConsumptionTypeBox.FormattingEnabled = true;
            this.ConsumptionTypeBox.Location = new System.Drawing.Point(115, 278);
            this.ConsumptionTypeBox.Name = "ConsumptionTypeBox";
            this.ConsumptionTypeBox.Size = new System.Drawing.Size(121, 21);
            this.ConsumptionTypeBox.TabIndex = 6;
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(137, 340);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(75, 23);
            this.createAnimalButton.TabIndex = 7;
            this.createAnimalButton.Text = "Add Animal";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.CreateAnimalButton_Click);
            // 
            // createdAnimalsLabel
            // 
            this.createdAnimalsLabel.AutoSize = true;
            this.createdAnimalsLabel.Location = new System.Drawing.Point(382, 375);
            this.createdAnimalsLabel.Name = "createdAnimalsLabel";
            this.createdAnimalsLabel.Size = new System.Drawing.Size(235, 13);
            this.createdAnimalsLabel.TabIndex = 8;
            this.createdAnimalsLabel.Text = "List with Animals that need to be put in a Wagon";
            // 
            // filledAnimalsLabel
            // 
            this.filledAnimalsLabel.AutoSize = true;
            this.filledAnimalsLabel.Location = new System.Drawing.Point(949, 375);
            this.filledAnimalsLabel.Name = "filledAnimalsLabel";
            this.filledAnimalsLabel.Size = new System.Drawing.Size(88, 13);
            this.filledAnimalsLabel.TabIndex = 9;
            this.filledAnimalsLabel.Text = "List with Wagons";
            // 
            // ConsumptionTypeLabel
            // 
            this.ConsumptionTypeLabel.AutoSize = true;
            this.ConsumptionTypeLabel.Location = new System.Drawing.Point(9, 286);
            this.ConsumptionTypeLabel.Name = "ConsumptionTypeLabel";
            this.ConsumptionTypeLabel.Size = new System.Drawing.Size(95, 13);
            this.ConsumptionTypeLabel.TabIndex = 10;
            this.ConsumptionTypeLabel.Text = "Consumption Type";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(77, 226);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 13);
            this.SizeLabel.TabIndex = 11;
            this.SizeLabel.Text = "Size";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(62, 171);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(42, 13);
            this.GenderLabel.TabIndex = 12;
            this.GenderLabel.Text = "Gender";
            // 
            // AnimalTypeLabel
            // 
            this.AnimalTypeLabel.AutoSize = true;
            this.AnimalTypeLabel.Location = new System.Drawing.Point(39, 116);
            this.AnimalTypeLabel.Name = "AnimalTypeLabel";
            this.AnimalTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.AnimalTypeLabel.TabIndex = 13;
            this.AnimalTypeLabel.Text = "Animal Type";
            // 
            // runAlgoritmButton
            // 
            this.runAlgoritmButton.Location = new System.Drawing.Point(942, 415);
            this.runAlgoritmButton.Name = "runAlgoritmButton";
            this.runAlgoritmButton.Size = new System.Drawing.Size(107, 23);
            this.runAlgoritmButton.TabIndex = 14;
            this.runAlgoritmButton.Text = "Fill the Wagons";
            this.runAlgoritmButton.UseVisualStyleBackColor = true;
            this.runAlgoritmButton.Click += new System.EventHandler(this.RunAlgoritmButton_Click);
            // 
            // generateMockDataButton
            // 
            this.generateMockDataButton.Location = new System.Drawing.Point(442, 415);
            this.generateMockDataButton.Name = "generateMockDataButton";
            this.generateMockDataButton.Size = new System.Drawing.Size(107, 23);
            this.generateMockDataButton.TabIndex = 14;
            this.generateMockDataButton.Text = "Generate MockData";
            this.generateMockDataButton.UseVisualStyleBackColor = true;
            this.generateMockDataButton.Click += new System.EventHandler(this.generateMockDataButton_Click);
            // 
            // CircusTrein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 450);
            this.ControlBox = false;
            this.Controls.Add(this.generateMockDataButton);
            this.Controls.Add(this.runAlgoritmButton);
            this.Controls.Add(this.AnimalTypeLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.ConsumptionTypeLabel);
            this.Controls.Add(this.filledAnimalsLabel);
            this.Controls.Add(this.createdAnimalsLabel);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.ConsumptionTypeBox);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.AnimalTypeBox);
            this.Controls.Add(this.filledAnimalsBox);
            this.Controls.Add(this.createdAnimalsBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CircusTrein";
            this.ShowIcon = false;
            this.Text = "CircusTrein";
            this.Load += new System.EventHandler(this.CircusTrein_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox createdAnimalsBox;
        private System.Windows.Forms.ListBox filledAnimalsBox;
        private System.Windows.Forms.ComboBox AnimalTypeBox;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.ComboBox SizeBox;
        private System.Windows.Forms.ComboBox ConsumptionTypeBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Label createdAnimalsLabel;
        private System.Windows.Forms.Label filledAnimalsLabel;
        private System.Windows.Forms.Label ConsumptionTypeLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label AnimalTypeLabel;
        private System.Windows.Forms.Button runAlgoritmButton;
        private System.Windows.Forms.Button generateMockDataButton;
    }
}

