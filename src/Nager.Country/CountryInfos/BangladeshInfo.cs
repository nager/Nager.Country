using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bangladesh
    /// </summary>
    public class BangladeshInfo : ICountryInfo
    {
        public string CommonName => "Bangladesh";
        public string OfficialName => "People's Republic of Bangladesh";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بنغلاديش"),
            new Translation(LanguageCode.AZ, "Banqladeş"),
            new Translation(LanguageCode.BE, "Бангладэш"),
            new Translation(LanguageCode.BG, "Бангладеш"),
            new Translation(LanguageCode.BS, "Bangladeš"),
            new Translation(LanguageCode.CA, "Bangla Desh"),
            new Translation(LanguageCode.CS, "Bangladéš"),
            new Translation(LanguageCode.DA, "Bangladesh"),
            new Translation(LanguageCode.DE, "Bangladesch"),
            new Translation(LanguageCode.EL, "Μπανγκλαντές"),
            new Translation(LanguageCode.EN, "Bangladesh"),
            new Translation(LanguageCode.ES, "Bangladesh"),
            new Translation(LanguageCode.ET, "Bangladesh"),
            new Translation(LanguageCode.FA, "بنگلادش"),
            new Translation(LanguageCode.FI, "Bangladesh"),
            new Translation(LanguageCode.FR, "Bangladesh"),
            new Translation(LanguageCode.HE, "בנגלדש"),
            new Translation(LanguageCode.HR, "Bangladeš"),
            new Translation(LanguageCode.HU, "Banglades"),
            new Translation(LanguageCode.HY, "Բանգլադեշ"),
            new Translation(LanguageCode.ID, "Bangladesh"),
            new Translation(LanguageCode.IT, "Bangladesh"),
            new Translation(LanguageCode.JA, "バングラデシュ"),
            new Translation(LanguageCode.KA, "ბანგლადეში"),
            new Translation(LanguageCode.KK, "Бангладеш"),
            new Translation(LanguageCode.KO, "방글라데시"),
            new Translation(LanguageCode.KY, "Бангладеш"),
            new Translation(LanguageCode.LT, "Bangladešas"),
            new Translation(LanguageCode.LV, "Bangladeša"),
            new Translation(LanguageCode.MK, "Бангладеш"),
            new Translation(LanguageCode.MN, "Бангладеш"),
            new Translation(LanguageCode.NB, "Bangladesh"),
            new Translation(LanguageCode.NL, "Bangladesh"),
            new Translation(LanguageCode.NN, "Bangladesh"),
            new Translation(LanguageCode.PL, "Bangladesz"),
            new Translation(LanguageCode.PT, "Bangladesh"),
            new Translation(LanguageCode.RO, "Bangladesh"),
            new Translation(LanguageCode.RU, "Бангладеш"),
            new Translation(LanguageCode.SK, "Bangladéš"),
            new Translation(LanguageCode.SL, "Bangladeš"),
            new Translation(LanguageCode.SR, "Бангладеш"),
            new Translation(LanguageCode.SV, "Bangladesh"),
            new Translation(LanguageCode.TR, "Bangladeş"),
            new Translation(LanguageCode.UK, "Бангладеш"),
            new Translation(LanguageCode.UZ, "Bangladesh"),
            new Translation(LanguageCode.ZH, "孟加拉国"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BD;
        public Alpha3Code Alpha3Code => Alpha3Code.BGD;
        public int NumericCode => 050;
        public string[] TLD => new [] { ".bd" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.MM,
            Alpha2Code.IN,
        };

        public ICurrency[] Currencies => new [] { new BdtCurrency() };
        public string[] CallingCodes => new [] { "880" };
    }
}
