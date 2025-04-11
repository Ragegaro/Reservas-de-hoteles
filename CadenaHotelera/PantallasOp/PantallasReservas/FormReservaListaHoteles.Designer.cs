namespace CadenaHotelera.PantallasOp.PantallasReservas
{
    partial class FormReservaListaHoteles
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
            lbx_listaHoteles = new ListBox();
            tb_desc1 = new TextBox();
            tb_desc2 = new TextBox();
            tb_desc3 = new TextBox();
            lab_nombre = new Label();
            label2 = new Label();
            btn_seleccionar = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // lbx_listaHoteles
            // 
            lbx_listaHoteles.FormattingEnabled = true;
            lbx_listaHoteles.ItemHeight = 15;
            lbx_listaHoteles.Location = new Point(85, 105);
            lbx_listaHoteles.Name = "lbx_listaHoteles";
            lbx_listaHoteles.Size = new Size(219, 379);
            lbx_listaHoteles.TabIndex = 0;
            // 
            // tb_desc1
            // 
            tb_desc1.Location = new Point(426, 184);
            tb_desc1.Multiline = true;
            tb_desc1.Name = "tb_desc1";
            tb_desc1.Size = new Size(407, 64);
            tb_desc1.TabIndex = 1;
            // 
            // tb_desc2
            // 
            tb_desc2.Location = new Point(426, 266);
            tb_desc2.Multiline = true;
            tb_desc2.Name = "tb_desc2";
            tb_desc2.Size = new Size(407, 64);
            tb_desc2.TabIndex = 2;
            // 
            // tb_desc3
            // 
            tb_desc3.Location = new Point(426, 352);
            tb_desc3.Multiline = true;
            tb_desc3.Name = "tb_desc3";
            tb_desc3.Size = new Size(407, 64);
            tb_desc3.TabIndex = 3;
            // 
            // lab_nombre
            // 
            lab_nombre.AutoSize = true;
            lab_nombre.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            lab_nombre.Location = new Point(426, 125);
            lab_nombre.Name = "lab_nombre";
            lab_nombre.Size = new Size(62, 21);
            lab_nombre.TabIndex = 5;
            lab_nombre.Text = "nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label2.Location = new Point(85, 81);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 6;
            label2.Text = "Lista de Hoteles";
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            btn_seleccionar.Location = new Point(665, 469);
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.Size = new Size(168, 35);
            btn_seleccionar.TabIndex = 46;
            btn_seleccionar.Text = "Seleccionar";
            btn_seleccionar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label6.Location = new Point(14, 19);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 48;
            label6.Text = "Ciudad:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(85, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 23);
            comboBox1.TabIndex = 49;
            // 
            // FormReservaListaHoteles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 526);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(btn_seleccionar);
            Controls.Add(label2);
            Controls.Add(lab_nombre);
            Controls.Add(tb_desc3);
            Controls.Add(tb_desc2);
            Controls.Add(tb_desc1);
            Controls.Add(lbx_listaHoteles);
            Name = "FormReservaListaHoteles";
            Text = "FormReservaListaHoteles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx_listaHoteles;
        private TextBox tb_desc1;
        private TextBox tb_desc2;
        private TextBox tb_desc3;
        private Label lab_nombre;
        private Label label2;
        private Button btn_seleccionar;
        private Label label6;
        private ComboBox comboBox1;
    }
}