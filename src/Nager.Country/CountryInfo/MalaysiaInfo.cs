namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Malaysia
    /// </summary>
    public class MalaysiaInfo : ICountryInfo
    {
        public string CommonName => "Malaysia";
        public string OfficialName => "Malaysia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ماليزيا"),
            new Translation(LanguageCode.AZ, "Malayziya"),
            new Translation(LanguageCode.BE, "Малайзія"),
            new Translation(LanguageCode.BG, "Малайзия"),
            new Translation(LanguageCode.BS, "Malezija"),
            new Translation(LanguageCode.CA, "Malàisia"),
            new Translation(LanguageCode.CS, "Malajsie"),
            new Translation(LanguageCode.DA, "Malaysia"),
            new Translation(LanguageCode.DE, "Malaysia"),
            new Translation(LanguageCode.EL, "Μαλαισία"),
            new Translation(LanguageCode.EN, "Malaysia"),
            new Translation(LanguageCode.ES, "Malasia"),
            new Translation(LanguageCode.ET, "Malaisia"),
            new Translation(LanguageCode.FA, "مالزی"),
            new Translation(LanguageCode.FI, "Malesia"),
            new Translation(LanguageCode.FR, "Malaisie"),
            new Translation(LanguageCode.HE, "מלזיה"),
            new Translation(LanguageCode.HR, "Malezija"),
            new Translation(LanguageCode.HU, "Malajzia"),
            new Translation(LanguageCode.HY, "Մալայզիա"),
            new Translation(LanguageCode.ID, "Malaysia"),
            new Translation(LanguageCode.IT, "Malesia"),
            new Translation(LanguageCode.JA, "マレーシア"),
            new Translation(LanguageCode.KA, "მალაიზია"),
            new Translation(LanguageCode.KK, "Малайзия"),
            new Translation(LanguageCode.KO, "말레이시아"),
            new Translation(LanguageCode.KY, "Малайзия"),
            new Translation(LanguageCode.LT, "Malaizija"),
            new Translation(LanguageCode.LV, "Malaizija"),
            new Translation(LanguageCode.MK, "Малезија"),
            new Translation(LanguageCode.MN, "Малайз"),
            new Translation(LanguageCode.NB, "Malaysia"),
            new Translation(LanguageCode.NL, "Maleisië"),
            new Translation(LanguageCode.NN, "Malaysia"),
            new Translation(LanguageCode.PL, "Malezja"),
            new Translation(LanguageCode.PT, "Malásia"),
            new Translation(LanguageCode.RO, "Malaysia"),
            new Translation(LanguageCode.RU, "Малайзия"),
            new Translation(LanguageCode.SK, "Malajzia"),
            new Translation(LanguageCode.SL, "Malezija"),
            new Translation(LanguageCode.SR, "Малезија"),
            new Translation(LanguageCode.SV, "Malaysia"),
            new Translation(LanguageCode.TR, "Malezya"),
            new Translation(LanguageCode.UK, "Малайзія"),
            new Translation(LanguageCode.UZ, "Malayziya"),
            new Translation(LanguageCode.ZH, "马来西亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MY;
        public Alpha3Code Alpha3Code => Alpha3Code.MYS;
        public int NumericCode => 458;
        public string[] TLD => new [] { ".my" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BN,
            Alpha2Code.ID,
            Alpha2Code.TH,
        };

        public string[] Currencies => new [] { "MYR" };
        public string[] CallingCodes => new [] { "60" };
    }
}
