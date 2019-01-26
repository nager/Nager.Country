namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Montserrat
	/// </summary>
	public class MontserratInfo : ICountryInfo
	{
		public string CommonName => "Montserrat";
		public string OfficialName => "Montserrat";

		public Alpha2Code Alpha2Code => Alpha2Code.MS;
		public Alpha3Code Alpha3Code => Alpha3Code.MSR;
		public int NumericCode => 500;
		public string[] TLD => new [] { ".ms" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XCD" };
		public string[] CallingCodes => new [] { "1664" };
	}
}
