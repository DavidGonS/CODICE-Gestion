namespace Company.PL.ExtraWindows
{
    partial class SalirAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalirAplicacion));
            this.label1 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.btNoSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Estás seguro de que desea salir?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btSalir.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btSalir.Location = new System.Drawing.Point(32, 59);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "SÍ";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btNoSalir
            // 
            this.btNoSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btNoSalir.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btNoSalir.Location = new System.Drawing.Point(128, 59);
            this.btNoSalir.Name = "btNoSalir";
            this.btNoSalir.Size = new System.Drawing.Size(75, 23);
            this.btNoSalir.TabIndex = 2;
            this.btNoSalir.Text = "NO";
            this.btNoSalir.UseVisualStyleBackColor = false;
            this.btNoSalir.Click += new System.EventHandler(this.btNoSalir_Click);
            // 
            // SalirAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.btNoSalir);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalirAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalirAplicacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btNoSalir;
    }
}