namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mayotte
    /// </summary>
    public class MayotteInfo : ICountryInfo
    {
        public string CommonName => "Mayotte";
        public string OfficialName => "Department of Mayotte";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "مايوت"),
            new Translation(LanguageCode.AZ, "Mayot"),
            new Translation(LanguageCode.BE, "Маёта"),
            new Translation(LanguageCode.BG, "Майот"),
            new Translation(LanguageCode.BS, "Majote"),
            new Translation(LanguageCode.CA, "Mayotte"),
            new Translation(LanguageCode.CS, "Mayotte"),
            new Translation(LanguageCode.DA, "Mayotte"),
            new Translation(LanguageCode.DE, "Mayotte"),
            new Translation(LanguageCode.EL, "Μαγιότ"),
            new Translation(LanguageCode.EN, "Mayotte"),
            new Translation(LanguageCode.ES, "Mayotte"),
            new Translation(LanguageCode.ET, "Mayotte"),
            new Translation(LanguageCode.FA, "مایوت"),
            new Translation(LanguageCode.FI, "Mayotte"),
            new Translation(LanguageCode.FR, "Mayotte"),
            new Translation(LanguageCode.HE, "מאיוט"),
            new Translation(LanguageCode.HR, "Mayotte"),
            new Translation(LanguageCode.HU, "Mayotte"),
            new Translation(LanguageCode.HY, "Մայոտ"),
            new Translation(LanguageCode.ID, "Mayotte"),
            new Translation(LanguageCode.IT, "Mayotte"),
            new Translation(LanguageCode.JA, "マヨット"),
            new Translation(LanguageCode.KA, "მაიოტა"),
            new Translation(LanguageCode.KK, "Майотта"),
            new Translation(LanguageCode.KO, "마 요트"),
            new Translation(LanguageCode.KY, "Майотта"),
            new Translation(LanguageCode.LT, "Majotas"),
            new Translation(LanguageCode.LV, "Majota"),
            new Translation(LanguageCode.MK, "Мајот"),
            new Translation(LanguageCode.MN, "Майотте"),
            new Translation(LanguageCode.NB, "Mayotte"),
            new Translation(LanguageCode.NL, "Mayotte"),
            new Translation(LanguageCode.NN, "Mayotte"),
            new Translation(LanguageCode.PL, "Majotta"),
            new Translation(LanguageCode.PT, "Mayotte"),
            new Translation(LanguageCode.RO, "Mayotte"),
            new Translation(LanguageCode.RU, "Майотта"),
            new Translation(LanguageCode.SK, "Mayotte"),
            new Translation(LanguageCode.SL, "Mayotte"),
            new Translation(LanguageCode.SR, "Мајот"),
            new Translation(LanguageCode.SV, "Mayotte"),
            new Translation(LanguageCode.TR, "Mayotte"),
            new Translation(LanguageCode.UK, "Майотта"),
            new Translation(LanguageCode.UZ, "Mayotta"),
            new Translation(LanguageCode.ZH, "马约特"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.YT;
        public Alpha3Code Alpha3Code => Alpha3Code.MYT;
        public int NumericCode => 175;
        public string[] TLD => new [] { ".yt" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "262" };
    }
}
