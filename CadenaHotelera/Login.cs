using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CadenaHotelera
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void FormLogin(object sender, EventArgs e)
        {
            radioButton1.Checked = true; // Marca el primer RadioButton por defecto
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MenuAdm nuevaPantalla = new MenuAdm(); // Abre Form2 si el primer RadioButton está marcado
                nuevaPantalla.Show();
            }
            else if (radioButton2.Checked)
            {
                MenuOp otraPantalla = new MenuOp(); // Abre Form3 si el segundo RadioButton está marcado
                otraPantalla.Show();
            }

            /*

             siempre se esconde a pesar de que no se seleccione nada, ya que el código de la función Hide() está fuera de la condición if-else.
             Si deseas que la ventana de inicio de sesión permanezca abierta hasta que se seleccione una opción, 
             debes mover la línea this.Hide(); dentro de cada bloque if-else. 


            añadir para que se cierre desde aqui y/o desde menu
            al paercer si jala deel cerrar desde el login sin hacer nada
             */
            this.Hide();
        }
    }
}
