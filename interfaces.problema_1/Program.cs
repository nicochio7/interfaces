
using System.Collections;
using System.ComponentModel.Design;

interface Icolleccion
{
    bool estaVacia();
    object extraer();
    object  primero();
    bool añadir(object parametro);

}

class Pilas : Icolleccion
{
    
    public int tamaño;
    object[] pila ;
    int contador = 0;
    public Pilas(int tamaño)
    {

     this.tamaño = tamaño;
     pila =new object[tamaño];

    }

    public bool estaVacia()
    { 
        if (pila[0] == null) {
            return true;
        }
        else { return false; }
    }
    public object extraer()
    {
        if (pila[0] == null)
        {
            return false;
        }
        
        else
        {
            object flag = pila[contador - 1];
            pila[contador - 1] = null;
             contador--;
             return flag;
        }




    } 
    public object primero()
    {
        /*  int longitud = pila.Length - 1;
          return pila[longitud];*/
        return pila[contador-1];

    }

    public bool añadir(object obj)
    {
        
        if(contador == tamaño) {
            return false;
        }
        else
        {
            pila[contador] = obj;
            contador ++;
            return true;
        }
    }
}

class Cola : Icolleccion
{
    List<object> list=new List<object>();
    public bool estaVacia()
    {

        if (list.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    } 

    public object extraer()
    {
        object flag = list[0];
        list.RemoveAt(0);
        return flag;
    }

    public object primero()
    {
        return list.First();
    }

    public bool añadir(object obj)
    {
        list.Add(obj);
        return true;
    }
}

class Program
{
    
        static void Main(string[] args)
        {
            Cola oCola = new Cola();
            Console.WriteLine(oCola.añadir(1));
            Console.WriteLine(oCola.añadir(2));
            Console.WriteLine(oCola.añadir(3));
            Console.WriteLine(oCola.estaVacia());
            Console.WriteLine(oCola.primero());
            Console.WriteLine(oCola.extraer());
            Console.WriteLine(oCola.primero());


            Pilas oPila = new Pilas(4);
            Console.WriteLine(oPila.añadir(1));
            Console.WriteLine(oPila.añadir(2));
            Console.WriteLine(oPila.añadir(3));
            Console.WriteLine(oPila.añadir(4));
            Console.WriteLine(oPila.añadir(5));
            Console.WriteLine(oPila.estaVacia());
            Console.WriteLine(oPila.primero());
            Console.WriteLine(oPila.extraer());
            Console.WriteLine(oPila.primero());

        }
    }


