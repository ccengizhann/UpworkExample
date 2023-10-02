using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpWorkExample.Abstract;
using UpWorkExample.Common;

namespace UpWorkExample.Entities
{
    public class Review:EntityBase<Guid>,ICsvConvertible
    {
        public String Text { get; set; }
        public int Rating { get; set; }

        public string GetValueCSV()
        {
            return $"{Text} --- {Rating}";
        }

        public void SetValueCSV(string csv)
        {
            throw new NotImplementedException();
        }
    }
}
