namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Zimbabwe
    /// </summary>
    public class ZimbabweInfo : ICountryInfo
    {
        public string CommonName => "Zimbabwe";
        public string OfficialName => "Republic of Zimbabwe";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "زيمبابوي"),
            new Translation(LanguageCode.AZ, "Zimbabve"),
            new Translation(LanguageCode.BE, "Зімбабвэ"),
            new Translation(LanguageCode.BG, "Зимбабве"),
            new Translation(LanguageCode.BS, "Zimbabve"),
            new Translation(LanguageCode.CA, "Zimbabwe"),
            new Translation(LanguageCode.CS, "Zimbabwe"),
            new Translation(LanguageCode.DA, "Zimbabwe"),
            new Translation(LanguageCode.DE, "Simbabwe"),
            new Translation(LanguageCode.EL, "Ζιμπάμπουε"),
            new Translation(LanguageCode.EN, "Zimbabwe"),
            new Translation(LanguageCode.ES, "Zimbabwe"),
            new Translation(LanguageCode.ET, "Zimbabwe"),
            new Translation(LanguageCode.FA, "زیمبابوه"),
            new Translation(LanguageCode.FI, "Zimbabwe"),
            new Translation(LanguageCode.FR, "Zimbabwe"),
            new Translation(LanguageCode.HE, "זימבבואה"),
            new Translation(LanguageCode.HR, "Zimbabve"),
            new Translation(LanguageCode.HU, "Zimbabwe"),
            new Translation(LanguageCode.HY, "Զիմբաբվե"),
            new Translation(LanguageCode.ID, "Zimbabwe"),
            new Translation(LanguageCode.IT, "Zimbabwe"),
            new Translation(LanguageCode.JA, "ジンバブエ"),
            new Translation(LanguageCode.KA, "ზიმბაბვე"),
            new Translation(LanguageCode.KK, "Зимбабве"),
            new Translation(LanguageCode.KO, "짐바브웨"),
            new Translation(LanguageCode.KY, "Зимбабве"),
            new Translation(LanguageCode.LT, "Zimbabvė"),
            new Translation(LanguageCode.LV, "Zimbabve"),
            new Translation(LanguageCode.MK, "Зимбабве"),
            new Translation(LanguageCode.MN, "Зимбабве"),
            new Translation(LanguageCode.NB, "Zimbabwe"),
            new Translation(LanguageCode.NL, "Zimbabwe"),
            new Translation(LanguageCode.NN, "Zimbabwe"),
            new Translation(LanguageCode.PL, "Zimbabwe"),
            new Translation(LanguageCode.PT, "Zimbábue"),
            new Translation(LanguageCode.RO, "Zimbabwe"),
            new Translation(LanguageCode.RU, "Зимбабве"),
            new Translation(LanguageCode.SK, "Zimbabwe"),
            new Translation(LanguageCode.SL, "Zimbabve"),
            new Translation(LanguageCode.SR, "Зимбабве"),
            new Translation(LanguageCode.SV, "Zimbabwe"),
            new Translation(LanguageCode.TR, "Zimbabve"),
            new Translation(LanguageCode.UK, "Зімбабве"),
            new Translation(LanguageCode.UZ, "Zimbabve"),
            new Translation(LanguageCode.ZH, "辛巴威"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.ZW;
        public Alpha3Code Alpha3Code => Alpha3Code.ZWE;
        public int NumericCode => 716;
        public string[] TLD => new [] { ".zw" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BW,
            Alpha2Code.MZ,
            Alpha2Code.ZA,
            Alpha2Code.ZM,
        };

        public string[] Currencies => new [] { "ZWL" };
        public string[] CallingCodes => new [] { "263" };
    }
}
