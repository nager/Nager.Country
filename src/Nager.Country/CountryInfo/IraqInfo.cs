namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Iraq
	/// </summary>
	public class IraqInfo : ICountryInfo
	{
		public string CommonName => "Iraq";
		public string OfficialName => "Republic of Iraq";

		public Alpha2Code Alpha2Code => Alpha2Code.IQ;
		public Alpha3Code Alpha3Code => Alpha3Code.IRQ;
		public int NumericCode => 368;
		public string[] TLD => new [] { ".iq" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.IR,
			Alpha2Code.JO,
			Alpha2Code.KW,
			Alpha2Code.SA,
			Alpha2Code.SY,
			Alpha2Code.TR,
		};

		public string[] Currencies => new [] { "IQD" };
		public string[] CallingCodes => new [] { "964" };
	}
}
