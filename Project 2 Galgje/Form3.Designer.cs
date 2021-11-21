namespace Project_2_Galgje
{
    partial class frmLevelCreator
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lbxToevoegen = new System.Windows.Forms.ListBox();
            this.txtToevoegen = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(42, 293);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lbxToevoegen
            // 
            this.lbxToevoegen.BackColor = System.Drawing.SystemColors.Window;
            this.lbxToevoegen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxToevoegen.FormattingEnabled = true;
            this.lbxToevoegen.Location = new System.Drawing.Point(30, 32);
            this.lbxToevoegen.Name = "lbxToevoegen";
            this.lbxToevoegen.Size = new System.Drawing.Size(146, 223);
            this.lbxToevoegen.TabIndex = 1;
            // 
            // txtToevoegen
            // 
            this.txtToevoegen.Font = new System.Drawing.Font("Papyrus", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToevoegen.Location = new System.Drawing.Point(196, 41);
            this.txtToevoegen.Name = "txtToevoegen";
            this.txtToevoegen.Size = new System.Drawing.Size(100, 34);
            this.txtToevoegen.TabIndex = 2;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.Location = new System.Drawing.Point(196, 81);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(100, 27);
            this.btnToevoegen.TabIndex = 3;
            this.btnToevoegen.Text = "toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddList.Location = new System.Drawing.Point(42, 261);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(115, 27);
            this.btnAddList.TabIndex = 4;
            this.btnAddList.Text = "lijst houden";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijder.Location = new System.Drawing.Point(196, 114);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(100, 27);
            this.btnVerwijder.TabIndex = 5;
            this.btnVerwijder.Text = "verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // frmLevelCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_2_Galgje.Properties.Resources.HomeScreen1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(506, 347);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtToevoegen);
            this.Controls.Add(this.lbxToevoegen);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLevelCreator";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxToevoegen;
        private System.Windows.Forms.TextBox txtToevoegen;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Button btnVerwijder;
    }
}