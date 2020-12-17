namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ethiopia
    /// </summary>
    public class EthiopiaInfo : ICountryInfo
    {
        public string CommonName => "Ethiopia";
        public string OfficialName => "Federal Democratic Republic of Ethiopia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "إثيوبيا"),
            new Translation(LanguageCode.AZ, "Efiopiya"),
            new Translation(LanguageCode.BE, "Эфіопія"),
            new Translation(LanguageCode.BG, "Етиопия"),
            new Translation(LanguageCode.BS, "Etiopija"),
            new Translation(LanguageCode.CA, "Etiòpia"),
            new Translation(LanguageCode.CS, "Etiopie"),
            new Translation(LanguageCode.DA, "Etiopien"),
            new Translation(LanguageCode.DE, "Äthiopien"),
            new Translation(LanguageCode.EL, "Αιθιοπία"),
            new Translation(LanguageCode.EN, "Ethiopia"),
            new Translation(LanguageCode.ES, "Etiopía"),
            new Translation(LanguageCode.ET, "Etioopia"),
            new Translation(LanguageCode.FA, "اتیوپی"),
            new Translation(LanguageCode.FI, "Etiopia"),
            new Translation(LanguageCode.FR, "Éthiopie"),
            new Translation(LanguageCode.HE, "אתיופיה"),
            new Translation(LanguageCode.HR, "Etiopija"),
            new Translation(LanguageCode.HU, "Etiópia"),
            new Translation(LanguageCode.HY, "Եթովպիա"),
            new Translation(LanguageCode.ID, "Ethiopia"),
            new Translation(LanguageCode.IT, "Etiopia"),
            new Translation(LanguageCode.JA, "エチオピア"),
            new Translation(LanguageCode.KA, "ეთიოპია"),
            new Translation(LanguageCode.KK, "Эфиопия"),
            new Translation(LanguageCode.KO, "에티오피아"),
            new Translation(LanguageCode.KY, "Эфиопия"),
            new Translation(LanguageCode.LT, "Etiopija"),
            new Translation(LanguageCode.LV, "Etiopija"),
            new Translation(LanguageCode.MK, "Етиопија"),
            new Translation(LanguageCode.MN, "Этиоп"),
            new Translation(LanguageCode.NB, "Etiopia"),
            new Translation(LanguageCode.NL, "Ethiopië"),
            new Translation(LanguageCode.NN, "Etiopia"),
            new Translation(LanguageCode.PL, "Etiopia"),
            new Translation(LanguageCode.PT, "Etiópia"),
            new Translation(LanguageCode.RO, "Etiopia"),
            new Translation(LanguageCode.RU, "Эфиопия"),
            new Translation(LanguageCode.SK, "Etiópia"),
            new Translation(LanguageCode.SL, "Etiopija"),
            new Translation(LanguageCode.SR, "Етиопија"),
            new Translation(LanguageCode.SV, "Etiopien"),
            new Translation(LanguageCode.TR, "Etiyopya"),
            new Translation(LanguageCode.UK, "Ефіопія"),
            new Translation(LanguageCode.UZ, "Efiopiya"),
            new Translation(LanguageCode.ZH, "衣索比亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.ET;
        public Alpha3Code Alpha3Code => Alpha3Code.ETH;
        public int NumericCode => 231;
        public string[] TLD => new [] { ".et" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.DJ,
            Alpha2Code.ER,
            Alpha2Code.KE,
            Alpha2Code.SO,
            Alpha2Code.SS,
            Alpha2Code.SD,
        };

        public string[] Currencies => new [] { "ETB" };
        public string[] CallingCodes => new [] { "251" };
    }
}
