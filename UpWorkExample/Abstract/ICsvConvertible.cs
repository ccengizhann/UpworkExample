using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpWorkExample.Abstract
{
    public interface ICsvConvertible
    {
        string GetValueCSV();
        void SetValueCSV(string csv);
    }
}
