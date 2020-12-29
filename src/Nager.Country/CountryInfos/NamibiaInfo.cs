using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Namibia
    /// </summary>
    public class NamibiaInfo : ICountryInfo
    {
        public string CommonName => "Namibia";
        public string OfficialName => "Republic of Namibia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ناميبيا"),
            new Translation(LanguageCode.AZ, "Namibiya"),
            new Translation(LanguageCode.BE, "Намібія"),
            new Translation(LanguageCode.BG, "Намибия"),
            new Translation(LanguageCode.BS, "Namibija"),
            new Translation(LanguageCode.CA, "Namíbia"),
            new Translation(LanguageCode.CS, "Namibie"),
            new Translation(LanguageCode.DA, "Namibia"),
            new Translation(LanguageCode.DE, "Namibia"),
            new Translation(LanguageCode.EL, "Ναμίμπια"),
            new Translation(LanguageCode.EN, "Namibia"),
            new Translation(LanguageCode.ES, "Namibia"),
            new Translation(LanguageCode.ET, "Namiibia"),
            new Translation(LanguageCode.FA, "نامیبیا"),
            new Translation(LanguageCode.FI, "Namibia"),
            new Translation(LanguageCode.FR, "Namibie"),
            new Translation(LanguageCode.HE, "נמיביה"),
            new Translation(LanguageCode.HR, "Namibija"),
            new Translation(LanguageCode.HU, "Namíbia"),
            new Translation(LanguageCode.HY, "Նամիբիա"),
            new Translation(LanguageCode.ID, "Namibia"),
            new Translation(LanguageCode.IT, "Namibia"),
            new Translation(LanguageCode.JA, "ナミビア"),
            new Translation(LanguageCode.KA, "ნამიბია"),
            new Translation(LanguageCode.KK, "Намибия"),
            new Translation(LanguageCode.KO, "나미비아"),
            new Translation(LanguageCode.KY, "Намибия"),
            new Translation(LanguageCode.LT, "Namibija"),
            new Translation(LanguageCode.LV, "Namībija"),
            new Translation(LanguageCode.MK, "Намибија"),
            new Translation(LanguageCode.MN, "Намиби"),
            new Translation(LanguageCode.NB, "Namibia"),
            new Translation(LanguageCode.NL, "Namibië"),
            new Translation(LanguageCode.NN, "Namibia"),
            new Translation(LanguageCode.PL, "Namibia"),
            new Translation(LanguageCode.PT, "Namíbia"),
            new Translation(LanguageCode.RO, "Namibia"),
            new Translation(LanguageCode.RU, "Намибия"),
            new Translation(LanguageCode.SK, "Namíbia"),
            new Translation(LanguageCode.SL, "Namibija"),
            new Translation(LanguageCode.SR, "Намибија"),
            new Translation(LanguageCode.SV, "Namibia"),
            new Translation(LanguageCode.TR, "Namibya"),
            new Translation(LanguageCode.UK, "Намібія"),
            new Translation(LanguageCode.UZ, "Namibiya"),
            new Translation(LanguageCode.ZH, "纳米比亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.NA;
        public Alpha3Code Alpha3Code => Alpha3Code.NAM;
        public int NumericCode => 516;
        public string[] TLD => new [] { ".na" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AO,
            Alpha2Code.BW,
            Alpha2Code.ZA,
            Alpha2Code.ZM,
        };

        public ICurrency[] Currencies => new ICurrency[] { new NadCurrency(), new ZarCurrency() };
        public string[] CallingCodes => new [] { "264" };
    }
}
