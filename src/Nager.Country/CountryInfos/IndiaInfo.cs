namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// India
    /// </summary>
    public class IndiaInfo : ICountryInfo
    {
        public string CommonName => "India";
        public string OfficialName => "Republic of India";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الهند"),
            new Translation(LanguageCode.AZ, "Hindistan"),
            new Translation(LanguageCode.BE, "Індыя"),
            new Translation(LanguageCode.BG, "Индия"),
            new Translation(LanguageCode.BS, "Indija"),
            new Translation(LanguageCode.CA, "Índia"),
            new Translation(LanguageCode.CS, "Indie"),
            new Translation(LanguageCode.DA, "Indien"),
            new Translation(LanguageCode.DE, "Indien"),
            new Translation(LanguageCode.EL, "Ινδία"),
            new Translation(LanguageCode.EN, "India"),
            new Translation(LanguageCode.ES, "India"),
            new Translation(LanguageCode.ET, "India"),
            new Translation(LanguageCode.FA, "هند"),
            new Translation(LanguageCode.FI, "Intia"),
            new Translation(LanguageCode.FR, "Inde"),
            new Translation(LanguageCode.HE, "הודו"),
            new Translation(LanguageCode.HR, "Indija"),
            new Translation(LanguageCode.HU, "India"),
            new Translation(LanguageCode.HY, "Հնդկաստան"),
            new Translation(LanguageCode.ID, "India"),
            new Translation(LanguageCode.IT, "India"),
            new Translation(LanguageCode.JA, "インド"),
            new Translation(LanguageCode.KA, "ინდოეთი"),
            new Translation(LanguageCode.KK, "Үндістан"),
            new Translation(LanguageCode.KO, "인도"),
            new Translation(LanguageCode.KY, "Индия"),
            new Translation(LanguageCode.LT, "Indija"),
            new Translation(LanguageCode.LV, "Indija"),
            new Translation(LanguageCode.MK, "Индија"),
            new Translation(LanguageCode.MN, "Энэтхэг"),
            new Translation(LanguageCode.NB, "India"),
            new Translation(LanguageCode.NL, "India"),
            new Translation(LanguageCode.NN, "India"),
            new Translation(LanguageCode.PL, "Indie"),
            new Translation(LanguageCode.PT, "Índia"),
            new Translation(LanguageCode.RO, "India"),
            new Translation(LanguageCode.RU, "Индия"),
            new Translation(LanguageCode.SK, "India"),
            new Translation(LanguageCode.SL, "Indija"),
            new Translation(LanguageCode.SR, "Индија"),
            new Translation(LanguageCode.SV, "Indien"),
            new Translation(LanguageCode.TR, "Hindistan"),
            new Translation(LanguageCode.UK, "Індія"),
            new Translation(LanguageCode.UZ, "Hindiston"),
            new Translation(LanguageCode.ZH, "印度"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.IN;
        public Alpha3Code Alpha3Code => Alpha3Code.IND;
        public int NumericCode => 356;
        public string[] TLD => new [] { ".in" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.BD,
            Alpha2Code.BT,
            Alpha2Code.MM,
            Alpha2Code.CN,
            Alpha2Code.NP,
            Alpha2Code.PK,
            Alpha2Code.LK,
        };

        public string[] Currencies => new [] { "INR" };
        public string[] CallingCodes => new [] { "91" };
    }
}
