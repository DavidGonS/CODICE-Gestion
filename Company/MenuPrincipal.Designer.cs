﻿namespace Company
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btDepartamento = new System.Windows.Forms.Button();
            this.btEmpleados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btDepartamento
            // 
            this.btDepartamento.BackColor = System.Drawing.SystemColors.Window;
            this.btDepartamento.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDepartamento.Location = new System.Drawing.Point(36, 155);
            this.btDepartamento.Name = "btDepartamento";
            this.btDepartamento.Size = new System.Drawing.Size(147, 134);
            this.btDepartamento.TabIndex = 0;
            this.btDepartamento.Text = "DEPARTAMENTOS";
            this.btDepartamento.UseVisualStyleBackColor = false;
            this.btDepartamento.Click += new System.EventHandler(this.btDepartamento_Click);
            // 
            // btEmpleados
            // 
            this.btEmpleados.BackColor = System.Drawing.SystemColors.Window;
            this.btEmpleados.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmpleados.Location = new System.Drawing.Point(278, 155);
            this.btEmpleados.Name = "btEmpleados";
            this.btEmpleados.Size = new System.Drawing.Size(147, 134);
            this.btEmpleados.TabIndex = 1;
            this.btEmpleados.Text = "EMPLEADOS";
            this.btEmpleados.UseVisualStyleBackColor = false;
            this.btEmpleados.Click += new System.EventHandler(this.btEmpleados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Company.Properties.Resources.logoCodice;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(324, 27);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbUsuario.TabIndex = 3;
            this.lbUsuario.Text = "label1";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 451);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btEmpleados);
            this.Controls.Add(this.btDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDepartamento;
        private System.Windows.Forms.Button btEmpleados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUsuario;
    }
}

