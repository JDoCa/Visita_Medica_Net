using domenech.jordi.dam.mp09.uf01.pr2.seguridad.Model.Domain;
using domenech.jordi.dam.mp09.uf01.pr2.seguridad.Model.Security;
using Domenech.Jordi.Dam.Mp09.Uf01.Pr2.Seguridad.View.Console;


namespace domenech.jordi.dam.mp09.uf01.pr2.seguridad.Controller
{
    public class VisitaMedicaController
    {
        private readonly VisitaMedicaView _visitaMedicaView = new VisitaMedicaView();

        public void AplicarSeguridadMD5()
        {
            try
            {
                _visitaMedicaView.MostrarMensaje("MD5 ------------", false);
                VisitaMedica visitaMedica = _visitaMedicaView.GetVisitaMedica();

                MD5Security md5Security = new MD5Security();

                string nomPacienteEnc = md5Security.Encripta(visitaMedica.NomPaciente);
                string diagnosticoEnc = md5Security.Encripta(visitaMedica.Diagnostico);

                VisitaMedica visitaMedicaEnc = new VisitaMedica
                {
                    IdVisita = visitaMedica.IdVisita,
                    NomPaciente = nomPacienteEnc,
                    NomMetge = visitaMedica.NomMetge,
                    Fecha = visitaMedica.Fecha,
                    Diagnostico = diagnosticoEnc
                };

                _visitaMedicaView.MostrarVisitaMedica(visitaMedicaEnc);
            }
            catch (Exception ex)
            {
                _visitaMedicaView.MostrarMensaje(ex.Message, true);
            }
        }

        public void AplicarSeguridadSHA256()
        {
            try
            {
                _visitaMedicaView.MostrarMensaje("SHA256 ------------", false);
                VisitaMedica visitaMedica = _visitaMedicaView.GetVisitaMedica();

                SHA256Security sha256Security = new SHA256Security();

                string nomPacienteEnc = sha256Security.Encripta(visitaMedica.NomPaciente);
                string diagnosticoEnc = sha256Security.Encripta(visitaMedica.Diagnostico);

                VisitaMedica visitaMedicaEnc = new VisitaMedica
                {
                    IdVisita = visitaMedica.IdVisita,
                    NomPaciente = nomPacienteEnc,
                    NomMetge = visitaMedica.NomMetge,
                    Fecha = visitaMedica.Fecha,
                    Diagnostico = diagnosticoEnc
                };

                _visitaMedicaView.MostrarVisitaMedica(visitaMedicaEnc);
            }
            catch (Exception ex)
            {
                _visitaMedicaView.MostrarMensaje(ex.Message, true);
            }
        }

        public void AplicarSeguridadAES()
        {
            try
            {
                _visitaMedicaView.MostrarMensaje("AES ------------ Encripta", false);
                VisitaMedica visitaMedica = _visitaMedicaView.GetVisitaMedica();

                AESSecurity aesSecurity = new AESSecurity();

                string nomPacienteEnc = aesSecurity.Encripta(visitaMedica.NomPaciente);
                string diagnosticoEnc = aesSecurity.Encripta(visitaMedica.Diagnostico);

                VisitaMedica visitaMedicaEnc = new VisitaMedica
                {
                    IdVisita = visitaMedica.IdVisita,
                    NomPaciente = nomPacienteEnc,
                    NomMetge = visitaMedica.NomMetge,
                    Fecha = visitaMedica.Fecha,
                    Diagnostico = diagnosticoEnc
                };

                _visitaMedicaView.MostrarVisitaMedica(visitaMedicaEnc);

                _visitaMedicaView.MostrarMensaje("AES ------------ Desencripta", false);
                string nomPacienteDesenc = aesSecurity.Desencripta(visitaMedicaEnc.NomPaciente);
                string diagnosticoDesenc = aesSecurity.Desencripta(visitaMedicaEnc.Diagnostico);

                VisitaMedica visitaMedicaDesenc = new VisitaMedica
                {
                    IdVisita = visitaMedica.IdVisita,
                    NomPaciente = nomPacienteDesenc,
                    NomMetge = visitaMedica.NomMetge,
                    Fecha = visitaMedica.Fecha,
                    Diagnostico = diagnosticoDesenc
                };

                _visitaMedicaView.MostrarVisitaMedica(visitaMedicaDesenc);
            }
            catch (Exception ex)
            {
                _visitaMedicaView.MostrarMensaje(ex.Message, true);
            }
        }
    }
}
