namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Timor-Leste
    /// </summary>
    public class TimorLesteInfo : ICountryInfo
    {
        public string CommonName => "Timor-Leste";
        public string OfficialName => "Democratic Republic of Timor-Leste";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "تيمور الشرقية"),
            new Translation(LanguageCode.AZ, "Şərqi Timor"),
            new Translation(LanguageCode.BE, "Тымор-Лешці"),
            new Translation(LanguageCode.BG, "Източен Тимор"),
            new Translation(LanguageCode.BS, "Istočni Timor"),
            new Translation(LanguageCode.CA, "Timor Oriental"),
            new Translation(LanguageCode.CS, "Východní Timor"),
            new Translation(LanguageCode.DA, "Østtimor"),
            new Translation(LanguageCode.DE, "Osttimor"),
            new Translation(LanguageCode.EL, "Ανατολικό Τιμόρ"),
            new Translation(LanguageCode.EN, "Timor-Leste"),
            new Translation(LanguageCode.ES, "Timor-Leste"),
            new Translation(LanguageCode.ET, "Ida-Timor"),
            new Translation(LanguageCode.FA, "تیمور-لسته"),
            new Translation(LanguageCode.FI, "Itä-Timor"),
            new Translation(LanguageCode.FR, "Timor Leste"),
            new Translation(LanguageCode.HE, "טימור לסטה"),
            new Translation(LanguageCode.HR, "Timor-Leste"),
            new Translation(LanguageCode.HU, "Kelet-Timor"),
            new Translation(LanguageCode.HY, "Թիմոր Լեշտի"),
            new Translation(LanguageCode.ID, "Timor-Leste"),
            new Translation(LanguageCode.IT, "Timor Est"),
            new Translation(LanguageCode.JA, "東ティモール"),
            new Translation(LanguageCode.KA, "ტიმორ-ლესტე"),
            new Translation(LanguageCode.KK, "Тимор-Лесте"),
            new Translation(LanguageCode.KO, "동 티모르"),
            new Translation(LanguageCode.KY, "Тимор-Лесте"),
            new Translation(LanguageCode.LT, "Rytų Timoras"),
            new Translation(LanguageCode.LV, "Austrumtimora"),
            new Translation(LanguageCode.MK, "Источен Тимор (Тимор Лесте)"),
            new Translation(LanguageCode.MN, "Тимор-Лесте"),
            new Translation(LanguageCode.NB, "Øst-Timor"),
            new Translation(LanguageCode.NL, "Timor Leste"),
            new Translation(LanguageCode.NN, "Aust-Timor"),
            new Translation(LanguageCode.PL, "Timor Wschodni"),
            new Translation(LanguageCode.PT, "Timor-Leste"),
            new Translation(LanguageCode.RO, "Timorul de Est"),
            new Translation(LanguageCode.RU, "Восточный Тимор"),
            new Translation(LanguageCode.SK, "Východný Timor"),
            new Translation(LanguageCode.SL, "Timor-Leste"),
            new Translation(LanguageCode.SR, "Источни Тимор"),
            new Translation(LanguageCode.SV, "Östtimor"),
            new Translation(LanguageCode.TR, "Timor-Leste"),
            new Translation(LanguageCode.UK, "Східний Тимор"),
            new Translation(LanguageCode.UZ, "Timor-Leste"),
            new Translation(LanguageCode.ZH, "东帝汶"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TL;
        public Alpha3Code Alpha3Code => Alpha3Code.TLS;
        public int NumericCode => 626;
        public string[] TLD => new [] { ".tl" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.ID,
        };

        public string[] Currencies => new [] { "USD" };
        public string[] CallingCodes => new [] { "670" };
    }
}
