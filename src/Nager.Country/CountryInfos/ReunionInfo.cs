using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Réunion
    /// </summary>
    public class ReunionInfo : ICountryInfo
    {
        public string CommonName => "Réunion";
        public string OfficialName => "Réunion Island";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "لا ريونيون"),
            new Translation(LanguageCode.AZ, "Reyunyon"),
            new Translation(LanguageCode.BE, "Рэюньён"),
            new Translation(LanguageCode.BG, "Реюнион"),
            new Translation(LanguageCode.BS, "Reunion"),
            new Translation(LanguageCode.CA, "Reunió, illa de la"),
            new Translation(LanguageCode.CS, "Réunion"),
            new Translation(LanguageCode.DA, "Réunion"),
            new Translation(LanguageCode.DE, "Réunion"),
            new Translation(LanguageCode.EL, "Ρεϋνιόν"),
            new Translation(LanguageCode.EN, "Reunion"),
            new Translation(LanguageCode.ES, "Reunión"),
            new Translation(LanguageCode.ET, "Réunion"),
            new Translation(LanguageCode.FA, "رئونیون"),
            new Translation(LanguageCode.FI, "Réunion"),
            new Translation(LanguageCode.FR, "Réunion"),
            new Translation(LanguageCode.HE, "ראוניון"),
            new Translation(LanguageCode.HR, "Réunion"),
            new Translation(LanguageCode.HU, "Réunion"),
            new Translation(LanguageCode.HY, "Ռեյունիոն"),
            new Translation(LanguageCode.ID, "Reunion"),
            new Translation(LanguageCode.IT, "Réunion"),
            new Translation(LanguageCode.JA, "レユニオン"),
            new Translation(LanguageCode.KA, "რეუნიონი"),
            new Translation(LanguageCode.KK, "Реюньон"),
            new Translation(LanguageCode.KO, "재결합"),
            new Translation(LanguageCode.KY, "Реюнион"),
            new Translation(LanguageCode.LT, "Reunjonas"),
            new Translation(LanguageCode.LV, "Reinjona"),
            new Translation(LanguageCode.MK, "Реунион"),
            new Translation(LanguageCode.MN, "Реюньон"),
            new Translation(LanguageCode.NB, "Réunion"),
            new Translation(LanguageCode.NL, "Réunion"),
            new Translation(LanguageCode.NN, "Réunion"),
            new Translation(LanguageCode.PL, "Reunion"),
            new Translation(LanguageCode.PT, "Reunião"),
            new Translation(LanguageCode.RO, "Réunion"),
            new Translation(LanguageCode.RU, "Реюньон"),
            new Translation(LanguageCode.SK, "Réunion"),
            new Translation(LanguageCode.SL, "Reunion"),
            new Translation(LanguageCode.SR, "Реинион"),
            new Translation(LanguageCode.SV, "Réunion"),
            new Translation(LanguageCode.TR, "Réunion"),
            new Translation(LanguageCode.UK, "Реюньйон"),
            new Translation(LanguageCode.UZ, "Reyunion"),
            new Translation(LanguageCode.ZH, "留尼汪"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.RE;
        public Alpha3Code Alpha3Code => Alpha3Code.REU;
        public int NumericCode => 638;
        public string[] TLD => new [] { ".re" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "262" };
    }
}
