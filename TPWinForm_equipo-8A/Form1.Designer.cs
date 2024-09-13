namespace TPWinForm_equipo_8A
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ListadoDesplegable = new System.Windows.Forms.ToolStripMenuItem();
            this.aRTICULOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarXMARCAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirDesplegable = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpImagenXArt = new System.Windows.Forms.FlowLayoutPanel();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListadoDesplegable,
            this.mARCASToolStripMenuItem,
            this.SalirDesplegable});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ListadoDesplegable
            // 
            this.ListadoDesplegable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRTICULOSToolStripMenuItem1,
            this.ListarXMARCAToolStripMenuItem});
            this.ListadoDesplegable.Name = "ListadoDesplegable";
            resources.ApplyResources(this.ListadoDesplegable, "ListadoDesplegable");
            // 
            // aRTICULOSToolStripMenuItem1
            // 
            this.aRTICULOSToolStripMenuItem1.Name = "aRTICULOSToolStripMenuItem1";
            resources.ApplyResources(this.aRTICULOSToolStripMenuItem1, "aRTICULOSToolStripMenuItem1");
            this.aRTICULOSToolStripMenuItem1.Click += new System.EventHandler(this.aRTICULOSToolStripMenuItem1_Click);
            // 
            // ListarXMARCAToolStripMenuItem
            // 
            this.ListarXMARCAToolStripMenuItem.Name = "ListarXMARCAToolStripMenuItem";
            resources.ApplyResources(this.ListarXMARCAToolStripMenuItem, "ListarXMARCAToolStripMenuItem");
            this.ListarXMARCAToolStripMenuItem.Click += new System.EventHandler(this.ListarXMARCAToolStripMenuItem_Click);
            // 
            // SalirDesplegable
            // 
            this.SalirDesplegable.Name = "SalirDesplegable";
            resources.ApplyResources(this.SalirDesplegable, "SalirDesplegable");
            this.SalirDesplegable.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // mARCASToolStripMenuItem
            // 
            this.mARCASToolStripMenuItem.Name = "mARCASToolStripMenuItem";
            resources.ApplyResources(this.mARCASToolStripMenuItem, "mARCASToolStripMenuItem");
            this.mARCASToolStripMenuItem.Click += new System.EventHandler(this.mARCASToolStripMenuItem_Click);
            // 
            // flpImagenXArt
            // 
            resources.ApplyResources(this.flpImagenXArt, "flpImagenXArt");
            this.flpImagenXArt.Name = "flpImagenXArt";
            this.flpImagenXArt.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            resources.ApplyResources(this.agregarToolStripMenuItem, "agregarToolStripMenuItem");
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            resources.ApplyResources(this.eliminarToolStripMenuItem, "eliminarToolStripMenuItem");
            // 
            // PantallaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.flpImagenXArt);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ListadoDesplegable;
        private System.Windows.Forms.ToolStripMenuItem SalirDesplegable;
        private System.Windows.Forms.ToolStripMenuItem aRTICULOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripContainer toolrara;
        private System.Windows.Forms.ToolStripMenuItem ListarXMARCAToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpImagenXArt;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARCASToolStripMenuItem;
    }
}