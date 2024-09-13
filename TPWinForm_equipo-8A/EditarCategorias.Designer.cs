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
            this.BtnAgregarCategoria = new System.Windows.Forms.Button();
            this.BtnEliminarCategoria = new System.Windows.Forms.Button();
            this.dgvEditarCategorias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNuevaCategoria = new System.Windows.Forms.TextBox();
            this.TxtEliminarCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregarCategoria
            // 
            this.BtnAgregarCategoria.Location = new System.Drawing.Point(404, 94);
            this.BtnAgregarCategoria.Name = "BtnAgregarCategoria";
            this.BtnAgregarCategoria.Size = new System.Drawing.Size(125, 23);
            this.BtnAgregarCategoria.TabIndex = 0;
            this.BtnAgregarCategoria.Text = "Agregar Categoria";
            this.BtnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarCategoria
            // 
            this.BtnEliminarCategoria.Location = new System.Drawing.Point(404, 159);
            this.BtnEliminarCategoria.Name = "BtnEliminarCategoria";
            this.BtnEliminarCategoria.Size = new System.Drawing.Size(125, 23);
            this.BtnEliminarCategoria.TabIndex = 1;
            this.BtnEliminarCategoria.Text = "Eliminar";
            this.BtnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvEditarCategorias
            // 
            this.dgvEditarCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditarCategorias.Location = new System.Drawing.Point(21, 222);
            this.dgvEditarCategorias.Name = "dgvEditarCategorias";
            this.dgvEditarCategorias.Size = new System.Drawing.Size(342, 192);
            this.dgvEditarCategorias.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nueva Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Categoria a Eliminar";
            // 
            // TxtNuevaCategoria
            // 
            this.TxtNuevaCategoria.Location = new System.Drawing.Point(206, 94);
            this.TxtNuevaCategoria.Name = "TxtNuevaCategoria";
            this.TxtNuevaCategoria.Size = new System.Drawing.Size(157, 20);
            this.TxtNuevaCategoria.TabIndex = 5;
            // 
            // TxtEliminarCategoria
            // 
            this.TxtEliminarCategoria.Location = new System.Drawing.Point(206, 162);
            this.TxtEliminarCategoria.Name = "TxtEliminarCategoria";
            this.TxtEliminarCategoria.Size = new System.Drawing.Size(157, 20);
            this.TxtEliminarCategoria.TabIndex = 6;
            // 
            // EditarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.TxtEliminarCategoria);
            this.Controls.Add(this.TxtNuevaCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEditarCategorias);
            this.Controls.Add(this.BtnEliminarCategoria);
            this.Controls.Add(this.BtnAgregarCategoria);
            this.Name = "EditarCategorias";
            this.Text = "EditarCategorias";
            this.Load += new System.EventHandler(this.EditarCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarCategoria;
        private System.Windows.Forms.Button BtnEliminarCategoria;
        private System.Windows.Forms.DataGridView dgvEditarCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNuevaCategoria;
        private System.Windows.Forms.TextBox TxtEliminarCategoria;
    }
}