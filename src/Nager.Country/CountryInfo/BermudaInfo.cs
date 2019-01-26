namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Bermuda
	/// </summary>
	public class BermudaInfo : ICountryInfo
	{
		public string CommonName => "Bermuda";
		public string OfficialName => "Bermuda";

		public Alpha2Code Alpha2Code => Alpha2Code.BM;
		public Alpha3Code Alpha3Code => Alpha3Code.BMU;
		public int NumericCode => 060;
		public string[] TLD => new [] { ".bm" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.NorthernAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "BMD" };
		public string[] CallingCodes => new [] { "1441" };
	}
}
