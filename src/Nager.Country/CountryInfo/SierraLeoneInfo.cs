namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Sierra Leone
	/// </summary>
	public class SierraLeoneInfo : ICountryInfo
	{
		public string CommonName => "Sierra Leone";
		public string OfficialName => "Republic of Sierra Leone";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "سيراليون"),
			new Translation(LanguageCode.AZ, "Syerra-Leone"),
			new Translation(LanguageCode.BE, "Сьера-Леонэ"),
			new Translation(LanguageCode.BG, "Сиера Леоне"),
			new Translation(LanguageCode.BS, "Sijera Leone"),
			new Translation(LanguageCode.CA, "Sierra Leone"),
			new Translation(LanguageCode.CS, "Sierra Leone"),
			new Translation(LanguageCode.DA, "Sierra Leone"),
			new Translation(LanguageCode.DE, "Sierra Leone"),
			new Translation(LanguageCode.EL, "Σιέρα Λεόνε"),
			new Translation(LanguageCode.EN, "Sierra Leone"),
			new Translation(LanguageCode.ES, "Sierra Leona"),
			new Translation(LanguageCode.ET, "Sierra Leone"),
			new Translation(LanguageCode.FA, "سیرالئون"),
			new Translation(LanguageCode.FI, "Sierra Leone"),
			new Translation(LanguageCode.FR, "Sierra Leone"),
			new Translation(LanguageCode.HE, "סיירה לאונה"),
			new Translation(LanguageCode.HR, "Sijera Leone"),
			new Translation(LanguageCode.HU, "Sierra Leone"),
			new Translation(LanguageCode.HY, "Սիեռա Լեոնե"),
			new Translation(LanguageCode.ID, "Sierra Leone"),
			new Translation(LanguageCode.IT, "Sierra Leone"),
			new Translation(LanguageCode.JA, "シエラレオネ"),
			new Translation(LanguageCode.KA, "სიერა-ლეონე"),
			new Translation(LanguageCode.KK, "Сьерра-Леоне"),
			new Translation(LanguageCode.KO, "시에라 리온"),
			new Translation(LanguageCode.KY, "Сьерра-Леоне"),
			new Translation(LanguageCode.LT, "Siera Leonė"),
			new Translation(LanguageCode.LV, "Sjerraleone"),
			new Translation(LanguageCode.MK, "Сиера Леоне"),
			new Translation(LanguageCode.MN, "Сьерра-Леоне"),
			new Translation(LanguageCode.NB, "Sierra Leone"),
			new Translation(LanguageCode.NL, "Sierra Leone"),
			new Translation(LanguageCode.NN, "Sierra Leone"),
			new Translation(LanguageCode.PL, "Sierra Leone"),
			new Translation(LanguageCode.PT, "Serra Leoa"),
			new Translation(LanguageCode.RO, "Sierra Leone"),
			new Translation(LanguageCode.RU, "Сьерра-Леоне"),
			new Translation(LanguageCode.SK, "Sierra Leone"),
			new Translation(LanguageCode.SL, "Sierra Leone"),
			new Translation(LanguageCode.SR, "Сијера Леоне"),
			new Translation(LanguageCode.SV, "Sierra Leone"),
			new Translation(LanguageCode.TR, "Sierra Leone"),
			new Translation(LanguageCode.UK, "Сьєрра-Леоне"),
			new Translation(LanguageCode.UZ, "Syerra-Leone"),
			new Translation(LanguageCode.ZH, "塞拉利昂"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.SL;
		public Alpha3Code Alpha3Code => Alpha3Code.SLE;
		public int NumericCode => 694;
		public string[] TLD => new [] { ".sl" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.GN,
			Alpha2Code.LR,
		};

		public string[] Currencies => new [] { "SLL" };
		public string[] CallingCodes => new [] { "232" };
	}
}
