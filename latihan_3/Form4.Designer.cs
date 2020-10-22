namespace latihan_3
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.ItemLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBeli = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.listBoxShop = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // cbItem
            // 
            resources.ApplyResources(this.cbItem, "cbItem");
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Items.AddRange(new object[] {
            resources.GetString("cbItem.Items"),
            resources.GetString("cbItem.Items1"),
            resources.GetString("cbItem.Items2"),
            resources.GetString("cbItem.Items3"),
            resources.GetString("cbItem.Items4")});
            this.cbItem.Name = "cbItem";
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
            // 
            // txtHarga
            // 
            resources.ApplyResources(this.txtHarga, "txtHarga");
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            // 
            // ItemLbl
            // 
            resources.ApplyResources(this.ItemLbl, "ItemLbl");
            this.ItemLbl.Name = "ItemLbl";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnBeli
            // 
            resources.ApplyResources(this.btnBeli, "btnBeli");
            this.btnBeli.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBeli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.UseVisualStyleBackColor = false;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // btnOut
            // 
            resources.ApplyResources(this.btnOut, "btnOut");
            this.btnOut.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOut.Name = "btnOut";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listBoxShop
            // 
            resources.ApplyResources(this.listBoxShop, "listBoxShop");
            this.listBoxShop.FormattingEnabled = true;
            this.listBoxShop.Name = "listBoxShop";
            // 
            // Form4
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxShop);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemLbl);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label ItemLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listBoxShop;
    }
}