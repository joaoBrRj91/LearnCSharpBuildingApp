
using System;
using System.IO;

namespace WorldUnscrambler.Workers
{
    public class FileReader
    {
        public string[] Read(string fileName)
        {
            string[] fileContent;

            try
            {
                fileContent = File.ReadAllLines(fileName);
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(ex.Message,ex);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return fileContent;
        }
    }
}
