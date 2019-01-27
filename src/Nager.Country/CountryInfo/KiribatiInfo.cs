namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Kiribati
    /// </summary>
    public class KiribatiInfo : ICountryInfo
    {
        public string CommonName => "Kiribati";
        public string OfficialName => "Independent and Sovereign Republic of Kiribati";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "كيريباتي"),
            new Translation(LanguageCode.AZ, "Kiribati"),
            new Translation(LanguageCode.BE, "Кірыбаці"),
            new Translation(LanguageCode.BG, "Кирибати"),
            new Translation(LanguageCode.BS, "Kiribati"),
            new Translation(LanguageCode.CA, "Kiribati"),
            new Translation(LanguageCode.CS, "Kiribati"),
            new Translation(LanguageCode.DA, "Kiribati"),
            new Translation(LanguageCode.DE, "Kiribati"),
            new Translation(LanguageCode.EL, "Κιριμπάτι"),
            new Translation(LanguageCode.EN, "Kiribati"),
            new Translation(LanguageCode.ES, "Kiribati"),
            new Translation(LanguageCode.ET, "Kiribati"),
            new Translation(LanguageCode.FA, "کیریباتی"),
            new Translation(LanguageCode.FI, "Kiribati"),
            new Translation(LanguageCode.FR, "Kiribati"),
            new Translation(LanguageCode.HE, "קיריבאטי"),
            new Translation(LanguageCode.HR, "Kiribati"),
            new Translation(LanguageCode.HU, "Kiribati"),
            new Translation(LanguageCode.HY, "Կիրիբատի"),
            new Translation(LanguageCode.ID, "Kiribati"),
            new Translation(LanguageCode.IT, "Kiribati"),
            new Translation(LanguageCode.JA, "キリバス"),
            new Translation(LanguageCode.KA, "კირიბატი"),
            new Translation(LanguageCode.KK, "Кирибати"),
            new Translation(LanguageCode.KO, "키리바시"),
            new Translation(LanguageCode.KY, "Кирибати"),
            new Translation(LanguageCode.LT, "Kiribatis"),
            new Translation(LanguageCode.LV, "Kiribati"),
            new Translation(LanguageCode.MK, "Кирибати"),
            new Translation(LanguageCode.MN, "Кирибати"),
            new Translation(LanguageCode.NB, "Kiribati"),
            new Translation(LanguageCode.NL, "Kiribati"),
            new Translation(LanguageCode.NN, "Kiribati"),
            new Translation(LanguageCode.PL, "Kiribati"),
            new Translation(LanguageCode.PT, "Quiribati"),
            new Translation(LanguageCode.RO, "Kiribati"),
            new Translation(LanguageCode.RU, "Кирибати"),
            new Translation(LanguageCode.SK, "Kiribati"),
            new Translation(LanguageCode.SL, "Kiribati"),
            new Translation(LanguageCode.SR, "Кирибати"),
            new Translation(LanguageCode.SV, "Kiribati"),
            new Translation(LanguageCode.TR, "Kiribati"),
            new Translation(LanguageCode.UK, "Кірибаті"),
            new Translation(LanguageCode.UZ, "Kiribati"),
            new Translation(LanguageCode.ZH, "基里巴斯"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.KI;
        public Alpha3Code Alpha3Code => Alpha3Code.KIR;
        public int NumericCode => 296;
        public string[] TLD => new [] { ".ki" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Micronesia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "AUD" };
        public string[] CallingCodes => new [] { "686" };
    }
}
