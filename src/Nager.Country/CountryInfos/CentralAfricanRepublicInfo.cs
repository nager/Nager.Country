using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Central African Republic
    /// </summary>
    public class CentralAfricanRepublicInfo : ICountryInfo
    {
        public string CommonName => "Central African Republic";
        public string OfficialName => "Central African Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "جمهورية أفريقيا الوسطى"),
            new Translation(LanguageCode.AZ, "Mərkəzi Afrika Respublikası"),
            new Translation(LanguageCode.BE, "Цэнтральнаафрыканская Рэспубліка"),
            new Translation(LanguageCode.BG, "Централноафриканска република"),
            new Translation(LanguageCode.BS, "Centralnoafrička Republika"),
            new Translation(LanguageCode.CA, "Centreafricana, República"),
            new Translation(LanguageCode.CS, "Středoafrická republika"),
            new Translation(LanguageCode.DA, "Den Centralafrikanske Republik"),
            new Translation(LanguageCode.DE, "Zentralafrikanische Republik"),
            new Translation(LanguageCode.EL, "Κεντροαφρικανική Δημοκρατίαc"),
            new Translation(LanguageCode.EN, "Central African Republic"),
            new Translation(LanguageCode.ES, "República Centroafricana"),
            new Translation(LanguageCode.ET, "Kesk-Aafrika Vabariik"),
            new Translation(LanguageCode.FA, "جمهوری افریقای مرکزی"),
            new Translation(LanguageCode.FI, "Keski-Afrikan tasavalta"),
            new Translation(LanguageCode.FR, "Centrafricaine, République"),
            new Translation(LanguageCode.HE, "הרפובליקה של מרכז אפריקה"),
            new Translation(LanguageCode.HR, "Srednjoafrička Republika"),
            new Translation(LanguageCode.HU, "Közép-afrikai Köztársaság"),
            new Translation(LanguageCode.HY, "Կենտրոնական Աֆրիկյան Հանրապետություն"),
            new Translation(LanguageCode.ID, "Afrika Tengah"),
            new Translation(LanguageCode.IT, "Repubblica Centrafricana"),
            new Translation(LanguageCode.JA, "中央アフリカ共和国"),
            new Translation(LanguageCode.KA, "ცენტრალური აფრიკის რესპუბლიკა"),
            new Translation(LanguageCode.KK, "Орталық Африка Республикасы"),
            new Translation(LanguageCode.KO, "중앙 아프리카 공화국"),
            new Translation(LanguageCode.KY, "Борбордук Африка Республикасы"),
            new Translation(LanguageCode.LT, "Centrinės Afrikos Respublika"),
            new Translation(LanguageCode.LV, "Centrālāfrikas Republika"),
            new Translation(LanguageCode.MK, "Централноафриканска Република"),
            new Translation(LanguageCode.MN, "Төв Африкийн Бүгд Найрамдах Улс"),
            new Translation(LanguageCode.NB, "Den sentralafrikanske republikk"),
            new Translation(LanguageCode.NL, "Centraal-Afrikaanse Republiek"),
            new Translation(LanguageCode.NN, "Den sentralafrikanske republikken"),
            new Translation(LanguageCode.PL, "Republika Środkowoafrykańska"),
            new Translation(LanguageCode.PT, "República Centro-Africana"),
            new Translation(LanguageCode.RO, "Republica Centrafricană"),
            new Translation(LanguageCode.RU, "ЦАР"),
            new Translation(LanguageCode.SK, "Stredoafrická republika"),
            new Translation(LanguageCode.SL, "Centralnoafriška republika"),
            new Translation(LanguageCode.SR, "Централноафричка Република"),
            new Translation(LanguageCode.SV, "Centralafrikanska republiken"),
            new Translation(LanguageCode.TR, "Orta Afrika Cumhuriyeti"),
            new Translation(LanguageCode.UK, "Центральноафриканська Республіка"),
            new Translation(LanguageCode.UZ, "Markaziy Afrika Respublikasi"),
            new Translation(LanguageCode.ZH, "中非"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CF;
        public Alpha3Code Alpha3Code => Alpha3Code.CAF;
        public int NumericCode => 140;
        public string[] TLD => new [] { ".cf" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CM,
            Alpha2Code.TD,
            Alpha2Code.CD,
            Alpha2Code.CG,
            Alpha2Code.SS,
            Alpha2Code.SD,
        };

        public ICurrency[] Currencies => new [] { new XafCurrency() };
        public string[] CallingCodes => new [] { "236" };
    }
}
