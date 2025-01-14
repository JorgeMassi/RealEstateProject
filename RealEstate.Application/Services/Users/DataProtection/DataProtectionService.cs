using RealEstate.Application.Interfaces.Users.DataProtection;
using RealEstate.Domain.Logins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Services.Users.DataProtection
{
    public class DataProtectionService : IDataProtectionService
    {
        public DataProtectionKeys Protect(string password)
        {
            using var hmac = new HMACSHA512();

            byte[] hashedPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            byte[] saltKey = hmac.Key;

            return new DataProtectionKeys(hashedPass, saltKey);
        }

        public byte[] GetComputedHash(string password, byte[] salt)
        {
            using var hmac = new HMACSHA512(salt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return computedHash;
        }
    }
}
