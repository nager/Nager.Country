using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Burkina Faso
    /// </summary>
    public class BurkinaFasoInfo : ICountryInfo
    {
        public string CommonName => "Burkina Faso";
        public string OfficialName => "Burkina Faso";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بوركينا فاسو"),
            new Translation(LanguageCode.AZ, "Burkina Faso"),
            new Translation(LanguageCode.BE, "Буркіна-Фасо"),
            new Translation(LanguageCode.BG, "Буркина Фасо"),
            new Translation(LanguageCode.BS, "Burkina Faso"),
            new Translation(LanguageCode.CA, "Burkina Faso"),
            new Translation(LanguageCode.CS, "Burkina Faso"),
            new Translation(LanguageCode.DA, "Burkina Faso"),
            new Translation(LanguageCode.DE, "Burkina Faso"),
            new Translation(LanguageCode.EL, "Μπουρκίνα Φάσο"),
            new Translation(LanguageCode.EN, "Burkina Faso"),
            new Translation(LanguageCode.ES, "Burkina Faso"),
            new Translation(LanguageCode.ET, "Burkina Faso"),
            new Translation(LanguageCode.FA, "بورکینافاسو"),
            new Translation(LanguageCode.FI, "Burkina Faso"),
            new Translation(LanguageCode.FR, "Burkina Faso"),
            new Translation(LanguageCode.HE, "בורקינה פאסו"),
            new Translation(LanguageCode.HR, "Burkina Faso"),
            new Translation(LanguageCode.HU, "Burkina Faso"),
            new Translation(LanguageCode.HY, "Բուրկինա Ֆասո"),
            new Translation(LanguageCode.ID, "Burkina Faso"),
            new Translation(LanguageCode.IT, "Burkina Faso"),
            new Translation(LanguageCode.JA, "ブルキナファソ"),
            new Translation(LanguageCode.KA, "ბურკინა-ფასო"),
            new Translation(LanguageCode.KK, "Буркина-Фасо"),
            new Translation(LanguageCode.KO, "부키 나 파소"),
            new Translation(LanguageCode.KY, "Буркина-Фасо"),
            new Translation(LanguageCode.LT, "Burkina Fasas"),
            new Translation(LanguageCode.LV, "Burkinafaso"),
            new Translation(LanguageCode.MK, "Буркина Фасо"),
            new Translation(LanguageCode.MN, "Буркина фасо"),
            new Translation(LanguageCode.NB, "Burkina Faso"),
            new Translation(LanguageCode.NL, "Burkina Faso"),
            new Translation(LanguageCode.NN, "Burkina Faso"),
            new Translation(LanguageCode.PL, "Burkina Faso"),
            new Translation(LanguageCode.PT, "Burquina Faso"),
            new Translation(LanguageCode.RO, "Burkina Faso"),
            new Translation(LanguageCode.RU, "Буркина-Фасо"),
            new Translation(LanguageCode.SK, "Burkina Faso"),
            new Translation(LanguageCode.SL, "Burkina Faso"),
            new Translation(LanguageCode.SR, "Буркина Фасо"),
            new Translation(LanguageCode.SV, "Burkina Faso"),
            new Translation(LanguageCode.TR, "Burkina Faso"),
            new Translation(LanguageCode.UK, "Буркіна-Фасо"),
            new Translation(LanguageCode.UZ, "Burkina-Faso"),
            new Translation(LanguageCode.ZH, "布吉纳法索"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BF;
        public Alpha3Code Alpha3Code => Alpha3Code.BFA;
        public int NumericCode => 854;
        public string[] TLD => new [] { ".bf" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BJ,
            Alpha2Code.CI,
            Alpha2Code.GH,
            Alpha2Code.ML,
            Alpha2Code.NE,
            Alpha2Code.TG,
        };

        public ICurrency[] Currencies => new [] { new XofCurrency() };
        public string[] CallingCodes => new [] { "226" };
    }
}
