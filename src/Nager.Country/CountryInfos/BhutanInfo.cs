using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bhutan
    /// </summary>
    public class BhutanInfo : ICountryInfo
    {
        public string CommonName => "Bhutan";
        public string OfficialName => "Kingdom of Bhutan";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بوتان"),
            new Translation(LanguageCode.AZ, "Butan"),
            new Translation(LanguageCode.BE, "Бутан"),
            new Translation(LanguageCode.BG, "Бутан"),
            new Translation(LanguageCode.BS, "Butan"),
            new Translation(LanguageCode.CA, "Bhutan"),
            new Translation(LanguageCode.CS, "Bhútán"),
            new Translation(LanguageCode.DA, "Bhutan"),
            new Translation(LanguageCode.DE, "Bhutan"),
            new Translation(LanguageCode.EL, "Μπουτάν"),
            new Translation(LanguageCode.EN, "Bhutan"),
            new Translation(LanguageCode.ES, "Bhután"),
            new Translation(LanguageCode.ET, "Bhutan"),
            new Translation(LanguageCode.FA, "بوتان"),
            new Translation(LanguageCode.FI, "Bhutan"),
            new Translation(LanguageCode.FR, "Bhoutan"),
            new Translation(LanguageCode.HE, "בהוטן"),
            new Translation(LanguageCode.HR, "Butan"),
            new Translation(LanguageCode.HU, "Bhután"),
            new Translation(LanguageCode.HY, "Բութան"),
            new Translation(LanguageCode.ID, "Bhutan"),
            new Translation(LanguageCode.IT, "Bhutan"),
            new Translation(LanguageCode.JA, "ブータン"),
            new Translation(LanguageCode.KA, "ბუტანი"),
            new Translation(LanguageCode.KK, "Бутан"),
            new Translation(LanguageCode.KO, "부탄"),
            new Translation(LanguageCode.KY, "Бутан"),
            new Translation(LanguageCode.LT, "Butanas"),
            new Translation(LanguageCode.LV, "Butāna"),
            new Translation(LanguageCode.MK, "Бутан"),
            new Translation(LanguageCode.MN, "Бутан"),
            new Translation(LanguageCode.NB, "Bhutan"),
            new Translation(LanguageCode.NL, "Bhutan"),
            new Translation(LanguageCode.NN, "Bhutan"),
            new Translation(LanguageCode.PL, "Bhutan"),
            new Translation(LanguageCode.PT, "Butão"),
            new Translation(LanguageCode.RO, "Bhutan"),
            new Translation(LanguageCode.RU, "Бутан"),
            new Translation(LanguageCode.SK, "Bhután"),
            new Translation(LanguageCode.SL, "Butan"),
            new Translation(LanguageCode.SR, "Бутан"),
            new Translation(LanguageCode.SV, "Bhutan"),
            new Translation(LanguageCode.TR, "Butan"),
            new Translation(LanguageCode.UK, "Бутан"),
            new Translation(LanguageCode.UZ, "Butan"),
            new Translation(LanguageCode.ZH, "不丹"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BT;
        public Alpha3Code Alpha3Code => Alpha3Code.BTN;
        public int NumericCode => 064;
        public string[] TLD => new [] { ".bt" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.IN,
        };

        public ICurrency[] Currencies => new ICurrency[] { new BtnCurrency(), new InrCurrency() };
        public string[] CallingCodes => new [] { "975" };
    }
}
