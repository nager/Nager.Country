namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bolivia
    /// </summary>
    public class BoliviaInfo : ICountryInfo
    {
        public string CommonName => "Bolivia";
        public string OfficialName => "Plurinational State of Bolivia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بوليفيا"),
            new Translation(LanguageCode.AZ, "Boliviya"),
            new Translation(LanguageCode.BE, "Балівія"),
            new Translation(LanguageCode.BG, "Боливия"),
            new Translation(LanguageCode.BS, "Bolivija"),
            new Translation(LanguageCode.CA, "Bolívia"),
            new Translation(LanguageCode.CS, "Bolívie"),
            new Translation(LanguageCode.DA, "Bolivia"),
            new Translation(LanguageCode.DE, "Bolivien"),
            new Translation(LanguageCode.EL, "Βολιβία"),
            new Translation(LanguageCode.EN, "Bolivia"),
            new Translation(LanguageCode.ES, "Bolivia"),
            new Translation(LanguageCode.ET, "Boliivia"),
            new Translation(LanguageCode.FA, "بولیوی"),
            new Translation(LanguageCode.FI, "Bolivia"),
            new Translation(LanguageCode.FR, "Bolivie"),
            new Translation(LanguageCode.HE, "בוליביה"),
            new Translation(LanguageCode.HR, "Bolivija"),
            new Translation(LanguageCode.HU, "Bolívia"),
            new Translation(LanguageCode.HY, "Բոլիվիա"),
            new Translation(LanguageCode.ID, "Bolivia"),
            new Translation(LanguageCode.IT, "Bolivia"),
            new Translation(LanguageCode.JA, "ボリビア多民族国"),
            new Translation(LanguageCode.KA, "ბოლივია"),
            new Translation(LanguageCode.KK, "Боливия"),
            new Translation(LanguageCode.KO, "볼리비아"),
            new Translation(LanguageCode.KY, "Боливия"),
            new Translation(LanguageCode.LT, "Bolivija"),
            new Translation(LanguageCode.LV, "Bolīvija"),
            new Translation(LanguageCode.MK, "Боливија"),
            new Translation(LanguageCode.MN, "Боливи"),
            new Translation(LanguageCode.NB, "Bolivia"),
            new Translation(LanguageCode.NL, "Bolivië"),
            new Translation(LanguageCode.NN, "Bolivia"),
            new Translation(LanguageCode.PL, "Boliwia"),
            new Translation(LanguageCode.PT, "Bolívia"),
            new Translation(LanguageCode.RO, "Bolivia"),
            new Translation(LanguageCode.RU, "Боливия"),
            new Translation(LanguageCode.SK, "Bolívia"),
            new Translation(LanguageCode.SL, "Bolivija"),
            new Translation(LanguageCode.SR, "Боливија"),
            new Translation(LanguageCode.SV, "Bolivia"),
            new Translation(LanguageCode.TR, "Bolivya"),
            new Translation(LanguageCode.UK, "Болівія"),
            new Translation(LanguageCode.UZ, "Boliviya"),
            new Translation(LanguageCode.ZH, "玻利维亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BO;
        public Alpha3Code Alpha3Code => Alpha3Code.BOL;
        public int NumericCode => 068;
        public string[] TLD => new [] { ".bo" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BR,
            Alpha2Code.CL,
            Alpha2Code.PY,
            Alpha2Code.PE,
        };

        public string[] Currencies => new [] { "BOB" };
        public string[] CallingCodes => new [] { "591" };
    }
}
