using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Estonia
    /// </summary>
    public class EstoniaInfo : ICountryInfo
    {
        public string CommonName => "Estonia";
        public string OfficialName => "Republic of Estonia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "إستونيا"),
            new Translation(LanguageCode.AZ, "Estoniya"),
            new Translation(LanguageCode.BE, "Эстонія"),
            new Translation(LanguageCode.BG, "Естония"),
            new Translation(LanguageCode.BS, "Estonija"),
            new Translation(LanguageCode.CA, "Estònia"),
            new Translation(LanguageCode.CS, "Estonsko"),
            new Translation(LanguageCode.DA, "Estland"),
            new Translation(LanguageCode.DE, "Estland"),
            new Translation(LanguageCode.EL, "Εσθονία"),
            new Translation(LanguageCode.EN, "Estonia"),
            new Translation(LanguageCode.ES, "Estonia"),
            new Translation(LanguageCode.ET, "Eesti"),
            new Translation(LanguageCode.FA, "استونی"),
            new Translation(LanguageCode.FI, "Viro"),
            new Translation(LanguageCode.FR, "Estonie"),
            new Translation(LanguageCode.HE, "אסטוניה"),
            new Translation(LanguageCode.HR, "Estonija"),
            new Translation(LanguageCode.HU, "Észtország"),
            new Translation(LanguageCode.HY, "Էստոնիա"),
            new Translation(LanguageCode.ID, "Estonia"),
            new Translation(LanguageCode.IT, "Estonia"),
            new Translation(LanguageCode.JA, "エストニア"),
            new Translation(LanguageCode.KA, "ესტონეთი"),
            new Translation(LanguageCode.KK, "Эстония"),
            new Translation(LanguageCode.KO, "에스토니아"),
            new Translation(LanguageCode.KY, "Эстония"),
            new Translation(LanguageCode.LT, "Estija"),
            new Translation(LanguageCode.LV, "Igaunija"),
            new Translation(LanguageCode.MK, "Естонија"),
            new Translation(LanguageCode.MN, "Эстони"),
            new Translation(LanguageCode.NB, "Estland"),
            new Translation(LanguageCode.NL, "Estland"),
            new Translation(LanguageCode.NN, "Estland"),
            new Translation(LanguageCode.PL, "Estonia"),
            new Translation(LanguageCode.PT, "Estônia"),
            new Translation(LanguageCode.RO, "Estonia"),
            new Translation(LanguageCode.RU, "Эстония"),
            new Translation(LanguageCode.SK, "Estónsko"),
            new Translation(LanguageCode.SL, "Estonija"),
            new Translation(LanguageCode.SR, "Естонија"),
            new Translation(LanguageCode.SV, "Estland"),
            new Translation(LanguageCode.TR, "Estonya"),
            new Translation(LanguageCode.UK, "Естонія"),
            new Translation(LanguageCode.UZ, "Estoniya"),
            new Translation(LanguageCode.ZH, "爱沙尼亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.EE;
        public Alpha3Code Alpha3Code => Alpha3Code.EST;
        public int NumericCode => 233;
        public string[] TLD => new [] { ".ee" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.LV,
            Alpha2Code.RU,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "372" };
    }
}
