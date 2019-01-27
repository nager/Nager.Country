namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Maldives
    /// </summary>
    public class MaldivesInfo : ICountryInfo
    {
        public string CommonName => "Maldives";
        public string OfficialName => "Republic of the Maldives";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر المالديف"),
            new Translation(LanguageCode.AZ, "Maldiv adaları"),
            new Translation(LanguageCode.BE, "Мальдывы"),
            new Translation(LanguageCode.BG, "Малдиви"),
            new Translation(LanguageCode.BS, "Maldivi"),
            new Translation(LanguageCode.CA, "Maldives"),
            new Translation(LanguageCode.CS, "Maledivy"),
            new Translation(LanguageCode.DA, "Maldiverne"),
            new Translation(LanguageCode.DE, "Malediven"),
            new Translation(LanguageCode.EL, "Μαλβίδες"),
            new Translation(LanguageCode.EN, "Maldives"),
            new Translation(LanguageCode.ES, "Maldivas"),
            new Translation(LanguageCode.ET, "Maldiivid"),
            new Translation(LanguageCode.FA, "مالدیو"),
            new Translation(LanguageCode.FI, "Malediivit"),
            new Translation(LanguageCode.FR, "Maldives"),
            new Translation(LanguageCode.HE, "האיים המלדיביים"),
            new Translation(LanguageCode.HR, "Maldivi"),
            new Translation(LanguageCode.HU, "Maldív-szigetek"),
            new Translation(LanguageCode.HY, "Մալդիվներ"),
            new Translation(LanguageCode.ID, "Maldives"),
            new Translation(LanguageCode.IT, "Maldive"),
            new Translation(LanguageCode.JA, "モルディブ"),
            new Translation(LanguageCode.KA, "მალდივები"),
            new Translation(LanguageCode.KK, "Мальдив аралдары"),
            new Translation(LanguageCode.KO, "몰디브"),
            new Translation(LanguageCode.KY, "Малдив аралдары"),
            new Translation(LanguageCode.LT, "Maldyvai"),
            new Translation(LanguageCode.LV, "Maldīvija"),
            new Translation(LanguageCode.MK, "Малдиви"),
            new Translation(LanguageCode.MN, "Мальдив"),
            new Translation(LanguageCode.NB, "Maldivene"),
            new Translation(LanguageCode.NL, "Maldiven"),
            new Translation(LanguageCode.NN, "Maldivane"),
            new Translation(LanguageCode.PL, "Malediwy"),
            new Translation(LanguageCode.PT, "Maldivas"),
            new Translation(LanguageCode.RO, "Maldive"),
            new Translation(LanguageCode.RU, "Мальдивы"),
            new Translation(LanguageCode.SK, "Maldivy"),
            new Translation(LanguageCode.SL, "Maldivi"),
            new Translation(LanguageCode.SR, "Малдиви"),
            new Translation(LanguageCode.SV, "Maldiverna"),
            new Translation(LanguageCode.TR, "Maldivler"),
            new Translation(LanguageCode.UK, "Мальдівы"),
            new Translation(LanguageCode.UZ, "Maldiv orollari"),
            new Translation(LanguageCode.ZH, "马尔地夫"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MV;
        public Alpha3Code Alpha3Code => Alpha3Code.MDV;
        public int NumericCode => 462;
        public string[] TLD => new [] { ".mv" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "MVR" };
        public string[] CallingCodes => new [] { "960" };
    }
}
