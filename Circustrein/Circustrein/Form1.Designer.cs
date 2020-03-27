namespace Circustrein
{
    partial class Form1
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
            this.LstAnimals = new System.Windows.Forms.ListBox();
            this.AddAnimal = new System.Windows.Forms.Button();
            this.Distribute = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.CmbSize = new System.Windows.Forms.ComboBox();
            this.CmbSpecies = new System.Windows.Forms.ComboBox();
            this.LstTrein = new System.Windows.Forms.ListBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.LblSpecies = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstAnimals
            // 
            this.LstAnimals.FormattingEnabled = true;
            this.LstAnimals.ItemHeight = 16;
            this.LstAnimals.Location = new System.Drawing.Point(41, 21);
            this.LstAnimals.Name = "LstAnimals";
            this.LstAnimals.Size = new System.Drawing.Size(228, 148);
            this.LstAnimals.TabIndex = 0;
            // 
            // AddAnimal
            // 
            this.AddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAnimal.Location = new System.Drawing.Point(11, 151);
            this.AddAnimal.Name = "AddAnimal";
            this.AddAnimal.Size = new System.Drawing.Size(122, 31);
            this.AddAnimal.TabIndex = 2;
            this.AddAnimal.Text = "Add Animal";
            this.AddAnimal.UseVisualStyleBackColor = true;
            this.AddAnimal.Click += new System.EventHandler(this.AddAnimal_Click);
            // 
            // Distribute
            // 
            this.Distribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distribute.Location = new System.Drawing.Point(190, 150);
            this.Distribute.Name = "Distribute";
            this.Distribute.Size = new System.Drawing.Size(106, 32);
            this.Distribute.TabIndex = 6;
            this.Distribute.Text = "Distribute";
            this.Distribute.UseVisualStyleBackColor = true;
            this.Distribute.Click += new System.EventHandler(this.Distribute_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(116, 38);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(162, 22);
            this.TxtName.TabIndex = 7;
            // 
            // CmbSize
            // 
            this.CmbSize.FormattingEnabled = true;
            this.CmbSize.Location = new System.Drawing.Point(119, 77);
            this.CmbSize.Name = "CmbSize";
            this.CmbSize.Size = new System.Drawing.Size(121, 24);
            this.CmbSize.TabIndex = 8;
            // 
            // CmbSpecies
            // 
            this.CmbSpecies.FormattingEnabled = true;
            this.CmbSpecies.Location = new System.Drawing.Point(119, 107);
            this.CmbSpecies.Name = "CmbSpecies";
            this.CmbSpecies.Size = new System.Drawing.Size(121, 24);
            this.CmbSpecies.TabIndex = 9;
            // 
            // LstTrein
            // 
            this.LstTrein.FormattingEnabled = true;
            this.LstTrein.ItemHeight = 16;
            this.LstTrein.Location = new System.Drawing.Point(41, 175);
            this.LstTrein.Name = "LstTrein";
            this.LstTrein.Size = new System.Drawing.Size(228, 164);
            this.LstTrein.TabIndex = 10;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(45, 41);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 17);
            this.LblName.TabIndex = 11;
            this.LblName.Text = "Name:";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(45, 80);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(39, 17);
            this.LblSize.TabIndex = 12;
            this.LblSize.Text = "Size:";
            // 
            // LblSpecies
            // 
            this.LblSpecies.AutoSize = true;
            this.LblSpecies.Location = new System.Drawing.Point(45, 110);
            this.LblSpecies.Name = "LblSpecies";
            this.LblSpecies.Size = new System.Drawing.Size(58, 17);
            this.LblSpecies.TabIndex = 13;
            this.LblSpecies.Text = "Species";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.AddAnimal);
            this.groupBox1.Controls.Add(this.LblSpecies);
            this.groupBox1.Controls.Add(this.Distribute);
            this.groupBox1.Controls.Add(this.LblSize);
            this.groupBox1.Controls.Add(this.CmbSize);
            this.groupBox1.Controls.Add(this.LblName);
            this.groupBox1.Controls.Add(this.CmbSpecies);
            this.groupBox1.Location = new System.Drawing.Point(398, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 208);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LstAnimals);
            this.groupBox2.Controls.Add(this.LstTrein);
            this.groupBox2.Location = new System.Drawing.Point(57, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 349);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstAnimals;
        private System.Windows.Forms.Button AddAnimal;
        private System.Windows.Forms.Button Distribute;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ComboBox CmbSize;
        private System.Windows.Forms.ComboBox CmbSpecies;
        private System.Windows.Forms.ListBox LstTrein;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.Label LblSpecies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

