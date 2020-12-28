using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Nauru
    /// </summary>
    public class NauruInfo : ICountryInfo
    {
        public string CommonName => "Nauru";
        public string OfficialName => "Republic of Nauru";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ناورو"),
            new Translation(LanguageCode.AZ, "Nauru"),
            new Translation(LanguageCode.BE, "Науру"),
            new Translation(LanguageCode.BG, "Науру"),
            new Translation(LanguageCode.BS, "Nauru"),
            new Translation(LanguageCode.CA, "Nauru"),
            new Translation(LanguageCode.CS, "Nauru"),
            new Translation(LanguageCode.DA, "Nauru"),
            new Translation(LanguageCode.DE, "Nauru"),
            new Translation(LanguageCode.EL, "Ναουρού"),
            new Translation(LanguageCode.EN, "Nauru"),
            new Translation(LanguageCode.ES, "Nauru"),
            new Translation(LanguageCode.ET, "Nauru"),
            new Translation(LanguageCode.FA, "نائورو"),
            new Translation(LanguageCode.FI, "Nauru"),
            new Translation(LanguageCode.FR, "Nauru"),
            new Translation(LanguageCode.HE, "נאורו"),
            new Translation(LanguageCode.HR, "Nauru"),
            new Translation(LanguageCode.HU, "Nauru"),
            new Translation(LanguageCode.HY, "Նաուրու"),
            new Translation(LanguageCode.ID, "Nauru"),
            new Translation(LanguageCode.IT, "Nauru"),
            new Translation(LanguageCode.JA, "ナウル"),
            new Translation(LanguageCode.KA, "ნაურუ"),
            new Translation(LanguageCode.KK, "Науру"),
            new Translation(LanguageCode.KO, "나우루"),
            new Translation(LanguageCode.KY, "Науру"),
            new Translation(LanguageCode.LT, "Nauru"),
            new Translation(LanguageCode.LV, "Nauru"),
            new Translation(LanguageCode.MK, "Науру"),
            new Translation(LanguageCode.MN, "Науру"),
            new Translation(LanguageCode.NB, "Nauru"),
            new Translation(LanguageCode.NL, "Nauru"),
            new Translation(LanguageCode.NN, "Nauru"),
            new Translation(LanguageCode.PL, "Nauru"),
            new Translation(LanguageCode.PT, "Nauru"),
            new Translation(LanguageCode.RO, "Nauru"),
            new Translation(LanguageCode.RU, "Науру"),
            new Translation(LanguageCode.SK, "Nauru"),
            new Translation(LanguageCode.SL, "Nauru"),
            new Translation(LanguageCode.SR, "Науру"),
            new Translation(LanguageCode.SV, "Nauru"),
            new Translation(LanguageCode.TR, "Nauru"),
            new Translation(LanguageCode.UK, "Науру"),
            new Translation(LanguageCode.UZ, "Nauru"),
            new Translation(LanguageCode.ZH, "瑙鲁"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.NR;
        public Alpha3Code Alpha3Code => Alpha3Code.NRU;
        public int NumericCode => 520;
        public string[] TLD => new [] { ".nr" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Micronesia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AudCurrency() };
        public string[] CallingCodes => new [] { "674" };
    }
}
