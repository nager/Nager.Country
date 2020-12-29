using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Kitts and Nevis
    /// </summary>
    public class SaintKittsAndNevisInfo : ICountryInfo
    {
        public string CommonName => "Saint Kitts and Nevis";
        public string OfficialName => "Federation of Saint Christopher and Nevisa";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سانت كيتس ونيفيس"),
            new Translation(LanguageCode.AZ, "Sent-Kits və Nevis"),
            new Translation(LanguageCode.BE, "Сент-Кітс і Невіс"),
            new Translation(LanguageCode.BG, "Сейнт Китс и Невис"),
            new Translation(LanguageCode.BS, "Sveti Kits i Nevis"),
            new Translation(LanguageCode.CA, "Saint Kitts i Nevis"),
            new Translation(LanguageCode.CS, "Svatý Kryštof a Nevis"),
            new Translation(LanguageCode.DA, "Saint Kitts og Nevis"),
            new Translation(LanguageCode.DE, "St. Kitts und Nevis"),
            new Translation(LanguageCode.EL, "Ομοσπονδία Αγίου Χριστόφορου και Νέβις"),
            new Translation(LanguageCode.EN, "Saint Kitts and Nevis"),
            new Translation(LanguageCode.ES, "Saint Kitts y Nevis"),
            new Translation(LanguageCode.ET, "Saint Kitts ja Nevis"),
            new Translation(LanguageCode.FA, "سنت کیتس و نویس"),
            new Translation(LanguageCode.FI, "Saint Kitts ja Nevis"),
            new Translation(LanguageCode.FR, "Saint-Christophe-et-Niévès"),
            new Translation(LanguageCode.HE, "סנט קיטס ונוויס"),
            new Translation(LanguageCode.HR, "Sveti Kristofor i Nevis"),
            new Translation(LanguageCode.HU, "Saint Kitts és Nevis"),
            new Translation(LanguageCode.HY, "Սենտ Քիտս և Նևիս"),
            new Translation(LanguageCode.ID, "Saint Kitts dan Nevis"),
            new Translation(LanguageCode.IT, "Saint Kitts e Nevis"),
            new Translation(LanguageCode.JA, "セントクリストファー・ネイビス"),
            new Translation(LanguageCode.KA, "სენტ-კიტსი და ნევისი"),
            new Translation(LanguageCode.KK, "Сент-Китс және Невис"),
            new Translation(LanguageCode.KO, "세인트 키츠 네비스"),
            new Translation(LanguageCode.KY, "Сент-Китс жана Невис"),
            new Translation(LanguageCode.LT, "Sent Kitsas ir Nevis"),
            new Translation(LanguageCode.LV, "Sentkitsa un Nevisa"),
            new Translation(LanguageCode.MK, "Свети Кристофер и Невис"),
            new Translation(LanguageCode.MN, "Сент-Киттс ба Невис"),
            new Translation(LanguageCode.NB, "Saint Kitts og Nevis"),
            new Translation(LanguageCode.NL, "Saint Kitts en Nevis"),
            new Translation(LanguageCode.NN, "Saint Kitts og Nevis"),
            new Translation(LanguageCode.PL, "Saint Kitts i Nevis"),
            new Translation(LanguageCode.PT, "São Cristóvão e Nevis"),
            new Translation(LanguageCode.RO, "Saint Kitts și Nevis"),
            new Translation(LanguageCode.RU, "Сент-Китс и Невис"),
            new Translation(LanguageCode.SK, "Svätý Krištof a Nevis"),
            new Translation(LanguageCode.SL, "Saint Kitts in Nevis"),
            new Translation(LanguageCode.SR, "Сент Китс и Невис"),
            new Translation(LanguageCode.SV, "Saint Kitts och Nevis"),
            new Translation(LanguageCode.TR, "Saint Kitts ve Nevis"),
            new Translation(LanguageCode.UK, "Сент-Кіттс і Невіс"),
            new Translation(LanguageCode.UZ, "Sent-Kits va Nevis"),
            new Translation(LanguageCode.ZH, "圣基茨和尼维斯"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.KN;
        public Alpha3Code Alpha3Code => Alpha3Code.KNA;
        public int NumericCode => 659;
        public string[] TLD => new [] { ".kn" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        public string[] CallingCodes => new [] { "1869" };
    }
}
