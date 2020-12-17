namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Martinique
    /// </summary>
    public class MartiniqueInfo : ICountryInfo
    {
        public string CommonName => "Martinique";
        public string OfficialName => "Martinique";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "مارتينيك"),
            new Translation(LanguageCode.AZ, "Martinik"),
            new Translation(LanguageCode.BE, "Марцініка"),
            new Translation(LanguageCode.BG, "Мартиника"),
            new Translation(LanguageCode.BS, "Martinik"),
            new Translation(LanguageCode.CA, "Martinica"),
            new Translation(LanguageCode.CS, "Martinik"),
            new Translation(LanguageCode.DA, "Martinique"),
            new Translation(LanguageCode.DE, "Martinique"),
            new Translation(LanguageCode.EL, "Μαρτινίκα"),
            new Translation(LanguageCode.EN, "Martinique"),
            new Translation(LanguageCode.ES, "Martinique"),
            new Translation(LanguageCode.ET, "Martinique"),
            new Translation(LanguageCode.FA, "مارتینیک"),
            new Translation(LanguageCode.FI, "Martinique"),
            new Translation(LanguageCode.FR, "Martinique"),
            new Translation(LanguageCode.HE, "מרטיניק"),
            new Translation(LanguageCode.HR, "Martinique"),
            new Translation(LanguageCode.HU, "Martinique"),
            new Translation(LanguageCode.HY, "Մարտինիկա"),
            new Translation(LanguageCode.ID, "Martinik"),
            new Translation(LanguageCode.IT, "Martinica"),
            new Translation(LanguageCode.JA, "マルティニーク"),
            new Translation(LanguageCode.KA, "მარტინიკა"),
            new Translation(LanguageCode.KK, "Мартиника"),
            new Translation(LanguageCode.KO, "마르티니크"),
            new Translation(LanguageCode.KY, "Мартиника"),
            new Translation(LanguageCode.LT, "Martinika"),
            new Translation(LanguageCode.LV, "Martinika"),
            new Translation(LanguageCode.MK, "Мартиник"),
            new Translation(LanguageCode.MN, "Мартиник"),
            new Translation(LanguageCode.NB, "Martinique"),
            new Translation(LanguageCode.NL, "Martinique"),
            new Translation(LanguageCode.NN, "Martinique"),
            new Translation(LanguageCode.PL, "Martynika"),
            new Translation(LanguageCode.PT, "Martinica"),
            new Translation(LanguageCode.RO, "Martinica"),
            new Translation(LanguageCode.RU, "Мартиника"),
            new Translation(LanguageCode.SK, "Martinik"),
            new Translation(LanguageCode.SL, "Martinik"),
            new Translation(LanguageCode.SR, "Мартиник"),
            new Translation(LanguageCode.SV, "Martinique"),
            new Translation(LanguageCode.TR, "Martinik"),
            new Translation(LanguageCode.UK, "Мартиніка"),
            new Translation(LanguageCode.UZ, "Martinika"),
            new Translation(LanguageCode.ZH, "马提尼克"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MQ;
        public Alpha3Code Alpha3Code => Alpha3Code.MTQ;
        public int NumericCode => 474;
        public string[] TLD => new [] { ".mq" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "596" };
    }
}
