namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Uzbekistan
    /// </summary>
    public class UzbekistanInfo : ICountryInfo
    {
        public string CommonName => "Uzbekistan";
        public string OfficialName => "Republic of Uzbekistan";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أوزبكستان"),
            new Translation(LanguageCode.AZ, "Özbəkistan"),
            new Translation(LanguageCode.BE, "Узбекістан"),
            new Translation(LanguageCode.BG, "Узбекистан"),
            new Translation(LanguageCode.BS, "Uzbekistan"),
            new Translation(LanguageCode.CA, "Uzbekistan"),
            new Translation(LanguageCode.CS, "Uzbekistán"),
            new Translation(LanguageCode.DA, "Usbekistan"),
            new Translation(LanguageCode.DE, "Usbekistan"),
            new Translation(LanguageCode.EL, "Ουζμπεκιστάν"),
            new Translation(LanguageCode.EN, "Uzbekistan"),
            new Translation(LanguageCode.ES, "Uzbekistán"),
            new Translation(LanguageCode.ET, "Usbekistan"),
            new Translation(LanguageCode.FA, "ازبکستان"),
            new Translation(LanguageCode.FI, "Uzbekistan"),
            new Translation(LanguageCode.FR, "Ouzbékistan"),
            new Translation(LanguageCode.HE, "אוזבקיסטן"),
            new Translation(LanguageCode.HR, "Uzbekistan"),
            new Translation(LanguageCode.HU, "Üzbegisztán"),
            new Translation(LanguageCode.HY, "Ուզբեկստան"),
            new Translation(LanguageCode.ID, "Uzbekistan"),
            new Translation(LanguageCode.IT, "Uzbekistan"),
            new Translation(LanguageCode.JA, "ウズベキスタン"),
            new Translation(LanguageCode.KA, "უზბეკეთი"),
            new Translation(LanguageCode.KK, "Өзбекстан"),
            new Translation(LanguageCode.KO, "우즈베키스탄"),
            new Translation(LanguageCode.KY, "Өзбекстан"),
            new Translation(LanguageCode.LT, "Uzbekistanas"),
            new Translation(LanguageCode.LV, "Uzbekistāna"),
            new Translation(LanguageCode.MK, "Узбекистан"),
            new Translation(LanguageCode.MN, "Узбекистан"),
            new Translation(LanguageCode.NB, "Usbekistan"),
            new Translation(LanguageCode.NL, "Oezbekistan"),
            new Translation(LanguageCode.NN, "Usbekistan"),
            new Translation(LanguageCode.PL, "Uzbekistan"),
            new Translation(LanguageCode.PT, "Uzbequistão"),
            new Translation(LanguageCode.RO, "Uzbekistan"),
            new Translation(LanguageCode.RU, "Узбекистан"),
            new Translation(LanguageCode.SK, "Uzbekistan"),
            new Translation(LanguageCode.SL, "Uzbekistan"),
            new Translation(LanguageCode.SR, "Узбекистан"),
            new Translation(LanguageCode.SV, "Uzbekistan"),
            new Translation(LanguageCode.TR, "Özbekistan"),
            new Translation(LanguageCode.UK, "Узбекистан"),
            new Translation(LanguageCode.UZ, "Oʻzbekiston"),
            new Translation(LanguageCode.ZH, "乌兹别克斯坦"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.UZ;
        public Alpha3Code Alpha3Code => Alpha3Code.UZB;
        public int NumericCode => 860;
        public string[] TLD => new [] { ".uz" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.CentralAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.KZ,
            Alpha2Code.KG,
            Alpha2Code.TJ,
            Alpha2Code.TM,
        };

        public string[] Currencies => new [] { "UZS" };
        public string[] CallingCodes => new [] { "998" };
    }
}
