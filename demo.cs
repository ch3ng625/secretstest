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
MIIEowIBAAKCAQEAihc7OMlffnhPB8IcTf5Ve+ekZapqMetIvWU261yGBfQIH6WO
Imv7UeHTZDnwp4VIWS8hNZPVCiaWuRA5QZR7rko3SIuKktpzSqn3EzIJVdHqFNyU
pDU99zaUO+s474MeVpojhL8taFhcATiu15/In6lx6piTZVJaNLyKGJtinIQl1OKp
eLT7O0vcpZ274a2DPGYVGoaRUcTcB6nWHDaqImnoLEamIH5BteA2FTGmPtYm9m69
G+sIWMeuEH7Btqe4huvTEBqyJ1GyNaiNsZoASQ9M+eNIzu0ySLTmxY9evQQ4xZoU
7DqaRPgQmPOPB5TBDJ7Af4WAyFprZJuNRqPJowIDAQABAoIBAFjkCXhNkI4tzdnV
pzjBjq+a9mWHZKLLrWBVphutzIxKgWw1uyAHWJlmABjVf0em8WKPhxYhGpNVMdLh
UaoYdeFE3v9w6/wKaQrYDDcsD3xSCxfwwjJOH5xiYtuLWHQ9eCsRP+n00rsHnfof
TdV5gsDcZ3s3SjJ/55dpApBCfiD3r5n9FCMBpvQfZ4/L+fWPelxsnMJbAfvG2/cq
X/jX0WC0lDmu/8i58sKR7qh2U0t9ck/f+H6ckljx+vbXOaTkLi1OdplFeKEy4vNj
VTL6yGwgH3EeRDmmST+BoBq6+tYHQZr2uQ6zcygWzM9mMwgY35KKYGBEQLXl9HRN
PxGg4akCgYEA2F76rAa+n8kv5nP1emhAU5JC5TtKgyDtK8qIWjzli86//gO/m0KH
/ATjm+mFVOGMaC8sJZrtjZR/0b5RrqoNAxgXyO3Jm+HgWBD5C5/nweW2R6Z3v6e3
NoOEO25dBDREmeFRx4j47wD4UBcKTRV/1GBTLlA/MiYUd5XrCOrIRjUCgYEAo2Hp
0mWN2b62VtEoOtzerjrlHsD2LxNmhhUs8ica7YwawO9vs4RE7n5z1EiWmeSUomOn
lspUi+/IIyTvtBx5SmYRZVv1VgtP6lKSXWvW+/17uLUBP7EaHN4bY/Ii0+R4Fzkj
cA8X4lTZyjDuQuJoeUiHJKx1TLJ7xn0E58/Ha3cCgYAbgvAioXTpgj5J8iKbXtgX
CDjjRsexpqUhdU4jEy0ourAkzzs0tZ/uxnxeXbHrWgZtVNorKejcoK4j8CwYplyj
MRQNI1cIMA9Dg1z3QmzIdbnYoG0HfH7KOqy8lcrT9wVl/4VTdrIYSapJHLTdmkc3
rMvGzsNKUBc4IWLSLnAqpQKBgC6Dl7AAnYvaUcsRrORlMThlKAnDYdMxMMUHjk46
d94dPxiikiiHhaBoe816BPY3L2G0AWhangtg7pei0mNyn81glZ9HuOcQPWY2r9jM
9N204t5JGdvqLcb+LModi3DL4Kyr5bznbyNOiNqZZ5u/HYM59M+qEZMOVVLDEPx2
GQ4tAoGBAL+JPTzF7+BJ7Ah9Zd6OWPK3Rc9yfdgSFK/nBMHN1/HuuvpQPUeRHfw9
nWXnkzAlkcM5PwNG41yjmYQ1RwZrr+lPdt6nBmlKlKcvE9/vx6PbeCga4ekOyqHO
vHWsMLBxwRLZVEyKDw/pPqtYbRyuQFjxTL0ZKq2/8T1r64rKscUc
-----END RSA PRIVATE KEY-----
"
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
