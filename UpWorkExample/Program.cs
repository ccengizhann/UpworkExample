﻿using System;
using UpWorkExample.Common;
using UpWorkExample.Abstract;
using UpWorkExample.Entities;
using UpWorkExample.Service;

/*ICsvConvertible freelancerInstance = new Freelancer()
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTime.Now,
    FirstName = "Tyler",
    LastName = "Durden",
    WorkExperience = "5 years of experience in web development"
};*/

/*var anotherCustomerInstance = new Customer
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTime.Now,
    FirstName = "Alex",
    LastName = "Mc Kenny",
    PhoneNumber = "545-167-3000"
};*/

var review = new Review()
{
    Text = "Excellent freelancer!",
    Rating = 5

}

NotepadService notepadService = new NotepadService();
notepadService.SaveToNotepad(review);




//string customerData = notepadService.GetOnNotepad("C:\Users\cengi\yetgen_akbank_bootcamp\UpworkExample\UpWorkExample\Database");
//
//string[] splittedLines = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

//List<Customer> customers = new();
//
//foreach (var line in splittedLines)
//{
//    Customer customer = new();
//    customer.SetValueCSV(line);
//    customers.Add(customer);
//}