using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Gabon
    /// </summary>
    public class GabonInfo : ICountryInfo
    {
        public string CommonName => "Gabon";
        public string OfficialName => "Gabonese Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الغابون"),
            new Translation(LanguageCode.AZ, "Qabon"),
            new Translation(LanguageCode.BE, "Габон"),
            new Translation(LanguageCode.BG, "Габон"),
            new Translation(LanguageCode.BS, "Gabon"),
            new Translation(LanguageCode.CA, "Gabon"),
            new Translation(LanguageCode.CS, "Gabon"),
            new Translation(LanguageCode.DA, "Gabon"),
            new Translation(LanguageCode.DE, "Gabun"),
            new Translation(LanguageCode.EL, "Γκαμπόν"),
            new Translation(LanguageCode.EN, "Gabon"),
            new Translation(LanguageCode.ES, "Gabón"),
            new Translation(LanguageCode.ET, "Gabon"),
            new Translation(LanguageCode.FA, "گابن"),
            new Translation(LanguageCode.FI, "Gabon"),
            new Translation(LanguageCode.FR, "Gabon"),
            new Translation(LanguageCode.HE, "גבון"),
            new Translation(LanguageCode.HR, "Gabon"),
            new Translation(LanguageCode.HU, "Gabon"),
            new Translation(LanguageCode.HY, "Գաբոն"),
            new Translation(LanguageCode.ID, "Gabon"),
            new Translation(LanguageCode.IT, "Gabon"),
            new Translation(LanguageCode.JA, "ガボン"),
            new Translation(LanguageCode.KA, "გაბონი"),
            new Translation(LanguageCode.KK, "Габон"),
            new Translation(LanguageCode.KO, "가봉"),
            new Translation(LanguageCode.KY, "Габон"),
            new Translation(LanguageCode.LT, "Gabonas"),
            new Translation(LanguageCode.LV, "Gabona"),
            new Translation(LanguageCode.MK, "Габон"),
            new Translation(LanguageCode.MN, "Габон"),
            new Translation(LanguageCode.NB, "Gabon"),
            new Translation(LanguageCode.NL, "Gabon"),
            new Translation(LanguageCode.NN, "Gabon"),
            new Translation(LanguageCode.PL, "Gabon"),
            new Translation(LanguageCode.PT, "Gabão"),
            new Translation(LanguageCode.RO, "Gabon"),
            new Translation(LanguageCode.RU, "Габон"),
            new Translation(LanguageCode.SK, "Gabon"),
            new Translation(LanguageCode.SL, "Gabon"),
            new Translation(LanguageCode.SR, "Габон"),
            new Translation(LanguageCode.SV, "Gabon"),
            new Translation(LanguageCode.TR, "Gabon"),
            new Translation(LanguageCode.UK, "Габон"),
            new Translation(LanguageCode.UZ, "Gabon"),
            new Translation(LanguageCode.ZH, "加彭"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GA;
        public Alpha3Code Alpha3Code => Alpha3Code.GAB;
        public int NumericCode => 266;
        public string[] TLD => new [] { ".ga" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CM,
            Alpha2Code.CG,
            Alpha2Code.GQ,
        };

        public ICurrency[] Currencies => new [] { new XafCurrency() };
        public string[] CallingCodes => new [] { "241" };
    }
}
