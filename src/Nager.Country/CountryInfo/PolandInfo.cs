namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Poland
	/// </summary>
	public class PolandInfo : ICountryInfo
	{
		public string CommonName => "Poland";
		public string OfficialName => "Republic of Poland";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "بولندا"),
			new Translation(LanguageCode.AZ, "Polşa"),
			new Translation(LanguageCode.BE, "Польшча"),
			new Translation(LanguageCode.BG, "Полша"),
			new Translation(LanguageCode.BS, "Poljska"),
			new Translation(LanguageCode.CA, "Polònia"),
			new Translation(LanguageCode.CS, "Polsko"),
			new Translation(LanguageCode.DA, "Polen"),
			new Translation(LanguageCode.DE, "Polen"),
			new Translation(LanguageCode.EL, "Πολωνία"),
			new Translation(LanguageCode.EN, "Poland"),
			new Translation(LanguageCode.ES, "Polonia"),
			new Translation(LanguageCode.ET, "Poola"),
			new Translation(LanguageCode.FA, "لهستان"),
			new Translation(LanguageCode.FI, "Puola"),
			new Translation(LanguageCode.FR, "Pologne"),
			new Translation(LanguageCode.HE, "פולין"),
			new Translation(LanguageCode.HR, "Poljska"),
			new Translation(LanguageCode.HU, "Lengyelország"),
			new Translation(LanguageCode.HY, "Լեհաստան"),
			new Translation(LanguageCode.ID, "Polandia"),
			new Translation(LanguageCode.IT, "Polonia"),
			new Translation(LanguageCode.JA, "ポーランド"),
			new Translation(LanguageCode.KA, "პოლონეთი"),
			new Translation(LanguageCode.KK, "Польша"),
			new Translation(LanguageCode.KO, "폴란드"),
			new Translation(LanguageCode.KY, "Польша"),
			new Translation(LanguageCode.LT, "Lenkija"),
			new Translation(LanguageCode.LV, "Polija"),
			new Translation(LanguageCode.MK, "Полска"),
			new Translation(LanguageCode.MN, "Польш"),
			new Translation(LanguageCode.NB, "Polen"),
			new Translation(LanguageCode.NL, "Polen"),
			new Translation(LanguageCode.NN, "Polen"),
			new Translation(LanguageCode.PL, "Polska"),
			new Translation(LanguageCode.PT, "Polônia"),
			new Translation(LanguageCode.RO, "Polonia"),
			new Translation(LanguageCode.RU, "Польша"),
			new Translation(LanguageCode.SK, "Poľsko"),
			new Translation(LanguageCode.SL, "Poljska"),
			new Translation(LanguageCode.SR, "Пољска"),
			new Translation(LanguageCode.SV, "Polen"),
			new Translation(LanguageCode.TR, "Polonya"),
			new Translation(LanguageCode.UK, "Польша"),
			new Translation(LanguageCode.UZ, "Polsha"),
			new Translation(LanguageCode.ZH, "波兰"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.PL;
		public Alpha3Code Alpha3Code => Alpha3Code.POL;
		public int NumericCode => 616;
		public string[] TLD => new [] { ".pl" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.EasternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BY,
			Alpha2Code.CZ,
			Alpha2Code.DE,
			Alpha2Code.LT,
			Alpha2Code.RU,
			Alpha2Code.SK,
			Alpha2Code.UA,
		};

		public string[] Currencies => new [] { "PLN" };
		public string[] CallingCodes => new [] { "48" };
	}
}
