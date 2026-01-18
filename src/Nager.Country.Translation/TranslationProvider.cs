using Nager.Country.Translation.CountryTranslations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace Nager.Country.Translation
{
    /// <summary>
    /// Translation Provider
    /// </summary>
    public class TranslationProvider : ITranslationProvider
    {
        private readonly ReadOnlyDictionary<LanguageCode, ILanguageTranslation> _languageCode2LanguageTranslation;
        private readonly ReadOnlyDictionary<Alpha2Code, ICountryTranslation> _alpha2Code2CountryTranslation;

        private readonly ICountryProvider _countryProvider;

        /// <summary>
        /// Translation Provider
        /// </summary>
        public TranslationProvider()
        {
            this._countryProvider = new CountryProvider();

            var interfaceType = typeof(ILanguageTranslation);

            _languageCode2LanguageTranslation = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetLoadableTypes())
                .Where(t => t?.IsClass == true && interfaceType.IsAssignableFrom(t))
                .Select(t => (ILanguageTranslation?)Activator.CreateInstance(t!))
                .Where(x => x is not null)
                .ToDictionary(x => x!.LanguageCode, x => x!)
                .AsReadOnly();

            #region Country translation

            _alpha2Code2CountryTranslation = new(
                new Dictionary<Alpha2Code, ICountryTranslation>
                {
                    { Alpha2Code.AF, new AfghanistanCountryTranslation() },
                    { Alpha2Code.AX, new AlandIslandsCountryTranslation() },
                    { Alpha2Code.AL, new AlbaniaCountryTranslation() },
                    { Alpha2Code.DZ, new AlgeriaCountryTranslation() },
                    { Alpha2Code.AS, new AmericanSamoaCountryTranslation() },
                    { Alpha2Code.AD, new AndorraCountryTranslation() },
                    { Alpha2Code.AO, new AngolaCountryTranslation() },
                    { Alpha2Code.AI, new AnguillaCountryTranslation() },
                    { Alpha2Code.AQ, new AntarcticaCountryTranslation() },
                    { Alpha2Code.AG, new AntiguaAndBarbudaCountryTranslation() },
                    { Alpha2Code.AR, new ArgentinaCountryTranslation() },
                    { Alpha2Code.AM, new ArmeniaCountryTranslation() },
                    { Alpha2Code.AW, new ArubaCountryTranslation() },
                    { Alpha2Code.AU, new AustraliaCountryTranslation() },
                    { Alpha2Code.AT, new AustriaCountryTranslation() },
                    { Alpha2Code.AZ, new AzerbaijanCountryTranslation() },
                    { Alpha2Code.BS, new BahamasCountryTranslation() },
                    { Alpha2Code.BH, new BahrainCountryTranslation() },
                    { Alpha2Code.BD, new BangladeshCountryTranslation() },
                    { Alpha2Code.BB, new BarbadosCountryTranslation() },
                    { Alpha2Code.BY, new BelarusCountryTranslation() },
                    { Alpha2Code.BE, new BelgiumCountryTranslation() },
                    { Alpha2Code.BZ, new BelizeCountryTranslation() },
                    { Alpha2Code.BJ, new BeninCountryTranslation() },
                    { Alpha2Code.BM, new BermudaCountryTranslation() },
                    { Alpha2Code.BT, new BhutanCountryTranslation() },
                    { Alpha2Code.BO, new BoliviaCountryTranslation() },
                    { Alpha2Code.BA, new BosniaandHerzegovinaCountryTranslation() },
                    { Alpha2Code.BW, new BotswanaCountryTranslation() },
                    { Alpha2Code.BV, new BouvetIslandCountryTranslation() },
                    { Alpha2Code.BR, new BrazilCountryTranslation() },
                    { Alpha2Code.IO, new BritishIndianOceanTerritoryCountryTranslation() },
                    { Alpha2Code.VG, new BritishVirginIslandsCountryTranslation() },
                    { Alpha2Code.BN, new BruneiCountryTranslation() },
                    { Alpha2Code.BG, new BulgariaCountryTranslation() },
                    { Alpha2Code.BF, new BurkinaFasoCountryTranslation() },
                    { Alpha2Code.BI, new BurundiCountryTranslation() },
                    { Alpha2Code.KH, new CambodiaCountryTranslation() },
                    { Alpha2Code.CM, new CameroonCountryTranslation() },
                    { Alpha2Code.CA, new CanadaCountryTranslation() },
                    { Alpha2Code.CV, new CapeVerdeCountryTranslation() },
                    { Alpha2Code.BQ, new CaribbeanNetherlandsCountryTranslation() },
                    { Alpha2Code.KY, new CaymanIslandsCountryTranslation() },
                    { Alpha2Code.CF, new CentralAfricanRepublicCountryTranslation() },
                    { Alpha2Code.TD, new ChadCountryTranslation() },
                    { Alpha2Code.CL, new ChileCountryTranslation() },
                    { Alpha2Code.CN, new ChinaCountryTranslation() },
                    { Alpha2Code.CX, new ChristmasIslandCountryTranslation() },
                    { Alpha2Code.CC, new CocosIslandsCountryTranslation() },
                    { Alpha2Code.CO, new ColombiaCountryTranslation() },
                    { Alpha2Code.KM, new ComorosCountryTranslation() },
                    { Alpha2Code.CD, new CongoCountryTranslation() },
                    { Alpha2Code.CK, new CookIslandsCountryTranslation() },
                    { Alpha2Code.CR, new CostaRicaCountryTranslation() },
                    { Alpha2Code.HR, new CroatiaCountryTranslation() },
                    { Alpha2Code.CU, new CubaCountryTranslation() },
                    { Alpha2Code.CW, new CuracaoCountryTranslation() },
                    { Alpha2Code.CY, new CyprusCountryTranslation() },
                    { Alpha2Code.CZ, new CzechRepublicCountryTranslation() },
                    { Alpha2Code.DK, new DenmarkCountryTranslation() },
                    { Alpha2Code.DJ, new DjiboutiCountryTranslation() },
                    { Alpha2Code.DM, new DominicaCountryTranslation() },
                    { Alpha2Code.DO, new DominicanRepublicCountryTranslation() },
                    { Alpha2Code.EC, new EcuadorCountryTranslation() },
                    { Alpha2Code.EG, new EgyptCountryTranslation() },
                    { Alpha2Code.SV, new ElSalvadorCountryTranslation() },
                    { Alpha2Code.GQ, new EquatorialGuineaCountryTranslation() },
                    { Alpha2Code.ER, new EritreaCountryTranslation() },
                    { Alpha2Code.EE, new EstoniaCountryTranslation() },
                    { Alpha2Code.ET, new EthiopiaCountryTranslation() },
                    { Alpha2Code.FK, new FalklandIslandsCountryTranslation() },
                    { Alpha2Code.FO, new FaroeIslandsCountryTranslation() },
                    { Alpha2Code.FJ, new FijiCountryTranslation() },
                    { Alpha2Code.FI, new FinlandCountryTranslation() },
                    { Alpha2Code.FR, new FranceCountryTranslation() },
                    { Alpha2Code.GF, new FrenchGuianaCountryTranslation() },
                    { Alpha2Code.PF, new FrenchPolynesiaCountryTranslation() },
                    { Alpha2Code.TF, new FrenchSouthernAndAntarcticLandsCountryTranslation() },
                    { Alpha2Code.GA, new GabonCountryTranslation() },
                    { Alpha2Code.GM, new GambiaCountryTranslation() },
                    { Alpha2Code.GE, new GeorgiaCountryTranslation() },
                    { Alpha2Code.DE, new GermanyCountryTranslation() },
                    { Alpha2Code.GH, new GhanaCountryTranslation() },
                    { Alpha2Code.GI, new GibraltarCountryTranslation() },
                    { Alpha2Code.GR, new GreeceCountryTranslation() },
                    { Alpha2Code.GL, new GreenlandCountryTranslation() },
                    { Alpha2Code.GD, new GrenadaCountryTranslation() },
                    { Alpha2Code.GP, new GuadeloupeCountryTranslation() },
                    { Alpha2Code.GU, new GuamCountryTranslation() },
                    { Alpha2Code.GT, new GuatemalaCountryTranslation() },
                    { Alpha2Code.GG, new GuernseyCountryTranslation() },
                    { Alpha2Code.GW, new GuineaBissauCountryTranslation() },
                    { Alpha2Code.GN, new GuineaCountryTranslation() },
                    { Alpha2Code.GY, new GuyanaCountryTranslation() },
                    { Alpha2Code.HT, new HaitiCountryTranslation() },
                    { Alpha2Code.HM, new HeardIslandAndMcDonaldIslandsCountryTranslation() },
                    { Alpha2Code.HN, new HondurasCountryTranslation() },
                    { Alpha2Code.HK, new HongKongCountryTranslation() },
                    { Alpha2Code.HU, new HungaryCountryTranslation() },
                    { Alpha2Code.IS, new IcelandCountryTranslation() },
                    { Alpha2Code.IN, new IndiaCountryTranslation() },
                    { Alpha2Code.ID, new IndonesiaCountryTranslation() },
                    { Alpha2Code.IR, new IranCountryTranslation() },
                    { Alpha2Code.IQ, new IraqCountryTranslation() },
                    { Alpha2Code.IE, new IrelandCountryTranslation() },
                    { Alpha2Code.IM, new IsleofManCountryTranslation() },
                    { Alpha2Code.IL, new IsraelCountryTranslation() },
                    { Alpha2Code.IT, new ItalyCountryTranslation() },
                    { Alpha2Code.CI, new IvoryCoastCountryTranslation() },
                    { Alpha2Code.JM, new JamaicaCountryTranslation() },
                    { Alpha2Code.JP, new JapanCountryTranslation() },
                    { Alpha2Code.JE, new JerseyCountryTranslation() },
                    { Alpha2Code.JO, new JordanCountryTranslation() },
                    { Alpha2Code.KZ, new KazakhstanCountryTranslation() },
                    { Alpha2Code.KE, new KenyaCountryTranslation() },
                    { Alpha2Code.KI, new KiribatiCountryTranslation() },
                    { Alpha2Code.XK, new KosovoCountryTranslation() },
                    { Alpha2Code.KW, new KuwaitCountryTranslation() },
                    { Alpha2Code.KG, new KyrgyzstanCountryTranslation() },
                    { Alpha2Code.LA, new LaosCountryTranslation() },
                    { Alpha2Code.LV, new LatviaCountryTranslation() },
                    { Alpha2Code.LB, new LebanonCountryTranslation() },
                    { Alpha2Code.LS, new LesothoCountryTranslation() },
                    { Alpha2Code.LR, new LiberiaCountryTranslation() },
                    { Alpha2Code.LY, new LibyaCountryTranslation() },
                    { Alpha2Code.LI, new LiechtensteinCountryTranslation() },
                    { Alpha2Code.LT, new LithuaniaCountryTranslation() },
                    { Alpha2Code.LU, new LuxembourgCountryTranslation() },
                    { Alpha2Code.MO, new MacauCountryTranslation() },
                    { Alpha2Code.MG, new MadagascarCountryTranslation() },
                    { Alpha2Code.MW, new MalawiCountryTranslation() },
                    { Alpha2Code.MY, new MalaysiaCountryTranslation() },
                    { Alpha2Code.MV, new MaldivesCountryTranslation() },
                    { Alpha2Code.ML, new MaliCountryTranslation() },
                    { Alpha2Code.MT, new MaltaCountryTranslation() },
                    { Alpha2Code.MH, new MarshallIslandsCountryTranslation() },
                    { Alpha2Code.MQ, new MartiniqueCountryTranslation() },
                    { Alpha2Code.MR, new MauritaniaCountryTranslation() },
                    { Alpha2Code.MU, new MauritiusCountryTranslation() },
                    { Alpha2Code.YT, new MayotteCountryTranslation() },
                    { Alpha2Code.MX, new MexicoCountryTranslation() },
                    { Alpha2Code.FM, new MicronesiaCountryTranslation() },
                    { Alpha2Code.MD, new MoldovaCountryTranslation() },
                    { Alpha2Code.MC, new MonacoCountryTranslation() },
                    { Alpha2Code.MN, new MongoliaCountryTranslation() },
                    { Alpha2Code.ME, new MontenegroCountryTranslation() },
                    { Alpha2Code.MS, new MontserratCountryTranslation() },
                    { Alpha2Code.MA, new MoroccoCountryTranslation() },
                    { Alpha2Code.MZ, new MozambiqueCountryTranslation() },
                    { Alpha2Code.MM, new MyanmarCountryTranslation() },
                    { Alpha2Code.NA, new NamibiaCountryTranslation() },
                    { Alpha2Code.NR, new NauruCountryTranslation() },
                    { Alpha2Code.NP, new NepalCountryTranslation() },
                    { Alpha2Code.NL, new NetherlandsCountryTranslation() },
                    { Alpha2Code.NC, new NewCaledoniaCountryTranslation() },
                    { Alpha2Code.NZ, new NewZealandCountryTranslation() },
                    { Alpha2Code.NI, new NicaraguaCountryTranslation() },
                    { Alpha2Code.NG, new NigeriaCountryTranslation() },
                    { Alpha2Code.NE, new NigerCountryTranslation() },
                    { Alpha2Code.NU, new NiueCountryTranslation() },
                    { Alpha2Code.NF, new NorfolkIslandCountryTranslation() },
                    { Alpha2Code.MP, new NorthernMarianaIslandsCountryTranslation() },
                    { Alpha2Code.KP, new NorthKoreaCountryTranslation() },
                    { Alpha2Code.MK, new NorthMacedoniaCountryTranslation() },
                    { Alpha2Code.NO, new NorwayCountryTranslation() },
                    { Alpha2Code.OM, new OmanCountryTranslation() },
                    { Alpha2Code.PK, new PakistanCountryTranslation() },
                    { Alpha2Code.PW, new PalauCountryTranslation() },
                    { Alpha2Code.PS, new PalestineCountryTranslation() },
                    { Alpha2Code.PA, new PanamaCountryTranslation() },
                    { Alpha2Code.PG, new PapuaNewGuineaCountryTranslation() },
                    { Alpha2Code.PY, new ParaguayCountryTranslation() },
                    { Alpha2Code.PE, new PeruCountryTranslation() },
                    { Alpha2Code.PH, new PhilippinesCountryTranslation() },
                    { Alpha2Code.PN, new PitcairnIslandsCountryTranslation() },
                    { Alpha2Code.PL, new PolandCountryTranslation() },
                    { Alpha2Code.PT, new PortugalCountryTranslation() },
                    { Alpha2Code.PR, new PuertoRicoCountryTranslation() },
                    { Alpha2Code.QA, new QatarCountryTranslation() },
                    { Alpha2Code.CG, new RepublicOfTheCongoCountryTranslation() },
                    { Alpha2Code.RE, new ReunionCountryTranslation() },
                    { Alpha2Code.RO, new RomaniaCountryTranslation() },
                    { Alpha2Code.RU, new RussiaCountryTranslation() },
                    { Alpha2Code.RW, new RwandaCountryTranslation() },
                    { Alpha2Code.BL, new SaintBarthelemyCountryTranslation() },
                    { Alpha2Code.SH, new SaintHelenaCountryTranslation() },
                    { Alpha2Code.KN, new SaintKittsAndNevisCountryTranslation() },
                    { Alpha2Code.LC, new SaintLuciaCountryTranslation() },
                    { Alpha2Code.MF, new SaintMartinCountryTranslation() },
                    { Alpha2Code.PM, new SaintPierreAndMiquelonCountryTranslation() },
                    { Alpha2Code.VC, new SaintVincentAndTheGrenadinesCountryTranslation() },
                    { Alpha2Code.WS, new SamoaCountryTranslation() },
                    { Alpha2Code.SM, new SanMarinoCountryTranslation() },
                    { Alpha2Code.ST, new SaoTomeAndPrincipeCountryTranslation() },
                    { Alpha2Code.SA, new SaudiArabiaCountryTranslation() },
                    { Alpha2Code.SN, new SenegalCountryTranslation() },
                    { Alpha2Code.RS, new SerbiaCountryTranslation() },
                    { Alpha2Code.SC, new SeychellesCountryTranslation() },
                    { Alpha2Code.SL, new SierraLeoneCountryTranslation() },
                    { Alpha2Code.SG, new SingaporeCountryTranslation() },
                    { Alpha2Code.SX, new SintMaartenCountryTranslation() },
                    { Alpha2Code.SK, new SlovakiaCountryTranslation() },
                    { Alpha2Code.SI, new SloveniaCountryTranslation() },
                    { Alpha2Code.SB, new SolomonIslandsCountryTranslation() },
                    { Alpha2Code.SO, new SomaliaCountryTranslation() },
                    { Alpha2Code.ZA, new SouthAfricaCountryTranslation() },
                    { Alpha2Code.GS, new SouthGeorgiaCountryTranslation() },
                    { Alpha2Code.KR, new SouthKoreaCountryTranslation() },
                    { Alpha2Code.SS, new SouthSudanCountryTranslation() },
                    { Alpha2Code.ES, new SpainCountryTranslation() },
                    { Alpha2Code.LK, new SriLankaCountryTranslation() },
                    { Alpha2Code.SD, new SudanCountryTranslation() },
                    { Alpha2Code.SR, new SurinameCountryTranslation() },
                    { Alpha2Code.SJ, new SvalbardAndJanMayenCountryTranslation() },
                    { Alpha2Code.SZ, new SwazilandCountryTranslation() },
                    { Alpha2Code.SE, new SwedenCountryTranslation() },
                    { Alpha2Code.CH, new SwitzerlandCountryTranslation() },
                    { Alpha2Code.SY, new SyriaCountryTranslation() },
                    { Alpha2Code.TW, new TaiwanCountryTranslation() },
                    { Alpha2Code.TJ, new TajikistanCountryTranslation() },
                    { Alpha2Code.TZ, new TanzaniaCountryTranslation() },
                    { Alpha2Code.TH, new ThailandCountryTranslation() },
                    { Alpha2Code.TL, new TimorLesteCountryTranslation() },
                    { Alpha2Code.TG, new TogoCountryTranslation() },
                    { Alpha2Code.TK, new TokelauCountryTranslation() },
                    { Alpha2Code.TO, new TongaCountryTranslation() },
                    { Alpha2Code.TT, new TrinidadAndTobagoCountryTranslation() },
                    { Alpha2Code.TN, new TunisiaCountryTranslation() },
                    { Alpha2Code.TR, new TurkeyCountryTranslation() },
                    { Alpha2Code.TM, new TurkmenistanCountryTranslation() },
                    { Alpha2Code.TC, new TurksAndCaicosIslandsCountryTranslation() },
                    { Alpha2Code.TV, new TuvaluCountryTranslation() },
                    { Alpha2Code.UG, new UgandaCountryTranslation() },
                    { Alpha2Code.UA, new UkraineCountryTranslation() },
                    { Alpha2Code.AE, new UnitedArabEmiratesCountryTranslation() },
                    { Alpha2Code.GB, new UnitedKingdomCountryTranslation() },
                    { Alpha2Code.US, new UnitedStatesCountryTranslation() },
                    { Alpha2Code.UM, new UnitedStatesMinorOutlyingIslandsCountryTranslation() },
                    { Alpha2Code.VI, new UnitedStatesVirginIslandsCountryTranslation() },
                    { Alpha2Code.UY, new UruguayCountryTranslation() },
                    { Alpha2Code.UZ, new UzbekistanCountryTranslation() },
                    { Alpha2Code.VU, new VanuatuCountryTranslation() },
                    { Alpha2Code.VA, new VaticanCityCountryTranslation() },
                    { Alpha2Code.VE, new VenezuelaCountryTranslation() },
                    { Alpha2Code.VN, new VietnamCountryTranslation() },
                    { Alpha2Code.WF, new WallisAndFutunaCountryTranslation() },
                    { Alpha2Code.EH, new WesternSaharaCountryTranslation() },
                    { Alpha2Code.YE, new YemenCountryTranslation() },
                    { Alpha2Code.ZM, new ZambiaCountryTranslation() },
                    { Alpha2Code.ZW, new ZimbabweCountryTranslation() },
                }
            );

            #endregion
        }

        /// <inheritdoc/>
        public IEnumerable<ILanguageTranslation> GetLanguages()
        {
            return this._languageCode2LanguageTranslation.Values;
        }

        /// <inheritdoc/>
        public ILanguageTranslation? GetLanguage(string languageCode)
        {
            if (Enum.TryParse(languageCode, true, out LanguageCode languageCodeParsed))
            {
                return this.GetLanguage(languageCodeParsed);
            }

            return null;
        }

        /// <inheritdoc/>
        public ILanguageTranslation? GetLanguage(LanguageCode languageCode)
        {
            if (this._languageCode2LanguageTranslation.TryGetValue(languageCode, out ILanguageTranslation? languageInfo))
            {
                return languageInfo;
            }

            return null;
        }

        /// <inheritdoc/>
        public ICountryTranslation? GetCountryTranslation(Alpha2Code alpha2Code)
        {
            if (this._alpha2Code2CountryTranslation.TryGetValue(alpha2Code, out ICountryTranslation? countryTranslation))
            {
                return countryTranslation;
            }

            return null;
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(Alpha2Code alpha2Code, LanguageCode languageCode)
        {
            var countryInfo = this._countryProvider.GetCountry(alpha2Code);
            return this.GetCountryTranslatedName(countryInfo, languageCode);
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(Alpha2Code alpha2Code, string languageCode)
        {
            if (Enum.TryParse(languageCode, true, out LanguageCode code))
            {
                return this.GetCountryTranslatedName(alpha2Code, code);
            }

            return null;
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(Alpha3Code alpha3Code, LanguageCode languageCode)
        {
            var countryInfo = this._countryProvider.GetCountry(alpha3Code);
            return this.GetCountryTranslatedName(countryInfo, languageCode);
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(Alpha3Code alpha3Code, string languageCode)
        {
            if (Enum.TryParse(languageCode, true, out LanguageCode code))
            {
                return this.GetCountryTranslatedName(alpha3Code, code);
            }

            return null;
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(string alpha2or3Code, LanguageCode languageCode)
        {
            var countryInfo = this._countryProvider.GetCountry(alpha2or3Code);
            return this.GetCountryTranslatedName(countryInfo, languageCode);
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(string alpha2or3Code, string languageCode)
        {
            if (Enum.TryParse(languageCode, true, out LanguageCode code))
            {
                return this.GetCountryTranslatedName(alpha2or3Code, code);
            }

            return null;
        }

        private string? GetCountryTranslatedName(ICountryInfo countryInfo, LanguageCode languageCode)
        {
            if (!this._alpha2Code2CountryTranslation.TryGetValue(countryInfo.Alpha2Code, out var countryTranslation))
            {
                return null;
            }

            if (countryTranslation.Translations is not null && countryTranslation.Translations.Length > 0)
            {
                return countryTranslation.Translations.Where(x => x.LanguageCode == languageCode).Select(x => x.Name).FirstOrDefault();
            }

            return null;
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(string alpha2or3Code, CultureInfo culture)
        {
            return this.GetCountryTranslatedName(alpha2or3Code, culture.TwoLetterISOLanguageName);
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(Alpha2Code alpha2Code, CultureInfo culture)
        {
            return this.GetCountryTranslatedName(alpha2Code, culture.TwoLetterISOLanguageName);
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(Alpha3Code alpha3Code, CultureInfo culture)
        {
            return this.GetCountryTranslatedName(alpha3Code, culture.TwoLetterISOLanguageName);
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(string alpha2or3Code, CultureInfo culture, LanguageCode defaultLanguageCode)
        {
            var name = this.GetCountryTranslatedName(alpha2or3Code, culture);
            if (string.IsNullOrWhiteSpace(name))
            {
                name = this.GetCountryTranslatedName(alpha2or3Code, defaultLanguageCode);
            }
            return name;
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(Alpha2Code alpha2Code, CultureInfo culture, LanguageCode defaultLanguageCode)
        {
            var name = this.GetCountryTranslatedName(alpha2Code, culture);
            if (string.IsNullOrWhiteSpace(name))
            {
                name = this.GetCountryTranslatedName(alpha2Code, defaultLanguageCode);
            }
            return name;
        }

        /// <inheritdoc/>
        public string? GetCountryTranslatedName(Alpha3Code alpha3Code, CultureInfo culture, LanguageCode defaultLanguageCode)
        {
            var name = this.GetCountryTranslatedName(alpha3Code, culture);
            if (string.IsNullOrWhiteSpace(name))
            {
                name = this.GetCountryTranslatedName(alpha3Code, defaultLanguageCode);
            }
            return name;
        }
    }
}