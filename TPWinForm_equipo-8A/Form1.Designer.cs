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
            this.ArticulosDesplegable = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeHModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.ListadoDesplegable = new System.Windows.Forms.ToolStripMenuItem();
            this.aRTICULOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarXMARCAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirDesplegable = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
=======
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
>>>>>>> d6289c2040079f5f1c10e05aa5bfeeda67cb6020
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticulosDesplegable,
            this.ListadoDesplegable,
            this.SalirDesplegable});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ArticulosDesplegable
            // 
            this.ArticulosDesplegable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaToolStripMenuItem,
            this.BajaToolStripMenuItem,
            this.typeHModificar});
            this.ArticulosDesplegable.Name = "ArticulosDesplegable";
            resources.ApplyResources(this.ArticulosDesplegable, "ArticulosDesplegable");
            // 
            // AltaToolStripMenuItem
            // 
            this.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem";
            resources.ApplyResources(this.AltaToolStripMenuItem, "AltaToolStripMenuItem");
            this.AltaToolStripMenuItem.Click += new System.EventHandler(this.aLTAToolStripMenuItem_Click);
            // 
            // BajaToolStripMenuItem
            // 
            this.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem";
            resources.ApplyResources(this.BajaToolStripMenuItem, "BajaToolStripMenuItem");
            this.BajaToolStripMenuItem.Click += new System.EventHandler(this.BajaToolStripMenuItem_Click);
            // 
            // typeHModificar
            // 
            this.typeHModificar.Name = "typeHModificar";
            resources.ApplyResources(this.typeHModificar, "typeHModificar");
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
<<<<<<< HEAD
=======
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
>>>>>>> d6289c2040079f5f1c10e05aa5bfeeda67cb6020
            // PantallaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.flowLayoutPanel1);
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
        private System.Windows.Forms.ToolStripMenuItem ArticulosDesplegable;
        private System.Windows.Forms.ToolStripMenuItem AltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeHModificar;
        private System.Windows.Forms.ToolStripMenuItem ListadoDesplegable;
        private System.Windows.Forms.ToolStripMenuItem SalirDesplegable;
        private System.Windows.Forms.ToolStripMenuItem aRTICULOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripContainer toolrara;
        private System.Windows.Forms.ToolStripMenuItem ListarXMARCAToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

