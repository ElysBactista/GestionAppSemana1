using System;
using System.Windows.Forms;

namespace TareaListasFinal
{
    public partial class Form1 : Form
    {
        // Creamos la instancia de la lista para que sea accesible desde todos los botones
        lista miLista = new lista();

        public Form1()
        {
            InitializeComponent();
        }

        // EJERCICIO 4: Función para reflejar los datos en el ListBox y actualizarlos
        void ActualizarInterfaz()
        {
            listVisual.Items.Clear(); // Limpiamos el ListBox antes de volver a llenarlo
            nodo puntero = miLista.inicio;

            while (puntero != null)
            {
                listVisual.Items.Add(puntero.dato); // Agregamos el dato del nodo al entorno gráfico
                puntero = puntero.siguiente;
            }
        }

        // Botón: Insertar al Frente (Inicio)
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDato.Text))
            {
                miLista.InsertarI(int.Parse(txtDato.Text));
                ActualizarInterfaz();
                txtDato.Clear();
                txtDato.Focus();
            }
        }

        // Botón: Insertar al Final (Cola)
        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDato.Text))
            {
                miLista.InsertarF(int.Parse(txtDato.Text));
                ActualizarInterfaz();
                txtDato.Clear();
                txtDato.Focus();
            }
        }

        // EJERCICIO 2: Insertar por posición con Alerta
        private void btnPosicion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDato.Text))
            {
                // Pedimos la posición mediante un cuadro de diálogo simple
                string inputPos = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la posición deseada:", "Insertar por Posición", "1");

                if (!string.IsNullOrEmpty(inputPos))
                {
                    int valor = int.Parse(txtDato.Text);
                    int pos = int.Parse(inputPos);

                    // El método en Lista.cs enviará el mensaje de alerta si la posición no existe
                    miLista.InsertarP(valor, pos);
                    ActualizarInterfaz();
                    txtDato.Clear();
                }
            }
        }

        // EJERCICIO 3: Insertar de forma Ascendente (Ordenado)
        private void btnOrdenado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDato.Text))
            {
                // Se compara con el primer valor y se busca su ubicación
                miLista.InsertarOrdenado(int.Parse(txtDato.Text));
                ActualizarInterfaz();
                txtDato.Clear();
                txtDato.Focus();
            }
        }

        // Botón: Eliminar al Frente (Actualiza el ListBox para que no aparezca más)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            miLista.EliminarI();
            ActualizarInterfaz(); // El dato desaparece del entorno
        }
    }
}