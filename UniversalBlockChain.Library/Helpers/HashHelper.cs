using System;
using System.Collections.Generic;
using System.Text;

namespace Chain.Library.Helpers
{
    internal static class HashHelper
    {
        public static string GetHash(byte[] array)
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();

            var hash = sha1.ComputeHash(array);

            return Convert.ToBase64String(hash);
        }
    }
}
