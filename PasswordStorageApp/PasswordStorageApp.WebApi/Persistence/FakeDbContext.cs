using System;
using System.Collections.Generic;
using PasswordStorageApp.WebApi.Models;

namespace PasswordStorageApp.WebApi.Persistence
{
    public class FakeDbContext
    {
        public static List<Account> Accounts { get; set; } = new List<Account>
        {
            new Account
            {
                Id = new Guid("a1b2c3d4-e5f6-47g8-h9i0-j1k2l3m4n5o6"),
                Username = "admin",
                Password = "Admin@1234",
                CreateOn = new DateTimeOffset(new DateTime(2023, 1, 15), TimeSpan.Zero), // January 15, 2023
            },
            new Account
            {
                Id = new Guid("b2c3d4e5-f6g7-48h9-i0j1-k2l3m4n5o6p7"),
                Username = "john.doe",
                Password = "John2023!",
                CreateOn = new DateTimeOffset(new DateTime(2023, 5, 20), TimeSpan.Zero), // May 20, 2023
            },
            new Account
            {
                Id = new Guid("c3d4e5f6-g7h8-49i0-j1k2-l3m4n5o6p7q8"),
                Username = "jane.smith",
                Password = "Jane#2024",
                CreateOn = new DateTimeOffset(new DateTime(2023, 8, 10), TimeSpan.Zero), // August 10, 2023
            },
            new Account
            {
                Id = new Guid("d4e5f6g7-h8i9-40j1-k2l3-m4n5o6p7q8r9"),
                Username = "mike.jones",
                Password = "Mike@4567",
                CreateOn = new DateTimeOffset(new DateTime(2024, 2, 5), TimeSpan.Zero), // February 5, 2024
            },
            new Account
            {
                Id = new Guid("e5f6g7h8-i9j0-41k2-l3m4-n5o6p7q8r9s0"),
                Username = "sarah.connor",
                Password = "Sarah#2024",
                CreateOn = new DateTimeOffset(new DateTime(2024, 6, 25), TimeSpan.Zero), // June 25, 2024
            },
        };
    }
}