using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kazakhstan
    /// </summary>
    public class KazakhstanInfo : ICountryInfo
    {
        public string CommonName => "Kazakhstan";
        public string OfficialName => "Republic of Kazakhstan";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "كازاخستان"),
            new Translation(LanguageCode.AZ, "Qazaxıstan"),
            new Translation(LanguageCode.BE, "Казахстан"),
            new Translation(LanguageCode.BG, "Казахстан"),
            new Translation(LanguageCode.BS, "Kazahstan"),
            new Translation(LanguageCode.CA, "Kazakhstan"),
            new Translation(LanguageCode.CS, "Kazachstán"),
            new Translation(LanguageCode.DA, "Kazakhstan"),
            new Translation(LanguageCode.DE, "Kasachstan"),
            new Translation(LanguageCode.EL, "Καζακστάν"),
            new Translation(LanguageCode.EN, "Kazakhstan"),
            new Translation(LanguageCode.ES, "Kazajstán"),
            new Translation(LanguageCode.ET, "Kasahstan"),
            new Translation(LanguageCode.FA, "قزاقستان"),
            new Translation(LanguageCode.FI, "Kazakstan"),
            new Translation(LanguageCode.FR, "Kazakhstan"),
            new Translation(LanguageCode.HE, "קזחסטן"),
            new Translation(LanguageCode.HR, "Kazahstan"),
            new Translation(LanguageCode.HU, "Kazahsztán"),
            new Translation(LanguageCode.HY, "Ղազախստան"),
            new Translation(LanguageCode.ID, "Kazakhstan"),
            new Translation(LanguageCode.IT, "Kazakistan"),
            new Translation(LanguageCode.JA, "カザフスタン"),
            new Translation(LanguageCode.KA, "ყაზახეთი"),
            new Translation(LanguageCode.KK, "Қазақстан"),
            new Translation(LanguageCode.KO, "카자흐스탄"),
            new Translation(LanguageCode.KY, "Казакстан"),
            new Translation(LanguageCode.LT, "Kazachstanas"),
            new Translation(LanguageCode.LV, "Kazahstāna"),
            new Translation(LanguageCode.MK, "Казахстан"),
            new Translation(LanguageCode.MN, "Казахстан"),
            new Translation(LanguageCode.NB, "Kasakhstan"),
            new Translation(LanguageCode.NL, "Kazachstan"),
            new Translation(LanguageCode.NN, "Kasakhstan"),
            new Translation(LanguageCode.PL, "Kazachstan"),
            new Translation(LanguageCode.PT, "Cazaquistão"),
            new Translation(LanguageCode.RO, "Kazahstan"),
            new Translation(LanguageCode.RU, "Казахстан"),
            new Translation(LanguageCode.SK, "Kazachstan"),
            new Translation(LanguageCode.SL, "Kazahstan"),
            new Translation(LanguageCode.SR, "Казахстан"),
            new Translation(LanguageCode.SV, "Kazakstan"),
            new Translation(LanguageCode.TR, "Kazakistan"),
            new Translation(LanguageCode.UK, "Казахстан"),
            new Translation(LanguageCode.UZ, "Qozogʻiston"),
            new Translation(LanguageCode.ZH, "哈萨克斯坦"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.KZ;
        public Alpha3Code Alpha3Code => Alpha3Code.KAZ;
        public int NumericCode => 398;
        public string[] TLD => new [] { ".kz", ".қаз" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.CentralAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.KG,
            Alpha2Code.RU,
            Alpha2Code.TM,
            Alpha2Code.UZ,
        };

        public ICurrency[] Currencies => new [] { new KztCurrency() };
        public string[] CallingCodes => new [] { "76", "77" };
    }
}
