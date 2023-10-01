using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpWorkExample.Constant
{
    public static class FileLocation
    {
        //C:\Users\cengi\C# project\UpWorkExample\UpWorkExample\Database
        public static string ProjectFolder => Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        
    }
}
