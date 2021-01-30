namespace installer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_install = new System.Windows.Forms.Button();
            this.btn_unistall = new System.Windows.Forms.Button();
            this.btn_Repair = new System.Windows.Forms.Button();
            this.lbl_Aguardando = new System.Windows.Forms.Label();
            this.lbl_transfer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 161);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(438, 10);
            this.progressBar1.TabIndex = 0;
            // 
            // btn_install
            // 
            this.btn_install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_install.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_install.Location = new System.Drawing.Point(319, 79);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(142, 40);
            this.btn_install.TabIndex = 1;
            this.btn_install.Text = "Instalar";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // btn_unistall
            // 
            this.btn_unistall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unistall.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_unistall.Location = new System.Drawing.Point(171, 79);
            this.btn_unistall.Name = "btn_unistall";
            this.btn_unistall.Size = new System.Drawing.Size(142, 40);
            this.btn_unistall.TabIndex = 2;
            this.btn_unistall.Text = "Desinstalar";
            this.btn_unistall.UseVisualStyleBackColor = true;
            this.btn_unistall.Click += new System.EventHandler(this.btn_unistall_Click);
            // 
            // btn_Repair
            // 
            this.btn_Repair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Repair.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Repair.Location = new System.Drawing.Point(23, 79);
            this.btn_Repair.Name = "btn_Repair";
            this.btn_Repair.Size = new System.Drawing.Size(142, 40);
            this.btn_Repair.TabIndex = 3;
            this.btn_Repair.Text = "Reparar";
            this.btn_Repair.UseVisualStyleBackColor = true;
            this.btn_Repair.Click += new System.EventHandler(this.btn_Repair_Click);
            // 
            // lbl_Aguardando
            // 
            this.lbl_Aguardando.AutoSize = true;
            this.lbl_Aguardando.ForeColor = System.Drawing.Color.White;
            this.lbl_Aguardando.Location = new System.Drawing.Point(19, 178);
            this.lbl_Aguardando.Name = "lbl_Aguardando";
            this.lbl_Aguardando.Size = new System.Drawing.Size(123, 13);
            this.lbl_Aguardando.TabIndex = 4;
            this.lbl_Aguardando.Text = "Aguardando o download";
            // 
            // lbl_transfer
            // 
            this.lbl_transfer.AutoSize = true;
            this.lbl_transfer.ForeColor = System.Drawing.Color.White;
            this.lbl_transfer.Location = new System.Drawing.Point(430, 145);
            this.lbl_transfer.Name = "lbl_transfer";
            this.lbl_transfer.Size = new System.Drawing.Size(27, 13);
            this.lbl_transfer.TabIndex = 5;
            this.lbl_transfer.Text = " 0 %";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::installer.Properties.Resources.img_36304_20170701192343;
            this.pictureBox1.Location = new System.Drawing.Point(225, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(225, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 134);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_transfer);
            this.Controls.Add(this.lbl_Aguardando);
            this.Controls.Add(this.btn_Repair);
            this.Controls.Add(this.btn_unistall);
            this.Controls.Add(this.btn_install);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Point Blank Installer";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Button btn_unistall;
        private System.Windows.Forms.Button btn_Repair;
        private System.Windows.Forms.Label lbl_Aguardando;
        private System.Windows.Forms.Label lbl_transfer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

