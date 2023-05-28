using System.Drawing.Text;

namespace PPAI
{
    public partial class PantallaRegistrarRespuesta : Form
    {
        private bool validacion1;

        public PantallaRegistrarRespuesta()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAcciones.Items.Add("Comunicar un saldo");
            cmbAcciones.Items.Add("Dar de baja una tarjeta");
            cmbAcciones.Items.Add("Denunciar un robo");
        }

        private void validarClick(object sender, EventArgs e)
        {
            if (!validacion1)
            {
                if (txtFecha.Text.Equals("31/10/2002"))
                {
                    MessageBox.Show("Validado correctamente", "Validacion", MessageBoxButtons.OK);
                    validacion1 = true;
                    lblHijos.Enabled = true;
                    txtHijos.Enabled = true;
                    lblValidacion.Enabled = false;
                    txtFecha.Enabled = false;

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
                // El TextBox no está vacío
                cmbAcciones.Enabled = true;
            }
            else
            {
                // El TextBox está vacío
            }
        }

        private void btnRegistrarAccionClick(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha registrado con éxito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cmbAcciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAcciones.SelectedIndex != -1)
            {
                // Habilitar el botón porque se seleccionó una opción en el ComboBox
                btnRegistrarAccion.Enabled = true;
            }
        }

        private void grpDatosLlamada_Enter(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}