using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.Infrastructure
{
    public static class PasswordService
    {
        public static string CalculateHash(string plainText)
        {
            var sha = SHA512.Create();
            var bytes = Encoding.Unicode.GetBytes(plainText);
            var hashed = sha.ComputeHash(bytes);
            return Encoding.Unicode.GetString(hashed);
        }
    }
}
