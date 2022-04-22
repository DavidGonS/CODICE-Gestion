namespace Company.PL.Departamentos
{
    partial class InsertarDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarDepartamento));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreDepartamento = new System.Windows.Forms.TextBox();
            this.btInsertar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce el nombre del departamento:";
            // 
            // tbNombreDepartamento
            // 
            this.tbNombreDepartamento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNombreDepartamento.Location = new System.Drawing.Point(232, 91);
            this.tbNombreDepartamento.Name = "tbNombreDepartamento";
            this.tbNombreDepartamento.Size = new System.Drawing.Size(100, 20);
            this.tbNombreDepartamento.TabIndex = 1;
            // 
            // btInsertar
            // 
            this.btInsertar.BackColor = System.Drawing.SystemColors.Window;
            this.btInsertar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btInsertar.Location = new System.Drawing.Point(165, 150);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(100, 23);
            this.btInsertar.TabIndex = 2;
            this.btInsertar.Text = "INSERTAR";
            this.btInsertar.UseVisualStyleBackColor = false;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Company.Properties.Resources.logoCodice;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(324, 27);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbUsuario.TabIndex = 4;
            this.lbUsuario.Text = "label2";
            // 
            // InsertarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 451);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.tbNombreDepartamento);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertarDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertarDepartamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreDepartamento;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUsuario;
    }
}