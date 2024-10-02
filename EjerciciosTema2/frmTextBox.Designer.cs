namespace EjerciciosTema2
{
    partial class frmTextBox
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
            this.txtBMusica = new System.Windows.Forms.TextBox();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.txtBContraseña = new System.Windows.Forms.TextBox();
            this.lblMusica = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnFoco = new System.Windows.Forms.Button();
            this.btnCambiarModo = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnVisible = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBMusica
            // 
            this.txtBMusica.Location = new System.Drawing.Point(194, 54);
            this.txtBMusica.Multiline = true;
            this.txtBMusica.Name = "txtBMusica";
            this.txtBMusica.Size = new System.Drawing.Size(315, 154);
            this.txtBMusica.TabIndex = 0;
            this.txtBMusica.Text = "Vows\r\nNirvana\r\nOmar Montes\r\n";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(194, 234);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(315, 22);
            this.txtBNombre.TabIndex = 1;
            this.txtBNombre.Text = "Nombre";
            // 
            // txtBContraseña
            // 
            this.txtBContraseña.Location = new System.Drawing.Point(194, 295);
            this.txtBContraseña.Name = "txtBContraseña";
            this.txtBContraseña.PasswordChar = '*';
            this.txtBContraseña.Size = new System.Drawing.Size(315, 22);
            this.txtBContraseña.TabIndex = 2;
            this.txtBContraseña.Text = "probando";
            // 
            // lblMusica
            // 
            this.lblMusica.AutoSize = true;
            this.lblMusica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMusica.Location = new System.Drawing.Point(67, 54);
            this.lblMusica.Name = "lblMusica";
            this.lblMusica.Size = new System.Drawing.Size(50, 16);
            this.lblMusica.TabIndex = 3;
            this.lblMusica.Text = "Música";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(67, 237);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContraseña.Location = new System.Drawing.Point(67, 301);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnFoco
            // 
            this.btnFoco.Location = new System.Drawing.Point(571, 70);
            this.btnFoco.Name = "btnFoco";
            this.btnFoco.Size = new System.Drawing.Size(127, 58);
            this.btnFoco.TabIndex = 6;
            this.btnFoco.Text = "Pasar Foco";
            this.btnFoco.UseVisualStyleBackColor = true;
            this.btnFoco.Click += new System.EventHandler(this.btnFoco_Click);
            // 
            // btnCambiarModo
            // 
            this.btnCambiarModo.Location = new System.Drawing.Point(571, 134);
            this.btnCambiarModo.Name = "btnCambiarModo";
            this.btnCambiarModo.Size = new System.Drawing.Size(127, 72);
            this.btnCambiarModo.TabIndex = 7;
            this.btnCambiarModo.Text = "Escritura";
            this.btnCambiarModo.UseVisualStyleBackColor = true;
            this.btnCambiarModo.Click += new System.EventHandler(this.btnCambiarModo_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(571, 212);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(127, 66);
            this.btnActivar.TabIndex = 8;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(571, 284);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(127, 68);
            this.btnVisible.TabIndex = 9;
            this.btnVisible.Text = "Hacer Visible";
            this.btnVisible.UseVisualStyleBackColor = true;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellido.Location = new System.Drawing.Point(67, 271);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido";
            // 
            // txtBApellido
            // 
            this.txtBApellido.Location = new System.Drawing.Point(194, 265);
            this.txtBApellido.Name = "txtBApellido";
            this.txtBApellido.Size = new System.Drawing.Size(315, 22);
            this.txtBApellido.TabIndex = 11;
            this.txtBApellido.Text = "Apellido";
            // 
            // frmTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.txtBApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnCambiarModo);
            this.Controls.Add(this.btnFoco);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMusica);
            this.Controls.Add(this.txtBContraseña);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.txtBMusica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTextBox";
            this.Text = "frmTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBMusica;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.TextBox txtBContraseña;
        private System.Windows.Forms.Label lblMusica;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnFoco;
        private System.Windows.Forms.Button btnCambiarModo;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnVisible;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBApellido;
    }
}