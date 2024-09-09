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
            this.txtListadoMarca = new System.Windows.Forms.TextBox();
            this.dvgListarxMarca = new System.Windows.Forms.DataGridView();
            this.btnListadoMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarxMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(13, 13);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "MARCA: ";
            // 
            // txtListadoMarca
            // 
            this.txtListadoMarca.Location = new System.Drawing.Point(71, 5);
            this.txtListadoMarca.Name = "txtListadoMarca";
            this.txtListadoMarca.Size = new System.Drawing.Size(100, 20);
            this.txtListadoMarca.TabIndex = 1;
            // 
            // dvgListarxMarca
            // 
            this.dvgListarxMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListarxMarca.Location = new System.Drawing.Point(71, 31);
            this.dvgListarxMarca.Name = "dvgListarxMarca";
            this.dvgListarxMarca.Size = new System.Drawing.Size(353, 245);
            this.dvgListarxMarca.TabIndex = 2;
            // 
            // btnListadoMarca
            // 
            this.btnListadoMarca.Location = new System.Drawing.Point(177, 2);
            this.btnListadoMarca.Name = "btnListadoMarca";
            this.btnListadoMarca.Size = new System.Drawing.Size(75, 23);
            this.btnListadoMarca.TabIndex = 3;
            this.btnListadoMarca.Text = "Buscar";
            this.btnListadoMarca.UseVisualStyleBackColor = true;
            this.btnListadoMarca.Click += new System.EventHandler(this.btnListadoMarca_Click);
            // 
            // ListarxMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListadoMarca);
            this.Controls.Add(this.dvgListarxMarca);
            this.Controls.Add(this.txtListadoMarca);
            this.Controls.Add(this.lblMarca);
            this.Name = "ListarxMarca";
            this.Text = "ListarxMarca";
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarxMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtListadoMarca;
        private System.Windows.Forms.DataGridView dvgListarxMarca;
        private System.Windows.Forms.Button btnListadoMarca;
    }
}