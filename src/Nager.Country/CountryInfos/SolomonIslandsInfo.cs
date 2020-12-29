using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Solomon Islands
    /// </summary>
    public class SolomonIslandsInfo : ICountryInfo
    {
        public string CommonName => "Solomon Islands";
        public string OfficialName => "Solomon Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر سليمان"),
            new Translation(LanguageCode.AZ, "Solomon adaları"),
            new Translation(LanguageCode.BE, "Саламонавы Астравы"),
            new Translation(LanguageCode.BG, "Соломонови острови"),
            new Translation(LanguageCode.BS, "Solomonska Ostrva"),
            new Translation(LanguageCode.CA, "Salomó"),
            new Translation(LanguageCode.CS, "Šalamounovy ostrovy"),
            new Translation(LanguageCode.DA, "Salomonøerne"),
            new Translation(LanguageCode.DE, "Salomonen"),
            new Translation(LanguageCode.EL, "Νήσοι Σολομώντα"),
            new Translation(LanguageCode.EN, "Solomon Islands"),
            new Translation(LanguageCode.ES, "Islas Salomón"),
            new Translation(LanguageCode.ET, "Saalomoni Saared"),
            new Translation(LanguageCode.FA, "جزایر سلیمان"),
            new Translation(LanguageCode.FI, "Salomonsaaret"),
            new Translation(LanguageCode.FR, "Salomon"),
            new Translation(LanguageCode.HE, "איי שלמה"),
            new Translation(LanguageCode.HR, "Salomonski Otoci"),
            new Translation(LanguageCode.HU, "Salamon-szigetek"),
            new Translation(LanguageCode.HY, "Սողոմոնյան կղզիներ"),
            new Translation(LanguageCode.ID, "Kepulauan Solomon"),
            new Translation(LanguageCode.IT, "Isole Salomone"),
            new Translation(LanguageCode.JA, "ソロモン諸島"),
            new Translation(LanguageCode.KA, "სოლომონის კუნძულები"),
            new Translation(LanguageCode.KK, "Соломон аралдары"),
            new Translation(LanguageCode.KO, "솔로몬 제도"),
            new Translation(LanguageCode.KY, "Соломон аралдары"),
            new Translation(LanguageCode.LT, "Saliamono Salos"),
            new Translation(LanguageCode.LV, "Zālamana salas"),
            new Translation(LanguageCode.MK, "Соломонски Острови"),
            new Translation(LanguageCode.MN, "Соломоны Арлууд"),
            new Translation(LanguageCode.NB, "Salomonøyene"),
            new Translation(LanguageCode.NL, "Salomonseilanden"),
            new Translation(LanguageCode.NN, "Salomonøyane"),
            new Translation(LanguageCode.PL, "Wyspy Salomona"),
            new Translation(LanguageCode.PT, "Ilhas Salomão"),
            new Translation(LanguageCode.RO, "Insulele Solomon"),
            new Translation(LanguageCode.RU, "Соломоновы Острова"),
            new Translation(LanguageCode.SK, "Šalamúnove ostrovy"),
            new Translation(LanguageCode.SL, "Salomonovi otoki"),
            new Translation(LanguageCode.SR, "Соломонска Острва"),
            new Translation(LanguageCode.SV, "Salomonöarna"),
            new Translation(LanguageCode.TR, "Solomon Adaları"),
            new Translation(LanguageCode.UK, "Соломонові Острови"),
            new Translation(LanguageCode.UZ, "Solomon orollari"),
            new Translation(LanguageCode.ZH, "所罗门群岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SB;
        public Alpha3Code Alpha3Code => Alpha3Code.SLB;
        public int NumericCode => 090;
        public string[] TLD => new [] { ".sb" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Melanesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new SbdCurrency() };
        public string[] CallingCodes => new [] { "677" };
    }
}
