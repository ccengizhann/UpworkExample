
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

var anotherCustomerInstance = new Customer
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTime.Now,
    FirstName = "Alex",
    LastName = "Mc Kenny",
    PhoneNumber = "545-167-3000"
};


NotepadService notepadService = new NotepadService();
notepadService.SaveToNotepad(anotherCustomerInstance);




//string customerData = notepadService.GetOnNotepad("C:\\Users\\ahmet\\OneDrive\\Documents\\GitHub\\Backend_Lecture_Materials\\Lecture_3\\Freelancer\\Database\\Customers.txt");
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