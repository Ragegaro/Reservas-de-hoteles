using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadenaHotelera.PantallasAdm
{
    public partial class FormCancelaciones : Form
    {
        public FormCancelaciones()
        {
            InitializeComponent();
        }

        private void FormCancelaciones_Load(object sender, EventArgs e)
        {
            // Configurar columnas del DataGridView
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nombre Persona";
            dataGridView1.Columns[2].Name = "Hotel";
            dataGridView1.Columns[3].Name = "Tipo de Cuarto";
            dataGridView1.Columns[4].Name = "Fecha de Entrada";
            dataGridView1.Columns[5].Name = "Fecha de Salida";

            // Agregar datos de ejemplo
            string[,] reservas = {
                    { "R001", "María Sánchez", "Hotel Playa Azul", "Suite Frente al Mar", "2025-03-10", "2025-03-15" },
                    { "R002", "José Ramírez", "Hotel Vista al Mar", "Habitación Estándar", "2025-04-01", "2025-04-05" },
                    { "R003", "Andrea Torres", "Hotel Montaña Verde", "Cabaña Deluxe", "2025-03-20", "2025-03-25" },
                    { "R004", "Fernando López", "Hotel Imperial", "Suite Ejecutiva", "2025-05-01", "2025-05-07" },
                    { "R005", "Elena Castillo", "Hotel Sol Dorado", "Habitación Doble", "2025-06-15", "2025-06-20" }
                };

            // Agregar las filas al DataGridView
            for (int i = 0; i < reservas.GetLength(0); i++)
            {
                dataGridView1.Rows.Add(reservas[i, 0], reservas[i, 1], reservas[i, 2], reservas[i, 3], reservas[i, 4], reservas[i, 5]);
            }
        }
    }
}
