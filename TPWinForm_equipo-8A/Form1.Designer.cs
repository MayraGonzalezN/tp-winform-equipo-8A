namespace WinForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRTICULOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticulosToolStripMenuItem,
            this.lISTADOSToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ArticulosToolStripMenuItem
            // 
            this.ArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaToolStripMenuItem,
            this.BajaToolStripMenuItem,
            this.ModificarToolStripMenuItem});
            this.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem";
            resources.ApplyResources(this.ArticulosToolStripMenuItem, "ArticulosToolStripMenuItem");
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
            // lISTADOSToolStripMenuItem
            // 
            this.lISTADOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRTICULOSToolStripMenuItem1});
            this.lISTADOSToolStripMenuItem.Name = "lISTADOSToolStripMenuItem";
            resources.ApplyResources(this.lISTADOSToolStripMenuItem, "lISTADOSToolStripMenuItem");
            // 
            // aRTICULOSToolStripMenuItem1
            // 
            this.aRTICULOSToolStripMenuItem1.Name = "aRTICULOSToolStripMenuItem1";
            resources.ApplyResources(this.aRTICULOSToolStripMenuItem1, "aRTICULOSToolStripMenuItem1");
            this.aRTICULOSToolStripMenuItem1.Click += new System.EventHandler(this.aRTICULOSToolStripMenuItem1_Click);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            resources.ApplyResources(this.SalirToolStripMenuItem, "SalirToolStripMenuItem");
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRTICULOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button button1;
    }
}

