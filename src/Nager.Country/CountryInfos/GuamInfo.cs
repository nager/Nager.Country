using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guam
    /// </summary>
    public class GuamInfo : ICountryInfo
    {
        public string CommonName => "Guam";
        public string OfficialName => "Guam";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "غوام"),
            new Translation(LanguageCode.AZ, "Quam"),
            new Translation(LanguageCode.BE, "Гуам"),
            new Translation(LanguageCode.BG, "Гуам"),
            new Translation(LanguageCode.BS, "Guam"),
            new Translation(LanguageCode.CA, "Guam"),
            new Translation(LanguageCode.CS, "Guam"),
            new Translation(LanguageCode.DA, "Guam"),
            new Translation(LanguageCode.DE, "Guam"),
            new Translation(LanguageCode.EL, "Γκουάμ"),
            new Translation(LanguageCode.EN, "Guam"),
            new Translation(LanguageCode.ES, "Guam"),
            new Translation(LanguageCode.ET, "Guam"),
            new Translation(LanguageCode.FA, "گوام"),
            new Translation(LanguageCode.FI, "Guam"),
            new Translation(LanguageCode.FR, "Guam"),
            new Translation(LanguageCode.HE, "גואם"),
            new Translation(LanguageCode.HR, "Guam"),
            new Translation(LanguageCode.HU, "Guam"),
            new Translation(LanguageCode.HY, "Գուամ"),
            new Translation(LanguageCode.ID, "Guam"),
            new Translation(LanguageCode.IT, "Guam"),
            new Translation(LanguageCode.JA, "グアム"),
            new Translation(LanguageCode.KA, "გუამი"),
            new Translation(LanguageCode.KK, "Гуам"),
            new Translation(LanguageCode.KO, "괌"),
            new Translation(LanguageCode.KY, "Гуам"),
            new Translation(LanguageCode.LT, "Guamas"),
            new Translation(LanguageCode.LV, "Guama"),
            new Translation(LanguageCode.MK, "Гуам"),
            new Translation(LanguageCode.MN, "Гуам"),
            new Translation(LanguageCode.NB, "Guam"),
            new Translation(LanguageCode.NL, "Guam"),
            new Translation(LanguageCode.NN, "Guam"),
            new Translation(LanguageCode.PL, "Guam"),
            new Translation(LanguageCode.PT, "Guam"),
            new Translation(LanguageCode.RO, "Guam"),
            new Translation(LanguageCode.RU, "Гуам"),
            new Translation(LanguageCode.SK, "Guam"),
            new Translation(LanguageCode.SL, "Guam"),
            new Translation(LanguageCode.SR, "Гуам"),
            new Translation(LanguageCode.SV, "Guam"),
            new Translation(LanguageCode.TR, "Guam"),
            new Translation(LanguageCode.UK, "Гуам"),
            new Translation(LanguageCode.UZ, "Guam"),
            new Translation(LanguageCode.ZH, "关岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GU;
        public Alpha3Code Alpha3Code => Alpha3Code.GUM;
        public int NumericCode => 316;
        public string[] TLD => new [] { ".gu" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Micronesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1671" };
    }
}
