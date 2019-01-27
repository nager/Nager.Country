namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Samoa
    /// </summary>
    public class SamoaInfo : ICountryInfo
    {
        public string CommonName => "Samoa";
        public string OfficialName => "Independent State of Samoa";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ساموا"),
            new Translation(LanguageCode.AZ, "Samoa"),
            new Translation(LanguageCode.BE, "Самоа"),
            new Translation(LanguageCode.BG, "Самоа"),
            new Translation(LanguageCode.BS, "Samoa"),
            new Translation(LanguageCode.CA, "Samoa"),
            new Translation(LanguageCode.CS, "Samoa"),
            new Translation(LanguageCode.DA, "Samoa"),
            new Translation(LanguageCode.DE, "Samoa"),
            new Translation(LanguageCode.EL, "Σαμόα"),
            new Translation(LanguageCode.EN, "Samoa"),
            new Translation(LanguageCode.ES, "Samoa"),
            new Translation(LanguageCode.ET, "Samoa"),
            new Translation(LanguageCode.FA, "ساموآ"),
            new Translation(LanguageCode.FI, "Samoa"),
            new Translation(LanguageCode.FR, "Samoa"),
            new Translation(LanguageCode.HE, "סמואה"),
            new Translation(LanguageCode.HR, "Samoa"),
            new Translation(LanguageCode.HU, "Szamoa"),
            new Translation(LanguageCode.HY, "Սամոա"),
            new Translation(LanguageCode.ID, "Samoa"),
            new Translation(LanguageCode.IT, "Samoa"),
            new Translation(LanguageCode.JA, "サモア"),
            new Translation(LanguageCode.KA, "სამოა"),
            new Translation(LanguageCode.KK, "Самоа"),
            new Translation(LanguageCode.KO, "사모아"),
            new Translation(LanguageCode.KY, "Самоа"),
            new Translation(LanguageCode.LT, "Samoa"),
            new Translation(LanguageCode.LV, "Samoa"),
            new Translation(LanguageCode.MK, "Самоа"),
            new Translation(LanguageCode.MN, "Самоа"),
            new Translation(LanguageCode.NB, "Samoa"),
            new Translation(LanguageCode.NL, "Samoa"),
            new Translation(LanguageCode.NN, "Samoa"),
            new Translation(LanguageCode.PL, "Samoa"),
            new Translation(LanguageCode.PT, "Samoa"),
            new Translation(LanguageCode.RO, "Samoa"),
            new Translation(LanguageCode.RU, "Самоа"),
            new Translation(LanguageCode.SK, "Samoa"),
            new Translation(LanguageCode.SL, "Samoa"),
            new Translation(LanguageCode.SR, "Самоа"),
            new Translation(LanguageCode.SV, "Samoa"),
            new Translation(LanguageCode.TR, "Samoa"),
            new Translation(LanguageCode.UK, "Самоа"),
            new Translation(LanguageCode.UZ, "Samoa"),
            new Translation(LanguageCode.ZH, "萨摩亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.WS;
        public Alpha3Code Alpha3Code => Alpha3Code.WSM;
        public int NumericCode => 882;
        public string[] TLD => new [] { ".ws" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "WST" };
        public string[] CallingCodes => new [] { "685" };
    }
}
