namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guernsey
    /// </summary>
    public class GuernseyInfo : ICountryInfo
    {
        public string CommonName => "Guernsey";
        public string OfficialName => "Bailiwick of Guernsey";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "غيرنزي"),
            new Translation(LanguageCode.AZ, "Gernsi"),
            new Translation(LanguageCode.BE, "Гернсі"),
            new Translation(LanguageCode.BG, "Гърнзи"),
            new Translation(LanguageCode.BS, "Gernzi"),
            new Translation(LanguageCode.CA, "Guernsey"),
            new Translation(LanguageCode.CS, "Guernsey"),
            new Translation(LanguageCode.DA, "Guernsey"),
            new Translation(LanguageCode.DE, "Guernsey"),
            new Translation(LanguageCode.EL, "Γκουέρνσεϊ"),
            new Translation(LanguageCode.EN, "Guernsey"),
            new Translation(LanguageCode.ES, "Guernsey"),
            new Translation(LanguageCode.ET, "Guernsey"),
            new Translation(LanguageCode.FA, "گرنزی"),
            new Translation(LanguageCode.FI, "Guernsey"),
            new Translation(LanguageCode.FR, "Guernesey"),
            new Translation(LanguageCode.HE, "גרנסי"),
            new Translation(LanguageCode.HR, "Guernsey"),
            new Translation(LanguageCode.HU, "Guernsey"),
            new Translation(LanguageCode.HY, "Գերնսի"),
            new Translation(LanguageCode.ID, "Guernsey"),
            new Translation(LanguageCode.IT, "Guernsey"),
            new Translation(LanguageCode.JA, "ガーンジー"),
            new Translation(LanguageCode.KA, "გერნსი"),
            new Translation(LanguageCode.KK, "Гернси"),
            new Translation(LanguageCode.KO, "건지 섬"),
            new Translation(LanguageCode.KY, "Гернси"),
            new Translation(LanguageCode.LT, "Gernsis"),
            new Translation(LanguageCode.LV, "Gērnsija"),
            new Translation(LanguageCode.MK, "Гернзи"),
            new Translation(LanguageCode.MN, "Гернси"),
            new Translation(LanguageCode.NB, "Guernsey"),
            new Translation(LanguageCode.NL, "Guernsey"),
            new Translation(LanguageCode.NN, "Guernsey"),
            new Translation(LanguageCode.PL, "Guernsey"),
            new Translation(LanguageCode.PT, "Guernsey"),
            new Translation(LanguageCode.RO, "Guernsey"),
            new Translation(LanguageCode.RU, "Гернси"),
            new Translation(LanguageCode.SK, "Guernsey"),
            new Translation(LanguageCode.SL, "Guernsey"),
            new Translation(LanguageCode.SR, "Гернзи"),
            new Translation(LanguageCode.SV, "Guernsey"),
            new Translation(LanguageCode.TR, "Guernsey"),
            new Translation(LanguageCode.UK, "Гернсі"),
            new Translation(LanguageCode.UZ, "Gernsi"),
            new Translation(LanguageCode.ZH, "根西"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GG;
        public Alpha3Code Alpha3Code => Alpha3Code.GGY;
        public int NumericCode => 831;
        public string[] TLD => new [] { ".gg" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "GBP" };
        public string[] CallingCodes => new [] { "44" };
    }
}
