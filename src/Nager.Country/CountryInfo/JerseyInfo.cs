namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Jersey
	/// </summary>
	public class JerseyInfo : ICountryInfo
	{
		public string CommonName => "Jersey";
		public string OfficialName => "Bailiwick of Jersey";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "جيرزي"),
			new Translation(LanguageCode.AZ, "Cersi"),
			new Translation(LanguageCode.BE, "Джэрсі"),
			new Translation(LanguageCode.BG, "Джърси"),
			new Translation(LanguageCode.BS, "Džerzi"),
			new Translation(LanguageCode.CA, "Jersey"),
			new Translation(LanguageCode.CS, "Jersey"),
			new Translation(LanguageCode.DA, "Jersey"),
			new Translation(LanguageCode.DE, "Jersey"),
			new Translation(LanguageCode.EL, "Βαϊλάτο του Τζέρσεϊ"),
			new Translation(LanguageCode.EN, "Jersey"),
			new Translation(LanguageCode.ES, "Jersey"),
			new Translation(LanguageCode.ET, "Jersey"),
			new Translation(LanguageCode.FA, "جرزی"),
			new Translation(LanguageCode.FI, "Jersey"),
			new Translation(LanguageCode.FR, "Jersey"),
			new Translation(LanguageCode.HE, "ג׳רסי"),
			new Translation(LanguageCode.HR, "Jersey"),
			new Translation(LanguageCode.HU, "Jersey"),
			new Translation(LanguageCode.HY, "Ջերսի"),
			new Translation(LanguageCode.ID, "Jersey"),
			new Translation(LanguageCode.IT, "Jersey"),
			new Translation(LanguageCode.JA, "ジャージー"),
			new Translation(LanguageCode.KA, "ჯერსი"),
			new Translation(LanguageCode.KK, "Джерси"),
			new Translation(LanguageCode.KO, "저지"),
			new Translation(LanguageCode.KY, "Жерси"),
			new Translation(LanguageCode.LT, "Džersis"),
			new Translation(LanguageCode.LV, "Džērsija"),
			new Translation(LanguageCode.MK, "Џерси"),
			new Translation(LanguageCode.MN, "Жерси"),
			new Translation(LanguageCode.NB, "Jersey"),
			new Translation(LanguageCode.NL, "Jersey"),
			new Translation(LanguageCode.NN, "Jersey"),
			new Translation(LanguageCode.PL, "Jersey"),
			new Translation(LanguageCode.PT, "Jersey"),
			new Translation(LanguageCode.RO, "Jersey"),
			new Translation(LanguageCode.RU, "Джерси"),
			new Translation(LanguageCode.SK, "Jersey"),
			new Translation(LanguageCode.SL, "Jersey"),
			new Translation(LanguageCode.SR, "Џерзи"),
			new Translation(LanguageCode.SV, "Jersey"),
			new Translation(LanguageCode.TR, "Jersey"),
			new Translation(LanguageCode.UK, "Джерсі"),
			new Translation(LanguageCode.UZ, "Jersi"),
			new Translation(LanguageCode.ZH, "泽西"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.JE;
		public Alpha3Code Alpha3Code => Alpha3Code.JEY;
		public int NumericCode => 832;
		public string[] TLD => new [] { ".je" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "GBP" };
		public string[] CallingCodes => new [] { "44" };
	}
}
