namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Trinidad and Tobago
	/// </summary>
	public class TrinidadandTobagoInfo : ICountryInfo
	{
		public string CommonName => "Trinidad and Tobago";
		public string OfficialName => "Republic of Trinidad and Tobago";

		public Alpha2Code Alpha2Code => Alpha2Code.TT;
		public Alpha3Code Alpha3Code => Alpha3Code.TTO;
		public int NumericCode => 780;
		public string[] TLD => new [] { ".tt" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "TTD" };
		public string[] CallingCodes => new [] { "1868" };
	}
}
