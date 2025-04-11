namespace CadenaHotelera.PantallasAdm
{
    partial class FormReportes
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
            menuStrip1 = new MenuStrip();
            ocupacionPorHotelToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            historialDelClienteToolStripMenuItem = new ToolStripMenuItem();
            panelReportes = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ocupacionPorHotelToolStripMenuItem, ventasToolStripMenuItem, historialDelClienteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1064, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ocupacionPorHotelToolStripMenuItem
            // 
            ocupacionPorHotelToolStripMenuItem.Name = "ocupacionPorHotelToolStripMenuItem";
            ocupacionPorHotelToolStripMenuItem.Size = new Size(131, 20);
            ocupacionPorHotelToolStripMenuItem.Text = "Ocupación  por hotel";
            ocupacionPorHotelToolStripMenuItem.Click += ocupacionPorHotelToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 20);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // historialDelClienteToolStripMenuItem
            // 
            historialDelClienteToolStripMenuItem.Name = "historialDelClienteToolStripMenuItem";
            historialDelClienteToolStripMenuItem.Size = new Size(122, 20);
            historialDelClienteToolStripMenuItem.Text = "Historial del Cliente";
            historialDelClienteToolStripMenuItem.Click += historialDelClienteToolStripMenuItem_Click;
            // 
            // panelReportes
            // 
            panelReportes.Dock = DockStyle.Fill;
            panelReportes.Location = new Point(0, 24);
            panelReportes.Name = "panelReportes";
            panelReportes.Size = new Size(1064, 577);
            panelReportes.TabIndex = 1;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 601);
            Controls.Add(panelReportes);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormReportes";
            Text = "FormReportes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ocupacionPorHotelToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem historialDelClienteToolStripMenuItem;
        private Panel panelReportes;
    }
}