using System;

class Cola
{
    public nodo primero; // El frente de la fila 
    public nodo ultimo;  // El final de la fila 

    public Cola()
    {
        primero = ultimo = null;
    }

    public void Encolar(int valor)
    {
        nodo aux = new nodo(); 
        aux.info = valor;     
        aux.sgte = null;       
      
        if (primero == null) 
        {
            primero = ultimo = aux;
        }
        else 
        {
            ultimo.sgte = aux; 
            ultimo = aux;      
        }
    }

    public void Mostrar()
    {
        if (primero == null) Console.WriteLine("Cola vacia"); 
        else
        {
            nodo puntero = primero; 
            do
            {
                Console.Write(puntero.info + " -> "); 
                puntero = puntero.sgte; 
            } while (puntero != null); 
            Console.WriteLine("FIN\n");
        }
    }
}