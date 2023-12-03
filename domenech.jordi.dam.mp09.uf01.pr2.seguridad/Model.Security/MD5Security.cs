using System;
using System.Security.Cryptography;
using System.Text;

namespace domenech.jordi.dam.mp09.uf01.pr2.seguridad.Model.Security
{
    public class MD5Security
    {
        public string Encripta(string valorOriginal)
        {
            string resultado = null;
            try
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(valorOriginal);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
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
