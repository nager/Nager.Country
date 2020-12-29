using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Croatia
    /// </summary>
    public class CroatiaInfo : ICountryInfo
    {
        public string CommonName => "Croatia";
        public string OfficialName => "Republic of Croatia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "كرواتيا"),
            new Translation(LanguageCode.AZ, "Xorvatiya"),
            new Translation(LanguageCode.BE, "Харватыя"),
            new Translation(LanguageCode.BG, "Хърватия"),
            new Translation(LanguageCode.BS, "Hrvatska"),
            new Translation(LanguageCode.CA, "Croàcia"),
            new Translation(LanguageCode.CS, "Chorvatsko"),
            new Translation(LanguageCode.DA, "Kroatien"),
            new Translation(LanguageCode.DE, "Kroatien"),
            new Translation(LanguageCode.EL, "Κροατία"),
            new Translation(LanguageCode.EN, "Croatia"),
            new Translation(LanguageCode.ES, "Croacia"),
            new Translation(LanguageCode.ET, "Horvaatia"),
            new Translation(LanguageCode.FA, "کرواسی"),
            new Translation(LanguageCode.FI, "Kroatia"),
            new Translation(LanguageCode.FR, "Croatie"),
            new Translation(LanguageCode.HE, "קרואטיה"),
            new Translation(LanguageCode.HR, "Hrvatska"),
            new Translation(LanguageCode.HU, "Horvátország"),
            new Translation(LanguageCode.HY, "Խորվաթիա"),
            new Translation(LanguageCode.ID, "Kroasia"),
            new Translation(LanguageCode.IT, "Croazia"),
            new Translation(LanguageCode.JA, "クロアチア"),
            new Translation(LanguageCode.KA, "ხორვატია"),
            new Translation(LanguageCode.KK, "Хорватия"),
            new Translation(LanguageCode.KO, "크로아티아"),
            new Translation(LanguageCode.KY, "Хорватия"),
            new Translation(LanguageCode.LT, "Kroatija"),
            new Translation(LanguageCode.LV, "Horvātija"),
            new Translation(LanguageCode.MK, "Хрватска"),
            new Translation(LanguageCode.MN, "Хорват"),
            new Translation(LanguageCode.NB, "Kroatia"),
            new Translation(LanguageCode.NL, "Kroatië"),
            new Translation(LanguageCode.NN, "Kroatia"),
            new Translation(LanguageCode.PL, "Chorwacja"),
            new Translation(LanguageCode.PT, "Croácia"),
            new Translation(LanguageCode.RO, "Croația"),
            new Translation(LanguageCode.RU, "Хорватия"),
            new Translation(LanguageCode.SK, "Chorvátsko"),
            new Translation(LanguageCode.SL, "Hrvaška"),
            new Translation(LanguageCode.SR, "Хрватска"),
            new Translation(LanguageCode.SV, "Kroatien"),
            new Translation(LanguageCode.TR, "Hırvatistan"),
            new Translation(LanguageCode.UK, "Хорватія"),
            new Translation(LanguageCode.UZ, "Xorvatiya"),
            new Translation(LanguageCode.ZH, "克罗地亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.HR;
        public Alpha3Code Alpha3Code => Alpha3Code.HRV;
        public int NumericCode => 191;
        public string[] TLD => new [] { ".hr" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BA,
            Alpha2Code.HU,
            Alpha2Code.ME,
            Alpha2Code.RS,
            Alpha2Code.SI,
        };

        public ICurrency[] Currencies => new [] { new HrkCurrency() };
        public string[] CallingCodes => new [] { "385" };
    }
}
