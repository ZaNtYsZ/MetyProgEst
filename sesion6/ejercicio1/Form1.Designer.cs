namespace ejercicio1
{
    partial class Form1
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
            this.nombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cmbNombres = new System.Windows.Forms.ComboBox();
            this.btmNombre2 = new System.Windows.Forms.ComboBox();
            this.btmMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(12, 43);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(47, 13);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre:";
            this.nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Image = global::ejercicio1.Properties.Resources.boton_mas;
            this.btnAgregar.Location = new System.Drawing.Point(461, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(51, 45);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbNombre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbNombre.Location = new System.Drawing.Point(62, 40);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(393, 20);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // cmbNombres
            // 
            this.cmbNombres.FormattingEnabled = true;
            this.cmbNombres.Location = new System.Drawing.Point(62, 98);
            this.cmbNombres.Name = "cmbNombres";
            this.cmbNombres.Size = new System.Drawing.Size(393, 21);
            this.cmbNombres.TabIndex = 3;
            // 
            // btmNombre2
            // 
            this.btmNombre2.FormattingEnabled = true;
            this.btmNombre2.Location = new System.Drawing.Point(62, 174);
            this.btmNombre2.Name = "btmNombre2";
            this.btmNombre2.Size = new System.Drawing.Size(393, 21);
            this.btmNombre2.TabIndex = 4;
            // 
            // btmMover
            // 
            this.btmMover.Location = new System.Drawing.Point(168, 125);
            this.btmMover.Name = "btmMover";
            this.btmMover.Size = new System.Drawing.Size(206, 43);
            this.btmMover.TabIndex = 5;
            this.btmMover.Text = "Mover todos los elemnetos";
            this.btmMover.UseVisualStyleBackColor = true;
            this.btmMover.Click += new System.EventHandler(this.btmMover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 369);
            this.Controls.Add(this.btmMover);
            this.Controls.Add(this.btmNombre2);
            this.Controls.Add(this.cmbNombres);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbNombre;
        protected System.Windows.Forms.Label nombre;
        private System.Windows.Forms.ComboBox cmbNombres;
        private System.Windows.Forms.ComboBox btmNombre2;
        private System.Windows.Forms.Button btmMover;
    }
}

