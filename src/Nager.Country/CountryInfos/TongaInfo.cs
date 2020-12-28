using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tonga
    /// </summary>
    public class TongaInfo : ICountryInfo
    {
        public string CommonName => "Tonga";
        public string OfficialName => "Kingdom of Tonga";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "تونغا"),
            new Translation(LanguageCode.AZ, "Tonqa"),
            new Translation(LanguageCode.BE, "Тонга"),
            new Translation(LanguageCode.BG, "Тонга"),
            new Translation(LanguageCode.BS, "Tonga"),
            new Translation(LanguageCode.CA, "Tonga"),
            new Translation(LanguageCode.CS, "Tonga"),
            new Translation(LanguageCode.DA, "Tonga"),
            new Translation(LanguageCode.DE, "Tonga"),
            new Translation(LanguageCode.EL, "Τόνγκα"),
            new Translation(LanguageCode.EN, "Tonga"),
            new Translation(LanguageCode.ES, "Tonga"),
            new Translation(LanguageCode.ET, "Tonga"),
            new Translation(LanguageCode.FA, "تونگا"),
            new Translation(LanguageCode.FI, "Tonga"),
            new Translation(LanguageCode.FR, "Tonga"),
            new Translation(LanguageCode.HE, "טונגה"),
            new Translation(LanguageCode.HR, "Tonga"),
            new Translation(LanguageCode.HU, "Tonga"),
            new Translation(LanguageCode.HY, "Տոնգա"),
            new Translation(LanguageCode.ID, "Tonga"),
            new Translation(LanguageCode.IT, "Tonga"),
            new Translation(LanguageCode.JA, "トンガ"),
            new Translation(LanguageCode.KA, "ტონგა"),
            new Translation(LanguageCode.KK, "Тонга"),
            new Translation(LanguageCode.KO, "통가"),
            new Translation(LanguageCode.KY, "Тонга"),
            new Translation(LanguageCode.LT, "Tonga"),
            new Translation(LanguageCode.LV, "Tonga"),
            new Translation(LanguageCode.MK, "Тонга"),
            new Translation(LanguageCode.MN, "Тонга"),
            new Translation(LanguageCode.NB, "Tonga"),
            new Translation(LanguageCode.NL, "Tonga"),
            new Translation(LanguageCode.NN, "Tonga"),
            new Translation(LanguageCode.PL, "Tonga"),
            new Translation(LanguageCode.PT, "Tonga"),
            new Translation(LanguageCode.RO, "Tonga"),
            new Translation(LanguageCode.RU, "Тонга"),
            new Translation(LanguageCode.SK, "Tonga"),
            new Translation(LanguageCode.SL, "Tonga"),
            new Translation(LanguageCode.SR, "Тонга"),
            new Translation(LanguageCode.SV, "Tonga"),
            new Translation(LanguageCode.TR, "Tonga"),
            new Translation(LanguageCode.UK, "Тонга"),
            new Translation(LanguageCode.UZ, "Tonga"),
            new Translation(LanguageCode.ZH, "汤加"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TO;
        public Alpha3Code Alpha3Code => Alpha3Code.TON;
        public int NumericCode => 776;
        public string[] TLD => new [] { ".to" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { "TOP" };
        public string[] CallingCodes => new [] { "676" };
    }
}
