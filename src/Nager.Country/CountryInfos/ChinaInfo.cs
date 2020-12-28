using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// China
    /// </summary>
    public class ChinaInfo : ICountryInfo
    {
        public string CommonName => "China";
        public string OfficialName => "People's Republic of China";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الصين"),
            new Translation(LanguageCode.AZ, "Çin"),
            new Translation(LanguageCode.BE, "Кітай"),
            new Translation(LanguageCode.BG, "Китай"),
            new Translation(LanguageCode.BS, "Kina"),
            new Translation(LanguageCode.CA, "Xina"),
            new Translation(LanguageCode.CS, "Čína"),
            new Translation(LanguageCode.DA, "Kina"),
            new Translation(LanguageCode.DE, "China"),
            new Translation(LanguageCode.EL, "Κίνα"),
            new Translation(LanguageCode.EN, "China"),
            new Translation(LanguageCode.ES, "China"),
            new Translation(LanguageCode.ET, "Hiina"),
            new Translation(LanguageCode.FA, "چین"),
            new Translation(LanguageCode.FI, "Kiina"),
            new Translation(LanguageCode.FR, "Chine"),
            new Translation(LanguageCode.HE, "סין"),
            new Translation(LanguageCode.HR, "Kina"),
            new Translation(LanguageCode.HU, "Kína"),
            new Translation(LanguageCode.HY, "Չինաստան"),
            new Translation(LanguageCode.ID, "China"),
            new Translation(LanguageCode.IT, "Cina"),
            new Translation(LanguageCode.JA, "中華人民共和国"),
            new Translation(LanguageCode.KA, "ჩინეთი"),
            new Translation(LanguageCode.KK, "Қытай"),
            new Translation(LanguageCode.KO, "중국"),
            new Translation(LanguageCode.KY, "Кытай"),
            new Translation(LanguageCode.LT, "Kinija"),
            new Translation(LanguageCode.LV, "Ķīna"),
            new Translation(LanguageCode.MK, "Кина"),
            new Translation(LanguageCode.MN, "Хятад"),
            new Translation(LanguageCode.NB, "Kina"),
            new Translation(LanguageCode.NL, "China"),
            new Translation(LanguageCode.NN, "Kina"),
            new Translation(LanguageCode.PL, "Chiny"),
            new Translation(LanguageCode.PT, "China"),
            new Translation(LanguageCode.RO, "China"),
            new Translation(LanguageCode.RU, "КНР (Китайская Народная Республика)"),
            new Translation(LanguageCode.SK, "Čína"),
            new Translation(LanguageCode.SL, "Kitajska"),
            new Translation(LanguageCode.SR, "Кина"),
            new Translation(LanguageCode.SV, "Kina"),
            new Translation(LanguageCode.TR, "Çin"),
            new Translation(LanguageCode.UK, "КНР (Китайська Народна Республіка)"),
            new Translation(LanguageCode.UZ, "Xitoy"),
            new Translation(LanguageCode.ZH, "中国"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CN;
        public Alpha3Code Alpha3Code => Alpha3Code.CHN;
        public int NumericCode => 156;
        public string[] TLD => new [] { ".cn", ".中国", ".中國", ".公司", ".网络" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.EasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.BT,
            Alpha2Code.MM,
            Alpha2Code.HK,
            Alpha2Code.IN,
            Alpha2Code.KZ,
            Alpha2Code.KP,
            Alpha2Code.KG,
            Alpha2Code.LA,
            Alpha2Code.MO,
            Alpha2Code.MN,
            Alpha2Code.PK,
            Alpha2Code.RU,
            Alpha2Code.TJ,
            Alpha2Code.VN,
        };

        public ICurrency[] Currencies => new [] { new CnyCurrency() };
        public string[] CallingCodes => new [] { "86" };
    }
}
