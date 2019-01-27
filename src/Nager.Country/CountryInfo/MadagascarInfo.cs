namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Madagascar
    /// </summary>
    public class MadagascarInfo : ICountryInfo
    {
        public string CommonName => "Madagascar";
        public string OfficialName => "Republic of Madagascar";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "مدغشقر"),
            new Translation(LanguageCode.AZ, "Madaqaskar"),
            new Translation(LanguageCode.BE, "Мадагаскар"),
            new Translation(LanguageCode.BG, "Мадагаскар"),
            new Translation(LanguageCode.BS, "Madagaskar"),
            new Translation(LanguageCode.CA, "Madagascar"),
            new Translation(LanguageCode.CS, "Madagaskar"),
            new Translation(LanguageCode.DA, "Madagaskar"),
            new Translation(LanguageCode.DE, "Madagaskar"),
            new Translation(LanguageCode.EL, "Μαδαγασκάρη"),
            new Translation(LanguageCode.EN, "Madagascar"),
            new Translation(LanguageCode.ES, "Madagascar"),
            new Translation(LanguageCode.ET, "Madagaskar"),
            new Translation(LanguageCode.FA, "ماداگاسکار"),
            new Translation(LanguageCode.FI, "Madagaskar"),
            new Translation(LanguageCode.FR, "Madagascar"),
            new Translation(LanguageCode.HE, "מדגסקר"),
            new Translation(LanguageCode.HR, "Madagaskar"),
            new Translation(LanguageCode.HU, "Madagaszkár"),
            new Translation(LanguageCode.HY, "Մադագասկար"),
            new Translation(LanguageCode.ID, "Madagaskar"),
            new Translation(LanguageCode.IT, "Madagascar"),
            new Translation(LanguageCode.JA, "マダガスカル"),
            new Translation(LanguageCode.KA, "მადაგასკარი"),
            new Translation(LanguageCode.KK, "Мадагаскар"),
            new Translation(LanguageCode.KO, "마다가스카르"),
            new Translation(LanguageCode.KY, "Мадагаскар"),
            new Translation(LanguageCode.LT, "Madagaskaras"),
            new Translation(LanguageCode.LV, "Madagaskara"),
            new Translation(LanguageCode.MK, "Мадагаскар"),
            new Translation(LanguageCode.MN, "Мадагаскар"),
            new Translation(LanguageCode.NB, "Madagaskar"),
            new Translation(LanguageCode.NL, "Madagaskar"),
            new Translation(LanguageCode.NN, "Madagaskar"),
            new Translation(LanguageCode.PL, "Madagaskar"),
            new Translation(LanguageCode.PT, "Madagascar"),
            new Translation(LanguageCode.RO, "Madagascar"),
            new Translation(LanguageCode.RU, "Мадагаскар"),
            new Translation(LanguageCode.SK, "Madagaskar"),
            new Translation(LanguageCode.SL, "Madagaskar"),
            new Translation(LanguageCode.SR, "Мадагаскар"),
            new Translation(LanguageCode.SV, "Madagaskar"),
            new Translation(LanguageCode.TR, "Madagaskar"),
            new Translation(LanguageCode.UK, "Мадагаскар"),
            new Translation(LanguageCode.UZ, "Madagaskar"),
            new Translation(LanguageCode.ZH, "马达加斯加"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MG;
        public Alpha3Code Alpha3Code => Alpha3Code.MDG;
        public int NumericCode => 450;
        public string[] TLD => new [] { ".mg" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "MGA" };
        public string[] CallingCodes => new [] { "261" };
    }
}
