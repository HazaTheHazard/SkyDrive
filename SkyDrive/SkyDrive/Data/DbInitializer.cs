using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SkyDrive.Models;

namespace SkyDrive.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SkyDriveContext context)
        {
            if (context.Account.Any())
            {
              return;  
            }

            var account = new Account[]
            {
                new Account
                {
                    Email = "matthew.king4@sky.uk",
                    Password = "abcd1234",
                    FullName = "Matt King"
                },
                new Account
                {
                    Email = "test@sky.uk",
                    Password = "abcd1234",
                    FullName = "test"
                }
            };

            foreach (Account a in account)
            {
                context.Account.Add(a);
            }
            context.SaveChanges();

        }
    }
}