namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// French Polynesia
	/// </summary>
	public class FrenchPolynesiaInfo : ICountryInfo
	{
		public string CommonName => "French Polynesia";
		public string OfficialName => "French Polynesia";

		public Alpha2Code Alpha2Code => Alpha2Code.PF;
		public Alpha3Code Alpha3Code => Alpha3Code.PYF;
		public int NumericCode => 258;
		public string[] TLD => new [] { ".pf" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Polynesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XPF" };
		public string[] CallingCodes => new [] { "689" };
	}
}
