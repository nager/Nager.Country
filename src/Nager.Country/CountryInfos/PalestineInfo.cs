using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Palestine
    /// </summary>
    public class PalestineInfo : ICountryInfo
    {
        public string CommonName => "Palestine";
        public string OfficialName => "State of Palestine";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "فلسطين"),
            new Translation(LanguageCode.AZ, "Fələstin Əraziləri"),
            new Translation(LanguageCode.BE, "Палесцінскія Тэрыторыі"),
            new Translation(LanguageCode.BG, "Палестински територии"),
            new Translation(LanguageCode.BS, "Palestinska Teritorija"),
            new Translation(LanguageCode.CA, "Palestina"),
            new Translation(LanguageCode.CS, "Palestinská autonomie"),
            new Translation(LanguageCode.DA, "Palæstina"),
            new Translation(LanguageCode.DE, "Staat Palästina"),
            new Translation(LanguageCode.EL, "Κράτος της Παλαιστίνης"),
            new Translation(LanguageCode.EN, "Palestinian Territory, Occupied"),
            new Translation(LanguageCode.ES, "Palestina"),
            new Translation(LanguageCode.ET, "Palestiina ala"),
            new Translation(LanguageCode.FA, "سرزمین‌های فلسطینی"),
            new Translation(LanguageCode.FI, "Palestiina"),
            new Translation(LanguageCode.FR, "Palestine"),
            new Translation(LanguageCode.HE, "השטחים הפלסטיניים"),
            new Translation(LanguageCode.HR, "Palestinsko Područje"),
            new Translation(LanguageCode.HU, "Palesztina"),
            new Translation(LanguageCode.HY, "Պաղեստինյան տարածքներ"),
            new Translation(LanguageCode.ID, "Palestina"),
            new Translation(LanguageCode.IT, "Stato di Palestina"),
            new Translation(LanguageCode.JA, "パレスチナ"),
            new Translation(LanguageCode.KA, "პალესტინის ტერიტორიები"),
            new Translation(LanguageCode.KK, "Палестина аймақтары"),
            new Translation(LanguageCode.KO, "팔레스타인 자치구, 점령 자"),
            new Translation(LanguageCode.KY, "Палестина аймактары"),
            new Translation(LanguageCode.LT, "Palestinos teritorija"),
            new Translation(LanguageCode.LV, "Palestīna"),
            new Translation(LanguageCode.MK, "Палестински територии"),
            new Translation(LanguageCode.MN, "Палестины нутаг дэвсгэрүүд"),
            new Translation(LanguageCode.NB, "De okkuperte palestinske områdene"),
            new Translation(LanguageCode.NL, "Palestina"),
            new Translation(LanguageCode.NN, "Dei okkuperte palestinske områda"),
            new Translation(LanguageCode.PL, "Palestyna"),
            new Translation(LanguageCode.PT, "Territórios palestinos"),
            new Translation(LanguageCode.RO, "Teritoriile Palestiniene"),
            new Translation(LanguageCode.RU, "Государство Палестина"),
            new Translation(LanguageCode.SK, "Palestínske územia"),
            new Translation(LanguageCode.SL, "Palestinsko ozemlje"),
            new Translation(LanguageCode.SR, "Палестинске територије"),
            new Translation(LanguageCode.SV, "Palestinska territoriet, ockuperade"),
            new Translation(LanguageCode.TR, "Filistin Bölgeleri"),
            new Translation(LanguageCode.UK, "Палестинська держава"),
            new Translation(LanguageCode.UZ, "Falastin hududi"),
            new Translation(LanguageCode.ZH, "巴勒斯坦"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.PS;
        public Alpha3Code Alpha3Code => Alpha3Code.PSE;
        public int NumericCode => 275;
        public string[] TLD => new [] { ".ps", "فلسطين." };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.IL,
            Alpha2Code.EG,
            Alpha2Code.JO,
        };

        public ICurrency[] Currencies => new [] { new IlsCurrency() };
        public string[] CallingCodes => new [] { "970" };
    }
}
