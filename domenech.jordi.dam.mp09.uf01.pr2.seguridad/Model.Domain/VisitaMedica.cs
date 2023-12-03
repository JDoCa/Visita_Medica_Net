using System;

namespace domenech.jordi.dam.mp09.uf01.pr2.seguridad.Model.Domain
{
    public class VisitaMedica
    {
        public int IdVisita { get; set; }
        public string NomPaciente { get; set; }
        public string NomMetge { get; set; }
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }

        public override string ToString()
        {
            return $"VisitaMedica{{idVisita={IdVisita}, nomPaciente='{NomPaciente}', nomMetge='{NomMetge}', fecha={Fecha}, diagnostico='{Diagnostico}'}}";
        }
    }
}
