namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// South Sudan
    /// </summary>
    public class SouthSudanInfo : ICountryInfo
    {
        public string CommonName => "South Sudan";
        public string OfficialName => "Republic of South Sudan";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جنوب السودان"),
            new Translation(LanguageCode.AZ, "Cənubi Sudan"),
            new Translation(LanguageCode.BE, "Паўднёвы Судан"),
            new Translation(LanguageCode.BG, "Южен Судан"),
            new Translation(LanguageCode.BS, "Južni Sudan"),
            new Translation(LanguageCode.CA, "Sudan del Sud"),
            new Translation(LanguageCode.CS, "Jižní Súdán"),
            new Translation(LanguageCode.DA, "Sydsudan"),
            new Translation(LanguageCode.DE, "Südsudan"),
            new Translation(LanguageCode.EL, "Νότιο Σουδάν"),
            new Translation(LanguageCode.EN, "South Sudan"),
            new Translation(LanguageCode.ES, "Sudán del Sur"),
            new Translation(LanguageCode.ET, "Lõuna-Sudaan"),
            new Translation(LanguageCode.FA, "سودان جنوبی"),
            new Translation(LanguageCode.FI, "Etelä-Sudan"),
            new Translation(LanguageCode.FR, "Sud-Soudan"),
            new Translation(LanguageCode.HE, "דרום סודן"),
            new Translation(LanguageCode.HR, "Južni Sudan"),
            new Translation(LanguageCode.HU, "Dél-Szudán"),
            new Translation(LanguageCode.HY, "Հարավային Սուդան"),
            new Translation(LanguageCode.ID, "Sudan Selatan"),
            new Translation(LanguageCode.IT, "Sudan del Sud"),
            new Translation(LanguageCode.JA, "南スーダン"),
            new Translation(LanguageCode.KA, "სამხრეთ სუდანი"),
            new Translation(LanguageCode.KK, "Оңтүстік Судан"),
            new Translation(LanguageCode.KO, "남 수단"),
            new Translation(LanguageCode.KY, "Түштүк Судан"),
            new Translation(LanguageCode.LT, "Pietų Sudanas"),
            new Translation(LanguageCode.LV, "Dienvidsudāna"),
            new Translation(LanguageCode.MK, "Јужен Судан"),
            new Translation(LanguageCode.MN, "Өмнөд Судан"),
            new Translation(LanguageCode.NB, "Sør-Sudan"),
            new Translation(LanguageCode.NL, "Zuid-Soedan"),
            new Translation(LanguageCode.NN, "Sør-Sudan"),
            new Translation(LanguageCode.PL, "Sudan Południowy"),
            new Translation(LanguageCode.PT, "Sudão do Sul"),
            new Translation(LanguageCode.RO, "Sudanul de Sud"),
            new Translation(LanguageCode.RU, "Южный Судан"),
            new Translation(LanguageCode.SK, "Južný Sudán"),
            new Translation(LanguageCode.SL, "Južni Sudan"),
            new Translation(LanguageCode.SR, "Јужни Судан"),
            new Translation(LanguageCode.SV, "Sydsudan"),
            new Translation(LanguageCode.TR, "Güney Sudan"),
            new Translation(LanguageCode.UK, "Південний Судан"),
            new Translation(LanguageCode.UZ, "Janubiy Sudan"),
            new Translation(LanguageCode.ZH, "南苏丹"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SS;
        public Alpha3Code Alpha3Code => Alpha3Code.SSD;
        public int NumericCode => 728;
        public string[] TLD => new [] { ".ss" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CF,
            Alpha2Code.CD,
            Alpha2Code.ET,
            Alpha2Code.KE,
            Alpha2Code.SD,
            Alpha2Code.UG,
        };

        public string[] Currencies => new [] { "SSP" };
        public string[] CallingCodes => new [] { "211" };
    }
}
