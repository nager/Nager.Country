namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Liechtenstein
    /// </summary>
    public class LiechtensteinInfo : ICountryInfo
    {
        public string CommonName => "Liechtenstein";
        public string OfficialName => "Principality of Liechtenstein";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ليختنشتاين"),
            new Translation(LanguageCode.AZ, "Lixtenşteyn"),
            new Translation(LanguageCode.BE, "Ліхтэнштэйн"),
            new Translation(LanguageCode.BG, "Лихтенщайн"),
            new Translation(LanguageCode.BS, "Lihtenštajn"),
            new Translation(LanguageCode.CA, "Liechtenstein"),
            new Translation(LanguageCode.CS, "Lichtenštejnsko"),
            new Translation(LanguageCode.DA, "Liechtenstein"),
            new Translation(LanguageCode.DE, "Liechtenstein"),
            new Translation(LanguageCode.EL, "Πριγκιπάτο του Λίχτενσταϊν"),
            new Translation(LanguageCode.EN, "Liechtenstein"),
            new Translation(LanguageCode.ES, "Liechtenstein"),
            new Translation(LanguageCode.ET, "Liechtenstein"),
            new Translation(LanguageCode.FA, "لیختن‌اشتاین"),
            new Translation(LanguageCode.FI, "Liechtenstein"),
            new Translation(LanguageCode.FR, "Liechtenstein"),
            new Translation(LanguageCode.HE, "ליכטנשטיין"),
            new Translation(LanguageCode.HR, "Lihtenštajn"),
            new Translation(LanguageCode.HU, "Liechtenstein"),
            new Translation(LanguageCode.HY, "Լիխտենշտեյն"),
            new Translation(LanguageCode.ID, "Liechtenstein"),
            new Translation(LanguageCode.IT, "Liechtenstein"),
            new Translation(LanguageCode.JA, "リヒテンシュタイン"),
            new Translation(LanguageCode.KA, "ლიხტენშტაინი"),
            new Translation(LanguageCode.KK, "Лихтенштейн"),
            new Translation(LanguageCode.KO, "리히텐슈타인"),
            new Translation(LanguageCode.KY, "Лихтенштейн"),
            new Translation(LanguageCode.LT, "Lichtenšteinas"),
            new Translation(LanguageCode.LV, "Lihtenšteina"),
            new Translation(LanguageCode.MK, "Лихтенштајн"),
            new Translation(LanguageCode.MN, "Лихтенштейн"),
            new Translation(LanguageCode.NB, "Liechtenstein"),
            new Translation(LanguageCode.NL, "Liechtenstein"),
            new Translation(LanguageCode.NN, "Liechtenstein"),
            new Translation(LanguageCode.PL, "Liechtenstein"),
            new Translation(LanguageCode.PT, "Liechtenstein"),
            new Translation(LanguageCode.RO, "Liechtenstein"),
            new Translation(LanguageCode.RU, "Лихтенштейн"),
            new Translation(LanguageCode.SK, "Lichtenštajnsko"),
            new Translation(LanguageCode.SL, "Lihtenštajn"),
            new Translation(LanguageCode.SR, "Лихтенштајн"),
            new Translation(LanguageCode.SV, "Liechtenstein"),
            new Translation(LanguageCode.TR, "Liechtenstein"),
            new Translation(LanguageCode.UK, "Ліхтенштейн"),
            new Translation(LanguageCode.UZ, "Lixtenshteyn"),
            new Translation(LanguageCode.ZH, "列支敦斯登"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.LI;
        public Alpha3Code Alpha3Code => Alpha3Code.LIE;
        public int NumericCode => 438;
        public string[] TLD => new [] { ".li" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.CH,
        };

        public string[] Currencies => new [] { "CHF" };
        public string[] CallingCodes => new [] { "423" };
    }
}
