namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Zambia
    /// </summary>
    public class ZambiaInfo : ICountryInfo
    {
        public string CommonName => "Zambia";
        public string OfficialName => "Republic of Zambia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "زامبيا"),
            new Translation(LanguageCode.AZ, "Zambiya"),
            new Translation(LanguageCode.BE, "Замбія"),
            new Translation(LanguageCode.BG, "Замбия"),
            new Translation(LanguageCode.BS, "Zambija"),
            new Translation(LanguageCode.CA, "Zàmbia"),
            new Translation(LanguageCode.CS, "Zambie"),
            new Translation(LanguageCode.DA, "Zambia"),
            new Translation(LanguageCode.DE, "Sambia"),
            new Translation(LanguageCode.EL, "Ζάμπια"),
            new Translation(LanguageCode.EN, "Zambia"),
            new Translation(LanguageCode.ES, "Zambia"),
            new Translation(LanguageCode.ET, "Sambia"),
            new Translation(LanguageCode.FA, "زامبیا"),
            new Translation(LanguageCode.FI, "Sambia"),
            new Translation(LanguageCode.FR, "Zambie"),
            new Translation(LanguageCode.HE, "זמביה"),
            new Translation(LanguageCode.HR, "Zambija"),
            new Translation(LanguageCode.HU, "Zambia"),
            new Translation(LanguageCode.HY, "Զամբիա"),
            new Translation(LanguageCode.ID, "Zambia"),
            new Translation(LanguageCode.IT, "Zambia"),
            new Translation(LanguageCode.JA, "ザンビア"),
            new Translation(LanguageCode.KA, "ზამბია"),
            new Translation(LanguageCode.KK, "Замбия"),
            new Translation(LanguageCode.KO, "잠비아"),
            new Translation(LanguageCode.KY, "Замбия"),
            new Translation(LanguageCode.LT, "Zambija"),
            new Translation(LanguageCode.LV, "Zambija"),
            new Translation(LanguageCode.MK, "Замбија"),
            new Translation(LanguageCode.MN, "Замби"),
            new Translation(LanguageCode.NB, "Zambia"),
            new Translation(LanguageCode.NL, "Zambia"),
            new Translation(LanguageCode.NN, "Zambia"),
            new Translation(LanguageCode.PL, "Zambia"),
            new Translation(LanguageCode.PT, "Zâmbia"),
            new Translation(LanguageCode.RO, "Zambia"),
            new Translation(LanguageCode.RU, "Замбия"),
            new Translation(LanguageCode.SK, "Zambia"),
            new Translation(LanguageCode.SL, "Zambija"),
            new Translation(LanguageCode.SR, "Замбија"),
            new Translation(LanguageCode.SV, "Zambia"),
            new Translation(LanguageCode.TR, "Zambiya"),
            new Translation(LanguageCode.UK, "Замбія"),
            new Translation(LanguageCode.UZ, "Zambiya"),
            new Translation(LanguageCode.ZH, "尚比亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.ZM;
        public Alpha3Code Alpha3Code => Alpha3Code.ZMB;
        public int NumericCode => 894;
        public string[] TLD => new [] { ".zm" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AO,
            Alpha2Code.BW,
            Alpha2Code.CD,
            Alpha2Code.MW,
            Alpha2Code.MZ,
            Alpha2Code.NA,
            Alpha2Code.TZ,
            Alpha2Code.ZW,
        };

        public string[] Currencies => new [] { "ZMW" };
        public string[] CallingCodes => new [] { "260" };
    }
}
