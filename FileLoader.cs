using System;
using System.IO;
using System.Text;
using System.Net;

namespace invento_web_app
{
    class FileLoader
    {
        public string pathToFile;
        public byte[] data;
        public int totalBytes = 0;
        public string mimeType;
        public FileLoader(string path)
        {
            pathToFile = "serverRoot" + path;

            switch (Path.GetExtension(pathToFile))
            {
                case ".html": mimeType = "text/html"; break;
                case ".jpg": mimeType = "image/jpeg"; break;
                case ".png": mimeType = "image/png"; break;
                case ".css": mimeType = "text/css"; break;
                case ".js": mimeType = "text/javascript"; break;
                case ".ttf":mimeType = "application/x-font-ttf"; break;
                case ".otf":mimeType = "application/x-font-otf"; break;
            }
        }

        public void ReadFile()
        {
            if(File.Exists(pathToFile) == false)
            {
                throw new FileNotFoundException("No such file in directory");
            }
            else
            {
                FileStream fileStream = new FileStream(pathToFile, FileMode.Open, FileAccess.Read, FileShare.Read);
                BinaryReader binReader = new BinaryReader(fileStream);
                data = new byte[fileStream.Length];
                int read;

                while((read = binReader.Read(data, 0, data.Length)) != 0)
                {
                    totalBytes += read;
                }

                binReader.Close();
                fileStream.Close();
            }
        }
    }
}