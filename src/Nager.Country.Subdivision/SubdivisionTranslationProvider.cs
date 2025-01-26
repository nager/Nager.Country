﻿using Nager.Country.Translation;

namespace Nager.Country.Subdivision;

public class SubdivisionTranslationProvider : ISubdivisionTranslationProvider
{
	private static readonly ISubdivisionTranslation EmptyTranslation = new EmptySubdivisionTranslation();

	private readonly Dictionary<SubdivisionCode, ISubdivisionTranslation> _code2SubdivisionTranslation = [];

	private ISubdivisionProvider _subdivisionProvider;

	public SubdivisionTranslationProvider( ISubdivisionProvider subdivisionProvider = null )
	{
		_subdivisionProvider = subdivisionProvider;

		_code2SubdivisionTranslation = SubdivisionTranslationInitializer.Create();
	}

	public ISubdivisionTranslation GetSubdivisionTranslation( SubdivisionCode code )
	{
		if( _code2SubdivisionTranslation.TryGetValue( code, out var translation ) )
		{
			return translation;
		}
		
		return EmptyTranslation;
	}

	public string GetSubdivisionTranslatedName( SubdivisionCode code, LanguageCode languageCode )
	{
		if( !_code2SubdivisionTranslation.TryGetValue( code,
			out ISubdivisionTranslation subdivisionTranslation ) )
		{
			return null;
		}

		return subdivisionTranslation.Translations
			.FirstOrDefault( x => x.LanguageCode == languageCode )
			?.Name;
	}

	public string GetSubdivisionTranslatedOrCommonName( SubdivisionCode code, LanguageCode languageCode )
	{
		string translatedName = GetSubdivisionTranslatedName( code, languageCode );
		if( translatedName != null )
		{
			return translatedName;
		}

		return GetProvider().GetSubdivision( code ).CommonName;
	}

	private ISubdivisionProvider GetProvider()
	{
		return _subdivisionProvider ??= new SubdivisionProvider();
	}
}