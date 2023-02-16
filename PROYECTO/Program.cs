// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using PROYECTO.Entidades;
using PROYECTO.Negocio;

Operaciones operaciones = new Operaciones();
clsOperaciones clsOperaciones = new clsOperaciones();

Console.WriteLine("Ingrese una palabra");

operaciones.palabra = Console.ReadLine();

Console.WriteLine("Su palabra contiene "+clsOperaciones.Conteo(operaciones)+" caracteres");