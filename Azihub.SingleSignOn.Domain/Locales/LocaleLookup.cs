using System.Collections.Generic;

namespace Azihub.SingleSignOn.Domain.Locales
{
    public static class LocaleLookUp
    {
        static LocaleLookUp()
        {
            Data = new Dictionary<Locale, Dictionary<string, string>>
            {
                { Locale.EnglishUS, LocaleEnUS.GetData() },
                { Locale.FarsiIran, LocaleFaIr.GetData() }
            };
        }

        public static IDictionary<Locale, Dictionary<string, string>> Data { get; set; }
    }
}
