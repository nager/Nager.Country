using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Curaçao
    /// </summary>
    public class CuracaoInfo : ICountryInfo
    {
        public string CommonName => "Curaçao";
        public string OfficialName => "Country of Curaçao";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "كوراساو"),
            new Translation(LanguageCode.AZ, "Kurasao"),
            new Translation(LanguageCode.BE, "Кюрасаа"),
            new Translation(LanguageCode.BG, "Кюрасао"),
            new Translation(LanguageCode.BS, "Kurasao"),
            new Translation(LanguageCode.CA, "Curaçao"),
            new Translation(LanguageCode.CS, "Curaçao"),
            new Translation(LanguageCode.DA, "Curaçao"),
            new Translation(LanguageCode.DE, "Curaçao"),
            new Translation(LanguageCode.EL, "Κουρασάο"),
            new Translation(LanguageCode.EN, "Curaçao"),
            new Translation(LanguageCode.ES, "Curaçao"),
            new Translation(LanguageCode.ET, "Curaçao"),
            new Translation(LanguageCode.FA, "کوراسائو"),
            new Translation(LanguageCode.FI, "Curaçao"),
            new Translation(LanguageCode.FR, "Curaçao"),
            new Translation(LanguageCode.HE, "קוראסאו"),
            new Translation(LanguageCode.HR, "Curaçao"),
            new Translation(LanguageCode.HU, "Curaçao"),
            new Translation(LanguageCode.HY, "Կյուրասաո"),
            new Translation(LanguageCode.ID, "Curaçao"),
            new Translation(LanguageCode.IT, "Curaçao"),
            new Translation(LanguageCode.JA, "キュラソー"),
            new Translation(LanguageCode.KA, "კიურასაო"),
            new Translation(LanguageCode.KK, "Кюрасао"),
            new Translation(LanguageCode.KO, "쿠라 사오"),
            new Translation(LanguageCode.KY, "Кюрасао"),
            new Translation(LanguageCode.LT, "Kiurasao"),
            new Translation(LanguageCode.LV, "Kirasao"),
            new Translation(LanguageCode.MK, "Курасао"),
            new Translation(LanguageCode.MN, "Куракао"),
            new Translation(LanguageCode.NB, "Curaçao"),
            new Translation(LanguageCode.NL, "Curaçao"),
            new Translation(LanguageCode.NN, "Curaçao"),
            new Translation(LanguageCode.PL, "Curaçao"),
            new Translation(LanguageCode.PT, "Curaçao"),
            new Translation(LanguageCode.RO, "Curaçao"),
            new Translation(LanguageCode.RU, "Кюрасао"),
            new Translation(LanguageCode.SK, "Curaçao"),
            new Translation(LanguageCode.SL, "Curaçao"),
            new Translation(LanguageCode.SR, "Курасао"),
            new Translation(LanguageCode.SV, "Curacao"),
            new Translation(LanguageCode.TR, "Curaçao"),
            new Translation(LanguageCode.UK, "Кюрасао"),
            new Translation(LanguageCode.UZ, "Kyurasao"),
            new Translation(LanguageCode.ZH, "库拉索"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CW;
        public Alpha3Code Alpha3Code => Alpha3Code.CUW;
        public int NumericCode => 531;
        public string[] TLD => new [] { ".cw" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AngCurrency() };
        public string[] CallingCodes => new [] { "5999" };
    }
}
