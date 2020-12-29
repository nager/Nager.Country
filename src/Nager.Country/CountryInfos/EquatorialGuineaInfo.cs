using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Equatorial Guinea
    /// </summary>
    public class EquatorialGuineaInfo : ICountryInfo
    {
        public string CommonName => "Equatorial Guinea";
        public string OfficialName => "Republic of Equatorial Guinea";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "غينيا الاستوائية"),
            new Translation(LanguageCode.AZ, "Ekvatorial Qvineya"),
            new Translation(LanguageCode.BE, "Экватарыяльная Гвінея"),
            new Translation(LanguageCode.BG, "Екваториална Гвинея"),
            new Translation(LanguageCode.BS, "Ekvatorijalna Gvineja"),
            new Translation(LanguageCode.CA, "Guinea Equatorial"),
            new Translation(LanguageCode.CS, "Rovníková Guinea"),
            new Translation(LanguageCode.DA, "Ækvatorialguinea"),
            new Translation(LanguageCode.DE, "Äquatorialguinea"),
            new Translation(LanguageCode.EL, "Ισημερινή-Γουινέα"),
            new Translation(LanguageCode.EN, "Equatorial Guinea"),
            new Translation(LanguageCode.ES, "Guinea Ecuatorial"),
            new Translation(LanguageCode.ET, "Ekvatoriaal-Guinea"),
            new Translation(LanguageCode.FA, "گینهٔ استوایی"),
            new Translation(LanguageCode.FI, "Päiväntasaajan Guinea"),
            new Translation(LanguageCode.FR, "Guinée équatoriale"),
            new Translation(LanguageCode.HE, "גינאה המשוונית"),
            new Translation(LanguageCode.HR, "Ekvatorska Gvineja"),
            new Translation(LanguageCode.HU, "Egyenlítői-Guinea"),
            new Translation(LanguageCode.HY, "Հասարակածային Գվինեա"),
            new Translation(LanguageCode.ID, "Guinea Khatulistiwa"),
            new Translation(LanguageCode.IT, "Guinea Equatoriale"),
            new Translation(LanguageCode.JA, "赤道ギニア"),
            new Translation(LanguageCode.KA, "ეკვატორული გვინეა"),
            new Translation(LanguageCode.KK, "Экваторлық Гвинея"),
            new Translation(LanguageCode.KO, "적도 기니"),
            new Translation(LanguageCode.KY, "Экваториалдык Гвинея"),
            new Translation(LanguageCode.LT, "Pusiaujo Gvinėja"),
            new Translation(LanguageCode.LV, "Ekvatoriālā Gvineja"),
            new Translation(LanguageCode.MK, "Екваторска Гвинеја"),
            new Translation(LanguageCode.MN, "Экваторын Гвиней"),
            new Translation(LanguageCode.NB, "Ekvatorial-Guinea"),
            new Translation(LanguageCode.NL, "Equatoriaal-Guinea"),
            new Translation(LanguageCode.NN, "Ekvatorial-Guinea"),
            new Translation(LanguageCode.PL, "Gwinea Równikowa"),
            new Translation(LanguageCode.PT, "Guiné Equatorial"),
            new Translation(LanguageCode.RO, "Guineea Ecuatorială"),
            new Translation(LanguageCode.RU, "Экваториальная Гвинея"),
            new Translation(LanguageCode.SK, "Rovníková Guinea"),
            new Translation(LanguageCode.SL, "Ekvatorialna Gvineja"),
            new Translation(LanguageCode.SR, "Екваторијална Гвинеја"),
            new Translation(LanguageCode.SV, "Ekvatorialguinea"),
            new Translation(LanguageCode.TR, "Ekvator Ginesi"),
            new Translation(LanguageCode.UK, "Екваторіальна Гвінея"),
            new Translation(LanguageCode.UZ, "Ekvatorial Gvineya"),
            new Translation(LanguageCode.ZH, "赤道几内亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GQ;
        public Alpha3Code Alpha3Code => Alpha3Code.GNQ;
        public int NumericCode => 226;
        public string[] TLD => new [] { ".gq" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CM,
            Alpha2Code.GA,
        };

        public ICurrency[] Currencies => new [] { new XafCurrency() };
        public string[] CallingCodes => new [] { "240" };
    }
}
