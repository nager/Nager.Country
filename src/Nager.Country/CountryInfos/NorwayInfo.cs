using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Norway
    /// </summary>
    public class NorwayInfo : ICountryInfo
    {
        public string CommonName => "Norway";
        public string OfficialName => "Kingdom of Norway";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "النرويج"),
            new Translation(LanguageCode.AZ, "Norveç"),
            new Translation(LanguageCode.BE, "Нарвегія"),
            new Translation(LanguageCode.BG, "Норвегия"),
            new Translation(LanguageCode.BS, "Norveška"),
            new Translation(LanguageCode.CA, "Noruega"),
            new Translation(LanguageCode.CS, "Norsko"),
            new Translation(LanguageCode.DA, "Norge"),
            new Translation(LanguageCode.DE, "Norwegen"),
            new Translation(LanguageCode.EL, "Νορβηγία"),
            new Translation(LanguageCode.EN, "Norway"),
            new Translation(LanguageCode.ES, "Noruega"),
            new Translation(LanguageCode.ET, "Norra"),
            new Translation(LanguageCode.FA, "نروژ"),
            new Translation(LanguageCode.FI, "Norja"),
            new Translation(LanguageCode.FR, "Norvège"),
            new Translation(LanguageCode.HE, "נורווגיה"),
            new Translation(LanguageCode.HR, "Norveška"),
            new Translation(LanguageCode.HU, "Norvégia"),
            new Translation(LanguageCode.HY, "Նորվեգիա"),
            new Translation(LanguageCode.ID, "Norwegia"),
            new Translation(LanguageCode.IT, "Norvegia"),
            new Translation(LanguageCode.JA, "ノルウェー"),
            new Translation(LanguageCode.KA, "ნორვეგია"),
            new Translation(LanguageCode.KK, "Норвегия"),
            new Translation(LanguageCode.KO, "노르웨이"),
            new Translation(LanguageCode.KY, "Норвегия"),
            new Translation(LanguageCode.LT, "Norvegija"),
            new Translation(LanguageCode.LV, "Norvēģija"),
            new Translation(LanguageCode.MK, "Норвешка"),
            new Translation(LanguageCode.MN, "Норвеги"),
            new Translation(LanguageCode.NB, "Norge"),
            new Translation(LanguageCode.NL, "Noorwegen"),
            new Translation(LanguageCode.NN, "Noreg"),
            new Translation(LanguageCode.PL, "Norwegia"),
            new Translation(LanguageCode.PT, "Noruega"),
            new Translation(LanguageCode.RO, "Norvegia"),
            new Translation(LanguageCode.RU, "Норвегия"),
            new Translation(LanguageCode.SK, "Nórsko"),
            new Translation(LanguageCode.SL, "Norveška"),
            new Translation(LanguageCode.SR, "Норвешка"),
            new Translation(LanguageCode.SV, "Norge"),
            new Translation(LanguageCode.TR, "Norveç"),
            new Translation(LanguageCode.UK, "Норвегія"),
            new Translation(LanguageCode.UZ, "Norvegiya"),
            new Translation(LanguageCode.ZH, "挪威"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.NO;
        public Alpha3Code Alpha3Code => Alpha3Code.NOR;
        public int NumericCode => 578;
        public string[] TLD => new [] { ".no" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.FI,
            Alpha2Code.SE,
            Alpha2Code.RU,
        };

        public ICurrency[] Currencies => new [] { new NokCurrency() };
        public string[] CallingCodes => new [] { "47" };
    }
}
