using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Costa Rica
    /// </summary>
    public class CostaRicaInfo : ICountryInfo
    {
        public string CommonName => "Costa Rica";
        public string OfficialName => "Republic of Costa Rica";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "كوستاريكا"),
            new Translation(LanguageCode.AZ, "Kosta Rika"),
            new Translation(LanguageCode.BE, "Коста-Рыка"),
            new Translation(LanguageCode.BG, "Коста Рика"),
            new Translation(LanguageCode.BS, "Kostarika"),
            new Translation(LanguageCode.CA, "Costa Rica"),
            new Translation(LanguageCode.CS, "Kostarika"),
            new Translation(LanguageCode.DA, "Costa Rica"),
            new Translation(LanguageCode.DE, "Costa Rica"),
            new Translation(LanguageCode.EL, "Κόστα Ρίκα"),
            new Translation(LanguageCode.EN, "Costa Rica"),
            new Translation(LanguageCode.ES, "Costa Rica"),
            new Translation(LanguageCode.ET, "Costa Rica"),
            new Translation(LanguageCode.FA, "کاستاریکا"),
            new Translation(LanguageCode.FI, "Costa Rica"),
            new Translation(LanguageCode.FR, "Costa Rica"),
            new Translation(LanguageCode.HE, "קוסטה ריקה"),
            new Translation(LanguageCode.HR, "Kostarika"),
            new Translation(LanguageCode.HU, "Costa Rica"),
            new Translation(LanguageCode.HY, "Կոստա Ռիկա"),
            new Translation(LanguageCode.ID, "Kosta Rika"),
            new Translation(LanguageCode.IT, "Costa Rica"),
            new Translation(LanguageCode.JA, "コスタリカ"),
            new Translation(LanguageCode.KA, "კოსტა-რიკა"),
            new Translation(LanguageCode.KK, "Коста-Рика"),
            new Translation(LanguageCode.KO, "코스타리카"),
            new Translation(LanguageCode.KY, "Коста-Рика"),
            new Translation(LanguageCode.LT, "Kosta Rika"),
            new Translation(LanguageCode.LV, "Kostarika"),
            new Translation(LanguageCode.MK, "Костарика"),
            new Translation(LanguageCode.MN, "Коста Рика"),
            new Translation(LanguageCode.NB, "Costa Rica"),
            new Translation(LanguageCode.NL, "Costa Rica"),
            new Translation(LanguageCode.NN, "Costa Rica"),
            new Translation(LanguageCode.PL, "Kostaryka"),
            new Translation(LanguageCode.PT, "Costa Rica"),
            new Translation(LanguageCode.RO, "Costa Rica"),
            new Translation(LanguageCode.RU, "Коста-Рика"),
            new Translation(LanguageCode.SK, "Kostarika"),
            new Translation(LanguageCode.SL, "Kostarika"),
            new Translation(LanguageCode.SR, "Костарика"),
            new Translation(LanguageCode.SV, "Costa Rica"),
            new Translation(LanguageCode.TR, "Kosta Rika"),
            new Translation(LanguageCode.UK, "Коста-Рика"),
            new Translation(LanguageCode.UZ, "Kosta-Rika"),
            new Translation(LanguageCode.ZH, "哥斯达黎加"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CR;
        public Alpha3Code Alpha3Code => Alpha3Code.CRI;
        public int NumericCode => 188;
        public string[] TLD => new [] { ".cr" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.NI,
            Alpha2Code.PA,
        };

        public ICurrency[] Currencies => new [] { new CrcCurrency() };
        public string[] CallingCodes => new [] { "506" };
    }
}
