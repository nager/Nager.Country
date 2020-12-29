using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Liberia
    /// </summary>
    public class LiberiaInfo : ICountryInfo
    {
        public string CommonName => "Liberia";
        public string OfficialName => "Republic of Liberia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ليبيريا"),
            new Translation(LanguageCode.AZ, "Liberiya"),
            new Translation(LanguageCode.BE, "Ліберыя"),
            new Translation(LanguageCode.BG, "Либерия"),
            new Translation(LanguageCode.BS, "Liberija"),
            new Translation(LanguageCode.CA, "Libèria"),
            new Translation(LanguageCode.CS, "Libérie"),
            new Translation(LanguageCode.DA, "Liberia"),
            new Translation(LanguageCode.DE, "Liberia"),
            new Translation(LanguageCode.EL, "Λιβερία"),
            new Translation(LanguageCode.EN, "Liberia"),
            new Translation(LanguageCode.ES, "Liberia"),
            new Translation(LanguageCode.ET, "Libeeria"),
            new Translation(LanguageCode.FA, "لیبریا"),
            new Translation(LanguageCode.FI, "Liberia"),
            new Translation(LanguageCode.FR, "Libéria"),
            new Translation(LanguageCode.HE, "ליבריה"),
            new Translation(LanguageCode.HR, "Liberija"),
            new Translation(LanguageCode.HU, "Libéria"),
            new Translation(LanguageCode.HY, "Լիբերիա"),
            new Translation(LanguageCode.ID, "Liberia"),
            new Translation(LanguageCode.IT, "Liberia"),
            new Translation(LanguageCode.JA, "リベリア"),
            new Translation(LanguageCode.KA, "ლიბერია"),
            new Translation(LanguageCode.KK, "Либерия"),
            new Translation(LanguageCode.KO, "라이베리아"),
            new Translation(LanguageCode.KY, "Либерия"),
            new Translation(LanguageCode.LT, "Liberija"),
            new Translation(LanguageCode.LV, "Libērija"),
            new Translation(LanguageCode.MK, "Либерија"),
            new Translation(LanguageCode.MN, "Либери"),
            new Translation(LanguageCode.NB, "Liberia"),
            new Translation(LanguageCode.NL, "Liberia"),
            new Translation(LanguageCode.NN, "Liberia"),
            new Translation(LanguageCode.PL, "Liberia"),
            new Translation(LanguageCode.PT, "Libéria"),
            new Translation(LanguageCode.RO, "Liberia"),
            new Translation(LanguageCode.RU, "Либерия"),
            new Translation(LanguageCode.SK, "Libéria"),
            new Translation(LanguageCode.SL, "Liberija"),
            new Translation(LanguageCode.SR, "Либерија"),
            new Translation(LanguageCode.SV, "Liberia"),
            new Translation(LanguageCode.TR, "Liberya"),
            new Translation(LanguageCode.UK, "Ліберія"),
            new Translation(LanguageCode.UZ, "Liberiya"),
            new Translation(LanguageCode.ZH, "利比里亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.LR;
        public Alpha3Code Alpha3Code => Alpha3Code.LBR;
        public int NumericCode => 430;
        public string[] TLD => new [] { ".lr" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GN,
            Alpha2Code.CI,
            Alpha2Code.SL,
        };

        public ICurrency[] Currencies => new [] { new LrdCurrency() };
        public string[] CallingCodes => new [] { "231" };
    }
}
