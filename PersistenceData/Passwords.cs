// using System;
// using System.Security.Cryptography;
// using System.Text;

// public static class PassworldManager
// {
//     private const int Saltsize = 16;
//     private const int Hashsize = 32;
//     private const int Iterations = 100_000;


//     // Generated hash and salt based on password
//     public static (string hashB64, string saltB64) HashPassword(string password)
//     {
//         byte[] salt = RandomNumberGenerator.GetBytes(Saltsize);

//         var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
//         byte[] hash = pbkdf2.GetBytes(Hashsize);

//         return (Convert.ToBase64String(hash), Convert.ToBase64String(salt));
//     }

//     // check if the password matches with the hash  
//     public static bool VerifyPassword(string password, string storedHashB64, string storedSaltB64)
//     {
//         byte[] salt = Convert.FromBase64String(storedSaltB64);
//         byte[] storedHash = Convert.FromBase64String(storedHashB64);

//         var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
//         byte[] computedHash = pbkdf2.GetBytes(Hashsize);

//         return CryptographicOperations.FixedTimeEquals(storedHash, computedHash);
//     }



// }