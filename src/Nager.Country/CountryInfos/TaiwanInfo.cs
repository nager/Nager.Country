using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Taiwan
    /// </summary>
    public class TaiwanInfo : ICountryInfo
    {
        public string CommonName => "Taiwan";
        public string OfficialName => "Republic of China";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "تايوان"),
            new Translation(LanguageCode.AZ, "Tayvan"),
            new Translation(LanguageCode.BE, "Тайвань"),
            new Translation(LanguageCode.BG, "Тайван"),
            new Translation(LanguageCode.BS, "Tajvan"),
            new Translation(LanguageCode.CA, "Taiwan"),
            new Translation(LanguageCode.CS, "Tchaj-wan"),
            new Translation(LanguageCode.DA, "Republikken Kina Taiwan"),
            new Translation(LanguageCode.DE, "Taiwan"),
            new Translation(LanguageCode.EL, "Δημοκρατία της Κίνας"),
            new Translation(LanguageCode.EN, "Taiwan"),
            new Translation(LanguageCode.ES, "Taiwán"),
            new Translation(LanguageCode.ET, "Taiwan"),
            new Translation(LanguageCode.FA, "تایوان"),
            new Translation(LanguageCode.FI, "Taiwan"),
            new Translation(LanguageCode.FR, "Taïwan"),
            new Translation(LanguageCode.HE, "טייוואן"),
            new Translation(LanguageCode.HR, "Tajvan"),
            new Translation(LanguageCode.HU, "Tajvan"),
            new Translation(LanguageCode.HY, "Թայվան"),
            new Translation(LanguageCode.ID, "Taiwan"),
            new Translation(LanguageCode.IT, "Repubblica di Cina"),
            new Translation(LanguageCode.JA, "台湾"),
            new Translation(LanguageCode.KA, "ტაივანი"),
            new Translation(LanguageCode.KK, "Тайвань"),
            new Translation(LanguageCode.KO, "대만"),
            new Translation(LanguageCode.KY, "Тайвань"),
            new Translation(LanguageCode.LT, "Taivanas"),
            new Translation(LanguageCode.LV, "Taivāna"),
            new Translation(LanguageCode.MK, "Тајван"),
            new Translation(LanguageCode.MN, "Тайвань"),
            new Translation(LanguageCode.NB, "Taiwan"),
            new Translation(LanguageCode.NL, "Taiwan"),
            new Translation(LanguageCode.NN, "Taiwan"),
            new Translation(LanguageCode.PL, "Tajwan"),
            new Translation(LanguageCode.PT, "Taiwan"),
            new Translation(LanguageCode.RO, "Taiwan"),
            new Translation(LanguageCode.RU, "Китайская Республика"),
            new Translation(LanguageCode.SK, "Taiwan"),
            new Translation(LanguageCode.SL, "Tajvan"),
            new Translation(LanguageCode.SR, "Тајван"),
            new Translation(LanguageCode.SV, "Taiwan"),
            new Translation(LanguageCode.TR, "Tayvan"),
            new Translation(LanguageCode.UK, "Республіка Китай"),
            new Translation(LanguageCode.UZ, "Tayvan"),
            new Translation(LanguageCode.ZH, "臺湾"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TW;
        public Alpha3Code Alpha3Code => Alpha3Code.TWN;
        public int NumericCode => 158;
        public string[] TLD => new [] { ".tw", ".台湾", ".台灣" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.EasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new TwdCurrency() };
        public string[] CallingCodes => new [] { "886" };
    }
}
