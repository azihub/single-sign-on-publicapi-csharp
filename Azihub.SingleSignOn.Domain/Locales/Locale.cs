using System;
using System.Collections.Generic;

namespace Azihub.SingleSignOn.Domain.Locales
{
    /// <summary>
    /// Type of supported Locale
    /// </summary>
    public class Locale : IEquatable<Locale>
    {
        private Locale(string code)
        {
            Code = code;
        }

        public string Code { get; }

        public override string ToString()
        {
            return Code;
        }

        #region Dictionary

        private static Dictionary<string, Locale> Codes { get; } = new Dictionary<string, Locale>()
        {
            { Locales.EN_US, new Locale(Locales.EN_US) },
            { Locales.FA_IR, new Locale(Locales.FA_IR) }
        };

        #endregion

        /// <summary>
        /// Create Locale type that is supported.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Locale FromString(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new LocalCodeException();
            }

            // Try get code local
            if (Codes.TryGetValue(code, out Locale local))
                return local;

            throw new LocalCodeException();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Locale);
        }

        public bool Equals(Locale other)
        {
            return other != null &&
                   Code == other.Code;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Code);
        }

        public static Locale FarsiIran => new Locale(Locales.FA_IR);
        public static Locale EnglishUS => new Locale(Locales.EN_US);

        public static bool operator ==(Locale left, Locale right)
        {
            return EqualityComparer<Locale>.Default.Equals(left, right);
        }

        public static bool operator !=(Locale left, Locale right)
        {
            return !(left == right);
        }
    }


}