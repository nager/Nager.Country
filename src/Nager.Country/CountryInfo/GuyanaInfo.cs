namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Guyana
	/// </summary>
	public class GuyanaInfo : ICountryInfo
	{
		public string CommonName => "Guyana";
		public string OfficialName => "Co-operative Republic of Guyana";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "غيانا"),
			new Translation(LanguageCode.AZ, "Qayana"),
			new Translation(LanguageCode.BE, "Гаяна"),
			new Translation(LanguageCode.BG, "Гаяна"),
			new Translation(LanguageCode.BS, "Gvajana"),
			new Translation(LanguageCode.CA, "Guyana"),
			new Translation(LanguageCode.CS, "Guyana"),
			new Translation(LanguageCode.DA, "Guyana"),
			new Translation(LanguageCode.DE, "Guyana"),
			new Translation(LanguageCode.EL, "Γουιάνα"),
			new Translation(LanguageCode.EN, "Guyana"),
			new Translation(LanguageCode.ES, "Guyana"),
			new Translation(LanguageCode.ET, "Guyana"),
			new Translation(LanguageCode.FA, "گویان"),
			new Translation(LanguageCode.FI, "Guyana"),
			new Translation(LanguageCode.FR, "Guyana"),
			new Translation(LanguageCode.HE, "גיאנה"),
			new Translation(LanguageCode.HR, "Gvajana"),
			new Translation(LanguageCode.HU, "Guyana"),
			new Translation(LanguageCode.HY, "Գայանա"),
			new Translation(LanguageCode.ID, "Guyana"),
			new Translation(LanguageCode.IT, "Guyana"),
			new Translation(LanguageCode.JA, "ガイアナ"),
			new Translation(LanguageCode.KA, "გაიანა"),
			new Translation(LanguageCode.KK, "Гайана"),
			new Translation(LanguageCode.KO, "가이아나"),
			new Translation(LanguageCode.KY, "Гайана"),
			new Translation(LanguageCode.LT, "Gajana"),
			new Translation(LanguageCode.LV, "Gajāna"),
			new Translation(LanguageCode.MK, "Гвајана"),
			new Translation(LanguageCode.MN, "Гайана"),
			new Translation(LanguageCode.NB, "Guyana"),
			new Translation(LanguageCode.NL, "Guyana"),
			new Translation(LanguageCode.NN, "Guyana"),
			new Translation(LanguageCode.PL, "Gujana"),
			new Translation(LanguageCode.PT, "Guiana"),
			new Translation(LanguageCode.RO, "Guyana"),
			new Translation(LanguageCode.RU, "Гайана"),
			new Translation(LanguageCode.SK, "Guayana"),
			new Translation(LanguageCode.SL, "Gvajana"),
			new Translation(LanguageCode.SR, "Гвајана"),
			new Translation(LanguageCode.SV, "Guyana"),
			new Translation(LanguageCode.TR, "Guyana"),
			new Translation(LanguageCode.UK, "Гаяна"),
			new Translation(LanguageCode.UZ, "Gayana"),
			new Translation(LanguageCode.ZH, "圭亚那"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.GY;
		public Alpha3Code Alpha3Code => Alpha3Code.GUY;
		public int NumericCode => 328;
		public string[] TLD => new [] { ".gy" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BR,
			Alpha2Code.SR,
			Alpha2Code.VE,
		};

		public string[] Currencies => new [] { "GYD" };
		public string[] CallingCodes => new [] { "592" };
	}
}
