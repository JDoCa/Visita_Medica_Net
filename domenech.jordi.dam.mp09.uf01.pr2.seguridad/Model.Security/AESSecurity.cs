using System;
using System.Security.Cryptography;
using System.Text;

namespace domenech.jordi.dam.mp09.uf01.pr2.seguridad.Model.Security
{
    public class AESSecurity
    {
        private const string EncryptKey = "clave-32-chars__________________";
        private const string EncryptAlgorithm = "AES";

        public string Encripta(string valorOriginal)
        {
            string resultado = null;
            byte[] cifrado = null;
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(EncryptKey);
                    aesAlg.Mode = CipherMode.ECB;

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(valorOriginal);
                            }
                        }
                        cifrado = msEncrypt.ToArray();
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
            if (cifrado != null)
            {
                resultado = Convert.ToBase64String(cifrado);
            }
            return resultado;
        }

        public string Desencripta(string cifrado)
        {
            string resultado = null;
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(EncryptKey);
                    aesAlg.Mode = CipherMode.ECB;

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cifrado)))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                resultado = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
            return resultado;
        }
    }
}
