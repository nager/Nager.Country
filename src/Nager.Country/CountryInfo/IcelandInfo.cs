namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Iceland
	/// </summary>
	public class IcelandInfo : ICountryInfo
	{
		public string CommonName => "Iceland";
		public string OfficialName => "Iceland";

		public Alpha2Code Alpha2Code => Alpha2Code.IS;
		public Alpha3Code Alpha3Code => Alpha3Code.ISL;
		public int NumericCode => 352;
		public string[] TLD => new [] { ".is" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "ISK" };
		public string[] CallingCodes => new [] { "354" };
	}
}
