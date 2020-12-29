using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Iraq
    /// </summary>
    public class IraqInfo : ICountryInfo
    {
        public string CommonName => "Iraq";
        public string OfficialName => "Republic of Iraq";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "العراق"),
            new Translation(LanguageCode.AZ, "İraq"),
            new Translation(LanguageCode.BE, "Ірак"),
            new Translation(LanguageCode.BG, "Ирак"),
            new Translation(LanguageCode.BS, "Irak"),
            new Translation(LanguageCode.CA, "Iraq"),
            new Translation(LanguageCode.CS, "Irák"),
            new Translation(LanguageCode.DA, "Irak"),
            new Translation(LanguageCode.DE, "Irak"),
            new Translation(LanguageCode.EL, "Ιράκ"),
            new Translation(LanguageCode.EN, "Iraq"),
            new Translation(LanguageCode.ES, "Iraq"),
            new Translation(LanguageCode.ET, "Iraak"),
            new Translation(LanguageCode.FA, "عراق"),
            new Translation(LanguageCode.FI, "Irak"),
            new Translation(LanguageCode.FR, "Irak"),
            new Translation(LanguageCode.HE, "עיראק"),
            new Translation(LanguageCode.HR, "Irak"),
            new Translation(LanguageCode.HU, "Irak"),
            new Translation(LanguageCode.HY, "Իրաք"),
            new Translation(LanguageCode.ID, "Irak"),
            new Translation(LanguageCode.IT, "Iraq"),
            new Translation(LanguageCode.JA, "イラク"),
            new Translation(LanguageCode.KA, "ერაყი"),
            new Translation(LanguageCode.KK, "Ирак"),
            new Translation(LanguageCode.KO, "이라크"),
            new Translation(LanguageCode.KY, "Ирак"),
            new Translation(LanguageCode.LT, "Irakas"),
            new Translation(LanguageCode.LV, "Irāka"),
            new Translation(LanguageCode.MK, "Ирак"),
            new Translation(LanguageCode.MN, "Ирак"),
            new Translation(LanguageCode.NB, "Irak"),
            new Translation(LanguageCode.NL, "Irak"),
            new Translation(LanguageCode.NN, "Irak"),
            new Translation(LanguageCode.PL, "Irak"),
            new Translation(LanguageCode.PT, "Iraque"),
            new Translation(LanguageCode.RO, "Irak"),
            new Translation(LanguageCode.RU, "Ирак"),
            new Translation(LanguageCode.SK, "Irak"),
            new Translation(LanguageCode.SL, "Irak"),
            new Translation(LanguageCode.SR, "Ирак"),
            new Translation(LanguageCode.SV, "Irak"),
            new Translation(LanguageCode.TR, "Irak"),
            new Translation(LanguageCode.UK, "Ірак"),
            new Translation(LanguageCode.UZ, "Iroq"),
            new Translation(LanguageCode.ZH, "伊拉克"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.IQ;
        public Alpha3Code Alpha3Code => Alpha3Code.IRQ;
        public int NumericCode => 368;
        public string[] TLD => new [] { ".iq" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IR,
            Alpha2Code.JO,
            Alpha2Code.KW,
            Alpha2Code.SA,
            Alpha2Code.SY,
            Alpha2Code.TR,
        };

        public ICurrency[] Currencies => new [] { new IqdCurrency() };
        public string[] CallingCodes => new [] { "964" };
    }
}
