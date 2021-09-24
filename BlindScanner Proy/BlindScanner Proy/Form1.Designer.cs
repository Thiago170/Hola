namespace BlindScanner_Proy
{
    partial class frmRegistro
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
            this.lblRegistrate = new System.Windows.Forms.Label();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblYt = new System.Windows.Forms.Label();
            this.lblIiinciSesionRegistr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegistrate
            // 
            this.lblRegistrate.AutoSize = true;
            this.lblRegistrate.Location = new System.Drawing.Point(73, 111);
            this.lblRegistrate.Name = "lblRegistrate";
            this.lblRegistrate.Size = new System.Drawing.Size(57, 13);
            this.lblRegistrate.TabIndex = 0;
            this.lblRegistrate.Text = "Regístrate";
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(76, 198);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(99, 13);
            this.lblNombreDeUsuario.TabIndex = 1;
            this.lblNombreDeUsuario.Text = "Nombre de usuario:";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(79, 239);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomUsuario.TabIndex = 2;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(79, 307);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(82, 375);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(82, 465);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(141, 81);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Registrate";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblYt
            // 
            this.lblYt.AutoSize = true;
            this.lblYt.Location = new System.Drawing.Point(82, 602);
            this.lblYt.Name = "lblYt";
            this.lblYt.Size = new System.Drawing.Size(114, 13);
            this.lblYt.TabIndex = 6;
            this.lblYt.Text = "Ya tienes una cuenta?";
            // 
            // lblIiinciSesionRegistr
            // 
            this.lblIiinciSesionRegistr.AutoSize = true;
            this.lblIiinciSesionRegistr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIiinciSesionRegistr.Location = new System.Drawing.Point(85, 628);
            this.lblIiinciSesionRegistr.Name = "lblIiinciSesionRegistr";
            this.lblIiinciSesionRegistr.Size = new System.Drawing.Size(65, 13);
            this.lblIiinciSesionRegistr.TabIndex = 7;
            this.lblIiinciSesionRegistr.Text = "Inicia sesión";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 812);
            this.Controls.Add(this.lblIiinciSesionRegistr);
            this.Controls.Add(this.lblYt);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.lblNombreDeUsuario);
            this.Controls.Add(this.lblRegistrate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistro";
            this.Text = "frmRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrate;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblYt;
        private System.Windows.Forms.Label lblIiinciSesionRegistr;
    }
}

