using System;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Recuerda agregar la Referencia en el proyecto

namespace ProyectoFinalListas
{
    public partial class Form1 : Form
    {
        lista miLista = new lista();

        public Form1() { InitializeComponent(); }

        // Actualización automática del ListBox
        void Actualizar()
        {
            listVisual.Items.Clear();
            nodo p = miLista.inicio;
            while (p != null) { listVisual.Items.Add(p.dato); p = p.siguiente; }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "") { miLista.InsertarI(int.Parse(txtDato.Text)); Actualizar(); txtDato.Clear(); }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "") { miLista.InsertarF(int.Parse(txtDato.Text)); Actualizar(); txtDato.Clear(); }
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "")
            {
                string p = Interaction.InputBox("Posición:", "Desafío 2", "1");
                if (p != "") { miLista.InsertarP(int.Parse(txtDato.Text), int.Parse(p)); Actualizar(); }
            }
        }

        private void btnOrdenado_Click(object sender, EventArgs e)
        {
            if (txtDato.Text != "") { miLista.InsertarOrdenado(int.Parse(txtDato.Text)); Actualizar(); txtDato.Clear(); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            miLista.EliminarI(); Actualizar();
        }
    }
}