namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Sri Lanka
    /// </summary>
    public class SriLankaInfo : ICountryInfo
    {
        public string CommonName => "Sri Lanka";
        public string OfficialName => "Democratic Socialist Republic of Sri Lanka";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سريلانكا"),
            new Translation(LanguageCode.AZ, "Şri-Lanka"),
            new Translation(LanguageCode.BE, "Шры-Ланка"),
            new Translation(LanguageCode.BG, "Шри Ланка"),
            new Translation(LanguageCode.BS, "Šri Lanka"),
            new Translation(LanguageCode.CA, "Sri Lanka"),
            new Translation(LanguageCode.CS, "Šrí Lanka"),
            new Translation(LanguageCode.DA, "Sri Lanka"),
            new Translation(LanguageCode.DE, "Sri Lanka"),
            new Translation(LanguageCode.EL, "Σρι Λάνκα"),
            new Translation(LanguageCode.EN, "Sri Lanka"),
            new Translation(LanguageCode.ES, "Sri Lanka"),
            new Translation(LanguageCode.ET, "Sri Lanka"),
            new Translation(LanguageCode.FA, "سری‌لانکا"),
            new Translation(LanguageCode.FI, "Sri Lanka"),
            new Translation(LanguageCode.FR, "Sri Lanka"),
            new Translation(LanguageCode.HE, "סרי לנקה"),
            new Translation(LanguageCode.HR, "Šri Lanka"),
            new Translation(LanguageCode.HU, "Sri Lanka"),
            new Translation(LanguageCode.HY, "Շրի Լանկա"),
            new Translation(LanguageCode.ID, "Sri Lanka"),
            new Translation(LanguageCode.IT, "Sri Lanka"),
            new Translation(LanguageCode.JA, "スリランカ"),
            new Translation(LanguageCode.KA, "შრი-ლანკა"),
            new Translation(LanguageCode.KK, "Шри-Ланка"),
            new Translation(LanguageCode.KO, "스리랑카"),
            new Translation(LanguageCode.KY, "Шри-Ланка"),
            new Translation(LanguageCode.LT, "Šri Lanka"),
            new Translation(LanguageCode.LV, "Šrilanka"),
            new Translation(LanguageCode.MK, "Шри Ланка"),
            new Translation(LanguageCode.MN, "Шри Ланка"),
            new Translation(LanguageCode.NB, "Sri Lanka"),
            new Translation(LanguageCode.NL, "Sri Lanka"),
            new Translation(LanguageCode.NN, "Sri Lanka"),
            new Translation(LanguageCode.PL, "Sri Lanka"),
            new Translation(LanguageCode.PT, "Sri Lanka"),
            new Translation(LanguageCode.RO, "Sri Lanka"),
            new Translation(LanguageCode.RU, "Шри-Ланка"),
            new Translation(LanguageCode.SK, "Srí Lanka"),
            new Translation(LanguageCode.SL, "Šrilanka"),
            new Translation(LanguageCode.SR, "Шри Ланка"),
            new Translation(LanguageCode.SV, "Sri Lanka"),
            new Translation(LanguageCode.TR, "Sri Lanka"),
            new Translation(LanguageCode.UK, "Шрі-Ланка"),
            new Translation(LanguageCode.UZ, "Shri-Lanka"),
            new Translation(LanguageCode.ZH, "斯里兰卡"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.LK;
        public Alpha3Code Alpha3Code => Alpha3Code.LKA;
        public int NumericCode => 144;
        public string[] TLD => new [] { ".lk", ".இலங்கை", ".ලංකා" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.IN,
        };

        public string[] Currencies => new [] { "LKR" };
        public string[] CallingCodes => new [] { "94" };
    }
}
