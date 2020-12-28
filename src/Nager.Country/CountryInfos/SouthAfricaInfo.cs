using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// South Africa
    /// </summary>
    public class SouthAfricaInfo : ICountryInfo
    {
        public string CommonName => "South Africa";
        public string OfficialName => "Republic of South Africa";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جنوب أفريقيا"),
            new Translation(LanguageCode.AZ, "Cənub Afrika"),
            new Translation(LanguageCode.BE, "Паўднёваафрыканская Рэспубліка"),
            new Translation(LanguageCode.BG, "Южна Африка"),
            new Translation(LanguageCode.BS, "Južnoafrička Republika"),
            new Translation(LanguageCode.CA, "Sud-àfrica"),
            new Translation(LanguageCode.CS, "Jihoafrická republika"),
            new Translation(LanguageCode.DA, "Sydafrika"),
            new Translation(LanguageCode.DE, "Südafrika"),
            new Translation(LanguageCode.EL, "Νότια Αφρική"),
            new Translation(LanguageCode.EN, "South Africa"),
            new Translation(LanguageCode.ES, "Sudáfrica"),
            new Translation(LanguageCode.ET, "Lõuna-Aafrika Vabariik"),
            new Translation(LanguageCode.FA, "افریقای جنوبی"),
            new Translation(LanguageCode.FI, "Etelä-Afrikka"),
            new Translation(LanguageCode.FR, "Afrique du Sud"),
            new Translation(LanguageCode.HE, "דרום אפריקה"),
            new Translation(LanguageCode.HR, "Južnoafrička Republika"),
            new Translation(LanguageCode.HU, "Dél-Afrika"),
            new Translation(LanguageCode.HY, "Հարավաֆրիկյան Հանրապետություն"),
            new Translation(LanguageCode.ID, "Afrika Selatan"),
            new Translation(LanguageCode.IT, "Sudafrica"),
            new Translation(LanguageCode.JA, "南アフリカ"),
            new Translation(LanguageCode.KA, "სამხრეთ აფრიკის რესპუბლიკა"),
            new Translation(LanguageCode.KK, "Оңтүстік Африка Республикасы"),
            new Translation(LanguageCode.KO, "남아프리카"),
            new Translation(LanguageCode.KY, "Түштүк Африка Республикасы"),
            new Translation(LanguageCode.LT, "Pietų Afrika"),
            new Translation(LanguageCode.LV, "Dienvidāfrikas Republika"),
            new Translation(LanguageCode.MK, "Јужноафриканска Република"),
            new Translation(LanguageCode.MN, "Өмнөд Африк тив"),
            new Translation(LanguageCode.NB, "Sør-Afrika"),
            new Translation(LanguageCode.NL, "Zuid-Afrika"),
            new Translation(LanguageCode.NN, "Sør-Afrika"),
            new Translation(LanguageCode.PL, "Południowa Afryka"),
            new Translation(LanguageCode.PT, "África do Sul"),
            new Translation(LanguageCode.RO, "Africa de Sud"),
            new Translation(LanguageCode.RU, "ЮАР"),
            new Translation(LanguageCode.SK, "Južná Afrika"),
            new Translation(LanguageCode.SL, "Južnoafriška republika"),
            new Translation(LanguageCode.SR, "Јужноафричка Република"),
            new Translation(LanguageCode.SV, "Sydafrika"),
            new Translation(LanguageCode.TR, "Güney Afrika"),
            new Translation(LanguageCode.UK, "ПАР"),
            new Translation(LanguageCode.UZ, "Janubiy Afrika Respublikasi"),
            new Translation(LanguageCode.ZH, "南非"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.ZA;
        public Alpha3Code Alpha3Code => Alpha3Code.ZAF;
        public int NumericCode => 710;
        public string[] TLD => new [] { ".za" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BW,
            Alpha2Code.LS,
            Alpha2Code.MZ,
            Alpha2Code.NA,
            Alpha2Code.SZ,
            Alpha2Code.ZW,
        };

        public ICurrency[] Currencies => new [] { new ZarCurrency() };
        public string[] CallingCodes => new [] { "27" };
    }
}
