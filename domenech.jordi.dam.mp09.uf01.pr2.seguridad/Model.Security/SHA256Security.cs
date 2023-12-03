using System;
using System.Security.Cryptography;
using System.Text;

namespace domenech.jordi.dam.mp09.uf01.pr2.seguridad.Model.Security
{
    public class SHA256Security
    {
        public string Encripta(string valorOriginal)
        {
            string resultado = null;
            try
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(valorOriginal);
                    byte[] hashBytes = sha256.ComputeHash(inputBytes);
                    resultado = Convert.ToBase64String(hashBytes);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return resultado;
        }

    }
}
