using ContenedorAlumnos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ABM
{
    public partial class FormAlumno : Form
    {
        private Alumno alumno;
        private bool eliminar;

        public Alumno AlumnoCreado
        {
            get
            {
                return alumno;
            }
        }


        public FormAlumno()
        {
            InitializeComponent();
        }

        public FormAlumno(Alumno alumno) : this()
        {
            this.alumno = alumno;
            this.eliminar = false;
        }

        public FormAlumno(Alumno alumno, bool eliminar) : this(alumno)
        {            
            this.eliminar = eliminar;
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {
            if (this.alumno is null)
            {
                lblId.Enabled = false;
                txtId.Enabled = false;
            }
            else if(!eliminar)
            {
                CargarInfo();
               
            }
            else
            {
                CargarInfo();
                textboxReadOnly();
            }

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = int.Parse(txtEdad.Text);


            if (this.alumno is null)
            {
                alumno = new Alumno(nombre, apellido, edad);
            }
            else
            {
                this.alumno.Nombre = nombre;
                this.alumno.Apellido = apellido;
                this.alumno.Edad = edad;
            }


            this.DialogResult = DialogResult.OK;

        }

        private void CargarInfo()
        {
            this.txtId.Text = this.alumno.Id.ToString();
            this.txtNombre.Text = this.alumno.Nombre;
            this.txtApellido.Text = this.alumno.Apellido;
            this.txtEdad.Text = this.alumno.Edad.ToString();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textboxReadOnly()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().Name == typeof(TextBox).Name)
                {
                    ((TextBox)item).ReadOnly = true;
                }
            }
        }
    }
}
