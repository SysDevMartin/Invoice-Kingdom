using InvoiceKingdom.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

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

        public DateTime Created { get; set; } = DateTime.Now;

        public bool IsHidden { get; set; } = false;

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
            string phoneNumber,
            List<WorkType> workTypes
            )
        {
            // Trim values.
            firstName = firstName.Trim();
            lastName = lastName.Trim();
            personalIdentityNumber = personalIdentityNumber.Trim();
            streetAddress = streetAddress.Trim();
            postalCode = postalCode.Trim();
            city = city.Trim();
            emailAddress = emailAddress.Trim();
            phoneNumber = phoneNumber.Trim();

            // Validate required values.
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException("firstName");
            if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException("lastName");
            if (string.IsNullOrEmpty(streetAddress)) throw new ArgumentNullException("streetAddress");
            if (string.IsNullOrEmpty(postalCode)) throw new ArgumentNullException("postalCode");
            if (string.IsNullOrEmpty(city)) throw new ArgumentNullException("city");

            // Validate personal identity number (if supplied).
            if (personalIdentityNumber.Length > 0)
            {
                // Sanitize value.
                personalIdentityNumber = personalIdentityNumber.Replace("-", string.Empty);

                var match = Regex.Match(personalIdentityNumber, "^[0-9]{12}$");
                if (!match.Success)
                {
                    throw new ArgumentException("Invalid personal identity number. Requires exactly 12 digits.");
                }
            }

            // Validate e-mail address (if supplied).
            if (emailAddress.Length > 0)
            {
                var match = Regex.Match(emailAddress, "@");
                if (!match.Success)
                {
                    throw new ArgumentException("Invalid e-mail address.");
                }
            }

            // Validate phone number (if supplied).
            if (phoneNumber.Length > 0)
            {
                var match = Regex.Match(phoneNumber, "^[0-9]+-?[0-9]+$");
                if (!match.Success)
                {
                    throw new ArgumentException("Invalid phone number. Must include only digits and at most one hyphen (-).");
                }
            }

            try
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
                    WorkTypes = workTypes,
                    Created = DateTime.Now
                };
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public static List<Customer> GetAllCustomers(InvoiceKingdomContext context)
        {
            return context.Customers.OrderBy(c => c.FirstName).ThenBy(c => c.LastName).ToList();
        }

        public Invoice GetLatestInvoice(InvoiceKingdomContext context)
        {
            Invoice latestInvoice = null!;

            var result = context.Invoices
                .OrderByDescending(i => i.Created)
                .Where(c => c.Id == Id);

            Debug.WriteLine(result);

            if (result.Any())
            {
                latestInvoice = result.First();
            }

            return latestInvoice;
        }
    }
}
