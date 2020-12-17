namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Eritrea
    /// </summary>
    public class EritreaInfo : ICountryInfo
    {
        public string CommonName => "Eritrea";
        public string OfficialName => "State of Eritrea";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "إريتريا"),
            new Translation(LanguageCode.AZ, "Eritreya"),
            new Translation(LanguageCode.BE, "Эрытрэя"),
            new Translation(LanguageCode.BG, "Еритрея"),
            new Translation(LanguageCode.BS, "Eritreja"),
            new Translation(LanguageCode.CA, "Eritrea"),
            new Translation(LanguageCode.CS, "Eritrea"),
            new Translation(LanguageCode.DA, "Eritrea"),
            new Translation(LanguageCode.DE, "Eritrea"),
            new Translation(LanguageCode.EL, "Κράτος της Ερυθραίας"),
            new Translation(LanguageCode.EN, "Eritrea"),
            new Translation(LanguageCode.ES, "Eritrea"),
            new Translation(LanguageCode.ET, "Eritrea"),
            new Translation(LanguageCode.FA, "اریتره"),
            new Translation(LanguageCode.FI, "Eritrea"),
            new Translation(LanguageCode.FR, "Érythrée"),
            new Translation(LanguageCode.HE, "אריתריאה"),
            new Translation(LanguageCode.HR, "Eritreja"),
            new Translation(LanguageCode.HU, "Eritrea"),
            new Translation(LanguageCode.HY, "Էրիթրեա"),
            new Translation(LanguageCode.ID, "Eritrea"),
            new Translation(LanguageCode.IT, "Eritrea"),
            new Translation(LanguageCode.JA, "エリトリア"),
            new Translation(LanguageCode.KA, "ერიტრეა"),
            new Translation(LanguageCode.KK, "Эритрея"),
            new Translation(LanguageCode.KO, "에리트레아"),
            new Translation(LanguageCode.KY, "Эритрея"),
            new Translation(LanguageCode.LT, "Eritrėja"),
            new Translation(LanguageCode.LV, "Eritreja"),
            new Translation(LanguageCode.MK, "Еритреја"),
            new Translation(LanguageCode.MN, "Эритри"),
            new Translation(LanguageCode.NB, "Eritrea"),
            new Translation(LanguageCode.NL, "Eritrea"),
            new Translation(LanguageCode.NN, "Eritrea"),
            new Translation(LanguageCode.PL, "Erytrea"),
            new Translation(LanguageCode.PT, "Eritreia"),
            new Translation(LanguageCode.RO, "Eritreea"),
            new Translation(LanguageCode.RU, "Эритрея"),
            new Translation(LanguageCode.SK, "Eritrea"),
            new Translation(LanguageCode.SL, "Eritreja"),
            new Translation(LanguageCode.SR, "Еритреја"),
            new Translation(LanguageCode.SV, "Eritrea"),
            new Translation(LanguageCode.TR, "Eritre"),
            new Translation(LanguageCode.UK, "Еритрея"),
            new Translation(LanguageCode.UZ, "Eritreya"),
            new Translation(LanguageCode.ZH, "厄立特里亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.ER;
        public Alpha3Code Alpha3Code => Alpha3Code.ERI;
        public int NumericCode => 232;
        public string[] TLD => new [] { ".er" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.DJ,
            Alpha2Code.ET,
            Alpha2Code.SD,
        };

        public string[] Currencies => new [] { "ERN" };
        public string[] CallingCodes => new [] { "291" };
    }
}
