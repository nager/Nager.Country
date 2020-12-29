using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Monaco
    /// </summary>
    public class MonacoInfo : ICountryInfo
    {
        public string CommonName => "Monaco";
        public string OfficialName => "Principality of Monaco";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "موناكو"),
            new Translation(LanguageCode.AZ, "Monako"),
            new Translation(LanguageCode.BE, "Манака"),
            new Translation(LanguageCode.BG, "Монако"),
            new Translation(LanguageCode.BS, "Monako"),
            new Translation(LanguageCode.CA, "Mònaco"),
            new Translation(LanguageCode.CS, "Monako"),
            new Translation(LanguageCode.DA, "Monaco"),
            new Translation(LanguageCode.DE, "Monaco"),
            new Translation(LanguageCode.EL, "Πριγκιπάτο του Μονακό"),
            new Translation(LanguageCode.EN, "Monaco"),
            new Translation(LanguageCode.ES, "Mónaco"),
            new Translation(LanguageCode.ET, "Monaco"),
            new Translation(LanguageCode.FA, "موناکو"),
            new Translation(LanguageCode.FI, "Monaco"),
            new Translation(LanguageCode.FR, "Monaco"),
            new Translation(LanguageCode.HE, "מונקו"),
            new Translation(LanguageCode.HR, "Monako"),
            new Translation(LanguageCode.HU, "Monaco"),
            new Translation(LanguageCode.HY, "Մոնակո"),
            new Translation(LanguageCode.ID, "Monako"),
            new Translation(LanguageCode.IT, "Monaco"),
            new Translation(LanguageCode.JA, "モナコ"),
            new Translation(LanguageCode.KA, "მონაკო"),
            new Translation(LanguageCode.KK, "Монако"),
            new Translation(LanguageCode.KO, "모나코"),
            new Translation(LanguageCode.KY, "Монако"),
            new Translation(LanguageCode.LT, "Monakas"),
            new Translation(LanguageCode.LV, "Monako"),
            new Translation(LanguageCode.MK, "Монако"),
            new Translation(LanguageCode.MN, "Монако"),
            new Translation(LanguageCode.NB, "Monaco"),
            new Translation(LanguageCode.NL, "Monaco"),
            new Translation(LanguageCode.NN, "Monaco"),
            new Translation(LanguageCode.PL, "Monako"),
            new Translation(LanguageCode.PT, "Mônaco"),
            new Translation(LanguageCode.RO, "Monaco"),
            new Translation(LanguageCode.RU, "Монако"),
            new Translation(LanguageCode.SK, "Monako"),
            new Translation(LanguageCode.SL, "Monako"),
            new Translation(LanguageCode.SR, "Монако"),
            new Translation(LanguageCode.SV, "Monaco"),
            new Translation(LanguageCode.TR, "Monako"),
            new Translation(LanguageCode.UK, "Монако"),
            new Translation(LanguageCode.UZ, "Monako"),
            new Translation(LanguageCode.ZH, "摩纳哥"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MC;
        public Alpha3Code Alpha3Code => Alpha3Code.MCO;
        public int NumericCode => 492;
        public string[] TLD => new [] { ".mc" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.FR,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "377" };
    }
}
