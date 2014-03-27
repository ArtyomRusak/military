using System.Security.Cryptography;
using System.Text;

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
