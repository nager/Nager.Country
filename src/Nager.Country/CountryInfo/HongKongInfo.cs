namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Hong Kong
    /// </summary>
    public class HongKongInfo : ICountryInfo
    {
        public string CommonName => "Hong Kong";
        public string OfficialName => "Hong Kong Special Administrative Region of the People's Republic of China";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "هونغ كونغ"),
            new Translation(LanguageCode.AZ, "Honq Konq"),
            new Translation(LanguageCode.BE, "Ганконг, САР (Кітай)"),
            new Translation(LanguageCode.BG, "Хонконг, САР на Китай"),
            new Translation(LanguageCode.BS, "Hong Kong (SAR Kina)"),
            new Translation(LanguageCode.CA, "Hong Kong"),
            new Translation(LanguageCode.CS, "Hongkong"),
            new Translation(LanguageCode.DA, "Hong Kong"),
            new Translation(LanguageCode.DE, "Hongkong"),
            new Translation(LanguageCode.EL, "Χονγκ Κόνγκ"),
            new Translation(LanguageCode.EN, "Hong Kong"),
            new Translation(LanguageCode.ES, "Hong Kong"),
            new Translation(LanguageCode.ET, "Hongkong - Hiina erihalduspiirkond"),
            new Translation(LanguageCode.FA, "هنگ‌کنگ"),
            new Translation(LanguageCode.FI, "Hongkong"),
            new Translation(LanguageCode.FR, "Hong Kong"),
            new Translation(LanguageCode.HE, "הונג קונג (מחוז מנהלי מיוחד של סין)"),
            new Translation(LanguageCode.HR, "PUP Hong Kong Kina"),
            new Translation(LanguageCode.HU, "Hong Kong"),
            new Translation(LanguageCode.HY, "Հոնկոնգի ՀՎՇ"),
            new Translation(LanguageCode.ID, "Hong Kong"),
            new Translation(LanguageCode.IT, "Hong Kong"),
            new Translation(LanguageCode.JA, "香港"),
            new Translation(LanguageCode.KA, "ჰონკონგი"),
            new Translation(LanguageCode.KK, "Гонконг"),
            new Translation(LanguageCode.KO, "홍콩"),
            new Translation(LanguageCode.KY, "Гонконг Кытай ААА"),
            new Translation(LanguageCode.LT, "Honkongas"),
            new Translation(LanguageCode.LV, "Ķīnas īpašās pārvaldes apgabals Honkonga"),
            new Translation(LanguageCode.MK, "Хонг Конг С.А.Р Кина"),
            new Translation(LanguageCode.MN, "Хонг Конг"),
            new Translation(LanguageCode.NB, "Hongkong"),
            new Translation(LanguageCode.NL, "Hong Kong"),
            new Translation(LanguageCode.NN, "Hongkong"),
            new Translation(LanguageCode.PL, "Hongkong"),
            new Translation(LanguageCode.PT, "Hong Kong, RAE da China"),
            new Translation(LanguageCode.RO, "R.A.S. Hong Kong a Chinei"),
            new Translation(LanguageCode.RU, "Гонконг"),
            new Translation(LanguageCode.SK, "Hongkong – OAO Číny"),
            new Translation(LanguageCode.SL, "Hongkong"),
            new Translation(LanguageCode.SR, "САР Хонгконг (Кина)"),
            new Translation(LanguageCode.SV, "Hongkong"),
            new Translation(LanguageCode.TR, "Çin Hong Kong ÖYB"),
            new Translation(LanguageCode.UK, "Гонконг"),
            new Translation(LanguageCode.UZ, "Gonkong (Xitoy MMH)"),
            new Translation(LanguageCode.ZH, "香港"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.HK;
        public Alpha3Code Alpha3Code => Alpha3Code.HKG;
        public int NumericCode => 344;
        public string[] TLD => new [] { ".hk", ".香港" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.EasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CN,
        };

        public string[] Currencies => new [] { "HKD" };
        public string[] CallingCodes => new [] { "852" };
    }
}
