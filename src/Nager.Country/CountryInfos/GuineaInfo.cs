using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guinea
    /// </summary>
    public class GuineaInfo : ICountryInfo
    {
        public string CommonName => "Guinea";
        public string OfficialName => "Republic of Guinea";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "غينيا"),
            new Translation(LanguageCode.AZ, "Qvineya"),
            new Translation(LanguageCode.BE, "Гвінея"),
            new Translation(LanguageCode.BG, "Гвинея"),
            new Translation(LanguageCode.BS, "Gvineja"),
            new Translation(LanguageCode.CA, "República de Guinea"),
            new Translation(LanguageCode.CS, "Guinea"),
            new Translation(LanguageCode.DA, "Guinea"),
            new Translation(LanguageCode.DE, "Guinea"),
            new Translation(LanguageCode.EL, "Γουινέα"),
            new Translation(LanguageCode.EN, "Guinea"),
            new Translation(LanguageCode.ES, "Guinea"),
            new Translation(LanguageCode.ET, "Guinea"),
            new Translation(LanguageCode.FA, "گینه"),
            new Translation(LanguageCode.FI, "Guinea"),
            new Translation(LanguageCode.FR, "Guinée"),
            new Translation(LanguageCode.HE, "גינאה"),
            new Translation(LanguageCode.HR, "Gvineja"),
            new Translation(LanguageCode.HU, "Guinea"),
            new Translation(LanguageCode.HY, "Գվինեա"),
            new Translation(LanguageCode.ID, "Guinea"),
            new Translation(LanguageCode.IT, "Guinea"),
            new Translation(LanguageCode.JA, "ギニア"),
            new Translation(LanguageCode.KA, "გვინეა"),
            new Translation(LanguageCode.KK, "Гвинея"),
            new Translation(LanguageCode.KO, "기니"),
            new Translation(LanguageCode.KY, "Гвинея"),
            new Translation(LanguageCode.LT, "Gvinėja"),
            new Translation(LanguageCode.LV, "Gvineja"),
            new Translation(LanguageCode.MK, "Гвинеја"),
            new Translation(LanguageCode.MN, "Гвиней"),
            new Translation(LanguageCode.NB, "Guinea"),
            new Translation(LanguageCode.NL, "Guinea"),
            new Translation(LanguageCode.NN, "Guinea"),
            new Translation(LanguageCode.PL, "Gwinea"),
            new Translation(LanguageCode.PT, "Guiné"),
            new Translation(LanguageCode.RO, "Guineea"),
            new Translation(LanguageCode.RU, "Гвинея"),
            new Translation(LanguageCode.SK, "Guinea"),
            new Translation(LanguageCode.SL, "Gvineja"),
            new Translation(LanguageCode.SR, "Гвинеја"),
            new Translation(LanguageCode.SV, "Guinea"),
            new Translation(LanguageCode.TR, "Gine"),
            new Translation(LanguageCode.UK, "Гвінея"),
            new Translation(LanguageCode.UZ, "Gvineya"),
            new Translation(LanguageCode.ZH, "几内亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GN;
        public Alpha3Code Alpha3Code => Alpha3Code.GIN;
        public int NumericCode => 324;
        public string[] TLD => new [] { ".gn" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CI,
            Alpha2Code.GW,
            Alpha2Code.LR,
            Alpha2Code.ML,
            Alpha2Code.SN,
            Alpha2Code.SL,
        };

        public ICurrency[] Currencies => new [] { "GNF" };
        public string[] CallingCodes => new [] { "224" };
    }
}
