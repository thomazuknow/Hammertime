using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hammertime.Core
{
    public class FileHandler
    {
        private readonly string FilePath;
        public FileHandler()
        {

            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Hammertime")))
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Hammertime"));

            FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hammertime";
            this.InitiateFiles();

        }

        private void InitiateFiles()
        {
            FileStream bonus = null;
            FileStream platform = null;
            try
            {
                bonus = this.OpenFile(FileType.Bonus);
                platform = this.OpenFile(FileType.Platform);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                bonus?.Close();
                platform?.Close();
            }
        }

        public FileStream OpenFile(FileType file)
        {
            var path = GetFileName(file);

            return File.Open(FilePath + path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        public void Write(FileType fileType, string value)
        {

            var fs = OpenFile(fileType);
            var sw = new StreamWriter(fs);
            sw.AutoFlush = true;
            sw.WriteLine(value);
            sw.Dispose();




            fs.Close();
        }


        private string GetFileName(FileType fileType)
        {
            switch (fileType)
            {
                case FileType.Platform:
                    return "platformes.txt";
                case FileType.Bonus:
                    return "bonuses.txt";
                default:
                    throw new Exception($"FileType not configured");
            }
        }


    }



    public enum FileType
    {
        Platform,
        Bonus

    }
}
