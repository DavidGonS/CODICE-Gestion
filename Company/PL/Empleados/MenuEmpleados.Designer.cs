namespace Company.PL
{
    partial class MenuEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEmpleados));
            this.btInsertar = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.btFichar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btInsertar
            // 
            this.btInsertar.BackColor = System.Drawing.SystemColors.Window;
            this.btInsertar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertar.Location = new System.Drawing.Point(25, 150);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(141, 33);
            this.btInsertar.TabIndex = 0;
            this.btInsertar.Text = "INSERTAR ";
            this.btInsertar.UseVisualStyleBackColor = false;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.SystemColors.Window;
            this.btListar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btListar.Location = new System.Drawing.Point(172, 150);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(140, 33);
            this.btListar.TabIndex = 1;
            this.btListar.Text = "LISTAR";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(88, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "MODIFICAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(322, 150);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(140, 33);
            this.btEliminar.TabIndex = 3;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENU EMPLEADOS";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.lbUsuario.Location = new System.Drawing.Point(324, 27);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(39, 16);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "label2";
            // 
            // btFichar
            // 
            this.btFichar.BackColor = System.Drawing.SystemColors.Window;
            this.btFichar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFichar.Location = new System.Drawing.Point(235, 214);
            this.btFichar.Name = "btFichar";
            this.btFichar.Size = new System.Drawing.Size(141, 33);
            this.btFichar.TabIndex = 20;
            this.btFichar.Text = "REGISTRAR HORAS";
            this.btFichar.UseVisualStyleBackColor = false;
            this.btFichar.Click += new System.EventHandler(this.btFichar_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Company.Properties.Resources._8680038_arrow_go_back_fill_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(320, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "VOLVER";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSalir
            // 
            this.btSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btSalir.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Image = global::Company.Properties.Resources._1564506_close_exit_logout_power_icon;
            this.btSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalir.Location = new System.Drawing.Point(408, 376);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(64, 23);
            this.btSalir.TabIndex = 18;
            this.btSalir.Text = "SALIR";
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Company.Properties.Resources.logoCodice;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MenuEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.btFichar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btInsertar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Empleados";
            this.Load += new System.EventHandler(this.MenuEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btFichar;
    }
}