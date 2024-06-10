using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace EncryptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data JSON yang ingin dienkripsi
            string data = "{ star : 12, star : 4, score : 5 }";
            Console.WriteLine("\nhasil:\n" + Encrypt(data));
        }

        static string Encrypt(string data)
        {

            // Generate kunci enkripsi 256-bit (32 byte)
            byte[] key = new byte[32];
            RandomNumberGenerator.Fill(key);

            // Pastikan panjang kunci benar
            if (key.Length != 32)
            {
                throw new ArgumentException("Kunci enkripsi harus 32 byte (256 bit).");
            }

            // Generate nonce dan timestamp
            byte[] nonce = new byte[12];
            RandomNumberGenerator.Fill(nonce);
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            // Enkripsi data JSON, nonce, dan timestamp dengan AES-GCM
            using (AesGcm aesGcm = new AesGcm(key))
            {
                var encryptedData = new { Data = data, Timestamp = timestamp };
                string encryptedJsonString = JsonSerializer.Serialize(encryptedData);

                byte[] plaintextBytes = Encoding.UTF8.GetBytes(encryptedJsonString);
                byte[] ciphertext = new byte[plaintextBytes.Length];
                byte[] tag = new byte[16];

                aesGcm.Encrypt(nonce, plaintextBytes, ciphertext, tag);

                // Simpan nonce, ciphertext, dan timestamp (misalnya, ke database)
                Console.WriteLine("Key (Base64): " + Convert.ToBase64String(key));
                Console.WriteLine("Nonce: " + Convert.ToBase64String(nonce));
                Console.WriteLine("Ciphertext: " + Convert.ToBase64String(ciphertext));
                Console.WriteLine("Tag: " + Convert.ToBase64String(tag));

                return "{\"Key\" : \""+Convert.ToBase64String(key)+"\", \"Nonce\" : \""+Convert.ToBase64String(nonce)+"\", \"Ciphertext\" : \""+Convert.ToBase64String(ciphertext)+"\", \"Tag\" : \""+Convert.ToBase64String(tag)+"\"}";
            }
        }
    }
}
