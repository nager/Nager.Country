using Nager.Country.CountryInfos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Nager.Country
{
    /// <summary>
    /// CountryProvider
    /// </summary>
    public class CountryProvider : ICountryProvider
    {
        private readonly ReadOnlyDictionary<Alpha2Code, ICountryInfo> _alpha2Code2CountryInfo;
        private readonly ReadOnlyDictionary<Alpha3Code, ICountryInfo> _alpha3Code2CountryInfo;

        /// <summary>
        /// CountryProvider
        /// </summary>
        public CountryProvider()
        {
            #region Alpha2Code mapping

            this._alpha2Code2CountryInfo = new(
                new Dictionary<Alpha2Code, ICountryInfo>()
                {
                    { Alpha2Code.AD, new AndorraCountryInfo() },
                    { Alpha2Code.AE, new UnitedArabEmiratesCountryInfo() },
                    { Alpha2Code.AF, new AfghanistanCountryInfo() },
                    { Alpha2Code.AG, new AntiguaAndBarbudaCountryInfo() },
                    { Alpha2Code.AI, new AnguillaCountryInfo() },
                    { Alpha2Code.AL, new AlbaniaCountryInfo() },
                    { Alpha2Code.AM, new ArmeniaCountryInfo() },
                    { Alpha2Code.AO, new AngolaCountryInfo() },
                    { Alpha2Code.AQ, new AntarcticaCountryInfo() },
                    { Alpha2Code.AR, new ArgentinaCountryInfo() },
                    { Alpha2Code.AS, new AmericanSamoaCountryInfo() },
                    { Alpha2Code.AT, new AustriaCountryInfo() },
                    { Alpha2Code.AU, new AustraliaCountryInfo() },
                    { Alpha2Code.AW, new ArubaCountryInfo() },
                    { Alpha2Code.AX, new AlandIslandsCountryInfo() },
                    { Alpha2Code.AZ, new AzerbaijanCountryInfo() },
                    { Alpha2Code.BA, new BosniaandHerzegovinaCountryInfo() },
                    { Alpha2Code.BB, new BarbadosCountryInfo() },
                    { Alpha2Code.BD, new BangladeshCountryInfo() },
                    { Alpha2Code.BE, new BelgiumCountryInfo() },
                    { Alpha2Code.BF, new BurkinaFasoCountryInfo() },
                    { Alpha2Code.BG, new BulgariaCountryInfo() },
                    { Alpha2Code.BH, new BahrainCountryInfo() },
                    { Alpha2Code.BI, new BurundiCountryInfo() },
                    { Alpha2Code.BJ, new BeninCountryInfo() },
                    { Alpha2Code.BL, new SaintBarthelemyCountryInfo() },
                    { Alpha2Code.BM, new BermudaCountryInfo() },
                    { Alpha2Code.BN, new BruneiCountryInfo() },
                    { Alpha2Code.BO, new BoliviaCountryInfo() },
                    { Alpha2Code.BQ, new CaribbeanNetherlandsCountryInfo() },
                    { Alpha2Code.BR, new BrazilCountryInfo() },
                    { Alpha2Code.BS, new BahamasCountryInfo() },
                    { Alpha2Code.BT, new BhutanCountryInfo() },
                    { Alpha2Code.BV, new BouvetIslandCountryInfo() },
                    { Alpha2Code.BW, new BotswanaCountryInfo() },
                    { Alpha2Code.BY, new BelarusCountryInfo() },
                    { Alpha2Code.BZ, new BelizeCountryInfo() },
                    { Alpha2Code.CA, new CanadaCountryInfo() },
                    { Alpha2Code.CC, new CocosIslandsCountryInfo() },
                    { Alpha2Code.CD, new CongoCountryInfo() },
                    { Alpha2Code.CF, new CentralAfricanRepublicCountryInfo() },
                    { Alpha2Code.CG, new RepublicOfTheCongoCountryInfo() },
                    { Alpha2Code.CH, new SwitzerlandCountryInfo() },
                    { Alpha2Code.CI, new IvoryCoastCountryInfo() },
                    { Alpha2Code.CK, new CookIslandsCountryInfo() },
                    { Alpha2Code.CL, new ChileCountryInfo() },
                    { Alpha2Code.CM, new CameroonCountryInfo() },
                    { Alpha2Code.CN, new ChinaCountryInfo() },
                    { Alpha2Code.CO, new ColombiaCountryInfo() },
                    { Alpha2Code.CR, new CostaRicaCountryInfo() },
                    { Alpha2Code.CU, new CubaCountryInfo() },
                    { Alpha2Code.CV, new CapeVerdeCountryInfo() },
                    { Alpha2Code.CW, new CuracaoCountryInfo() },
                    { Alpha2Code.CX, new ChristmasIslandCountryInfo() },
                    { Alpha2Code.CY, new CyprusCountryInfo() },
                    { Alpha2Code.CZ, new CzechRepublicCountryInfo() },
                    { Alpha2Code.DE, new GermanyCountryInfo() },
                    { Alpha2Code.DJ, new DjiboutiCountryInfo() },
                    { Alpha2Code.DK, new DenmarkCountryInfo() },
                    { Alpha2Code.DM, new DominicaCountryInfo() },
                    { Alpha2Code.DO, new DominicanRepublicCountryInfo() },
                    { Alpha2Code.DZ, new AlgeriaCountryInfo() },
                    { Alpha2Code.EC, new EcuadorCountryInfo() },
                    { Alpha2Code.EE, new EstoniaCountryInfo() },
                    { Alpha2Code.EG, new EgyptCountryInfo() },
                    { Alpha2Code.EH, new WesternSaharaCountryInfo() },
                    { Alpha2Code.ER, new EritreaCountryInfo() },
                    { Alpha2Code.ES, new SpainCountryInfo() },
                    { Alpha2Code.ET, new EthiopiaCountryInfo() },
                    { Alpha2Code.FI, new FinlandCountryInfo() },
                    { Alpha2Code.FJ, new FijiCountryInfo() },
                    { Alpha2Code.FK, new FalklandIslandsCountryInfo() },
                    { Alpha2Code.FM, new MicronesiaCountryInfo() },
                    { Alpha2Code.FO, new FaroeIslandsCountryInfo() },
                    { Alpha2Code.FR, new FranceCountryInfo() },
                    { Alpha2Code.GA, new GabonCountryInfo() },
                    { Alpha2Code.GB, new UnitedKingdomCountryInfo() },
                    { Alpha2Code.GD, new GrenadaCountryInfo() },
                    { Alpha2Code.GE, new GeorgiaCountryInfo() },
                    { Alpha2Code.GF, new FrenchGuianaCountryInfo() },
                    { Alpha2Code.GG, new GuernseyCountryInfo() },
                    { Alpha2Code.GH, new GhanaCountryInfo() },
                    { Alpha2Code.GI, new GibraltarCountryInfo() },
                    { Alpha2Code.GL, new GreenlandCountryInfo() },
                    { Alpha2Code.GM, new GambiaCountryInfo() },
                    { Alpha2Code.GN, new GuineaCountryInfo() },
                    { Alpha2Code.GP, new GuadeloupeCountryInfo() },
                    { Alpha2Code.GQ, new EquatorialGuineaCountryInfo() },
                    { Alpha2Code.GR, new GreeceCountryInfo() },
                    { Alpha2Code.GS, new SouthGeorgiaCountryInfo() },
                    { Alpha2Code.GT, new GuatemalaCountryInfo() },
                    { Alpha2Code.GU, new GuamCountryInfo() },
                    { Alpha2Code.GW, new GuineaBissauCountryInfo() },
                    { Alpha2Code.GY, new GuyanaCountryInfo() },
                    { Alpha2Code.HK, new HongKongCountryInfo() },
                    { Alpha2Code.HM, new HeardIslandAndMcDonaldIslandsCountryInfo() },
                    { Alpha2Code.HN, new HondurasCountryInfo() },
                    { Alpha2Code.HR, new CroatiaCountryInfo() },
                    { Alpha2Code.HT, new HaitiCountryInfo() },
                    { Alpha2Code.HU, new HungaryCountryInfo() },
                    { Alpha2Code.ID, new IndonesiaCountryInfo() },
                    { Alpha2Code.IE, new IrelandCountryInfo() },
                    { Alpha2Code.IL, new IsraelCountryInfo() },
                    { Alpha2Code.IM, new IsleofManCountryInfo() },
                    { Alpha2Code.IN, new IndiaCountryInfo() },
                    { Alpha2Code.IO, new BritishIndianOceanTerritoryCountryInfo() },
                    { Alpha2Code.IQ, new IraqCountryInfo() },
                    { Alpha2Code.IR, new IranCountryInfo() },
                    { Alpha2Code.IS, new IcelandCountryInfo() },
                    { Alpha2Code.IT, new ItalyCountryInfo() },
                    { Alpha2Code.JE, new JerseyCountryInfo() },
                    { Alpha2Code.JM, new JamaicaCountryInfo() },
                    { Alpha2Code.JO, new JordanCountryInfo() },
                    { Alpha2Code.JP, new JapanCountryInfo() },
                    { Alpha2Code.KE, new KenyaCountryInfo() },
                    { Alpha2Code.KG, new KyrgyzstanCountryInfo() },
                    { Alpha2Code.KH, new CambodiaCountryInfo() },
                    { Alpha2Code.KI, new KiribatiCountryInfo() },
                    { Alpha2Code.KM, new ComorosCountryInfo() },
                    { Alpha2Code.KN, new SaintKittsAndNevisCountryInfo() },
                    { Alpha2Code.KP, new NorthKoreaCountryInfo() },
                    { Alpha2Code.KR, new SouthKoreaCountryInfo() },
                    { Alpha2Code.KW, new KuwaitCountryInfo() },
                    { Alpha2Code.KY, new CaymanIslandsCountryInfo() },
                    { Alpha2Code.KZ, new KazakhstanCountryInfo() },
                    { Alpha2Code.LA, new LaosCountryInfo() },
                    { Alpha2Code.LB, new LebanonCountryInfo() },
                    { Alpha2Code.LC, new SaintLuciaCountryInfo() },
                    { Alpha2Code.LI, new LiechtensteinCountryInfo() },
                    { Alpha2Code.LK, new SriLankaCountryInfo() },
                    { Alpha2Code.LR, new LiberiaCountryInfo() },
                    { Alpha2Code.LS, new LesothoCountryInfo() },
                    { Alpha2Code.LT, new LithuaniaCountryInfo() },
                    { Alpha2Code.LU, new LuxembourgCountryInfo() },
                    { Alpha2Code.LV, new LatviaCountryInfo() },
                    { Alpha2Code.LY, new LibyaCountryInfo() },
                    { Alpha2Code.MA, new MoroccoCountryInfo() },
                    { Alpha2Code.MC, new MonacoCountryInfo() },
                    { Alpha2Code.MD, new MoldovaCountryInfo() },
                    { Alpha2Code.ME, new MontenegroCountryInfo() },
                    { Alpha2Code.MF, new SaintMartinCountryInfo() },
                    { Alpha2Code.MG, new MadagascarCountryInfo() },
                    { Alpha2Code.MH, new MarshallIslandsCountryInfo() },
                    { Alpha2Code.MK, new NorthMacedoniaCountryInfo() },
                    { Alpha2Code.ML, new MaliCountryInfo() },
                    { Alpha2Code.MM, new MyanmarCountryInfo() },
                    { Alpha2Code.MN, new MongoliaCountryInfo() },
                    { Alpha2Code.MO, new MacauCountryInfo() },
                    { Alpha2Code.MP, new NorthernMarianaIslandsCountryInfo() },
                    { Alpha2Code.MQ, new MartiniqueCountryInfo() },
                    { Alpha2Code.MR, new MauritaniaCountryInfo() },
                    { Alpha2Code.MS, new MontserratCountryInfo() },
                    { Alpha2Code.MT, new MaltaCountryInfo() },
                    { Alpha2Code.MU, new MauritiusCountryInfo() },
                    { Alpha2Code.MV, new MaldivesCountryInfo() },
                    { Alpha2Code.MW, new MalawiCountryInfo() },
                    { Alpha2Code.MX, new MexicoCountryInfo() },
                    { Alpha2Code.MY, new MalaysiaCountryInfo() },
                    { Alpha2Code.MZ, new MozambiqueCountryInfo() },
                    { Alpha2Code.NA, new NamibiaCountryInfo() },
                    { Alpha2Code.NC, new NewCaledoniaCountryInfo() },
                    { Alpha2Code.NE, new NigerCountryInfo() },
                    { Alpha2Code.NF, new NorfolkIslandCountryInfo() },
                    { Alpha2Code.NG, new NigeriaCountryInfo() },
                    { Alpha2Code.NI, new NicaraguaCountryInfo() },
                    { Alpha2Code.NL, new NetherlandsCountryInfo() },
                    { Alpha2Code.NO, new NorwayCountryInfo() },
                    { Alpha2Code.NP, new NepalCountryInfo() },
                    { Alpha2Code.NR, new NauruCountryInfo() },
                    { Alpha2Code.NU, new NiueCountryInfo() },
                    { Alpha2Code.NZ, new NewZealandCountryInfo() },
                    { Alpha2Code.OM, new OmanCountryInfo() },
                    { Alpha2Code.PA, new PanamaCountryInfo() },
                    { Alpha2Code.PE, new PeruCountryInfo() },
                    { Alpha2Code.PF, new FrenchPolynesiaCountryInfo() },
                    { Alpha2Code.PG, new PapuaNewGuineaCountryInfo() },
                    { Alpha2Code.PH, new PhilippinesCountryInfo() },
                    { Alpha2Code.PK, new PakistanCountryInfo() },
                    { Alpha2Code.PL, new PolandCountryInfo() },
                    { Alpha2Code.PM, new SaintPierreAndMiquelonCountryInfo() },
                    { Alpha2Code.PN, new PitcairnIslandsCountryInfo() },
                    { Alpha2Code.PR, new PuertoRicoCountryInfo() },
                    { Alpha2Code.PS, new PalestineCountryInfo() },
                    { Alpha2Code.PT, new PortugalCountryInfo() },
                    { Alpha2Code.PW, new PalauCountryInfo() },
                    { Alpha2Code.PY, new ParaguayCountryInfo() },
                    { Alpha2Code.QA, new QatarCountryInfo() },
                    { Alpha2Code.RE, new ReunionCountryInfo() },
                    { Alpha2Code.RO, new RomaniaCountryInfo() },
                    { Alpha2Code.RS, new SerbiaCountryInfo() },
                    { Alpha2Code.RU, new RussiaCountryInfo() },
                    { Alpha2Code.RW, new RwandaCountryInfo() },
                    { Alpha2Code.SA, new SaudiArabiaCountryInfo() },
                    { Alpha2Code.SB, new SolomonIslandsCountryInfo() },
                    { Alpha2Code.SC, new SeychellesCountryInfo() },
                    { Alpha2Code.SD, new SudanCountryInfo() },
                    { Alpha2Code.SE, new SwedenCountryInfo() },
                    { Alpha2Code.SG, new SingaporeCountryInfo() },
                    { Alpha2Code.SH, new SaintHelenaCountryInfo() },
                    { Alpha2Code.SI, new SloveniaCountryInfo() },
                    { Alpha2Code.SJ, new SvalbardAndJanMayenCountryInfo() },
                    { Alpha2Code.SK, new SlovakiaCountryInfo() },
                    { Alpha2Code.SL, new SierraLeoneCountryInfo() },
                    { Alpha2Code.SM, new SanMarinoCountryInfo() },
                    { Alpha2Code.SN, new SenegalCountryInfo() },
                    { Alpha2Code.SO, new SomaliaCountryInfo() },
                    { Alpha2Code.SR, new SurinameCountryInfo() },
                    { Alpha2Code.SS, new SouthSudanCountryInfo() },
                    { Alpha2Code.ST, new SaoTomeAndPrincipeCountryInfo() },
                    { Alpha2Code.SV, new ElSalvadorCountryInfo() },
                    { Alpha2Code.SX, new SintMaartenCountryInfo() },
                    { Alpha2Code.SY, new SyriaCountryInfo() },
                    { Alpha2Code.SZ, new SwazilandCountryInfo() },
                    { Alpha2Code.TC, new TurksAndCaicosIslandsCountryInfo() },
                    { Alpha2Code.TD, new ChadCountryInfo() },
                    { Alpha2Code.TF, new FrenchSouthernAndAntarcticLandsCountryInfo() },
                    { Alpha2Code.TG, new TogoCountryInfo() },
                    { Alpha2Code.TH, new ThailandCountryInfo() },
                    { Alpha2Code.TJ, new TajikistanCountryInfo() },
                    { Alpha2Code.TK, new TokelauCountryInfo() },
                    { Alpha2Code.TL, new TimorLesteCountryInfo() },
                    { Alpha2Code.TM, new TurkmenistanCountryInfo() },
                    { Alpha2Code.TN, new TunisiaCountryInfo() },
                    { Alpha2Code.TO, new TongaCountryInfo() },
                    { Alpha2Code.TR, new TurkeyCountryInfo() },
                    { Alpha2Code.TT, new TrinidadAndTobagoCountryInfo() },
                    { Alpha2Code.TV, new TuvaluCountryInfo() },
                    { Alpha2Code.TW, new TaiwanCountryInfo() },
                    { Alpha2Code.TZ, new TanzaniaCountryInfo() },
                    { Alpha2Code.UA, new UkraineCountryInfo() },
                    { Alpha2Code.UG, new UgandaCountryInfo() },
                    { Alpha2Code.UM, new UnitedStatesMinorOutlyingIslandsCountryInfo() },
                    { Alpha2Code.US, new UnitedStatesCountryInfo() },
                    { Alpha2Code.UY, new UruguayCountryInfo() },
                    { Alpha2Code.UZ, new UzbekistanCountryInfo() },
                    { Alpha2Code.VA, new VaticanCityCountryInfo() },
                    { Alpha2Code.VC, new SaintVincentAndTheGrenadinesCountryInfo() },
                    { Alpha2Code.VE, new VenezuelaCountryInfo() },
                    { Alpha2Code.VG, new BritishVirginIslandsCountryInfo() },
                    { Alpha2Code.VI, new UnitedStatesVirginIslandsCountryInfo() },
                    { Alpha2Code.VN, new VietnamCountryInfo() },
                    { Alpha2Code.VU, new VanuatuCountryInfo() },
                    { Alpha2Code.WF, new WallisAndFutunaCountryInfo() },
                    { Alpha2Code.WS, new SamoaCountryInfo() },
                    { Alpha2Code.XK, new KosovoCountryInfo() },
                    { Alpha2Code.YE, new YemenCountryInfo() },
                    { Alpha2Code.YT, new MayotteCountryInfo() },
                    { Alpha2Code.ZA, new SouthAfricaCountryInfo() },
                    { Alpha2Code.ZM, new ZambiaCountryInfo() },
                    { Alpha2Code.ZW, new ZimbabweCountryInfo() },
                }
            );

            #endregion

            #region Alpha3Code mapping

            this._alpha3Code2CountryInfo = new(_alpha2Code2CountryInfo.Values.ToDictionary(x => x.Alpha3Code, x => x));

            #endregion
        }

        /// <inheritdoc/>
        public IEnumerable<ICountryInfo> GetCountries()
        {
            return this._alpha2Code2CountryInfo.Values;
        }

        /// <inheritdoc/>
        public ICountryInfo GetCountry(string alpha2or3Code)
        {
            if (Enum.TryParse(alpha2or3Code, true, out Alpha2Code alpha2Code))
            {
                return this.GetCountry(alpha2Code);
            }

            if (Enum.TryParse(alpha2or3Code, true, out Alpha3Code alpha3Code))
            {
                return this.GetCountry(alpha3Code);
            }

            throw new UnknownCountryException($"Cannot found a country for code {alpha2or3Code}");
        }

        /// <inheritdoc/>
        public bool TryGetCountry(string alpha2or3Code, [NotNullWhen(true)] out ICountryInfo? countryInfo)
        {
            if (Enum.TryParse(alpha2or3Code, true, out Alpha2Code alpha2Code))
            {
                countryInfo = this.GetCountry(alpha2Code);
                return true;
            }

            if (Enum.TryParse(alpha2or3Code, true, out Alpha3Code alpha3Code))
            {
                countryInfo = this.GetCountry(alpha3Code);
                return true;
            }

            countryInfo = null;
            return false;
        }

        /// <inheritdoc/>
        public ICountryInfo GetCountry(Alpha2Code alpha2Code)
        {
            if (this._alpha2Code2CountryInfo.TryGetValue(alpha2Code, out ICountryInfo? countryInfo))
            {
                return countryInfo;
            }

            throw new UnknownCountryException($"Cannot found a country for code {alpha2Code}");
        }

        /// <inheritdoc/>
        public ICountryInfo GetCountry(Alpha3Code alpha3Code)
        {
            if (this._alpha3Code2CountryInfo.TryGetValue(alpha3Code, out ICountryInfo? countryInfo))
            {
                return countryInfo;
            }

            throw new UnknownCountryException($"Cannot found a country for code {alpha3Code}");
        }

        /// <inheritdoc/>
        public ICountryInfo GetCountryByName(string countryName)
        {
            foreach (var countryInfo in this._alpha2Code2CountryInfo.Values)
            {
                if (countryInfo.CommonName.Equals(countryName, StringComparison.OrdinalIgnoreCase))
                {
                    return countryInfo;
                }

                if (countryInfo.OfficialName.Equals(countryName, StringComparison.OrdinalIgnoreCase))
                {
                    return countryInfo;
                }
            }

            throw new UnknownCountryException($"Cannot found a country for countryName {countryName}");
        }
    }
}
