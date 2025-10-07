
// using System.Text;

// string json = "{\"PlayerName\":\"Coralie\",\"Level\":1}";
// byte[] plaintext = Encoding.UTF8.GetBytes(json);


// string password = "UserPassword"; 
// byte[] salt = RandomNumberGenerator.GetBytes(16); // 128 bits

// var key = new Rfc2898DeriveBytes(
//     password,
//     salt,
//     100_000,
//     HashAlgorithmName.SHA256
//     ).GetBytes(32); //256 bis


// // Encrypt with AES-GCM
// using var aes = new AesGcm(key);
// byte[] nonce = RandomNumberGenerator.GetBytes(12); // 96 bits
// byte[] ciphertext = new byte[plaintext.Length];
// byte[] tag = new byte[16]; // 128 bits

// aes.Encrypt(nonce, plaintext, ciphertext, tag);


// //decrypting 
// string encryptedContent = File.ReadAllText("Stock.enc");
// var payload = JsonSerializer.Deserialize<EncryptedPayload>(encryptedContent);

// byte[] salt = Convert.FromBase64String(payload.Salt);
// byte[] nonce = Convert.FromBase64String(payload.Nonce);
// byte[] tag = Convert.FromBase64String(payload.Tag);
// byte[] ciphertext = Convert.FromBase64String(payload.Data);

// string inputPassword = "UserPassword"; 

// var key = new Rfc2898DeriveBytes(
//     inputPassword,
//     salt,
//     100_000,
//     HashAlgorithmName.SHA256
// ).GetBytes(32);


// using var aes = new AesGcm(key);
// byte[] decrypted = new byte[ciphertext.Length];

// try
// {
//     aes.Decrypt(nonce, ciphertext, tag, decrypted);
//     string json = Encoding.UTF8.GetString(decrypted);
//     Console.WriteLine("Decrypt file :");
//     Console.WriteLine(json);
// }
// catch (CryptographicException)
// {
//     Console.WriteLine("Incorrect password or corrompt file.");
// }

// public class EncryptedPayload
// {
//     public string Salt { get; set; } = string.Empty;
//     public string Nonce { get; set; } = string.Empty;
//     public string Tag { get; set; } = string.Empty;
//     public string Data { get; set; } = string.Empty;
// }