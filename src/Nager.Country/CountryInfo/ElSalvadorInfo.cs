namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// El Salvador
	/// </summary>
	public class ElSalvadorInfo : ICountryInfo
	{
		public string CommonName => "El Salvador";
		public string OfficialName => "Republic of El Salvador";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "السلفادور"),
			new Translation(LanguageCode.AZ, "Salvador"),
			new Translation(LanguageCode.BE, "Сальвадор"),
			new Translation(LanguageCode.BG, "Салвадор"),
			new Translation(LanguageCode.BS, "Salvador"),
			new Translation(LanguageCode.CA, "Salvador, El"),
			new Translation(LanguageCode.CS, "Salvador"),
			new Translation(LanguageCode.DA, "El Salvador"),
			new Translation(LanguageCode.DE, "El Salvador"),
			new Translation(LanguageCode.EL, "Ελ Σαλβαδόρ"),
			new Translation(LanguageCode.EN, "El Salvador"),
			new Translation(LanguageCode.ES, "El Salvador"),
			new Translation(LanguageCode.ET, "El Salvador"),
			new Translation(LanguageCode.FA, "السالوادور"),
			new Translation(LanguageCode.FI, "El Salvador"),
			new Translation(LanguageCode.FR, "El Salvador"),
			new Translation(LanguageCode.HE, "אל סלבדור"),
			new Translation(LanguageCode.HR, "Salvador"),
			new Translation(LanguageCode.HU, "Salvador"),
			new Translation(LanguageCode.HY, "Սալվադոր"),
			new Translation(LanguageCode.ID, "El Salvador"),
			new Translation(LanguageCode.IT, "El Salvador"),
			new Translation(LanguageCode.JA, "エルサルバドル"),
			new Translation(LanguageCode.KA, "სალვადორი"),
			new Translation(LanguageCode.KK, "Сальвадор"),
			new Translation(LanguageCode.KO, "엘살바도르"),
			new Translation(LanguageCode.KY, "Эл Салвадор"),
			new Translation(LanguageCode.LT, "Salvadoras"),
			new Translation(LanguageCode.LV, "Salvadora"),
			new Translation(LanguageCode.MK, "Ел Салвадор"),
			new Translation(LanguageCode.MN, "Эль Сальвадор"),
			new Translation(LanguageCode.NB, "El Salvador"),
			new Translation(LanguageCode.NL, "El Salvador"),
			new Translation(LanguageCode.NN, "El Salvador"),
			new Translation(LanguageCode.PL, "Salwador"),
			new Translation(LanguageCode.PT, "El Salvador"),
			new Translation(LanguageCode.RO, "El Salvador"),
			new Translation(LanguageCode.RU, "Сальвадор"),
			new Translation(LanguageCode.SK, "Salvádor"),
			new Translation(LanguageCode.SL, "Salvador"),
			new Translation(LanguageCode.SR, "Салвадор"),
			new Translation(LanguageCode.SV, "El Salvador"),
			new Translation(LanguageCode.TR, "El Salvador"),
			new Translation(LanguageCode.UK, "Сальвадор"),
			new Translation(LanguageCode.UZ, "Salvador"),
			new Translation(LanguageCode.ZH, "萨尔瓦多"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.SV;
		public Alpha3Code Alpha3Code => Alpha3Code.SLV;
		public int NumericCode => 222;
		public string[] TLD => new [] { ".sv" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.CentralAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.GT,
			Alpha2Code.HN,
		};

		public string[] Currencies => new [] { "SVC", "USD" };
		public string[] CallingCodes => new [] { "503" };
	}
}
