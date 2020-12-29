using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ukraine
    /// </summary>
    public class UkraineInfo : ICountryInfo
    {
        public string CommonName => "Ukraine";
        public string OfficialName => "Ukraine";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أوكرانيا"),
            new Translation(LanguageCode.AZ, "Ukrayna"),
            new Translation(LanguageCode.BE, "Украіна"),
            new Translation(LanguageCode.BG, "Украйна"),
            new Translation(LanguageCode.BS, "Ukrajina"),
            new Translation(LanguageCode.CA, "Ucraïna"),
            new Translation(LanguageCode.CS, "Ukrajina"),
            new Translation(LanguageCode.DA, "Ukraine"),
            new Translation(LanguageCode.DE, "Ukraine"),
            new Translation(LanguageCode.EL, "Ουκρανια"),
            new Translation(LanguageCode.EN, "Ukraine"),
            new Translation(LanguageCode.ES, "Ucrania"),
            new Translation(LanguageCode.ET, "Ukraina"),
            new Translation(LanguageCode.FA, "اوکراین"),
            new Translation(LanguageCode.FI, "Ukraina"),
            new Translation(LanguageCode.FR, "Ukraine"),
            new Translation(LanguageCode.HE, "אוקראינה"),
            new Translation(LanguageCode.HR, "Ukrajina"),
            new Translation(LanguageCode.HU, "Ukrajna"),
            new Translation(LanguageCode.HY, "Ուկրաինա"),
            new Translation(LanguageCode.ID, "Ukraina"),
            new Translation(LanguageCode.IT, "Ucraina"),
            new Translation(LanguageCode.JA, "ウクライナ"),
            new Translation(LanguageCode.KA, "უკრაინა"),
            new Translation(LanguageCode.KK, "Украина"),
            new Translation(LanguageCode.KO, "우크라이나"),
            new Translation(LanguageCode.KY, "Украина"),
            new Translation(LanguageCode.LT, "Ukraina"),
            new Translation(LanguageCode.LV, "Ukraina"),
            new Translation(LanguageCode.MK, "Украина"),
            new Translation(LanguageCode.MN, "Украин"),
            new Translation(LanguageCode.NB, "Ukraina"),
            new Translation(LanguageCode.NL, "Oekraïne"),
            new Translation(LanguageCode.NN, "Ukraina"),
            new Translation(LanguageCode.PL, "Ukraina"),
            new Translation(LanguageCode.PT, "Ucrânia"),
            new Translation(LanguageCode.RO, "Ucraina"),
            new Translation(LanguageCode.RU, "Украина"),
            new Translation(LanguageCode.SK, "Ukrajina"),
            new Translation(LanguageCode.SL, "Ukrajina"),
            new Translation(LanguageCode.SR, "Украјина"),
            new Translation(LanguageCode.SV, "Ukraina"),
            new Translation(LanguageCode.TR, "Ukrayna"),
            new Translation(LanguageCode.UK, "Україна"),
            new Translation(LanguageCode.UZ, "Ukraina"),
            new Translation(LanguageCode.ZH, "乌克兰"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.UA;
        public Alpha3Code Alpha3Code => Alpha3Code.UKR;
        public int NumericCode => 804;
        public string[] TLD => new [] { ".ua", ".укр" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BY,
            Alpha2Code.HU,
            Alpha2Code.MD,
            Alpha2Code.PL,
            Alpha2Code.RO,
            Alpha2Code.RU,
            Alpha2Code.SK,
        };

        public ICurrency[] Currencies => new [] { new UahCurrency() };
        public string[] CallingCodes => new [] { "380" };
    }
}
