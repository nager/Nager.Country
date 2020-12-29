using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Latvia
    /// </summary>
    public class LatviaInfo : ICountryInfo
    {
        public string CommonName => "Latvia";
        public string OfficialName => "Republic of Latvia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "لاتفيا"),
            new Translation(LanguageCode.AZ, "Latviya"),
            new Translation(LanguageCode.BE, "Латвія"),
            new Translation(LanguageCode.BG, "Латвия"),
            new Translation(LanguageCode.BS, "Latvija"),
            new Translation(LanguageCode.CA, "Letònia"),
            new Translation(LanguageCode.CS, "Lotyšsko"),
            new Translation(LanguageCode.DA, "Letland"),
            new Translation(LanguageCode.DE, "Lettland"),
            new Translation(LanguageCode.EL, "Λετονία"),
            new Translation(LanguageCode.EN, "Latvia"),
            new Translation(LanguageCode.ES, "Letonia"),
            new Translation(LanguageCode.ET, "Läti"),
            new Translation(LanguageCode.FA, "لتونی"),
            new Translation(LanguageCode.FI, "Latvia"),
            new Translation(LanguageCode.FR, "Lettonie"),
            new Translation(LanguageCode.HE, "לטביה"),
            new Translation(LanguageCode.HR, "Latvija"),
            new Translation(LanguageCode.HU, "Lettország"),
            new Translation(LanguageCode.HY, "Լատվիա"),
            new Translation(LanguageCode.ID, "Latvia"),
            new Translation(LanguageCode.IT, "Lettonia"),
            new Translation(LanguageCode.JA, "ラトビア"),
            new Translation(LanguageCode.KA, "ლატვია"),
            new Translation(LanguageCode.KK, "Латвия"),
            new Translation(LanguageCode.KO, "라트비아"),
            new Translation(LanguageCode.KY, "Латвия"),
            new Translation(LanguageCode.LT, "Latvija"),
            new Translation(LanguageCode.LV, "Latvija"),
            new Translation(LanguageCode.MK, "Латвија"),
            new Translation(LanguageCode.MN, "Латви"),
            new Translation(LanguageCode.NB, "Latvia"),
            new Translation(LanguageCode.NL, "Letland"),
            new Translation(LanguageCode.NN, "Latvia"),
            new Translation(LanguageCode.PL, "Łotwa"),
            new Translation(LanguageCode.PT, "Letônia"),
            new Translation(LanguageCode.RO, "Letonia"),
            new Translation(LanguageCode.RU, "Латвия"),
            new Translation(LanguageCode.SK, "Lotyšsko"),
            new Translation(LanguageCode.SL, "Latvija"),
            new Translation(LanguageCode.SR, "Летонија"),
            new Translation(LanguageCode.SV, "Lettland"),
            new Translation(LanguageCode.TR, "Letonya"),
            new Translation(LanguageCode.UK, "Латвія"),
            new Translation(LanguageCode.UZ, "Latviya"),
            new Translation(LanguageCode.ZH, "拉脱维亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.LV;
        public Alpha3Code Alpha3Code => Alpha3Code.LVA;
        public int NumericCode => 428;
        public string[] TLD => new [] { ".lv" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BY,
            Alpha2Code.EE,
            Alpha2Code.LT,
            Alpha2Code.RU,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "371" };
    }
}
