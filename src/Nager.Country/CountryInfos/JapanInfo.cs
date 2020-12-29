using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Japan
    /// </summary>
    public class JapanInfo : ICountryInfo
    {
        public string CommonName => "Japan";
        public string OfficialName => "Japan";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "اليابان"),
            new Translation(LanguageCode.AZ, "Yaponiya"),
            new Translation(LanguageCode.BE, "Японія"),
            new Translation(LanguageCode.BG, "Япония"),
            new Translation(LanguageCode.BS, "Japan"),
            new Translation(LanguageCode.CA, "Japó"),
            new Translation(LanguageCode.CS, "Japonsko"),
            new Translation(LanguageCode.DA, "Japan"),
            new Translation(LanguageCode.DE, "Japan"),
            new Translation(LanguageCode.EL, "Ιαπωνία"),
            new Translation(LanguageCode.EN, "Japan"),
            new Translation(LanguageCode.ES, "Japón"),
            new Translation(LanguageCode.ET, "Jaapan"),
            new Translation(LanguageCode.FA, "ژاپن"),
            new Translation(LanguageCode.FI, "Japani"),
            new Translation(LanguageCode.FR, "Japon"),
            new Translation(LanguageCode.HE, "יפן"),
            new Translation(LanguageCode.HR, "Japan"),
            new Translation(LanguageCode.HU, "Japán"),
            new Translation(LanguageCode.HY, "Ճապոնիա"),
            new Translation(LanguageCode.ID, "Jepang"),
            new Translation(LanguageCode.IT, "Giappone"),
            new Translation(LanguageCode.JA, "日本"),
            new Translation(LanguageCode.KA, "იაპონია"),
            new Translation(LanguageCode.KK, "Жапония"),
            new Translation(LanguageCode.KO, "일본"),
            new Translation(LanguageCode.KY, "Япония"),
            new Translation(LanguageCode.LT, "Japonija"),
            new Translation(LanguageCode.LV, "Japāna"),
            new Translation(LanguageCode.MK, "Јапонија"),
            new Translation(LanguageCode.MN, "Япон"),
            new Translation(LanguageCode.NB, "Japan"),
            new Translation(LanguageCode.NL, "Japan"),
            new Translation(LanguageCode.NN, "Japan"),
            new Translation(LanguageCode.PL, "Japonia"),
            new Translation(LanguageCode.PT, "Japão"),
            new Translation(LanguageCode.RO, "Japonia"),
            new Translation(LanguageCode.RU, "Япония"),
            new Translation(LanguageCode.SK, "Japonsko"),
            new Translation(LanguageCode.SL, "Japonska"),
            new Translation(LanguageCode.SR, "Јапан"),
            new Translation(LanguageCode.SV, "Japan"),
            new Translation(LanguageCode.TR, "Japonya"),
            new Translation(LanguageCode.UK, "Японія"),
            new Translation(LanguageCode.UZ, "Yaponiya"),
            new Translation(LanguageCode.ZH, "日本"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.JP;
        public Alpha3Code Alpha3Code => Alpha3Code.JPN;
        public int NumericCode => 392;
        public string[] TLD => new [] { ".jp", ".みんな" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.EasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new JpyCurrency() };
        public string[] CallingCodes => new [] { "81" };
    }
}
