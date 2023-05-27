using System.Drawing.Text;

namespace PPAI
{
    public partial class Form1 : Form
    {
        private bool validacion1;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbValFecha.Items.Add(fecha1);
            cmbValFecha.Items.Add(fecha2);
            cmbValFecha.Items.Add(fecha3);

            cmbAcciones.Items.Add("Comunicar un saldo");
            cmbAcciones.Items.Add("Dar de baja una tarjeta");
            cmbAcciones.Items.Add("Denunciar un robo");
        }

        private void validarClick(object sender, EventArgs e)
        {
            if (!validacion1)
            {
                if (cmbValFecha.SelectedItem.Equals(fecha2))
                {
                    MessageBox.Show("Validado correctamente", "Validacion", MessageBoxButtons.OK);
                    validacion1 = true;
                    lblHijos.Enabled = true;
                    txtHijos.Enabled = true;
                    lblValidacion.Enabled = false;
                    cmbValFecha.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Invalidado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtHijos.Text.Equals(cantHijosCorrecto))
                {
                    MessageBox.Show("Validado correctamente", "Validacion", MessageBoxButtons.OK);
                    lblHijos.Enabled = false;
                    txtHijos.Enabled = false;
                    btnValidar.Enabled = false;
                    txtDescripcion.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Invalidado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblCall_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarClick(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
        }

        private void btnGuardarClick(object sender, EventArgs e)
        {
            descripcionOperador = txtDescripcion.Text;
            if (!string.IsNullOrEmpty(txtDescripcion.Text))
            {
                // El TextBox no est� vac�o
                cmbAcciones.Enabled = true;
            }
            else
            {
                // El TextBox est� vac�o
            }
        }

        private void btnRegistrarAccionClick(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha registrado con �xito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cmbAcciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAcciones.SelectedIndex != -1)
            {
                // Habilitar el bot�n porque se seleccion� una opci�n en el ComboBox
                btnRegistrarAccion.Enabled = true;
            }
        }

        private void grpDatosLlamada_Enter(object sender, EventArgs e)
        {

        }
    }
}