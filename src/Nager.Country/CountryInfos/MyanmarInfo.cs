namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Myanmar
    /// </summary>
    public class MyanmarInfo : ICountryInfo
    {
        public string CommonName => "Myanmar";
        public string OfficialName => "Republic of the Union of Myanmar";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "بورما"),
            new Translation(LanguageCode.AZ, "Myanma"),
            new Translation(LanguageCode.BE, "М’янма (Бірма)"),
            new Translation(LanguageCode.BG, "Мианмар (Бирма)"),
            new Translation(LanguageCode.BS, "Mijanmar"),
            new Translation(LanguageCode.CA, "Myanmar"),
            new Translation(LanguageCode.CS, "Myanmar"),
            new Translation(LanguageCode.DA, "Myanmar (Burma)"),
            new Translation(LanguageCode.DE, "Myanmar"),
            new Translation(LanguageCode.EL, "Μιανμάρ"),
            new Translation(LanguageCode.EN, "Myanmar"),
            new Translation(LanguageCode.ES, "Myanmar"),
            new Translation(LanguageCode.ET, "Myanmar"),
            new Translation(LanguageCode.FA, "میانمار (برمه)"),
            new Translation(LanguageCode.FI, "Myanmar"),
            new Translation(LanguageCode.FR, "Myanmar"),
            new Translation(LanguageCode.HE, "מיאנמר (בורמה)"),
            new Translation(LanguageCode.HR, "Mjanmar (Burma)"),
            new Translation(LanguageCode.HU, "Mianmar"),
            new Translation(LanguageCode.HY, "Մյանմա (Բիրմա)"),
            new Translation(LanguageCode.ID, "Myanmar"),
            new Translation(LanguageCode.IT, "Birmania  Myanmar"),
            new Translation(LanguageCode.JA, "ミャンマー"),
            new Translation(LanguageCode.KA, "მიანმარი (ბირმა)"),
            new Translation(LanguageCode.KK, "Мьянма (Бирма)"),
            new Translation(LanguageCode.KO, "미얀마"),
            new Translation(LanguageCode.KY, "Мьянма (Бирма)"),
            new Translation(LanguageCode.LT, "Mianmaras (Birma)"),
            new Translation(LanguageCode.LV, "Mjanma (Birma)"),
            new Translation(LanguageCode.MK, "Мјанмар (Бурма)"),
            new Translation(LanguageCode.MN, "Мьянмар (Бурма)"),
            new Translation(LanguageCode.NB, "Burma"),
            new Translation(LanguageCode.NL, "Myanmar"),
            new Translation(LanguageCode.NN, "Burma"),
            new Translation(LanguageCode.PL, "Mjanma"),
            new Translation(LanguageCode.PT, "Mianmar (Birmânia)"),
            new Translation(LanguageCode.RO, "Myanmar"),
            new Translation(LanguageCode.RU, "Мьянма"),
            new Translation(LanguageCode.SK, "Mjanmarsko"),
            new Translation(LanguageCode.SL, "Mjanmar (Burma)"),
            new Translation(LanguageCode.SR, "Мијанмар (Бурма)"),
            new Translation(LanguageCode.SV, "Burma"),
            new Translation(LanguageCode.TR, "Myanmar (Burma)"),
            new Translation(LanguageCode.UK, "М'янма"),
            new Translation(LanguageCode.UZ, "Myanma (Birma)"),
            new Translation(LanguageCode.ZH, "缅甸"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.MM;
        public Alpha3Code Alpha3Code => Alpha3Code.MMR;
        public int NumericCode => 104;
        public string[] TLD => new [] { ".mm" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.BD,
            Alpha2Code.CN,
            Alpha2Code.IN,
            Alpha2Code.LA,
            Alpha2Code.TH,
        };

        public string[] Currencies => new [] { "MMK" };
        public string[] CallingCodes => new [] { "95" };
    }
}
