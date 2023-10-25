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
            nuevoForm.FormBorderStyle = FormBorderStyle.None; // Asegúrate de establecer el mismo estilo de borde que en el formulario secundario
            nuevoForm.Dock = DockStyle.Fill; // Ajusta al tamaño del formulario principal
            nuevoForm.TopMost = true;
            this.Controls.Add(nuevoForm);



            nuevoForm.MdiParent = this; // Establece el formulario principal como el padre.


            // Llama al método Show para mostrar el formulario de manera no modal (puede interactuar con otros formularios).
            nuevoForm.Show();
            //this.Hide();

            // O, si deseas mostrar el formulario de manera modal (bloquea la interacción con otros formularios hasta que se cierre):
            //nuevoForm.ShowDialog();
        }

        private void btnOpenVigenere_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario que deseas abrir.
            VigenereForm nuevoForm = new VigenereForm();
            nuevoForm.TopLevel = false;
            nuevoForm.FormBorderStyle = FormBorderStyle.None; // Asegúrate de establecer el mismo estilo de borde que en el formulario secundario
            nuevoForm.Dock = DockStyle.Fill; // Ajusta al tamaño del formulario principal
            this.Controls.Add(nuevoForm);


            nuevoForm.MdiParent = this; // Establece el formulario principal como el padre.


            // Llama al método Show para mostrar el formulario de manera no modal (puede interactuar con otros formularios).
            nuevoForm.Show();
            //this.Hide();

            // O, si deseas mostrar el formulario de manera modal (bloquea la interacción con otros formularios hasta que se cierre):
            // nuevoForm.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario que deseas abrir.
            cesarform FormCesar = new cesarform();

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
