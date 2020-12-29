using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Swaziland
    /// </summary>
    public class SwazilandInfo : ICountryInfo
    {
        public string CommonName => "Eswatini";
        public string OfficialName => "Kingdom of Swaziland";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سوازيلاند"),
            new Translation(LanguageCode.AZ, "Svazilend"),
            new Translation(LanguageCode.BE, "Свазіленд"),
            new Translation(LanguageCode.BG, "Свазиленд"),
            new Translation(LanguageCode.BS, "Svazilend"),
            new Translation(LanguageCode.CA, "Swazilàndia"),
            new Translation(LanguageCode.CS, "Svazijsko"),
            new Translation(LanguageCode.DA, "Swaziland"),
            new Translation(LanguageCode.DE, "Swasiland"),
            new Translation(LanguageCode.EL, "Σουαζιλάνδη"),
            new Translation(LanguageCode.EN, "Swaziland"),
            new Translation(LanguageCode.ES, "Swazilandia"),
            new Translation(LanguageCode.ET, "Svaasimaa"),
            new Translation(LanguageCode.FA, "سوازیلند"),
            new Translation(LanguageCode.FI, "Swazimaa"),
            new Translation(LanguageCode.FR, "Ngwane, Royaume du Swaziland"),
            new Translation(LanguageCode.HE, "סווזילנד"),
            new Translation(LanguageCode.HR, "Svazi"),
            new Translation(LanguageCode.HU, "Szváziföld"),
            new Translation(LanguageCode.HY, "Սվազիլենդ"),
            new Translation(LanguageCode.ID, "Swaziland"),
            new Translation(LanguageCode.IT, "Swaziland"),
            new Translation(LanguageCode.JA, "スワジランド"),
            new Translation(LanguageCode.KA, "სვაზილენდი"),
            new Translation(LanguageCode.KK, "Свазиленд"),
            new Translation(LanguageCode.KO, "스와질란드"),
            new Translation(LanguageCode.KY, "Свазиленд"),
            new Translation(LanguageCode.LT, "Svazilandas"),
            new Translation(LanguageCode.LV, "Svazilenda"),
            new Translation(LanguageCode.MK, "Свазиленд"),
            new Translation(LanguageCode.MN, "Свазиланд"),
            new Translation(LanguageCode.NB, "Swaziland"),
            new Translation(LanguageCode.NL, "Ngwane, Koninkrijk Swaziland"),
            new Translation(LanguageCode.NN, "Swaziland"),
            new Translation(LanguageCode.PL, "Suazi"),
            new Translation(LanguageCode.PT, "Suazilândia"),
            new Translation(LanguageCode.RO, "Swaziland"),
            new Translation(LanguageCode.RU, "Свазиленд"),
            new Translation(LanguageCode.SK, "Svazijsko"),
            new Translation(LanguageCode.SL, "Svazi"),
            new Translation(LanguageCode.SR, "Свазиленд"),
            new Translation(LanguageCode.SV, "Swaziland"),
            new Translation(LanguageCode.TR, "Svaziland"),
            new Translation(LanguageCode.UK, "Свазіленд"),
            new Translation(LanguageCode.UZ, "Svazilend"),
            new Translation(LanguageCode.ZH, "斯威士兰"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SZ;
        public Alpha3Code Alpha3Code => Alpha3Code.SWZ;
        public int NumericCode => 748;
        public string[] TLD => new [] { ".sz" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MZ,
            Alpha2Code.ZA,
        };

        public ICurrency[] Currencies => new [] { new SzlCurrency() };
        public string[] CallingCodes => new [] { "268" };
    }
}
