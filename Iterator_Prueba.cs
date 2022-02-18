using System;
using System.Collections.Generic;
namespace Iterator.Prueba
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Collection coleccion = new Collection();
            coleccion[0] = new Item("Item 0");
            coleccion[1] = new Item("Item 1");
            coleccion[2] = new Item("Item 2");
            coleccion[3] = new Item("Item 3");
            coleccion[4] = new Item("Item 4");
            coleccion[5] = new Item("Item 5");
            coleccion[6] = new Item("Item 6");
            coleccion[7] = new Item("Item 7");
            coleccion[8] = new Item("Item 8");
    
            Iterator iterador = coleccion.CreateIterator();

            iterator.Step = 2;
            Console.WriteLine("Iterando");
            for (Item item = iterador.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Nombre);
            }
            Console.ReadKey();
        }
    }
   
    public class Item
    {
        string nombre;
       
        public Item(string nombre)
        {
            this.nombre = nombre;
        }
        public string Nombre
        {
            get { return nombre; }
        }
    }

    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
   
    public class Collection : IAbstractCollection
    {
        List<Item> items = new List<Item>();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
       
        public int Contador
        {
            get { return items.Contador; }
        }
        // Indexer
        public Item this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }
    }
   

    public class Iterator : IAbstractIterator
    {
        Collection coleccion;
        int actual = 0;
        int paso = 1;
        // Constructor
        public Iterator(Collection coleccion)
        {
            this.coleccion = coleccion;
        }
        // Gets first item
        public Item First()
        {
            actual = 0;
            return coleccion[actual] as Item;
        }
        // Gets next item
        public Item Next()
        {
            actual += paso;
            if (!IsDone)
                return coleccion[current] as Item;
            else
                return null;
        }
        // Gets or sets stepsize
        public int Paso
        {
            get { return paso; }
            set { paso = value; }
        }
        // Gets current iterator item
        public Item ItemActual
        {
            get { return coleccion[actual] as Item; }
        }
        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return actual >= coleccion.Contador; }
        }
    }
}