namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Colombia
	/// </summary>
	public class ColombiaInfo : ICountryInfo
	{
		public string CommonName => "Colombia";
		public string OfficialName => "Republic of Colombia";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "كولومبيا"),
			new Translation(LanguageCode.AZ, "Kolumbiya"),
			new Translation(LanguageCode.BE, "Калумбія"),
			new Translation(LanguageCode.BG, "Колумбия"),
			new Translation(LanguageCode.BS, "Kolumbija"),
			new Translation(LanguageCode.CA, "Colòmbia"),
			new Translation(LanguageCode.CS, "Kolumbie"),
			new Translation(LanguageCode.DA, "Colombia"),
			new Translation(LanguageCode.DE, "Kolumbien"),
			new Translation(LanguageCode.EL, "Κολομβία"),
			new Translation(LanguageCode.EN, "Colombia"),
			new Translation(LanguageCode.ES, "Colombia"),
			new Translation(LanguageCode.ET, "Colombia"),
			new Translation(LanguageCode.FA, "کلمبیا"),
			new Translation(LanguageCode.FI, "Kolumbia"),
			new Translation(LanguageCode.FR, "Colombie"),
			new Translation(LanguageCode.HE, "קולומביה"),
			new Translation(LanguageCode.HR, "Kolumbija"),
			new Translation(LanguageCode.HU, "Kolumbia"),
			new Translation(LanguageCode.HY, "Կոլումբիա"),
			new Translation(LanguageCode.ID, "Kolombia"),
			new Translation(LanguageCode.IT, "Colombia"),
			new Translation(LanguageCode.JA, "コロンビア"),
			new Translation(LanguageCode.KA, "კოლუმბია"),
			new Translation(LanguageCode.KK, "Колумбия"),
			new Translation(LanguageCode.KO, "콜롬비아"),
			new Translation(LanguageCode.KY, "Колумбия"),
			new Translation(LanguageCode.LT, "Kolumbija"),
			new Translation(LanguageCode.LV, "Kolumbija"),
			new Translation(LanguageCode.MK, "Колумбија"),
			new Translation(LanguageCode.MN, "Колумб"),
			new Translation(LanguageCode.NB, "Colombia"),
			new Translation(LanguageCode.NL, "Colombia"),
			new Translation(LanguageCode.NN, "Colombia"),
			new Translation(LanguageCode.PL, "Kolumbia"),
			new Translation(LanguageCode.PT, "Colômbia"),
			new Translation(LanguageCode.RO, "Columbia"),
			new Translation(LanguageCode.RU, "Колумбия"),
			new Translation(LanguageCode.SK, "Kolumbia"),
			new Translation(LanguageCode.SL, "Kolumbija"),
			new Translation(LanguageCode.SR, "Колумбија"),
			new Translation(LanguageCode.SV, "Colombia"),
			new Translation(LanguageCode.TR, "Kolombiya"),
			new Translation(LanguageCode.UK, "Колумбія"),
			new Translation(LanguageCode.UZ, "Kolumbiya"),
			new Translation(LanguageCode.ZH, "哥伦比亚"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.CO;
		public Alpha3Code Alpha3Code => Alpha3Code.COL;
		public int NumericCode => 170;
		public string[] TLD => new [] { ".co" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BR,
			Alpha2Code.EC,
			Alpha2Code.PA,
			Alpha2Code.PE,
			Alpha2Code.VE,
		};

		public string[] Currencies => new [] { "COP" };
		public string[] CallingCodes => new [] { "57" };
	}
}
