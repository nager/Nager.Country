namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Serbia
    /// </summary>
    public class SerbiaInfo : ICountryInfo
    {
        public string CommonName => "Serbia";
        public string OfficialName => "Republic of Serbia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "صربيا"),
            new Translation(LanguageCode.AZ, "Serbiya"),
            new Translation(LanguageCode.BE, "Сербія"),
            new Translation(LanguageCode.BG, "Сърбия"),
            new Translation(LanguageCode.BS, "Srbija"),
            new Translation(LanguageCode.CA, "Sèrbia"),
            new Translation(LanguageCode.CS, "Srbsko"),
            new Translation(LanguageCode.DA, "Serbien"),
            new Translation(LanguageCode.DE, "Serbien"),
            new Translation(LanguageCode.EL, "Σερβία"),
            new Translation(LanguageCode.EN, "Serbia"),
            new Translation(LanguageCode.ES, "Serbia"),
            new Translation(LanguageCode.ET, "Serbia"),
            new Translation(LanguageCode.FA, "صربستان"),
            new Translation(LanguageCode.FI, "Serbia"),
            new Translation(LanguageCode.FR, "Serbie"),
            new Translation(LanguageCode.HE, "סרביה"),
            new Translation(LanguageCode.HR, "Srbija"),
            new Translation(LanguageCode.HU, "Szerbia"),
            new Translation(LanguageCode.HY, "Սերբիա"),
            new Translation(LanguageCode.ID, "Serbia"),
            new Translation(LanguageCode.IT, "Serbia"),
            new Translation(LanguageCode.JA, "セルビア"),
            new Translation(LanguageCode.KA, "სერბეთი"),
            new Translation(LanguageCode.KK, "Сербия"),
            new Translation(LanguageCode.KO, "세르비아"),
            new Translation(LanguageCode.KY, "Сербия"),
            new Translation(LanguageCode.LT, "Serbija"),
            new Translation(LanguageCode.LV, "Serbija"),
            new Translation(LanguageCode.MK, "Србија"),
            new Translation(LanguageCode.MN, "Серби"),
            new Translation(LanguageCode.NB, "Serbia"),
            new Translation(LanguageCode.NL, "Servië"),
            new Translation(LanguageCode.NN, "Serbia"),
            new Translation(LanguageCode.PL, "Serbia"),
            new Translation(LanguageCode.PT, "Sérvia"),
            new Translation(LanguageCode.RO, "Serbia"),
            new Translation(LanguageCode.RU, "Сербия"),
            new Translation(LanguageCode.SK, "Srbsko"),
            new Translation(LanguageCode.SL, "Srbija"),
            new Translation(LanguageCode.SR, "Србија"),
            new Translation(LanguageCode.SV, "Serbien"),
            new Translation(LanguageCode.TR, "Sırbistan"),
            new Translation(LanguageCode.UK, "Сербія"),
            new Translation(LanguageCode.UZ, "Serbiya"),
            new Translation(LanguageCode.ZH, "塞尔维亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.RS;
        public Alpha3Code Alpha3Code => Alpha3Code.SRB;
        public int NumericCode => 688;
        public string[] TLD => new [] { ".rs", ".срб" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BA,
            Alpha2Code.BG,
            Alpha2Code.HR,
            Alpha2Code.HU,
            Alpha2Code.MK,
            Alpha2Code.ME,
            Alpha2Code.RO,
        };

        public string[] Currencies => new [] { "RSD" };
        public string[] CallingCodes => new [] { "381" };
    }
}
