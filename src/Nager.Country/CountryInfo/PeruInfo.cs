namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Peru
    /// </summary>
    public class PeruInfo : ICountryInfo
    {
        public string CommonName => "Peru";
        public string OfficialName => "Republic of Peru";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بيرو"),
            new Translation(LanguageCode.AZ, "Peru"),
            new Translation(LanguageCode.BE, "Перу"),
            new Translation(LanguageCode.BG, "Перу"),
            new Translation(LanguageCode.BS, "Peru"),
            new Translation(LanguageCode.CA, "Perú"),
            new Translation(LanguageCode.CS, "Peru"),
            new Translation(LanguageCode.DA, "Peru"),
            new Translation(LanguageCode.DE, "Peru"),
            new Translation(LanguageCode.EL, "Περού"),
            new Translation(LanguageCode.EN, "Peru"),
            new Translation(LanguageCode.ES, "Perú"),
            new Translation(LanguageCode.ET, "Peruu"),
            new Translation(LanguageCode.FA, "پرو"),
            new Translation(LanguageCode.FI, "Peru"),
            new Translation(LanguageCode.FR, "Pérou"),
            new Translation(LanguageCode.HE, "פרו"),
            new Translation(LanguageCode.HR, "Peru"),
            new Translation(LanguageCode.HU, "Peru"),
            new Translation(LanguageCode.HY, "Պերու"),
            new Translation(LanguageCode.ID, "Peru"),
            new Translation(LanguageCode.IT, "Perù"),
            new Translation(LanguageCode.JA, "ペルー"),
            new Translation(LanguageCode.KA, "პერუ"),
            new Translation(LanguageCode.KK, "Перу"),
            new Translation(LanguageCode.KO, "페루"),
            new Translation(LanguageCode.KY, "Перу"),
            new Translation(LanguageCode.LT, "Peru"),
            new Translation(LanguageCode.LV, "Peru"),
            new Translation(LanguageCode.MK, "Перу"),
            new Translation(LanguageCode.MN, "Перу"),
            new Translation(LanguageCode.NB, "Peru"),
            new Translation(LanguageCode.NL, "Peru"),
            new Translation(LanguageCode.NN, "Peru"),
            new Translation(LanguageCode.PL, "Peru"),
            new Translation(LanguageCode.PT, "Peru"),
            new Translation(LanguageCode.RO, "Peru"),
            new Translation(LanguageCode.RU, "Перу"),
            new Translation(LanguageCode.SK, "Peru"),
            new Translation(LanguageCode.SL, "Peru"),
            new Translation(LanguageCode.SR, "Перу"),
            new Translation(LanguageCode.SV, "Peru"),
            new Translation(LanguageCode.TR, "Peru"),
            new Translation(LanguageCode.UK, "Перу"),
            new Translation(LanguageCode.UZ, "Peru"),
            new Translation(LanguageCode.ZH, "秘鲁"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.PE;
        public Alpha3Code Alpha3Code => Alpha3Code.PER;
        public int NumericCode => 604;
        public string[] TLD => new [] { ".pe" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BO,
            Alpha2Code.BR,
            Alpha2Code.CL,
            Alpha2Code.CO,
            Alpha2Code.EC,
        };

        public string[] Currencies => new [] { "PEN" };
        public string[] CallingCodes => new [] { "51" };
    }
}
