namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Grenada
	/// </summary>
	public class GrenadaInfo : ICountryInfo
	{
		public string CommonName => "Grenada";
		public string OfficialName => "Grenada";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "غرينادا"),
			new Translation(LanguageCode.AZ, "Qrenada"),
			new Translation(LanguageCode.BE, "Грэнада"),
			new Translation(LanguageCode.BG, "Гренада"),
			new Translation(LanguageCode.BS, "Grenada"),
			new Translation(LanguageCode.CA, "Grenada"),
			new Translation(LanguageCode.CS, "Grenada"),
			new Translation(LanguageCode.DA, "Grenada"),
			new Translation(LanguageCode.DE, "Grenada"),
			new Translation(LanguageCode.EL, "Γρενάδα"),
			new Translation(LanguageCode.EN, "Grenada"),
			new Translation(LanguageCode.ES, "Granada"),
			new Translation(LanguageCode.ET, "Grenada"),
			new Translation(LanguageCode.FA, "گرنادا"),
			new Translation(LanguageCode.FI, "Grenada"),
			new Translation(LanguageCode.FR, "Grenada"),
			new Translation(LanguageCode.HE, "גרנדה"),
			new Translation(LanguageCode.HR, "Grenada"),
			new Translation(LanguageCode.HU, "Grenada"),
			new Translation(LanguageCode.HY, "Գրենադա"),
			new Translation(LanguageCode.ID, "Grenada"),
			new Translation(LanguageCode.IT, "Grenada"),
			new Translation(LanguageCode.JA, "グレナダ"),
			new Translation(LanguageCode.KA, "გრენადა"),
			new Translation(LanguageCode.KK, "Гренада"),
			new Translation(LanguageCode.KO, "그레나다"),
			new Translation(LanguageCode.KY, "Гренада"),
			new Translation(LanguageCode.LT, "Grenada"),
			new Translation(LanguageCode.LV, "Grenāda"),
			new Translation(LanguageCode.MK, "Гренада"),
			new Translation(LanguageCode.MN, "Гренада"),
			new Translation(LanguageCode.NB, "Grenada"),
			new Translation(LanguageCode.NL, "Grenada"),
			new Translation(LanguageCode.NN, "Grenada"),
			new Translation(LanguageCode.PL, "Grenada"),
			new Translation(LanguageCode.PT, "Granada"),
			new Translation(LanguageCode.RO, "Grenada"),
			new Translation(LanguageCode.RU, "Гренада"),
			new Translation(LanguageCode.SK, "Grenada"),
			new Translation(LanguageCode.SL, "Grenada"),
			new Translation(LanguageCode.SR, "Гренада"),
			new Translation(LanguageCode.SV, "Grenada"),
			new Translation(LanguageCode.TR, "Grenada"),
			new Translation(LanguageCode.UK, "Гренада"),
			new Translation(LanguageCode.UZ, "Grenada"),
			new Translation(LanguageCode.ZH, "格瑞那达"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.GD;
		public Alpha3Code Alpha3Code => Alpha3Code.GRD;
		public int NumericCode => 308;
		public string[] TLD => new [] { ".gd" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XCD" };
		public string[] CallingCodes => new [] { "1473" };
	}
}
