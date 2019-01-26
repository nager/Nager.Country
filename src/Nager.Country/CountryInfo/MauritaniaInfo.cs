namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Mauritania
	/// </summary>
	public class MauritaniaInfo : ICountryInfo
	{
		public string CommonName => "Mauritania";
		public string OfficialName => "Islamic Republic of Mauritania";

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
