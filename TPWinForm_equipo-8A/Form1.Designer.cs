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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRTICULOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticulosToolStripMenuItem,
            this.lISTADOSToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArticulosToolStripMenuItem
            // 
            this.ArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaToolStripMenuItem,
            this.BajaToolStripMenuItem,
            this.ModificarToolStripMenuItem});
            this.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem";
            this.ArticulosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ArticulosToolStripMenuItem.Text = "ARTICULOS";
            // 
            // AltaToolStripMenuItem
            // 
            this.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem";
            this.AltaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AltaToolStripMenuItem.Text = "&1- ALTA";
            this.AltaToolStripMenuItem.Click += new System.EventHandler(this.aLTAToolStripMenuItem_Click);
            // 
            // BajaToolStripMenuItem
            // 
            this.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem";
            this.BajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BajaToolStripMenuItem.Text = "&2- BAJA";
            // 
            // ModificarToolStripMenuItem
            // 
            this.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem";
            this.ModificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ModificarToolStripMenuItem.Text = "&3- MODIFICAR";
            this.ModificarToolStripMenuItem.Click += new System.EventHandler(this.mODIFICARToolStripMenuItem_Click);
            // 
            // lISTADOSToolStripMenuItem
            // 
            this.lISTADOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRTICULOSToolStripMenuItem1});
            this.lISTADOSToolStripMenuItem.Name = "lISTADOSToolStripMenuItem";
            this.lISTADOSToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.lISTADOSToolStripMenuItem.Text = "LISTADOS";
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.SalirToolStripMenuItem.Text = "SALIR";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // aRTICULOSToolStripMenuItem1
            // 
            this.aRTICULOSToolStripMenuItem1.Name = "aRTICULOSToolStripMenuItem1";
            this.aRTICULOSToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aRTICULOSToolStripMenuItem1.Text = "ARTICULOS";
            this.aRTICULOSToolStripMenuItem1.Click += new System.EventHandler(this.aRTICULOSToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APP1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

