using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Argentina
    /// </summary>
    public class ArgentinaInfo : ICountryInfo
    {
        public string CommonName => "Argentina";
        public string OfficialName => "Argentine Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الأرجنتين"),
            new Translation(LanguageCode.AZ, "Argentina"),
            new Translation(LanguageCode.BE, "Аргенціна"),
            new Translation(LanguageCode.BG, "Аржентина"),
            new Translation(LanguageCode.BS, "Argentina"),
            new Translation(LanguageCode.CA, "Argentina"),
            new Translation(LanguageCode.CS, "Argentina"),
            new Translation(LanguageCode.DA, "Argentina"),
            new Translation(LanguageCode.DE, "Argentinien"),
            new Translation(LanguageCode.EL, "Αργεντινή"),
            new Translation(LanguageCode.EN, "Argentina"),
            new Translation(LanguageCode.ES, "Argentina"),
            new Translation(LanguageCode.ET, "Argentina"),
            new Translation(LanguageCode.FA, "آرژانتین"),
            new Translation(LanguageCode.FI, "Argentiina"),
            new Translation(LanguageCode.FR, "Argentine"),
            new Translation(LanguageCode.HE, "ארגנטינה"),
            new Translation(LanguageCode.HR, "Argentina"),
            new Translation(LanguageCode.HU, "Argentína"),
            new Translation(LanguageCode.HY, "Արգենտինա"),
            new Translation(LanguageCode.ID, "Argentina"),
            new Translation(LanguageCode.IT, "Argentina"),
            new Translation(LanguageCode.JA, "アルゼンチン"),
            new Translation(LanguageCode.KA, "არგენტინა"),
            new Translation(LanguageCode.KK, "Аргентина"),
            new Translation(LanguageCode.KO, "아르헨티나"),
            new Translation(LanguageCode.KY, "Аргентина"),
            new Translation(LanguageCode.LT, "Argentina"),
            new Translation(LanguageCode.LV, "Argentīna"),
            new Translation(LanguageCode.MK, "Аргентина"),
            new Translation(LanguageCode.MN, "Аргентин"),
            new Translation(LanguageCode.NB, "Argentina"),
            new Translation(LanguageCode.NL, "Argentinië"),
            new Translation(LanguageCode.NN, "Argentina"),
            new Translation(LanguageCode.PL, "Argentyna"),
            new Translation(LanguageCode.PT, "Argentina"),
            new Translation(LanguageCode.RO, "Argentina"),
            new Translation(LanguageCode.RU, "Аргентина"),
            new Translation(LanguageCode.SK, "Argentína"),
            new Translation(LanguageCode.SL, "Argentina"),
            new Translation(LanguageCode.SR, "Аргентина"),
            new Translation(LanguageCode.SV, "Argentina"),
            new Translation(LanguageCode.TR, "Arjantin"),
            new Translation(LanguageCode.UK, "Аргентина"),
            new Translation(LanguageCode.UZ, "Argentina"),
            new Translation(LanguageCode.ZH, "阿根廷"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AR;
        public Alpha3Code Alpha3Code => Alpha3Code.ARG;
        public int NumericCode => 032;
        public string[] TLD => new [] { ".ar" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BO,
            Alpha2Code.BR,
            Alpha2Code.CL,
            Alpha2Code.PY,
            Alpha2Code.UY,
        };

        public ICurrency[] Currencies => new [] { new ArsCurrency() };
        public string[] CallingCodes => new [] { "54" };
    }
}
