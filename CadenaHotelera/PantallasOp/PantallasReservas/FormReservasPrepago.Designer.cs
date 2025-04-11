namespace CadenaHotelera.PantallasOp.PantallasReservas
{
    partial class FormReservasPrepago
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
            btn_pagar = new Button();
            label10 = new Label();
            tb_anticipo = new TextBox();
            label1 = new Label();
            lb_codigoReserva = new Label();
            SuspendLayout();
            // 
            // btn_pagar
            // 
            btn_pagar.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            btn_pagar.Location = new Point(54, 87);
            btn_pagar.Name = "btn_pagar";
            btn_pagar.Size = new Size(168, 35);
            btn_pagar.TabIndex = 70;
            btn_pagar.Text = "Pagar";
            btn_pagar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label10.Location = new Point(29, 30);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 69;
            label10.Text = "Anticipo:";
            // 
            // tb_anticipo
            // 
            tb_anticipo.Location = new Point(103, 32);
            tb_anticipo.Name = "tb_anticipo";
            tb_anticipo.ReadOnly = true;
            tb_anticipo.Size = new Size(119, 23);
            tb_anticipo.TabIndex = 68;
            tb_anticipo.TextChanged += tb_telCel_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label1.Location = new Point(449, 255);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 71;
            label1.Text = "Código de reserva:";
            // 
            // lb_codigoReserva
            // 
            lb_codigoReserva.AutoSize = true;
            lb_codigoReserva.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            lb_codigoReserva.Location = new Point(449, 287);
            lb_codigoReserva.Name = "lb_codigoReserva";
            lb_codigoReserva.Size = new Size(35, 21);
            lb_codigoReserva.TabIndex = 72;
            lb_codigoReserva.Text = "-----";
            lb_codigoReserva.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormReservasPrepago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 526);
            Controls.Add(lb_codigoReserva);
            Controls.Add(label1);
            Controls.Add(btn_pagar);
            Controls.Add(label10);
            Controls.Add(tb_anticipo);
            Name = "FormReservasPrepago";
            Text = "FormReservasPrepago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_pagar;
        private Label label10;
        private TextBox tb_anticipo;
        private Label label1;
        private Label lb_codigoReserva;
    }
}