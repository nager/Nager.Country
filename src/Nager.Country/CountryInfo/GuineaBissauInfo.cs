namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Guinea-Bissau
    /// </summary>
    public class GuineaBissauInfo : ICountryInfo
    {
        public string CommonName => "Guinea-Bissau";
        public string OfficialName => "Republic of Guinea-Bissau";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "غينيا بيساو"),
            new Translation(LanguageCode.AZ, "Qvineya-Bisau"),
            new Translation(LanguageCode.BE, "Гвінея-Бісау"),
            new Translation(LanguageCode.BG, "Гвинея-Бисау"),
            new Translation(LanguageCode.BS, "Gvineja-Bisao"),
            new Translation(LanguageCode.CA, "Guinea Bissau"),
            new Translation(LanguageCode.CS, "Guinea-Bissau"),
            new Translation(LanguageCode.DA, "Guinea-Bissau"),
            new Translation(LanguageCode.DE, "Guinea-Bissau"),
            new Translation(LanguageCode.EL, "Γουινέα-Μπισσάου"),
            new Translation(LanguageCode.EN, "Guinea-Bissau"),
            new Translation(LanguageCode.ES, "Guinea Bissau"),
            new Translation(LanguageCode.ET, "Guinea-Bissau"),
            new Translation(LanguageCode.FA, "گینهٔ بیسائو"),
            new Translation(LanguageCode.FI, "Guinea-Bissau"),
            new Translation(LanguageCode.FR, "Guinée-Bissau"),
            new Translation(LanguageCode.HE, "גינאה ביסאו"),
            new Translation(LanguageCode.HR, "Gvineja Bisau"),
            new Translation(LanguageCode.HU, "Bissau-Guinea"),
            new Translation(LanguageCode.HY, "Գվինեա-Բիսսաու"),
            new Translation(LanguageCode.ID, "Guinea-Bissau"),
            new Translation(LanguageCode.IT, "Guinea-Bissau"),
            new Translation(LanguageCode.JA, "ギニアビサウ"),
            new Translation(LanguageCode.KA, "გვინეა-ბისაუ"),
            new Translation(LanguageCode.KK, "Гвинея-Бисау"),
            new Translation(LanguageCode.KO, "기니 비사우"),
            new Translation(LanguageCode.KY, "Гвинея-Бисау"),
            new Translation(LanguageCode.LT, "Bisau Gvinėja"),
            new Translation(LanguageCode.LV, "Gvineja-Bisava"),
            new Translation(LanguageCode.MK, "Гвинеја-Бисау"),
            new Translation(LanguageCode.MN, "Гвиней-Бисау"),
            new Translation(LanguageCode.NB, "Guinea-Bissau"),
            new Translation(LanguageCode.NL, "Guinee-Bissau"),
            new Translation(LanguageCode.NN, "Guinea-Bissau"),
            new Translation(LanguageCode.PL, "Gwinea Bissau"),
            new Translation(LanguageCode.PT, "Guiné Bissau"),
            new Translation(LanguageCode.RO, "Guineea-Bissau"),
            new Translation(LanguageCode.RU, "Гвинея-Бисау"),
            new Translation(LanguageCode.SK, "Guinea-Bissau"),
            new Translation(LanguageCode.SL, "Gvineja Bissau"),
            new Translation(LanguageCode.SR, "Гвинеја-Бисао"),
            new Translation(LanguageCode.SV, "Guinea Bissau"),
            new Translation(LanguageCode.TR, "Gine-Bissau"),
            new Translation(LanguageCode.UK, "Гвінея-Бісау"),
            new Translation(LanguageCode.UZ, "Gvineya-Bisau"),
            new Translation(LanguageCode.ZH, "几内亚比绍"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GW;
        public Alpha3Code Alpha3Code => Alpha3Code.GNB;
        public int NumericCode => 624;
        public string[] TLD => new [] { ".gw" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.GN,
            Alpha2Code.SN,
        };

        public string[] Currencies => new [] { "XOF" };
        public string[] CallingCodes => new [] { "245" };
    }
}
