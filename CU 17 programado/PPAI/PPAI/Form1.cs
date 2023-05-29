using System.ComponentModel;
using System.Drawing.Text;
using System.Xml.Linq;
using PPAI.Entidades;

namespace PPAI
{
    public partial class PantallaRegistrarRespuesta : Form
    {
        public PantallaRegistrarRespuesta()
        {
            info = new List<InformacionCliente>();
            respuestasValidaciones = new List<string>();
            tipoInformacionFechaNac = new TipoInformacion("Fecha de nacimiento");
            tipoInformacionCantHijos = new TipoInformacion("Cantidad de hijos");

            validacionA = new Validacion("Fecha de nacimiento:", tipoInformacionFechaNac);
            validacionB = new Validacion("Cantidad de hijos:", tipoInformacionCantHijos);

            validaciones = new List<Validacion>();
            respuestasValidaciones.Add("");
            respuestasValidaciones.Add("");
            validaciones.Add(validacionA);
            validaciones.Add(validacionB);

            info1 = new InformacionCliente("31/10/2002", tipoInformacionFechaNac);
            info2 = new InformacionCliente("3", tipoInformacionCantHijos);
            info.Add(info1);
            info.Add(info2);

            subOpc1 = new SubOpcionLlamada("Cuenta con datos de la tarjeta", 1, validaciones);
            opc1 = new OpcionLlamada("", "Solicita nueva tarjeta", 1);
            cat1 = new CategoriaLlamada("", "Informar robo", 1);

            clienteLlamada = new Cliente(44551641, "Santiago Vagni", 35152817257, info);
            llamadaIniciada = new Llamada("", "", "", clienteLlamada);

            iniciada = new Estado("Iniciada");
            enCurso = new Estado("En curso");
            finalizada = new Estado("Finalizada");

            cambioEstadoIniciada = new CambioEstado(fecha1, iniciada);

            estados = new HashSet<Estado>();
            estados.Add(iniciada);
            estados.Add(enCurso);
            estados.Add(finalizada);

            gestorRegistrarRespuesta = new GestorRegistrarRespuesta(estados);

            gestorRegistrarRespuesta.nuevaRespuestaOperador(llamadaIniciada, cat1, opc1, subOpc1, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAcciones.Items.Add("Comunicar un saldo");
            cmbAcciones.Items.Add("Dar de baja una tarjeta");
            cmbAcciones.Items.Add("Denunciar un robo");
        }
        public void mostrarDatosLlamadas(String nombreCliente, List<string> nombreCatOpcSub)
        {
            lblNombre.Text = nombreCliente;
            lblCat.Text = nombreCatOpcSub[0];
            lblOpc.Text = nombreCatOpcSub[1];
            lblSubOpc.Text = nombreCatOpcSub[2];
            grpDatosLlamada.Visible = true;
        }

        public void solicitarRespuestaAValidacion(List<string> mensajesValidaciones)
        {
            lblValidacion1.Text = mensajesValidaciones[0];
            lblValidacion2.Text = mensajesValidaciones[1];
            grpValidaciones.Visible = true;
        }
        public void tomarIngresoDatoValidacion(object sender, EventArgs e)
        {
            respuestasValidaciones[0] = txtValidacion1.Text;
            respuestasValidaciones[1] = txtValidacion2.Text;

            if (gestorRegistrarRespuesta.tomarIngresoDatoValidacion(clienteLlamada, respuestasValidaciones[0], validado) && gestorRegistrarRespuesta.tomarIngresoDatoValidacion(clienteLlamada, respuestasValidaciones[1], validado))
            {
                validado = true;
            }
            else
            {
                validado = false;
            }

            if (validado)
            {
                grpValidaciones.Enabled = false;
                gestorRegistrarRespuesta.eventoValidacionCorrecta();
            }
            else
            {
                grpDescripcion.Visible = false;
                MessageBox.Show("El o los datos ingresados son incorrectos", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
        private void btnLimpiarClick(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
        }

        public void solicitarRespuesta()
        {
            grpDescripcion.Visible = true;
            grpAccion.Visible = true;
            grpAccion.Enabled = true;
        }

        public void tomarIngresoRta(object sender, EventArgs e)
        {
            gestorRegistrarRespuesta.tomarIngresoRta(txtDescripcion.Text, cmbAcciones.SelectedItem.ToString());
        }
        public void solicitarConfirmacion()
        {
            mensajeConfirmacion = "Confirme si desea proceder a registrar \n\n" +
                                  "Datos:" +  "\n - "
                                  + lblTitleNombre.Text + lblNombre.Text + "\n - "
                                  + lblTitleCat.Text + lblCat.Text + "\n - "
                                  + lblTitleOpc.Text + lblOpc.Text + "\n - "
                                  + lblTitleSubOpc.Text + lblSubOpc.Text + "\n - "
                                  + "Descripcion operador: " + gestorRegistrarRespuesta.descripcionOperador + "\n - "
                                  + "Accion a registrar: " + gestorRegistrarRespuesta.accionARealizar + "\n ";
            DialogResult confirmacion = MessageBox.Show(mensajeConfirmacion, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            tomarConfirmacion(confirmacion);
        }

        public void tomarConfirmacion(DialogResult confirmacion)
        {
            if (confirmacion == DialogResult.Yes)
            {
                gestorRegistrarRespuesta.tomarConfirmacion();
                
                
            }
            else if (confirmacion == DialogResult.No)
            {
                MessageBox.Show("Se cancelo el registro, puedes modificar la descripcion y accion e intentar registrar de nuevo", "Registro cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpAccion.Enabled = false;
            }
        }
        public void mostrarAccionRegistrada()
        {
            MessageBox.Show("Se registro satisfactoriamente", "Registro satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnGuardarClick(object sender, EventArgs e)
        {
            descripcionOperador = txtDescripcion.Text;
            if (!string.IsNullOrEmpty(txtDescripcion.Text))
            {
                // El TextBox no está vacío
                cmbAcciones.Enabled = true; 
                grpAccion.Enabled = true;
            }
            else
            {
                // El TextBox está vacío
            }
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