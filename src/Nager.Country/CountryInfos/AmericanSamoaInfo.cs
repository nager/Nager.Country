using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// American Samoa
    /// </summary>
    public class AmericanSamoaInfo : ICountryInfo
    {
        public string CommonName => "American Samoa";
        public string OfficialName => "American Samoa";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ساموا الأمريكية"),
            new Translation(LanguageCode.AZ, "Amerika Samoası"),
            new Translation(LanguageCode.BE, "Амерыканскае Самоа"),
            new Translation(LanguageCode.BG, "Американска Самоа"),
            new Translation(LanguageCode.BS, "Američka Samoa"),
            new Translation(LanguageCode.CA, "Samoa Nord-americana"),
            new Translation(LanguageCode.CS, "Americká Samoa"),
            new Translation(LanguageCode.DA, "Amerikansk Samoa"),
            new Translation(LanguageCode.DE, "Amerikanisch-Samoa"),
            new Translation(LanguageCode.EL, "Αμερικανική Σαμόα"),
            new Translation(LanguageCode.EN, "American Samoa"),
            new Translation(LanguageCode.ES, "Samoa Americana"),
            new Translation(LanguageCode.ET, "Ameerika Samoa"),
            new Translation(LanguageCode.FA, "ساموآی امریکا"),
            new Translation(LanguageCode.FI, "Amerikan Samoa"),
            new Translation(LanguageCode.FR, "Samoa américaine"),
            new Translation(LanguageCode.HE, "סמואה האמריקנית"),
            new Translation(LanguageCode.HR, "Američka Samoa"),
            new Translation(LanguageCode.HU, "Amerikai Szamoa"),
            new Translation(LanguageCode.HY, "Ամերիկյան Սամոա"),
            new Translation(LanguageCode.ID, "Amerika Serikat"),
            new Translation(LanguageCode.IT, "Samoa Americane"),
            new Translation(LanguageCode.JA, "アメリカ領サモア"),
            new Translation(LanguageCode.KA, "ამერიკის სამოა"),
            new Translation(LanguageCode.KK, "Америкалық Самоа"),
            new Translation(LanguageCode.KO, "아메리칸 사모아"),
            new Translation(LanguageCode.KY, "Америка Самоасы"),
            new Translation(LanguageCode.LT, "Amerikos Samoa"),
            new Translation(LanguageCode.LV, "ASV Samoa"),
            new Translation(LanguageCode.MK, "Американска Самоа"),
            new Translation(LanguageCode.MN, "Америкийн Самоа"),
            new Translation(LanguageCode.NB, "Amerikansk Samoa"),
            new Translation(LanguageCode.NL, "Amerikaans-Samoa"),
            new Translation(LanguageCode.NN, "Amerikansk Samoa"),
            new Translation(LanguageCode.PL, "Samoa Amerykańskie"),
            new Translation(LanguageCode.PT, "Samoa Americana"),
            new Translation(LanguageCode.RO, "Samoa Americană"),
            new Translation(LanguageCode.RU, "Американское Самоа"),
            new Translation(LanguageCode.SK, "Americká Samoa"),
            new Translation(LanguageCode.SL, "Ameriška Samoa"),
            new Translation(LanguageCode.SR, "Америчка Самоа"),
            new Translation(LanguageCode.SV, "Amerikanska Samoa"),
            new Translation(LanguageCode.TR, "Amerikan Samoası"),
            new Translation(LanguageCode.UK, "Американське Самоа"),
            new Translation(LanguageCode.UZ, "Amerika Samoasi"),
            new Translation(LanguageCode.ZH, "美属萨摩亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AS;
        public Alpha3Code Alpha3Code => Alpha3Code.ASM;
        public int NumericCode => 016;
        public string[] TLD => new [] { ".as" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1684" };
    }
}
