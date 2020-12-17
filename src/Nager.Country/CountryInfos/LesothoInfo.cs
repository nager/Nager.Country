namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Lesotho
    /// </summary>
    public class LesothoInfo : ICountryInfo
    {
        public string CommonName => "Lesotho";
        public string OfficialName => "Kingdom of Lesotho";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ليسوتو"),
            new Translation(LanguageCode.AZ, "Lesoto"),
            new Translation(LanguageCode.BE, "Лесота"),
            new Translation(LanguageCode.BG, "Лесото"),
            new Translation(LanguageCode.BS, "Lesoto"),
            new Translation(LanguageCode.CA, "Lesotho"),
            new Translation(LanguageCode.CS, "Lesotho"),
            new Translation(LanguageCode.DA, "Lesotho"),
            new Translation(LanguageCode.DE, "Lesotho"),
            new Translation(LanguageCode.EL, "Βασίλειο του Λεσότο"),
            new Translation(LanguageCode.EN, "Lesotho"),
            new Translation(LanguageCode.ES, "Lesotho"),
            new Translation(LanguageCode.ET, "Lesotho"),
            new Translation(LanguageCode.FA, "لسوتو"),
            new Translation(LanguageCode.FI, "Lesotho"),
            new Translation(LanguageCode.FR, "Lesotho"),
            new Translation(LanguageCode.HE, "לסוטו"),
            new Translation(LanguageCode.HR, "Lesoto"),
            new Translation(LanguageCode.HU, "Lesotho"),
            new Translation(LanguageCode.HY, "Լեսոտո"),
            new Translation(LanguageCode.ID, "Lesotho"),
            new Translation(LanguageCode.IT, "Lesotho"),
            new Translation(LanguageCode.JA, "レソト"),
            new Translation(LanguageCode.KA, "ლესოთო"),
            new Translation(LanguageCode.KK, "Лесото"),
            new Translation(LanguageCode.KO, "레소토"),
            new Translation(LanguageCode.KY, "Лесото"),
            new Translation(LanguageCode.LT, "Lesotas"),
            new Translation(LanguageCode.LV, "Lesoto"),
            new Translation(LanguageCode.MK, "Лесото"),
            new Translation(LanguageCode.MN, "Лесото"),
            new Translation(LanguageCode.NB, "Lesotho"),
            new Translation(LanguageCode.NL, "Lesotho"),
            new Translation(LanguageCode.NN, "Lesotho"),
            new Translation(LanguageCode.PL, "Lesotho"),
            new Translation(LanguageCode.PT, "Lesoto"),
            new Translation(LanguageCode.RO, "Lesotho"),
            new Translation(LanguageCode.RU, "Лесото"),
            new Translation(LanguageCode.SK, "Lesotho"),
            new Translation(LanguageCode.SL, "Lesoto"),
            new Translation(LanguageCode.SR, "Лесото"),
            new Translation(LanguageCode.SV, "Lesotho"),
            new Translation(LanguageCode.TR, "Lesoto"),
            new Translation(LanguageCode.UK, "Лесото"),
            new Translation(LanguageCode.UZ, "Lesoto"),
            new Translation(LanguageCode.ZH, "赖索托"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.LS;
        public Alpha3Code Alpha3Code => Alpha3Code.LSO;
        public int NumericCode => 426;
        public string[] TLD => new [] { ".ls" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.ZA,
        };

        public string[] Currencies => new [] { "LSL", "ZAR" };
        public string[] CallingCodes => new [] { "266" };
    }
}
