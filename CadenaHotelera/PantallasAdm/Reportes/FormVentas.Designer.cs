namespace CadenaHotelera.PantallasAdm.Reportes
{
    partial class FormVentas
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
            dataGridView1 = new DataGridView();
            label3 = new Label();
            comboBox4 = new ComboBox();
            label2 = new Label();
            comboBox3 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            ciudad = new DataGridViewTextBoxColumn();
            hotel = new DataGridViewTextBoxColumn();
            Anio = new DataGridViewTextBoxColumn();
            Mes = new DataGridViewTextBoxColumn();
            TipoHabit = new DataGridViewTextBoxColumn();
            CantidadHabi = new DataGridViewTextBoxColumn();
            PorcentajeOcu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ciudad, hotel, Anio, Mes, TipoHabit, CantidadHabi, PorcentajeOcu });
            dataGridView1.Location = new Point(12, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1024, 448);
            dataGridView1.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label3.Location = new Point(639, 17);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 62;
            label3.Text = " Hotel";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(694, 17);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(126, 23);
            comboBox4.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label2.Location = new Point(376, 17);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 60;
            label2.Text = "Ciudad";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(439, 17);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(194, 23);
            comboBox3.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label1.Location = new Point(202, 17);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 58;
            label1.Text = "Año";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(244, 17);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(126, 23);
            comboBox2.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label8.Location = new Point(21, 17);
            label8.Name = "label8";
            label8.Size = new Size(43, 21);
            label8.TabIndex = 56;
            label8.Text = " País";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(70, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 55;
            // 
            // ciudad
            // 
            ciudad.HeaderText = "Ciudad";
            ciudad.Name = "ciudad";
            // 
            // hotel
            // 
            hotel.HeaderText = "Hotel";
            hotel.Name = "hotel";
            // 
            // Anio
            // 
            Anio.HeaderText = "Año";
            Anio.Name = "Anio";
            // 
            // Mes
            // 
            Mes.HeaderText = "Mes";
            Mes.Name = "Mes";
            // 
            // TipoHabit
            // 
            TipoHabit.HeaderText = "Ingresos por hospedaje";
            TipoHabit.Name = "TipoHabit";
            // 
            // CantidadHabi
            // 
            CantidadHabi.HeaderText = "Ingresos por servicios adicionales";
            CantidadHabi.Name = "CantidadHabi";
            // 
            // PorcentajeOcu
            // 
            PorcentajeOcu.HeaderText = "Ingresos totales";
            PorcentajeOcu.Name = "PorcentajeOcu";
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 538);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(comboBox4);
            Controls.Add(label2);
            Controls.Add(comboBox3);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Name = "FormVentas";
            Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ciudad;
        private DataGridViewTextBoxColumn hotel;
        private DataGridViewTextBoxColumn Anio;
        private DataGridViewTextBoxColumn Mes;
        private DataGridViewTextBoxColumn TipoHabit;
        private DataGridViewTextBoxColumn CantidadHabi;
        private DataGridViewTextBoxColumn PorcentajeOcu;
        private Label label3;
        private ComboBox comboBox4;
        private Label label2;
        private ComboBox comboBox3;
        private Label label1;
        private ComboBox comboBox2;
        private Label label8;
        private ComboBox comboBox1;
    }
}