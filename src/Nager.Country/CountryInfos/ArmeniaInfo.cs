using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Armenia
    /// </summary>
    public class ArmeniaInfo : ICountryInfo
    {
        public string CommonName => "Armenia";
        public string OfficialName => "Republic of Armenia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أرمينيا"),
            new Translation(LanguageCode.AZ, "Ermənistan"),
            new Translation(LanguageCode.BE, "Арменія"),
            new Translation(LanguageCode.BG, "Армения"),
            new Translation(LanguageCode.BS, "Armenija"),
            new Translation(LanguageCode.CA, "Armènia"),
            new Translation(LanguageCode.CS, "Arménie"),
            new Translation(LanguageCode.DA, "Armenien"),
            new Translation(LanguageCode.DE, "Armenien"),
            new Translation(LanguageCode.EL, "Αρμενία"),
            new Translation(LanguageCode.EN, "Armenia"),
            new Translation(LanguageCode.ES, "Armenia"),
            new Translation(LanguageCode.ET, "Armeenia"),
            new Translation(LanguageCode.FA, "ارمنستان"),
            new Translation(LanguageCode.FI, "Armenia"),
            new Translation(LanguageCode.FR, "Arménie"),
            new Translation(LanguageCode.HE, "ארמניה"),
            new Translation(LanguageCode.HR, "Armenija"),
            new Translation(LanguageCode.HU, "Örményország"),
            new Translation(LanguageCode.HY, "Հայաստան"),
            new Translation(LanguageCode.ID, "Armenia"),
            new Translation(LanguageCode.IT, "Armenia"),
            new Translation(LanguageCode.JA, "アルメニア"),
            new Translation(LanguageCode.KA, "სომხეთი"),
            new Translation(LanguageCode.KK, "Армения"),
            new Translation(LanguageCode.KO, "아르메니아"),
            new Translation(LanguageCode.KY, "Армения"),
            new Translation(LanguageCode.LT, "Armėnija"),
            new Translation(LanguageCode.LV, "Armēnija"),
            new Translation(LanguageCode.MK, "Ерменија"),
            new Translation(LanguageCode.MN, "Армени"),
            new Translation(LanguageCode.NB, "Armenia"),
            new Translation(LanguageCode.NL, "Armenië"),
            new Translation(LanguageCode.NN, "Armenia"),
            new Translation(LanguageCode.PL, "Armenia"),
            new Translation(LanguageCode.PT, "Armênia"),
            new Translation(LanguageCode.RO, "Armenia"),
            new Translation(LanguageCode.RU, "Армения"),
            new Translation(LanguageCode.SK, "Arménsko"),
            new Translation(LanguageCode.SL, "Armenija"),
            new Translation(LanguageCode.SR, "Јерменија"),
            new Translation(LanguageCode.SV, "Armenien"),
            new Translation(LanguageCode.TR, "Ermenistan"),
            new Translation(LanguageCode.UK, "Арменія"),
            new Translation(LanguageCode.UZ, "Armaniston"),
            new Translation(LanguageCode.ZH, "亚美尼亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AM;
        public Alpha3Code Alpha3Code => Alpha3Code.ARM;
        public int NumericCode => 051;
        public string[] TLD => new [] { ".am" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AZ,
            Alpha2Code.GE,
            Alpha2Code.IR,
            Alpha2Code.TR,
        };

        public ICurrency[] Currencies => new [] { new AmdCurrency() };
        public string[] CallingCodes => new [] { "374" };
    }
}
