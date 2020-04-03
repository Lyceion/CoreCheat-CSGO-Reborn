using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace MD5Controller
{
    public class MD5Controller
    {
        public static void ChangeMD5(string FilePath)
        {
            Random random = new Random();
            Thread.Sleep(1000);

            int num = random.Next(2, 7);
            byte[] extraByte = new byte[num];
            for (int j = 0; j < num; j++)
            {
                extraByte[j] = (byte)0;
            }
            long fileSize = new FileInfo(FilePath).Length;
            if (fileSize == 0L)
            {

            }
            else
            {
                using (FileStream fileStream = new FileStream(FilePath, FileMode.Append))
                {
                    fileStream.Write(extraByte, 0, extraByte.Length);
                }
                int bufferSize = fileSize > 1048576L ? 1048576 : 4096;
                string md5hash = "";
                using (MD5 md = MD5.Create())
                {
                    using (FileStream fileStream2 = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize))
                    {
                        md5hash = BitConverter.ToString(md.ComputeHash(fileStream2)).Replace("-", "");
                    }
                }
            }
        }

        public static string GetMD5HashFromFile(string FilePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(FilePath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }
    }
}
