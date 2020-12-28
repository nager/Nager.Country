using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Rwanda
    /// </summary>
    public class RwandaInfo : ICountryInfo
    {
        public string CommonName => "Rwanda";
        public string OfficialName => "Republic of Rwanda";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "رواندا"),
            new Translation(LanguageCode.AZ, "Ruanda"),
            new Translation(LanguageCode.BE, "Руанда"),
            new Translation(LanguageCode.BG, "Руанда"),
            new Translation(LanguageCode.BS, "Ruanda"),
            new Translation(LanguageCode.CA, "Ruanda"),
            new Translation(LanguageCode.CS, "Rwanda"),
            new Translation(LanguageCode.DA, "Rwanda"),
            new Translation(LanguageCode.DE, "Ruanda"),
            new Translation(LanguageCode.EL, "Ρουάντα"),
            new Translation(LanguageCode.EN, "Rwanda"),
            new Translation(LanguageCode.ES, "Rwanda"),
            new Translation(LanguageCode.ET, "Rwanda"),
            new Translation(LanguageCode.FA, "رواندا"),
            new Translation(LanguageCode.FI, "Ruanda"),
            new Translation(LanguageCode.FR, "Rwanda"),
            new Translation(LanguageCode.HE, "רואנדה"),
            new Translation(LanguageCode.HR, "Ruanda"),
            new Translation(LanguageCode.HU, "Ruanda"),
            new Translation(LanguageCode.HY, "Ռուանդա"),
            new Translation(LanguageCode.ID, "Rwanda"),
            new Translation(LanguageCode.IT, "Ruanda"),
            new Translation(LanguageCode.JA, "ルワンダ"),
            new Translation(LanguageCode.KA, "რუანდა"),
            new Translation(LanguageCode.KK, "Руанда"),
            new Translation(LanguageCode.KO, "르완다"),
            new Translation(LanguageCode.KY, "Руанда"),
            new Translation(LanguageCode.LT, "Ruanda"),
            new Translation(LanguageCode.LV, "Ruanda"),
            new Translation(LanguageCode.MK, "Руанда"),
            new Translation(LanguageCode.MN, "Руанда"),
            new Translation(LanguageCode.NB, "Rwanda"),
            new Translation(LanguageCode.NL, "Rwanda"),
            new Translation(LanguageCode.NN, "Rwanda"),
            new Translation(LanguageCode.PL, "Rwanda"),
            new Translation(LanguageCode.PT, "Ruanda"),
            new Translation(LanguageCode.RO, "Rwanda"),
            new Translation(LanguageCode.RU, "Руанда"),
            new Translation(LanguageCode.SK, "Rwanda"),
            new Translation(LanguageCode.SL, "Ruanda"),
            new Translation(LanguageCode.SR, "Руанда"),
            new Translation(LanguageCode.SV, "Rwanda"),
            new Translation(LanguageCode.TR, "Ruanda"),
            new Translation(LanguageCode.UK, "Руанда"),
            new Translation(LanguageCode.UZ, "Ruanda"),
            new Translation(LanguageCode.ZH, "卢旺达"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.RW;
        public Alpha3Code Alpha3Code => Alpha3Code.RWA;
        public int NumericCode => 646;
        public string[] TLD => new [] { ".rw" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BI,
            Alpha2Code.CD,
            Alpha2Code.TZ,
            Alpha2Code.UG,
        };

        public ICurrency[] Currencies => new [] { new RwfCurrency() };
        public string[] CallingCodes => new [] { "250" };
    }
}
