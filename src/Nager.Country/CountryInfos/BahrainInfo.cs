namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bahrain
    /// </summary>
    public class BahrainInfo : ICountryInfo
    {
        public string CommonName => "Bahrain";
        public string OfficialName => "Kingdom of Bahrain";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "البحرين"),
            new Translation(LanguageCode.AZ, "Bəhreyn"),
            new Translation(LanguageCode.BE, "Бахрэйн"),
            new Translation(LanguageCode.BG, "Бахрейн"),
            new Translation(LanguageCode.BS, "Bahrein"),
            new Translation(LanguageCode.CA, "Bahrain"),
            new Translation(LanguageCode.CS, "Bahrajn"),
            new Translation(LanguageCode.DA, "Bahrain"),
            new Translation(LanguageCode.DE, "Bahrain"),
            new Translation(LanguageCode.EL, "Μπαχρέιν"),
            new Translation(LanguageCode.EN, "Bahrain"),
            new Translation(LanguageCode.ES, "Bahrein"),
            new Translation(LanguageCode.ET, "Bahrein"),
            new Translation(LanguageCode.FA, "بحرین"),
            new Translation(LanguageCode.FI, "Bahrain"),
            new Translation(LanguageCode.FR, "Bahrein"),
            new Translation(LanguageCode.HE, "בחריין"),
            new Translation(LanguageCode.HR, "Bahrein"),
            new Translation(LanguageCode.HU, "Bahrein"),
            new Translation(LanguageCode.HY, "Բահրեյն"),
            new Translation(LanguageCode.ID, "Bahrain"),
            new Translation(LanguageCode.IT, "Bahrain"),
            new Translation(LanguageCode.JA, "バーレーン"),
            new Translation(LanguageCode.KA, "ბაჰრეინი"),
            new Translation(LanguageCode.KK, "Бахрейн"),
            new Translation(LanguageCode.KO, "바레인"),
            new Translation(LanguageCode.KY, "Бахрейн"),
            new Translation(LanguageCode.LT, "Bahreinas"),
            new Translation(LanguageCode.LV, "Bahreina"),
            new Translation(LanguageCode.MK, "Бахреин"),
            new Translation(LanguageCode.MN, "Бахрейн"),
            new Translation(LanguageCode.NB, "Bahrain"),
            new Translation(LanguageCode.NL, "Bahrein"),
            new Translation(LanguageCode.NN, "Bahrain"),
            new Translation(LanguageCode.PL, "Bahrajn"),
            new Translation(LanguageCode.PT, "Bahrein"),
            new Translation(LanguageCode.RO, "Bahrain"),
            new Translation(LanguageCode.RU, "Бахрейн"),
            new Translation(LanguageCode.SK, "Bahrajn"),
            new Translation(LanguageCode.SL, "Bahrajn"),
            new Translation(LanguageCode.SR, "Бахреин"),
            new Translation(LanguageCode.SV, "Bahrain"),
            new Translation(LanguageCode.TR, "Bahreyn"),
            new Translation(LanguageCode.UK, "Бахрейн"),
            new Translation(LanguageCode.UZ, "Bahrayn"),
            new Translation(LanguageCode.ZH, "巴林"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BH;
        public Alpha3Code Alpha3Code => Alpha3Code.BHR;
        public int NumericCode => 048;
        public string[] TLD => new [] { ".bh" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public string[] Currencies => new [] { "BHD" };
        public string[] CallingCodes => new [] { "973" };
    }
}
