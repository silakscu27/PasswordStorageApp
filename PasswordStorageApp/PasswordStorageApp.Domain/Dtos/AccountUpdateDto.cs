﻿using PasswordStorageApp.Domain.Enums;
using PasswordStorageApp.Domain.Models;

namespace PasswordStorageApp.WebApi.Dtos
{
    public class AccountUpdateDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public AccountType Type { get; set; }

        public Account ToAccount(Account account)
        {
            account.Username = Username;
            account.Password = Password;
            account.ModifiedOn = DateTimeOffset.UtcNow;

            return account;
        }
    }
}
