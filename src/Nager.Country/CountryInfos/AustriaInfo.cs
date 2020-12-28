using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Austria
    /// </summary>
    public class AustriaInfo : ICountryInfo
    {
        public string CommonName => "Austria";
        public string OfficialName => "Republic of Austria";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "النمسا"),
            new Translation(LanguageCode.AZ, "Avstriya"),
            new Translation(LanguageCode.BE, "Аўстрыя"),
            new Translation(LanguageCode.BG, "Австрия"),
            new Translation(LanguageCode.BS, "Austrija"),
            new Translation(LanguageCode.CA, "Àustria"),
            new Translation(LanguageCode.CS, "Rakousko"),
            new Translation(LanguageCode.DA, "Østrig"),
            new Translation(LanguageCode.DE, "Österreich"),
            new Translation(LanguageCode.EL, "Αυστρία"),
            new Translation(LanguageCode.EN, "Austria"),
            new Translation(LanguageCode.ES, "Austria"),
            new Translation(LanguageCode.ET, "Austria"),
            new Translation(LanguageCode.FA, "اتریش"),
            new Translation(LanguageCode.FI, "Itävalta"),
            new Translation(LanguageCode.FR, "Autriche"),
            new Translation(LanguageCode.HE, "אוסטריה"),
            new Translation(LanguageCode.HR, "Austrija"),
            new Translation(LanguageCode.HU, "Ausztria"),
            new Translation(LanguageCode.HY, "Ավստրիա"),
            new Translation(LanguageCode.ID, "Austria"),
            new Translation(LanguageCode.IT, "Austria"),
            new Translation(LanguageCode.JA, "オーストリア"),
            new Translation(LanguageCode.KA, "ავსტრია"),
            new Translation(LanguageCode.KK, "Австрия"),
            new Translation(LanguageCode.KO, "오스트리아"),
            new Translation(LanguageCode.KY, "Австрия"),
            new Translation(LanguageCode.LT, "Austrija"),
            new Translation(LanguageCode.LV, "Austrija"),
            new Translation(LanguageCode.MK, "Австрија"),
            new Translation(LanguageCode.MN, "Австри"),
            new Translation(LanguageCode.NB, "Østerrike"),
            new Translation(LanguageCode.NL, "Oostenrijk"),
            new Translation(LanguageCode.NN, "Austerrike"),
            new Translation(LanguageCode.PL, "Austria"),
            new Translation(LanguageCode.PT, "Áustria"),
            new Translation(LanguageCode.RO, "Austria"),
            new Translation(LanguageCode.RU, "Австрия"),
            new Translation(LanguageCode.SK, "Rakúsko"),
            new Translation(LanguageCode.SL, "Avstrija"),
            new Translation(LanguageCode.SR, "Аустрија"),
            new Translation(LanguageCode.SV, "Österrike"),
            new Translation(LanguageCode.TR, "Avusturya"),
            new Translation(LanguageCode.UK, "Австрія"),
            new Translation(LanguageCode.UZ, "Avstriya"),
            new Translation(LanguageCode.ZH, "奥地利"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AT;
        public Alpha3Code Alpha3Code => Alpha3Code.AUT;
        public int NumericCode => 040;
        public string[] TLD => new [] { ".at" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CZ,
            Alpha2Code.DE,
            Alpha2Code.HU,
            Alpha2Code.IT,
            Alpha2Code.LI,
            Alpha2Code.SK,
            Alpha2Code.SI,
            Alpha2Code.CH,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "43" };

    }
}
