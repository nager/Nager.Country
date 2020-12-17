namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// French Guiana
    /// </summary>
    public class FrenchGuianaInfo : ICountryInfo
    {
        public string CommonName => "French Guiana";
        public string OfficialName => "Guiana";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "غويانا الفرنسية"),
            new Translation(LanguageCode.AZ, "Fransa Qvianası"),
            new Translation(LanguageCode.BE, "Французская Гвіяна"),
            new Translation(LanguageCode.BG, "Френска Гвиана"),
            new Translation(LanguageCode.BS, "Francuska Gvajana"),
            new Translation(LanguageCode.CA, "Guaiana Francesa"),
            new Translation(LanguageCode.CS, "Francouzská Guyana"),
            new Translation(LanguageCode.DA, "Fransk Guiana"),
            new Translation(LanguageCode.DE, "Französisch-Guayana"),
            new Translation(LanguageCode.EL, "Γαλλική Γουιάνα"),
            new Translation(LanguageCode.EN, "French Guiana"),
            new Translation(LanguageCode.ES, "Guayana Francesa"),
            new Translation(LanguageCode.ET, "Prantsuse Guajaana"),
            new Translation(LanguageCode.FA, "گویان فرانسه"),
            new Translation(LanguageCode.FI, "Ranskan Guayana"),
            new Translation(LanguageCode.FR, "Guyane française"),
            new Translation(LanguageCode.HE, "גיאנה הצרפתית"),
            new Translation(LanguageCode.HR, "Francuska Gijana"),
            new Translation(LanguageCode.HU, "Francia Guyana"),
            new Translation(LanguageCode.HY, "Ֆրանսիական Գվիանա"),
            new Translation(LanguageCode.ID, "Guyana Perancis"),
            new Translation(LanguageCode.IT, "Guyana Francese"),
            new Translation(LanguageCode.JA, "フランス領ギアナ"),
            new Translation(LanguageCode.KA, "საფრანგეთის გვიანა"),
            new Translation(LanguageCode.KK, "Француз Гвианасы"),
            new Translation(LanguageCode.KO, "프랑스 령 기아나"),
            new Translation(LanguageCode.KY, "Гвиана (Франция)"),
            new Translation(LanguageCode.LT, "Prancūzijos Gviana"),
            new Translation(LanguageCode.LV, "Francijas Gviāna"),
            new Translation(LanguageCode.MK, "Француска Гвајана"),
            new Translation(LanguageCode.MN, "Францын Гайана"),
            new Translation(LanguageCode.NB, "Fransk Guyana"),
            new Translation(LanguageCode.NL, "Frans-Guyana"),
            new Translation(LanguageCode.NN, "Fransk Guyana"),
            new Translation(LanguageCode.PL, "Gujana Francuska"),
            new Translation(LanguageCode.PT, "Guiana Francesa"),
            new Translation(LanguageCode.RO, "Guyana Franceză"),
            new Translation(LanguageCode.RU, "Гвиана"),
            new Translation(LanguageCode.SK, "Francúzska Guayana"),
            new Translation(LanguageCode.SL, "Francoska Gvajana"),
            new Translation(LanguageCode.SR, "Француска Гвајана"),
            new Translation(LanguageCode.SV, "Franska Guyana"),
            new Translation(LanguageCode.TR, "Fransız Guyanası"),
            new Translation(LanguageCode.UK, "Гвіана"),
            new Translation(LanguageCode.UZ, "Fransuz Gvianasi"),
            new Translation(LanguageCode.ZH, "法属圭亚那"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GF;
        public Alpha3Code Alpha3Code => Alpha3Code.GUF;
        public int NumericCode => 254;
        public string[] TLD => new [] { ".gf" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BR,
            Alpha2Code.SR,
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "594" };
    }
}
