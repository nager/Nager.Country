using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Seychelles
    /// </summary>
    public class SeychellesInfo : ICountryInfo
    {
        public string CommonName => "Seychelles";
        public string OfficialName => "Republic of Seychelles";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سيشل"),
            new Translation(LanguageCode.AZ, "Seyşel adaları"),
            new Translation(LanguageCode.BE, "Сейшэльскія Астравы"),
            new Translation(LanguageCode.BG, "Сейшели"),
            new Translation(LanguageCode.BS, "Sejšeli"),
            new Translation(LanguageCode.CA, "Seychelles"),
            new Translation(LanguageCode.CS, "Seychely"),
            new Translation(LanguageCode.DA, "Seychellerne"),
            new Translation(LanguageCode.DE, "Seychellen"),
            new Translation(LanguageCode.EL, "Σεϋχέλλες"),
            new Translation(LanguageCode.EN, "Seychelles"),
            new Translation(LanguageCode.ES, "Seychelles"),
            new Translation(LanguageCode.ET, "Seišellid"),
            new Translation(LanguageCode.FA, "سیشل"),
            new Translation(LanguageCode.FI, "Seychellit"),
            new Translation(LanguageCode.FR, "Seychelles"),
            new Translation(LanguageCode.HE, "איי סיישל"),
            new Translation(LanguageCode.HR, "Sejšeli"),
            new Translation(LanguageCode.HU, "Seychelle-szigetek"),
            new Translation(LanguageCode.HY, "Սեյշելներ"),
            new Translation(LanguageCode.ID, "Seychelles"),
            new Translation(LanguageCode.IT, "Seychelles"),
            new Translation(LanguageCode.JA, "セーシェル"),
            new Translation(LanguageCode.KA, "სეიშელის კუნძულები"),
            new Translation(LanguageCode.KK, "Сейшель аралдары"),
            new Translation(LanguageCode.KO, "세이셸"),
            new Translation(LanguageCode.KY, "Сейшелдер"),
            new Translation(LanguageCode.LT, "Seišeliai"),
            new Translation(LanguageCode.LV, "Seišelu salas"),
            new Translation(LanguageCode.MK, "Сејшели"),
            new Translation(LanguageCode.MN, "Сейшел"),
            new Translation(LanguageCode.NB, "Seychellene"),
            new Translation(LanguageCode.NL, "Seychellen"),
            new Translation(LanguageCode.NN, "Seychellane"),
            new Translation(LanguageCode.PL, "Seszele"),
            new Translation(LanguageCode.PT, "Seychelles"),
            new Translation(LanguageCode.RO, "Seychelles"),
            new Translation(LanguageCode.RU, "Сейшельские Острова"),
            new Translation(LanguageCode.SK, "Seychely"),
            new Translation(LanguageCode.SL, "Sejšeli"),
            new Translation(LanguageCode.SR, "Сејшели"),
            new Translation(LanguageCode.SV, "Seychellerna"),
            new Translation(LanguageCode.TR, "Seyşeller"),
            new Translation(LanguageCode.UK, "Сейшельські Острови"),
            new Translation(LanguageCode.UZ, "Seyshel orollari"),
            new Translation(LanguageCode.ZH, "塞舌尔"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SC;
        public Alpha3Code Alpha3Code => Alpha3Code.SYC;
        public int NumericCode => 690;
        public string[] TLD => new [] { ".sc" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new ScrCurrency() };
        public string[] CallingCodes => new [] { "248" };
    }
}
