namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// North Korea
    /// </summary>
    public class NorthKoreaInfo : ICountryInfo
    {
        public string CommonName => "North Korea";
        public string OfficialName => "Democratic People's Republic of Korea";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "كوريا الشمالية"),
            new Translation(LanguageCode.AZ, "Şimali Koreya"),
            new Translation(LanguageCode.BE, "Паўночная Карэя"),
            new Translation(LanguageCode.BG, "Северна Корея"),
            new Translation(LanguageCode.BS, "Sjeverna Koreja"),
            new Translation(LanguageCode.CA, "Corea del Nord"),
            new Translation(LanguageCode.CS, "Severní Korea"),
            new Translation(LanguageCode.DA, "Nordkorea"),
            new Translation(LanguageCode.DE, "Nordkorea"),
            new Translation(LanguageCode.EL, "Λαοκρατική Δημοκρατία της Κορέας"),
            new Translation(LanguageCode.EN, "North Korea"),
            new Translation(LanguageCode.ES, "República Popular Democrática de Corea"),
            new Translation(LanguageCode.ET, "Põhja-Korea"),
            new Translation(LanguageCode.FA, "کرهٔ شمالی"),
            new Translation(LanguageCode.FI, "Korean demokraattinen kansantasavalta"),
            new Translation(LanguageCode.FR, "Corée du Nord, République populaire démocratique"),
            new Translation(LanguageCode.HE, "קוריאה הצפונית"),
            new Translation(LanguageCode.HR, "Sjeverna Koreja"),
            new Translation(LanguageCode.HU, "Észak-Korea"),
            new Translation(LanguageCode.HY, "Հյուսիսային Կորեա"),
            new Translation(LanguageCode.ID, "Korea Utara"),
            new Translation(LanguageCode.IT, "Corea del Nord"),
            new Translation(LanguageCode.JA, "朝鮮民主主義人民共和国"),
            new Translation(LanguageCode.KA, "ჩრდილოეთ კორეა"),
            new Translation(LanguageCode.KK, "Солтүстік Корея"),
            new Translation(LanguageCode.KO, "한국, 조선 민주주의 인민 공화국"),
            new Translation(LanguageCode.KY, "Түндүк Корея"),
            new Translation(LanguageCode.LT, "Šiaurės Korėja"),
            new Translation(LanguageCode.LV, "Ziemeļkoreja"),
            new Translation(LanguageCode.MK, "Северна Кореја"),
            new Translation(LanguageCode.MN, "Хойд Солонгос"),
            new Translation(LanguageCode.NB, "Nord-Korea"),
            new Translation(LanguageCode.NL, "Noord-Korea"),
            new Translation(LanguageCode.NN, "Nord-Korea"),
            new Translation(LanguageCode.PL, "Korea Północna"),
            new Translation(LanguageCode.PT, "Coreia do Norte"),
            new Translation(LanguageCode.RO, "Coreea de Nord"),
            new Translation(LanguageCode.RU, "КНДР (Корейская Народно-Демократическая Республика)"),
            new Translation(LanguageCode.SK, "Severná Kórea"),
            new Translation(LanguageCode.SL, "Severna Koreja"),
            new Translation(LanguageCode.SR, "Северна Кореја"),
            new Translation(LanguageCode.SV, "Nordkorea"),
            new Translation(LanguageCode.TR, "Kuzey Kore"),
            new Translation(LanguageCode.UK, "КНДР (Корейська Народно-Демократична Республіка)"),
            new Translation(LanguageCode.UZ, "Shimoliy Koreya"),
            new Translation(LanguageCode.ZH, "朝鲜"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.KP;
        public Alpha3Code Alpha3Code => Alpha3Code.PRK;
        public int NumericCode => 408;
        public string[] TLD => new [] { ".kp" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.EasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.KR,
            Alpha2Code.RU,
        };

        public string[] Currencies => new [] { "KPW" };
        public string[] CallingCodes => new [] { "850" };
    }
}
