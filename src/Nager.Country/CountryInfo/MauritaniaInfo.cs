namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Mauritania
	/// </summary>
	public class MauritaniaInfo : ICountryInfo
	{
		public string CommonName => "Mauritania";
		public string OfficialName => "Islamic Republic of Mauritania";
		public Translation[] Translations => new []
		{
			new Translation(LanguageCode.AR, "موريتانيا"),
			new Translation(LanguageCode.AZ, "Mavritaniya"),
			new Translation(LanguageCode.BE, "Маўрытанія"),
			new Translation(LanguageCode.BG, "Мавритания"),
			new Translation(LanguageCode.BS, "Mauritanija"),
			new Translation(LanguageCode.CA, "Mauritània"),
			new Translation(LanguageCode.CS, "Mauritánie"),
			new Translation(LanguageCode.DA, "Mauretanien"),
			new Translation(LanguageCode.DE, "Mauretanien"),
			new Translation(LanguageCode.EL, "Μαυριτανία"),
			new Translation(LanguageCode.EN, "Mauritania"),
			new Translation(LanguageCode.ES, "Mauritania"),
			new Translation(LanguageCode.ET, "Mauritaania"),
			new Translation(LanguageCode.FA, "موریتانی"),
			new Translation(LanguageCode.FI, "Mauritania"),
			new Translation(LanguageCode.FR, "Mauritanie"),
			new Translation(LanguageCode.HE, "מאוריטניה"),
			new Translation(LanguageCode.HR, "Mauretanija"),
			new Translation(LanguageCode.HU, "Mauritánia"),
			new Translation(LanguageCode.HY, "Մավրիտանիա"),
			new Translation(LanguageCode.ID, "Mauritania"),
			new Translation(LanguageCode.IT, "Mauritania"),
			new Translation(LanguageCode.JA, "モーリタニア"),
			new Translation(LanguageCode.KA, "მავრიტანია"),
			new Translation(LanguageCode.KK, "Мавритания"),
			new Translation(LanguageCode.KO, "모리타니"),
			new Translation(LanguageCode.KY, "Мавритания"),
			new Translation(LanguageCode.LT, "Mauritanija"),
			new Translation(LanguageCode.LV, "Mauritānija"),
			new Translation(LanguageCode.MK, "Мавританија"),
			new Translation(LanguageCode.MN, "Мавритани"),
			new Translation(LanguageCode.NB, "Mauritania"),
			new Translation(LanguageCode.NL, "Mauritanië"),
			new Translation(LanguageCode.NN, "Mauritania"),
			new Translation(LanguageCode.PL, "Mauretania"),
			new Translation(LanguageCode.PT, "Mauritânia"),
			new Translation(LanguageCode.RO, "Mauritania"),
			new Translation(LanguageCode.RU, "Мавритания"),
			new Translation(LanguageCode.SK, "Mauritánia"),
			new Translation(LanguageCode.SL, "Mavretanija"),
			new Translation(LanguageCode.SR, "Мауританија"),
			new Translation(LanguageCode.SV, "Mauretanien"),
			new Translation(LanguageCode.TR, "Moritanya"),
			new Translation(LanguageCode.UK, "Мавританія"),
			new Translation(LanguageCode.UZ, "Mavritaniya"),
			new Translation(LanguageCode.ZH, "毛里塔尼亚"),
		};

		public Alpha2Code Alpha2Code => Alpha2Code.MR;
		public Alpha3Code Alpha3Code => Alpha3Code.MRT;
		public int NumericCode => 478;
		public string[] TLD => new [] { ".mr" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DZ,
			Alpha2Code.ML,
			Alpha2Code.SN,
			Alpha2Code.EH,
		};

		public string[] Currencies => new [] { "MRO" };
		public string[] CallingCodes => new [] { "222" };
	}
}
