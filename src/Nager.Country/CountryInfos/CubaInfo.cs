using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cuba
    /// </summary>
    public class CubaInfo : ICountryInfo
    {
        public string CommonName => "Cuba";
        public string OfficialName => "Republic of Cuba";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "كوبا"),
            new Translation(LanguageCode.AZ, "Kuba"),
            new Translation(LanguageCode.BE, "Куба"),
            new Translation(LanguageCode.BG, "Куба"),
            new Translation(LanguageCode.BS, "Kuba"),
            new Translation(LanguageCode.CA, "Cuba"),
            new Translation(LanguageCode.CS, "Kuba"),
            new Translation(LanguageCode.DA, "Cuba"),
            new Translation(LanguageCode.DE, "Kuba"),
            new Translation(LanguageCode.EL, "Κούβα"),
            new Translation(LanguageCode.EN, "Cuba"),
            new Translation(LanguageCode.ES, "Cuba"),
            new Translation(LanguageCode.ET, "Kuuba"),
            new Translation(LanguageCode.FA, "کوبا"),
            new Translation(LanguageCode.FI, "Kuuba"),
            new Translation(LanguageCode.FR, "Cuba"),
            new Translation(LanguageCode.HE, "קובה"),
            new Translation(LanguageCode.HR, "Kuba"),
            new Translation(LanguageCode.HU, "Kuba"),
            new Translation(LanguageCode.HY, "Կուբա"),
            new Translation(LanguageCode.ID, "Kuba"),
            new Translation(LanguageCode.IT, "Cuba"),
            new Translation(LanguageCode.JA, "キューバ"),
            new Translation(LanguageCode.KA, "კუბა"),
            new Translation(LanguageCode.KK, "Куба"),
            new Translation(LanguageCode.KO, "쿠바"),
            new Translation(LanguageCode.KY, "Куба"),
            new Translation(LanguageCode.LT, "Kuba"),
            new Translation(LanguageCode.LV, "Kuba"),
            new Translation(LanguageCode.MK, "Куба"),
            new Translation(LanguageCode.MN, "Куба"),
            new Translation(LanguageCode.NB, "Cuba"),
            new Translation(LanguageCode.NL, "Cuba"),
            new Translation(LanguageCode.NN, "Cuba"),
            new Translation(LanguageCode.PL, "Kuba"),
            new Translation(LanguageCode.PT, "Cuba"),
            new Translation(LanguageCode.RO, "Cuba"),
            new Translation(LanguageCode.RU, "Куба"),
            new Translation(LanguageCode.SK, "Kuba"),
            new Translation(LanguageCode.SL, "Kuba"),
            new Translation(LanguageCode.SR, "Куба"),
            new Translation(LanguageCode.SV, "Kuba"),
            new Translation(LanguageCode.TR, "Küba"),
            new Translation(LanguageCode.UK, "Куба"),
            new Translation(LanguageCode.UZ, "Kuba"),
            new Translation(LanguageCode.ZH, "古巴"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CU;
        public Alpha3Code Alpha3Code => Alpha3Code.CUB;
        public int NumericCode => 192;
        public string[] TLD => new [] { ".cu" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new ICurrency[] { new CucCurrency(), new CupCurrency() };
        public string[] CallingCodes => new [] { "53" };
    }
}
