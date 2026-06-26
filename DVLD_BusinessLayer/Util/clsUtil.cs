using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{

    public static class ClsUtil
    {
        public static void CreateFolderIfNotExists(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        public static string GenerateGuidFileName(string originalFileName)
        {
            string extension = Path.GetExtension(originalFileName);

            return $"{Guid.NewGuid()}{extension}";
        }

        public static string CopyImageToFolder(string sourceFile, string destinationFolder)
        {
            CreateFolderIfNotExists(destinationFolder);

            string newFileName = GenerateGuidFileName(sourceFile);

            string destinationPath = Path.Combine(destinationFolder, newFileName);

            File.Copy(sourceFile, destinationPath, true);

            return destinationPath;
        }

        public static object HandleDBNull(object value)
        {
            return value is string str && string.IsNullOrWhiteSpace(str)
                ? DBNull.Value
                : value ?? DBNull.Value;
        }

        public static string HandleDBNullToString(object value)
        {
            if (value == DBNull.Value)
            {
                return null;
            }

            return value.ToString();
        }
    }
}