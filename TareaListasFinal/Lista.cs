using System;
using System.Windows.Forms;

public class lista
{
    public nodo inicio;
    public lista() { inicio = null; }

    // Métodos básicos requeridos
    public void InsertarI(int item)
    {
        nodo auxiliar = new nodo(item);
        auxiliar.siguiente = inicio;
        inicio = auxiliar;
    }

    public void InsertarF(int item)
    {
        nodo auxiliar = new nodo(item);
        if (inicio == null) inicio = auxiliar;
        else
        {
            nodo puntero = inicio;
            while (puntero.siguiente != null) puntero = puntero.siguiente;
            puntero.siguiente = auxiliar;
        }
    }

    public void InsertarP(int item, int pos)
    {
        if (pos <= 1 || inicio == null) { InsertarI(item); return; }
        nodo puntero = inicio;
        int i = 1;
        while (i < pos - 1 && puntero.siguiente != null)
        {
            puntero = puntero.siguiente;
            i++;
        }
        if (puntero.siguiente == null)
        {
            MessageBox.Show("¡Alerta! La posición " + pos + " no existe. Insertando al final.");
            InsertarF(item);
        }
        else
        {
            nodo auxiliar = new nodo(item);
            auxiliar.siguiente = puntero.siguiente;
            puntero.siguiente = auxiliar;
        }
    }

    public void InsertarOrdenado(int item)
    {
        nodo auxiliar = new nodo(item);
        if (inicio == null || item < inicio.dato)
        {
            auxiliar.siguiente = inicio;
            inicio = auxiliar;
        }
        else
        {
            nodo puntero = inicio;
            while (puntero.siguiente != null && puntero.siguiente.dato < item)
            {
                puntero = puntero.siguiente;
            }
            auxiliar.siguiente = puntero.siguiente;
            puntero.siguiente = auxiliar;
        }
    }

    public void EliminarI() { if (inicio != null) inicio = inicio.siguiente; }
    public void EliminarF() { /* Implementación según guía si la necesitas */ }
}