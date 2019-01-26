namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Vanuatu
	/// </summary>
	public class VanuatuInfo : ICountryInfo
	{
		public string CommonName => "Vanuatu";
		public string OfficialName => "Republic of Vanuatu";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "فانواتو"),
			new Translation(LanguageCode.AZ, "Vanuatu"),
			new Translation(LanguageCode.BE, "Вануату"),
			new Translation(LanguageCode.BG, "Вануату"),
			new Translation(LanguageCode.BS, "Vanuatu"),
			new Translation(LanguageCode.CA, "Vanuatu"),
			new Translation(LanguageCode.CS, "Vanuatu"),
			new Translation(LanguageCode.DA, "Vanuatu"),
			new Translation(LanguageCode.DE, "Vanuatu"),
			new Translation(LanguageCode.EL, "Βανουάτου"),
			new Translation(LanguageCode.EN, "Vanuatu"),
			new Translation(LanguageCode.ES, "Vanuatu"),
			new Translation(LanguageCode.ET, "Vanuatu"),
			new Translation(LanguageCode.FA, "وانواتو"),
			new Translation(LanguageCode.FI, "Vanuatu"),
			new Translation(LanguageCode.FR, "Vanuatu"),
			new Translation(LanguageCode.HE, "ונואטו"),
			new Translation(LanguageCode.HR, "Vanuatu"),
			new Translation(LanguageCode.HU, "Vanuatu"),
			new Translation(LanguageCode.HY, "Վանուատու"),
			new Translation(LanguageCode.ID, "Vanuatu"),
			new Translation(LanguageCode.IT, "Vanuatu"),
			new Translation(LanguageCode.JA, "バヌアツ"),
			new Translation(LanguageCode.KA, "ვანუატუ"),
			new Translation(LanguageCode.KK, "Вануату"),
			new Translation(LanguageCode.KO, "바누아투"),
			new Translation(LanguageCode.KY, "Вануату"),
			new Translation(LanguageCode.LT, "Vanuatu"),
			new Translation(LanguageCode.LV, "Vanuatu"),
			new Translation(LanguageCode.MK, "Вануату"),
			new Translation(LanguageCode.MN, "Вануату"),
			new Translation(LanguageCode.NB, "Vanuatu"),
			new Translation(LanguageCode.NL, "Vanuatu"),
			new Translation(LanguageCode.NN, "Vanuatu"),
			new Translation(LanguageCode.PL, "Vanuatu"),
			new Translation(LanguageCode.PT, "Vanuatu"),
			new Translation(LanguageCode.RO, "Vanuatu"),
			new Translation(LanguageCode.RU, "Вануату"),
			new Translation(LanguageCode.SK, "Vanuatu"),
			new Translation(LanguageCode.SL, "Vanuatu"),
			new Translation(LanguageCode.SR, "Вануату"),
			new Translation(LanguageCode.SV, "Vanuatu"),
			new Translation(LanguageCode.TR, "Vanuatu"),
			new Translation(LanguageCode.UK, "Вануату"),
			new Translation(LanguageCode.UZ, "Vanuatu"),
			new Translation(LanguageCode.ZH, "瓦努阿图"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.VU;
		public Alpha3Code Alpha3Code => Alpha3Code.VUT;
		public int NumericCode => 548;
		public string[] TLD => new [] { ".vu" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Melanesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "VUV" };
		public string[] CallingCodes => new [] { "678" };
	}
}
