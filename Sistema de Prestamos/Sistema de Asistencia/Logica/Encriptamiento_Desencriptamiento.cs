using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Sistema_de_Prestamos.Logica
{
    public class Encriptamiento_Desencriptamiento
    {
        private readonly byte[] _clave;  // Clave de encriptación

        // Constructor que recibe la clave de encriptación
        public Encriptamiento_Desencriptamiento(string clave)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                _clave = sha256.ComputeHash(Encoding.UTF8.GetBytes(clave));
            }
        }

        // Método para encriptar una cadena
        public byte[] EncriptarClave(string clave)
        {
            byte[] claveBytes = Encoding.UTF8.GetBytes(clave);
            byte[] claveCifrada;

            using (Aes aes = Aes.Create())
            {
                aes.Key = _clave;
                aes.IV = new byte[16]; // Vector de inicialización de 16 bytes

                ICryptoTransform encriptador = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encriptador, CryptoStreamMode.Write))
                    {
                        cs.Write(claveBytes, 0, claveBytes.Length);
                        cs.FlushFinalBlock();
                    }
                    claveCifrada = ms.ToArray();
                }
            }

            return claveCifrada;  // Retorna el arreglo de bytes cifrado
        }


        // Método para desencriptar una cadena
        public string DesencriptarClave(string claveCifrada)
        {
            byte[] claveCifradaBytes = Convert.FromBase64String(claveCifrada);
            byte[] claveDesencriptadaBytes;

            using (Aes aes = Aes.Create())
            {
                aes.Key = _clave;
                aes.IV = new byte[16]; // Vector de inicialización de 16 bytes

                ICryptoTransform desencriptador = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(claveCifradaBytes))
                {
                    using (CryptoStream cs = new CryptoStream(ms, desencriptador, CryptoStreamMode.Read))
                    {
                        using (MemoryStream msDesencriptado = new MemoryStream())
                        {
                            cs.CopyTo(msDesencriptado);
                            claveDesencriptadaBytes = msDesencriptado.ToArray();
                        }
                    }
                }
            }

            return Encoding.UTF8.GetString(claveDesencriptadaBytes);
        }
    }
}
