using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Burundi
    /// </summary>
    public class BurundiInfo : ICountryInfo
    {
        public string CommonName => "Burundi";
        public string OfficialName => "Republic of Burundi";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بوروندي"),
            new Translation(LanguageCode.AZ, "Burundi"),
            new Translation(LanguageCode.BE, "Бурундзі"),
            new Translation(LanguageCode.BG, "Бурунди"),
            new Translation(LanguageCode.BS, "Burundi"),
            new Translation(LanguageCode.CA, "Burundi"),
            new Translation(LanguageCode.CS, "Burundi"),
            new Translation(LanguageCode.DA, "Burundi"),
            new Translation(LanguageCode.DE, "Burundi"),
            new Translation(LanguageCode.EL, "Μπουρουντί"),
            new Translation(LanguageCode.EN, "Burundi"),
            new Translation(LanguageCode.ES, "Burundi"),
            new Translation(LanguageCode.ET, "Burundi"),
            new Translation(LanguageCode.FA, "بوروندی"),
            new Translation(LanguageCode.FI, "Burundi"),
            new Translation(LanguageCode.FR, "Burundi"),
            new Translation(LanguageCode.HE, "בורונדי"),
            new Translation(LanguageCode.HR, "Burundi"),
            new Translation(LanguageCode.HU, "Burundi"),
            new Translation(LanguageCode.HY, "Բուրունդի"),
            new Translation(LanguageCode.ID, "Burundi"),
            new Translation(LanguageCode.IT, "Burundi"),
            new Translation(LanguageCode.JA, "ブルンジ"),
            new Translation(LanguageCode.KA, "ბურუნდი"),
            new Translation(LanguageCode.KK, "Бурунди"),
            new Translation(LanguageCode.KO, "부룬디"),
            new Translation(LanguageCode.KY, "Бурунди"),
            new Translation(LanguageCode.LT, "Burundis"),
            new Translation(LanguageCode.LV, "Burundija"),
            new Translation(LanguageCode.MK, "Бурунди"),
            new Translation(LanguageCode.MN, "Бурунди"),
            new Translation(LanguageCode.NB, "Burundi"),
            new Translation(LanguageCode.NL, "Burundi"),
            new Translation(LanguageCode.NN, "Burundi"),
            new Translation(LanguageCode.PL, "Burundi"),
            new Translation(LanguageCode.PT, "Burundi"),
            new Translation(LanguageCode.RO, "Burundi"),
            new Translation(LanguageCode.RU, "Бурунди"),
            new Translation(LanguageCode.SK, "Burundi"),
            new Translation(LanguageCode.SL, "Burundi"),
            new Translation(LanguageCode.SR, "Бурунди"),
            new Translation(LanguageCode.SV, "Burundi"),
            new Translation(LanguageCode.TR, "Burundi"),
            new Translation(LanguageCode.UK, "Бурунді"),
            new Translation(LanguageCode.UZ, "Burundi"),
            new Translation(LanguageCode.ZH, "布隆迪"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BI;
        public Alpha3Code Alpha3Code => Alpha3Code.BDI;
        public int NumericCode => 108;
        public string[] TLD => new [] { ".bi" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CD,
            Alpha2Code.RW,
            Alpha2Code.TZ,
        };

        public ICurrency[] Currencies => new [] { new BifCurrency() };
        public string[] CallingCodes => new [] { "257" };
    }
}
