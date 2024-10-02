namespace EjerciciosTema2
{
    partial class frmInicio
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
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnListaImagen = new System.Windows.Forms.Button();
            this.btnColores = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnCajas = new System.Windows.Forms.Button();
            this.btnComboBox = new System.Windows.Forms.Button();
            this.btnGamaColor = new System.Windows.Forms.Button();
            this.btnTemporizador = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnTextBox = new System.Windows.Forms.Button();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.LightBlue;
            this.pnlOpciones.Controls.Add(this.btnListaImagen);
            this.pnlOpciones.Controls.Add(this.btnColores);
            this.pnlOpciones.Controls.Add(this.btnListas);
            this.pnlOpciones.Controls.Add(this.btnCajas);
            this.pnlOpciones.Controls.Add(this.btnComboBox);
            this.pnlOpciones.Controls.Add(this.btnGamaColor);
            this.pnlOpciones.Controls.Add(this.btnTemporizador);
            this.pnlOpciones.Controls.Add(this.btnCalendario);
            this.pnlOpciones.Controls.Add(this.btnTriangulo);
            this.pnlOpciones.Controls.Add(this.btnTextBox);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(211, 456);
            this.pnlOpciones.TabIndex = 0;
            // 
            // btnListaImagen
            // 
            this.btnListaImagen.Location = new System.Drawing.Point(24, 372);
            this.btnListaImagen.Name = "btnListaImagen";
            this.btnListaImagen.Size = new System.Drawing.Size(157, 34);
            this.btnListaImagen.TabIndex = 9;
            this.btnListaImagen.Text = "10 Lista Imágenes";
            this.btnListaImagen.UseVisualStyleBackColor = true;
            // 
            // btnColores
            // 
            this.btnColores.Location = new System.Drawing.Point(24, 92);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(157, 34);
            this.btnColores.TabIndex = 8;
            this.btnColores.Text = "03 Colores";
            this.btnColores.UseVisualStyleBackColor = true;
            // 
            // btnListas
            // 
            this.btnListas.Location = new System.Drawing.Point(24, 132);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(157, 34);
            this.btnListas.TabIndex = 7;
            this.btnListas.Text = "04 Listas";
            this.btnListas.UseVisualStyleBackColor = true;
            // 
            // btnCajas
            // 
            this.btnCajas.Location = new System.Drawing.Point(24, 172);
            this.btnCajas.Name = "btnCajas";
            this.btnCajas.Size = new System.Drawing.Size(157, 34);
            this.btnCajas.TabIndex = 6;
            this.btnCajas.Text = "05 Cajas";
            this.btnCajas.UseVisualStyleBackColor = true;
            // 
            // btnComboBox
            // 
            this.btnComboBox.Location = new System.Drawing.Point(24, 212);
            this.btnComboBox.Name = "btnComboBox";
            this.btnComboBox.Size = new System.Drawing.Size(157, 34);
            this.btnComboBox.TabIndex = 5;
            this.btnComboBox.Text = "06 ComboBox";
            this.btnComboBox.UseVisualStyleBackColor = true;
            // 
            // btnGamaColor
            // 
            this.btnGamaColor.Location = new System.Drawing.Point(24, 332);
            this.btnGamaColor.Name = "btnGamaColor";
            this.btnGamaColor.Size = new System.Drawing.Size(157, 34);
            this.btnGamaColor.TabIndex = 4;
            this.btnGamaColor.Text = "09 GamaColores";
            this.btnGamaColor.UseVisualStyleBackColor = true;
            // 
            // btnTemporizador
            // 
            this.btnTemporizador.Location = new System.Drawing.Point(24, 292);
            this.btnTemporizador.Name = "btnTemporizador";
            this.btnTemporizador.Size = new System.Drawing.Size(157, 34);
            this.btnTemporizador.TabIndex = 3;
            this.btnTemporizador.Text = "08 Temporizador";
            this.btnTemporizador.UseVisualStyleBackColor = true;
            // 
            // btnCalendario
            // 
            this.btnCalendario.Location = new System.Drawing.Point(24, 252);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(157, 34);
            this.btnCalendario.TabIndex = 2;
            this.btnCalendario.Text = "07 Calendarios";
            this.btnCalendario.UseVisualStyleBackColor = true;
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(24, 52);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(157, 34);
            this.btnTriangulo.TabIndex = 1;
            this.btnTriangulo.Text = "02 Triángulos";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnTextBox
            // 
            this.btnTextBox.Location = new System.Drawing.Point(24, 12);
            this.btnTextBox.Name = "btnTextBox";
            this.btnTextBox.Size = new System.Drawing.Size(157, 34);
            this.btnTextBox.TabIndex = 0;
            this.btnTextBox.Text = "01 TextBox";
            this.btnTextBox.UseVisualStyleBackColor = true;
            this.btnTextBox.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(950, 456);
            this.Controls.Add(this.pnlOpciones);
            this.IsMdiContainer = true;
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.pnlOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnTextBox;
        private System.Windows.Forms.Button btnListaImagen;
        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Button btnCajas;
        private System.Windows.Forms.Button btnComboBox;
        private System.Windows.Forms.Button btnGamaColor;
        private System.Windows.Forms.Button btnTemporizador;
        private System.Windows.Forms.Button btnCalendario;
    }
}

