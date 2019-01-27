namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Chad
    /// </summary>
    public class ChadInfo : ICountryInfo
    {
        public string CommonName => "Chad";
        public string OfficialName => "Republic of Chad";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "تشاد"),
            new Translation(LanguageCode.AZ, "Çad"),
            new Translation(LanguageCode.BE, "Чад"),
            new Translation(LanguageCode.BG, "Чад"),
            new Translation(LanguageCode.BS, "Čad"),
            new Translation(LanguageCode.CA, "Txad"),
            new Translation(LanguageCode.CS, "Čad"),
            new Translation(LanguageCode.DA, "Tchad"),
            new Translation(LanguageCode.DE, "Tschad"),
            new Translation(LanguageCode.EL, "Τσάντ"),
            new Translation(LanguageCode.EN, "Chad"),
            new Translation(LanguageCode.ES, "Chad"),
            new Translation(LanguageCode.ET, "Tšaad"),
            new Translation(LanguageCode.FA, "چاد"),
            new Translation(LanguageCode.FI, "Tšad"),
            new Translation(LanguageCode.FR, "Tchad"),
            new Translation(LanguageCode.HE, "צ׳אד"),
            new Translation(LanguageCode.HR, "Čad"),
            new Translation(LanguageCode.HU, "Csád"),
            new Translation(LanguageCode.HY, "Չադ"),
            new Translation(LanguageCode.ID, "Chad"),
            new Translation(LanguageCode.IT, "Ciad"),
            new Translation(LanguageCode.JA, "チャド"),
            new Translation(LanguageCode.KA, "ჩადი"),
            new Translation(LanguageCode.KK, "Чад"),
            new Translation(LanguageCode.KO, "차드"),
            new Translation(LanguageCode.KY, "Чад"),
            new Translation(LanguageCode.LT, "Čadas"),
            new Translation(LanguageCode.LV, "Čada"),
            new Translation(LanguageCode.MK, "Чад"),
            new Translation(LanguageCode.MN, "Чад"),
            new Translation(LanguageCode.NB, "Tsjad"),
            new Translation(LanguageCode.NL, "Tsjaad"),
            new Translation(LanguageCode.NN, "Tsjad"),
            new Translation(LanguageCode.PL, "Czad"),
            new Translation(LanguageCode.PT, "Chade"),
            new Translation(LanguageCode.RO, "Ciad"),
            new Translation(LanguageCode.RU, "Чад"),
            new Translation(LanguageCode.SK, "Čad"),
            new Translation(LanguageCode.SL, "Čad"),
            new Translation(LanguageCode.SR, "Чад"),
            new Translation(LanguageCode.SV, "Tchad"),
            new Translation(LanguageCode.TR, "Çad"),
            new Translation(LanguageCode.UK, "Чад"),
            new Translation(LanguageCode.UZ, "Chad"),
            new Translation(LanguageCode.ZH, "乍得"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TD;
        public Alpha3Code Alpha3Code => Alpha3Code.TCD;
        public int NumericCode => 148;
        public string[] TLD => new [] { ".td" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CM,
            Alpha2Code.CF,
            Alpha2Code.LY,
            Alpha2Code.NE,
            Alpha2Code.NG,
            Alpha2Code.SS,
        };

        public string[] Currencies => new [] { "XAF" };
        public string[] CallingCodes => new [] { "235" };
    }
}
