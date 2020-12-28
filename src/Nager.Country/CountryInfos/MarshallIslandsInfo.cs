using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Marshall Islands
    /// </summary>
    public class MarshallIslandsInfo : ICountryInfo
    {
        public string CommonName => "Marshall Islands";
        public string OfficialName => "Republic of the Marshall Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر مارشال"),
            new Translation(LanguageCode.AZ, "Marşal adaları"),
            new Translation(LanguageCode.BE, "Маршалавы Астравы"),
            new Translation(LanguageCode.BG, "Маршалови острови"),
            new Translation(LanguageCode.BS, "Maršalova Ostrva"),
            new Translation(LanguageCode.CA, "Marshall, illes"),
            new Translation(LanguageCode.CS, "Marshallovy ostrovy"),
            new Translation(LanguageCode.DA, "Marshalløerne"),
            new Translation(LanguageCode.DE, "Marshallinseln"),
            new Translation(LanguageCode.EL, "Νήσοι Μάρσαλ"),
            new Translation(LanguageCode.EN, "Marshall Islands"),
            new Translation(LanguageCode.ES, "Islas Marshall"),
            new Translation(LanguageCode.ET, "Marshalli saared"),
            new Translation(LanguageCode.FA, "جزایر مارشال"),
            new Translation(LanguageCode.FI, "Marshallinsaaret"),
            new Translation(LanguageCode.FR, "Îles Marshall"),
            new Translation(LanguageCode.HE, "איי מרשל"),
            new Translation(LanguageCode.HR, "Maršalovi Otoci"),
            new Translation(LanguageCode.HU, "Marshall-szigetek"),
            new Translation(LanguageCode.HY, "Մարշալյան կղզիներ"),
            new Translation(LanguageCode.ID, "Kepulauan Marshall"),
            new Translation(LanguageCode.IT, "Isole Marshall"),
            new Translation(LanguageCode.JA, "マーシャル諸島"),
            new Translation(LanguageCode.KA, "მარშალის კუნძულები"),
            new Translation(LanguageCode.KK, "Маршалл аралдары"),
            new Translation(LanguageCode.KO, "마샬 군도"),
            new Translation(LanguageCode.KY, "Маршалл аралдары"),
            new Translation(LanguageCode.LT, "Maršalo Salos"),
            new Translation(LanguageCode.LV, "Māršala salas"),
            new Translation(LanguageCode.MK, "Маршалски Острови"),
            new Translation(LanguageCode.MN, "Маршаллын арлууд"),
            new Translation(LanguageCode.NB, "Marshalløyene"),
            new Translation(LanguageCode.NL, "Marshalleilanden"),
            new Translation(LanguageCode.NN, "Marshalløyane"),
            new Translation(LanguageCode.PL, "Wyspy Marshalla"),
            new Translation(LanguageCode.PT, "Ilhas Marshall"),
            new Translation(LanguageCode.RO, "Insulele Marshall"),
            new Translation(LanguageCode.RU, "Маршалловы Острова"),
            new Translation(LanguageCode.SK, "Marshallove ostrovy"),
            new Translation(LanguageCode.SL, "Marshallovi otoki"),
            new Translation(LanguageCode.SR, "Маршалска Острва"),
            new Translation(LanguageCode.SV, "Marshallöarna"),
            new Translation(LanguageCode.TR, "Marshall Adaları"),
            new Translation(LanguageCode.UK, "Маршаллові Острови"),
            new Translation(LanguageCode.UZ, "Marshall orollari"),
            new Translation(LanguageCode.ZH, "马绍尔群岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MH;
        public Alpha3Code Alpha3Code => Alpha3Code.MHL;
        public int NumericCode => 584;
        public string[] TLD => new [] { ".mh" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Micronesia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "692" };
    }
}
