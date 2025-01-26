namespace Nager.Country.Subdivision;

public interface ISubdivisionInfo
{
	/// <summary>
	/// CommonName (english)
	/// </summary>
	string CommonName { get; }
	/// <summary>
	/// ISO-3166-2 code
	/// </summary>
	string TextCode { get; }
	/// <summary>
	/// Subdivision code
	/// </summary>
	SubdivisionCode Code { get; }
	/// <summary>
	/// Alpha2Code of parent
	/// </summary>
	Alpha2Code ParentAlpha2Code { get; }
}