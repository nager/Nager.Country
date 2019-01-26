namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// French Polynesia
	/// </summary>
	public class FrenchPolynesiaInfo : ICountryInfo
	{
		public string CommonName => "French Polynesia";
		public string OfficialName => "French Polynesia";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "بولينزيا الفرنسية"),
			new Translation(LanguageCode.AZ, "Fransa Polineziyası"),
			new Translation(LanguageCode.BE, "Французская Палінезія"),
			new Translation(LanguageCode.BG, "Френска Полинезия"),
			new Translation(LanguageCode.BS, "Francuska Polinezija"),
			new Translation(LanguageCode.CA, "Polinèsia Francesa"),
			new Translation(LanguageCode.CS, "Francouzská Polynésie"),
			new Translation(LanguageCode.DA, "Fransk Polynesien"),
			new Translation(LanguageCode.DE, "Französisch-Polynesien"),
			new Translation(LanguageCode.EL, "Γαλλική Πολυνησία"),
			new Translation(LanguageCode.EN, "French Polynesia"),
			new Translation(LanguageCode.ES, "Polinesia Francesa"),
			new Translation(LanguageCode.ET, "Prantsuse Polüneesia"),
			new Translation(LanguageCode.FA, "پلی‌نزی فرانسه"),
			new Translation(LanguageCode.FI, "Ranskan Polynesia"),
			new Translation(LanguageCode.FR, "Polynésie française"),
			new Translation(LanguageCode.HE, "פולינזיה הצרפתית"),
			new Translation(LanguageCode.HR, "Francuska Polinezija"),
			new Translation(LanguageCode.HU, "Francia Polinézia"),
			new Translation(LanguageCode.HY, "Ֆրանսիական Պոլինեզիա"),
			new Translation(LanguageCode.ID, "Polinesia Perancis"),
			new Translation(LanguageCode.IT, "Polinesia Francese"),
			new Translation(LanguageCode.JA, "フランス領ポリネシア"),
			new Translation(LanguageCode.KA, "საფრანგეთის პოლინეზია"),
			new Translation(LanguageCode.KK, "Француз Полинезиясы"),
			new Translation(LanguageCode.KO, "프랑스 령 폴리네시아의"),
			new Translation(LanguageCode.KY, "Француз Полинезиясы"),
			new Translation(LanguageCode.LT, "Prancūzijos Polinezija"),
			new Translation(LanguageCode.LV, "Francijas Polinēzija"),
			new Translation(LanguageCode.MK, "Француска Полинезија"),
			new Translation(LanguageCode.MN, "Францын Полинез"),
			new Translation(LanguageCode.NB, "Fransk Polynesia"),
			new Translation(LanguageCode.NL, "Frans-Polynesië"),
			new Translation(LanguageCode.NN, "Fransk Polynesia"),
			new Translation(LanguageCode.PL, "Polinezja Francuska"),
			new Translation(LanguageCode.PT, "Polinésia Francesa"),
			new Translation(LanguageCode.RO, "Polinezia Franceză"),
			new Translation(LanguageCode.RU, "Французская Полинезия"),
			new Translation(LanguageCode.SK, "Francúzska Polynézia"),
			new Translation(LanguageCode.SL, "Francoska Polinezija"),
			new Translation(LanguageCode.SR, "Француска Полинезија"),
			new Translation(LanguageCode.SV, "Franska Polynesien"),
			new Translation(LanguageCode.TR, "Fransız Polinezyası"),
			new Translation(LanguageCode.UK, "Французька Полінезія"),
			new Translation(LanguageCode.UZ, "Fransuz Polineziyasi"),
			new Translation(LanguageCode.ZH, "法属玻里尼西亚"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.PF;
		public Alpha3Code Alpha3Code => Alpha3Code.PYF;
		public int NumericCode => 258;
		public string[] TLD => new [] { ".pf" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Polynesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XPF" };
		public string[] CallingCodes => new [] { "689" };
	}
}
