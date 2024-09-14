namespace TPWinForm_equipo_8A
{
    partial class ListarxMarca
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dvgListarxMarca = new System.Windows.Forms.DataGridView();
            this.btnListadoMarca = new System.Windows.Forms.Button();
            this.lblMenorPrecio = new System.Windows.Forms.Label();
            this.btnMenorPrecio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarxMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(35, 20);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 17);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(86, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(106, 25);
            this.txtBusqueda.TabIndex = 0;
            // 
            // dvgListarxMarca
            // 
            this.dvgListarxMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListarxMarca.Location = new System.Drawing.Point(38, 52);
            this.dvgListarxMarca.Name = "dvgListarxMarca";
            this.dvgListarxMarca.Size = new System.Drawing.Size(517, 165);
            this.dvgListarxMarca.TabIndex = 2;
            this.dvgListarxMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgListarxMarca_CellContentClick);
            // 
            // btnListadoMarca
            // 
            this.btnListadoMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoMarca.Location = new System.Drawing.Point(198, 12);
            this.btnListadoMarca.Name = "btnListadoMarca";
            this.btnListadoMarca.Size = new System.Drawing.Size(78, 26);
            this.btnListadoMarca.TabIndex = 1;
            this.btnListadoMarca.Text = "Buscar";
            this.btnListadoMarca.UseVisualStyleBackColor = true;
            this.btnListadoMarca.Click += new System.EventHandler(this.btnListadoMarca_Click);
            // 
            // lblMenorPrecio
            // 
            this.lblMenorPrecio.AutoSize = true;
            this.lblMenorPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenorPrecio.Location = new System.Drawing.Point(35, 249);
            this.lblMenorPrecio.Name = "lblMenorPrecio";
            this.lblMenorPrecio.Size = new System.Drawing.Size(87, 17);
            this.lblMenorPrecio.TabIndex = 4;
            this.lblMenorPrecio.Text = "Menor Precio";
            this.lblMenorPrecio.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMenorPrecio
            // 
            this.btnMenorPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenorPrecio.Location = new System.Drawing.Point(128, 245);
            this.btnMenorPrecio.Name = "btnMenorPrecio";
            this.btnMenorPrecio.Size = new System.Drawing.Size(72, 25);
            this.btnMenorPrecio.TabIndex = 2;
            this.btnMenorPrecio.Text = "Buscar";
            this.btnMenorPrecio.UseVisualStyleBackColor = true;
            this.btnMenorPrecio.Click += new System.EventHandler(this.btnMenorPrecio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 165);
            this.dataGridView1.TabIndex = 6;
            // 
            // ListarxMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMenorPrecio);
            this.Controls.Add(this.lblMenorPrecio);
            this.Controls.Add(this.btnListadoMarca);
            this.Controls.Add(this.dvgListarxMarca);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblMarca);
            this.Name = "ListarxMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.ListarxMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarxMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dvgListarxMarca;
        private System.Windows.Forms.Button btnListadoMarca;
        private System.Windows.Forms.Label lblMenorPrecio;
        private System.Windows.Forms.Button btnMenorPrecio;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}