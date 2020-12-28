using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Oman
    /// </summary>
    public class OmanInfo : ICountryInfo
    {
        public string CommonName => "Oman";
        public string OfficialName => "Sultanate of Oman";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "عمان"),
            new Translation(LanguageCode.AZ, "Oman"),
            new Translation(LanguageCode.BE, "Аман"),
            new Translation(LanguageCode.BG, "Оман"),
            new Translation(LanguageCode.BS, "Oman"),
            new Translation(LanguageCode.CA, "Oman"),
            new Translation(LanguageCode.CS, "Omán"),
            new Translation(LanguageCode.DA, "Oman"),
            new Translation(LanguageCode.DE, "Oman"),
            new Translation(LanguageCode.EL, "Ομάν"),
            new Translation(LanguageCode.EN, "Oman"),
            new Translation(LanguageCode.ES, "Omán"),
            new Translation(LanguageCode.ET, "Omaan"),
            new Translation(LanguageCode.FA, "عمان"),
            new Translation(LanguageCode.FI, "Oman"),
            new Translation(LanguageCode.FR, "Oman"),
            new Translation(LanguageCode.HE, "עומאן"),
            new Translation(LanguageCode.HR, "Oman"),
            new Translation(LanguageCode.HU, "Omán"),
            new Translation(LanguageCode.HY, "Օման"),
            new Translation(LanguageCode.ID, "Oman"),
            new Translation(LanguageCode.IT, "Oman"),
            new Translation(LanguageCode.JA, "オマーン"),
            new Translation(LanguageCode.KA, "ომანი"),
            new Translation(LanguageCode.KK, "Оман"),
            new Translation(LanguageCode.KO, "오만"),
            new Translation(LanguageCode.KY, "Оман"),
            new Translation(LanguageCode.LT, "Omanas"),
            new Translation(LanguageCode.LV, "Omāna"),
            new Translation(LanguageCode.MK, "Оман"),
            new Translation(LanguageCode.MN, "Оман"),
            new Translation(LanguageCode.NB, "Oman"),
            new Translation(LanguageCode.NL, "Oman"),
            new Translation(LanguageCode.NN, "Oman"),
            new Translation(LanguageCode.PL, "Oman"),
            new Translation(LanguageCode.PT, "Omã"),
            new Translation(LanguageCode.RO, "Oman"),
            new Translation(LanguageCode.RU, "Оман"),
            new Translation(LanguageCode.SK, "Omán"),
            new Translation(LanguageCode.SL, "Oman"),
            new Translation(LanguageCode.SR, "Оман"),
            new Translation(LanguageCode.SV, "Oman"),
            new Translation(LanguageCode.TR, "Umman"),
            new Translation(LanguageCode.UK, "Оман"),
            new Translation(LanguageCode.UZ, "Ummon"),
            new Translation(LanguageCode.ZH, "阿曼"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.OM;
        public Alpha3Code Alpha3Code => Alpha3Code.OMN;
        public int NumericCode => 512;
        public string[] TLD => new [] { ".om" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.SA,
            Alpha2Code.AE,
            Alpha2Code.YE,
        };

        public ICurrency[] Currencies => new [] { new OmrCurrency() };
        public string[] CallingCodes => new [] { "968" };
    }
}
