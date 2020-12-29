using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Martin
    /// </summary>
    public class SaintMartinInfo : ICountryInfo
    {
        public string CommonName => "Saint Martin";
        public string OfficialName => "Saint Martin";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "سانت مارتن (الجزء الفرنسي)"),
            new Translation(LanguageCode.AZ, "Sent Martin"),
            new Translation(LanguageCode.BE, "Сен-Мартэн"),
            new Translation(LanguageCode.BG, "Сен Мартен"),
            new Translation(LanguageCode.BS, "Sv. Martin"),
            new Translation(LanguageCode.CA, "Saint-Martin"),
            new Translation(LanguageCode.CS, "Svatý Martin (francouzská část)"),
            new Translation(LanguageCode.DA, "Saint Martin (fransk side)"),
            new Translation(LanguageCode.DE, "Saint-Martin"),
            new Translation(LanguageCode.EL, "Άγιος Μαρτίνος (Γαλλία)"),
            new Translation(LanguageCode.EN, "Saint Martin (French part)"),
            new Translation(LanguageCode.ES, "Saint Martin (francesa)"),
            new Translation(LanguageCode.ET, "Saint Martin"),
            new Translation(LanguageCode.FA, "سنت مارتین"),
            new Translation(LanguageCode.FI, "Saint-Martin"),
            new Translation(LanguageCode.FR, "Saint-Martin (partie française)"),
            new Translation(LanguageCode.HE, "סן מרטן"),
            new Translation(LanguageCode.HR, "Saint Martin"),
            new Translation(LanguageCode.HU, "Szent Márton-sziget (francia rész)"),
            new Translation(LanguageCode.HY, "Սեն Մարտեն"),
            new Translation(LanguageCode.ID, "Saint Martin (French part)"),
            new Translation(LanguageCode.IT, "Saint-Martin"),
            new Translation(LanguageCode.JA, "サン・マルタン（フランス領）"),
            new Translation(LanguageCode.KA, "სენ-მარტენი"),
            new Translation(LanguageCode.KK, "Сен-Мартен"),
            new Translation(LanguageCode.KO, "세인트 마틴 (프랑스어 부분)"),
            new Translation(LanguageCode.KY, "Сент-Мартин"),
            new Translation(LanguageCode.LT, "Sen Martenas"),
            new Translation(LanguageCode.LV, "Senmartēna"),
            new Translation(LanguageCode.MK, "Сент Мартин"),
            new Translation(LanguageCode.MN, "Сент-Мартин"),
            new Translation(LanguageCode.NB, "Saint-Martin"),
            new Translation(LanguageCode.NL, "Sint-Maarten (Frans deel)"),
            new Translation(LanguageCode.NN, "Saint-Martin"),
            new Translation(LanguageCode.PL, "Saint-Martin"),
            new Translation(LanguageCode.PT, "São Martinho"),
            new Translation(LanguageCode.RO, "Sfântul Martin"),
            new Translation(LanguageCode.RU, "Сен-Мартен"),
            new Translation(LanguageCode.SK, "Svätý Martin (fr.)"),
            new Translation(LanguageCode.SL, "Saint Martin"),
            new Translation(LanguageCode.SR, "Свети Мартин (Француска)"),
            new Translation(LanguageCode.SV, "Saint Martin (franska delen)"),
            new Translation(LanguageCode.TR, "Saint Martin"),
            new Translation(LanguageCode.UK, "Сен-Мартен"),
            new Translation(LanguageCode.UZ, "Sent-Martin"),
            new Translation(LanguageCode.ZH, "法属圣马丁"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MF;
        public Alpha3Code Alpha3Code => Alpha3Code.MAF;
        public int NumericCode => 663;
        public string[] TLD => new [] { ".fr", ".gp" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.SX,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "590" };
    }
}
