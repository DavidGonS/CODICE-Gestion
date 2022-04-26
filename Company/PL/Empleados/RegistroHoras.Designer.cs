namespace Company.PL.Empleados
{
    partial class RegistroHoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroHoras));
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaImputacion = new System.Windows.Forms.DateTimePicker();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label1.Location = new System.Drawing.Point(171, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbId.Location = new System.Drawing.Point(207, 72);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(75, 20);
            this.tbId.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btBuscar.Image = global::Company.Properties.Resources._3844432_magnifier_search_zoom_icon;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(207, 109);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label2.Location = new System.Drawing.Point(171, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label3.Location = new System.Drawing.Point(171, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label4.Location = new System.Drawing.Point(171, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero horas:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.lbNombre.Location = new System.Drawing.Point(232, 158);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(39, 16);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "label5";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.lbApellido.Location = new System.Drawing.Point(232, 195);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(39, 16);
            this.lbApellido.TabIndex = 7;
            this.lbApellido.Text = "label6";
            // 
            // tbHoras
            // 
            this.tbHoras.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbHoras.Location = new System.Drawing.Point(256, 224);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(63, 20);
            this.tbHoras.TabIndex = 8;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.Window;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btGuardar.Image = global::Company.Properties.Resources._285657_floppy_guardar_save_icon;
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar.Location = new System.Drawing.Point(207, 304);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(84, 23);
            this.btGuardar.TabIndex = 9;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Company.Properties.Resources.logoCodice;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label7.Location = new System.Drawing.Point(171, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha:";
            // 
            // dtpFechaImputacion
            // 
            this.dtpFechaImputacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaImputacion.Location = new System.Drawing.Point(219, 259);
            this.dtpFechaImputacion.Name = "dtpFechaImputacion";
            this.dtpFechaImputacion.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaImputacion.TabIndex = 12;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.lbUsuario.Location = new System.Drawing.Point(391, 37);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(39, 16);
            this.lbUsuario.TabIndex = 13;
            this.lbUsuario.Text = "label5";
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
            this.button1.TabIndex = 21;
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
            this.btSalir.TabIndex = 20;
            this.btSalir.Text = "SALIR";
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // RegistroHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.dtpFechaImputacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroHoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroHoras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaImputacion;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSalir;
    }
}