using Nager.Country.Translation.CountryTranslations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Nager.Country.Translation
{
    public class TranslationProvider : ITranslationProvider
    {
        private readonly Dictionary<LanguageCode, ILanguageTranslation> _languageCode2LanguageTranslation = new Dictionary<LanguageCode, ILanguageTranslation>();
        private readonly Dictionary<Alpha2Code, ICountryTranslation> _alpha2Code2CountryTranslation = new Dictionary<Alpha2Code, ICountryTranslation>();

        private readonly ICountryProvider _countryProvider;

        /// <inheritdoc/>
        public TranslationProvider()
        {
            this._countryProvider = new CountryProvider();

            var interfaceType = typeof(ILanguageTranslation);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetLoadableTypes())
                .Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass);

            foreach (var type in types)
            {
                var languageTranslation = (ILanguageTranslation)Activator.CreateInstance(type);
                this._languageCode2LanguageTranslation.Add(languageTranslation.LanguageCode, languageTranslation);
            }

            #region Country translation

            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AF, new AfghanistanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AX, new AlandIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AL, new AlbaniaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.DZ, new AlgeriaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AS, new AmericanSamoaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AD, new AndorraCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AO, new AngolaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AI, new AnguillaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AQ, new AntarcticaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AG, new AntiguaAndBarbudaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AR, new ArgentinaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AM, new ArmeniaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AW, new ArubaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AU, new AustraliaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AT, new AustriaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AZ, new AzerbaijanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BS, new BahamasCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BH, new BahrainCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BD, new BangladeshCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BB, new BarbadosCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BY, new BelarusCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BE, new BelgiumCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BZ, new BelizeCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BJ, new BeninCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BM, new BermudaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BT, new BhutanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BO, new BoliviaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BA, new BosniaandHerzegovinaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BW, new BotswanaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BV, new BouvetIslandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BR, new BrazilCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.IO, new BritishIndianOceanTerritoryCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.VG, new BritishVirginIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BN, new BruneiCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BG, new BulgariaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BF, new BurkinaFasoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BI, new BurundiCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.KH, new CambodiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CM, new CameroonCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CA, new CanadaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CV, new CapeVerdeCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BQ, new CaribbeanNetherlandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.KY, new CaymanIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CF, new CentralAfricanRepublicCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TD, new ChadCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CL, new ChileCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CN, new ChinaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CX, new ChristmasIslandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CC, new CocosIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CO, new ColombiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.KM, new ComorosCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CD, new CongoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CK, new CookIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CR, new CostaRicaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.HR, new CroatiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CU, new CubaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CW, new CuracaoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CY, new CyprusCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CZ, new CzechRepublicCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.DK, new DenmarkCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.DJ, new DjiboutiCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.DM, new DominicaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.DO, new DominicanRepublicCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.EC, new EcuadorCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.EG, new EgyptCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SV, new ElSalvadorCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GQ, new EquatorialGuineaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.ER, new EritreaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.EE, new EstoniaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.ET, new EthiopiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.FK, new FalklandIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.FO, new FaroeIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.FJ, new FijiCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.FI, new FinlandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.FR, new FranceCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GF, new FrenchGuianaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PF, new FrenchPolynesiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TF, new FrenchSouthernAndAntarcticLandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GA, new GabonCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GM, new GambiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GE, new GeorgiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.DE, new GermanyCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GH, new GhanaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GI, new GibraltarCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GR, new GreeceCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GL, new GreenlandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GD, new GrenadaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GP, new GuadeloupeCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GU, new GuamCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GT, new GuatemalaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GG, new GuernseyCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GW, new GuineaBissauCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GN, new GuineaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GY, new GuyanaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.HT, new HaitiCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.HM, new HeardIslandAndMcDonaldIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.HN, new HondurasCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.HK, new HongKongCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.HU, new HungaryCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.IS, new IcelandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.IN, new IndiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.ID, new IndonesiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.IR, new IranCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.IQ, new IraqCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.IE, new IrelandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.IM, new IsleofManCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.IL, new IsraelCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.IT, new ItalyCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CI, new IvoryCoastCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.JM, new JamaicaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.JP, new JapanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.JE, new JerseyCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.JO, new JordanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.KZ, new KazakhstanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.KE, new KenyaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.KI, new KiribatiCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.KW, new KuwaitCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.KG, new KyrgyzstanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.LA, new LaosCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.LV, new LatviaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.LB, new LebanonCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.LS, new LesothoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.LR, new LiberiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.LY, new LibyaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.LI, new LiechtensteinCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.LT, new LithuaniaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.LU, new LuxembourgCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MO, new MacauCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MG, new MadagascarCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MW, new MalawiCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MY, new MalaysiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MV, new MaldivesCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.ML, new MaliCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MT, new MaltaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MH, new MarshallIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MQ, new MartiniqueCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MR, new MauritaniaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MU, new MauritiusCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.YT, new MayotteCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MX, new MexicoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.FM, new MicronesiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MD, new MoldovaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MC, new MonacoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MN, new MongoliaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.ME, new MontenegroCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MS, new MontserratCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MA, new MoroccoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MZ, new MozambiqueCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MM, new MyanmarCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NA, new NamibiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NR, new NauruCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NP, new NepalCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NL, new NetherlandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NC, new NewCaledoniaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NZ, new NewZealandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NI, new NicaraguaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NG, new NigeriaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NE, new NigerCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NU, new NiueCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NF, new NorfolkIslandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MP, new NorthernMarianaIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.KP, new NorthKoreaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MK, new NorthMacedoniaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.NO, new NorwayCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.OM, new OmanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PK, new PakistanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PW, new PalauCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PS, new PalestineCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PA, new PanamaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PG, new PapuaNewGuineaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PY, new ParaguayCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PE, new PeruCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PH, new PhilippinesCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PN, new PitcairnIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PL, new PolandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PT, new PortugalCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PR, new PuertoRicoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.QA, new QatarCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CG, new RepublicOfTheCongoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.RE, new ReunionCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.RO, new RomaniaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.RU, new RussiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.RW, new RwandaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.BL, new SaintBarthelemyCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SH, new SaintHelenaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.KN, new SaintKittsAndNevisCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.LC, new SaintLuciaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.MF, new SaintMartinCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.PM, new SaintPierreAndMiquelonCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.VC, new SaintVincentAndTheGrenadinesCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.WS, new SamoaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SM, new SanMarinoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.ST, new SaoTomeAndPrincipeCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SA, new SaudiArabiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SN, new SenegalCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.RS, new SerbiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SC, new SeychellesCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SL, new SierraLeoneCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SG, new SingaporeCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SX, new SintMaartenCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SK, new SlovakiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SI, new SloveniaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SB, new SolomonIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SO, new SomaliaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.ZA, new SouthAfricaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GS, new SouthGeorgiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.KR, new SouthKoreaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SS, new SouthSudanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.ES, new SpainCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.LK, new SriLankaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SD, new SudanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SR, new SurinameCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SJ, new SvalbardAndJanMayenCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SZ, new SwazilandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SE, new SwedenCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.CH, new SwitzerlandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.SY, new SyriaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TW, new TaiwanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TJ, new TajikistanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TZ, new TanzaniaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TH, new ThailandCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TL, new TimorLesteCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TG, new TogoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TK, new TokelauCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TO, new TongaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TT, new TrinidadAndTobagoCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TN, new TunisiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TR, new TurkeyCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TM, new TurkmenistanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TC, new TurksAndCaicosIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.TV, new TuvaluCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.UG, new UgandaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.UA, new UkraineCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.AE, new UnitedArabEmiratesCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.GB, new UnitedKingdomCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.US, new UnitedStatesCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.UM, new UnitedStatesMinorOutlyingIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.VI, new UnitedStatesVirginIslandsCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.UY, new UruguayCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.UZ, new UzbekistanCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.VU, new VanuatuCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.VA, new VaticanCityCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.VE, new VenezuelaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.VN, new VietnamCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.WF, new WallisAndFutunaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.EH, new WesternSaharaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.YE, new YemenCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.ZM, new ZambiaCountryTranslation());
            this._alpha2Code2CountryTranslation.Add(Alpha2Code.ZW, new ZimbabweCountryTranslation());

            #endregion
        }

        public IEnumerable<ILanguageTranslation> GetLanguages()
        {
            return this._languageCode2LanguageTranslation.Values;
        }

        public ILanguageTranslation GetLanguage(string languageCode)
        {
            if (Enum.TryParse(languageCode, true, out LanguageCode languageCodeParsed))
            {
                return this.GetLanguage(languageCodeParsed);
            }

            return null;
        }

        public ILanguageTranslation GetLanguage(LanguageCode languageCode)
        {
            if (this._languageCode2LanguageTranslation.TryGetValue(languageCode, out ILanguageTranslation languageInfo))
            {
                return languageInfo;
            }

            return null;
        }

        public ICountryTranslation GetCountryTranslation(Alpha2Code alpha2Code)
        {
            if (this._alpha2Code2CountryTranslation.TryGetValue(alpha2Code, out ICountryTranslation countryTranslation))
            {
                return countryTranslation;
            }

            return null;
        }

        public string GetCountryTranslatedName(Alpha2Code alpha2Code, LanguageCode languageCode)
        {
            var countryInfo = this._countryProvider.GetCountry(alpha2Code);
            return this.GetCountryTranslatedName(countryInfo, languageCode);
        }

        public string GetCountryTranslatedName(Alpha2Code alpha2Code, string languageCode)
        {
            if (Enum.TryParse(languageCode, true, out LanguageCode code))
            {
                return this.GetCountryTranslatedName(alpha2Code, code);
            }

            return null;
        }

        public string GetCountryTranslatedName(Alpha3Code alpha3Code, LanguageCode languageCode)
        {
            var countryInfo = this._countryProvider.GetCountry(alpha3Code);
            return this.GetCountryTranslatedName(countryInfo, languageCode);
        }

        public string GetCountryTranslatedName(Alpha3Code alpha3Code, string languageCode)
        {
            if (Enum.TryParse(languageCode, true, out LanguageCode code))
            {
                return this.GetCountryTranslatedName(alpha3Code, code);
            }

            return null;
        }

        public string GetCountryTranslatedName(string alpha2or3Code, LanguageCode languageCode)
        {
            var countryInfo = this._countryProvider.GetCountry(alpha2or3Code);
            return this.GetCountryTranslatedName(countryInfo, languageCode);
        }

        public string GetCountryTranslatedName(string alpha2or3Code, string languageCode)
        {
            if (Enum.TryParse(languageCode, true, out LanguageCode code))
            {
                return this.GetCountryTranslatedName(alpha2or3Code, code);
            }

            return null;
        }

        private string GetCountryTranslatedName(ICountryInfo countryInfo, LanguageCode languageCode)
        {
            this._alpha2Code2CountryTranslation.TryGetValue(countryInfo.Alpha2Code, out var countryTranslation);

            if (countryTranslation.Translations != null && countryTranslation.Translations.Length > 0)
            {
                return countryTranslation.Translations.Where(x => x.LanguageCode == languageCode).Select(x => x.Name).FirstOrDefault();
            }

            return null;
        }

        public string GetCountryTranslatedName(string alpha2or3Code, CultureInfo culture)
        {
            return this.GetCountryTranslatedName(alpha2or3Code, culture.TwoLetterISOLanguageName);
        }

        public string GetCountryTranslatedName(Alpha2Code alpha2Code, CultureInfo culture)
        {
            return this.GetCountryTranslatedName(alpha2Code, culture.TwoLetterISOLanguageName);
        }

        public string GetCountryTranslatedName(Alpha3Code alpha3Code, CultureInfo culture)
        {
            return this.GetCountryTranslatedName(alpha3Code, culture.TwoLetterISOLanguageName);
        }

        public string GetCountryTranslatedName(string alpha2or3Code, CultureInfo culture, LanguageCode defaultLanguageCode)
        {
            var name = this.GetCountryTranslatedName(alpha2or3Code, culture);
            if (string.IsNullOrWhiteSpace(name))
            {
                name = this.GetCountryTranslatedName(alpha2or3Code, defaultLanguageCode);
            }
            return name;
        }

        public string GetCountryTranslatedName(Alpha2Code alpha2Code, CultureInfo culture, LanguageCode defaultLanguageCode)
        {
            var name = this.GetCountryTranslatedName(alpha2Code, culture);
            if (string.IsNullOrWhiteSpace(name))
            {
                name = this.GetCountryTranslatedName(alpha2Code, defaultLanguageCode);
            }
            return name;
        }

        public string GetCountryTranslatedName(Alpha3Code alpha3Code, CultureInfo culture, LanguageCode defaultLanguageCode)
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