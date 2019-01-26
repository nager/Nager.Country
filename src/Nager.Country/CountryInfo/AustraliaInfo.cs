namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Australia
	/// </summary>
	public class AustraliaInfo : ICountryInfo
	{
		public string CommonName => "Australia";
		public string OfficialName => "Commonwealth of Australia";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "أستراليا"),
			new Translation(LanguageCode.AZ, "Avstraliya"),
			new Translation(LanguageCode.BE, "Аўстралія"),
			new Translation(LanguageCode.BG, "Австралия"),
			new Translation(LanguageCode.BS, "Australija"),
			new Translation(LanguageCode.CA, "Austràlia"),
			new Translation(LanguageCode.CS, "Austrálie"),
			new Translation(LanguageCode.DA, "Australien"),
			new Translation(LanguageCode.DE, "Australien"),
			new Translation(LanguageCode.EL, "Αυστραλία"),
			new Translation(LanguageCode.EN, "Australia"),
			new Translation(LanguageCode.ES, "Australia"),
			new Translation(LanguageCode.ET, "Austraalia"),
			new Translation(LanguageCode.FA, "استرالیا"),
			new Translation(LanguageCode.FI, "Australia"),
			new Translation(LanguageCode.FR, "Australie"),
			new Translation(LanguageCode.HE, "אוסטרליה"),
			new Translation(LanguageCode.HR, "Australija"),
			new Translation(LanguageCode.HU, "Ausztrália"),
			new Translation(LanguageCode.HY, "Ավստրալիա"),
			new Translation(LanguageCode.ID, "Australia"),
			new Translation(LanguageCode.IT, "Australia"),
			new Translation(LanguageCode.JA, "オーストラリア"),
			new Translation(LanguageCode.KA, "ავსტრალია"),
			new Translation(LanguageCode.KK, "Австралия"),
			new Translation(LanguageCode.KO, "호주"),
			new Translation(LanguageCode.KY, "Австралия"),
			new Translation(LanguageCode.LT, "Australija"),
			new Translation(LanguageCode.LV, "Austrālija"),
			new Translation(LanguageCode.MK, "Австралија"),
			new Translation(LanguageCode.MN, "Австрали"),
			new Translation(LanguageCode.NB, "Australia"),
			new Translation(LanguageCode.NL, "Australië"),
			new Translation(LanguageCode.NN, "Australia"),
			new Translation(LanguageCode.PL, "Australia"),
			new Translation(LanguageCode.PT, "Austrália"),
			new Translation(LanguageCode.RO, "Australia"),
			new Translation(LanguageCode.RU, "Австралия"),
			new Translation(LanguageCode.SK, "Austrália"),
			new Translation(LanguageCode.SL, "Avstralija"),
			new Translation(LanguageCode.SR, "Аустралија"),
			new Translation(LanguageCode.SV, "Australien"),
			new Translation(LanguageCode.TR, "Avustralya"),
			new Translation(LanguageCode.UK, "Австралія"),
			new Translation(LanguageCode.UZ, "Avstraliya"),
			new Translation(LanguageCode.ZH, "澳大利亚"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.AU;
		public Alpha3Code Alpha3Code => Alpha3Code.AUS;
		public int NumericCode => 036;
		public string[] TLD => new [] { ".au" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.AustraliaandNewZealand;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "AUD" };
		public string[] CallingCodes => new [] { "61" };
	}
}
