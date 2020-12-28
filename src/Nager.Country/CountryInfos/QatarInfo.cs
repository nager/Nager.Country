using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Qatar
    /// </summary>
    public class QatarInfo : ICountryInfo
    {
        public string CommonName => "Qatar";
        public string OfficialName => "State of Qatar";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "قطر"),
            new Translation(LanguageCode.AZ, "Qətər"),
            new Translation(LanguageCode.BE, "Катар"),
            new Translation(LanguageCode.BG, "Катар"),
            new Translation(LanguageCode.BS, "Katar"),
            new Translation(LanguageCode.CA, "Qatar"),
            new Translation(LanguageCode.CS, "Katar"),
            new Translation(LanguageCode.DA, "Qatar"),
            new Translation(LanguageCode.DE, "Katar"),
            new Translation(LanguageCode.EL, "Κατάρ"),
            new Translation(LanguageCode.EN, "Qatar"),
            new Translation(LanguageCode.ES, "Qatar"),
            new Translation(LanguageCode.ET, "Katar"),
            new Translation(LanguageCode.FA, "قطر"),
            new Translation(LanguageCode.FI, "Qatar"),
            new Translation(LanguageCode.FR, "Qatar"),
            new Translation(LanguageCode.HE, "קטאר"),
            new Translation(LanguageCode.HR, "Katar"),
            new Translation(LanguageCode.HU, "Katar"),
            new Translation(LanguageCode.HY, "Կատար"),
            new Translation(LanguageCode.ID, "Qatar"),
            new Translation(LanguageCode.IT, "Qatar"),
            new Translation(LanguageCode.JA, "カタール"),
            new Translation(LanguageCode.KA, "კატარი"),
            new Translation(LanguageCode.KK, "Катар"),
            new Translation(LanguageCode.KO, "카타르"),
            new Translation(LanguageCode.KY, "Катар"),
            new Translation(LanguageCode.LT, "Kataras"),
            new Translation(LanguageCode.LV, "Katara"),
            new Translation(LanguageCode.MK, "Катар"),
            new Translation(LanguageCode.MN, "Катар"),
            new Translation(LanguageCode.NB, "Qatar"),
            new Translation(LanguageCode.NL, "Qatar"),
            new Translation(LanguageCode.NN, "Qatar"),
            new Translation(LanguageCode.PL, "Katar"),
            new Translation(LanguageCode.PT, "Catar"),
            new Translation(LanguageCode.RO, "Qatar"),
            new Translation(LanguageCode.RU, "Катар"),
            new Translation(LanguageCode.SK, "Katar"),
            new Translation(LanguageCode.SL, "Katar"),
            new Translation(LanguageCode.SR, "Катар"),
            new Translation(LanguageCode.SV, "Qatar"),
            new Translation(LanguageCode.TR, "Katar"),
            new Translation(LanguageCode.UK, "Катар"),
            new Translation(LanguageCode.UZ, "Qatar"),
            new Translation(LanguageCode.ZH, "卡塔尔"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.QA;
        public Alpha3Code Alpha3Code => Alpha3Code.QAT;
        public int NumericCode => 634;
        public string[] TLD => new [] { ".qa", "قطر." };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.SA,
        };

        public ICurrency[] Currencies => new [] { new QarCurrency() };
        public string[] CallingCodes => new [] { "974" };
    }
}
