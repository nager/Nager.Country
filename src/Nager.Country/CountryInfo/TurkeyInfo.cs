namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Turkey
    /// </summary>
    public class TurkeyInfo : ICountryInfo
    {
        public string CommonName => "Turkey";
        public string OfficialName => "Republic of Turkey";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "تركيا"),
            new Translation(LanguageCode.AZ, "Türkiyə"),
            new Translation(LanguageCode.BE, "Турцыя"),
            new Translation(LanguageCode.BG, "Турция"),
            new Translation(LanguageCode.BS, "Turska"),
            new Translation(LanguageCode.CA, "Turquia"),
            new Translation(LanguageCode.CS, "Turecko"),
            new Translation(LanguageCode.DA, "Tyrkiet"),
            new Translation(LanguageCode.DE, "Türkei"),
            new Translation(LanguageCode.EL, "Τουρκία"),
            new Translation(LanguageCode.EN, "Turkey"),
            new Translation(LanguageCode.ES, "Turquía"),
            new Translation(LanguageCode.ET, "Türgi"),
            new Translation(LanguageCode.FA, "ترکیه"),
            new Translation(LanguageCode.FI, "Turkki"),
            new Translation(LanguageCode.FR, "Turquie"),
            new Translation(LanguageCode.HE, "טורקיה"),
            new Translation(LanguageCode.HR, "Turska"),
            new Translation(LanguageCode.HU, "Törökország"),
            new Translation(LanguageCode.HY, "Թուրքիա"),
            new Translation(LanguageCode.ID, "Turki"),
            new Translation(LanguageCode.IT, "Turchia"),
            new Translation(LanguageCode.JA, "トルコ"),
            new Translation(LanguageCode.KA, "თურქეთი"),
            new Translation(LanguageCode.KK, "Түркия"),
            new Translation(LanguageCode.KO, "터키"),
            new Translation(LanguageCode.KY, "Түркия"),
            new Translation(LanguageCode.LT, "Turkija"),
            new Translation(LanguageCode.LV, "Turcija"),
            new Translation(LanguageCode.MK, "Турција"),
            new Translation(LanguageCode.MN, "Турк"),
            new Translation(LanguageCode.NB, "Tyrkia"),
            new Translation(LanguageCode.NL, "Turkije"),
            new Translation(LanguageCode.NN, "Tyrkia"),
            new Translation(LanguageCode.PL, "Turcja"),
            new Translation(LanguageCode.PT, "Turquia"),
            new Translation(LanguageCode.RO, "Turcia"),
            new Translation(LanguageCode.RU, "Турция"),
            new Translation(LanguageCode.SK, "Turecko"),
            new Translation(LanguageCode.SL, "Turčija"),
            new Translation(LanguageCode.SR, "Турска"),
            new Translation(LanguageCode.SV, "Turkiet"),
            new Translation(LanguageCode.TR, "Türkiye"),
            new Translation(LanguageCode.UK, "Турція"),
            new Translation(LanguageCode.UZ, "Turkiya"),
            new Translation(LanguageCode.ZH, "土耳其"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TR;
        public Alpha3Code Alpha3Code => Alpha3Code.TUR;
        public int NumericCode => 792;
        public string[] TLD => new [] { ".tr" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AM,
            Alpha2Code.AZ,
            Alpha2Code.BG,
            Alpha2Code.GE,
            Alpha2Code.GR,
            Alpha2Code.IR,
            Alpha2Code.IQ,
            Alpha2Code.SY,
        };

        public string[] Currencies => new [] { "TRY" };
        public string[] CallingCodes => new [] { "90" };
    }
}
