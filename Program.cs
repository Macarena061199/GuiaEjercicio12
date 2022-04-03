using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*	Solicite el ingreso de dos frases y determine si son iguales.*/

string frase;
string frase2;

do
{
    Console.Write("Por favor ingrese una frase: ");
    frase = Console.ReadLine();

    Console.Write("Por favor ingrese otra frase: ");
    frase2 = Console.ReadLine();


    bool comparasion = frase.Equals(frase2, StringComparison.InvariantCultureIgnoreCase);

    if (comparasion == true)
    {
        Console.WriteLine("Las frases ingresadas son iguales.");
      
    }
    else
    {
        Console.WriteLine("Las frases ingresasas no son iguales.");
    }

} while (frase != frase2);

/* Solicite el ingreso de dos frases y determine si tienen la misma longitud.*/
int log1;
int log2;
do
{
    Console.Write("Por favor ingrese una frase: ");
    string frase3 = Console.ReadLine();

    Console.Write("Por favor ingrese otra frase: ");
    string frase4 = Console.ReadLine();

    log1 = frase3.Length;
    log2 = frase4.Length;


    if (log1 == log2)
    {
        Console.WriteLine("Las frases ingresadas tienen la misma longitud.");
        
    }
    else
    {
        Console.WriteLine("Las frases ingresasas no tienen la misma longitud.");
    }

} while (log1 != log2);

/*	Solicite el ingreso de dos frases y determine si son iguales, sin diferenciar mayúsculas de minúsculas.*/

string fras;
string fras2;

do
{
    Console.Write("Por favor ingrese una frase: ");
    fras = Console.ReadLine();

    Console.Write("Por favor ingrese otra frase: ");
    fras2 = Console.ReadLine();

    

    bool comparasion = fras.Equals(fras2);

    if (comparasion == true)
    {
        Console.WriteLine("Las frases ingresadas son iguales.");

    }
    else
    {
        Console.WriteLine("Las frases ingresasas no son iguales.");
    }

} while (fras != fras2);
