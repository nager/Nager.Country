using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Aruba
    /// </summary>
    public class ArubaInfo : ICountryInfo
    {
        public string CommonName => "Aruba";
        public string OfficialName => "Aruba";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أروبا"),
            new Translation(LanguageCode.AZ, "Aruba"),
            new Translation(LanguageCode.BE, "Аруба"),
            new Translation(LanguageCode.BG, "Аруба"),
            new Translation(LanguageCode.BS, "Aruba"),
            new Translation(LanguageCode.CA, "Aruba"),
            new Translation(LanguageCode.CS, "Aruba"),
            new Translation(LanguageCode.DA, "Aruba"),
            new Translation(LanguageCode.DE, "Aruba"),
            new Translation(LanguageCode.EL, "Αρούμπα"),
            new Translation(LanguageCode.EN, "Aruba"),
            new Translation(LanguageCode.ES, "Aruba"),
            new Translation(LanguageCode.ET, "Aruba"),
            new Translation(LanguageCode.FA, "آروبا"),
            new Translation(LanguageCode.FI, "Aruba"),
            new Translation(LanguageCode.FR, "Aruba"),
            new Translation(LanguageCode.HE, "ארובה"),
            new Translation(LanguageCode.HR, "Aruba"),
            new Translation(LanguageCode.HU, "Aruba"),
            new Translation(LanguageCode.HY, "Արուբա"),
            new Translation(LanguageCode.ID, "Aruba"),
            new Translation(LanguageCode.IT, "Aruba"),
            new Translation(LanguageCode.JA, "アルバ"),
            new Translation(LanguageCode.KA, "არუბა"),
            new Translation(LanguageCode.KK, "Аруба"),
            new Translation(LanguageCode.KO, "아루바"),
            new Translation(LanguageCode.KY, "Аруба"),
            new Translation(LanguageCode.LT, "Aruba"),
            new Translation(LanguageCode.LV, "Aruba"),
            new Translation(LanguageCode.MK, "Аруба"),
            new Translation(LanguageCode.MN, "Аруба"),
            new Translation(LanguageCode.NB, "Aruba"),
            new Translation(LanguageCode.NL, "Aruba"),
            new Translation(LanguageCode.NN, "Aruba"),
            new Translation(LanguageCode.PL, "Aruba"),
            new Translation(LanguageCode.PT, "Aruba"),
            new Translation(LanguageCode.RO, "Aruba"),
            new Translation(LanguageCode.RU, "Аруба"),
            new Translation(LanguageCode.SK, "Aruba"),
            new Translation(LanguageCode.SL, "Aruba"),
            new Translation(LanguageCode.SR, "Аруба"),
            new Translation(LanguageCode.SV, "Aruba"),
            new Translation(LanguageCode.TR, "Aruba"),
            new Translation(LanguageCode.UK, "Аруба"),
            new Translation(LanguageCode.UZ, "Aruba"),
            new Translation(LanguageCode.ZH, "阿鲁巴"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AW;
        public Alpha3Code Alpha3Code => Alpha3Code.ABW;
        public int NumericCode => 533;
        public string[] TLD => new [] { ".aw" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AwgCurrency() };
        public string[] CallingCodes => new [] { "297" };
    }
}
