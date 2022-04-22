namespace Company.PL
{
    partial class InsertarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarEmpleado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPrimerApellido = new System.Windows.Forms.TextBox();
            this.tbSegundoApellido = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreDepartamento = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaIncorporacion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNombre.Location = new System.Drawing.Point(36, 104);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbPrimerApellido
            // 
            this.tbPrimerApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbPrimerApellido.Location = new System.Drawing.Point(36, 159);
            this.tbPrimerApellido.Name = "tbPrimerApellido";
            this.tbPrimerApellido.Size = new System.Drawing.Size(100, 20);
            this.tbPrimerApellido.TabIndex = 5;
            // 
            // tbSegundoApellido
            // 
            this.tbSegundoApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSegundoApellido.Location = new System.Drawing.Point(36, 212);
            this.tbSegundoApellido.Name = "tbSegundoApellido";
            this.tbSegundoApellido.Size = new System.Drawing.Size(100, 20);
            this.tbSegundoApellido.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbEmail.Location = new System.Drawing.Point(36, 262);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(330, 20);
            this.tbEmail.TabIndex = 7;
            // 
            // btEnviar
            // 
            this.btEnviar.BackColor = System.Drawing.SystemColors.Window;
            this.btEnviar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviar.Location = new System.Drawing.Point(36, 439);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 23);
            this.btEnviar.TabIndex = 8;
            this.btEnviar.Text = "CREAR";
            this.btEnviar.UseVisualStyleBackColor = false;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Company.Properties.Resources.logoCodice;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre Departamento:";
            // 
            // tbNombreDepartamento
            // 
            this.tbNombreDepartamento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNombreDepartamento.Location = new System.Drawing.Point(36, 320);
            this.tbNombreDepartamento.Name = "tbNombreDepartamento";
            this.tbNombreDepartamento.Size = new System.Drawing.Size(330, 20);
            this.tbNombreDepartamento.TabIndex = 11;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(324, 27);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbUsuario.TabIndex = 12;
            this.lbUsuario.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Incorporación:";
            // 
            // dtpFechaIncorporacion
            // 
            this.dtpFechaIncorporacion.CalendarForeColor = System.Drawing.SystemColors.HotTrack;
            this.dtpFechaIncorporacion.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpFechaIncorporacion.CalendarTitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.dtpFechaIncorporacion.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dtpFechaIncorporacion.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.dtpFechaIncorporacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIncorporacion.Location = new System.Drawing.Point(36, 382);
            this.dtpFechaIncorporacion.Name = "dtpFechaIncorporacion";
            this.dtpFechaIncorporacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIncorporacion.TabIndex = 15;
            this.dtpFechaIncorporacion.ValueChanged += new System.EventHandler(this.dtpFechaIncorporacion_ValueChanged);
            // 
            // InsertarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 541);
            this.Controls.Add(this.dtpFechaIncorporacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.tbNombreDepartamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSegundoApellido);
            this.Controls.Add(this.tbPrimerApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPrimerApellido;
        private System.Windows.Forms.TextBox tbSegundoApellido;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombreDepartamento;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaIncorporacion;
    }
}