using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Germany
    /// </summary>
    public class GermanyInfo : ICountryInfo
    {
        public string CommonName => "Germany";
        public string OfficialName => "Federal Republic of Germany";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "ألمانيا"),
            new Translation(LanguageCode.AZ, "Almaniya"),
            new Translation(LanguageCode.BE, "Германія"),
            new Translation(LanguageCode.BG, "Германия"),
            new Translation(LanguageCode.BS, "Njemačka"),
            new Translation(LanguageCode.CA, "Alemanya"),
            new Translation(LanguageCode.CS, "Německo"),
            new Translation(LanguageCode.DA, "Tyskland"),
            new Translation(LanguageCode.DE, "Deutschland"),
            new Translation(LanguageCode.EL, "Γερμανία"),
            new Translation(LanguageCode.EN, "Germany"),
            new Translation(LanguageCode.ES, "Alemania"),
            new Translation(LanguageCode.ET, "Saksamaa"),
            new Translation(LanguageCode.FA, "آلمان"),
            new Translation(LanguageCode.FI, "Saksa"),
            new Translation(LanguageCode.FR, "Allemagne"),
            new Translation(LanguageCode.HE, "גרמניה"),
            new Translation(LanguageCode.HR, "Njemačka"),
            new Translation(LanguageCode.HU, "Németország"),
            new Translation(LanguageCode.HY, "Գերմանիա"),
            new Translation(LanguageCode.ID, "Jerman"),
            new Translation(LanguageCode.IT, "Germania"),
            new Translation(LanguageCode.JA, "ドイツ"),
            new Translation(LanguageCode.KA, "გერმანია"),
            new Translation(LanguageCode.KK, "Германия"),
            new Translation(LanguageCode.KO, "독일"),
            new Translation(LanguageCode.KY, "Германия"),
            new Translation(LanguageCode.LT, "Vokietija"),
            new Translation(LanguageCode.LV, "Vācija"),
            new Translation(LanguageCode.MK, "Германија"),
            new Translation(LanguageCode.MN, "Герман"),
            new Translation(LanguageCode.NB, "Tyskland"),
            new Translation(LanguageCode.NL, "Duitsland"),
            new Translation(LanguageCode.NN, "Tyskland"),
            new Translation(LanguageCode.PL, "Niemcy"),
            new Translation(LanguageCode.PT, "Alemanha"),
            new Translation(LanguageCode.RO, "Germania"),
            new Translation(LanguageCode.RU, "Германия"),
            new Translation(LanguageCode.SK, "Nemecko"),
            new Translation(LanguageCode.SL, "Nemčija"),
            new Translation(LanguageCode.SR, "Немачка"),
            new Translation(LanguageCode.SV, "Tyskland"),
            new Translation(LanguageCode.TR, "Almanya"),
            new Translation(LanguageCode.UK, "Німеччина"),
            new Translation(LanguageCode.UZ, "Germaniya"),
            new Translation(LanguageCode.ZH, "德国"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.DE;
        public Alpha3Code Alpha3Code => Alpha3Code.DEU;
        public int NumericCode => 276;
        public string[] TLD => new [] { ".de" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.BE,
            Alpha2Code.CZ,
            Alpha2Code.DK,
            Alpha2Code.FR,
            Alpha2Code.LU,
            Alpha2Code.NL,
            Alpha2Code.PL,
            Alpha2Code.CH,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "49" };
    }
}
