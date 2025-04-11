namespace CadenaHotelera.PantallasOp
{
    partial class FormReservasUsuario
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
            panelMenuReservas = new Panel();
            btn_regresar = new Button();
            btn_continuar = new Button();
            panelReservas = new Panel();
            panelMenuReservas.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuReservas
            // 
            panelMenuReservas.BackColor = Color.FromArgb(51, 51, 113);
            panelMenuReservas.Controls.Add(btn_regresar);
            panelMenuReservas.Controls.Add(btn_continuar);
            panelMenuReservas.Dock = DockStyle.Top;
            panelMenuReservas.Location = new Point(0, 0);
            panelMenuReservas.Name = "panelMenuReservas";
            panelMenuReservas.Size = new Size(1064, 36);
            panelMenuReservas.TabIndex = 0;
            // 
            // btn_regresar
            // 
            btn_regresar.Dock = DockStyle.Left;
            btn_regresar.FlatAppearance.BorderSize = 0;
            btn_regresar.FlatStyle = FlatStyle.Flat;
            btn_regresar.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            btn_regresar.ForeColor = Color.Gainsboro;
            btn_regresar.Location = new Point(0, 0);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(120, 36);
            btn_regresar.TabIndex = 1;
            btn_regresar.Text = "Regresar";
            btn_regresar.TextAlign = ContentAlignment.MiddleRight;
            btn_regresar.UseVisualStyleBackColor = true;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // btn_continuar
            // 
            btn_continuar.BackgroundImageLayout = ImageLayout.None;
            btn_continuar.Dock = DockStyle.Right;
            btn_continuar.FlatAppearance.BorderSize = 0;
            btn_continuar.FlatStyle = FlatStyle.Flat;
            btn_continuar.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            btn_continuar.ForeColor = Color.Gainsboro;
            btn_continuar.ImageAlign = ContentAlignment.MiddleRight;
            btn_continuar.Location = new Point(944, 0);
            btn_continuar.Name = "btn_continuar";
            btn_continuar.Size = new Size(120, 36);
            btn_continuar.TabIndex = 0;
            btn_continuar.Text = "Continuar";
            btn_continuar.TextAlign = ContentAlignment.MiddleLeft;
            btn_continuar.UseVisualStyleBackColor = true;
            btn_continuar.Click += btn_continuar_Click;
            // 
            // panelReservas
            // 
            panelReservas.Dock = DockStyle.Fill;
            panelReservas.Location = new Point(0, 36);
            panelReservas.Name = "panelReservas";
            panelReservas.Size = new Size(1064, 565);
            panelReservas.TabIndex = 1;
            // 
            // FormReservasUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 601);
            Controls.Add(panelReservas);
            Controls.Add(panelMenuReservas);
            Name = "FormReservasUsuario";
            Text = "FormReservas";
            panelMenuReservas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuReservas;
        private Button btn_regresar;
        private Button btn_continuar;
        private Panel panelReservas;
    }
}