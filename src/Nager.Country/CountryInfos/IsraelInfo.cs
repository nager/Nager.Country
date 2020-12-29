using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Israel
    /// </summary>
    public class IsraelInfo : ICountryInfo
    {
        public string CommonName => "Israel";
        public string OfficialName => "State of Israel";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "إسرائيل"),
            new Translation(LanguageCode.AZ, "İsrail"),
            new Translation(LanguageCode.BE, "Ізраіль"),
            new Translation(LanguageCode.BG, "Израел"),
            new Translation(LanguageCode.BS, "Izrael"),
            new Translation(LanguageCode.CA, "Israel"),
            new Translation(LanguageCode.CS, "Izrael"),
            new Translation(LanguageCode.DA, "Israel"),
            new Translation(LanguageCode.DE, "Israel"),
            new Translation(LanguageCode.EL, "Ισραήλ"),
            new Translation(LanguageCode.EN, "Israel"),
            new Translation(LanguageCode.ES, "Israel"),
            new Translation(LanguageCode.ET, "Iisrael"),
            new Translation(LanguageCode.FA, "اسرائیل"),
            new Translation(LanguageCode.FI, "Israel"),
            new Translation(LanguageCode.FR, "Israël"),
            new Translation(LanguageCode.HE, "ישראל"),
            new Translation(LanguageCode.HR, "Izrael"),
            new Translation(LanguageCode.HU, "Izrael"),
            new Translation(LanguageCode.HY, "Իսրայել"),
            new Translation(LanguageCode.ID, "Israel"),
            new Translation(LanguageCode.IT, "Israele"),
            new Translation(LanguageCode.JA, "イスラエル"),
            new Translation(LanguageCode.KA, "ისრაელი"),
            new Translation(LanguageCode.KK, "Израиль"),
            new Translation(LanguageCode.KO, "이스라엘"),
            new Translation(LanguageCode.KY, "Израиль"),
            new Translation(LanguageCode.LT, "Izraelis"),
            new Translation(LanguageCode.LV, "Izraēla"),
            new Translation(LanguageCode.MK, "Израел"),
            new Translation(LanguageCode.MN, "Израиль"),
            new Translation(LanguageCode.NB, "Israel"),
            new Translation(LanguageCode.NL, "Israël"),
            new Translation(LanguageCode.NN, "Israel"),
            new Translation(LanguageCode.PL, "Izrael"),
            new Translation(LanguageCode.PT, "Israel"),
            new Translation(LanguageCode.RO, "Israel"),
            new Translation(LanguageCode.RU, "Израиль"),
            new Translation(LanguageCode.SK, "Izrael"),
            new Translation(LanguageCode.SL, "Izrael"),
            new Translation(LanguageCode.SR, "Израел"),
            new Translation(LanguageCode.SV, "Israel"),
            new Translation(LanguageCode.TR, "İsrail"),
            new Translation(LanguageCode.UK, "Ізраїль"),
            new Translation(LanguageCode.UZ, "Isroil"),
            new Translation(LanguageCode.ZH, "以色列"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.IL;
        public Alpha3Code Alpha3Code => Alpha3Code.ISR;
        public int NumericCode => 376;
        public string[] TLD => new [] { ".il" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.EG,
            Alpha2Code.JO,
            Alpha2Code.LB,
            Alpha2Code.SY,
        };

        public ICurrency[] Currencies => new [] { new IlsCurrency() };
        public string[] CallingCodes => new [] { "972" };
    }
}
