namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Iran
    /// </summary>
    public class IranInfo : ICountryInfo
    {
        public string CommonName => "Iran";
        public string OfficialName => "Islamic Republic of Iran";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "إيران"),
            new Translation(LanguageCode.AZ, "İran"),
            new Translation(LanguageCode.BE, "Іран"),
            new Translation(LanguageCode.BG, "Иран"),
            new Translation(LanguageCode.BS, "Iran"),
            new Translation(LanguageCode.CA, "Iran"),
            new Translation(LanguageCode.CS, "Írán"),
            new Translation(LanguageCode.DA, "Iran"),
            new Translation(LanguageCode.DE, "Iran"),
            new Translation(LanguageCode.EL, "Ισλαμική Δημοκρατία του Ιράν"),
            new Translation(LanguageCode.EN, "Iran, Islamic Republic of"),
            new Translation(LanguageCode.ES, "Irán (República Islámica de)"),
            new Translation(LanguageCode.ET, "Iraan"),
            new Translation(LanguageCode.FA, "ایران"),
            new Translation(LanguageCode.FI, "Iran"),
            new Translation(LanguageCode.FR, "Iran"),
            new Translation(LanguageCode.HE, "איראן"),
            new Translation(LanguageCode.HR, "Iran"),
            new Translation(LanguageCode.HU, "Irán"),
            new Translation(LanguageCode.HY, "Իրան"),
            new Translation(LanguageCode.ID, "Iran"),
            new Translation(LanguageCode.IT, "Iran"),
            new Translation(LanguageCode.JA, "イラン・イスラム共和国"),
            new Translation(LanguageCode.KA, "ირანი"),
            new Translation(LanguageCode.KK, "Иран"),
            new Translation(LanguageCode.KO, "이란, 이슬람 공화국"),
            new Translation(LanguageCode.KY, "Иран"),
            new Translation(LanguageCode.LT, "Iranas"),
            new Translation(LanguageCode.LV, "Irāna"),
            new Translation(LanguageCode.MK, "Иран"),
            new Translation(LanguageCode.MN, "Иран"),
            new Translation(LanguageCode.NB, "Iran"),
            new Translation(LanguageCode.NL, "Iran"),
            new Translation(LanguageCode.NN, "Iran"),
            new Translation(LanguageCode.PL, "Iran"),
            new Translation(LanguageCode.PT, "Irã"),
            new Translation(LanguageCode.RO, "Iran"),
            new Translation(LanguageCode.RU, "Иран"),
            new Translation(LanguageCode.SK, "Irán"),
            new Translation(LanguageCode.SL, "Iran"),
            new Translation(LanguageCode.SR, "Иран"),
            new Translation(LanguageCode.SV, "Iran"),
            new Translation(LanguageCode.TR, "İran"),
            new Translation(LanguageCode.UK, "Іран"),
            new Translation(LanguageCode.UZ, "Eron"),
            new Translation(LanguageCode.ZH, "伊朗"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.IR;
        public Alpha3Code Alpha3Code => Alpha3Code.IRN;
        public int NumericCode => 364;
        public string[] TLD => new [] { ".ir", "ایران." };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.AM,
            Alpha2Code.AZ,
            Alpha2Code.IQ,
            Alpha2Code.PK,
            Alpha2Code.TR,
            Alpha2Code.TM,
        };

        public string[] Currencies => new [] { "IRR" };
        public string[] CallingCodes => new [] { "98" };
    }
}
