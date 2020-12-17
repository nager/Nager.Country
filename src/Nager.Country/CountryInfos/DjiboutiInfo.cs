namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Djibouti
    /// </summary>
    public class DjiboutiInfo : ICountryInfo
    {
        public string CommonName => "Djibouti";
        public string OfficialName => "Republic of Djibouti";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جيبوتي"),
            new Translation(LanguageCode.AZ, "Cibuti"),
            new Translation(LanguageCode.BE, "Джыбуці"),
            new Translation(LanguageCode.BG, "Джибути"),
            new Translation(LanguageCode.BS, "Džibuti"),
            new Translation(LanguageCode.CA, "Djibouti"),
            new Translation(LanguageCode.CS, "Džibutsko"),
            new Translation(LanguageCode.DA, "Djibouti"),
            new Translation(LanguageCode.DE, "Dschibuti"),
            new Translation(LanguageCode.EL, "Τζιμπουτί"),
            new Translation(LanguageCode.EN, "Djibouti"),
            new Translation(LanguageCode.ES, "Djibouti"),
            new Translation(LanguageCode.ET, "Djibouti"),
            new Translation(LanguageCode.FA, "جیبوتی"),
            new Translation(LanguageCode.FI, "Djibouti"),
            new Translation(LanguageCode.FR, "Djibouti"),
            new Translation(LanguageCode.HE, "ג׳יבוטי"),
            new Translation(LanguageCode.HR, "Džibuti"),
            new Translation(LanguageCode.HU, "Dzsibuti"),
            new Translation(LanguageCode.HY, "Ջիբութի"),
            new Translation(LanguageCode.ID, "Djibouti"),
            new Translation(LanguageCode.IT, "Gibuti"),
            new Translation(LanguageCode.JA, "ジブチ"),
            new Translation(LanguageCode.KA, "ჯიბუტი"),
            new Translation(LanguageCode.KK, "Джибути"),
            new Translation(LanguageCode.KO, "지부티"),
            new Translation(LanguageCode.KY, "Джибути"),
            new Translation(LanguageCode.LT, "Džibutis"),
            new Translation(LanguageCode.LV, "Džibutija"),
            new Translation(LanguageCode.MK, "Џибути"),
            new Translation(LanguageCode.MN, "Джибути"),
            new Translation(LanguageCode.NB, "Djibouti"),
            new Translation(LanguageCode.NL, "Djibouti"),
            new Translation(LanguageCode.NN, "Djibouti"),
            new Translation(LanguageCode.PL, "Dżibuti"),
            new Translation(LanguageCode.PT, "Djibuti"),
            new Translation(LanguageCode.RO, "Djibouti"),
            new Translation(LanguageCode.RU, "Джибути"),
            new Translation(LanguageCode.SK, "Džibutsko"),
            new Translation(LanguageCode.SL, "Džibuti"),
            new Translation(LanguageCode.SR, "Џибути"),
            new Translation(LanguageCode.SV, "Djibouti"),
            new Translation(LanguageCode.TR, "Cibuti"),
            new Translation(LanguageCode.UK, "Джибуті"),
            new Translation(LanguageCode.UZ, "Jibuti"),
            new Translation(LanguageCode.ZH, "吉布提"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.DJ;
        public Alpha3Code Alpha3Code => Alpha3Code.DJI;
        public int NumericCode => 262;
        public string[] TLD => new [] { ".dj" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.ER,
            Alpha2Code.ET,
            Alpha2Code.SO,
        };

        public string[] Currencies => new [] { "DJF" };
        public string[] CallingCodes => new [] { "253" };
    }
}
