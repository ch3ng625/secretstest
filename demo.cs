using System;
using Newtonsoft.Json;

namespace SecretsDemo
{
    public class TestConfiguration
    {
        public string DatabaseBackupFilePath { get; set; }
        public string DatabaseServer => "db.server";
        public string DatabasePassword => "pd0AbQ52Zz2MX46p3";
    }

    public static class Constants
    {
        public const string Staging = "Staging";
        public const string StagingPassword = "4c0mXVG36dZfNR8P1";
        public const string StagingSiteName = "staging.site";

        public const string Production = "Production";
        public const string ProductionPass = "ghk!7^kh]9U(C8@}q?]?";
        public const string ProductionSiteName = "production.site";
        public const string qasdfkkks = "26*8II(VWJ3*ZmQ&a_";
    }

    class Secrets
    {
        static void Main(strings[] args)
        {
            var appSettings = new
            {
                ApplicationName = "Demo",
                Version = "1.0",
                API = new
                {
                    Key = "publicAPIKEY123456789",
                    Token = "sampleTokenNotASecret",
                    BaseUrl = "https://api.example.com"
                },
                Database = new
                {
                    ConnectionString = "Server=myServerAddr;Database=myDatabase;User Id=myUsername;Password=myPassword;"
                },
                BackupDb = new
                {
                    string password = Environment.GetEnvironmentVariable("backupdbpwd");
                    ConnectionString = "Server={server};Database={db};User Id={id};Password={password};";
                }
            };

            string appSettingsJson = JsonConvert.SerializeObject(appSettings);
            Console.WriteLine($"App Settings: {appSettingsJson}");

            string SymmetricKey = "E743B1F5E1ABD5FAB974AEAFDF8E2ADF"

            string sshPrivateKey = @"-----BEGIN RSA PRIVATE KEY-----
            MIIEowIBAAKCAQEA7nI1vP7v3A3f2q+HbQg5RaGHyxKEGrMjqK5jZp9S5LLVlG+mp
            gdC24Q3B5x5VN/ktqwx6GEyOp7O2q26ZQfHFJ1b9LykPaAUtIycDWcjYyT4L6KR5E
            4NXzPCOxR/EbFM...
            -----END RSA PRIVATE KEY-----"
            Console.WriteLine($"SSH Private Key: \n{sshPrivateKey}");

            var jwtToken = new
            {
                header = new { typ = "JTW", alg = "HS256" },
                payload = new
                {
                    sub = "1234567890",
                    name = "John Doe",
                    admin = true,
                    exp = 1716239022,
                    secret_token = "dd36wlsNHbxJe1WsSptMee8LJ"
                },
                signature = "SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c"
            };

            string jwtTokenJson = JsonConvert.SerializeObject(jwtToken);
            Console.WriteLine($"JWT Token: {jwtTokenJson}");

            void EncryptData(string data)
            {
                string encryptedData = $"Encrypted data: {data} with key {SymmetricKey}";
                Console.WriteLine(encryptedData);
            }

            string PublicKeyToken = "b77abcd2222d"

            void DecodeJwtToken(string jwt)
            {
                Console.WriteLine($"Decoding JWT token: {jwt}");
            }

            string DigitalCertificate = @"-----BEGIN CERTIFICATE-----
            MIIDdTCCAl2gAwIBAgIJAN7uSs7S6LrMA0GCSqGSIb3DQEBCwUAMCoxKDAmBgNV
            BAMMH1Rlc3QgQ2VydGlmaWNhdGUgQXV0aG9yaXR5IC0gRzIwHhcNMjAwMTAxMDAw
            MDAwWhcNMzAwMTAxMDAwMDAwWjAqMSgwJgYDVQQDDB9UZXN0IENlcnRpZmljYXRl
            IEF1dGhvcml0eSAtIEcyMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA
            7nI1vP7v3A3f2q+HbQg5RaGHyxKEGrMjqK5jZp9S5LLVlG+mpgdC24Q3B5x5VN/k
            tqwx6GEyOp7O2q26ZQfHFJ1b9LykPaAUtIycDWcjYyT4L6KR5E4NXzPCOxR/EbFM
            ...
            -----END CERTIFICATE-----";
            Console.WriteLine($"Digital Certificate: \n{DigitalCertificate}");
        }

        FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://admin:jjssd38sdf@myFtpAddress.tld/myFile.txt");
        FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://admin@myFtpAddress.tld/myFile.txt");

        string SSHPasscode = "";
    }
}
