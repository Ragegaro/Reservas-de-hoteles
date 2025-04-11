namespace CadenaHotelera
{
    partial class MenuOp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btn_Checkout = new Button();
            btn_Checkin = new Button();
            btn_Reservas = new Button();
            btn_RegClientes = new Button();
            panel1 = new Panel();
            panelTitleBar = new Panel();
            tituloPantalla = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btn_Checkout);
            panelMenu.Controls.Add(btn_Checkin);
            panelMenu.Controls.Add(btn_Reservas);
            panelMenu.Controls.Add(btn_RegClientes);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 720);
            panelMenu.TabIndex = 0;
            // 
            // btn_Checkout
            // 
            btn_Checkout.Dock = DockStyle.Top;
            btn_Checkout.FlatAppearance.BorderSize = 0;
            btn_Checkout.FlatStyle = FlatStyle.Flat;
            btn_Checkout.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            btn_Checkout.ForeColor = Color.Gainsboro;
            btn_Checkout.Location = new Point(0, 310);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new Size(200, 60);
            btn_Checkout.TabIndex = 4;
            btn_Checkout.Text = "Check-out";
            btn_Checkout.UseVisualStyleBackColor = true;
            btn_Checkout.Click += btn_Checkout_Click;
            // 
            // btn_Checkin
            // 
            btn_Checkin.Dock = DockStyle.Top;
            btn_Checkin.FlatAppearance.BorderSize = 0;
            btn_Checkin.FlatStyle = FlatStyle.Flat;
            btn_Checkin.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            btn_Checkin.ForeColor = Color.Gainsboro;
            btn_Checkin.Location = new Point(0, 250);
            btn_Checkin.Name = "btn_Checkin";
            btn_Checkin.Size = new Size(200, 60);
            btn_Checkin.TabIndex = 3;
            btn_Checkin.Text = "Check-in";
            btn_Checkin.UseVisualStyleBackColor = true;
            btn_Checkin.Click += btn_Checkin_Click;
            // 
            // btn_Reservas
            // 
            btn_Reservas.Dock = DockStyle.Top;
            btn_Reservas.FlatAppearance.BorderSize = 0;
            btn_Reservas.FlatStyle = FlatStyle.Flat;
            btn_Reservas.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            btn_Reservas.ForeColor = Color.Gainsboro;
            btn_Reservas.Location = new Point(0, 190);
            btn_Reservas.Name = "btn_Reservas";
            btn_Reservas.Size = new Size(200, 60);
            btn_Reservas.TabIndex = 2;
            btn_Reservas.Text = "Reservas";
            btn_Reservas.UseVisualStyleBackColor = true;
            btn_Reservas.Click += btn_Reservas_Click;
            // 
            // btn_RegClientes
            // 
            btn_RegClientes.Dock = DockStyle.Top;
            btn_RegClientes.FlatAppearance.BorderSize = 0;
            btn_RegClientes.FlatStyle = FlatStyle.Flat;
            btn_RegClientes.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            btn_RegClientes.ForeColor = Color.Gainsboro;
            btn_RegClientes.Location = new Point(0, 130);
            btn_RegClientes.Name = "btn_RegClientes";
            btn_RegClientes.Size = new Size(200, 60);
            btn_RegClientes.TabIndex = 1;
            btn_RegClientes.Text = "Registro de clientes";
            btn_RegClientes.UseVisualStyleBackColor = true;
            btn_RegClientes.Click += btn_RegClientes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 130);
            panel1.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelTitleBar.Controls.Add(tituloPantalla);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(200, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1080, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // tituloPantalla
            // 
            tituloPantalla.AutoSize = true;
            tituloPantalla.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloPantalla.ForeColor = Color.Gainsboro;
            tituloPantalla.Location = new Point(32, 21);
            tituloPantalla.Name = "tituloPantalla";
            tituloPantalla.Size = new Size(84, 39);
            tituloPantalla.TabIndex = 0;
            tituloPantalla.Text = "Inicio";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(200, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1080, 640);
            panelDesktop.TabIndex = 2;
            // 
            // MenuOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuOp";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Button btn_RegClientes;
        private Button btn_Checkout;
        private Button btn_Checkin;
        private Button btn_Reservas;
        private Panel panelTitleBar;
        private Label tituloPantalla;
        private Panel panelDesktop;
    }
}
