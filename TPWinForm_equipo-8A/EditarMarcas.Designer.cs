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
            this.btnAceptarMarca.Location = new System.Drawing.Point(385, 68);
            this.btnAceptarMarca.Name = "btnAceptarMarca";
            this.btnAceptarMarca.Size = new System.Drawing.Size(121, 23);
            this.btnAceptarMarca.TabIndex = 0;
            this.btnAceptarMarca.Text = "Agregar Marca";
            this.btnAceptarMarca.UseVisualStyleBackColor = true;
            this.btnAceptarMarca.Click += new System.EventHandler(this.btnAceptarMarca_Click);
            // 
            // txtboxMarca
            // 
            this.txtboxMarca.Location = new System.Drawing.Point(183, 65);
            this.txtboxMarca.Name = "txtboxMarca";
            this.txtboxMarca.Size = new System.Drawing.Size(143, 20);
            this.txtboxMarca.TabIndex = 1;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(70, 68);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Nueva Marca";
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(385, 132);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(121, 23);
            this.btnEliminarMarca.TabIndex = 3;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // txtboxEliminarMarca
            // 
            this.txtboxEliminarMarca.Location = new System.Drawing.Point(183, 132);
            this.txtboxEliminarMarca.Name = "txtboxEliminarMarca";
            this.txtboxEliminarMarca.Size = new System.Drawing.Size(143, 20);
            this.txtboxEliminarMarca.TabIndex = 4;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Location = new System.Drawing.Point(61, 137);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(99, 13);
            this.lblEliminar.TabIndex = 5;
            this.lblEliminar.Text = "ID Marca a Eliminar";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(64, 207);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(330, 248);
            this.dgvMarcas.TabIndex = 6;
            // 
            // EditarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 538);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.txtboxEliminarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtboxMarca);
            this.Controls.Add(this.btnAceptarMarca);
            this.Name = "EditarMarcas";
            this.Text = "EditarMarcas";
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