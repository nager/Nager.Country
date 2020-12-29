using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Papua New Guinea
    /// </summary>
    public class PapuaNewGuineaInfo : ICountryInfo
    {
        public string CommonName => "Papua New Guinea";
        public string OfficialName => "Independent State of Papua New Guinea";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بابوا غينيا الجديدة"),
            new Translation(LanguageCode.AZ, "Papua-Yeni Qvineya"),
            new Translation(LanguageCode.BE, "Папуа-Новая Гвінея"),
            new Translation(LanguageCode.BG, "Папуа-Нова Гвинея"),
            new Translation(LanguageCode.BS, "Papua Nova Gvineja"),
            new Translation(LanguageCode.CA, "Papua Nova Guinea"),
            new Translation(LanguageCode.CS, "Papua-Nová Guinea"),
            new Translation(LanguageCode.DA, "Papua Ny Guinea"),
            new Translation(LanguageCode.DE, "Papua-Neuguinea"),
            new Translation(LanguageCode.EL, "Παπούα Νέα Γουινέα"),
            new Translation(LanguageCode.EN, "Papua New Guinea"),
            new Translation(LanguageCode.ES, "Papua Nueva Guinea"),
            new Translation(LanguageCode.ET, "Paapua Uus-Guinea"),
            new Translation(LanguageCode.FA, "پاپوا گینهٔ نو"),
            new Translation(LanguageCode.FI, "Papua-Uusi-Guinea"),
            new Translation(LanguageCode.FR, "Papouasie-Nouvelle-Guinée"),
            new Translation(LanguageCode.HE, "פפואה גינאה החדשה"),
            new Translation(LanguageCode.HR, "Papua Nova Gvineja"),
            new Translation(LanguageCode.HU, "Pápua Új-Guinea"),
            new Translation(LanguageCode.HY, "Պապուա Նոր Գվինեա"),
            new Translation(LanguageCode.ID, "Papua Nugini"),
            new Translation(LanguageCode.IT, "Papua Nuova Guinea"),
            new Translation(LanguageCode.JA, "パプアニューギニア"),
            new Translation(LanguageCode.KA, "პაპუა-ახალი გვინეა"),
            new Translation(LanguageCode.KK, "Папуа — Жаңа Гвинея"),
            new Translation(LanguageCode.KO, "파푸아 뉴기니"),
            new Translation(LanguageCode.KY, "Папуа Жаңы-Гвинея"),
            new Translation(LanguageCode.LT, "Papua Naujoji Gvinėja"),
            new Translation(LanguageCode.LV, "Papua-Jaungvineja"),
            new Translation(LanguageCode.MK, "Папуа Нова Гвинеја"),
            new Translation(LanguageCode.MN, "Папуа Шинэ Гвиней"),
            new Translation(LanguageCode.NB, "Papua Ny-Guinea"),
            new Translation(LanguageCode.NL, "Papoea-Nieuw-Guinea"),
            new Translation(LanguageCode.NN, "Papua Ny-Guinea"),
            new Translation(LanguageCode.PL, "Papua-Nowa Gwinea"),
            new Translation(LanguageCode.PT, "Papua-Nova Guiné"),
            new Translation(LanguageCode.RO, "Papua-Noua Guinee"),
            new Translation(LanguageCode.RU, "Папуа — Новая Гвинея"),
            new Translation(LanguageCode.SK, "Papua Nová Guinea"),
            new Translation(LanguageCode.SL, "Papua Nova Gvineja"),
            new Translation(LanguageCode.SR, "Папуа Нова Гвинеја"),
            new Translation(LanguageCode.SV, "Papua Nya Guinea"),
            new Translation(LanguageCode.TR, "Papua Yeni Gine"),
            new Translation(LanguageCode.UK, "Папуа Нова Гвінея"),
            new Translation(LanguageCode.UZ, "Papua – Yangi Gvineya"),
            new Translation(LanguageCode.ZH, "巴布亚新几内亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.PG;
        public Alpha3Code Alpha3Code => Alpha3Code.PNG;
        public int NumericCode => 598;
        public string[] TLD => new [] { ".pg" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Melanesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ID,
        };

        public ICurrency[] Currencies => new [] { new PgkCurrency() };
        public string[] CallingCodes => new [] { "675" };
    }
}
