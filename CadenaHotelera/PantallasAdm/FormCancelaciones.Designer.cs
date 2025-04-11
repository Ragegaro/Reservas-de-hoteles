namespace CadenaHotelera.PantallasAdm
{
    partial class FormCancelaciones
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
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            hotel = new DataGridViewTextBoxColumn();
            tipocuarto = new DataGridViewTextBoxColumn();
            fechaEntrada = new DataGridViewTextBoxColumn();
            fechasalida = new DataGridViewTextBoxColumn();
            Cancelar = new DataGridViewButtonColumn();
            comboBox1 = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, nombre, hotel, tipocuarto, fechaEntrada, fechasalida, Cancelar });
            dataGridView1.Location = new Point(29, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1008, 502);
            dataGridView1.TabIndex = 0;
            // 
            // codigo
            // 
            codigo.HeaderText = "codigo";
            codigo.Name = "codigo";
            // 
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.Name = "nombre";
            // 
            // hotel
            // 
            hotel.HeaderText = "hotel";
            hotel.Name = "hotel";
            // 
            // tipocuarto
            // 
            tipocuarto.HeaderText = "tipocuarto";
            tipocuarto.Name = "tipocuarto";
            // 
            // fechaEntrada
            // 
            fechaEntrada.HeaderText = "fechaEntrada";
            fechaEntrada.Name = "fechaEntrada";
            // 
            // fechasalida
            // 
            fechasalida.HeaderText = "fechaSalida";
            fechasalida.Name = "fechasalida";
            // 
            // Cancelar
            // 
            Cancelar.HeaderText = "Cancelar";
            Cancelar.Name = "Cancelar";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(197, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 23);
            comboBox1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold);
            label8.Location = new Point(29, 40);
            label8.Name = "label8";
            label8.Size = new Size(162, 21);
            label8.TabIndex = 44;
            label8.Text = " Código de reservación";
            // 
            // button1
            // 
            button1.Location = new Point(899, 49);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 45;
            button1.Text = "Cancelar reservación";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormCancelaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 601);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "FormCancelaciones";
            Text = "FormCancelaciones";
            Load += FormCancelaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn hotel;
        private DataGridViewTextBoxColumn tipocuarto;
        private DataGridViewTextBoxColumn fechaEntrada;
        private DataGridViewTextBoxColumn fechasalida;
        private DataGridViewButtonColumn Cancelar;
        private Label label8;
        private Button button1;
    }
}