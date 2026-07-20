using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Colas
{
    public partial class FormEmpleados : Form
    {
        // La cola donde guardaremos a los empleados
        Queue<Empleados> Trabajadores = new Queue<Empleados>();
        // Las 4 colas para el ejercicio del banco
        Queue<Empleados> c1 = new Queue<Empleados>(), c2 = new Queue<Empleados>(),
                         c3 = new Queue<Empleados>(), c4 = new Queue<Empleados>();

        ErrorProvider errorP = new ErrorProvider();

        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Botón REGISTRAR
        {
            errorP.Clear();

            //  Validar que no estén vacíos
            if (string.IsNullOrWhiteSpace(txtcarnet.Text))
            {
                errorP.SetError(txtcarnet, "Carnet obligatorio");
                return;
            }

            // Validar salario 
            decimal sueldo;
            if (!decimal.TryParse(txtsalario.Text, out sueldo) || sueldo < 0)
            {
                errorP.SetError(txtsalario, "Sueldo inválido o negativo");
                return;
            }

            // Crear el objeto
            Empleados nuevo = new Empleados
            {
                Carnet = txtcarnet.Text,
                Nombre = txtnombre.Text,
                Salario = sueldo,
                Fecha = fecha.Value
            };

            //  Mandar al cajero con menos gente
            int[] conteos = { c1.Count, c2.Count, c3.Count, c4.Count };
            int menor = conteos.Min();

            if (c1.Count == menor) c1.Enqueue(nuevo);
            else if (c2.Count == menor) c2.Enqueue(nuevo);
            else if (c3.Count == menor) c3.Enqueue(nuevo);
            else c4.Enqueue(nuevo);

            // Agregar a la cola general y mostrar en la tabla
            Trabajadores.Enqueue(nuevo);
            dgvCola.DataSource = Trabajadores.ToList();

            // Limpiar cuadros
            txtcarnet.Clear(); txtnombre.Clear(); txtsalario.Clear();
            txtcarnet.Focus();
        }

        private void button2_Click(object sender, EventArgs e) // Botón ELIMINAR
        {
            if (Trabajadores.Count > 0)
            {
                Trabajadores.Dequeue();
                dgvCola.DataSource = Trabajadores.ToList();
            }
            else
            {
                MessageBox.Show("La cola está vacía");
            }
        }

        private void button3_Click(object sender, EventArgs e) // Botón SALIR
        {
            Application.Exit();
        }
    }
}