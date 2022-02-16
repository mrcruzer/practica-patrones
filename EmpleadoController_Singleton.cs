using System;
using static System.Console;

namespace Singleton
{
  class Program
  {
    static void Main(string[] args)
    {
      Singleton Manager = new Singleton();
      Manager.Mensaje("Mensaje desde Manager");

      Singleton Empleado = new Singleton();
      Empleado.Mensaje("Mensaje desde Empleado");

      ReadLine();
    }
  }
}

