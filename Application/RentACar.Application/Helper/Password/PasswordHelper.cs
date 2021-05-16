using EasyEncryption;
using System;
using System.Text;

namespace RentACar.Application.Helper.Password
{
    public static class PasswordHelper
    {
        private static string HashPasswordSHA256(string input)
        {
            return SHA.ComputeSHA256Hash(input);
        }
        private static string HashPasswordMD5(string input)
        {
            return EasyEncryption.MD5.ComputeMD5Hash(input);
        }
        private static string TwoTimeCrypt(string password, string salt)
        {
            var firstCrypt = HashPasswordMD5(salt + password);

            return HashPasswordSHA256(firstCrypt);
        }
        public static string CreateRandomSaltMD5()
        {
            Random rnd = new Random();
            var length = rnd.Next(15, 30);
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return HashPasswordMD5(res.ToString());

        }
        public static bool PasswordsMatch(string password, string salt, string dbPassword)
        {
            var hashedInput = TwoTimeCrypt(password, salt);
            return string.Equals(hashedInput, dbPassword);
        }
        public static string CreateDbPass(string password, string salt)
        {
            var dbPassword = TwoTimeCrypt(password, salt); // in db password

            return dbPassword;
        }

    }
}
