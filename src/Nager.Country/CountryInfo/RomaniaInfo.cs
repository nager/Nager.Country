namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Romania
	/// </summary>
	public class RomaniaInfo : ICountryInfo
	{
		public string CommonName => "Romania";
		public string OfficialName => "Romania";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "رومانيا"),
			new Translation(LanguageCode.AZ, "Rumıniya"),
			new Translation(LanguageCode.BE, "Румынія"),
			new Translation(LanguageCode.BG, "Румъния"),
			new Translation(LanguageCode.BS, "Rumunija"),
			new Translation(LanguageCode.CA, "Romania"),
			new Translation(LanguageCode.CS, "Rumunsko"),
			new Translation(LanguageCode.DA, "Rumænien"),
			new Translation(LanguageCode.DE, "Rumänien"),
			new Translation(LanguageCode.EL, "Ρουμανία"),
			new Translation(LanguageCode.EN, "Romania"),
			new Translation(LanguageCode.ES, "Rumania"),
			new Translation(LanguageCode.ET, "Rumeenia"),
			new Translation(LanguageCode.FA, "رومانی"),
			new Translation(LanguageCode.FI, "Romania"),
			new Translation(LanguageCode.FR, "Roumanie"),
			new Translation(LanguageCode.HE, "רומניה"),
			new Translation(LanguageCode.HR, "Rumunjska"),
			new Translation(LanguageCode.HU, "Románia"),
			new Translation(LanguageCode.HY, "Ռումինիա"),
			new Translation(LanguageCode.ID, "Rumania"),
			new Translation(LanguageCode.IT, "Romania"),
			new Translation(LanguageCode.JA, "ルーマニア"),
			new Translation(LanguageCode.KA, "რუმინეთი"),
			new Translation(LanguageCode.KK, "Румыния"),
			new Translation(LanguageCode.KO, "루마니아"),
			new Translation(LanguageCode.KY, "Румыния"),
			new Translation(LanguageCode.LT, "Rumunija"),
			new Translation(LanguageCode.LV, "Rumānija"),
			new Translation(LanguageCode.MK, "Романија"),
			new Translation(LanguageCode.MN, "Румын"),
			new Translation(LanguageCode.NB, "Romania"),
			new Translation(LanguageCode.NL, "Roemenië"),
			new Translation(LanguageCode.NN, "Romania"),
			new Translation(LanguageCode.PL, "Rumunia"),
			new Translation(LanguageCode.PT, "Romênia"),
			new Translation(LanguageCode.RO, "România"),
			new Translation(LanguageCode.RU, "Румыния"),
			new Translation(LanguageCode.SK, "Rumunsko"),
			new Translation(LanguageCode.SL, "Romunija"),
			new Translation(LanguageCode.SR, "Румунија"),
			new Translation(LanguageCode.SV, "Rumänien"),
			new Translation(LanguageCode.TR, "Romanya"),
			new Translation(LanguageCode.UK, "Румунія"),
			new Translation(LanguageCode.UZ, "Ruminiya"),
			new Translation(LanguageCode.ZH, "罗马尼亚"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.RO;
		public Alpha3Code Alpha3Code => Alpha3Code.ROU;
		public int NumericCode => 642;
		public string[] TLD => new [] { ".ro" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.EasternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BG,
			Alpha2Code.HU,
			Alpha2Code.MD,
			Alpha2Code.RS,
			Alpha2Code.UA,
		};

		public string[] Currencies => new [] { "RON" };
		public string[] CallingCodes => new [] { "40" };
	}
}
