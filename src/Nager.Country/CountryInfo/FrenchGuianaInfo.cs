namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// French Guiana
	/// </summary>
	public class FrenchGuianaInfo : ICountryInfo
	{
		public string CommonName => "French Guiana";
		public string OfficialName => "Guiana";

		public Alpha2Code Alpha2Code => Alpha2Code.GF;
		public Alpha3Code Alpha3Code => Alpha3Code.GUF;
		public int NumericCode => 254;
		public string[] TLD => new [] { ".gf" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BR,
			Alpha2Code.SR,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "594" };
	}
}
