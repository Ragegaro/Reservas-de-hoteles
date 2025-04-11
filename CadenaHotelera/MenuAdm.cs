using CadenaHotelera.Pantallas;
using CadenaHotelera.PantallasAdm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadenaHotelera
{
    public partial class MenuAdm : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public MenuAdm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(112, 112, 165);
                currentBtn.ForeColor = color;

                //texto del titulo
                tituloPantalla.Text = currentBtn.Text;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = Color.Gainsboro;
            }

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
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MenuAdm_Load(object sender, EventArgs e)
        {

        }

        private void btn_RegClientes_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormRegHoteles());
        }

        private void btn_Reservas_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormRegUsuarios());
        }

        private void btn_Checkin_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormCancelaciones());
        }

        private void btn_Checkout_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormReportes());
        }

        //mover ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
