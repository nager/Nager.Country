namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Philippines
    /// </summary>
    public class PhilippinesInfo : ICountryInfo
    {
        public string CommonName => "Philippines";
        public string OfficialName => "Republic of the Philippines";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الفلبين"),
            new Translation(LanguageCode.AZ, "Filippin"),
            new Translation(LanguageCode.BE, "Філіпіны"),
            new Translation(LanguageCode.BG, "Филипини"),
            new Translation(LanguageCode.BS, "Filipini"),
            new Translation(LanguageCode.CA, "Filipines"),
            new Translation(LanguageCode.CS, "Filipíny"),
            new Translation(LanguageCode.DA, "Filippinerne"),
            new Translation(LanguageCode.DE, "Philippinen"),
            new Translation(LanguageCode.EL, "Φιλιππίνες"),
            new Translation(LanguageCode.EN, "Philippines"),
            new Translation(LanguageCode.ES, "Filipinas"),
            new Translation(LanguageCode.ET, "Filipiinid"),
            new Translation(LanguageCode.FA, "فیلیپین"),
            new Translation(LanguageCode.FI, "Filippiinit"),
            new Translation(LanguageCode.FR, "Philippines"),
            new Translation(LanguageCode.HE, "הפיליפינים"),
            new Translation(LanguageCode.HR, "Filipini"),
            new Translation(LanguageCode.HU, "Fülöp-szigetek"),
            new Translation(LanguageCode.HY, "Ֆիլիպիններ"),
            new Translation(LanguageCode.ID, "Filipina"),
            new Translation(LanguageCode.IT, "Filippine"),
            new Translation(LanguageCode.JA, "フィリピン"),
            new Translation(LanguageCode.KA, "ფილიპინები"),
            new Translation(LanguageCode.KK, "Филиппин"),
            new Translation(LanguageCode.KO, "필리핀 제도"),
            new Translation(LanguageCode.KY, "Филлипин"),
            new Translation(LanguageCode.LT, "Filipinai"),
            new Translation(LanguageCode.LV, "Filipīnas"),
            new Translation(LanguageCode.MK, "Филипини"),
            new Translation(LanguageCode.MN, "Филиппин"),
            new Translation(LanguageCode.NB, "Filippinene"),
            new Translation(LanguageCode.NL, "Filipijnen"),
            new Translation(LanguageCode.NN, "Filippinane"),
            new Translation(LanguageCode.PL, "Filipiny"),
            new Translation(LanguageCode.PT, "Filipinas"),
            new Translation(LanguageCode.RO, "Filipine"),
            new Translation(LanguageCode.RU, "Филиппины"),
            new Translation(LanguageCode.SK, "Filipíny"),
            new Translation(LanguageCode.SL, "Filipini"),
            new Translation(LanguageCode.SR, "Филипини"),
            new Translation(LanguageCode.SV, "Filippinerna"),
            new Translation(LanguageCode.TR, "Filipinler"),
            new Translation(LanguageCode.UK, "Філіппіни"),
            new Translation(LanguageCode.UZ, "Filippin"),
            new Translation(LanguageCode.ZH, "菲律宾"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.PH;
        public Alpha3Code Alpha3Code => Alpha3Code.PHL;
        public int NumericCode => 608;
        public string[] TLD => new [] { ".ph" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "PHP" };
        public string[] CallingCodes => new [] { "63" };
    }
}
