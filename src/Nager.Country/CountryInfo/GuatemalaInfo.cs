namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Guatemala
    /// </summary>
    public class GuatemalaInfo : ICountryInfo
    {
        public string CommonName => "Guatemala";
        public string OfficialName => "Republic of Guatemala";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "غواتيمالا"),
            new Translation(LanguageCode.AZ, "Qvatemala"),
            new Translation(LanguageCode.BE, "Гватэмала"),
            new Translation(LanguageCode.BG, "Гватемала"),
            new Translation(LanguageCode.BS, "Gvatemala"),
            new Translation(LanguageCode.CA, "Guatemala"),
            new Translation(LanguageCode.CS, "Guatemala"),
            new Translation(LanguageCode.DA, "Guatemala"),
            new Translation(LanguageCode.DE, "Guatemala"),
            new Translation(LanguageCode.EL, "Γουατεμάλα"),
            new Translation(LanguageCode.EN, "Guatemala"),
            new Translation(LanguageCode.ES, "Guatemala"),
            new Translation(LanguageCode.ET, "Guatemala"),
            new Translation(LanguageCode.FA, "گواتمالا"),
            new Translation(LanguageCode.FI, "Guatemala"),
            new Translation(LanguageCode.FR, "Guatemala"),
            new Translation(LanguageCode.HE, "גואטמלה"),
            new Translation(LanguageCode.HR, "Gvatemala"),
            new Translation(LanguageCode.HU, "Guatemala"),
            new Translation(LanguageCode.HY, "Գվատեմալա"),
            new Translation(LanguageCode.ID, "Guatamala"),
            new Translation(LanguageCode.IT, "Guatemala"),
            new Translation(LanguageCode.JA, "グアテマラ"),
            new Translation(LanguageCode.KA, "გვატემალა"),
            new Translation(LanguageCode.KK, "Гватемала"),
            new Translation(LanguageCode.KO, "과테말라"),
            new Translation(LanguageCode.KY, "Гватемала"),
            new Translation(LanguageCode.LT, "Gvatemala"),
            new Translation(LanguageCode.LV, "Gvatemala"),
            new Translation(LanguageCode.MK, "Гватемала"),
            new Translation(LanguageCode.MN, "Гватемал"),
            new Translation(LanguageCode.NB, "Guatemala"),
            new Translation(LanguageCode.NL, "Guatemala"),
            new Translation(LanguageCode.NN, "Guatemala"),
            new Translation(LanguageCode.PL, "Gwatemala"),
            new Translation(LanguageCode.PT, "Guatemala"),
            new Translation(LanguageCode.RO, "Guatemala"),
            new Translation(LanguageCode.RU, "Гватемала"),
            new Translation(LanguageCode.SK, "Guatemala"),
            new Translation(LanguageCode.SL, "Gvatemala"),
            new Translation(LanguageCode.SR, "Гватемала"),
            new Translation(LanguageCode.SV, "Guatemala"),
            new Translation(LanguageCode.TR, "Guatemala"),
            new Translation(LanguageCode.UK, "Гватемала"),
            new Translation(LanguageCode.UZ, "Gvatemala"),
            new Translation(LanguageCode.ZH, "危地马拉"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GT;
        public Alpha3Code Alpha3Code => Alpha3Code.GTM;
        public int NumericCode => 320;
        public string[] TLD => new [] { ".gt" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BZ,
            Alpha2Code.SV,
            Alpha2Code.HN,
            Alpha2Code.MX,
        };

        public string[] Currencies => new [] { "GTQ" };
        public string[] CallingCodes => new [] { "502" };
    }
}
