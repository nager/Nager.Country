using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class GenevaSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.FR, "Genève")
	};
}