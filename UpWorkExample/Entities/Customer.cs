﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpWorkExample.Abstract;
using UpWorkExample.Common;

namespace UpWorkExample.Entities
{
    public class Customer : PersonBase<Guid>, ICsvConvertible
    {
        public string PhoneNumber { get; set; }

        public string GetValueCSV()
        {
            return $"{Id} --- {CreatedOn} --- {FirstName} --- {LastName} --- {PhoneNumber}";
        }
        public Customer()
        {

        }

        public void SetValueCSV(string csvLine)
        {
            string[] data = csvLine.Split(',');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[1]);
            FirstName = data[2];
            LastName = data[3];
            PhoneNumber = data[4];

        }
    }
}
