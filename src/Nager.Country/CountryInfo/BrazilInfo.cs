namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Brazil
	/// </summary>
	public class BrazilInfo : ICountryInfo
	{
		public string CommonName => "Brazil";
		public string OfficialName => "Federative Republic of Brazil";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "البرازيل"),
			new Translation(LanguageCode.AZ, "Braziliya"),
			new Translation(LanguageCode.BE, "Бразілія"),
			new Translation(LanguageCode.BG, "Бразилия"),
			new Translation(LanguageCode.BS, "Brazil"),
			new Translation(LanguageCode.CA, "Brasil"),
			new Translation(LanguageCode.CS, "Brazílie"),
			new Translation(LanguageCode.DA, "Brasilien"),
			new Translation(LanguageCode.DE, "Brasilien"),
			new Translation(LanguageCode.EL, "Βραζιλία"),
			new Translation(LanguageCode.EN, "Brazil"),
			new Translation(LanguageCode.ES, "Brasil"),
			new Translation(LanguageCode.ET, "Brasiilia"),
			new Translation(LanguageCode.FA, "برزیل"),
			new Translation(LanguageCode.FI, "Brasilia"),
			new Translation(LanguageCode.FR, "Brésil"),
			new Translation(LanguageCode.HE, "ברזיל"),
			new Translation(LanguageCode.HR, "Brazil"),
			new Translation(LanguageCode.HU, "Brazília"),
			new Translation(LanguageCode.HY, "Բրազիլիա"),
			new Translation(LanguageCode.ID, "Brasil"),
			new Translation(LanguageCode.IT, "Brasile"),
			new Translation(LanguageCode.JA, "ブラジル"),
			new Translation(LanguageCode.KA, "ბრაზილია"),
			new Translation(LanguageCode.KK, "Бразилия"),
			new Translation(LanguageCode.KO, "브라질"),
			new Translation(LanguageCode.KY, "Бразилия"),
			new Translation(LanguageCode.LT, "Brazilija"),
			new Translation(LanguageCode.LV, "Brazīlija"),
			new Translation(LanguageCode.MK, "Бразил"),
			new Translation(LanguageCode.MN, "Бразил"),
			new Translation(LanguageCode.NB, "Brasil"),
			new Translation(LanguageCode.NL, "Brazilië"),
			new Translation(LanguageCode.NN, "Brasil"),
			new Translation(LanguageCode.PL, "Brazylia"),
			new Translation(LanguageCode.PT, "Brasil"),
			new Translation(LanguageCode.RO, "Brazilia"),
			new Translation(LanguageCode.RU, "Бразилия"),
			new Translation(LanguageCode.SK, "Brazília"),
			new Translation(LanguageCode.SL, "Brazilija"),
			new Translation(LanguageCode.SR, "Бразил"),
			new Translation(LanguageCode.SV, "Brasilien"),
			new Translation(LanguageCode.TR, "Brezilya"),
			new Translation(LanguageCode.UK, "Бразилія"),
			new Translation(LanguageCode.UZ, "Braziliya"),
			new Translation(LanguageCode.ZH, "巴西"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.BR;
		public Alpha3Code Alpha3Code => Alpha3Code.BRA;
		public int NumericCode => 076;
		public string[] TLD => new [] { ".br" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AR,
			Alpha2Code.BO,
			Alpha2Code.CO,
			Alpha2Code.GF,
			Alpha2Code.GY,
			Alpha2Code.PY,
			Alpha2Code.PE,
			Alpha2Code.SR,
			Alpha2Code.UY,
			Alpha2Code.VE,
		};

		public string[] Currencies => new [] { "BRL" };
		public string[] CallingCodes => new [] { "55" };
	}
}
