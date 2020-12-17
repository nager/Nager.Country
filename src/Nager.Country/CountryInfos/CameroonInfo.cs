namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cameroon
    /// </summary>
    public class CameroonInfo : ICountryInfo
    {
        public string CommonName => "Cameroon";
        public string OfficialName => "Republic of Cameroon";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الكاميرون"),
            new Translation(LanguageCode.AZ, "Kamerun"),
            new Translation(LanguageCode.BE, "Камерун"),
            new Translation(LanguageCode.BG, "Камерун"),
            new Translation(LanguageCode.BS, "Kamerun"),
            new Translation(LanguageCode.CA, "Camerun"),
            new Translation(LanguageCode.CS, "Kamerun"),
            new Translation(LanguageCode.DA, "Cameroun"),
            new Translation(LanguageCode.DE, "Kamerun"),
            new Translation(LanguageCode.EL, "Καμερούν"),
            new Translation(LanguageCode.EN, "Cameroon"),
            new Translation(LanguageCode.ES, "Camerún"),
            new Translation(LanguageCode.ET, "Kamerun"),
            new Translation(LanguageCode.FA, "کامرون"),
            new Translation(LanguageCode.FI, "Kamerun"),
            new Translation(LanguageCode.FR, "Cameroun"),
            new Translation(LanguageCode.HE, "קמרון"),
            new Translation(LanguageCode.HR, "Kamerun"),
            new Translation(LanguageCode.HU, "Kamerun"),
            new Translation(LanguageCode.HY, "Կամերուն"),
            new Translation(LanguageCode.ID, "Kamerun"),
            new Translation(LanguageCode.IT, "Camerun"),
            new Translation(LanguageCode.JA, "カメルーン"),
            new Translation(LanguageCode.KA, "კამერუნი"),
            new Translation(LanguageCode.KK, "Камерун"),
            new Translation(LanguageCode.KO, "카메룬"),
            new Translation(LanguageCode.KY, "Камерун"),
            new Translation(LanguageCode.LT, "Kamerūnas"),
            new Translation(LanguageCode.LV, "Kamerūna"),
            new Translation(LanguageCode.MK, "Камерун"),
            new Translation(LanguageCode.MN, "Камерун"),
            new Translation(LanguageCode.NB, "Kamerun"),
            new Translation(LanguageCode.NL, "Kameroen"),
            new Translation(LanguageCode.NN, "Kamerun"),
            new Translation(LanguageCode.PL, "Kamerun"),
            new Translation(LanguageCode.PT, "República dos Camarões"),
            new Translation(LanguageCode.RO, "Camerun"),
            new Translation(LanguageCode.RU, "Камерун"),
            new Translation(LanguageCode.SK, "Kamerun"),
            new Translation(LanguageCode.SL, "Kamerun"),
            new Translation(LanguageCode.SR, "Камерун"),
            new Translation(LanguageCode.SV, "Kamerun"),
            new Translation(LanguageCode.TR, "Kamerun"),
            new Translation(LanguageCode.UK, "Камерун"),
            new Translation(LanguageCode.UZ, "Kamerun"),
            new Translation(LanguageCode.ZH, "喀麦隆"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CM;
        public Alpha3Code Alpha3Code => Alpha3Code.CMR;
        public int NumericCode => 120;
        public string[] TLD => new [] { ".cm" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CF,
            Alpha2Code.TD,
            Alpha2Code.CG,
            Alpha2Code.GQ,
            Alpha2Code.GA,
            Alpha2Code.NG,
        };

        public string[] Currencies => new [] { "XAF" };
        public string[] CallingCodes => new [] { "237" };
    }
}
