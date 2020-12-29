using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bulgaria
    /// </summary>
    public class BulgariaInfo : ICountryInfo
    {
        public string CommonName => "Bulgaria";
        public string OfficialName => "Republic of Bulgaria";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بلغاريا"),
            new Translation(LanguageCode.AZ, "Bolqarıstan"),
            new Translation(LanguageCode.BE, "Балгарыя"),
            new Translation(LanguageCode.BG, "България"),
            new Translation(LanguageCode.BS, "Bugarska"),
            new Translation(LanguageCode.CA, "Bulgària"),
            new Translation(LanguageCode.CS, "Bulharsko"),
            new Translation(LanguageCode.DA, "Bulgarien"),
            new Translation(LanguageCode.DE, "Bulgarien"),
            new Translation(LanguageCode.EL, "Βουλγαρία"),
            new Translation(LanguageCode.EN, "Bulgaria"),
            new Translation(LanguageCode.ES, "Bulgaria"),
            new Translation(LanguageCode.ET, "Bulgaaria"),
            new Translation(LanguageCode.FA, "بلغارستان"),
            new Translation(LanguageCode.FI, "Bulgaria"),
            new Translation(LanguageCode.FR, "Bulgarie"),
            new Translation(LanguageCode.HE, "בולגריה"),
            new Translation(LanguageCode.HR, "Bugarska"),
            new Translation(LanguageCode.HU, "Bulgária"),
            new Translation(LanguageCode.HY, "Բուլղարիա"),
            new Translation(LanguageCode.ID, "Bulgaria"),
            new Translation(LanguageCode.IT, "Bulgaria"),
            new Translation(LanguageCode.JA, "ブルガリア"),
            new Translation(LanguageCode.KA, "ბულგარეთი"),
            new Translation(LanguageCode.KK, "Болгария"),
            new Translation(LanguageCode.KO, "불가리아"),
            new Translation(LanguageCode.KY, "Болгария"),
            new Translation(LanguageCode.LT, "Bulgarija"),
            new Translation(LanguageCode.LV, "Bulgārija"),
            new Translation(LanguageCode.MK, "Бугарија"),
            new Translation(LanguageCode.MN, "Болгар"),
            new Translation(LanguageCode.NB, "Bulgaria"),
            new Translation(LanguageCode.NL, "Bulgarije"),
            new Translation(LanguageCode.NN, "Bulgaria"),
            new Translation(LanguageCode.PL, "Bułgaria"),
            new Translation(LanguageCode.PT, "Bulgária"),
            new Translation(LanguageCode.RO, "Bulgaria"),
            new Translation(LanguageCode.RU, "Болгария"),
            new Translation(LanguageCode.SK, "Bulharsko"),
            new Translation(LanguageCode.SL, "Bolgarija"),
            new Translation(LanguageCode.SR, "Бугарска"),
            new Translation(LanguageCode.SV, "Bulgarien"),
            new Translation(LanguageCode.TR, "Bulgaristan"),
            new Translation(LanguageCode.UK, "Болгарія"),
            new Translation(LanguageCode.UZ, "Bolgariya"),
            new Translation(LanguageCode.ZH, "保加利亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BG;
        public Alpha3Code Alpha3Code => Alpha3Code.BGR;
        public int NumericCode => 100;
        public string[] TLD => new [] { ".bg" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GR,
            Alpha2Code.MK,
            Alpha2Code.RO,
            Alpha2Code.RS,
            Alpha2Code.TR,
        };

        public ICurrency[] Currencies => new [] { new BgnCurrency() };
        public string[] CallingCodes => new [] { "359" };
    }
}
