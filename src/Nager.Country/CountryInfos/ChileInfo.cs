using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Chile
    /// </summary>
    public class ChileInfo : ICountryInfo
    {
        public string CommonName => "Chile";
        public string OfficialName => "Republic of Chile";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "تشيلي"),
            new Translation(LanguageCode.AZ, "Çili"),
            new Translation(LanguageCode.BE, "Чылі"),
            new Translation(LanguageCode.BG, "Чили"),
            new Translation(LanguageCode.BS, "Čile"),
            new Translation(LanguageCode.CA, "Xile"),
            new Translation(LanguageCode.CS, "Chile"),
            new Translation(LanguageCode.DA, "Chile"),
            new Translation(LanguageCode.DE, "Chile"),
            new Translation(LanguageCode.EL, "Χιλή"),
            new Translation(LanguageCode.EN, "Chile"),
            new Translation(LanguageCode.ES, "Chile"),
            new Translation(LanguageCode.ET, "Tšiili"),
            new Translation(LanguageCode.FA, "شیلی"),
            new Translation(LanguageCode.FI, "Chile"),
            new Translation(LanguageCode.FR, "Chili"),
            new Translation(LanguageCode.HE, "צ׳ילה"),
            new Translation(LanguageCode.HR, "Čile"),
            new Translation(LanguageCode.HU, "Chile"),
            new Translation(LanguageCode.HY, "Չիլի"),
            new Translation(LanguageCode.ID, "Chile"),
            new Translation(LanguageCode.IT, "Cile"),
            new Translation(LanguageCode.JA, "チリ"),
            new Translation(LanguageCode.KA, "ჩილე"),
            new Translation(LanguageCode.KK, "Чили"),
            new Translation(LanguageCode.KO, "칠레"),
            new Translation(LanguageCode.KY, "Чили"),
            new Translation(LanguageCode.LT, "Čilė"),
            new Translation(LanguageCode.LV, "Čīle"),
            new Translation(LanguageCode.MK, "Чиле"),
            new Translation(LanguageCode.MN, "Чили"),
            new Translation(LanguageCode.NB, "Chile"),
            new Translation(LanguageCode.NL, "Chili"),
            new Translation(LanguageCode.NN, "Chile"),
            new Translation(LanguageCode.PL, "Chile"),
            new Translation(LanguageCode.PT, "Chile"),
            new Translation(LanguageCode.RO, "Chile"),
            new Translation(LanguageCode.RU, "Чили"),
            new Translation(LanguageCode.SK, "Čile"),
            new Translation(LanguageCode.SL, "Čile"),
            new Translation(LanguageCode.SR, "Чиле"),
            new Translation(LanguageCode.SV, "Chile"),
            new Translation(LanguageCode.TR, "Şili"),
            new Translation(LanguageCode.UK, "Чілі"),
            new Translation(LanguageCode.UZ, "Chili"),
            new Translation(LanguageCode.ZH, "智利"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CL;
        public Alpha3Code Alpha3Code => Alpha3Code.CHL;
        public int NumericCode => 152;
        public string[] TLD => new [] { ".cl" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BO,
            Alpha2Code.PE,
        };

        public ICurrency[] Currencies => new [] { new ClpCurrency() };
        public string[] CallingCodes => new [] { "56" };
    }
}
