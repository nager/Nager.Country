namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Gibraltar
    /// </summary>
    public class GibraltarInfo : ICountryInfo
    {
        public string CommonName => "Gibraltar";
        public string OfficialName => "Gibraltar";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جبل طارق"),
            new Translation(LanguageCode.AZ, "Cəbəllütariq"),
            new Translation(LanguageCode.BE, "Гібралтар"),
            new Translation(LanguageCode.BG, "Гибралтар"),
            new Translation(LanguageCode.BS, "Gibraltar"),
            new Translation(LanguageCode.CA, "Gibraltar"),
            new Translation(LanguageCode.CS, "Gibraltar"),
            new Translation(LanguageCode.DA, "Gibraltar"),
            new Translation(LanguageCode.DE, "Gibraltar"),
            new Translation(LanguageCode.EL, "Γιβραλτάρ"),
            new Translation(LanguageCode.EN, "Gibraltar"),
            new Translation(LanguageCode.ES, "Gibraltar"),
            new Translation(LanguageCode.ET, "Gibraltar"),
            new Translation(LanguageCode.FA, "جبل‌الطارق"),
            new Translation(LanguageCode.FI, "Gibraltar"),
            new Translation(LanguageCode.FR, "Gibraltar"),
            new Translation(LanguageCode.HE, "גיברלטר"),
            new Translation(LanguageCode.HR, "Gibraltar"),
            new Translation(LanguageCode.HU, "Gibraltár"),
            new Translation(LanguageCode.HY, "Ջիբրալթար"),
            new Translation(LanguageCode.ID, "Gibraltar"),
            new Translation(LanguageCode.IT, "Gibilterra"),
            new Translation(LanguageCode.JA, "ジブラルタル"),
            new Translation(LanguageCode.KA, "გიბრალტარი"),
            new Translation(LanguageCode.KK, "Гибралтар"),
            new Translation(LanguageCode.KO, "지브롤터"),
            new Translation(LanguageCode.KY, "Гибралтар"),
            new Translation(LanguageCode.LT, "Gibraltaras"),
            new Translation(LanguageCode.LV, "Gibraltārs"),
            new Translation(LanguageCode.MK, "Гибралтар"),
            new Translation(LanguageCode.MN, "Гибралтар"),
            new Translation(LanguageCode.NB, "Gibraltar"),
            new Translation(LanguageCode.NL, "Gibraltar"),
            new Translation(LanguageCode.NN, "Gibraltar"),
            new Translation(LanguageCode.PL, "Gibraltar"),
            new Translation(LanguageCode.PT, "Gibraltar"),
            new Translation(LanguageCode.RO, "Gibraltar"),
            new Translation(LanguageCode.RU, "Гибралтар"),
            new Translation(LanguageCode.SK, "Gibraltár"),
            new Translation(LanguageCode.SL, "Gibraltar"),
            new Translation(LanguageCode.SR, "Гибралтар"),
            new Translation(LanguageCode.SV, "Gibraltar"),
            new Translation(LanguageCode.TR, "Cebelitarık"),
            new Translation(LanguageCode.UK, "Гібралтар"),
            new Translation(LanguageCode.UZ, "Gibraltar"),
            new Translation(LanguageCode.ZH, "直布罗陀"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GI;
        public Alpha3Code Alpha3Code => Alpha3Code.GIB;
        public int NumericCode => 292;
        public string[] TLD => new [] { ".gi" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.ES,
        };

        public string[] Currencies => new [] { "GIP" };
        public string[] CallingCodes => new [] { "350" };
    }
}
