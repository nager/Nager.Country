using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// French Southern and Antarctic Lands
    /// </summary>
    public class FrenchSouthernAndAntarcticLandsInfo : ICountryInfo
    {
        public string CommonName => "French Southern and Antarctic Lands";
        public string OfficialName => "Territory of the French Southern and Antarctic Lands";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "أراض فرنسية جنوبية وأنتارتيكية"),
            new Translation(LanguageCode.AZ, "Fransanın Cənub Əraziləri"),
            new Translation(LanguageCode.BE, "Французскія Паўднёвыя тэрыторыі"),
            new Translation(LanguageCode.BG, "Френски южни територии"),
            new Translation(LanguageCode.BS, "Francuske Južne Teritorije"),
            new Translation(LanguageCode.CA, "Territoris Francesos del Sud"),
            new Translation(LanguageCode.CS, "Francouzská jižní a antarktická území"),
            new Translation(LanguageCode.DA, "Franske Sydterritorier"),
            new Translation(LanguageCode.DE, "Französische Süd- und Antarktisgebiete"),
            new Translation(LanguageCode.EL, "Γαλλικά Νότια και Ανταρκτικά Εδάφη"),
            new Translation(LanguageCode.EN, "French Southern Territories"),
            new Translation(LanguageCode.ES, "Tierras Australes Francesas"),
            new Translation(LanguageCode.ET, "Prantsuse Lõunaalad"),
            new Translation(LanguageCode.FA, "قلمروهای جنوبی فرانسه"),
            new Translation(LanguageCode.FI, "Ranskan eteläiset alueet"),
            new Translation(LanguageCode.FR, "Terres australes françaises"),
            new Translation(LanguageCode.HE, "הטריטוריות הדרומיות של צרפת"),
            new Translation(LanguageCode.HR, "Francuski južni i antarktički teritoriji"),
            new Translation(LanguageCode.HU, "Francia déli területek"),
            new Translation(LanguageCode.HY, "Ֆրանսիական Հարավային Տարածքներ"),
            new Translation(LanguageCode.ID, "Antartika Perancis"),
            new Translation(LanguageCode.IT, "Territori Francesi del Sud"),
            new Translation(LanguageCode.JA, "フランス領南方・南極地域"),
            new Translation(LanguageCode.KA, "ფრანგული სამხრეთის ტერიტორიები"),
            new Translation(LanguageCode.KK, "Францияның оңтүстік аймақтары"),
            new Translation(LanguageCode.KO, "프랑스 남부 지역"),
            new Translation(LanguageCode.KY, "Франциянын Түштүктөгү аймактары"),
            new Translation(LanguageCode.LT, "Prancūzijos Pietų sritys"),
            new Translation(LanguageCode.LV, "Francijas Dienvidjūru teritorija"),
            new Translation(LanguageCode.MK, "Француски Јужни Територии"),
            new Translation(LanguageCode.MN, "Францын өмнөд газар нутаг"),
            new Translation(LanguageCode.NB, "Søre franske territorier"),
            new Translation(LanguageCode.NL, "Franse Zuidelijke Gebieden"),
            new Translation(LanguageCode.NN, "Søre franske territorier"),
            new Translation(LanguageCode.PL, "Francuskie Terytoria Południowe i Antarktyczne"),
            new Translation(LanguageCode.PT, "Territórios Franceses do Sul"),
            new Translation(LanguageCode.RO, "Teritoriile Australe și Antarctice Franceze"),
            new Translation(LanguageCode.RU, "Французские Южные и Антарктические Территории"),
            new Translation(LanguageCode.SK, "Francúzske južné a antarktické územia"),
            new Translation(LanguageCode.SL, "Francosko južno ozemlje"),
            new Translation(LanguageCode.SR, "Француске Јужне Територије"),
            new Translation(LanguageCode.SV, "Franska södra territorierna"),
            new Translation(LanguageCode.TR, "Fransız Güney Toprakları"),
            new Translation(LanguageCode.UK, "Французькі Південні і Антарктичні Території"),
            new Translation(LanguageCode.UZ, "Fransuz Janubiy hududlari"),
            new Translation(LanguageCode.ZH, "法属南部领地"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TF;
        public Alpha3Code Alpha3Code => Alpha3Code.ATF;
        public int NumericCode => 260;
        public string[] TLD => new [] { ".tf" };

        public Region Region => Region.Antarctic;
        public SubRegion SubRegion => SubRegion.None;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new string[0];
    }
}
