using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// San Marino
    /// </summary>
    public class SanMarinoInfo : ICountryInfo
    {
        public string CommonName => "San Marino";
        public string OfficialName => "Most Serene Republic of San Marino";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سان مارينو"),
            new Translation(LanguageCode.AZ, "San-Marino"),
            new Translation(LanguageCode.BE, "Сан-Марына"),
            new Translation(LanguageCode.BG, "Сан Марино"),
            new Translation(LanguageCode.BS, "San Marino"),
            new Translation(LanguageCode.CA, "San Marino"),
            new Translation(LanguageCode.CS, "San Marino"),
            new Translation(LanguageCode.DA, "San Marino"),
            new Translation(LanguageCode.DE, "San Marino"),
            new Translation(LanguageCode.EL, "Άγιος Μαρίνος"),
            new Translation(LanguageCode.EN, "San Marino"),
            new Translation(LanguageCode.ES, "San Marino"),
            new Translation(LanguageCode.ET, "San Marino"),
            new Translation(LanguageCode.FA, "سان‌مارینو"),
            new Translation(LanguageCode.FI, "San Marino"),
            new Translation(LanguageCode.FR, "Saint-Marin"),
            new Translation(LanguageCode.HE, "סן מרינו"),
            new Translation(LanguageCode.HR, "San Marino"),
            new Translation(LanguageCode.HU, "San Marino"),
            new Translation(LanguageCode.HY, "Սան Մարինո"),
            new Translation(LanguageCode.ID, "San Marino"),
            new Translation(LanguageCode.IT, "San Marino"),
            new Translation(LanguageCode.JA, "サンマリノ"),
            new Translation(LanguageCode.KA, "სან-მარინო"),
            new Translation(LanguageCode.KK, "Сан-Марино"),
            new Translation(LanguageCode.KO, "산 마리노"),
            new Translation(LanguageCode.KY, "Сан Марино"),
            new Translation(LanguageCode.LT, "San Marinas"),
            new Translation(LanguageCode.LV, "Sanmarīno"),
            new Translation(LanguageCode.MK, "Сан Марино"),
            new Translation(LanguageCode.MN, "Сан-Марино"),
            new Translation(LanguageCode.NB, "San Marino"),
            new Translation(LanguageCode.NL, "San Marino"),
            new Translation(LanguageCode.NN, "San Marino"),
            new Translation(LanguageCode.PL, "San Marino"),
            new Translation(LanguageCode.PT, "San Marino"),
            new Translation(LanguageCode.RO, "San Marino"),
            new Translation(LanguageCode.RU, "Сан-Марино"),
            new Translation(LanguageCode.SK, "San Maríno"),
            new Translation(LanguageCode.SL, "San Marino"),
            new Translation(LanguageCode.SR, "Сан Марино"),
            new Translation(LanguageCode.SV, "San Marino"),
            new Translation(LanguageCode.TR, "San Marino"),
            new Translation(LanguageCode.UK, "Сан-Маріно"),
            new Translation(LanguageCode.UZ, "San-Marino"),
            new Translation(LanguageCode.ZH, "圣马力诺"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SM;
        public Alpha3Code Alpha3Code => Alpha3Code.SMR;
        public int NumericCode => 674;
        public string[] TLD => new [] { ".sm" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.IT,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "378" };
    }
}
