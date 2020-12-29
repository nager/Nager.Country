using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Nigeria
    /// </summary>
    public class NigeriaInfo : ICountryInfo
    {
        public string CommonName => "Nigeria";
        public string OfficialName => "Federal Republic of Nigeria";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "نيجيريا"),
            new Translation(LanguageCode.AZ, "Nigeriya"),
            new Translation(LanguageCode.BE, "Нігерыя"),
            new Translation(LanguageCode.BG, "Нигерия"),
            new Translation(LanguageCode.BS, "Nigerija"),
            new Translation(LanguageCode.CA, "Nigèria"),
            new Translation(LanguageCode.CS, "Nigérie"),
            new Translation(LanguageCode.DA, "Nigeria"),
            new Translation(LanguageCode.DE, "Nigeria"),
            new Translation(LanguageCode.EL, "Νιγηρία"),
            new Translation(LanguageCode.EN, "Nigeria"),
            new Translation(LanguageCode.ES, "Nigeria"),
            new Translation(LanguageCode.ET, "Nigeeria"),
            new Translation(LanguageCode.FA, "نیجریه"),
            new Translation(LanguageCode.FI, "Nigeria"),
            new Translation(LanguageCode.FR, "Nigéria"),
            new Translation(LanguageCode.HE, "ניגריה"),
            new Translation(LanguageCode.HR, "Nigerija"),
            new Translation(LanguageCode.HU, "Nigéria"),
            new Translation(LanguageCode.HY, "Նիգերիա"),
            new Translation(LanguageCode.ID, "Nigeria"),
            new Translation(LanguageCode.IT, "Nigeria"),
            new Translation(LanguageCode.JA, "ナイジェリア"),
            new Translation(LanguageCode.KA, "ნიგერია"),
            new Translation(LanguageCode.KK, "Нигерия"),
            new Translation(LanguageCode.KO, "나이지리아"),
            new Translation(LanguageCode.KY, "Нигерия"),
            new Translation(LanguageCode.LT, "Nigerija"),
            new Translation(LanguageCode.LV, "Nigērija"),
            new Translation(LanguageCode.MK, "Нигерија"),
            new Translation(LanguageCode.MN, "Нигери"),
            new Translation(LanguageCode.NB, "Nigeria"),
            new Translation(LanguageCode.NL, "Nigeria"),
            new Translation(LanguageCode.NN, "Nigeria"),
            new Translation(LanguageCode.PL, "Nigeria"),
            new Translation(LanguageCode.PT, "Nigéria"),
            new Translation(LanguageCode.RO, "Nigeria"),
            new Translation(LanguageCode.RU, "Нигерия"),
            new Translation(LanguageCode.SK, "Nigéria"),
            new Translation(LanguageCode.SL, "Nigerija"),
            new Translation(LanguageCode.SR, "Нигерија"),
            new Translation(LanguageCode.SV, "Nigeria"),
            new Translation(LanguageCode.TR, "Nijerya"),
            new Translation(LanguageCode.UK, "Нігерія"),
            new Translation(LanguageCode.UZ, "Nigeriya"),
            new Translation(LanguageCode.ZH, "奈及利亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.NG;
        public Alpha3Code Alpha3Code => Alpha3Code.NGA;
        public int NumericCode => 566;
        public string[] TLD => new [] { ".ng" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BJ,
            Alpha2Code.CM,
            Alpha2Code.TD,
            Alpha2Code.NE,
        };

        public ICurrency[] Currencies => new [] { new NgnCurrency() };
        public string[] CallingCodes => new [] { "234" };
    }
}
