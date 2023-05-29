using System.Drawing.Text;
using PPAI.Entidades;

namespace PPAI
{
    public partial class PantallaRegistrarRespuesta : Form
    {
        private bool validacion1;

        public PantallaRegistrarRespuesta()
        {
            validacionA = new Validacion("Fecha de nacimiento:","Fecha de nacimiento");
            validacionB = new Validacion("Cantidad de hijos:", "Cantidad de hijos");
            
            validaciones = new List<Validacion>();
            validaciones.Add(validacionA);
            validaciones.Add(validacionB);

            info1 = new InformacionCliente("31/10/2002");
            info2 = new InformacionCliente("3");

            subOpc1 = new SubOpcionLlamada("Cuenta con datos de la tarjeta", 1, validaciones);
            opc1 = new OpcionLlamada("","Solicita nueva tarjeta", 1);
            cat1 = new CategoriaLlamada("", "Informar robo", 1);

            clienteLlamada = new Cliente(44551641, "Santiago Vagni", 35152817257);
            llamadaIniciada = new Llamada("", "", 0,"", clienteLlamada);

            iniciada = new Estado("Iniciada");
            enCurso = new Estado("En curso");
            finalizada = new Estado("Finalizada");

            cambioEstadoIniciada = new CambioEstado(fecha1, iniciada);

            estados = new HashSet<Estado>();
            estados.Add(iniciada);
            estados.Add(enCurso);
            estados.Add(finalizada);

            gestorRegistrarRespuesta = new GestorRegistrarRespuesta(estados);

            gestorRegistrarRespuesta.nuevaRespuestaOperador(llamadaIniciada, cat1,opc1,subOpc1);

            InitializeComponent();

            gestorRegistrarRespuesta.mostrarDatosLlamadas(this, cat1,opc1,subOpc1);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAcciones.Items.Add("Comunicar un saldo");
            cmbAcciones.Items.Add("Dar de baja una tarjeta");
            cmbAcciones.Items.Add("Denunciar un robo");
        }
        public void mostrarDatosLlamadas(object sender, EventArgs e)
        {

            grpDatosLlamada.Visible = true;
        }

        public void solicitarRespuestaAValidacion()
        {
            grpValidaciones.Visible = true;
        }

        public void tomarIngresoDatoValidacion()
        {
            
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
    }
}