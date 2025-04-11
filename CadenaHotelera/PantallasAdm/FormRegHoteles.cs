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
    public partial class FormRegHoteles : Form
    {
        public FormRegHoteles()
        {
            InitializeComponent();
            checkedListBox1.Items.AddRange(new string[] {
                "Gimnasio",
                "WiFi",
                "Servicio al cuarto",
                "Renta de películas",
                "Masajes",
                "Restaurantes"
            });
        }
    }
}
