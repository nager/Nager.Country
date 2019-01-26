namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Thailand
	/// </summary>
	public class ThailandInfo : ICountryInfo
	{
		public string CommonName => "Thailand";
		public string OfficialName => "Kingdom of Thailand";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "تايلاند"),
			new Translation(LanguageCode.AZ, "Tailand"),
			new Translation(LanguageCode.BE, "Тайланд"),
			new Translation(LanguageCode.BG, "Тайланд"),
			new Translation(LanguageCode.BS, "Tajland"),
			new Translation(LanguageCode.CA, "Tailàndia"),
			new Translation(LanguageCode.CS, "Thajsko"),
			new Translation(LanguageCode.DA, "Thailand"),
			new Translation(LanguageCode.DE, "Thailand"),
			new Translation(LanguageCode.EL, "Ταϊλάνδη"),
			new Translation(LanguageCode.EN, "Thailand"),
			new Translation(LanguageCode.ES, "Tailandia"),
			new Translation(LanguageCode.ET, "Tai"),
			new Translation(LanguageCode.FA, "تایلند"),
			new Translation(LanguageCode.FI, "Thaimaa"),
			new Translation(LanguageCode.FR, "Thaïlande"),
			new Translation(LanguageCode.HE, "תאילנד"),
			new Translation(LanguageCode.HR, "Tajland"),
			new Translation(LanguageCode.HU, "Thaiföld"),
			new Translation(LanguageCode.HY, "Թայլանդ"),
			new Translation(LanguageCode.ID, "Thailand"),
			new Translation(LanguageCode.IT, "Thailandia"),
			new Translation(LanguageCode.JA, "タイ"),
			new Translation(LanguageCode.KA, "ტაილანდი"),
			new Translation(LanguageCode.KK, "Тайланд"),
			new Translation(LanguageCode.KO, "태국"),
			new Translation(LanguageCode.KY, "Таиланд"),
			new Translation(LanguageCode.LT, "Tailandas"),
			new Translation(LanguageCode.LV, "Taizeme"),
			new Translation(LanguageCode.MK, "Тајланд"),
			new Translation(LanguageCode.MN, "Тайланд"),
			new Translation(LanguageCode.NB, "Thailand"),
			new Translation(LanguageCode.NL, "Thailand"),
			new Translation(LanguageCode.NN, "Thailand"),
			new Translation(LanguageCode.PL, "Tajlandia"),
			new Translation(LanguageCode.PT, "Tailândia"),
			new Translation(LanguageCode.RO, "Thailanda"),
			new Translation(LanguageCode.RU, "Таиланд"),
			new Translation(LanguageCode.SK, "Thajsko"),
			new Translation(LanguageCode.SL, "Tajska"),
			new Translation(LanguageCode.SR, "Тајланд"),
			new Translation(LanguageCode.SV, "Thailand"),
			new Translation(LanguageCode.TR, "Tayland"),
			new Translation(LanguageCode.UK, "Таїланд"),
			new Translation(LanguageCode.UZ, "Tailand"),
			new Translation(LanguageCode.ZH, "泰国"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.TH;
		public Alpha3Code Alpha3Code => Alpha3Code.THA;
		public int NumericCode => 764;
		public string[] TLD => new [] { ".th", ".ไทย" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.SouthEasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.MM,
			Alpha2Code.KH,
			Alpha2Code.LA,
			Alpha2Code.MY,
		};

		public string[] Currencies => new [] { "THB" };
		public string[] CallingCodes => new [] { "66" };
	}
}
