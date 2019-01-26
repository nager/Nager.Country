namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Peru
	/// </summary>
	public class PeruInfo : ICountryInfo
	{
		public string CommonName => "Peru";
		public string OfficialName => "Republic of Peru";

		public Alpha2Code Alpha2Code => Alpha2Code.PE;
		public Alpha3Code Alpha3Code => Alpha3Code.PER;
		public int NumericCode => 604;
		public string[] TLD => new [] { ".pe" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BO,
			Alpha2Code.BR,
			Alpha2Code.CL,
			Alpha2Code.CO,
			Alpha2Code.EC,
		};

		public string[] Currencies => new [] { "PEN" };
		public string[] CallingCodes => new [] { "51" };
	}
}
