using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Singapore
    /// </summary>
    public class SingaporeInfo : ICountryInfo
    {
        public string CommonName => "Singapore";
        public string OfficialName => "Republic of Singapore";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سنغافورة"),
            new Translation(LanguageCode.AZ, "Sinqapur"),
            new Translation(LanguageCode.BE, "Сінгапур"),
            new Translation(LanguageCode.BG, "Сингапур"),
            new Translation(LanguageCode.BS, "Singapur"),
            new Translation(LanguageCode.CA, "Singapur"),
            new Translation(LanguageCode.CS, "Singapur"),
            new Translation(LanguageCode.DA, "Singapore"),
            new Translation(LanguageCode.DE, "Singapur"),
            new Translation(LanguageCode.EL, "Σιγκαπούρη"),
            new Translation(LanguageCode.EN, "Singapore"),
            new Translation(LanguageCode.ES, "Singapur"),
            new Translation(LanguageCode.ET, "Singapur"),
            new Translation(LanguageCode.FA, "سنگاپور"),
            new Translation(LanguageCode.FI, "Singapore"),
            new Translation(LanguageCode.FR, "Singapour"),
            new Translation(LanguageCode.HE, "סינגפור"),
            new Translation(LanguageCode.HR, "Singapur"),
            new Translation(LanguageCode.HU, "Szingapúr"),
            new Translation(LanguageCode.HY, "Սինգապուր"),
            new Translation(LanguageCode.ID, "Singapura"),
            new Translation(LanguageCode.IT, "Singapore"),
            new Translation(LanguageCode.JA, "シンガポール"),
            new Translation(LanguageCode.KA, "სინგაპური"),
            new Translation(LanguageCode.KK, "Сингапур"),
            new Translation(LanguageCode.KO, "싱가포르"),
            new Translation(LanguageCode.KY, "Сингапур"),
            new Translation(LanguageCode.LT, "Singapūras"),
            new Translation(LanguageCode.LV, "Singapūra"),
            new Translation(LanguageCode.MK, "Сингапур"),
            new Translation(LanguageCode.MN, "Сингапур"),
            new Translation(LanguageCode.NB, "Singapore"),
            new Translation(LanguageCode.NL, "Singapore"),
            new Translation(LanguageCode.NN, "Singapore"),
            new Translation(LanguageCode.PL, "Singapur"),
            new Translation(LanguageCode.PT, "Cingapura"),
            new Translation(LanguageCode.RO, "Singapore"),
            new Translation(LanguageCode.RU, "Сингапур"),
            new Translation(LanguageCode.SK, "Singapur"),
            new Translation(LanguageCode.SL, "Singapur"),
            new Translation(LanguageCode.SR, "Сингапур"),
            new Translation(LanguageCode.SV, "Singapore"),
            new Translation(LanguageCode.TR, "Singapur"),
            new Translation(LanguageCode.UK, "Сінгапур"),
            new Translation(LanguageCode.UZ, "Singapur"),
            new Translation(LanguageCode.ZH, "新加坡"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SG;
        public Alpha3Code Alpha3Code => Alpha3Code.SGP;
        public int NumericCode => 702;
        public string[] TLD => new [] { ".sg", ".新加坡", ".சிங்கப்பூர்" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new SgdCurrency() };
        public string[] CallingCodes => new [] { "65" };
    }
}
