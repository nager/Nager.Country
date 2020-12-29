using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Yemen
    /// </summary>
    public class YemenInfo : ICountryInfo
    {
        public string CommonName => "Yemen";
        public string OfficialName => "Republic of Yemen";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "اليمن"),
            new Translation(LanguageCode.AZ, "Yəmən"),
            new Translation(LanguageCode.BE, "Емен"),
            new Translation(LanguageCode.BG, "Йемен"),
            new Translation(LanguageCode.BS, "Jemen"),
            new Translation(LanguageCode.CA, "Iemen"),
            new Translation(LanguageCode.CS, "Jemen"),
            new Translation(LanguageCode.DA, "Yemen"),
            new Translation(LanguageCode.DE, "Jemen"),
            new Translation(LanguageCode.EL, "Υεμένη"),
            new Translation(LanguageCode.EN, "Yemen"),
            new Translation(LanguageCode.ES, "Yemen"),
            new Translation(LanguageCode.ET, "Jeemen"),
            new Translation(LanguageCode.FA, "یمن"),
            new Translation(LanguageCode.FI, "Jemen"),
            new Translation(LanguageCode.FR, "Yémen"),
            new Translation(LanguageCode.HE, "תימן"),
            new Translation(LanguageCode.HR, "Jemen"),
            new Translation(LanguageCode.HU, "Jemen"),
            new Translation(LanguageCode.HY, "Եմեն"),
            new Translation(LanguageCode.ID, "Yaman"),
            new Translation(LanguageCode.IT, "Yemen"),
            new Translation(LanguageCode.JA, "イエメン"),
            new Translation(LanguageCode.KA, "იემენი"),
            new Translation(LanguageCode.KK, "Йемен"),
            new Translation(LanguageCode.KO, "예멘 아랍 공화국"),
            new Translation(LanguageCode.KY, "Йемен"),
            new Translation(LanguageCode.LT, "Jemenas"),
            new Translation(LanguageCode.LV, "Jemena"),
            new Translation(LanguageCode.MK, "Јемен"),
            new Translation(LanguageCode.MN, "Йемен"),
            new Translation(LanguageCode.NB, "Jemen"),
            new Translation(LanguageCode.NL, "Jemen"),
            new Translation(LanguageCode.NN, "Jemen"),
            new Translation(LanguageCode.PL, "Jemen"),
            new Translation(LanguageCode.PT, "Iêmen"),
            new Translation(LanguageCode.RO, "Yemen"),
            new Translation(LanguageCode.RU, "Йемен"),
            new Translation(LanguageCode.SK, "Jemen"),
            new Translation(LanguageCode.SL, "Jemen"),
            new Translation(LanguageCode.SR, "Јемен"),
            new Translation(LanguageCode.SV, "Jemen"),
            new Translation(LanguageCode.TR, "Yemen"),
            new Translation(LanguageCode.UK, "Ємен"),
            new Translation(LanguageCode.UZ, "Yaman"),
            new Translation(LanguageCode.ZH, "叶门"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.YE;
        public Alpha3Code Alpha3Code => Alpha3Code.YEM;
        public int NumericCode => 887;
        public string[] TLD => new [] { ".ye" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.OM,
            Alpha2Code.SA,
        };

        public ICurrency[] Currencies => new [] { new YerCurrency() };
        public string[] CallingCodes => new [] { "967" };
    }
}
