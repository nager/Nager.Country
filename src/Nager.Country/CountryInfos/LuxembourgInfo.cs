using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Luxembourg
    /// </summary>
    public class LuxembourgInfo : ICountryInfo
    {
        public string CommonName => "Luxembourg";
        public string OfficialName => "Grand Duchy of Luxembourg";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "لوكسمبورغ"),
            new Translation(LanguageCode.AZ, "Lüksemburq"),
            new Translation(LanguageCode.BE, "Люксембург"),
            new Translation(LanguageCode.BG, "Люксембург"),
            new Translation(LanguageCode.BS, "Luksemburg"),
            new Translation(LanguageCode.CA, "Luxemburg"),
            new Translation(LanguageCode.CS, "Lucembursko"),
            new Translation(LanguageCode.DA, "Luxembourg"),
            new Translation(LanguageCode.DE, "Luxemburg"),
            new Translation(LanguageCode.EL, "Λουξεμβούργο"),
            new Translation(LanguageCode.EN, "Luxembourg"),
            new Translation(LanguageCode.ES, "Luxemburgo"),
            new Translation(LanguageCode.ET, "Luksemburg"),
            new Translation(LanguageCode.FA, "لوکزامبورگ"),
            new Translation(LanguageCode.FI, "Luxemburg"),
            new Translation(LanguageCode.FR, "Luxembourg, Grand-Duché"),
            new Translation(LanguageCode.HE, "לוקסמבורג"),
            new Translation(LanguageCode.HR, "Luksemburg"),
            new Translation(LanguageCode.HU, "Luxemburg"),
            new Translation(LanguageCode.HY, "Լյուքսեմբուրգ"),
            new Translation(LanguageCode.ID, "Luxemburg"),
            new Translation(LanguageCode.IT, "Lussemburgo"),
            new Translation(LanguageCode.JA, "ルクセンブルク"),
            new Translation(LanguageCode.KA, "ლუქსემბურგი"),
            new Translation(LanguageCode.KK, "Люксембург"),
            new Translation(LanguageCode.KO, "룩셈부르크"),
            new Translation(LanguageCode.KY, "Люксембург"),
            new Translation(LanguageCode.LT, "Liuksemburgas"),
            new Translation(LanguageCode.LV, "Luksemburga"),
            new Translation(LanguageCode.MK, "Луксембург"),
            new Translation(LanguageCode.MN, "Люксембург"),
            new Translation(LanguageCode.NB, "Luxembourg"),
            new Translation(LanguageCode.NL, "Luxemburg"),
            new Translation(LanguageCode.NN, "Luxembourg"),
            new Translation(LanguageCode.PL, "Luksemburg"),
            new Translation(LanguageCode.PT, "Luxemburgo"),
            new Translation(LanguageCode.RO, "Luxemburg"),
            new Translation(LanguageCode.RU, "Люксембург"),
            new Translation(LanguageCode.SK, "Luxembursko"),
            new Translation(LanguageCode.SL, "Luksemburg"),
            new Translation(LanguageCode.SR, "Луксембург"),
            new Translation(LanguageCode.SV, "Luxemburg"),
            new Translation(LanguageCode.TR, "Lüksemburg"),
            new Translation(LanguageCode.UK, "Люксембург"),
            new Translation(LanguageCode.UZ, "Lyuksemburg"),
            new Translation(LanguageCode.ZH, "卢森堡"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.LU;
        public Alpha3Code Alpha3Code => Alpha3Code.LUX;
        public int NumericCode => 442;
        public string[] TLD => new [] { ".lu" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BE,
            Alpha2Code.FR,
            Alpha2Code.DE,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "352" };
    }
}
