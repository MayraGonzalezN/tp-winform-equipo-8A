namespace TPWinForm_equipo_8A
{
    partial class EditarCategorias
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
            this.BtnEliminarCategoria = new System.Windows.Forms.Button();
            this.dgvEditarCategorias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNuevaCategoria = new System.Windows.Forms.TextBox();
            this.TxtEliminarCategoria = new System.Windows.Forms.TextBox();
            this.btnAceptarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminarCategoria
            // 
            this.BtnEliminarCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCategoria.Location = new System.Drawing.Point(404, 348);
            this.BtnEliminarCategoria.Name = "BtnEliminarCategoria";
            this.BtnEliminarCategoria.Size = new System.Drawing.Size(125, 30);
            this.BtnEliminarCategoria.TabIndex = 3;
            this.BtnEliminarCategoria.Text = "Eliminar";
            this.BtnEliminarCategoria.UseVisualStyleBackColor = true;
            this.BtnEliminarCategoria.Click += new System.EventHandler(this.BtnEliminarCategoria_Click);
            // 
            // dgvEditarCategorias
            // 
            this.dgvEditarCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditarCategorias.Location = new System.Drawing.Point(25, 30);
            this.dgvEditarCategorias.Name = "dgvEditarCategorias";
            this.dgvEditarCategorias.Size = new System.Drawing.Size(244, 192);
            this.dgvEditarCategorias.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nueva Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Categoria a Eliminar";
            // 
            // TxtNuevaCategoria
            // 
            this.TxtNuevaCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNuevaCategoria.Location = new System.Drawing.Point(190, 284);
            this.TxtNuevaCategoria.Name = "TxtNuevaCategoria";
            this.TxtNuevaCategoria.Size = new System.Drawing.Size(157, 27);
            this.TxtNuevaCategoria.TabIndex = 0;
            // 
            // TxtEliminarCategoria
            // 
            this.TxtEliminarCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEliminarCategoria.Location = new System.Drawing.Point(190, 351);
            this.TxtEliminarCategoria.Name = "TxtEliminarCategoria";
            this.TxtEliminarCategoria.Size = new System.Drawing.Size(157, 27);
            this.TxtEliminarCategoria.TabIndex = 2;
            // 
            // btnAceptarCategoria
            // 
            this.btnAceptarCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCategoria.Location = new System.Drawing.Point(404, 284);
            this.btnAceptarCategoria.Name = "btnAceptarCategoria";
            this.btnAceptarCategoria.Size = new System.Drawing.Size(125, 30);
            this.btnAceptarCategoria.TabIndex = 1;
            this.btnAceptarCategoria.Text = "Agregar Categoria";
            this.btnAceptarCategoria.UseVisualStyleBackColor = true;
             this.btnAceptarCategoria.Click += new System.EventHandler(this.btnAceptarCategoria_Click);
            // 
            // EditarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 409);
            this.Controls.Add(this.btnAceptarCategoria);
            this.Controls.Add(this.TxtEliminarCategoria);
            this.Controls.Add(this.TxtNuevaCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEditarCategorias);
            this.Controls.Add(this.BtnEliminarCategoria);
            this.Name = "EditarCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar Categorias";
            this.Load += new System.EventHandler(this.EditarCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEliminarCategoria;
        private System.Windows.Forms.DataGridView dgvEditarCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNuevaCategoria;
        private System.Windows.Forms.TextBox TxtEliminarCategoria;
        private System.Windows.Forms.Button btnAceptarCategoria;
    }
}