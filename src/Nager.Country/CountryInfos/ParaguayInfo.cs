using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Paraguay
    /// </summary>
    public class ParaguayInfo : ICountryInfo
    {
        public string CommonName => "Paraguay";
        public string OfficialName => "Republic of Paraguay";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "باراغواي"),
            new Translation(LanguageCode.AZ, "Paraqvay"),
            new Translation(LanguageCode.BE, "Парагвай"),
            new Translation(LanguageCode.BG, "Парагвай"),
            new Translation(LanguageCode.BS, "Paragvaj"),
            new Translation(LanguageCode.CA, "Paraguai"),
            new Translation(LanguageCode.CS, "Paraguay"),
            new Translation(LanguageCode.DA, "Paraguay"),
            new Translation(LanguageCode.DE, "Paraguay"),
            new Translation(LanguageCode.EL, "Παραγουάη"),
            new Translation(LanguageCode.EN, "Paraguay"),
            new Translation(LanguageCode.ES, "Paraguay"),
            new Translation(LanguageCode.ET, "Paraguay"),
            new Translation(LanguageCode.FA, "پاراگوئه"),
            new Translation(LanguageCode.FI, "Paraguay"),
            new Translation(LanguageCode.FR, "Paraguay"),
            new Translation(LanguageCode.HE, "פרגוואי"),
            new Translation(LanguageCode.HR, "Paragvaj"),
            new Translation(LanguageCode.HU, "Paraguay"),
            new Translation(LanguageCode.HY, "Պարագվայ"),
            new Translation(LanguageCode.ID, "Paraguay"),
            new Translation(LanguageCode.IT, "Paraguay"),
            new Translation(LanguageCode.JA, "パラグアイ"),
            new Translation(LanguageCode.KA, "პარაგვაი"),
            new Translation(LanguageCode.KK, "Парагвай"),
            new Translation(LanguageCode.KO, "파라과이"),
            new Translation(LanguageCode.KY, "Парагвай"),
            new Translation(LanguageCode.LT, "Paragvajus"),
            new Translation(LanguageCode.LV, "Paragvaja"),
            new Translation(LanguageCode.MK, "Парагвај"),
            new Translation(LanguageCode.MN, "Парагвай"),
            new Translation(LanguageCode.NB, "Paraguay"),
            new Translation(LanguageCode.NL, "Paraguay"),
            new Translation(LanguageCode.NN, "Paraguay"),
            new Translation(LanguageCode.PL, "Paragwaj"),
            new Translation(LanguageCode.PT, "Paraguai"),
            new Translation(LanguageCode.RO, "Paraguay"),
            new Translation(LanguageCode.RU, "Парагвай"),
            new Translation(LanguageCode.SK, "Paraguaj"),
            new Translation(LanguageCode.SL, "Paragvaj"),
            new Translation(LanguageCode.SR, "Парагвај"),
            new Translation(LanguageCode.SV, "Paraguay"),
            new Translation(LanguageCode.TR, "Paraguay"),
            new Translation(LanguageCode.UK, "Парагвай"),
            new Translation(LanguageCode.UZ, "Paragvay"),
            new Translation(LanguageCode.ZH, "巴拉圭"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.PY;
        public Alpha3Code Alpha3Code => Alpha3Code.PRY;
        public int NumericCode => 600;
        public string[] TLD => new [] { ".py" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BO,
            Alpha2Code.BR,
        };

        public ICurrency[] Currencies => new [] { new PygCurrency() };
        public string[] CallingCodes => new [] { "595" };
    }
}
