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
            this.ModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListadoDesplegable = new System.Windows.Forms.ToolStripMenuItem();
            this.aRTICULOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirDesplegable = new System.Windows.Forms.ToolStripMenuItem();
       
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
           
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
            this.ModificarToolStripMenuItem});
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
            // ModificarToolStripMenuItem
            // 
            this.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem";
            resources.ApplyResources(this.ModificarToolStripMenuItem, "ModificarToolStripMenuItem");
            this.ModificarToolStripMenuItem.Click += new System.EventHandler(this.mODIFICARToolStripMenuItem_Click);
            // 
            // ListadoDesplegable
            // 
            this.ListadoDesplegable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRTICULOSToolStripMenuItem1});
            this.ListadoDesplegable.Name = "ListadoDesplegable";
            resources.ApplyResources(this.ListadoDesplegable, "ListadoDesplegable");
            // 
            // aRTICULOSToolStripMenuItem1
            // 
            this.aRTICULOSToolStripMenuItem1.Name = "aRTICULOSToolStripMenuItem1";
            resources.ApplyResources(this.aRTICULOSToolStripMenuItem1, "aRTICULOSToolStripMenuItem1");
            this.aRTICULOSToolStripMenuItem1.Click += new System.EventHandler(this.aRTICULOSToolStripMenuItem1_Click);
            // 
            // SalirDesplegable
            // 
            this.SalirDesplegable.Name = "SalirDesplegable";
            resources.ApplyResources(this.SalirDesplegable, "SalirDesplegable");
            this.SalirDesplegable.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // PantallaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
     
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
        private System.Windows.Forms.ToolStripMenuItem ModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListadoDesplegable;
        private System.Windows.Forms.ToolStripMenuItem SalirDesplegable;
        private System.Windows.Forms.ToolStripMenuItem aRTICULOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripContainer toolrara;
    }
}

