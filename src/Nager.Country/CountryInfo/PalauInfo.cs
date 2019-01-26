namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Palau
	/// </summary>
	public class PalauInfo : ICountryInfo
	{
		public string CommonName => "Palau";
		public string OfficialName => "Republic of Palau";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "بالاو"),
			new Translation(LanguageCode.AZ, "Palau"),
			new Translation(LanguageCode.BE, "Палау"),
			new Translation(LanguageCode.BG, "Палау"),
			new Translation(LanguageCode.BS, "Palau"),
			new Translation(LanguageCode.CA, "Palau"),
			new Translation(LanguageCode.CS, "Palau"),
			new Translation(LanguageCode.DA, "Palau"),
			new Translation(LanguageCode.DE, "Palau"),
			new Translation(LanguageCode.EL, "Παλάου"),
			new Translation(LanguageCode.EN, "Palau"),
			new Translation(LanguageCode.ES, "Palau"),
			new Translation(LanguageCode.ET, "Belau"),
			new Translation(LanguageCode.FA, "پالائو"),
			new Translation(LanguageCode.FI, "Palau"),
			new Translation(LanguageCode.FR, "Palau"),
			new Translation(LanguageCode.HE, "פלאו"),
			new Translation(LanguageCode.HR, "Palau"),
			new Translation(LanguageCode.HU, "Palau"),
			new Translation(LanguageCode.HY, "Պալաու"),
			new Translation(LanguageCode.ID, "Palau"),
			new Translation(LanguageCode.IT, "Palau"),
			new Translation(LanguageCode.JA, "パラオ"),
			new Translation(LanguageCode.KA, "პალაუ"),
			new Translation(LanguageCode.KK, "Палау"),
			new Translation(LanguageCode.KO, "팔라우"),
			new Translation(LanguageCode.KY, "Палау"),
			new Translation(LanguageCode.LT, "Palau"),
			new Translation(LanguageCode.LV, "Palau"),
			new Translation(LanguageCode.MK, "Палау"),
			new Translation(LanguageCode.MN, "Палау"),
			new Translation(LanguageCode.NB, "Palau"),
			new Translation(LanguageCode.NL, "Palau"),
			new Translation(LanguageCode.NN, "Palau"),
			new Translation(LanguageCode.PL, "Palau"),
			new Translation(LanguageCode.PT, "Palau"),
			new Translation(LanguageCode.RO, "Palau"),
			new Translation(LanguageCode.RU, "Палау"),
			new Translation(LanguageCode.SK, "Palau"),
			new Translation(LanguageCode.SL, "Palau"),
			new Translation(LanguageCode.SR, "Палау"),
			new Translation(LanguageCode.SV, "Palau"),
			new Translation(LanguageCode.TR, "Palau"),
			new Translation(LanguageCode.UK, "Палау"),
			new Translation(LanguageCode.UZ, "Palau"),
			new Translation(LanguageCode.ZH, "帛琉"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.PW;
		public Alpha3Code Alpha3Code => Alpha3Code.PLW;
		public int NumericCode => 585;
		public string[] TLD => new [] { ".pw" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Micronesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "680" };
	}
}
