using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datos1
{

    public partial class Form1 : Form
    {
        private string usuarioCorrecto = "santiago";
        private string contraseñaCorrecta = "santiago0114";

        private int intentos = 0;
        public Form1()
            
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if
                 (txtuser.Text == usuarioCorrecto && txtpass.Text == contraseñaCorrecta)
            {
                MessageBox.Show($"Bienvenido user", "login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
                this.Hide();

                this.Hide();
            }

            else
            {
                intentos++;
                if (intentos >= 3)
                {
                    MessageBox.Show("Numero Maximo de Errores", "Intentos Agotados", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Inconrrectos", "Intenta de Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}