using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;


namespace MBPC001.Models
{
    public class PasswordEncryptor
    {
        // poging om ww the encrypten voor gebruik MySQL
        public static string DecryptPassword(string encryptedPassword, string encryptionKey)
        {
            // Convert the encryption key and hex-encoded password to bytes
            byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(encryptionKey);
            byte[] encryptedBytes = Hex.Decode(encryptedPassword);

            // Create the cipher
            IBufferedCipher cipher = CipherUtilities.GetCipher("AES/CTR/NoPadding");
            cipher.Init(false, new ParametersWithIV(new KeyParameter(keyBytes), new byte[16]));

            // Decrypt the password
            byte[] decryptedBytes = new byte[cipher.GetOutputSize(encryptedBytes.Length)];
            int length = cipher.ProcessBytes(encryptedBytes, 0, encryptedBytes.Length, decryptedBytes, 0);
            cipher.DoFinal(decryptedBytes, length);

            // Convert the decrypted bytes back to a string           
            return System.Text.Encoding.UTF8.GetString(decryptedBytes);
        }
    }
}
