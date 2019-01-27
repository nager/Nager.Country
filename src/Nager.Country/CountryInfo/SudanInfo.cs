namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Sudan
    /// </summary>
    public class SudanInfo : ICountryInfo
    {
        public string CommonName => "Sudan";
        public string OfficialName => "Republic of the Sudan";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "السودان"),
            new Translation(LanguageCode.AZ, "Sudan"),
            new Translation(LanguageCode.BE, "Судан"),
            new Translation(LanguageCode.BG, "Судан"),
            new Translation(LanguageCode.BS, "Sudan"),
            new Translation(LanguageCode.CA, "Sudan"),
            new Translation(LanguageCode.CS, "Súdán"),
            new Translation(LanguageCode.DA, "Sudan"),
            new Translation(LanguageCode.DE, "Sudan"),
            new Translation(LanguageCode.EL, "Σουδάν"),
            new Translation(LanguageCode.EN, "Sudan"),
            new Translation(LanguageCode.ES, "Sudan"),
            new Translation(LanguageCode.ET, "Sudaan"),
            new Translation(LanguageCode.FA, "سودان"),
            new Translation(LanguageCode.FI, "Sudan"),
            new Translation(LanguageCode.FR, "Soudan"),
            new Translation(LanguageCode.HE, "סודן"),
            new Translation(LanguageCode.HR, "Sudan"),
            new Translation(LanguageCode.HU, "Szudán"),
            new Translation(LanguageCode.HY, "Սուդան"),
            new Translation(LanguageCode.ID, "Sudan"),
            new Translation(LanguageCode.IT, "Sudan"),
            new Translation(LanguageCode.JA, "スーダン"),
            new Translation(LanguageCode.KA, "სუდანი"),
            new Translation(LanguageCode.KK, "Судан"),
            new Translation(LanguageCode.KO, "수단"),
            new Translation(LanguageCode.KY, "Судан"),
            new Translation(LanguageCode.LT, "Sudanas"),
            new Translation(LanguageCode.LV, "Sudāna"),
            new Translation(LanguageCode.MK, "Судан"),
            new Translation(LanguageCode.MN, "Судан"),
            new Translation(LanguageCode.NB, "Sudan"),
            new Translation(LanguageCode.NL, "Soedan"),
            new Translation(LanguageCode.NN, "Sudan"),
            new Translation(LanguageCode.PL, "Sudan"),
            new Translation(LanguageCode.PT, "Sudão"),
            new Translation(LanguageCode.RO, "Sudan"),
            new Translation(LanguageCode.RU, "Судан"),
            new Translation(LanguageCode.SK, "Sudán"),
            new Translation(LanguageCode.SL, "Sudan"),
            new Translation(LanguageCode.SR, "Судан"),
            new Translation(LanguageCode.SV, "Sudan"),
            new Translation(LanguageCode.TR, "Sudan"),
            new Translation(LanguageCode.UK, "Судан"),
            new Translation(LanguageCode.UZ, "Sudan"),
            new Translation(LanguageCode.ZH, "苏丹"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SD;
        public Alpha3Code Alpha3Code => Alpha3Code.SDN;
        public int NumericCode => 729;
        public string[] TLD => new [] { ".sd" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CF,
            Alpha2Code.TD,
            Alpha2Code.EG,
            Alpha2Code.ER,
            Alpha2Code.ET,
            Alpha2Code.LY,
            Alpha2Code.SS,
        };

        public string[] Currencies => new [] { "SDG" };
        public string[] CallingCodes => new [] { "249" };
    }
}
