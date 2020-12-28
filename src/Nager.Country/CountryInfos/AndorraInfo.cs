using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Andorra
    /// </summary>
    public class AndorraInfo : ICountryInfo
    {
        public string CommonName => "Andorra";
        public string OfficialName => "Principality of Andorra";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أندورا"),
            new Translation(LanguageCode.AZ, "Andorra"),
            new Translation(LanguageCode.BE, "Андора"),
            new Translation(LanguageCode.BG, "Андора"),
            new Translation(LanguageCode.BS, "Andora"),
            new Translation(LanguageCode.CA, "Andorra"),
            new Translation(LanguageCode.CS, "Andorra"),
            new Translation(LanguageCode.DA, "Andorra"),
            new Translation(LanguageCode.DE, "Andorra"),
            new Translation(LanguageCode.EL, "Ανδόρρα"),
            new Translation(LanguageCode.EN, "Andorra"),
            new Translation(LanguageCode.ES, "Andorra"),
            new Translation(LanguageCode.ET, "Andorra"),
            new Translation(LanguageCode.FA, "آندورا"),
            new Translation(LanguageCode.FI, "Andorra"),
            new Translation(LanguageCode.FR, "Andorre"),
            new Translation(LanguageCode.HE, "אנדורה"),
            new Translation(LanguageCode.HR, "Andora"),
            new Translation(LanguageCode.HU, "Andorra"),
            new Translation(LanguageCode.HY, "Անդորրա"),
            new Translation(LanguageCode.ID, "Andorra"),
            new Translation(LanguageCode.IT, "Andorra"),
            new Translation(LanguageCode.JA, "アンドラ"),
            new Translation(LanguageCode.KA, "ანდორა"),
            new Translation(LanguageCode.KK, "Андорра"),
            new Translation(LanguageCode.KO, "안도라"),
            new Translation(LanguageCode.KY, "Андорра"),
            new Translation(LanguageCode.LT, "Andora"),
            new Translation(LanguageCode.LV, "Andora"),
            new Translation(LanguageCode.MK, "Андора"),
            new Translation(LanguageCode.MN, "Андорра"),
            new Translation(LanguageCode.NB, "Andorra"),
            new Translation(LanguageCode.NL, "Andorra"),
            new Translation(LanguageCode.NN, "Andorra"),
            new Translation(LanguageCode.PL, "Andora"),
            new Translation(LanguageCode.PT, "Andorra"),
            new Translation(LanguageCode.RO, "Andorra"),
            new Translation(LanguageCode.RU, "Андорра"),
            new Translation(LanguageCode.SK, "Andorra"),
            new Translation(LanguageCode.SL, "Andora"),
            new Translation(LanguageCode.SR, "Андора"),
            new Translation(LanguageCode.SV, "Andorra"),
            new Translation(LanguageCode.TR, "Andorra"),
            new Translation(LanguageCode.UK, "Андорра"),
            new Translation(LanguageCode.UZ, "Andorra"),
            new Translation(LanguageCode.ZH, "安道尔"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AD;
        public Alpha3Code Alpha3Code => Alpha3Code.AND;
        public int NumericCode => 020;
        public string[] TLD => new [] { ".ad" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.FR,
            Alpha2Code.ES,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "376" };
    }
}
