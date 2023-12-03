using System;
using domenech.jordi.dam.mp09.uf01.pr2.seguridad.Model.Domain;

namespace Domenech.Jordi.Dam.Mp09.Uf01.Pr2.Seguridad.View.Console
{
    public class VisitaMedicaView
    {
        public VisitaMedica GetVisitaMedica()
        {
            VisitaMedica visitaMedica = new VisitaMedica();
            System.Console.WriteLine("Introduce el ID de la visita: ");
            visitaMedica.IdVisita = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Introduce el nombre del paciente: ");
            visitaMedica.NomPaciente = System.Console.ReadLine();

            System.Console.WriteLine("Introduce el nombre del médico: ");
            visitaMedica.NomMetge = System.Console.ReadLine();

            System.Console.WriteLine("Introduce la fecha (YYYY-MM-DD): ");
            visitaMedica.Fecha = DateTime.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Introduce el diagnóstico: ");
            visitaMedica.Diagnostico = System.Console.ReadLine();

            return visitaMedica;
        }

        public void MostrarVisitaMedica(VisitaMedica visitaMedica)
        {
            System.Console.WriteLine(visitaMedica.ToString());
        }

        public void MostrarMensaje(string mensaje, bool esError)
        {
            if (esError)
            {
                System.Console.Error.WriteLine(mensaje);
            }
            else
            {
                System.Console.WriteLine(mensaje);
            }
        }
    }
}
