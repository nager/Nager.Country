using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Georgia
    /// </summary>
    public class GeorgiaInfo : ICountryInfo
    {
        public string CommonName => "Georgia";
        public string OfficialName => "Georgia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جورجيا"),
            new Translation(LanguageCode.AZ, "Gürcüstan"),
            new Translation(LanguageCode.BE, "Грузія"),
            new Translation(LanguageCode.BG, "Грузия"),
            new Translation(LanguageCode.BS, "Gruzija"),
            new Translation(LanguageCode.CA, "Geòrgia"),
            new Translation(LanguageCode.CS, "Gruzie"),
            new Translation(LanguageCode.DA, "Georgien"),
            new Translation(LanguageCode.DE, "Georgien"),
            new Translation(LanguageCode.EL, "Γεωργία"),
            new Translation(LanguageCode.EN, "Georgia"),
            new Translation(LanguageCode.ES, "Georgia"),
            new Translation(LanguageCode.ET, "Gruusia"),
            new Translation(LanguageCode.FA, "گرجستان"),
            new Translation(LanguageCode.FI, "Georgia"),
            new Translation(LanguageCode.FR, "Géorgie"),
            new Translation(LanguageCode.HE, "גאורגיה"),
            new Translation(LanguageCode.HR, "Gruzija"),
            new Translation(LanguageCode.HU, "Grúzia"),
            new Translation(LanguageCode.HY, "Վրաստան"),
            new Translation(LanguageCode.ID, "Georgia"),
            new Translation(LanguageCode.IT, "Georgia"),
            new Translation(LanguageCode.JA, "ジョージア"),
            new Translation(LanguageCode.KA, "საქართველო"),
            new Translation(LanguageCode.KK, "Грузия"),
            new Translation(LanguageCode.KO, "그루지야"),
            new Translation(LanguageCode.KY, "Грузия"),
            new Translation(LanguageCode.LT, "Gruzija"),
            new Translation(LanguageCode.LV, "Gruzija"),
            new Translation(LanguageCode.MK, "Грузија"),
            new Translation(LanguageCode.MN, "Гүрж"),
            new Translation(LanguageCode.NB, "Georgia"),
            new Translation(LanguageCode.NL, "Georgië"),
            new Translation(LanguageCode.NN, "Georgia"),
            new Translation(LanguageCode.PL, "Gruzja"),
            new Translation(LanguageCode.PT, "Geórgia"),
            new Translation(LanguageCode.RO, "Georgia"),
            new Translation(LanguageCode.RU, "Грузия"),
            new Translation(LanguageCode.SK, "Gruzínsko"),
            new Translation(LanguageCode.SL, "Gruzija"),
            new Translation(LanguageCode.SR, "Грузија"),
            new Translation(LanguageCode.SV, "Georgien"),
            new Translation(LanguageCode.TR, "Gürcistan"),
            new Translation(LanguageCode.UK, "Грузія"),
            new Translation(LanguageCode.UZ, "Gruziya"),
            new Translation(LanguageCode.ZH, "格鲁吉亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GE;
        public Alpha3Code Alpha3Code => Alpha3Code.GEO;
        public int NumericCode => 268;
        public string[] TLD => new [] { ".ge" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AM,
            Alpha2Code.AZ,
            Alpha2Code.RU,
            Alpha2Code.TR,
        };

        public ICurrency[] Currencies => new [] { new GelCurrency() };
        public string[] CallingCodes => new [] { "995" };
    }
}
