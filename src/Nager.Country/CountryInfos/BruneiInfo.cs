using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Brunei
    /// </summary>
    public class BruneiInfo : ICountryInfo
    {
        public string CommonName => "Brunei";
        public string OfficialName => "Nation of Brunei, Abode of Peace";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بروناي"),
            new Translation(LanguageCode.AZ, "Bruney"),
            new Translation(LanguageCode.BE, "Бруней"),
            new Translation(LanguageCode.BG, "Бруней Даруссалам"),
            new Translation(LanguageCode.BS, "Brunej"),
            new Translation(LanguageCode.CA, "Brunei"),
            new Translation(LanguageCode.CS, "Brunej"),
            new Translation(LanguageCode.DA, "Brunei Darussalam"),
            new Translation(LanguageCode.DE, "Brunei Darussalam"),
            new Translation(LanguageCode.EL, "Σουλτανάτο του Μπρουνέι"),
            new Translation(LanguageCode.EN, "Brunei Darussalam"),
            new Translation(LanguageCode.ES, "Brunei Darussalam"),
            new Translation(LanguageCode.ET, "Brunei"),
            new Translation(LanguageCode.FA, "برونئی"),
            new Translation(LanguageCode.FI, "Brunei"),
            new Translation(LanguageCode.FR, "Brunei Darussalam"),
            new Translation(LanguageCode.HE, "ברוניי"),
            new Translation(LanguageCode.HR, "Brunej"),
            new Translation(LanguageCode.HU, "Brunei"),
            new Translation(LanguageCode.HY, "Բրունեյ"),
            new Translation(LanguageCode.ID, "Brunei Darussalam"),
            new Translation(LanguageCode.IT, "Brunei"),
            new Translation(LanguageCode.JA, "ブルネイ・ダルサラーム"),
            new Translation(LanguageCode.KA, "ბრუნეი"),
            new Translation(LanguageCode.KK, "Бруней"),
            new Translation(LanguageCode.KO, "브루나이 다루 살람"),
            new Translation(LanguageCode.KY, "Бруней"),
            new Translation(LanguageCode.LT, "Brunėjus"),
            new Translation(LanguageCode.LV, "Bruneja"),
            new Translation(LanguageCode.MK, "Брунеј"),
            new Translation(LanguageCode.MN, "Бруней"),
            new Translation(LanguageCode.NB, "Brunei"),
            new Translation(LanguageCode.NL, "Brunei Darussalam"),
            new Translation(LanguageCode.NN, "Brunei"),
            new Translation(LanguageCode.PL, "Brunei"),
            new Translation(LanguageCode.PT, "Brunei"),
            new Translation(LanguageCode.RO, "Brunei"),
            new Translation(LanguageCode.RU, "Бруней"),
            new Translation(LanguageCode.SK, "Brunej"),
            new Translation(LanguageCode.SL, "Brunej"),
            new Translation(LanguageCode.SR, "Брунеј"),
            new Translation(LanguageCode.SV, "Brunei"),
            new Translation(LanguageCode.TR, "Brunei"),
            new Translation(LanguageCode.UK, "Бруней Даруссалам"),
            new Translation(LanguageCode.UZ, "Bruney"),
            new Translation(LanguageCode.ZH, "文莱"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BN;
        public Alpha3Code Alpha3Code => Alpha3Code.BRN;
        public int NumericCode => 096;
        public string[] TLD => new [] { ".bn" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.MY,
        };

        public ICurrency[] Currencies => new [] { new BndCurrency() };
        public string[] CallingCodes => new [] { "673" };
    }
}
