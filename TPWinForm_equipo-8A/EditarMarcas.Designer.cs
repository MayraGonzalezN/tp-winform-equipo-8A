namespace TPWinForm_equipo_8A
{
    partial class EditarMarcas
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
            this.btnAceptarMarca = new System.Windows.Forms.Button();
            this.txtboxMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.txtboxEliminarMarca = new System.Windows.Forms.TextBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarMarca
            // 
            this.btnAceptarMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarMarca.Location = new System.Drawing.Point(388, 208);
            this.btnAceptarMarca.Name = "btnAceptarMarca";
            this.btnAceptarMarca.Size = new System.Drawing.Size(121, 30);
            this.btnAceptarMarca.TabIndex = 1;
            this.btnAceptarMarca.Text = "Agregar Marca";
            this.btnAceptarMarca.UseVisualStyleBackColor = true;
            this.btnAceptarMarca.Click += new System.EventHandler(this.btnAceptarMarca_Click);
            // 
            // txtboxMarca
            // 
            this.txtboxMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMarca.Location = new System.Drawing.Point(167, 206);
            this.txtboxMarca.Name = "txtboxMarca";
            this.txtboxMarca.Size = new System.Drawing.Size(176, 27);
            this.txtboxMarca.TabIndex = 0;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(23, 213);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(96, 20);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Nueva Marca";
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.Location = new System.Drawing.Point(388, 256);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(121, 31);
            this.btnEliminarMarca.TabIndex = 3;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // txtboxEliminarMarca
            // 
            this.txtboxEliminarMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEliminarMarca.Location = new System.Drawing.Point(167, 258);
            this.txtboxEliminarMarca.Name = "txtboxEliminarMarca";
            this.txtboxEliminarMarca.Size = new System.Drawing.Size(176, 27);
            this.txtboxEliminarMarca.TabIndex = 2;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(23, 261);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(139, 20);
            this.lblEliminar.TabIndex = 5;
            this.lblEliminar.Text = "ID Marca a Eliminar";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(27, 27);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(268, 127);
            this.dgvMarcas.TabIndex = 6;
            // 
            // EditarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 297);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.txtboxEliminarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtboxMarca);
            this.Controls.Add(this.btnAceptarMarca);
            this.Name = "EditarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar Marcas";
            this.Load += new System.EventHandler(this.EditarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarMarca;
        private System.Windows.Forms.TextBox txtboxMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.TextBox txtboxEliminarMarca;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.DataGridView dgvMarcas;
    }
}