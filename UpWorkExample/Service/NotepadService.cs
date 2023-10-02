using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpWorkExample.Abstract;
using UpWorkExample.Constant;

namespace UpWorkExample.Service
{
    public class NotepadService
    {
        public void SaveToNotepad(ICsvConvertible data)
        {
            string path = $"{FileLocation.ProjectFolder}\\Database";
            string type = data.GetType().ToString().Split(" --- ").LastOrDefault();

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = $"{path}\\{type}s.txt";
            File.AppendAllText(filePath, $"{data.GetValueCSV()}\n");
        }
        public string GetOnNotepad(string path)
        {
                if (File.Exists(path))
                    return File.ReadAllText(path);

                throw new Exception("File Doesn't Exist");
        }
        
    }
}
