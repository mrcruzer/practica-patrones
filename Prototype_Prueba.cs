using System;
using System.Collections.Generic;
namespace Prototype.Prueba
{
    /// <summary>
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            AdministradorColores administradorcolores = new AdministradorColores();
           
            administradorcolores["rojo"] = new Color(255, 0, 0);
            administradorcolores["verde"] = new Color(0, 255, 0);
            administradorcolores["azul"] = new Color(0, 0, 255);
           
            Color color1 = administradorcolores["red"].Clone() as Color;
            Color color2 = administradorcolores["verde"].Clone() as Color;
            Color color3 = administradorcolores["azul"].Clone() as Color;
           
            Console.ReadKey();
        }
    }
    /// <summary>
   
    /// </summary>
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
    /// <summary>
    
    /// </summary>
    public class Color : ColorPrototype
    {
        int rojo;
        int verde;
        int azul;
    
        public Color(int rojo, int verde, int azul)
        {
            this.rojo = rojo;
            this.verde = verde;
            this.azul = azul;
        }
            public override ColorPrototype Clone()
        {
            Console.WriteLine(
                rojo, verde, azul);
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
    /// <summary>
    /// </summary>
    public class AdministradorColores
    {
        private Dictionary<string, ColorPrototype> colores =
            new Dictionary<string, ColorPrototype>();
       
        public ColorPrototype this[string key]
        {
            get { return colores[key]; }
            set { colores.Add(key, value); }
        }
    }
}