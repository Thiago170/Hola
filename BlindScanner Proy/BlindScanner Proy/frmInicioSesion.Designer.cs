namespace BlindScanner_Proy
{
    partial class frmInicioSesion
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
            this.lbIniciaSesion = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblNoTienesCuenta = new System.Windows.Forms.Label();
            this.lblRegis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIniciaSesion
            // 
            this.lbIniciaSesion.AutoSize = true;
            this.lbIniciaSesion.Location = new System.Drawing.Point(56, 82);
            this.lbIniciaSesion.Name = "lbIniciaSesion";
            this.lbIniciaSesion.Size = new System.Drawing.Size(68, 13);
            this.lbIniciaSesion.TabIndex = 0;
            this.lbIniciaSesion.Text = "Iniciar sesión";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Location = new System.Drawing.Point(56, 137);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(99, 13);
            this.lbNombreUsuario.TabIndex = 1;
            this.lbNombreUsuario.Text = "Nombre de usuario:";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(62, 189);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomUsuario.TabIndex = 2;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(59, 259);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(59, 311);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(62, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(165, 98);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Inicia sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblNoTienesCuenta
            // 
            this.lblNoTienesCuenta.AutoSize = true;
            this.lblNoTienesCuenta.Location = new System.Drawing.Point(62, 514);
            this.lblNoTienesCuenta.Name = "lblNoTienesCuenta";
            this.lblNoTienesCuenta.Size = new System.Drawing.Size(94, 13);
            this.lblNoTienesCuenta.TabIndex = 6;
            this.lblNoTienesCuenta.Text = "No tienes cuenta?";
            // 
            // lblRegis
            // 
            this.lblRegis.AutoSize = true;
            this.lblRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegis.Location = new System.Drawing.Point(65, 550);
            this.lblRegis.Name = "lblRegis";
            this.lblRegis.Size = new System.Drawing.Size(57, 13);
            this.lblRegis.TabIndex = 7;
            this.lblRegis.Text = "Regístrate";
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 794);
            this.Controls.Add(this.lblRegis);
            this.Controls.Add(this.lblNoTienesCuenta);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.lbIniciaSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicioSesion";
            this.Text = "frmInicioSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIniciaSesion;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNoTienesCuenta;
        private System.Windows.Forms.Label lblRegis;
    }
}