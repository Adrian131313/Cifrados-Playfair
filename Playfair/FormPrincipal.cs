using Cifrados_Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfair
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }

        public void btnOpenPlayfair_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario que deseas abrir.
            PlayfairForm nuevoForm = new PlayfairForm();

            nuevoForm.TopLevel = false;

            nuevoForm.FormBorderStyle = FormBorderStyle.None;

            nuevoForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();

            pnlContainer.Controls.Add(nuevoForm);

            nuevoForm.Show();


            // O, si deseas mostrar el formulario de manera modal (bloquea la interacción con otros formularios hasta que se cierre):
            //nuevoForm.ShowDialog();
        }

        private void btnOpenVigenere_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario que deseas abrir.
            VigenereForm nuevoForm = new VigenereForm();

            nuevoForm.TopLevel = false;

            nuevoForm.FormBorderStyle = FormBorderStyle.None;

            nuevoForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();

            pnlContainer.Controls.Add(nuevoForm);

            nuevoForm.Show();

            // O, si deseas mostrar el formulario de manera modal (bloquea la interacción con otros formularios hasta que se cierre):
            // nuevoForm.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario que deseas abrir.
            cesarform FormCesar = new cesarform();

            FormCesar.TopLevel = false;

            FormCesar.FormBorderStyle = FormBorderStyle.None;

            FormCesar.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();

            pnlContainer.Controls.Add(FormCesar);


            // Llama al método Show para mostrar el formulario de manera no modal (puede interactuar con otros formularios).
            FormCesar.Show();

            // O, si deseas mostrar el formulario de manera modal (bloquea la interacción con otros formularios hasta que se cierre):
            // nuevoForm.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
