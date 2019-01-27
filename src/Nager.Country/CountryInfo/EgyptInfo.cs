namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Egypt
    /// </summary>
    public class EgyptInfo : ICountryInfo
    {
        public string CommonName => "Egypt";
        public string OfficialName => "Arab Republic of Egypt";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "مصر"),
            new Translation(LanguageCode.AZ, "Misir"),
            new Translation(LanguageCode.BE, "Егіпет"),
            new Translation(LanguageCode.BG, "Египет"),
            new Translation(LanguageCode.BS, "Egipat"),
            new Translation(LanguageCode.CA, "Egipte"),
            new Translation(LanguageCode.CS, "Egypt"),
            new Translation(LanguageCode.DA, "Egypten"),
            new Translation(LanguageCode.DE, "Ägypten"),
            new Translation(LanguageCode.EL, "Αίγυπτος"),
            new Translation(LanguageCode.EN, "Egypt"),
            new Translation(LanguageCode.ES, "Egipto"),
            new Translation(LanguageCode.ET, "Egiptus"),
            new Translation(LanguageCode.FA, "مصر"),
            new Translation(LanguageCode.FI, "Egypti"),
            new Translation(LanguageCode.FR, "Égypte"),
            new Translation(LanguageCode.HE, "מצרים"),
            new Translation(LanguageCode.HR, "Egipat"),
            new Translation(LanguageCode.HU, "Egyiptom"),
            new Translation(LanguageCode.HY, "Եգիպտոս"),
            new Translation(LanguageCode.ID, "Mesir"),
            new Translation(LanguageCode.IT, "Egitto"),
            new Translation(LanguageCode.JA, "エジプト"),
            new Translation(LanguageCode.KA, "ეგვიპტე"),
            new Translation(LanguageCode.KK, "Мысыр"),
            new Translation(LanguageCode.KO, "이집트"),
            new Translation(LanguageCode.KY, "Египет"),
            new Translation(LanguageCode.LT, "Egiptas"),
            new Translation(LanguageCode.LV, "Ēģipte"),
            new Translation(LanguageCode.MK, "Египет"),
            new Translation(LanguageCode.MN, "Египет"),
            new Translation(LanguageCode.NB, "Egypt"),
            new Translation(LanguageCode.NL, "Egypte"),
            new Translation(LanguageCode.NN, "Egypt"),
            new Translation(LanguageCode.PL, "Egipt"),
            new Translation(LanguageCode.PT, "Egito"),
            new Translation(LanguageCode.RO, "Egipt"),
            new Translation(LanguageCode.RU, "Египет"),
            new Translation(LanguageCode.SK, "Egypt"),
            new Translation(LanguageCode.SL, "Egipt"),
            new Translation(LanguageCode.SR, "Египат"),
            new Translation(LanguageCode.SV, "Egypten"),
            new Translation(LanguageCode.TR, "Mısır"),
            new Translation(LanguageCode.UK, "Єгипет"),
            new Translation(LanguageCode.UZ, "Misr"),
            new Translation(LanguageCode.ZH, "埃及"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.EG;
        public Alpha3Code Alpha3Code => Alpha3Code.EGY;
        public int NumericCode => 818;
        public string[] TLD => new [] { ".eg", ".مصر" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.IL,
            Alpha2Code.LY,
            Alpha2Code.SD,
        };

        public string[] Currencies => new [] { "EGP" };
        public string[] CallingCodes => new [] { "20" };
    }
}
