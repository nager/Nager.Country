namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Botswana
    /// </summary>
    public class BotswanaInfo : ICountryInfo
    {
        public string CommonName => "Botswana";
        public string OfficialName => "Republic of Botswana";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بوتسوانا"),
            new Translation(LanguageCode.AZ, "Botsvana"),
            new Translation(LanguageCode.BE, "Батсвана"),
            new Translation(LanguageCode.BG, "Ботсвана"),
            new Translation(LanguageCode.BS, "Bocvana"),
            new Translation(LanguageCode.CA, "Botswana"),
            new Translation(LanguageCode.CS, "Botswana"),
            new Translation(LanguageCode.DA, "Botswana"),
            new Translation(LanguageCode.DE, "Botswana"),
            new Translation(LanguageCode.EL, "Μποτσουάνα"),
            new Translation(LanguageCode.EN, "Botswana"),
            new Translation(LanguageCode.ES, "Botswana"),
            new Translation(LanguageCode.ET, "Botswana"),
            new Translation(LanguageCode.FA, "بوتسوانا"),
            new Translation(LanguageCode.FI, "Botswana"),
            new Translation(LanguageCode.FR, "Botswana"),
            new Translation(LanguageCode.HE, "בוצוואנה"),
            new Translation(LanguageCode.HR, "Bocvana"),
            new Translation(LanguageCode.HU, "Botswana"),
            new Translation(LanguageCode.HY, "Բոթսվանա"),
            new Translation(LanguageCode.ID, "Botswana"),
            new Translation(LanguageCode.IT, "Botswana"),
            new Translation(LanguageCode.JA, "ボツワナ"),
            new Translation(LanguageCode.KA, "ბოტსვანა"),
            new Translation(LanguageCode.KK, "Ботсвана"),
            new Translation(LanguageCode.KO, "보츠와나"),
            new Translation(LanguageCode.KY, "Ботсвана"),
            new Translation(LanguageCode.LT, "Botsvana"),
            new Translation(LanguageCode.LV, "Botsvāna"),
            new Translation(LanguageCode.MK, "Боцвана"),
            new Translation(LanguageCode.MN, "Ботсвана"),
            new Translation(LanguageCode.NB, "Botswana"),
            new Translation(LanguageCode.NL, "Botswana"),
            new Translation(LanguageCode.NN, "Botswana"),
            new Translation(LanguageCode.PL, "Botswana"),
            new Translation(LanguageCode.PT, "Botsuana"),
            new Translation(LanguageCode.RO, "Botswana"),
            new Translation(LanguageCode.RU, "Ботсвана"),
            new Translation(LanguageCode.SK, "Botswana"),
            new Translation(LanguageCode.SL, "Bocvana"),
            new Translation(LanguageCode.SR, "Боцвана"),
            new Translation(LanguageCode.SV, "Botswana"),
            new Translation(LanguageCode.TR, "Botsvana"),
            new Translation(LanguageCode.UK, "Ботсвана"),
            new Translation(LanguageCode.UZ, "Botsvana"),
            new Translation(LanguageCode.ZH, "博茨瓦纳"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BW;
        public Alpha3Code Alpha3Code => Alpha3Code.BWA;
        public int NumericCode => 072;
        public string[] TLD => new [] { ".bw" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.NA,
            Alpha2Code.ZA,
            Alpha2Code.ZM,
            Alpha2Code.ZW,
        };

        public string[] Currencies => new [] { "BWP" };
        public string[] CallingCodes => new [] { "267" };
    }
}
