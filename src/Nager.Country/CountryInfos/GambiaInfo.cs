using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Gambia
    /// </summary>
    public class GambiaInfo : ICountryInfo
    {
        public string CommonName => "Gambia";
        public string OfficialName => "Republic of the Gambia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "غامبيا"),
            new Translation(LanguageCode.AZ, "Qambiya"),
            new Translation(LanguageCode.BE, "Гамбія"),
            new Translation(LanguageCode.BG, "Гамбия"),
            new Translation(LanguageCode.BS, "Gambija"),
            new Translation(LanguageCode.CA, "Gàmbia"),
            new Translation(LanguageCode.CS, "Gambie"),
            new Translation(LanguageCode.DA, "Gambia"),
            new Translation(LanguageCode.DE, "Gambia"),
            new Translation(LanguageCode.EL, "Γκάμπια"),
            new Translation(LanguageCode.EN, "Gambia"),
            new Translation(LanguageCode.ES, "Gambia"),
            new Translation(LanguageCode.ET, "Gambia"),
            new Translation(LanguageCode.FA, "گامبیا"),
            new Translation(LanguageCode.FI, "Gambia"),
            new Translation(LanguageCode.FR, "Gambie"),
            new Translation(LanguageCode.HE, "גמביה"),
            new Translation(LanguageCode.HR, "Gambija"),
            new Translation(LanguageCode.HU, "Gambia"),
            new Translation(LanguageCode.HY, "Գամբիա"),
            new Translation(LanguageCode.ID, "Gambia"),
            new Translation(LanguageCode.IT, "Gambia"),
            new Translation(LanguageCode.JA, "ガンビア"),
            new Translation(LanguageCode.KA, "გამბია"),
            new Translation(LanguageCode.KK, "Гамбия"),
            new Translation(LanguageCode.KO, "감비아"),
            new Translation(LanguageCode.KY, "Гамбия"),
            new Translation(LanguageCode.LT, "Gambija"),
            new Translation(LanguageCode.LV, "Gambija"),
            new Translation(LanguageCode.MK, "Гамбија"),
            new Translation(LanguageCode.MN, "Гамби"),
            new Translation(LanguageCode.NB, "Gambia"),
            new Translation(LanguageCode.NL, "Gambia"),
            new Translation(LanguageCode.NN, "Gambia"),
            new Translation(LanguageCode.PL, "Gambia"),
            new Translation(LanguageCode.PT, "Gâmbia"),
            new Translation(LanguageCode.RO, "Gambia"),
            new Translation(LanguageCode.RU, "Гамбия"),
            new Translation(LanguageCode.SK, "Gambia"),
            new Translation(LanguageCode.SL, "Gambija"),
            new Translation(LanguageCode.SR, "Гамбија"),
            new Translation(LanguageCode.SV, "Gambia"),
            new Translation(LanguageCode.TR, "Gambiya"),
            new Translation(LanguageCode.UK, "Гамбія"),
            new Translation(LanguageCode.UZ, "Gambiya"),
            new Translation(LanguageCode.ZH, "冈比亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GM;
        public Alpha3Code Alpha3Code => Alpha3Code.GMB;
        public int NumericCode => 270;
        public string[] TLD => new [] { ".gm" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.SN,
        };

        public ICurrency[] Currencies => new [] { new GmdCurrency() };
        public string[] CallingCodes => new [] { "220" };
    }
}
