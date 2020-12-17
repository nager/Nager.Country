namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Faroe Islands
    /// </summary>
    public class FaroeIslandsInfo : ICountryInfo
    {
        public string CommonName => "Faroe Islands";
        public string OfficialName => "Faroe Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر فارو"),
            new Translation(LanguageCode.AZ, "Farer adaları"),
            new Translation(LanguageCode.BE, "Фарэрскія астравы"),
            new Translation(LanguageCode.BG, "Фарьорски острови"),
            new Translation(LanguageCode.BS, "Farska Ostrva"),
            new Translation(LanguageCode.CA, "Fèroe, illes"),
            new Translation(LanguageCode.CS, "Faerské ostrovy"),
            new Translation(LanguageCode.DA, "Færøerne"),
            new Translation(LanguageCode.DE, "Färöer"),
            new Translation(LanguageCode.EL, "Νήσοι Φερόες"),
            new Translation(LanguageCode.EN, "Faroe Islands"),
            new Translation(LanguageCode.ES, "Islas Feroe"),
            new Translation(LanguageCode.ET, "Fääri saared"),
            new Translation(LanguageCode.FA, "جزایر فارو"),
            new Translation(LanguageCode.FI, "Färsaaret"),
            new Translation(LanguageCode.FR, "Îles Féroé"),
            new Translation(LanguageCode.HE, "איי פארו"),
            new Translation(LanguageCode.HR, "Farski otoci"),
            new Translation(LanguageCode.HU, "Feröer"),
            new Translation(LanguageCode.HY, "Ֆարերյան կղզիներ"),
            new Translation(LanguageCode.ID, "Kepulauan Faroe"),
            new Translation(LanguageCode.IT, "Isole Fær Øer"),
            new Translation(LanguageCode.JA, "フェロー諸島"),
            new Translation(LanguageCode.KA, "ფარერის კუნძულები"),
            new Translation(LanguageCode.KK, "Фарер аралдары"),
            new Translation(LanguageCode.KO, "페로 제도"),
            new Translation(LanguageCode.KY, "Фарер аралдары"),
            new Translation(LanguageCode.LT, "Farerų Salos"),
            new Translation(LanguageCode.LV, "Fēru salas"),
            new Translation(LanguageCode.MK, "Фарски Острови"),
            new Translation(LanguageCode.MN, "Фароэ Арлууд"),
            new Translation(LanguageCode.NB, "Færøyene"),
            new Translation(LanguageCode.NL, "Faeröer"),
            new Translation(LanguageCode.NN, "Færøyane"),
            new Translation(LanguageCode.PL, "Wyspy Owcze"),
            new Translation(LanguageCode.PT, "Ilhas Faroe"),
            new Translation(LanguageCode.RO, "Insulele Feroe"),
            new Translation(LanguageCode.RU, "Фареры"),
            new Translation(LanguageCode.SK, "Faerské ostrovy"),
            new Translation(LanguageCode.SL, "Ferski otoki"),
            new Translation(LanguageCode.SR, "Фарска Острва"),
            new Translation(LanguageCode.SV, "Färöarna"),
            new Translation(LanguageCode.TR, "Faroe Adaları"),
            new Translation(LanguageCode.UK, "Фарерські острови"),
            new Translation(LanguageCode.UZ, "Farer orollari"),
            new Translation(LanguageCode.ZH, "法罗群岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.FO;
        public Alpha3Code Alpha3Code => Alpha3Code.FRO;
        public int NumericCode => 234;
        public string[] TLD => new [] { ".fo" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "DKK" };
        public string[] CallingCodes => new [] { "298" };
    }
}
