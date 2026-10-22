using InvoiceKingdom.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InvoiceKingdom.Models
{
    internal class Customer
    {
        #region Database fields
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public string PersonalIdentityNumber { get; set; } = null!;

        public required string StreetAddress { get; set; }

        public required string PostalCode { get; set; }

        public required string City { get; set; }

        public string EmailAddress { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public ICollection<WorkType> WorkTypes { get; set; } = null!;

        public DateTime Created { get; set; }
        #endregion

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public static void CreateCustomer(
            InvoiceKingdomContext context,
            string firstName,
            string lastName,
            string personalIdentityNumber,
            string streetAddress,
            string postalCode,
            string city,
            string emailAddress,
            string phoneNumber)
        {
            var customer = new Customer()
            {
                FirstName = firstName,
                LastName = lastName,
                PersonalIdentityNumber = personalIdentityNumber,
                StreetAddress = streetAddress,
                PostalCode = postalCode,
                City = city,
                EmailAddress = emailAddress,
                PhoneNumber = phoneNumber,
                Created = DateTime.Now
            };
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public static IOrderedQueryable<Customer> GetAllCustomers(InvoiceKingdomContext context)
        {
            return context.Customers.OrderBy(c => c.FirstName).ThenBy(c => c.LastName);
        }
    }
}
