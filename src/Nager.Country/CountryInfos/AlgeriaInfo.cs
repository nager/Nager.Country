using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Algeria
    /// </summary>
    public class AlgeriaInfo : ICountryInfo
    {
        public string CommonName => "Algeria";
        public string OfficialName => "People's Democratic Republic of Algeria";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الجزائر"),
            new Translation(LanguageCode.AZ, "Əlcəzair"),
            new Translation(LanguageCode.BE, "Алжыр"),
            new Translation(LanguageCode.BG, "Алжир"),
            new Translation(LanguageCode.BS, "Alžir"),
            new Translation(LanguageCode.CA, "Algèria"),
            new Translation(LanguageCode.CS, "Alžírsko"),
            new Translation(LanguageCode.DA, "Algeriet"),
            new Translation(LanguageCode.DE, "Algerien"),
            new Translation(LanguageCode.EL, "Αλγερία"),
            new Translation(LanguageCode.EN, "Algeria"),
            new Translation(LanguageCode.ES, "Argelia"),
            new Translation(LanguageCode.ET, "Alžeeria"),
            new Translation(LanguageCode.FA, "الجزایر"),
            new Translation(LanguageCode.FI, "Algeria"),
            new Translation(LanguageCode.FR, "Algérie"),
            new Translation(LanguageCode.HE, "אלג׳יריה"),
            new Translation(LanguageCode.HR, "Alžir"),
            new Translation(LanguageCode.HU, "Algéria"),
            new Translation(LanguageCode.HY, "Ալժիր"),
            new Translation(LanguageCode.ID, "Algeria"),
            new Translation(LanguageCode.IT, "Algeria"),
            new Translation(LanguageCode.JA, "アルジェリア"),
            new Translation(LanguageCode.KA, "ალჟირი"),
            new Translation(LanguageCode.KK, "Алжир"),
            new Translation(LanguageCode.KO, "알제리"),
            new Translation(LanguageCode.KY, "Алжир"),
            new Translation(LanguageCode.LT, "Alžyras"),
            new Translation(LanguageCode.LV, "Alžīrija"),
            new Translation(LanguageCode.MK, "Алжир"),
            new Translation(LanguageCode.MN, "Алжир"),
            new Translation(LanguageCode.NB, "Algerie"),
            new Translation(LanguageCode.NL, "Algerije"),
            new Translation(LanguageCode.NN, "Algerie"),
            new Translation(LanguageCode.PL, "Algieria"),
            new Translation(LanguageCode.PT, "Argélia"),
            new Translation(LanguageCode.RO, "Algeria"),
            new Translation(LanguageCode.RU, "Алжир"),
            new Translation(LanguageCode.SK, "Alžírsko"),
            new Translation(LanguageCode.SL, "Alžirija"),
            new Translation(LanguageCode.SR, "Алжир"),
            new Translation(LanguageCode.SV, "Algeriet"),
            new Translation(LanguageCode.TR, "Cezayir"),
            new Translation(LanguageCode.UK, "Алжир"),
            new Translation(LanguageCode.UZ, "Jazoir"),
            new Translation(LanguageCode.ZH, "阿尔及利亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.DZ;
        public Alpha3Code Alpha3Code => Alpha3Code.DZA;
        public int NumericCode => 012;
        public string[] TLD => new [] { ".dz", "الجزائر." };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.TN,
            Alpha2Code.LY,
            Alpha2Code.NE,
            Alpha2Code.EH,
            Alpha2Code.MR,
            Alpha2Code.ML,
            Alpha2Code.MA,
        };

        public ICurrency[] Currencies => new [] { new DzdCurrency() };
        public string[] CallingCodes => new [] { "213" };
    }
}
