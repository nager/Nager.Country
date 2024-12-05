using Nager.Country.Translation;

namespace Nager.Country.Subdivision.SubdivisionTranslations;

public class RhinelandPalatinateSubdivisionTranslation : ISubdivisionTranslation
{
	public TranslationInfo[] Translations => new[]
	{
		new TranslationInfo( LanguageCode.DE, "Rheinland-Pfalz")
	};
}