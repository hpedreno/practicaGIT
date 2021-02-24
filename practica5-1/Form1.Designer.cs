
namespace practica5_1
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
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.labelAluNombre = new System.Windows.Forms.Label();
            this.labelAluNota = new System.Windows.Forms.Label();
            this.aluNota = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelListaAlumnos = new System.Windows.Forms.Label();
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(12, 52);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(305, 20);
            this.aluNombre.TabIndex = 0;
            // 
            // labelAluNombre
            // 
            this.labelAluNombre.AutoSize = true;
            this.labelAluNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAluNombre.Location = new System.Drawing.Point(12, 29);
            this.labelAluNombre.Name = "labelAluNombre";
            this.labelAluNombre.Size = new System.Drawing.Size(121, 20);
            this.labelAluNombre.TabIndex = 1;
            this.labelAluNombre.Text = "Nombre alumno";
            // 
            // labelAluNota
            // 
            this.labelAluNota.AutoSize = true;
            this.labelAluNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAluNota.Location = new System.Drawing.Point(398, 29);
            this.labelAluNota.Name = "labelAluNota";
            this.labelAluNota.Size = new System.Drawing.Size(43, 20);
            this.labelAluNota.TabIndex = 2;
            this.labelAluNota.Text = "Nota";
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(402, 52);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(134, 20);
            this.aluNota.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar Alumnos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelListaAlumnos
            // 
            this.labelListaAlumnos.AutoSize = true;
            this.labelListaAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaAlumnos.Location = new System.Drawing.Point(16, 121);
            this.labelListaAlumnos.Name = "labelListaAlumnos";
            this.labelListaAlumnos.Size = new System.Drawing.Size(131, 20);
            this.labelListaAlumnos.TabIndex = 5;
            this.labelListaAlumnos.Text = "Lista de Alumnos";
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listaAlumnos.Location = new System.Drawing.Point(12, 144);
            this.listaAlumnos.Multiline = true;
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(776, 262);
            this.listaAlumnos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.labelListaAlumnos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.labelAluNota);
            this.Controls.Add(this.labelAluNombre);
            this.Controls.Add(this.aluNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAluNombre;
        private System.Windows.Forms.Label labelAluNota;
        private System.Windows.Forms.Label labelListaAlumnos;
        private System.Windows.Forms.TextBox aluNombre;
        private System.Windows.Forms.TextBox aluNota;
        private System.Windows.Forms.TextBox listaAlumnos;
        private System.Windows.Forms.Button button1;

    }
}

