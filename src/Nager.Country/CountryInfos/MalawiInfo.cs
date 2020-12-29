using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Malawi
    /// </summary>
    public class MalawiInfo : ICountryInfo
    {
        public string CommonName => "Malawi";
        public string OfficialName => "Republic of Malawi";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "مالاوي"),
            new Translation(LanguageCode.AZ, "Malavi"),
            new Translation(LanguageCode.BE, "Малаві"),
            new Translation(LanguageCode.BG, "Малави"),
            new Translation(LanguageCode.BS, "Malavi"),
            new Translation(LanguageCode.CA, "Malawi"),
            new Translation(LanguageCode.CS, "Malawi"),
            new Translation(LanguageCode.DA, "Malawi"),
            new Translation(LanguageCode.DE, "Malawi"),
            new Translation(LanguageCode.EL, "Μαλάουι"),
            new Translation(LanguageCode.EN, "Malawi"),
            new Translation(LanguageCode.ES, "Malawi"),
            new Translation(LanguageCode.ET, "Malawi"),
            new Translation(LanguageCode.FA, "مالاوی"),
            new Translation(LanguageCode.FI, "Malawi"),
            new Translation(LanguageCode.FR, "Malawi"),
            new Translation(LanguageCode.HE, "מלאווי"),
            new Translation(LanguageCode.HR, "Malavi"),
            new Translation(LanguageCode.HU, "Malawi"),
            new Translation(LanguageCode.HY, "Մալավի"),
            new Translation(LanguageCode.ID, "Malawi"),
            new Translation(LanguageCode.IT, "Malawi"),
            new Translation(LanguageCode.JA, "マラウイ"),
            new Translation(LanguageCode.KA, "მალავი"),
            new Translation(LanguageCode.KK, "Малави"),
            new Translation(LanguageCode.KO, "말라위"),
            new Translation(LanguageCode.KY, "Малави"),
            new Translation(LanguageCode.LT, "Malavis"),
            new Translation(LanguageCode.LV, "Malāvija"),
            new Translation(LanguageCode.MK, "Малави"),
            new Translation(LanguageCode.MN, "Малави"),
            new Translation(LanguageCode.NB, "Malawi"),
            new Translation(LanguageCode.NL, "Malawi"),
            new Translation(LanguageCode.NN, "Malawi"),
            new Translation(LanguageCode.PL, "Malawi"),
            new Translation(LanguageCode.PT, "Malawi"),
            new Translation(LanguageCode.RO, "Malawi"),
            new Translation(LanguageCode.RU, "Малави"),
            new Translation(LanguageCode.SK, "Malawi"),
            new Translation(LanguageCode.SL, "Malavi"),
            new Translation(LanguageCode.SR, "Малави"),
            new Translation(LanguageCode.SV, "Malawi"),
            new Translation(LanguageCode.TR, "Malavi"),
            new Translation(LanguageCode.UK, "Малаві"),
            new Translation(LanguageCode.UZ, "Malavi"),
            new Translation(LanguageCode.ZH, "马拉维"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MW;
        public Alpha3Code Alpha3Code => Alpha3Code.MWI;
        public int NumericCode => 454;
        public string[] TLD => new [] { ".mw" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MZ,
            Alpha2Code.TZ,
            Alpha2Code.ZM,
        };

        public ICurrency[] Currencies => new [] { new MwkCurrency() };
        public string[] CallingCodes => new [] { "265" };
    }
}
