using Nager.Country.Translation;

namespace Nager.Country.Subdivision;

/// <summary>
/// ISubdivisionTranslation
/// </summary>
public interface ISubdivisionTranslation
{
	/// <summary>
	/// Get all subdivision translation (different than common name) 
	/// </summary>
	TranslationInfo[] Translations { get; }
}