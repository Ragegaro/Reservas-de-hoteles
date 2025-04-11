using CadenaHotelera.PantallasAdm.Reportes;
using CadenaHotelera.PantallasOp.PantallasReservas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadenaHotelera.PantallasOp
{
    public partial class FormReservasUsuario : Form
    {
        int menu = 1;
        private Form currentChildForm;
        public FormReservasUsuario()
        {
            InitializeComponent();
            OpenChildForm(new FormReservasHuesped());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelReservas.Controls.Add(childForm);
            panelReservas.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new FormOcupHotel());
        //}

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (menu < 5)
            {
                menu++;
            }
            ventanas();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            if (menu > 1)
            {
                menu--;
            }
            ventanas();
        }

        private void ventanas()
        {
            switch (menu)
            { 
                case 1: OpenChildForm(new FormReservasHuesped());
                    break;
                case 2:
                    OpenChildForm(new FormReservaListaHoteles());
                    break;
                case 3:
                    OpenChildForm(new FormReservasListaHabi());
                    break;
                case 4:
                    OpenChildForm(new FormReservasFechas());
                    break;
                case 5:
                    OpenChildForm(new FormReservasPrepago());
                    break;


            }

        }
    }
}
