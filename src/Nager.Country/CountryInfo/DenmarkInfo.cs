namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Denmark
	/// </summary>
	public class DenmarkInfo : ICountryInfo
	{
		public string CommonName => "Denmark";
		public string OfficialName => "Kingdom of Denmark";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "الدنمارك"),
			new Translation(LanguageCode.AZ, "Danimarka"),
			new Translation(LanguageCode.BE, "Данія"),
			new Translation(LanguageCode.BG, "Дания"),
			new Translation(LanguageCode.BS, "Danska"),
			new Translation(LanguageCode.CA, "Dinamarca"),
			new Translation(LanguageCode.CS, "Dánsko"),
			new Translation(LanguageCode.DA, "Danmark"),
			new Translation(LanguageCode.DE, "Dänemark"),
			new Translation(LanguageCode.EL, "Δανία"),
			new Translation(LanguageCode.EN, "Denmark"),
			new Translation(LanguageCode.ES, "Dinamarca"),
			new Translation(LanguageCode.ET, "Taani"),
			new Translation(LanguageCode.FA, "دانمارک"),
			new Translation(LanguageCode.FI, "Tanska"),
			new Translation(LanguageCode.FR, "Danemark"),
			new Translation(LanguageCode.HE, "דנמרק"),
			new Translation(LanguageCode.HR, "Danska"),
			new Translation(LanguageCode.HU, "Dánia"),
			new Translation(LanguageCode.HY, "Դանիա"),
			new Translation(LanguageCode.ID, "Denmark"),
			new Translation(LanguageCode.IT, "Danimarca"),
			new Translation(LanguageCode.JA, "デンマーク"),
			new Translation(LanguageCode.KA, "დანია"),
			new Translation(LanguageCode.KK, "Дания"),
			new Translation(LanguageCode.KO, "덴마크"),
			new Translation(LanguageCode.KY, "Дания"),
			new Translation(LanguageCode.LT, "Danija"),
			new Translation(LanguageCode.LV, "Dānija"),
			new Translation(LanguageCode.MK, "Данска"),
			new Translation(LanguageCode.MN, "Дани"),
			new Translation(LanguageCode.NB, "Danmark"),
			new Translation(LanguageCode.NL, "Denemarken"),
			new Translation(LanguageCode.NN, "Danmark"),
			new Translation(LanguageCode.PL, "Dania"),
			new Translation(LanguageCode.PT, "Dinamarca"),
			new Translation(LanguageCode.RO, "Danemarca"),
			new Translation(LanguageCode.RU, "Дания"),
			new Translation(LanguageCode.SK, "Dánsko"),
			new Translation(LanguageCode.SL, "Danska"),
			new Translation(LanguageCode.SR, "Данска"),
			new Translation(LanguageCode.SV, "Danmark"),
			new Translation(LanguageCode.TR, "Danimarka"),
			new Translation(LanguageCode.UK, "Данія"),
			new Translation(LanguageCode.UZ, "Daniya"),
			new Translation(LanguageCode.ZH, "丹麦"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.DK;
		public Alpha3Code Alpha3Code => Alpha3Code.DNK;
		public int NumericCode => 208;
		public string[] TLD => new [] { ".dk" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DE,
		};

		public string[] Currencies => new [] { "DKK" };
		public string[] CallingCodes => new [] { "45" };
	}
}
