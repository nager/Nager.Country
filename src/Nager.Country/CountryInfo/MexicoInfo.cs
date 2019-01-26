namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Mexico
	/// </summary>
	public class MexicoInfo : ICountryInfo
	{
		public string CommonName => "Mexico";
		public string OfficialName => "United Mexican States";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "المكسيك"),
			new Translation(LanguageCode.AZ, "Meksika"),
			new Translation(LanguageCode.BE, "Мексіка"),
			new Translation(LanguageCode.BG, "Мексико"),
			new Translation(LanguageCode.BS, "Meksiko"),
			new Translation(LanguageCode.CA, "Mèxic"),
			new Translation(LanguageCode.CS, "Mexiko"),
			new Translation(LanguageCode.DA, "Mexico"),
			new Translation(LanguageCode.DE, "Mexiko"),
			new Translation(LanguageCode.EL, "Μεξικό"),
			new Translation(LanguageCode.EN, "Mexico"),
			new Translation(LanguageCode.ES, "México"),
			new Translation(LanguageCode.ET, "Mehhiko"),
			new Translation(LanguageCode.FA, "مکزیک"),
			new Translation(LanguageCode.FI, "Meksiko"),
			new Translation(LanguageCode.FR, "Mexique"),
			new Translation(LanguageCode.HE, "מקסיקו"),
			new Translation(LanguageCode.HR, "Meksiko"),
			new Translation(LanguageCode.HU, "Mexikó"),
			new Translation(LanguageCode.HY, "Մեքսիկա"),
			new Translation(LanguageCode.ID, "Meksiko"),
			new Translation(LanguageCode.IT, "Messico"),
			new Translation(LanguageCode.JA, "メキシコ"),
			new Translation(LanguageCode.KA, "მექსიკა"),
			new Translation(LanguageCode.KK, "Мексика"),
			new Translation(LanguageCode.KO, "멕시코"),
			new Translation(LanguageCode.KY, "Мексика"),
			new Translation(LanguageCode.LT, "Meksika"),
			new Translation(LanguageCode.LV, "Meksika"),
			new Translation(LanguageCode.MK, "Мексико"),
			new Translation(LanguageCode.MN, "Мексик"),
			new Translation(LanguageCode.NB, "Mexico"),
			new Translation(LanguageCode.NL, "Mexico"),
			new Translation(LanguageCode.NN, "Mexico"),
			new Translation(LanguageCode.PL, "Meksyk"),
			new Translation(LanguageCode.PT, "México"),
			new Translation(LanguageCode.RO, "Mexic"),
			new Translation(LanguageCode.RU, "Мексика"),
			new Translation(LanguageCode.SK, "Mexiko"),
			new Translation(LanguageCode.SL, "Mehika"),
			new Translation(LanguageCode.SR, "Мексико"),
			new Translation(LanguageCode.SV, "Mexiko"),
			new Translation(LanguageCode.TR, "Meksika"),
			new Translation(LanguageCode.UK, "Мексика"),
			new Translation(LanguageCode.UZ, "Meksika"),
			new Translation(LanguageCode.ZH, "墨西哥"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.MX;
		public Alpha3Code Alpha3Code => Alpha3Code.MEX;
		public int NumericCode => 484;
		public string[] TLD => new [] { ".mx" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.CentralAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BZ,
			Alpha2Code.GT,
			Alpha2Code.US,
		};

		public string[] Currencies => new [] { "MXN" };
		public string[] CallingCodes => new [] { "52" };
	}
}
