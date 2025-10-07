using System.Security.Cryptography


string password = "userPassword"; 
byte[] salt = RandomNumberGenerator.GetBytes(16); // 128 bits

var key = new Rfc2898DeriveBytes(
    password,
    salt,
    100_000,
    HashAlgorithmName.SHA256
    )GetBytes(32); //256 bis

