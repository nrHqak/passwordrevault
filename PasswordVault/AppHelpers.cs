using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordVault
{
    public static class EncryptionHelper
    {
        public static string Encrypt(string text)
        {
            try
            {
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
            }
            catch
            {
                return text;
            }
        }

        public static string Decrypt(string text)
        {
            try
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String(text));
            }
            catch
            {
                return text;
            }
        }
    }

    public static class PasswordGenerator
    {
        private const string Letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Digits = "0123456789";
        private const string Symbols = "!@#$%^&*()_+-=[]{}|;:,.<>/?";

        public static string Generate(int length, bool useLetters, bool useDigits, bool useSymbols)
        {
            var charPool = new StringBuilder();
            if (useLetters) charPool.Append(Letters);
            if (useDigits) charPool.Append(Digits);
            if (useSymbols) charPool.Append(Symbols);

            if (!useLetters && !useDigits && !useSymbols)
            {
                charPool.Append(Letters); // Default to letters if no options selected
            }

            if (charPool.Length == 0) return string.Empty; // Should not happen with default

            var random = new Random();
            var password = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                password.Append(charPool[random.Next(charPool.Length)]);
            }

            return password.ToString();
        }
    }

    public static class VaultStorage
    {
        public static string FilePath = Path.Combine(Application.StartupPath, "vault.dat");

        public static void Save(List<PasswordEntry> entries)
        {
            try
            {
                var lines = entries.Select(e => $"{e.ServiceName}|{e.Login}|{e.Password}|{e.DateAdded}");
                File.WriteAllLines(FilePath, lines);
            }
            catch (Exception ex)
            {
                // Log or handle exception
                Console.WriteLine($"Error saving vault: {ex.Message}");
            }
        }

        public static List<PasswordEntry> Load()
        {
            var entries = new List<PasswordEntry>();
            if (!File.Exists(FilePath))
            {
                return entries;
            }

            try
            {
                var lines = File.ReadAllLines(FilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        entries.Add(new PasswordEntry(parts[0], parts[1], parts[2])
                        {
                            DateAdded = DateTime.Parse(parts[3])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle exception
                Console.WriteLine($"Error loading vault: {ex.Message}");
            }

            return entries;
        }
    }
}
