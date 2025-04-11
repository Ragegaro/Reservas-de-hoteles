namespace CadenaHotelera.PantallasAdm.Reportes
{
    partial class FormHistorialCliente
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
            label8 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            ciudad = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            hotel = new DataGridViewTextBoxColumn();
            Anio = new DataGridViewTextBoxColumn();
            Mes = new DataGridViewTextBoxColumn();
            TipoHabit = new DataGridViewTextBoxColumn();
            CantidadHabi = new DataGridViewTextBoxColumn();
            PorcentajeOcu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label8.Location = new Point(12, 17);
            label8.Name = "label8";
            label8.Size = new Size(59, 21);
            label8.TabIndex = 44;
            label8.Text = "E-mail:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ciudad, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column1, hotel, Anio, Mes, TipoHabit, CantidadHabi, PorcentajeOcu });
            dataGridView1.Location = new Point(12, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1024, 448);
            dataGridView1.TabIndex = 65;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(288, 23);
            comboBox1.TabIndex = 64;
            // 
            // ciudad
            // 
            ciudad.HeaderText = "Nombre del cliente";
            ciudad.Name = "ciudad";
            // 
            // Column2
            // 
            Column2.HeaderText = "Fecha de Check In ";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Fecha de Check out";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Estatus de la reservación ";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Anticipo ";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Monto de hospedaje";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Monto de servicios adicionales";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Total Factura";
            Column8.Name = "Column8";
            // 
            // Column1
            // 
            Column1.HeaderText = "Ciudad ";
            Column1.Name = "Column1";
            // 
            // hotel
            // 
            hotel.HeaderText = "Hotel";
            hotel.Name = "hotel";
            // 
            // Anio
            // 
            Anio.HeaderText = "Tipo de habitación";
            Anio.Name = "Anio";
            // 
            // Mes
            // 
            Mes.HeaderText = "Número de habitación";
            Mes.Name = "Mes";
            // 
            // TipoHabit
            // 
            TipoHabit.HeaderText = "Número de personas hospedadas";
            TipoHabit.Name = "TipoHabit";
            // 
            // CantidadHabi
            // 
            CantidadHabi.HeaderText = "Código de reservación";
            CantidadHabi.Name = "CantidadHabi";
            // 
            // PorcentajeOcu
            // 
            PorcentajeOcu.HeaderText = "Fecha de reservación ";
            PorcentajeOcu.Name = "PorcentajeOcu";
            // 
            // FormHistorialCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 538);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Name = "FormHistorialCliente";
            Text = "FormHistorialCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ciudad;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn hotel;
        private DataGridViewTextBoxColumn Anio;
        private DataGridViewTextBoxColumn Mes;
        private DataGridViewTextBoxColumn TipoHabit;
        private DataGridViewTextBoxColumn CantidadHabi;
        private DataGridViewTextBoxColumn PorcentajeOcu;
        private ComboBox comboBox1;
    }
}