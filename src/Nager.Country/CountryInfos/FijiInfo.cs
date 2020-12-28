using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Fiji
    /// </summary>
    public class FijiInfo : ICountryInfo
    {
        public string CommonName => "Fiji";
        public string OfficialName => "Republic of Fiji";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "فيجي"),
            new Translation(LanguageCode.AZ, "Fici"),
            new Translation(LanguageCode.BE, "Фіджы"),
            new Translation(LanguageCode.BG, "Фиджи"),
            new Translation(LanguageCode.BS, "Fidži"),
            new Translation(LanguageCode.CA, "Fiji"),
            new Translation(LanguageCode.CS, "Fidži"),
            new Translation(LanguageCode.DA, "Fiji"),
            new Translation(LanguageCode.DE, "Fidschi"),
            new Translation(LanguageCode.EL, "Δημοκρατία των Φίτζι"),
            new Translation(LanguageCode.EN, "Fiji"),
            new Translation(LanguageCode.ES, "Fiji"),
            new Translation(LanguageCode.ET, "Fidži"),
            new Translation(LanguageCode.FA, "فیجی"),
            new Translation(LanguageCode.FI, "Fidži"),
            new Translation(LanguageCode.FR, "Fidji"),
            new Translation(LanguageCode.HE, "פיג׳י"),
            new Translation(LanguageCode.HR, "Fidži"),
            new Translation(LanguageCode.HU, "Fidzsi-szigetek"),
            new Translation(LanguageCode.HY, "Ֆիջի"),
            new Translation(LanguageCode.ID, "Fiji"),
            new Translation(LanguageCode.IT, "Figi"),
            new Translation(LanguageCode.JA, "フィジー"),
            new Translation(LanguageCode.KA, "ფიჯი"),
            new Translation(LanguageCode.KK, "Фиджи"),
            new Translation(LanguageCode.KO, "피지"),
            new Translation(LanguageCode.KY, "Фиджи"),
            new Translation(LanguageCode.LT, "Fidžis"),
            new Translation(LanguageCode.LV, "Fidži"),
            new Translation(LanguageCode.MK, "Фиџи"),
            new Translation(LanguageCode.MN, "Фижи"),
            new Translation(LanguageCode.NB, "Fiji"),
            new Translation(LanguageCode.NL, "Fiji"),
            new Translation(LanguageCode.NN, "Fiji"),
            new Translation(LanguageCode.PL, "Fidżi"),
            new Translation(LanguageCode.PT, "Fiji"),
            new Translation(LanguageCode.RO, "Fiji"),
            new Translation(LanguageCode.RU, "Фиджи"),
            new Translation(LanguageCode.SK, "Fidži"),
            new Translation(LanguageCode.SL, "Fidži"),
            new Translation(LanguageCode.SR, "Фиџи"),
            new Translation(LanguageCode.SV, "Fiji"),
            new Translation(LanguageCode.TR, "Fiji"),
            new Translation(LanguageCode.UK, "Фіджі"),
            new Translation(LanguageCode.UZ, "Fiji"),
            new Translation(LanguageCode.ZH, "斐济"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.FJ;
        public Alpha3Code Alpha3Code => Alpha3Code.FJI;
        public int NumericCode => 242;
        public string[] TLD => new [] { ".fj" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Melanesia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new FjdCurrency() };
        public string[] CallingCodes => new [] { "679" };
    }
}
