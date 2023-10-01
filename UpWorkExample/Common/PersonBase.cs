using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpWorkExample.Common
{
    public class PersonBase<TKey>:EntityBase<TKey>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
