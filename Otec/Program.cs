using System;
using OtecLibrary;
using System.Linq;

namespace Otec
{
    class Program
    {
            static void Main(string[] args) {

            Administrador administrador = new Administrador();
            administrador.nombreAdministrador = "Rodrigo Barria";

            Sede sede = new Sede();
            sede.nombreSede = "Los Ángeles";

            Curso curso = new Curso();
            curso.nombreCurso = "Ofimática";

            Coordinador coordinador = new Coordinador();
            coordinador.nombreCoordinador = "Claudio Montoya";

            Asignaturas arr1 = new Asignaturas();
            arr1.Arr1.Count();

            Console.WriteLine("Ficha Persona: \n");
            Console.WriteLine("Nombre de Sede: " + sede.nombreSede);
            Console.WriteLine("Nombre de Curso: " + curso.nombreCurso);
            Console.WriteLine("Nombre de Administrador: " + administrador.nombreAdministrador);
            Console.WriteLine("Nombre de Coordinador: " + coordinador.nombreCoordinador);
            Console.WriteLine("Cantidad de Asignaturas: " + arr1.Arr1.Count());
        }
    }
}
