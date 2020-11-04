namespace ProyectoInicial
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TextBoxNombreCompleto = new System.Windows.Forms.TextBox();
			this.TextBoxId = new System.Windows.Forms.TextBox();
			this.TextBoxCarrera = new System.Windows.Forms.TextBox();
			this.ButtonAgregar = new System.Windows.Forms.Button();
			this.ButtonEditar = new System.Windows.Forms.Button();
			this.ButtonActualizar = new System.Windows.Forms.Button();
			this.ButtonEliminar = new System.Windows.Forms.Button();
			this.DataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewEstudiantes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(258, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Estudiantes";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre completo:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "ID:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 218);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Carrera:";
			// 
			// TextBoxNombreCompleto
			// 
			this.TextBoxNombreCompleto.Location = new System.Drawing.Point(150, 122);
			this.TextBoxNombreCompleto.Name = "TextBoxNombreCompleto";
			this.TextBoxNombreCompleto.Size = new System.Drawing.Size(247, 20);
			this.TextBoxNombreCompleto.TabIndex = 4;
			// 
			// TextBoxId
			// 
			this.TextBoxId.Location = new System.Drawing.Point(51, 163);
			this.TextBoxId.Name = "TextBoxId";
			this.TextBoxId.Size = new System.Drawing.Size(247, 20);
			this.TextBoxId.TabIndex = 5;
			// 
			// TextBoxCarrera
			// 
			this.TextBoxCarrera.Location = new System.Drawing.Point(85, 219);
			this.TextBoxCarrera.Name = "TextBoxCarrera";
			this.TextBoxCarrera.Size = new System.Drawing.Size(247, 20);
			this.TextBoxCarrera.TabIndex = 6;
			// 
			// ButtonAgregar
			// 
			this.ButtonAgregar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.ButtonAgregar.Location = new System.Drawing.Point(434, 131);
			this.ButtonAgregar.Name = "ButtonAgregar";
			this.ButtonAgregar.Size = new System.Drawing.Size(97, 52);
			this.ButtonAgregar.TabIndex = 7;
			this.ButtonAgregar.Text = "Agregar";
			this.ButtonAgregar.UseVisualStyleBackColor = true;
			// 
			// ButtonEditar
			// 
			this.ButtonEditar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.ButtonEditar.Location = new System.Drawing.Point(537, 131);
			this.ButtonEditar.Name = "ButtonEditar";
			this.ButtonEditar.Size = new System.Drawing.Size(97, 52);
			this.ButtonEditar.TabIndex = 8;
			this.ButtonEditar.Text = "Editar";
			this.ButtonEditar.UseVisualStyleBackColor = true;
			// 
			// ButtonActualizar
			// 
			this.ButtonActualizar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.ButtonActualizar.Location = new System.Drawing.Point(434, 189);
			this.ButtonActualizar.Name = "ButtonActualizar";
			this.ButtonActualizar.Size = new System.Drawing.Size(97, 52);
			this.ButtonActualizar.TabIndex = 9;
			this.ButtonActualizar.Text = "Actualizar";
			this.ButtonActualizar.UseVisualStyleBackColor = true;
			// 
			// ButtonEliminar
			// 
			this.ButtonEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.ButtonEliminar.Location = new System.Drawing.Point(537, 189);
			this.ButtonEliminar.Name = "ButtonEliminar";
			this.ButtonEliminar.Size = new System.Drawing.Size(97, 52);
			this.ButtonEliminar.TabIndex = 10;
			this.ButtonEliminar.Text = "Eliminar";
			this.ButtonEliminar.UseVisualStyleBackColor = true;
			// 
			// DataGridViewEstudiantes
			// 
			this.DataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridViewEstudiantes.Location = new System.Drawing.Point(4, 263);
			this.DataGridViewEstudiantes.Name = "DataGridViewEstudiantes";
			this.DataGridViewEstudiantes.Size = new System.Drawing.Size(658, 214);
			this.DataGridViewEstudiantes.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 487);
			this.Controls.Add(this.DataGridViewEstudiantes);
			this.Controls.Add(this.ButtonEliminar);
			this.Controls.Add(this.ButtonActualizar);
			this.Controls.Add(this.ButtonEditar);
			this.Controls.Add(this.ButtonAgregar);
			this.Controls.Add(this.TextBoxCarrera);
			this.Controls.Add(this.TextBoxId);
			this.Controls.Add(this.TextBoxNombreCompleto);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewEstudiantes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TextBoxNombreCompleto;
		private System.Windows.Forms.TextBox TextBoxId;
		private System.Windows.Forms.TextBox TextBoxCarrera;
		private System.Windows.Forms.Button ButtonAgregar;
		private System.Windows.Forms.Button ButtonEditar;
		private System.Windows.Forms.Button ButtonActualizar;
		private System.Windows.Forms.Button ButtonEliminar;
		private System.Windows.Forms.DataGridView DataGridViewEstudiantes;
	}
}

