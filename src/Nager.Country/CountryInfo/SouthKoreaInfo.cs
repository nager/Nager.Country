namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// South Korea
    /// </summary>
    public class SouthKoreaInfo : ICountryInfo
    {
        public string CommonName => "South Korea";
        public string OfficialName => "Republic of Korea";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "كوريا الجنوبية"),
            new Translation(LanguageCode.AZ, "Cənubi Koreya"),
            new Translation(LanguageCode.BE, "Паўднёвая Карэя"),
            new Translation(LanguageCode.BG, "Южна Корея"),
            new Translation(LanguageCode.BS, "Južna Koreja"),
            new Translation(LanguageCode.CA, "Corea del Sud"),
            new Translation(LanguageCode.CS, "Jižní Korea"),
            new Translation(LanguageCode.DA, "Sydkorea"),
            new Translation(LanguageCode.DE, "Südkorea"),
            new Translation(LanguageCode.EL, "Δημοκρατία της Κορέας"),
            new Translation(LanguageCode.EN, "South Korea"),
            new Translation(LanguageCode.ES, "República de Corea"),
            new Translation(LanguageCode.ET, "Lõuna-Korea"),
            new Translation(LanguageCode.FA, "کرهٔ جنوبی"),
            new Translation(LanguageCode.FI, "Korean tasavalta"),
            new Translation(LanguageCode.FR, "Corée du Sud, République"),
            new Translation(LanguageCode.HE, "קוריאה הדרומית"),
            new Translation(LanguageCode.HR, "Južna Koreja"),
            new Translation(LanguageCode.HU, "Dél-Korea"),
            new Translation(LanguageCode.HY, "Հարավային Կորեա"),
            new Translation(LanguageCode.ID, "Korea Selatan"),
            new Translation(LanguageCode.IT, "Corea del Sud"),
            new Translation(LanguageCode.JA, "大韓民国"),
            new Translation(LanguageCode.KA, "სამხრეთ კორეა"),
            new Translation(LanguageCode.KK, "Оңтүстік Корея"),
            new Translation(LanguageCode.KO, "대한민국"),
            new Translation(LanguageCode.KY, "Түштүк Корея"),
            new Translation(LanguageCode.LT, "Pietų Korėja"),
            new Translation(LanguageCode.LV, "Dienvidkoreja"),
            new Translation(LanguageCode.MK, "Јужна Кореја"),
            new Translation(LanguageCode.MN, "Өмнөд Солонгос"),
            new Translation(LanguageCode.NB, "Sør-Korea"),
            new Translation(LanguageCode.NL, "Zuid-Korea"),
            new Translation(LanguageCode.NN, "Sør-Korea"),
            new Translation(LanguageCode.PL, "Korea Południowa"),
            new Translation(LanguageCode.PT, "Coreia do Sul"),
            new Translation(LanguageCode.RO, "Coreea de Sud"),
            new Translation(LanguageCode.RU, "Республика Корея"),
            new Translation(LanguageCode.SK, "Južná Kórea"),
            new Translation(LanguageCode.SL, "Južna Koreja"),
            new Translation(LanguageCode.SR, "Јужна Кореја"),
            new Translation(LanguageCode.SV, "Sydkorea"),
            new Translation(LanguageCode.TR, "Güney Kore"),
            new Translation(LanguageCode.UK, "Південна Корея"),
            new Translation(LanguageCode.UZ, "Janubiy Koreya"),
            new Translation(LanguageCode.ZH, "韩国"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.KR;
        public Alpha3Code Alpha3Code => Alpha3Code.KOR;
        public int NumericCode => 410;
        public string[] TLD => new [] { ".kr", ".한국" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.EasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.KP,
        };

        public string[] Currencies => new [] { "KRW" };
        public string[] CallingCodes => new [] { "82" };
    }
}
