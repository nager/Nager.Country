namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Tanzania
    /// </summary>
    public class TanzaniaInfo : ICountryInfo
    {
        public string CommonName => "Tanzania";
        public string OfficialName => "United Republic of Tanzania";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "تانزانيا"),
            new Translation(LanguageCode.AZ, "Tanzaniya"),
            new Translation(LanguageCode.BE, "Танзанія"),
            new Translation(LanguageCode.BG, "Танзания"),
            new Translation(LanguageCode.BS, "Tanzanija"),
            new Translation(LanguageCode.CA, "Tanzània"),
            new Translation(LanguageCode.CS, "Tanzanie"),
            new Translation(LanguageCode.DA, "Tanzania"),
            new Translation(LanguageCode.DE, "Tansania, Vereinigte Republik"),
            new Translation(LanguageCode.EL, "Ενωμένη Δημοκρατία της Τανζανίας"),
            new Translation(LanguageCode.EN, "Tanzania, United Republic of"),
            new Translation(LanguageCode.ES, "Tanzania"),
            new Translation(LanguageCode.ET, "Tansaania"),
            new Translation(LanguageCode.FA, "تانزانیا"),
            new Translation(LanguageCode.FI, "Tansania"),
            new Translation(LanguageCode.FR, "Tanzanie, République unie"),
            new Translation(LanguageCode.HE, "טנזניה"),
            new Translation(LanguageCode.HR, "Tanzanija"),
            new Translation(LanguageCode.HU, "Tanzánia"),
            new Translation(LanguageCode.HY, "Տանզանիա"),
            new Translation(LanguageCode.ID, "Tanzania"),
            new Translation(LanguageCode.IT, "Tanzania"),
            new Translation(LanguageCode.JA, "タンザニア"),
            new Translation(LanguageCode.KA, "ტანზანია"),
            new Translation(LanguageCode.KK, "Танзания"),
            new Translation(LanguageCode.KO, "탄자니아, 유엔"),
            new Translation(LanguageCode.KY, "Танзания"),
            new Translation(LanguageCode.LT, "Tanzanija"),
            new Translation(LanguageCode.LV, "Tanzānija"),
            new Translation(LanguageCode.MK, "Танзанија"),
            new Translation(LanguageCode.MN, "Танзани"),
            new Translation(LanguageCode.NB, "Tanzania"),
            new Translation(LanguageCode.NL, "Tanzania, Verenigde Republiek"),
            new Translation(LanguageCode.NN, "Tanzania"),
            new Translation(LanguageCode.PL, "Tanzania"),
            new Translation(LanguageCode.PT, "Tanzânia"),
            new Translation(LanguageCode.RO, "Tanzania"),
            new Translation(LanguageCode.RU, "Танзания"),
            new Translation(LanguageCode.SK, "Tanzánia"),
            new Translation(LanguageCode.SL, "Tanzanija"),
            new Translation(LanguageCode.SR, "Танзанија"),
            new Translation(LanguageCode.SV, "Tanzania"),
            new Translation(LanguageCode.TR, "Tanzanya"),
            new Translation(LanguageCode.UK, "Танзанія"),
            new Translation(LanguageCode.UZ, "Tanzaniya"),
            new Translation(LanguageCode.ZH, "坦桑尼亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TZ;
        public Alpha3Code Alpha3Code => Alpha3Code.TZA;
        public int NumericCode => 834;
        public string[] TLD => new [] { ".tz" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BI,
            Alpha2Code.CD,
            Alpha2Code.KE,
            Alpha2Code.MW,
            Alpha2Code.MZ,
            Alpha2Code.RW,
            Alpha2Code.UG,
            Alpha2Code.ZM,
        };

        public string[] Currencies => new [] { "TZS" };
        public string[] CallingCodes => new [] { "255" };
    }
}
