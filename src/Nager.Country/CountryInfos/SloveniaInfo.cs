namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Slovenia
    /// </summary>
    public class SloveniaInfo : ICountryInfo
    {
        public string CommonName => "Slovenia";
        public string OfficialName => "Republic of Slovenia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سلوفينيا"),
            new Translation(LanguageCode.AZ, "Sloveniya"),
            new Translation(LanguageCode.BE, "Славенія"),
            new Translation(LanguageCode.BG, "Словения"),
            new Translation(LanguageCode.BS, "Slovenija"),
            new Translation(LanguageCode.CA, "Eslovènia"),
            new Translation(LanguageCode.CS, "Slovinsko"),
            new Translation(LanguageCode.DA, "Slovenien"),
            new Translation(LanguageCode.DE, "Slowenien"),
            new Translation(LanguageCode.EL, "Σλοβενία"),
            new Translation(LanguageCode.EN, "Slovenia"),
            new Translation(LanguageCode.ES, "Eslovenia"),
            new Translation(LanguageCode.ET, "Sloveenia"),
            new Translation(LanguageCode.FA, "اسلوونی"),
            new Translation(LanguageCode.FI, "Slovenia"),
            new Translation(LanguageCode.FR, "Slovénie"),
            new Translation(LanguageCode.HE, "סלובניה"),
            new Translation(LanguageCode.HR, "Slovenija"),
            new Translation(LanguageCode.HU, "Szlovénia"),
            new Translation(LanguageCode.HY, "Սլովենիա"),
            new Translation(LanguageCode.ID, "Slovenia"),
            new Translation(LanguageCode.IT, "Slovenia"),
            new Translation(LanguageCode.JA, "スロベニア"),
            new Translation(LanguageCode.KA, "სლოვენია"),
            new Translation(LanguageCode.KK, "Словения"),
            new Translation(LanguageCode.KO, "슬로베니아"),
            new Translation(LanguageCode.KY, "Словения"),
            new Translation(LanguageCode.LT, "Slovėnija"),
            new Translation(LanguageCode.LV, "Slovēnija"),
            new Translation(LanguageCode.MK, "Словенија"),
            new Translation(LanguageCode.MN, "Словени"),
            new Translation(LanguageCode.NB, "Slovenia"),
            new Translation(LanguageCode.NL, "Slovenië"),
            new Translation(LanguageCode.NN, "Slovenia"),
            new Translation(LanguageCode.PL, "Słowenia"),
            new Translation(LanguageCode.PT, "Eslovênia"),
            new Translation(LanguageCode.RO, "Slovenia"),
            new Translation(LanguageCode.RU, "Словения"),
            new Translation(LanguageCode.SK, "Slovinsko"),
            new Translation(LanguageCode.SL, "Slovenija"),
            new Translation(LanguageCode.SR, "Словенија"),
            new Translation(LanguageCode.SV, "Slovenien"),
            new Translation(LanguageCode.TR, "Slovenya"),
            new Translation(LanguageCode.UK, "Словенія"),
            new Translation(LanguageCode.UZ, "Sloveniya"),
            new Translation(LanguageCode.ZH, "斯洛维尼亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SI;
        public Alpha3Code Alpha3Code => Alpha3Code.SVN;
        public int NumericCode => 705;
        public string[] TLD => new [] { ".si" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.HR,
            Alpha2Code.IT,
            Alpha2Code.HU,
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "386" };
    }
}
