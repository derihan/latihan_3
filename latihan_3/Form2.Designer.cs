namespace latihan_3
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
            this.FormTampilanLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormTampilanLogin
            // 
            this.FormTampilanLogin.AutoSize = true;
            this.FormTampilanLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTampilanLogin.Location = new System.Drawing.Point(74, 116);
            this.FormTampilanLogin.Name = "FormTampilanLogin";
            this.FormTampilanLogin.Size = new System.Drawing.Size(654, 39);
            this.FormTampilanLogin.TabIndex = 0;
            this.FormTampilanLogin.Text = "SELAMAT DATANG  DI PRAKTIKUM C# ";
            this.FormTampilanLogin.Click += new System.EventHandler(this.FormTampilanLogin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 271);
            this.Controls.Add(this.FormTampilanLogin);
            this.Name = "Form2";
            this.Text = "Hi !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormTampilanLogin;
    }
}