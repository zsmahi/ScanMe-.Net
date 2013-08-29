using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ScanMe.Net_processing.Hashs
{
    class Hashs
    {
        /// <summary>
        /// Sha256 generate the SHA256 Hash
        /// </summary>
        
        
        public static string Sha256(byte[] buffering)
        {
            if (buffering == null) throw new ArgumentNullException("buffering");
            using (var sha256 = SHA256.Create())
            {
                var hashBytes = sha256.ComputeHash(buffering);
                return ByteArrayToString(hashBytes);
            }
        }

        public static string Sha256(string chaine)
        {
            if (chaine == null) throw new ArgumentNullException("chaine");
            return Sha256((Encoding.ASCII.GetBytes(chaine)));
        }

        /// <summary>
        /// ByteArrayToString
        /// </summary>

        public static string ByteArrayToString(byte[] byteArray)
        {
            if (byteArray == null) throw new ArgumentNullException("byteArray");
            var hexadecimal = new StringBuilder(byteArray.Length * 2);
            foreach (var b in byteArray)
                hexadecimal.AppendFormat("{0:x2}", b);

            return hexadecimal.ToString();
        }

        /// <summary>
        /// Md5 generate the MD5 Hash
        /// </summary>

        public static string Md5(byte[] bufferring)
        {
            if (bufferring == null) throw new ArgumentNullException("bufferring");
            using (var md5 = MD5.Create())
            {
                var md5Result = md5.ComputeHash(bufferring);
                return ByteArrayToString(md5Result);
            }
        }

        public static string Md5(string content)
        {
            if (content == null) throw new ArgumentNullException("content");
            return Md5(Encoding.ASCII.GetBytes(content));
        }

        public static string Md5(FileInfo file)
        {
            if (file.Exists)
            {
                var buffer = File.ReadAllBytes(file.FullName);
                return Md5(buffer);
            }

            throw new FileNotFoundException("File not found.", file.FullName);
        }
    }
}
