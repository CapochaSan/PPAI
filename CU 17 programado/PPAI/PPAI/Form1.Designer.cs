using PPAI.Entidades;

namespace PPAI
{
    partial class PantallaRegistrarRespuesta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            lblCall = new Label();
            lblTitleNombre = new Label();
            lblTitleCat = new Label();
            lblTitleOpc = new Label();
            lblNombre = new Label();
            lblCat = new Label();
            lblOpc = new Label();
            lblSubOpc = new Label();
            lblTitleSubOpc = new Label();
            label6 = new Label();
            lblValidacion1 = new Label();
            btnValidar = new Button();
            lblValidacion2 = new Label();
            txtValidacion2 = new MaskedTextBox();
            label9 = new Label();
            cmbAcciones = new ComboBox();
            btnRegistrarAccion = new Button();
            label12 = new Label();
            txtDescripcion = new TextBox();
            btnGuardarDesc = new Button();
            btnLimpiar = new Button();
            grpDatosLlamada = new GroupBox();
            grpValidaciones = new GroupBox();
            txtValidacion1 = new MaskedTextBox();
            grpDescripcion = new GroupBox();
            grpAccion = new GroupBox();
            grpDatosLlamada.SuspendLayout();
            grpValidaciones.SuspendLayout();
            grpDescripcion.SuspendLayout();
            grpAccion.SuspendLayout();
            SuspendLayout();
            // 
            // lblCall
            // 
            lblCall.AutoSize = true;
            lblCall.FlatStyle = FlatStyle.Popup;
            lblCall.Font = new Font("AmsiPro-SemiBold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCall.Location = new Point(124, 19);
            lblCall.Name = "lblCall";
            lblCall.Size = new Size(192, 25);
            lblCall.TabIndex = 0;
            lblCall.Text = "Datos de la llamada";
            lblCall.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTitleNombre
            // 
            lblTitleNombre.AutoSize = true;
            lblTitleNombre.Font = new Font("AmsiPro-LightItalic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitleNombre.Location = new Point(35, 53);
            lblTitleNombre.Name = "lblTitleNombre";
            lblTitleNombre.Size = new Size(145, 20);
            lblTitleNombre.TabIndex = 0;
            lblTitleNombre.Text = "Nombre del cliente: ";
            // 
            // lblTitleCat
            // 
            lblTitleCat.AutoSize = true;
            lblTitleCat.Font = new Font("AmsiPro-LightItalic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitleCat.Location = new Point(35, 80);
            lblTitleCat.Name = "lblTitleCat";
            lblTitleCat.Size = new Size(173, 20);
            lblTitleCat.TabIndex = 0;
            lblTitleCat.Text = "Categoria seleccionada: ";
            // 
            // lblTitleOpc
            // 
            lblTitleOpc.AutoSize = true;
            lblTitleOpc.Font = new Font("AmsiPro-LightItalic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitleOpc.Location = new Point(35, 106);
            lblTitleOpc.Name = "lblTitleOpc";
            lblTitleOpc.Size = new Size(157, 20);
            lblTitleOpc.TabIndex = 0;
            lblTitleOpc.Text = "Opción seleccionada: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(234, 56);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 19);
            lblNombre.TabIndex = 0;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCat.Location = new Point(234, 83);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(0, 19);
            lblCat.TabIndex = 2;
            // 
            // lblOpc
            // 
            lblOpc.AutoSize = true;
            lblOpc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblOpc.Location = new Point(234, 109);
            lblOpc.Name = "lblOpc";
            lblOpc.Size = new Size(0, 19);
            lblOpc.TabIndex = 2;
            // 
            // lblSubOpc
            // 
            lblSubOpc.AutoSize = true;
            lblSubOpc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubOpc.Location = new Point(233, 136);
            lblSubOpc.Name = "lblSubOpc";
            lblSubOpc.Size = new Size(0, 19);
            lblSubOpc.TabIndex = 2;
            // 
            // lblTitleSubOpc
            // 
            lblTitleSubOpc.AutoSize = true;
            lblTitleSubOpc.Font = new Font("AmsiPro-LightItalic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitleSubOpc.Location = new Point(35, 133);
            lblTitleSubOpc.Name = "lblTitleSubOpc";
            lblTitleSubOpc.Size = new Size(187, 20);
            lblTitleSubOpc.TabIndex = 0;
            lblTitleSubOpc.Text = "Sub-opción seleccionada: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("AmsiPro-SemiBold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(119, 19);
            label6.Name = "label6";
            label6.Size = new Size(271, 25);
            label6.TabIndex = 9;
            label6.Text = "Ingrese respuesta del cliente";
            // 
            // lblValidacion1
            // 
            lblValidacion1.AutoSize = true;
            lblValidacion1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidacion1.Location = new Point(49, 50);
            lblValidacion1.Name = "lblValidacion1";
            lblValidacion1.Size = new Size(0, 19);
            lblValidacion1.TabIndex = 11;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(319, 50);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 52);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += tomarIngresoDatoValidacion;
            // 
            // lblValidacion2
            // 
            lblValidacion2.AutoSize = true;
            lblValidacion2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidacion2.Location = new Point(68, 79);
            lblValidacion2.Name = "lblValidacion2";
            lblValidacion2.Size = new Size(0, 19);
            lblValidacion2.TabIndex = 16;
            // 
            // txtValidacion2
            // 
            txtValidacion2.Location = new Point(192, 79);
            txtValidacion2.Mask = "9";
            txtValidacion2.Name = "txtValidacion2";
            txtValidacion2.Size = new Size(121, 23);
            txtValidacion2.TabIndex = 17;
            txtValidacion2.TextAlign = HorizontalAlignment.Center;
            txtValidacion2.ValidatingType = typeof(int);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("AmsiPro-SemiBold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(68, 19);
            label9.Name = "label9";
            label9.Size = new Size(357, 25);
            label9.TabIndex = 18;
            label9.Text = "Ingrese accion solicidata por el cliente";
            // 
            // cmbAcciones
            // 
            cmbAcciones.BackColor = SystemColors.Info;
            cmbAcciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAcciones.Enabled = false;
            cmbAcciones.FormattingEnabled = true;
            cmbAcciones.Location = new Point(68, 56);
            cmbAcciones.Name = "cmbAcciones";
            cmbAcciones.Size = new Size(362, 23);
            cmbAcciones.Sorted = true;
            cmbAcciones.TabIndex = 15;
            cmbAcciones.SelectedIndexChanged += cmbAcciones_SelectedIndexChanged;
            // 
            // btnRegistrarAccion
            // 
            btnRegistrarAccion.Enabled = false;
            btnRegistrarAccion.Location = new Point(140, 89);
            btnRegistrarAccion.Name = "btnRegistrarAccion";
            btnRegistrarAccion.Size = new Size(209, 30);
            btnRegistrarAccion.TabIndex = 4;
            btnRegistrarAccion.Text = "Registrar acción requerida";
            btnRegistrarAccion.UseVisualStyleBackColor = true;
            btnRegistrarAccion.Click += tomarIngresoRta;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("AmsiPro-SemiBold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(14, 20);
            label12.Name = "label12";
            label12.Size = new Size(453, 25);
            label12.TabIndex = 9;
            label12.Text = "Ingrese descripcion de la respuesta del operador";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(18, 59);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(360, 87);
            txtDescripcion.TabIndex = 19;
            // 
            // btnGuardarDesc
            // 
            btnGuardarDesc.Location = new Point(387, 59);
            btnGuardarDesc.Name = "btnGuardarDesc";
            btnGuardarDesc.Size = new Size(75, 42);
            btnGuardarDesc.TabIndex = 4;
            btnGuardarDesc.Text = "Guardar";
            btnGuardarDesc.UseVisualStyleBackColor = true;
            btnGuardarDesc.Click += btnGuardarClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(387, 107);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 39);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiarClick;
            // 
            // grpDatosLlamada
            // 
            grpDatosLlamada.Controls.Add(lblOpc);
            grpDatosLlamada.Controls.Add(lblCall);
            grpDatosLlamada.Controls.Add(lblTitleNombre);
            grpDatosLlamada.Controls.Add(lblNombre);
            grpDatosLlamada.Controls.Add(lblTitleCat);
            grpDatosLlamada.Controls.Add(lblTitleOpc);
            grpDatosLlamada.Controls.Add(lblTitleSubOpc);
            grpDatosLlamada.Controls.Add(lblCat);
            grpDatosLlamada.Controls.Add(lblSubOpc);
            grpDatosLlamada.Location = new Point(12, 12);
            grpDatosLlamada.Name = "grpDatosLlamada";
            grpDatosLlamada.Size = new Size(475, 177);
            grpDatosLlamada.TabIndex = 20;
            grpDatosLlamada.TabStop = false;
            grpDatosLlamada.Visible = false;
            // 
            // grpValidaciones
            // 
            grpValidaciones.Controls.Add(txtValidacion1);
            grpValidaciones.Controls.Add(label6);
            grpValidaciones.Controls.Add(btnValidar);
            grpValidaciones.Controls.Add(lblValidacion1);
            grpValidaciones.Controls.Add(txtValidacion2);
            grpValidaciones.Controls.Add(lblValidacion2);
            grpValidaciones.Location = new Point(12, 195);
            grpValidaciones.Name = "grpValidaciones";
            grpValidaciones.Size = new Size(475, 125);
            grpValidaciones.TabIndex = 21;
            grpValidaciones.TabStop = false;
            grpValidaciones.Visible = false;
            // 
            // txtValidacion1
            // 
            txtValidacion1.Location = new Point(192, 52);
            txtValidacion1.Mask = "00/00/0000";
            txtValidacion1.Name = "txtValidacion1";
            txtValidacion1.Size = new Size(121, 23);
            txtValidacion1.TabIndex = 18;
            txtValidacion1.TextAlign = HorizontalAlignment.Center;
            txtValidacion1.ValidatingType = typeof(DateTime);
            // 
            // grpDescripcion
            // 
            grpDescripcion.Controls.Add(btnGuardarDesc);
            grpDescripcion.Controls.Add(btnLimpiar);
            grpDescripcion.Controls.Add(label12);
            grpDescripcion.Controls.Add(txtDescripcion);
            grpDescripcion.Location = new Point(12, 323);
            grpDescripcion.Name = "grpDescripcion";
            grpDescripcion.Size = new Size(475, 163);
            grpDescripcion.TabIndex = 22;
            grpDescripcion.TabStop = false;
            grpDescripcion.Visible = false;
            // 
            // grpAccion
            // 
            grpAccion.Controls.Add(btnRegistrarAccion);
            grpAccion.Controls.Add(cmbAcciones);
            grpAccion.Controls.Add(label9);
            grpAccion.Location = new Point(12, 496);
            grpAccion.Name = "grpAccion";
            grpAccion.Size = new Size(475, 133);
            grpAccion.TabIndex = 23;
            grpAccion.TabStop = false;
            grpAccion.Visible = false;
            // 
            // PantallaRegistrarRespuesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 642);
            Controls.Add(grpAccion);
            Controls.Add(grpDescripcion);
            Controls.Add(grpValidaciones);
            Controls.Add(grpDatosLlamada);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "PantallaRegistrarRespuesta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar respuesta de operador";
            TopMost = true;
            Load += Form1_Load;
            grpDatosLlamada.ResumeLayout(false);
            grpDatosLlamada.PerformLayout();
            grpValidaciones.ResumeLayout(false);
            grpValidaciones.PerformLayout();
            grpDescripcion.ResumeLayout(false);
            grpDescripcion.PerformLayout();
            grpAccion.ResumeLayout(false);
            grpAccion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCall;
        private Label lblTitleNombre;
        private Label lblTitleCat;
        private Label lblTitleOpc;
        private Label lblNombre;
        private Label lblCat;
        private Label lblOpc;
        private Label lblSubOpc;
        private Label lblTitleSubOpc;
        private Label label6;
        private Label lblValidacion1;
        private Button btnValidar;
        private DateTime fecha1 = new DateTime(2001, 3, 14);
        private DateTime fecha2 = new DateTime(1998, 10, 31); // fecha correcta:
        private DateTime fecha3 = new DateTime(2000, 2, 01);
        private string descripcionOperador = "";
        private string cantHijosCorrecto = "2";
        private Label lblValidacion2;
        private MaskedTextBox txtValidacion2;
        private Label label9;
        private ComboBox cmbAcciones;
        private Button btnRegistrarAccion;
        private Label label12;
        private TextBox txtDescripcion;
        private Button btnGuardarDesc;
        private Button btnLimpiar;
        private GroupBox grpDatosLlamada;
        private GroupBox grpValidaciones;
        private GroupBox grpDescripcion;
        private GroupBox grpAccion;
        private MaskedTextBox txtValidacion1;
        private List<String> respuestasValidaciones;
        private Entidades.Validacion validacionA;
        private Entidades.Validacion validacionB;
        private Entidades.InformacionCliente info1;
        private Entidades.InformacionCliente info2;
        private Entidades.SubOpcionLlamada subOpc1;
        private Entidades.OpcionLlamada opc1;
        private Entidades.CategoriaLlamada cat1;
        private Entidades.Cliente clienteLlamada;
        private Entidades.Llamada llamadaIniciada;
        private Entidades.CambioEstado cambioEstadoIniciada;
        private Entidades.Estado iniciada;
        private Entidades.Estado enCurso;
        private Entidades.Estado finalizada;
        private Entidades.GestorRegistrarRespuesta gestorRegistrarRespuesta;
        private HashSet<Estado> estados;
        private List<Validacion> validaciones;
        private bool pantallaHab = false;
        private TipoInformacion tipoInformacionFechaNac;
        private TipoInformacion tipoInformacionCantHijos;
        private bool validado = false;
        private List<InformacionCliente> info;
        private string mensajeConfirmacion;
    }
}