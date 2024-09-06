namespace EvalueEdge
{
    partial class EvalueAge
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
            this.label1 = new System.Windows.Forms.Label();
            this.evaluate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce tu edad: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // evaluate
            // 
            this.evaluate.Location = new System.Drawing.Point(320, 16);
            this.evaluate.Name = "evaluate";
            this.evaluate.Size = new System.Drawing.Size(99, 24);
            this.evaluate.TabIndex = 1;
            this.evaluate.Text = "Evaluar";
            this.evaluate.UseVisualStyleBackColor = true;
            this.evaluate.Click += new System.EventHandler(this.evaluate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 2;
            // 
            // IblAnswer
            // 
            this.IblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IblAnswer.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblAnswer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.IblAnswer.Location = new System.Drawing.Point(16, 79);
            this.IblAnswer.Name = "IblAnswer";
            this.IblAnswer.Size = new System.Drawing.Size(453, 74);
            this.IblAnswer.TabIndex = 3;
            this.IblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EvalueAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 391);
            this.Controls.Add(this.IblAnswer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.evaluate);
            this.Controls.Add(this.label1);
            this.Name = "EvalueAge";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button evaluate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label IblAnswer;
    }
}

