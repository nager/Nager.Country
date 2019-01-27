namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Cook Islands
    /// </summary>
    public class CookIslandsInfo : ICountryInfo
    {
        public string CommonName => "Cook Islands";
        public string OfficialName => "Cook Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر كوك"),
            new Translation(LanguageCode.AZ, "Kuk adaları"),
            new Translation(LanguageCode.BE, "Астравы Кука"),
            new Translation(LanguageCode.BG, "острови Кук"),
            new Translation(LanguageCode.BS, "Kukova Ostrva"),
            new Translation(LanguageCode.CA, "Cook, illes"),
            new Translation(LanguageCode.CS, "Cookovy ostrovy"),
            new Translation(LanguageCode.DA, "Cookøerne"),
            new Translation(LanguageCode.DE, "Cookinseln"),
            new Translation(LanguageCode.EL, "Νήσοι Κουκ"),
            new Translation(LanguageCode.EN, "Cook Islands"),
            new Translation(LanguageCode.ES, "Islas Cook"),
            new Translation(LanguageCode.ET, "Cooki saared"),
            new Translation(LanguageCode.FA, "جزایر کوک"),
            new Translation(LanguageCode.FI, "Cookinsaaret"),
            new Translation(LanguageCode.FR, "Îles Cook"),
            new Translation(LanguageCode.HE, "איי קוק"),
            new Translation(LanguageCode.HR, "Cookovi Otoci"),
            new Translation(LanguageCode.HU, "Cook-szigetek"),
            new Translation(LanguageCode.HY, "Կուկի կղզիներ"),
            new Translation(LanguageCode.ID, "Kepulauan Cook"),
            new Translation(LanguageCode.IT, "Isole Cook"),
            new Translation(LanguageCode.JA, "クック諸島"),
            new Translation(LanguageCode.KA, "კუკის კუნძულები"),
            new Translation(LanguageCode.KK, "Кук аралдары"),
            new Translation(LanguageCode.KO, "쿡 제도"),
            new Translation(LanguageCode.KY, "Кук аралдары"),
            new Translation(LanguageCode.LT, "Kuko Salos"),
            new Translation(LanguageCode.LV, "Kuka salas"),
            new Translation(LanguageCode.MK, "Кукови Острови"),
            new Translation(LanguageCode.MN, "Күүкийн арлууд"),
            new Translation(LanguageCode.NB, "Cookøyene"),
            new Translation(LanguageCode.NL, "Cookeilanden"),
            new Translation(LanguageCode.NN, "Cookøyane"),
            new Translation(LanguageCode.PL, "Wyspy Cooka"),
            new Translation(LanguageCode.PT, "Ilhas Cook"),
            new Translation(LanguageCode.RO, "Insulele Cook"),
            new Translation(LanguageCode.RU, "Острова Кука"),
            new Translation(LanguageCode.SK, "Cookove ostrovy"),
            new Translation(LanguageCode.SL, "Cookovi otoki"),
            new Translation(LanguageCode.SR, "Кукова Острва"),
            new Translation(LanguageCode.SV, "Cooköarna"),
            new Translation(LanguageCode.TR, "Cook Adaları"),
            new Translation(LanguageCode.UK, "Острови Кука"),
            new Translation(LanguageCode.UZ, "Kuk orollari"),
            new Translation(LanguageCode.ZH, "库克群岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CK;
        public Alpha3Code Alpha3Code => Alpha3Code.COK;
        public int NumericCode => 184;
        public string[] TLD => new [] { ".ck" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "NZD" };
        public string[] CallingCodes => new [] { "682" };
    }
}
