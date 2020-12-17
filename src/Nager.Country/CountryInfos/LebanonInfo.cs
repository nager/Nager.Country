namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Lebanon
    /// </summary>
    public class LebanonInfo : ICountryInfo
    {
        public string CommonName => "Lebanon";
        public string OfficialName => "Lebanese Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "لبنان"),
            new Translation(LanguageCode.AZ, "Livan"),
            new Translation(LanguageCode.BE, "Ліван"),
            new Translation(LanguageCode.BG, "Ливан"),
            new Translation(LanguageCode.BS, "Liban"),
            new Translation(LanguageCode.CA, "Líban"),
            new Translation(LanguageCode.CS, "Libanon"),
            new Translation(LanguageCode.DA, "Libanon"),
            new Translation(LanguageCode.DE, "Libanon"),
            new Translation(LanguageCode.EL, "Λίβανο"),
            new Translation(LanguageCode.EN, "Lebanon"),
            new Translation(LanguageCode.ES, "Líbano"),
            new Translation(LanguageCode.ET, "Liibanon"),
            new Translation(LanguageCode.FA, "لبنان"),
            new Translation(LanguageCode.FI, "Libanon"),
            new Translation(LanguageCode.FR, "Liban"),
            new Translation(LanguageCode.HE, "לבנון"),
            new Translation(LanguageCode.HR, "Libanon"),
            new Translation(LanguageCode.HU, "Libanon"),
            new Translation(LanguageCode.HY, "Լիբանան"),
            new Translation(LanguageCode.ID, "Lebanon"),
            new Translation(LanguageCode.IT, "Libano"),
            new Translation(LanguageCode.JA, "レバノン"),
            new Translation(LanguageCode.KA, "ლიბანი"),
            new Translation(LanguageCode.KK, "Ливан"),
            new Translation(LanguageCode.KO, "레바논"),
            new Translation(LanguageCode.KY, "Ливан"),
            new Translation(LanguageCode.LT, "Libanas"),
            new Translation(LanguageCode.LV, "Libāna"),
            new Translation(LanguageCode.MK, "Либан"),
            new Translation(LanguageCode.MN, "Ливан"),
            new Translation(LanguageCode.NB, "Libanon"),
            new Translation(LanguageCode.NL, "Libanon"),
            new Translation(LanguageCode.NN, "Libanon"),
            new Translation(LanguageCode.PL, "Liban"),
            new Translation(LanguageCode.PT, "Líbano"),
            new Translation(LanguageCode.RO, "Liban"),
            new Translation(LanguageCode.RU, "Ливан"),
            new Translation(LanguageCode.SK, "Libanon"),
            new Translation(LanguageCode.SL, "Libanon"),
            new Translation(LanguageCode.SR, "Либан"),
            new Translation(LanguageCode.SV, "Libanon"),
            new Translation(LanguageCode.TR, "Lübnan"),
            new Translation(LanguageCode.UK, "Ліван"),
            new Translation(LanguageCode.UZ, "Livan"),
            new Translation(LanguageCode.ZH, "黎巴嫩"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.LB;
        public Alpha3Code Alpha3Code => Alpha3Code.LBN;
        public int NumericCode => 422;
        public string[] TLD => new [] { ".lb" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.IL,
            Alpha2Code.SY,
        };

        public string[] Currencies => new [] { "LBP" };
        public string[] CallingCodes => new [] { "961" };
    }
}
