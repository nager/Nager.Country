using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bahamas
    /// </summary>
    public class BahamasInfo : ICountryInfo
    {
        public string CommonName => "Bahamas";
        public string OfficialName => "Commonwealth of the Bahamas";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "باهاماس"),
            new Translation(LanguageCode.AZ, "Baham adaları"),
            new Translation(LanguageCode.BE, "Багамы"),
            new Translation(LanguageCode.BG, "Бахами"),
            new Translation(LanguageCode.BS, "Bahami"),
            new Translation(LanguageCode.CA, "Bahames"),
            new Translation(LanguageCode.CS, "Bahamy"),
            new Translation(LanguageCode.DA, "Bahamas"),
            new Translation(LanguageCode.DE, "Bahamas"),
            new Translation(LanguageCode.EL, "Μπαχάμες"),
            new Translation(LanguageCode.EN, "Bahamas"),
            new Translation(LanguageCode.ES, "Bahamas"),
            new Translation(LanguageCode.ET, "Bahama"),
            new Translation(LanguageCode.FA, "باهاما"),
            new Translation(LanguageCode.FI, "Bahama"),
            new Translation(LanguageCode.FR, "Bahamas"),
            new Translation(LanguageCode.HE, "איי בהאמה"),
            new Translation(LanguageCode.HR, "Bahami"),
            new Translation(LanguageCode.HU, "Bahama-szigetek"),
            new Translation(LanguageCode.HY, "Բահամաներ"),
            new Translation(LanguageCode.ID, "Bahama"),
            new Translation(LanguageCode.IT, "Bahamas"),
            new Translation(LanguageCode.JA, "バハマ"),
            new Translation(LanguageCode.KA, "ბაჰამის კუნძულები"),
            new Translation(LanguageCode.KK, "Багам аралдары"),
            new Translation(LanguageCode.KO, "바하마"),
            new Translation(LanguageCode.KY, "Багам аралдары"),
            new Translation(LanguageCode.LT, "Bahamos"),
            new Translation(LanguageCode.LV, "Bahamu salas"),
            new Translation(LanguageCode.MK, "Бахами"),
            new Translation(LanguageCode.MN, "Багам"),
            new Translation(LanguageCode.NB, "Bahamas"),
            new Translation(LanguageCode.NL, "Bahama's"),
            new Translation(LanguageCode.NN, "Bahamas"),
            new Translation(LanguageCode.PL, "Bahamy"),
            new Translation(LanguageCode.PT, "Bahamas"),
            new Translation(LanguageCode.RO, "Bahamas"),
            new Translation(LanguageCode.RU, "Багамы"),
            new Translation(LanguageCode.SK, "Bahamy"),
            new Translation(LanguageCode.SL, "Bahami"),
            new Translation(LanguageCode.SR, "Бахами"),
            new Translation(LanguageCode.SV, "Bahamas"),
            new Translation(LanguageCode.TR, "Bahamalar"),
            new Translation(LanguageCode.UK, "Багами"),
            new Translation(LanguageCode.UZ, "Bagama orollari"),
            new Translation(LanguageCode.ZH, "巴哈马"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BS;
        public Alpha3Code Alpha3Code => Alpha3Code.BHS;
        public int NumericCode => 044;
        public string[] TLD => new [] { ".bs" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new BsdCurrency() };
        public string[] CallingCodes => new [] { "1242" };
    }
}
