namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Morocco
    /// </summary>
    public class MoroccoInfo : ICountryInfo
    {
        public string CommonName => "Morocco";
        public string OfficialName => "Kingdom of Morocco";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "المغرب"),
            new Translation(LanguageCode.AZ, "Mərakeş"),
            new Translation(LanguageCode.BE, "Марока"),
            new Translation(LanguageCode.BG, "Мароко"),
            new Translation(LanguageCode.BS, "Maroko"),
            new Translation(LanguageCode.CA, "Marroc"),
            new Translation(LanguageCode.CS, "Maroko"),
            new Translation(LanguageCode.DA, "Marokko"),
            new Translation(LanguageCode.DE, "Marokko"),
            new Translation(LanguageCode.EL, "Μαρόκο"),
            new Translation(LanguageCode.EN, "Morocco"),
            new Translation(LanguageCode.ES, "Marruecos"),
            new Translation(LanguageCode.ET, "Maroko"),
            new Translation(LanguageCode.FA, "مراکش"),
            new Translation(LanguageCode.FI, "Marokko"),
            new Translation(LanguageCode.FR, "Maroc"),
            new Translation(LanguageCode.HE, "מרוקו"),
            new Translation(LanguageCode.HR, "Maroko"),
            new Translation(LanguageCode.HU, "Marokkó"),
            new Translation(LanguageCode.HY, "Մարոկկո"),
            new Translation(LanguageCode.ID, "Moroko"),
            new Translation(LanguageCode.IT, "Marocco"),
            new Translation(LanguageCode.JA, "モロッコ"),
            new Translation(LanguageCode.KA, "მაროკო"),
            new Translation(LanguageCode.KK, "Марокко"),
            new Translation(LanguageCode.KO, "모로코"),
            new Translation(LanguageCode.KY, "Марокко"),
            new Translation(LanguageCode.LT, "Marokas"),
            new Translation(LanguageCode.LV, "Maroka"),
            new Translation(LanguageCode.MK, "Мароко"),
            new Translation(LanguageCode.MN, "Марокко"),
            new Translation(LanguageCode.NB, "Marokko"),
            new Translation(LanguageCode.NL, "Marokko"),
            new Translation(LanguageCode.NN, "Marokko"),
            new Translation(LanguageCode.PL, "Maroko"),
            new Translation(LanguageCode.PT, "Marrocos"),
            new Translation(LanguageCode.RO, "Maroc"),
            new Translation(LanguageCode.RU, "Марокко"),
            new Translation(LanguageCode.SK, "Maroko"),
            new Translation(LanguageCode.SL, "Maroko"),
            new Translation(LanguageCode.SR, "Мароко"),
            new Translation(LanguageCode.SV, "Marocko"),
            new Translation(LanguageCode.TR, "Fas"),
            new Translation(LanguageCode.UK, "Марокко"),
            new Translation(LanguageCode.UZ, "Marokash"),
            new Translation(LanguageCode.ZH, "摩洛哥"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MA;
        public Alpha3Code Alpha3Code => Alpha3Code.MAR;
        public int NumericCode => 504;
        public string[] TLD => new [] { ".ma", "المغرب." };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.EH,
            Alpha2Code.ES,
        };

        public string[] Currencies => new [] { "MAD" };
        public string[] CallingCodes => new [] { "212" };
    }
}
