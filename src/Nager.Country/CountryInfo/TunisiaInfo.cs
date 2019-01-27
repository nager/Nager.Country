namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Tunisia
    /// </summary>
    public class TunisiaInfo : ICountryInfo
    {
        public string CommonName => "Tunisia";
        public string OfficialName => "Tunisian Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "تونس"),
            new Translation(LanguageCode.AZ, "Tunis"),
            new Translation(LanguageCode.BE, "Туніс"),
            new Translation(LanguageCode.BG, "Тунис"),
            new Translation(LanguageCode.BS, "Tunis"),
            new Translation(LanguageCode.CA, "Tunísia"),
            new Translation(LanguageCode.CS, "Tunisko"),
            new Translation(LanguageCode.DA, "Tunesien"),
            new Translation(LanguageCode.DE, "Tunesien"),
            new Translation(LanguageCode.EL, "Τυνησία"),
            new Translation(LanguageCode.EN, "Tunisia"),
            new Translation(LanguageCode.ES, "Túnez"),
            new Translation(LanguageCode.ET, "Tuneesia"),
            new Translation(LanguageCode.FA, "تونس"),
            new Translation(LanguageCode.FI, "Tunisia"),
            new Translation(LanguageCode.FR, "Tunisie"),
            new Translation(LanguageCode.HE, "טוניסיה"),
            new Translation(LanguageCode.HR, "Tunis"),
            new Translation(LanguageCode.HU, "Tunézia"),
            new Translation(LanguageCode.HY, "Թունիս"),
            new Translation(LanguageCode.ID, "Tunisia"),
            new Translation(LanguageCode.IT, "Tunisia"),
            new Translation(LanguageCode.JA, "チュニジア"),
            new Translation(LanguageCode.KA, "ტუნისი"),
            new Translation(LanguageCode.KK, "Тунис"),
            new Translation(LanguageCode.KO, "튀니지"),
            new Translation(LanguageCode.KY, "Тунис"),
            new Translation(LanguageCode.LT, "Tunisas"),
            new Translation(LanguageCode.LV, "Tunisija"),
            new Translation(LanguageCode.MK, "Тунис"),
            new Translation(LanguageCode.MN, "Тунис"),
            new Translation(LanguageCode.NB, "Tunisia"),
            new Translation(LanguageCode.NL, "Tunesië"),
            new Translation(LanguageCode.NN, "Tunisia"),
            new Translation(LanguageCode.PL, "Tunezja"),
            new Translation(LanguageCode.PT, "Tunísia"),
            new Translation(LanguageCode.RO, "Tunisia"),
            new Translation(LanguageCode.RU, "Тунис"),
            new Translation(LanguageCode.SK, "Tunisko"),
            new Translation(LanguageCode.SL, "Tunizija"),
            new Translation(LanguageCode.SR, "Тунис"),
            new Translation(LanguageCode.SV, "Tunisien"),
            new Translation(LanguageCode.TR, "Tunus"),
            new Translation(LanguageCode.UK, "Туніс"),
            new Translation(LanguageCode.UZ, "Tunis"),
            new Translation(LanguageCode.ZH, "突尼西亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TN;
        public Alpha3Code Alpha3Code => Alpha3Code.TUN;
        public int NumericCode => 788;
        public string[] TLD => new [] { ".tn" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.LY,
        };

        public string[] Currencies => new [] { "TND" };
        public string[] CallingCodes => new [] { "216" };
    }
}
