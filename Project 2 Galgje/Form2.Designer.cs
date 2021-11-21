namespace Project_2_Galgje
{
    partial class frmSelectGame
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
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCustom = new System.Windows.Forms.RadioButton();
            this.rdbFood = new System.Windows.Forms.RadioButton();
            this.rdbAnimals = new System.Windows.Forms.RadioButton();
            this.rdbRandom = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Peru;
            this.btnStart.BackgroundImage = global::Project_2_Galgje.Properties.Resources.broad;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(44, 247);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::Project_2_Galgje.Properties.Resources.broad21;
            this.groupBox1.Controls.Add(this.rdbCustom);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.rdbFood);
            this.groupBox1.Controls.Add(this.rdbAnimals);
            this.groupBox1.Controls.Add(this.rdbRandom);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(23, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(205, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rdbCustom
            // 
            this.rdbCustom.AutoSize = true;
            this.rdbCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCustom.ForeColor = System.Drawing.Color.White;
            this.rdbCustom.Location = new System.Drawing.Point(44, 155);
            this.rdbCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCustom.Name = "rdbCustom";
            this.rdbCustom.Size = new System.Drawing.Size(82, 21);
            this.rdbCustom.TabIndex = 3;
            this.rdbCustom.TabStop = true;
            this.rdbCustom.Text = "Custom";
            this.rdbCustom.UseVisualStyleBackColor = true;
            // 
            // rdbFood
            // 
            this.rdbFood.AutoSize = true;
            this.rdbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFood.ForeColor = System.Drawing.Color.White;
            this.rdbFood.Location = new System.Drawing.Point(44, 122);
            this.rdbFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFood.Name = "rdbFood";
            this.rdbFood.Size = new System.Drawing.Size(65, 21);
            this.rdbFood.TabIndex = 2;
            this.rdbFood.TabStop = true;
            this.rdbFood.Text = "Food";
            this.rdbFood.UseVisualStyleBackColor = true;
            // 
            // rdbAnimals
            // 
            this.rdbAnimals.AutoSize = true;
            this.rdbAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnimals.ForeColor = System.Drawing.Color.White;
            this.rdbAnimals.Location = new System.Drawing.Point(44, 86);
            this.rdbAnimals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbAnimals.Name = "rdbAnimals";
            this.rdbAnimals.Size = new System.Drawing.Size(85, 21);
            this.rdbAnimals.TabIndex = 1;
            this.rdbAnimals.TabStop = true;
            this.rdbAnimals.Text = "Animals";
            this.rdbAnimals.UseVisualStyleBackColor = true;
            // 
            // rdbRandom
            // 
            this.rdbRandom.AutoSize = true;
            this.rdbRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRandom.ForeColor = System.Drawing.Color.White;
            this.rdbRandom.Location = new System.Drawing.Point(44, 50);
            this.rdbRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbRandom.Name = "rdbRandom";
            this.rdbRandom.Size = new System.Drawing.Size(88, 21);
            this.rdbRandom.TabIndex = 0;
            this.rdbRandom.TabStop = true;
            this.rdbRandom.Text = "Random";
            this.rdbRandom.UseVisualStyleBackColor = true;
            // 
            // frmSelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_2_Galgje.Properties.Resources.HomeScreen1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(656, 426);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSelectGame";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCustom;
        private System.Windows.Forms.RadioButton rdbFood;
        private System.Windows.Forms.RadioButton rdbAnimals;
        private System.Windows.Forms.RadioButton rdbRandom;
    }
}