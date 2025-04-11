namespace CadenaHotelera.PantallasOp.PantallasReservas
{
    partial class FormReservasListaHabi
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
            btn_Confirmar = new Button();
            lab_nombre = new Label();
            tb_desc3 = new TextBox();
            tb_desc2 = new TextBox();
            tb_desc1 = new TextBox();
            tb_cantHusped = new TextBox();
            cb_tipoHabi = new ComboBox();
            tb_cantHabi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbx_listaHabi = new ListBox();
            button1 = new Button();
            dgv_habiSeleccionadas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_habiSeleccionadas).BeginInit();
            SuspendLayout();
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            btn_Confirmar.Location = new Point(792, 458);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(168, 35);
            btn_Confirmar.TabIndex = 51;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = true;
            // 
            // lab_nombre
            // 
            lab_nombre.AutoSize = true;
            lab_nombre.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            lab_nombre.Location = new Point(216, 88);
            lab_nombre.Name = "lab_nombre";
            lab_nombre.Size = new Size(62, 21);
            lab_nombre.TabIndex = 50;
            lab_nombre.Text = "nombre";
            // 
            // tb_desc3
            // 
            tb_desc3.Location = new Point(216, 315);
            tb_desc3.Multiline = true;
            tb_desc3.Name = "tb_desc3";
            tb_desc3.Size = new Size(308, 64);
            tb_desc3.TabIndex = 49;
            // 
            // tb_desc2
            // 
            tb_desc2.Location = new Point(216, 229);
            tb_desc2.Multiline = true;
            tb_desc2.Name = "tb_desc2";
            tb_desc2.Size = new Size(308, 64);
            tb_desc2.TabIndex = 48;
            // 
            // tb_desc1
            // 
            tb_desc1.Location = new Point(216, 147);
            tb_desc1.Multiline = true;
            tb_desc1.Name = "tb_desc1";
            tb_desc1.Size = new Size(308, 64);
            tb_desc1.TabIndex = 47;
            // 
            // tb_cantHusped
            // 
            tb_cantHusped.Location = new Point(775, 65);
            tb_cantHusped.Name = "tb_cantHusped";
            tb_cantHusped.Size = new Size(59, 23);
            tb_cantHusped.TabIndex = 53;
            // 
            // cb_tipoHabi
            // 
            cb_tipoHabi.FormattingEnabled = true;
            cb_tipoHabi.Location = new Point(775, 110);
            cb_tipoHabi.Name = "cb_tipoHabi";
            cb_tipoHabi.Size = new Size(174, 23);
            cb_tipoHabi.TabIndex = 54;
            // 
            // tb_cantHabi
            // 
            tb_cantHabi.Location = new Point(775, 156);
            tb_cantHabi.Name = "tb_cantHabi";
            tb_cantHabi.Size = new Size(59, 23);
            tb_cantHabi.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label1.Location = new Point(591, 63);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 56;
            label1.Text = "Cantidad de huespedes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label2.Location = new Point(591, 112);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 57;
            label2.Text = "Tipo de habitacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label3.Location = new Point(591, 156);
            label3.Name = "label3";
            label3.Size = new Size(178, 21);
            label3.TabIndex = 58;
            label3.Text = "Cantidad de habitaciones";
            // 
            // lbx_listaHabi
            // 
            lbx_listaHabi.FormattingEnabled = true;
            lbx_listaHabi.ItemHeight = 15;
            lbx_listaHabi.Location = new Point(38, 85);
            lbx_listaHabi.Name = "lbx_listaHabi";
            lbx_listaHabi.Size = new Size(156, 349);
            lbx_listaHabi.TabIndex = 59;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            button1.Location = new Point(591, 192);
            button1.Name = "button1";
            button1.Size = new Size(91, 29);
            button1.TabIndex = 60;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgv_habiSeleccionadas
            // 
            dgv_habiSeleccionadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_habiSeleccionadas.Location = new Point(591, 248);
            dgv_habiSeleccionadas.Name = "dgv_habiSeleccionadas";
            dgv_habiSeleccionadas.Size = new Size(389, 150);
            dgv_habiSeleccionadas.TabIndex = 61;
            // 
            // FormReservasListaHabi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 526);
            Controls.Add(dgv_habiSeleccionadas);
            Controls.Add(button1);
            Controls.Add(lbx_listaHabi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_cantHabi);
            Controls.Add(cb_tipoHabi);
            Controls.Add(tb_cantHusped);
            Controls.Add(btn_Confirmar);
            Controls.Add(lab_nombre);
            Controls.Add(tb_desc3);
            Controls.Add(tb_desc2);
            Controls.Add(tb_desc1);
            Name = "FormReservasListaHabi";
            Text = "LitaHabi";
            ((System.ComponentModel.ISupportInitialize)dgv_habiSeleccionadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Confirmar;
        private Label lab_nombre;
        private TextBox tb_desc3;
        private TextBox tb_desc2;
        private TextBox tb_desc1;
        private TextBox tb_cantHusped;
        private ComboBox cb_tipoHabi;
        private TextBox tb_cantHabi;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lbx_listaHabi;
        private Button button1;
        private DataGridView dgv_habiSeleccionadas;
    }
}