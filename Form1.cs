using System.Drawing.Text;

namespace practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private bool validarCampos()
        {
            bool nombre = false;
            bool apellido = false;
            bool edad = false;
            bool direccion = false;
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                nombre = true;
            }
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
            }
            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
                apellido = true;
            }
            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
            }
            else
            {
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;
                direccion = true;
            }
            if (nudEdad.Value == 0)
            {
                nudEdad.BackColor = Color.Red;
            }
            else
            {
                nudEdad.BackColor = System.Drawing.SystemColors.Control;
                edad = true;
            }
            if (nombre == true && apellido == true && edad == true && direccion == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                txtNombre.Text = txtNombre.Text.ToUpper();
                txtDireccion.Text = txtDireccion.Text.ToUpper();
                txtApellido.Text = txtApellido.Text.ToUpper();
                ListViewItem item = new ListViewItem(new[]
                {
                    txtNombre.Text,
                    txtApellido.Text,
                    nudEdad.Value.ToString(),
                    txtDireccion.Text
                });
                
                lvResultado.Items.Add(item);

            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye!!");
            //Cerrar form
            this.Close();
        }
    }
}