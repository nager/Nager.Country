namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Jordan
    /// </summary>
    public class JordanInfo : ICountryInfo
    {
        public string CommonName => "Jordan";
        public string OfficialName => "Hashemite Kingdom of Jordan";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الأردن"),
            new Translation(LanguageCode.AZ, "İordaniya"),
            new Translation(LanguageCode.BE, "Іарданія"),
            new Translation(LanguageCode.BG, "Йордания"),
            new Translation(LanguageCode.BS, "Jordan"),
            new Translation(LanguageCode.CA, "Jordània"),
            new Translation(LanguageCode.CS, "Jordánsko"),
            new Translation(LanguageCode.DA, "Jordan"),
            new Translation(LanguageCode.DE, "Jordanien"),
            new Translation(LanguageCode.EL, "Ιορδανία"),
            new Translation(LanguageCode.EN, "Jordan"),
            new Translation(LanguageCode.ES, "Jordania"),
            new Translation(LanguageCode.ET, "Jordaania"),
            new Translation(LanguageCode.FA, "اردن"),
            new Translation(LanguageCode.FI, "Jordania"),
            new Translation(LanguageCode.FR, "Jordanie"),
            new Translation(LanguageCode.HE, "ירדן"),
            new Translation(LanguageCode.HR, "Jordan"),
            new Translation(LanguageCode.HU, "Jordánia"),
            new Translation(LanguageCode.HY, "Հորդանան"),
            new Translation(LanguageCode.ID, "Yordania"),
            new Translation(LanguageCode.IT, "Giordania"),
            new Translation(LanguageCode.JA, "ヨルダン"),
            new Translation(LanguageCode.KA, "იორდანია"),
            new Translation(LanguageCode.KK, "Иордания"),
            new Translation(LanguageCode.KO, "요르단"),
            new Translation(LanguageCode.KY, "Иордания"),
            new Translation(LanguageCode.LT, "Jordanija"),
            new Translation(LanguageCode.LV, "Jordānija"),
            new Translation(LanguageCode.MK, "Јордан"),
            new Translation(LanguageCode.MN, "Йордан"),
            new Translation(LanguageCode.NB, "Jordan"),
            new Translation(LanguageCode.NL, "Jordanië"),
            new Translation(LanguageCode.NN, "Jordan"),
            new Translation(LanguageCode.PL, "Jordania"),
            new Translation(LanguageCode.PT, "Jordânia"),
            new Translation(LanguageCode.RO, "Iordania"),
            new Translation(LanguageCode.RU, "Иордания"),
            new Translation(LanguageCode.SK, "Jordánsko"),
            new Translation(LanguageCode.SL, "Jordanija"),
            new Translation(LanguageCode.SR, "Јордан"),
            new Translation(LanguageCode.SV, "Jordanien"),
            new Translation(LanguageCode.TR, "Ürdün"),
            new Translation(LanguageCode.UK, "Йорданія"),
            new Translation(LanguageCode.UZ, "Iordaniya"),
            new Translation(LanguageCode.ZH, "约旦"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.JO;
        public Alpha3Code Alpha3Code => Alpha3Code.JOR;
        public int NumericCode => 400;
        public string[] TLD => new [] { ".jo", "الاردن." };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.IQ,
            Alpha2Code.IL,
            Alpha2Code.SA,
            Alpha2Code.SY,
        };

        public string[] Currencies => new [] { "JOD" };
        public string[] CallingCodes => new [] { "962" };
    }
}
