using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Benin
    /// </summary>
    public class BeninInfo : ICountryInfo
    {
        public string CommonName => "Benin";
        public string OfficialName => "Republic of Benin";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بنين"),
            new Translation(LanguageCode.AZ, "Benin"),
            new Translation(LanguageCode.BE, "Бенін"),
            new Translation(LanguageCode.BG, "Бенин"),
            new Translation(LanguageCode.BS, "Benin"),
            new Translation(LanguageCode.CA, "Benín"),
            new Translation(LanguageCode.CS, "Benin"),
            new Translation(LanguageCode.DA, "Benin"),
            new Translation(LanguageCode.DE, "Benin"),
            new Translation(LanguageCode.EL, "Μπενίν"),
            new Translation(LanguageCode.EN, "Benin"),
            new Translation(LanguageCode.ES, "Benin"),
            new Translation(LanguageCode.ET, "Benin"),
            new Translation(LanguageCode.FA, "بنین"),
            new Translation(LanguageCode.FI, "Benin"),
            new Translation(LanguageCode.FR, "Bénin"),
            new Translation(LanguageCode.HE, "בנין"),
            new Translation(LanguageCode.HR, "Benin"),
            new Translation(LanguageCode.HU, "Benin"),
            new Translation(LanguageCode.HY, "Բենին"),
            new Translation(LanguageCode.ID, "Benin"),
            new Translation(LanguageCode.IT, "Benin"),
            new Translation(LanguageCode.JA, "ベナン"),
            new Translation(LanguageCode.KA, "ბენინი"),
            new Translation(LanguageCode.KK, "Бенин"),
            new Translation(LanguageCode.KO, "베냉"),
            new Translation(LanguageCode.KY, "Бенин"),
            new Translation(LanguageCode.LT, "Beninas"),
            new Translation(LanguageCode.LV, "Benina"),
            new Translation(LanguageCode.MK, "Бенин"),
            new Translation(LanguageCode.MN, "Бенин"),
            new Translation(LanguageCode.NB, "Benin"),
            new Translation(LanguageCode.NL, "Benin"),
            new Translation(LanguageCode.NN, "Benin"),
            new Translation(LanguageCode.PL, "Benin"),
            new Translation(LanguageCode.PT, "Benin"),
            new Translation(LanguageCode.RO, "Benin"),
            new Translation(LanguageCode.RU, "Бенин"),
            new Translation(LanguageCode.SK, "Benin"),
            new Translation(LanguageCode.SL, "Benin"),
            new Translation(LanguageCode.SR, "Бенин"),
            new Translation(LanguageCode.SV, "Benin"),
            new Translation(LanguageCode.TR, "Benin"),
            new Translation(LanguageCode.UK, "Бенін"),
            new Translation(LanguageCode.UZ, "Benin"),
            new Translation(LanguageCode.ZH, "贝宁"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BJ;
        public Alpha3Code Alpha3Code => Alpha3Code.BEN;
        public int NumericCode => 204;
        public string[] TLD => new [] { ".bj" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BF,
            Alpha2Code.NE,
            Alpha2Code.NG,
            Alpha2Code.TG,
        };

        public ICurrency[] Currencies => new [] { new XofCurrency() };
        public string[] CallingCodes => new [] { "229" };
    }
}
