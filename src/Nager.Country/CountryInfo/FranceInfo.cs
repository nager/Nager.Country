namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// France
    /// </summary>
    public class FranceInfo : ICountryInfo
    {
        public string CommonName => "France";
        public string OfficialName => "French Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "فرنسا"),
            new Translation(LanguageCode.AZ, "Fransa"),
            new Translation(LanguageCode.BE, "Францыя"),
            new Translation(LanguageCode.BG, "Франция"),
            new Translation(LanguageCode.BS, "Francuska"),
            new Translation(LanguageCode.CA, "França"),
            new Translation(LanguageCode.CS, "Francie"),
            new Translation(LanguageCode.DA, "Frankrig"),
            new Translation(LanguageCode.DE, "Frankreich"),
            new Translation(LanguageCode.EL, "Γαλλία"),
            new Translation(LanguageCode.EN, "France"),
            new Translation(LanguageCode.ES, "Francia"),
            new Translation(LanguageCode.ET, "Prantsusmaa"),
            new Translation(LanguageCode.FA, "فرانسه"),
            new Translation(LanguageCode.FI, "Ranska"),
            new Translation(LanguageCode.FR, "France"),
            new Translation(LanguageCode.HE, "צרפת"),
            new Translation(LanguageCode.HR, "Francuska"),
            new Translation(LanguageCode.HU, "Franciaország"),
            new Translation(LanguageCode.HY, "Ֆրանսիա"),
            new Translation(LanguageCode.ID, "Perancis"),
            new Translation(LanguageCode.IT, "Francia"),
            new Translation(LanguageCode.JA, "フランス"),
            new Translation(LanguageCode.KA, "საფრანგეთი"),
            new Translation(LanguageCode.KK, "Франция"),
            new Translation(LanguageCode.KO, "프랑스"),
            new Translation(LanguageCode.KY, "Франция"),
            new Translation(LanguageCode.LT, "Prancūzija"),
            new Translation(LanguageCode.LV, "Francija"),
            new Translation(LanguageCode.MK, "Франција"),
            new Translation(LanguageCode.MN, "Франц"),
            new Translation(LanguageCode.NB, "Frankrike"),
            new Translation(LanguageCode.NL, "Frankrijk"),
            new Translation(LanguageCode.NN, "Frankrike"),
            new Translation(LanguageCode.PL, "Francja"),
            new Translation(LanguageCode.PT, "França"),
            new Translation(LanguageCode.RO, "Franța"),
            new Translation(LanguageCode.RU, "Франция"),
            new Translation(LanguageCode.SK, "Francúzsko"),
            new Translation(LanguageCode.SL, "Francija"),
            new Translation(LanguageCode.SR, "Француска"),
            new Translation(LanguageCode.SV, "Frankrike"),
            new Translation(LanguageCode.TR, "Fransa"),
            new Translation(LanguageCode.UK, "Франція"),
            new Translation(LanguageCode.UZ, "Fransiya"),
            new Translation(LanguageCode.ZH, "法国"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.FR;
        public Alpha3Code Alpha3Code => Alpha3Code.FRA;
        public int NumericCode => 250;
        public string[] TLD => new [] { ".fr" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AD,
            Alpha2Code.BE,
            Alpha2Code.DE,
            Alpha2Code.IT,
            Alpha2Code.LU,
            Alpha2Code.MC,
            Alpha2Code.ES,
            Alpha2Code.CH,
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "33" };
    }
}
