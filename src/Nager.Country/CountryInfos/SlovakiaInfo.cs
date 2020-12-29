using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Slovakia
    /// </summary>
    public class SlovakiaInfo : ICountryInfo
    {
        public string CommonName => "Slovakia";
        public string OfficialName => "Slovak Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سلوفاكيا"),
            new Translation(LanguageCode.AZ, "Slovakiya"),
            new Translation(LanguageCode.BE, "Славакія"),
            new Translation(LanguageCode.BG, "Словакия"),
            new Translation(LanguageCode.BS, "Slovačka"),
            new Translation(LanguageCode.CA, "Eslovàquia"),
            new Translation(LanguageCode.CS, "Slovensko"),
            new Translation(LanguageCode.DA, "Slovakiet"),
            new Translation(LanguageCode.DE, "Slowakei"),
            new Translation(LanguageCode.EL, "Σλοβακία"),
            new Translation(LanguageCode.EN, "Slovakia"),
            new Translation(LanguageCode.ES, "Eslovaquia"),
            new Translation(LanguageCode.ET, "Slovakkia"),
            new Translation(LanguageCode.FA, "اسلواکی"),
            new Translation(LanguageCode.FI, "Slovakia"),
            new Translation(LanguageCode.FR, "Slovaquie"),
            new Translation(LanguageCode.HE, "סלובקיה"),
            new Translation(LanguageCode.HR, "Slovačka"),
            new Translation(LanguageCode.HU, "Szlovákia"),
            new Translation(LanguageCode.HY, "Սլովակիա"),
            new Translation(LanguageCode.ID, "Slovakia"),
            new Translation(LanguageCode.IT, "Slovacchia"),
            new Translation(LanguageCode.JA, "スロバキア"),
            new Translation(LanguageCode.KA, "სლოვაკეთი"),
            new Translation(LanguageCode.KK, "Словакия"),
            new Translation(LanguageCode.KO, "슬로바키아"),
            new Translation(LanguageCode.KY, "Словакия"),
            new Translation(LanguageCode.LT, "Slovakija"),
            new Translation(LanguageCode.LV, "Slovākija"),
            new Translation(LanguageCode.MK, "Словачка"),
            new Translation(LanguageCode.MN, "Словак"),
            new Translation(LanguageCode.NB, "Slovakia"),
            new Translation(LanguageCode.NL, "Slowakije"),
            new Translation(LanguageCode.NN, "Slovakia"),
            new Translation(LanguageCode.PL, "Słowacja"),
            new Translation(LanguageCode.PT, "Eslováquia"),
            new Translation(LanguageCode.RO, "Slovacia"),
            new Translation(LanguageCode.RU, "Словакия"),
            new Translation(LanguageCode.SK, "Slovensko"),
            new Translation(LanguageCode.SL, "Slovaška"),
            new Translation(LanguageCode.SR, "Словачка"),
            new Translation(LanguageCode.SV, "Slovakien"),
            new Translation(LanguageCode.TR, "Slovakya"),
            new Translation(LanguageCode.UK, "Словаччина"),
            new Translation(LanguageCode.UZ, "Slovakiya"),
            new Translation(LanguageCode.ZH, "斯洛伐克"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SK;
        public Alpha3Code Alpha3Code => Alpha3Code.SVK;
        public int NumericCode => 703;
        public string[] TLD => new [] { ".sk" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.CZ,
            Alpha2Code.HU,
            Alpha2Code.PL,
            Alpha2Code.UA,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "421" };
    }
}
