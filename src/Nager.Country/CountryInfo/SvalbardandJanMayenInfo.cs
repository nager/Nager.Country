namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Svalbard and Jan Mayen
	/// </summary>
	public class SvalbardandJanMayenInfo : ICountryInfo
	{
		public string CommonName => "Svalbard and Jan Mayen";
		public string OfficialName => "Svalbard og Jan Mayen";

		public Alpha2Code Alpha2Code => Alpha2Code.SJ;
		public Alpha3Code Alpha3Code => Alpha3Code.SJM;
		public int NumericCode => 744;
		public string[] TLD => new [] { ".sj" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "NOK" };
		public string[] CallingCodes => new [] { "4779" };
	}
}
