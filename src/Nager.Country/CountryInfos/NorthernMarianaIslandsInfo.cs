using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Northern Mariana Islands
    /// </summary>
    public class NorthernMarianaIslandsInfo : ICountryInfo
    {
        public string CommonName => "Northern Mariana Islands";
        public string OfficialName => "Commonwealth of the Northern Mariana Islands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جزر ماريانا الشمالية"),
            new Translation(LanguageCode.AZ, "Şimali Marian adaları"),
            new Translation(LanguageCode.BE, "Паўночныя Марыянскія астравы"),
            new Translation(LanguageCode.BG, "Северни Мариански острови"),
            new Translation(LanguageCode.BS, "Sjeverna Marijanska Ostrva"),
            new Translation(LanguageCode.CA, "Mariannes Septentrionals, illes"),
            new Translation(LanguageCode.CS, "Severní Mariany"),
            new Translation(LanguageCode.DA, "Nordmarianerne"),
            new Translation(LanguageCode.DE, "Nördliche Marianen"),
            new Translation(LanguageCode.EL, "Βόρειες Μαριάνες Νήσοι"),
            new Translation(LanguageCode.EN, "Northern Mariana Islands"),
            new Translation(LanguageCode.ES, "Isla Marianas del Norte"),
            new Translation(LanguageCode.ET, "Põhja-Mariaanid"),
            new Translation(LanguageCode.FA, "جزایر ماریانای شمالی"),
            new Translation(LanguageCode.FI, "Pohjois-Mariaanit"),
            new Translation(LanguageCode.FR, "Mariannes du Nord"),
            new Translation(LanguageCode.HE, "איי מריאנה הצפוניים"),
            new Translation(LanguageCode.HR, "Sjevernomarijanski otoci"),
            new Translation(LanguageCode.HU, "Északi-Mariana-szigetek"),
            new Translation(LanguageCode.HY, "Հյուսիսային Մարիանյան կղզիներ"),
            new Translation(LanguageCode.ID, "Kepulauan Mariana Utara"),
            new Translation(LanguageCode.IT, "Isole Marianne Settentrionali"),
            new Translation(LanguageCode.JA, "北マリアナ諸島"),
            new Translation(LanguageCode.KA, "ჩრდილოეთ მარიანას კუნძულები"),
            new Translation(LanguageCode.KK, "Солтүстік Мариана аралдары"),
            new Translation(LanguageCode.KO, "북 마리아나 제도"),
            new Translation(LanguageCode.KY, "Түндүк Мариана аралдары"),
            new Translation(LanguageCode.LT, "Marianos Šiaurinės Salos"),
            new Translation(LanguageCode.LV, "Ziemeļu Marianas salas"),
            new Translation(LanguageCode.MK, "Северни Маријански Острови"),
            new Translation(LanguageCode.MN, "Хойд Марианы арлууд"),
            new Translation(LanguageCode.NB, "Nord-Marianene"),
            new Translation(LanguageCode.NL, "Noordelijke Marianen"),
            new Translation(LanguageCode.NN, "Nord-Marianane"),
            new Translation(LanguageCode.PL, "Mariany Północne"),
            new Translation(LanguageCode.PT, "Ilhas Marianas do Norte"),
            new Translation(LanguageCode.RO, "Insulele Mariane de Nord"),
            new Translation(LanguageCode.RU, "Северные Марианские Острова"),
            new Translation(LanguageCode.SK, "Severné Mariány"),
            new Translation(LanguageCode.SL, "Severni Marianski otoki"),
            new Translation(LanguageCode.SR, "Северна Маријанска Острва"),
            new Translation(LanguageCode.SV, "Nordmarianerna"),
            new Translation(LanguageCode.TR, "Kuzey Mariana Adaları"),
            new Translation(LanguageCode.UK, "Північні Маріанські Острови"),
            new Translation(LanguageCode.UZ, "Shimoliy Mariana orollari"),
            new Translation(LanguageCode.ZH, "北马里亚纳群岛"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MP;
        public Alpha3Code Alpha3Code => Alpha3Code.MNP;
        public int NumericCode => 580;
        public string[] TLD => new [] { ".mp" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Micronesia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1670" };
    }
}
