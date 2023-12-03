using System;
namespace domenech.jordi.dam.mp09.uf01.pr2.seguridad.Controller
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitaMedicaController visitaMedicaController = new VisitaMedicaController();
            visitaMedicaController.AplicarSeguridadMD5();
            visitaMedicaController.AplicarSeguridadAES();
            visitaMedicaController.AplicarSeguridadSHA256();
        }
    }
}