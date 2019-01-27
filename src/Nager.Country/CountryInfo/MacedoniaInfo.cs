namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Macedonia
    /// </summary>
    public class MacedoniaInfo : ICountryInfo
    {
        public string CommonName => "Macedonia";
        public string OfficialName => "Republic of Macedonia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "مقدونيا"),
            new Translation(LanguageCode.AZ, "Makedoniya"),
            new Translation(LanguageCode.BE, "Македонія"),
            new Translation(LanguageCode.BG, "Македония"),
            new Translation(LanguageCode.BS, "Makedonija"),
            new Translation(LanguageCode.CA, "Macedònia"),
            new Translation(LanguageCode.CS, "Makedonie"),
            new Translation(LanguageCode.DA, "Makedonien"),
            new Translation(LanguageCode.DE, "Mazedonien"),
            new Translation(LanguageCode.EL, "πρώην Γιουγκοσλαβική Δημοκρατία της Μακεδονίας"),
            new Translation(LanguageCode.EN, "Macedonia, the Former Yugoslav Republic of"),
            new Translation(LanguageCode.ES, "Macedonia"),
            new Translation(LanguageCode.ET, "Makedoonia"),
            new Translation(LanguageCode.FA, "مقدونیه"),
            new Translation(LanguageCode.FI, "Makedonia"),
            new Translation(LanguageCode.FR, "Macédoine, Ex-République yougoslave"),
            new Translation(LanguageCode.HE, "מקדוניה"),
            new Translation(LanguageCode.HR, "Makedonija"),
            new Translation(LanguageCode.HU, "Macedónia"),
            new Translation(LanguageCode.HY, "Մակեդոնիա"),
            new Translation(LanguageCode.ID, "Makedonia"),
            new Translation(LanguageCode.IT, "Macedonia"),
            new Translation(LanguageCode.JA, "マケドニア旧ユーゴスラビア共和国"),
            new Translation(LanguageCode.KA, "მაკედონია"),
            new Translation(LanguageCode.KK, "Македония Республикасы"),
            new Translation(LanguageCode.KO, "마케도니아, 이전의 유고 슬라비아 공화국"),
            new Translation(LanguageCode.KY, "Македония"),
            new Translation(LanguageCode.LT, "Makedonija"),
            new Translation(LanguageCode.LV, "Maķedonija"),
            new Translation(LanguageCode.MK, "Македонија"),
            new Translation(LanguageCode.MN, "Македон"),
            new Translation(LanguageCode.NB, "Makedonia"),
            new Translation(LanguageCode.NL, "Macedonië, Ex-Joegoslavische Republiek"),
            new Translation(LanguageCode.NN, "Makedonia"),
            new Translation(LanguageCode.PL, "Macedonia"),
            new Translation(LanguageCode.PT, "Macedônia"),
            new Translation(LanguageCode.RO, "Republica Macedonia"),
            new Translation(LanguageCode.RU, "Македония"),
            new Translation(LanguageCode.SK, "Macedónsko"),
            new Translation(LanguageCode.SL, "Makedonija"),
            new Translation(LanguageCode.SR, "Македонија"),
            new Translation(LanguageCode.SV, "Makedonien"),
            new Translation(LanguageCode.TR, "Makedonya"),
            new Translation(LanguageCode.UK, "Македонія"),
            new Translation(LanguageCode.UZ, "Makedoniya"),
            new Translation(LanguageCode.ZH, "马其顿"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MK;
        public Alpha3Code Alpha3Code => Alpha3Code.MKD;
        public int NumericCode => 807;
        public string[] TLD => new [] { ".mk" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AL,
            Alpha2Code.BG,
            Alpha2Code.GR,
            Alpha2Code.RS,
        };

        public string[] Currencies => new [] { "MKD" };
        public string[] CallingCodes => new [] { "389" };
    }
}
