namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Comoros
	/// </summary>
	public class ComorosInfo : ICountryInfo
	{
		public string CommonName => "Comoros";
		public string OfficialName => "Union of the Comoros";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "جزر القمر"),
			new Translation(LanguageCode.AZ, "Komor adaları"),
			new Translation(LanguageCode.BE, "Каморскія Астравы"),
			new Translation(LanguageCode.BG, "Коморски острови"),
			new Translation(LanguageCode.BS, "Komorska Ostrva"),
			new Translation(LanguageCode.CA, "Comores"),
			new Translation(LanguageCode.CS, "Komory"),
			new Translation(LanguageCode.DA, "Comorerne"),
			new Translation(LanguageCode.DE, "Komoren"),
			new Translation(LanguageCode.EL, "Ένωση των Κομορών"),
			new Translation(LanguageCode.EN, "Comoros"),
			new Translation(LanguageCode.ES, "Comoras"),
			new Translation(LanguageCode.ET, "Komoorid"),
			new Translation(LanguageCode.FA, "کومورو"),
			new Translation(LanguageCode.FI, "Komorit"),
			new Translation(LanguageCode.FR, "Comores"),
			new Translation(LanguageCode.HE, "קומורו"),
			new Translation(LanguageCode.HR, "Komori"),
			new Translation(LanguageCode.HU, "Comore-szigetek"),
			new Translation(LanguageCode.HY, "Կոմորյան կղզիներ"),
			new Translation(LanguageCode.ID, "Komoro"),
			new Translation(LanguageCode.IT, "Comore"),
			new Translation(LanguageCode.JA, "小諸"),
			new Translation(LanguageCode.KA, "კომორის კუნძულები"),
			new Translation(LanguageCode.KK, "Комор аралдары"),
			new Translation(LanguageCode.KO, "코모로"),
			new Translation(LanguageCode.KY, "Коморос"),
			new Translation(LanguageCode.LT, "Komorai"),
			new Translation(LanguageCode.LV, "Komoru salas"),
			new Translation(LanguageCode.MK, "Коморски Острови"),
			new Translation(LanguageCode.MN, "Коморос"),
			new Translation(LanguageCode.NB, "Komorene"),
			new Translation(LanguageCode.NL, "Comoren"),
			new Translation(LanguageCode.NN, "Komorane"),
			new Translation(LanguageCode.PL, "Komory"),
			new Translation(LanguageCode.PT, "Comores"),
			new Translation(LanguageCode.RO, "Comore"),
			new Translation(LanguageCode.RU, "Коморы"),
			new Translation(LanguageCode.SK, "Komory"),
			new Translation(LanguageCode.SL, "Komori"),
			new Translation(LanguageCode.SR, "Коморска Острва"),
			new Translation(LanguageCode.SV, "Komorerna"),
			new Translation(LanguageCode.TR, "Komorlar"),
			new Translation(LanguageCode.UK, "Коморські Острови"),
			new Translation(LanguageCode.UZ, "Komor orollari"),
			new Translation(LanguageCode.ZH, "科摩罗"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.KM;
		public Alpha3Code Alpha3Code => Alpha3Code.COM;
		public int NumericCode => 174;
		public string[] TLD => new [] { ".km" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "KMF" };
		public string[] CallingCodes => new [] { "269" };
	}
}
