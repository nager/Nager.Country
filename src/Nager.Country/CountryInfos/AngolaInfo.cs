using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Angola
    /// </summary>
    public class AngolaInfo : ICountryInfo
    {
        public string CommonName => "Angola";
        public string OfficialName => "Republic of Angola";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أنغولا"),
            new Translation(LanguageCode.AZ, "Anqola"),
            new Translation(LanguageCode.BE, "Ангола"),
            new Translation(LanguageCode.BG, "Ангола"),
            new Translation(LanguageCode.BS, "Angola"),
            new Translation(LanguageCode.CA, "Angola"),
            new Translation(LanguageCode.CS, "Angola"),
            new Translation(LanguageCode.DA, "Angola"),
            new Translation(LanguageCode.DE, "Angola"),
            new Translation(LanguageCode.EL, "Ανγκόλα"),
            new Translation(LanguageCode.EN, "Angola"),
            new Translation(LanguageCode.ES, "Angola"),
            new Translation(LanguageCode.ET, "Angola"),
            new Translation(LanguageCode.FA, "آنگولا"),
            new Translation(LanguageCode.FI, "Angola"),
            new Translation(LanguageCode.FR, "Angola"),
            new Translation(LanguageCode.HE, "אנגולה"),
            new Translation(LanguageCode.HR, "Angola"),
            new Translation(LanguageCode.HU, "Angola"),
            new Translation(LanguageCode.HY, "Անգոլա"),
            new Translation(LanguageCode.ID, "Angola"),
            new Translation(LanguageCode.IT, "Angola"),
            new Translation(LanguageCode.JA, "アンゴラ"),
            new Translation(LanguageCode.KA, "ანგოლა"),
            new Translation(LanguageCode.KK, "Ангола"),
            new Translation(LanguageCode.KO, "앙골라"),
            new Translation(LanguageCode.KY, "Ангола"),
            new Translation(LanguageCode.LT, "Angola"),
            new Translation(LanguageCode.LV, "Angola"),
            new Translation(LanguageCode.MK, "Ангола"),
            new Translation(LanguageCode.MN, "Ангол"),
            new Translation(LanguageCode.NB, "Angola"),
            new Translation(LanguageCode.NL, "Angola"),
            new Translation(LanguageCode.NN, "Angola"),
            new Translation(LanguageCode.PL, "Angola"),
            new Translation(LanguageCode.PT, "Angola"),
            new Translation(LanguageCode.RO, "Angola"),
            new Translation(LanguageCode.RU, "Ангола"),
            new Translation(LanguageCode.SK, "Angola"),
            new Translation(LanguageCode.SL, "Angola"),
            new Translation(LanguageCode.SR, "Ангола"),
            new Translation(LanguageCode.SV, "Angola"),
            new Translation(LanguageCode.TR, "Angola"),
            new Translation(LanguageCode.UK, "Ангола"),
            new Translation(LanguageCode.UZ, "Angola"),
            new Translation(LanguageCode.ZH, "安哥拉"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AO;
        public Alpha3Code Alpha3Code => Alpha3Code.AGO;
        public int NumericCode => 024;
        public string[] TLD => new [] { ".ao" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CG,
            Alpha2Code.CD,
            Alpha2Code.ZM,
            Alpha2Code.NA,
        };

        public ICurrency[] Currencies => new [] { new AoaCurrency() };
        public string[] CallingCodes => new [] { "244" };
    }
}
