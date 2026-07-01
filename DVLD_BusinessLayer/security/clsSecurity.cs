using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;

namespace DVLD.More
{
    public class clsSecurity
    {
       

        static private string RegistryPath = @"HKEY_CURRENT_USER\SOFTWARE\zDVLD";
        private static string GetHashedPassword(string salt, string password)
        {
            byte[] Salt = Convert.FromBase64String(salt);

          
            string passwordWithPepper = password + Registry.GetValue(RegistryPath, "Pepper", "") as string;

            byte[] hash;
            using (var pbkdf2 = new Rfc2898DeriveBytes(passwordWithPepper, Salt, 310000, HashAlgorithmName.SHA256))
            {
                hash = pbkdf2.GetBytes(32); 
            }
            return Convert.ToBase64String(hash);
        }

        public static string CreateNewHashPassword(string password)
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }


            string passwordWithPepper = password + Registry.GetValue(RegistryPath, "Pepper", "") as string;

            byte[] hash;
            using (var pbkdf2 = new Rfc2898DeriveBytes(passwordWithPepper, salt, 310000, HashAlgorithmName.SHA256))
            {
                hash = pbkdf2.GetBytes(32);
            }
            string saltBase64 = Convert.ToBase64String(salt);
            string hashBase64 = Convert.ToBase64String(hash);

            return saltBase64 + ":" + hashBase64;
        }

        public static bool IsTruePassword(string password, string HashedPasswordWithSalt)
        {
            string[] SplitHashRecord = HashedPasswordWithSalt.Split(':');
            if (SplitHashRecord.Length != 2) return false;

            string s = SplitHashRecord[0]; 
            string h = SplitHashRecord[1]; 
            string jjjj = GetHashedPassword(s, password);
            if (h.Equals(GetHashedPassword(s, password))) return true;
            return false;
        }

        #region XOR Encryption (SimpleEncrypt / SimpleDecrypt)
        public static string SimpleEncrypt(string password)
        {
            StringBuilder encrypted = new StringBuilder();
            string key = Registry.GetValue(RegistryPath, "PasswordEncryptionKey", "") as string;
            for (int i = 0; i < password.Length; i++)
            {
                char encryptedChar = (char)(password[i] ^ key[i % key.Length]);
                encrypted.Append(Convert.ToString((int)encryptedChar, 16).PadLeft(2, '0'));
            }
            return encrypted.ToString();
        }

        public static string SimpleDecrypt(string encrypted)
        {
            StringBuilder decrypted = new StringBuilder();
            string key = Registry.GetValue(RegistryPath, "PasswordEncryptionKey", "") as string;
            for (int i = 0; i < encrypted.Length; i += 2)
            {
                int charCode = Convert.ToInt32(encrypted.Substring(i, 2), 16);
                char decryptedChar = (char)(charCode ^ key[(i / 2) % key.Length]);
                decrypted.Append(decryptedChar);
            }
            return decrypted.ToString();
        }
        #endregion

        public static string SymmetricEncrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                string key = Registry.GetValue(RegistryPath, "PasswordEncryptionKey", "") as string;
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string SymmetricDecrypt(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                string key = Registry.GetValue(RegistryPath, "PasswordEncryptionKey", "") as string;
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    // Read the decrypted data from the StreamReader
                    return srDecrypt.ReadToEnd();
                }
            }
        }

        public static string AsymmetricEncrypt(string plainText, string publicKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(publicKey);

                    byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(plainText), false);
                    return Convert.ToBase64String(encryptedData);
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Encryption error: {ex.Message}");
                throw; // Rethrow the exception to be caught in the Main method
            }
        }

        public static string AsymmetricDecrypt(string cipherText, string privateKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(privateKey);

                    byte[] encryptedData = Convert.FromBase64String(cipherText);
                    byte[] decryptedData = rsa.Decrypt(encryptedData, false);

                    return Encoding.UTF8.GetString(decryptedData);
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Decryption error: {ex.Message}");
                throw; 
            }
        }


    }
}