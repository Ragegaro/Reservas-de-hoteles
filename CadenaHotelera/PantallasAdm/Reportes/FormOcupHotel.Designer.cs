namespace CadenaHotelera.PantallasAdm.Reportes
{
    partial class FormOcupHotel
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox3 = new ComboBox();
            label3 = new Label();
            comboBox4 = new ComboBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ciudad = new DataGridViewTextBoxColumn();
            hotel = new DataGridViewTextBoxColumn();
            Anio = new DataGridViewTextBoxColumn();
            Mes = new DataGridViewTextBoxColumn();
            TipoHabit = new DataGridViewTextBoxColumn();
            CantidadHabi = new DataGridViewTextBoxColumn();
            PorcentajeOcu = new DataGridViewTextBoxColumn();
            personas = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label8.Location = new Point(21, 21);
            label8.Name = "label8";
            label8.Size = new Size(43, 21);
            label8.TabIndex = 46;
            label8.Text = " País";
            label8.Click += label8_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(70, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label1.Location = new Point(202, 21);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 48;
            label1.Text = "Año";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(244, 21);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(126, 23);
            comboBox2.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label2.Location = new Point(376, 21);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 50;
            label2.Text = "Ciudad";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(439, 21);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(194, 23);
            comboBox3.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label3.Location = new Point(639, 21);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 52;
            label3.Text = " Hotel";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(694, 21);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(126, 23);
            comboBox4.TabIndex = 51;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ciudad, hotel, Anio, Mes, TipoHabit, CantidadHabi, PorcentajeOcu, personas });
            dataGridView1.Location = new Point(12, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1024, 296);
            dataGridView1.TabIndex = 53;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView2.Location = new Point(12, 384);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1024, 142);
            dataGridView2.TabIndex = 54;
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
            TipoHabit.HeaderText = "Tipo de habitación ";
            TipoHabit.Name = "TipoHabit";
            // 
            // CantidadHabi
            // 
            CantidadHabi.HeaderText = "Cantidad de habitaciones";
            CantidadHabi.Name = "CantidadHabi";
            // 
            // PorcentajeOcu
            // 
            PorcentajeOcu.HeaderText = "Porcentaje de ocupación ";
            PorcentajeOcu.Name = "PorcentajeOcu";
            // 
            // personas
            // 
            personas.HeaderText = "Cantidad de personas hospedadas ";
            personas.Name = "personas";
            // 
            // Column1
            // 
            Column1.HeaderText = "Ciudad";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre del hotel";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Año";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Mes";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Porcentaje de ocupación ";
            Column5.Name = "Column5";
            // 
            // FormOcupHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 538);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(comboBox4);
            Controls.Add(label2);
            Controls.Add(comboBox3);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Name = "FormOcupHotel";
            Text = "FormOcupHotel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox3;
        private Label label3;
        private ComboBox comboBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ciudad;
        private DataGridViewTextBoxColumn hotel;
        private DataGridViewTextBoxColumn Anio;
        private DataGridViewTextBoxColumn Mes;
        private DataGridViewTextBoxColumn TipoHabit;
        private DataGridViewTextBoxColumn CantidadHabi;
        private DataGridViewTextBoxColumn PorcentajeOcu;
        private DataGridViewTextBoxColumn personas;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}