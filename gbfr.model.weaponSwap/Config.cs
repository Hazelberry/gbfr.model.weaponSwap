using gbfr.model.weaponSwap.Template.Configuration;

using Reloaded.Mod.Interfaces.Structs;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace gbfr.model.weaponSwap.Configuration
{
    public class Config : Configurable<Config>
    {
        // 0000-0100
        [DisplayName("Djeeta Sheath Swap")]
        [Category("Captain")]
        [DefaultValue(Toggle.Disabled)]
        [Description("\nEnables swapping Djeeta's sheaths on her default outfit.\n" +
            "If replacing Partenza it will apply the thick sheath and only affect that weapon.\n" +
            "However, replacing any other weapon WITH Partenza will replace the thick sheath for all of her weapons\n" +
            "and those will have noticeable clipping if they were not also swapped to Partenza.\n\n" +
            "Does not affect Gran's default outfit or either Captain's rebelwear outfits, they only have a single sheath size.\n\n" +
            "Will not work if you have a modified Djeeta default outfit player model.\n")]
        public Toggle Captain_SheathSwapToggle { get; set; } = Toggle.Disabled;

        [DisplayName("Traveller's Sword")]
        [Category("Captain")]
        [DefaultValue(CaptainWeaponObjId.Travellers_Sword)]
        [Description("Gran's Defender Weapon")]
        public CaptainWeaponObjId Captain_TravellersSword { get; set; } = CaptainWeaponObjId.Travellers_Sword;

        [DisplayName("Partenza")]
        [Category("Captain")]
        [DefaultValue(CaptainWeaponObjId.Partenza)]
        [Description("Djeeta's Defender Weapon")]
        public CaptainWeaponObjId Captain_Partenza { get; set; } = CaptainWeaponObjId.Partenza;

        [DisplayName("Durandal")]
        [Category("Captain")]
        [DefaultValue(CaptainWeaponObjId.Durandal)]
        public CaptainWeaponObjId Captain_Durandal { get; set; } = CaptainWeaponObjId.Durandal;

        [DisplayName("Sword of Eos")]
        [Category("Captain")]
        [DefaultValue(CaptainWeaponObjId.Sword_of_Eos)]
        public CaptainWeaponObjId Captain_SwordofEos { get; set; } = CaptainWeaponObjId.Sword_of_Eos;

        [DisplayName("Albacore Blade")]
        [Category("Captain")]
        [DefaultValue(CaptainWeaponObjId.Albacore_Blade)]
        public CaptainWeaponObjId Captain_AlbacoreBlade { get; set; } = CaptainWeaponObjId.Albacore_Blade;

        [DisplayName("Ultima Sword")]
        [Category("Captain")]
        [DefaultValue(CaptainWeaponObjId.Ultima_Sword)]
        public CaptainWeaponObjId Captain_UltimaSword { get; set; } = CaptainWeaponObjId.Ultima_Sword;

        [DisplayName("Seven-Star Sword")]
        [Category("Captain")]
        [DefaultValue(CaptainWeaponObjId.Seven_Star_Sword)]
        public CaptainWeaponObjId Captain_SevenStarSword { get; set; } = CaptainWeaponObjId.Seven_Star_Sword;

        // 0200
        [DisplayName("Rukalsa")]
        [Category("Katalina")]
        [DefaultValue(KatalinaWeaponObjId.Rukalsa)]
        public KatalinaWeaponObjId Katalina_Rukalsa { get; set; } = KatalinaWeaponObjId.Rukalsa;

        [DisplayName("Flame Rapier")]
        [Category("Katalina")]
        [DefaultValue(KatalinaWeaponObjId.Flame_Rapier)]
        public KatalinaWeaponObjId Katalina_FlameRapier { get; set; } = KatalinaWeaponObjId.Flame_Rapier;

        [DisplayName("Murgleis")]
        [Category("Katalina")]
        [DefaultValue(KatalinaWeaponObjId.Murgleis)]
        public KatalinaWeaponObjId Katalina_Murgleis { get; set; } = KatalinaWeaponObjId.Murgleis;

        [DisplayName("Luminiera Sword Omega")]
        [Category("Katalina")]
        [DefaultValue(KatalinaWeaponObjId.Luminiera_Sword_Omega)]
        public KatalinaWeaponObjId Katalina_LuminieraSwordOmega { get; set; } = KatalinaWeaponObjId.Luminiera_Sword_Omega;

        [DisplayName("Ephemeron")]
        [Category("Katalina")]
        [DefaultValue(KatalinaWeaponObjId.Ephemeron)]
        public KatalinaWeaponObjId Katalina_Ephemeron { get; set; } = KatalinaWeaponObjId.Ephemeron;

        [DisplayName("Blutgang")]
        [Category("Katalina")]
        [DefaultValue(KatalinaWeaponObjId.Blutgang)]
        public KatalinaWeaponObjId Katalina_Blutgang { get; set; } = KatalinaWeaponObjId.Blutgang;

        // 0300
        [DisplayName("Flintspike")]
        [Category("Rackam")]
        [DefaultValue(RackamWeaponObjId.Flintspike)]
        public RackamWeaponObjId Rackam_Flintspike { get; set; } = RackamWeaponObjId.Flintspike;

        [DisplayName("Wheellock Axe")]
        [Category("Rackam")]
        [DefaultValue(RackamWeaponObjId.Wheellock_Axe)]
        public RackamWeaponObjId Rackam_WheellockAxe { get; set; } = RackamWeaponObjId.Wheellock_Axe;

        [DisplayName("Benedia")]
        [Category("Rackam")]
        [DefaultValue(RackamWeaponObjId.Benedia)]
        public RackamWeaponObjId Rackam_Benedia { get; set; } = RackamWeaponObjId.Benedia;

        [DisplayName("Tiamat Bolt Omega")]
        [Category("Rackam")]
        [DefaultValue(RackamWeaponObjId.Tiamat_Bolt_Omega)]
        public RackamWeaponObjId Rackam_TiamatBoltOmega { get; set; } = RackamWeaponObjId.Tiamat_Bolt_Omega;

        [DisplayName("Stormcloud")]
        [Category("Rackam")]
        [DefaultValue(RackamWeaponObjId.Stormcloud)]
        public RackamWeaponObjId Rackam_Stormcloud { get; set; } = RackamWeaponObjId.Stormcloud;

        [DisplayName("Freikugel")]
        [Category("Rackam")]
        [DefaultValue(RackamWeaponObjId.Freikugel)]
        public RackamWeaponObjId Rackam_Freikugel { get; set; } = RackamWeaponObjId.Freikugel;

        // 0400
        [DisplayName("Little Witch Scepter")]
        [Category("Io")]
        [DefaultValue(IoWeaponObjId.Little_Witch_Scepter)]
        public IoWeaponObjId Io_LittleWitchScepter { get; set; } = IoWeaponObjId.Little_Witch_Scepter;

        [DisplayName("Zhezl")]
        [Category("Io")]
        [DefaultValue(IoWeaponObjId.Zhezl)]
        public IoWeaponObjId Io_Zhezl { get; set; } = IoWeaponObjId.Zhezl;

        [DisplayName("Gambanteinn")]
        [Category("Io")]
        [DefaultValue(IoWeaponObjId.Gambanteinn)]
        public IoWeaponObjId Io_Gambanteinn { get; set; } = IoWeaponObjId.Gambanteinn;

        [DisplayName("Colossus Cane Omega")]
        [Category("Io")]
        [DefaultValue(IoWeaponObjId.Colossus_Cane_Omega)]
        public IoWeaponObjId Io_ColossusCaneOmega { get; set; } = IoWeaponObjId.Colossus_Cane_Omega;

        [DisplayName("Tupsmati")]
        [Category("Io")]
        [DefaultValue(IoWeaponObjId.Tupsimati)]
        public IoWeaponObjId Io_Tupsimati { get; set; } = IoWeaponObjId.Tupsimati;

        [DisplayName("Caduceus")]
        [Category("Io")]
        [DefaultValue(IoWeaponObjId.Caduceus)]
        public IoWeaponObjId Io_Caduceus { get; set; } = IoWeaponObjId.Caduceus;

        // 0500
        [DisplayName("Dreyse")]
        [Category("Eugen")]
        [DefaultValue(EugenWeaponObjId.Dreyse)]
        public EugenWeaponObjId Eugen_Dreyse { get; set; } = EugenWeaponObjId.Dreyse;

        [DisplayName("Matchlock")]
        [Category("Eugen")]
        [DefaultValue(EugenWeaponObjId.Matchlock)]
        public EugenWeaponObjId Eugen_Matchlock { get; set; } = EugenWeaponObjId.Matchlock;

        [DisplayName("AK-4A")]
        [Category("Eugen")]
        [DefaultValue(EugenWeaponObjId.AK4A)]
        public EugenWeaponObjId Eugen_AK4A { get; set; } = EugenWeaponObjId.AK4A;

        [DisplayName("Leviathan Muzzle")]
        [Category("Eugen")]
        [DefaultValue(EugenWeaponObjId.Leviathan_Muzzle)]
        public EugenWeaponObjId Eugen_LeviathanMuzzle { get; set; } = EugenWeaponObjId.Leviathan_Muzzle;

        [DisplayName("Clarion")]
        [Category("Eugen")]
        [DefaultValue(EugenWeaponObjId.Clarion)]
        public EugenWeaponObjId Eugen_Clarion { get; set; } = EugenWeaponObjId.Clarion;

        [DisplayName("Draconic Fire")]
        [Category("Eugen")]
        [DefaultValue(EugenWeaponObjId.Draconic_Fire)]
        public EugenWeaponObjId Eugen_DraconicFire { get; set; } = EugenWeaponObjId.Draconic_Fire;

        // 0600
        [DisplayName("Egoism")]
        [Category("Rosetta")]
        [DefaultValue(RosettaWeaponObjId.Egoism)]
        public RosettaWeaponObjId Rosetta_Egoism { get; set; } = RosettaWeaponObjId.Egoism;

        [DisplayName("Swordbreaker")]
        [Category("Rosetta")]
        [DefaultValue(RosettaWeaponObjId.Swordbreaker)]
        public RosettaWeaponObjId Rosetta_Swordbreaker { get; set; } = RosettaWeaponObjId.Swordbreaker;

        [DisplayName("Love Eternal")]
        [Category("Rosetta")]
        [DefaultValue(RosettaWeaponObjId.Love_Eternal)]
        public RosettaWeaponObjId Rosetta_LoveEternal { get; set; } = RosettaWeaponObjId.Love_Eternal;

        [DisplayName("Rose Crystal Knife")]
        [Category("Rosetta")]
        [DefaultValue(RosettaWeaponObjId.Rose_Crystal_Knife)]
        public RosettaWeaponObjId Rosetta_RoseCrystalKnife { get; set; } = RosettaWeaponObjId.Rose_Crystal_Knife;

        [DisplayName("Cortana")]
        [Category("Rosetta")]
        [DefaultValue(RosettaWeaponObjId.Cortana)]
        public RosettaWeaponObjId Rosetta_Cortana { get; set; } = RosettaWeaponObjId.Cortana;

        [DisplayName("Dragger of Bahamut Coda")]
        [Category("Rosetta")]
        [DefaultValue(RosettaWeaponObjId.Dagger_of_Bahamut_Coda)]
        public RosettaWeaponObjId Rosetta_DaggerofBahamutCoda { get; set; } = RosettaWeaponObjId.Dagger_of_Bahamut_Coda;

        // 0700
        [DisplayName("Geisterpeitche")]
        [Category("Ferry")]
        [DefaultValue(FerryWeaponObjId.Geisterpeitche)]
        public FerryWeaponObjId Ferry_Geisterpeitche { get; set; } = FerryWeaponObjId.Geisterpeitche;

        [DisplayName("Leather Belt")]
        [Category("Ferry")]
        [DefaultValue(FerryWeaponObjId.Leather_Belt)]
        public FerryWeaponObjId Ferry_LeatherBelt { get; set; } = FerryWeaponObjId.Leather_Belt;

        [DisplayName("Ethereal Lasher")]
        [Category("Ferry")]
        [DefaultValue(FerryWeaponObjId.Ethereal_Lasher)]
        public FerryWeaponObjId Ferry_EtherealLasher { get; set; } = FerryWeaponObjId.Ethereal_Lasher;

        [DisplayName("Flame Lit Curl")]
        [Category("Ferry")]
        [DefaultValue(FerryWeaponObjId.Flame_Lit_Curl)]
        public FerryWeaponObjId Ferry_FlameLitCurl { get; set; } = FerryWeaponObjId.Flame_Lit_Curl;

        [DisplayName("Live Wire")]
        [Category("Ferry")]
        [DefaultValue(FerryWeaponObjId.Live_Wire)]
        public FerryWeaponObjId Ferry_LiveWire { get; set; } = FerryWeaponObjId.Live_Wire;

        [DisplayName("Erinnerung")]
        [Category("Ferry")]
        [DefaultValue(FerryWeaponObjId.Erinnerung)]
        public FerryWeaponObjId Ferry_Erinnerung { get; set; } = FerryWeaponObjId.Erinnerung;

        // 0800
        [DisplayName("Altachiara")]
        [Category("Lancelot")]
        [DefaultValue(LancelotWeaponObjId.Altachiara)]
        public LancelotWeaponObjId Lancelot_Altachiara { get; set; } = LancelotWeaponObjId.Altachiara;

        [DisplayName("Hoarfrost Blade Persius")]
        [Category("Lancelot")]
        [DefaultValue(LancelotWeaponObjId.Hoarfrost_Blade_Persius)]
        public LancelotWeaponObjId Lancelot_HoarfrostBladePersius { get; set; } = LancelotWeaponObjId.Hoarfrost_Blade_Persius;

        [DisplayName("Blanc Comme Neige")]
        [Category("Lancelot")]
        [DefaultValue(LancelotWeaponObjId.Blanc_Comme_Neige)]
        public LancelotWeaponObjId Lancelot_BlancCommeNeige { get; set; } = LancelotWeaponObjId.Blanc_Comme_Neige;

        [DisplayName("Vegalta")]
        [Category("Lancelot")]
        [DefaultValue(LancelotWeaponObjId.Vegalta)]
        public LancelotWeaponObjId Lancelot_Vegalta { get; set; } = LancelotWeaponObjId.Vegalta;

        [DisplayName("Knight of Ice")]
        [Category("Lancelot")]
        [DefaultValue(LancelotWeaponObjId.Knight_of_Ice)]
        public LancelotWeaponObjId Lancelot_KnightOfIce { get; set; } = LancelotWeaponObjId.Knight_of_Ice;

        [DisplayName("Damascus Knife")]
        [Category("Lancelot")]
        [DefaultValue(LancelotWeaponObjId.Damascus_Knife)]
        public LancelotWeaponObjId Lancelot_DamascusKnife { get; set; } = LancelotWeaponObjId.Damascus_Knife;

        // 0900
        [DisplayName("Alabarda")]
        [Category("Vane")]
        [DefaultValue(VaneWeaponObjId.Alabarda)]
        public VaneWeaponObjId Vane_Alabarda { get; set; } = VaneWeaponObjId.Alabarda;

        [DisplayName("Swan")]
        [Category("Vane")]
        [DefaultValue(VaneWeaponObjId.Swan)]
        public VaneWeaponObjId Vane_Swan { get; set; } = VaneWeaponObjId.Swan;

        [DisplayName("Treuer Krieger")]
        [Category("Vane")]
        [DefaultValue(VaneWeaponObjId.Treuer_Krieger)]
        public VaneWeaponObjId Vane_TreuerKrieger { get; set; } = VaneWeaponObjId.Treuer_Krieger;

        [DisplayName("Ukonvasara")]
        [Category("Vane")]
        [DefaultValue(VaneWeaponObjId.Ukonvasara)]
        public VaneWeaponObjId Vane_Ukonvasara { get; set; } = VaneWeaponObjId.Ukonvasara;

        [DisplayName("Blossom Axe")]
        [Category("Vane")]
        [DefaultValue(VaneWeaponObjId.Blossom_Axe)]
        public VaneWeaponObjId Vane_BlossomAxe { get; set; } = VaneWeaponObjId.Blossom_Axe;

        [DisplayName("Mjolnir")]
        [Category("Vane")]
        [DefaultValue(VaneWeaponObjId.Mjolnir)]
        public VaneWeaponObjId Vane_Mjolnir { get; set; } = VaneWeaponObjId.Mjolnir;

        // 1000
        [DisplayName("Flamberge")]
        [Category("Percival")]
        [DefaultValue(PercivalWeaponObjId.Flamberge)]
        public PercivalWeaponObjId Percival_Flamberge { get; set; } = PercivalWeaponObjId.Flamberge;

        [DisplayName("Lohengrin")]
        [Category("Percival")]
        [DefaultValue(PercivalWeaponObjId.Lohengrin)]
        public PercivalWeaponObjId Percival_Lohengrin { get; set; } = PercivalWeaponObjId.Lohengrin;

        [DisplayName("Antwerp")]
        [Category("Percival")]
        [DefaultValue(PercivalWeaponObjId.Antwerp)]
        public PercivalWeaponObjId Percival_Antwerp { get; set; } = PercivalWeaponObjId.Antwerp;

        [DisplayName("Joyeuse")]
        [Category("Percival")]
        [DefaultValue(PercivalWeaponObjId.Joyeuse)]
        public PercivalWeaponObjId Percival_Joyeuse { get; set; } = PercivalWeaponObjId.Joyeuse;

        [DisplayName("Lord of Flames")]
        [Category("Percival")]
        [DefaultValue(PercivalWeaponObjId.Lord_of_Flames)]
        public PercivalWeaponObjId Percival_LordOfFlames { get; set; } = PercivalWeaponObjId.Lord_of_Flames;

        [DisplayName("Gottfried")]
        [Category("Percival")]
        [DefaultValue(PercivalWeaponObjId.Gottfried)]
        public PercivalWeaponObjId Percival_Gottfried { get; set; } = PercivalWeaponObjId.Gottfried;

        // 1100
        [DisplayName("Integrity")]
        [Category("Siegfried")]
        [DefaultValue(SiegfriedWeaponObjId.Integrity)]
        public SiegfriedWeaponObjId Siegfried_Integrity { get; set; } = SiegfriedWeaponObjId.Integrity;

        [DisplayName("Broadsword of Earth")]
        [Category("Siegfried")]
        [DefaultValue(SiegfriedWeaponObjId.Broadsword_of_Earth)]
        public SiegfriedWeaponObjId Siegfried_BroadswordofEarth { get; set; } = SiegfriedWeaponObjId.Broadsword_of_Earth;

        [DisplayName("Ascalon")]
        [Category("Siegfried")]
        [DefaultValue(SiegfriedWeaponObjId.Ascalon)]
        public SiegfriedWeaponObjId Siegfried_Ascalon { get; set; } = SiegfriedWeaponObjId.Ascalon;

        [DisplayName("Hrunting")]
        [Category("Siegfried")]
        [DefaultValue(SiegfriedWeaponObjId.Hrunting)]
        public SiegfriedWeaponObjId Siegfried_Hrunting { get; set; } = SiegfriedWeaponObjId.Hrunting;

        [DisplayName("Windhose")]
        [Category("Siegfried")]
        [DefaultValue(SiegfriedWeaponObjId.Windhose)]
        public SiegfriedWeaponObjId Siegfried_Windhose { get; set; } = SiegfriedWeaponObjId.Windhose;

        [DisplayName("Balmung")]
        [Category("Siegfried")]
        [DefaultValue(SiegfriedWeaponObjId.Balmung)]
        public SiegfriedWeaponObjId Siegfried_Balmung { get; set; } = SiegfriedWeaponObjId.Balmung;

        // 1200
        [DisplayName("Claiomh Solais")]
        [Category("Charlotta")]
        [DefaultValue(CharlottaWeaponObjId.Claiomh_Solais)]
        public CharlottaWeaponObjId Charlotta_ClaiomhSolais { get; set; } = CharlottaWeaponObjId.Claiomh_Solais;

        [DisplayName("Arondight")]
        [Category("Charlotta")]
        [DefaultValue(CharlottaWeaponObjId.Arondight)]
        public CharlottaWeaponObjId Charlotta_Arondight { get; set; } = CharlottaWeaponObjId.Arondight;

        [DisplayName("Claidheamh Soluis")]
        [Category("Charlotta")]
        [DefaultValue(CharlottaWeaponObjId.Claidheamh_Soluis)]
        public CharlottaWeaponObjId Charlotta_ClaidheamhSoluis { get; set; } = CharlottaWeaponObjId.Claidheamh_Soluis;

        [DisplayName("Ushumgal")]
        [Category("Charlotta")]
        [DefaultValue(CharlottaWeaponObjId.Ushumgal)]
        public CharlottaWeaponObjId Charlotta_Ushumgal { get; set; } = CharlottaWeaponObjId.Ushumgal;

        [DisplayName("Sahrivar")]
        [Category("Charlotta")]
        [DefaultValue(CharlottaWeaponObjId.Sahrivar)]
        public CharlottaWeaponObjId Charlotta_Sahrivar { get; set; } = CharlottaWeaponObjId.Sahrivar;

        [DisplayName("Galatine")]
        [Category("Charlotta")]
        [DefaultValue(CharlottaWeaponObjId.Galatine)]
        public CharlottaWeaponObjId Charlotta_Galatine { get; set; } = CharlottaWeaponObjId.Galatine;

        // 1300
        [DisplayName("Kiku-Ichimonji")]
        [Category("Yodarha")]
        [DefaultValue(YodarhaWeaponObjId.Kiku_Ichimonji)]
        public YodarhaWeaponObjId Yodarha_KikuIchimonji { get; set; } = YodarhaWeaponObjId.Kiku_Ichimonji;

        [DisplayName("Asura")]
        [Category("Yodarha")]
        [DefaultValue(YodarhaWeaponObjId.Asura)]
        public YodarhaWeaponObjId Yodarha_Asura { get; set; } = YodarhaWeaponObjId.Asura;

        [DisplayName("Fudo-Kuniyuki")]
        [Category("Yodarha")]
        [DefaultValue(YodarhaWeaponObjId.Fudo_Kuniyuki)]
        public YodarhaWeaponObjId Yodarha_FudoKuniyuki { get; set; } = YodarhaWeaponObjId.Fudo_Kuniyuki;

        [DisplayName("Higurashi")]
        [Category("Yodarha")]
        [DefaultValue(YodarhaWeaponObjId.Higurashi)]
        public YodarhaWeaponObjId Yodarha_Higurashi { get; set; } = YodarhaWeaponObjId.Higurashi;

        [DisplayName("Xeno Phantom Demon Blade")]
        [Category("Yodarha")]
        [DefaultValue(YodarhaWeaponObjId.Xeno_Phantom_Demon_Blade)]
        public YodarhaWeaponObjId Yodarha_XenoPhantomDemonBlade { get; set; } = YodarhaWeaponObjId.Xeno_Phantom_Demon_Blade;

        [DisplayName("Swordfish")]
        [Category("Yodarha")]
        [DefaultValue(YodarhaWeaponObjId.Swordfish)]
        public YodarhaWeaponObjId Yodarha_Swordfish { get; set; } = YodarhaWeaponObjId.Swordfish;

        // 1400
        [DisplayName("Narmaya Sheath Swap")]
        [Category("Narmaya")]
        [DefaultValue(Toggle.Disabled)]
        [Description("\nONLY USE IF SWAPPING A SINGLE WEAPON FOR NARMAYA.\n\n" +
            "Will literally swap 2 sheaths. The one being used as a skin will be changed to the one you are replacing.\n" +
            "If you try using this while changing more than 1 Narmaya weapon results will vary.\n\n" +
            "Will not work if you have a modded Narmaya player model.\n")]
        public Toggle Narmaya_SheathSwapToggle { get; set; } = Toggle.Disabled;

        [DisplayName("Nakamaki Nodachi")]
        [Category("Narmaya")]
        [DefaultValue(NarmayaWeaponObjId.Nakamaki_Nodachi)]
        public NarmayaWeaponObjId Narmaya_NakamakiNodachi { get; set; } = NarmayaWeaponObjId.Nakamaki_Nodachi;

        [DisplayName("Kotetsu")]
        [Category("Narmaya")]
        [DefaultValue(NarmayaWeaponObjId.Kotetsu)]
        public NarmayaWeaponObjId Narmaya_Kotetsu { get; set; } = NarmayaWeaponObjId.Kotetsu;

        [DisplayName("Venustas")]
        [Category("Narmaya")]
        [DefaultValue(NarmayaWeaponObjId.Venustas)]
        public NarmayaWeaponObjId Narmaya_Venustas { get; set; } = NarmayaWeaponObjId.Venustas;

        [DisplayName("Flourithium Blade")]
        [Category("Narmaya")]
        [DefaultValue(NarmayaWeaponObjId.Flourithium_Blade)]
        public NarmayaWeaponObjId Narmaya_Flourithium_Blade { get; set; } = NarmayaWeaponObjId.Flourithium_Blade;

        [DisplayName("Blade of Purification")]
        [Category("Narmaya")]
        [DefaultValue(NarmayaWeaponObjId.Blade_of_Purification)]
        public NarmayaWeaponObjId Narmaya_BladeofPurification { get; set; } = NarmayaWeaponObjId.Blade_of_Purification;

        [DisplayName("Ameno Habakiri")]
        [Category("Narmaya")]
        [DefaultValue(NarmayaWeaponObjId.Ameno_Habakiri)]
        public NarmayaWeaponObjId Narmaya_AmenoHabakiri { get; set; } = NarmayaWeaponObjId.Ameno_Habakiri;

        // 1500
        [DisplayName("Brahma Gauntlet")]
        [Category("Ghandagoza")]
        [DefaultValue(GhandagozaWeaponObjId.Brahma_Gauntlet)]
        public GhandagozaWeaponObjId Ghandagoza_BrahmaGauntlet { get; set; } = GhandagozaWeaponObjId.Brahma_Gauntlet;

        [DisplayName("Rope Knuckles")]
        [Category("Ghandagoza")]
        [DefaultValue(GhandagozaWeaponObjId.Rope_Knuckles)]
        public GhandagozaWeaponObjId Ghandagoza_RopeKnuckles { get; set; } = GhandagozaWeaponObjId.Rope_Knuckles;

        [DisplayName("Crimson Finger")]
        [Category("Ghandagoza")]
        [DefaultValue(GhandagozaWeaponObjId.Crimson_Finger)]
        public GhandagozaWeaponObjId Ghandagoza_CrimsonFinger { get; set; } = GhandagozaWeaponObjId.Crimson_Finger;

        [DisplayName("Golden Fists of Ura")]
        [Category("Ghandagoza")]
        [DefaultValue(GhandagozaWeaponObjId.Golden_Fists_of_Ura)]
        public GhandagozaWeaponObjId Ghandagoza_GoldenFistsOfUra { get; set; } = GhandagozaWeaponObjId.Golden_Fists_of_Ura;

        [DisplayName("Arkab")]
        [Category("Ghandagoza")]
        [DefaultValue(GhandagozaWeaponObjId.Arkab)]
        public GhandagozaWeaponObjId Ghandagoza_Arkab { get; set; } = GhandagozaWeaponObjId.Arkab;

        [DisplayName("Sky Piercer")]
        [Category("Ghandagoza")]
        [DefaultValue(GhandagozaWeaponObjId.Sky_Piercer)]
        public GhandagozaWeaponObjId Ghandagoza_SkyPiercer { get; set; } = GhandagozaWeaponObjId.Sky_Piercer;

        // 1600
        [DisplayName("Spear of Arvess")]
        [Category("Zeta")]
        [DefaultValue(ZetaWeaponObjId.Spear_of_Arvess)]
        public ZetaWeaponObjId Zeta_SpearofArvess { get; set; } = ZetaWeaponObjId.Spear_of_Arvess;

        [DisplayName("Sunspot Spear")]
        [Category("Zeta")]
        [DefaultValue(ZetaWeaponObjId.Sunspot_Spear)]
        public ZetaWeaponObjId Zeta_Sunspot_Spear { get; set; } = ZetaWeaponObjId.Sunspot_Spear;

        [DisplayName("Brionac")]
        [Category("Zeta")]
        [DefaultValue(ZetaWeaponObjId.Brionac)]
        public ZetaWeaponObjId Zeta_Brionac { get; set; } = ZetaWeaponObjId.Brionac;

        [DisplayName("Gisla")]
        [Category("Zeta")]
        [DefaultValue(ZetaWeaponObjId.Gisla)]
        public ZetaWeaponObjId Zeta_Gisla { get; set; } = ZetaWeaponObjId.Gisla;

        [DisplayName("Huanglong Spear")]
        [Category("Zeta")]
        [DefaultValue(ZetaWeaponObjId.Huanglong_Spear)]
        public ZetaWeaponObjId Zeta_HuanglongSpear { get; set; } = ZetaWeaponObjId.Huanglong_Spear;

        [DisplayName("Gae Bulg")]
        [Category("Zeta")]
        [DefaultValue(ZetaWeaponObjId.Gae_Bulg)]
        public ZetaWeaponObjId Zeta_GaeBulg { get; set; } = ZetaWeaponObjId.Gae_Bulg;

        // 1700
        [DisplayName("Great Scythe Grynoth")]
        [Category("Vaseraga")]
        [DefaultValue(VaseragaWeaponObjId.Great_Scythe_Grynoth)]
        public VaseragaWeaponObjId Vaseraga_GreatScytheGrynoth { get; set; } = VaseragaWeaponObjId.Great_Scythe_Grynoth;

        [DisplayName("Alsarav")]
        [Category("Vaseraga")]
        [DefaultValue(VaseragaWeaponObjId.Alsarav)]
        public VaseragaWeaponObjId Vaseraga_Alsarav { get; set; } = VaseragaWeaponObjId.Alsarav;

        [DisplayName("Wurtzite Scythe")]
        [Category("Vaseraga")]
        [DefaultValue(VaseragaWeaponObjId.Wurtzite_Scythe)]
        public VaseragaWeaponObjId Vaseraga_WurtziteScythe { get; set; } = VaseragaWeaponObjId.Wurtzite_Scythe;

        [DisplayName("Soul Eater")]
        [Category("Vaseraga")]
        [DefaultValue(VaseragaWeaponObjId.Soul_Eater)]
        public VaseragaWeaponObjId Vaseraga_SoulEater { get; set; } = VaseragaWeaponObjId.Soul_Eater;

        [DisplayName("Cosmic Scythe")]
        [Category("Vaseraga")]
        [DefaultValue(VaseragaWeaponObjId.Cosmic_Scythe)]
        public VaseragaWeaponObjId Vaseraga_CosmicScythe { get; set; } = VaseragaWeaponObjId.Cosmic_Scythe;

        [DisplayName("Ereshkigal")]
        [Category("Vaseraga")]
        [DefaultValue(VaseragaWeaponObjId.Ereshkigal)]
        public VaseragaWeaponObjId Vaseraga_Ereshkigal { get; set; } = VaseragaWeaponObjId.Ereshkigal;

        // 1800
        [DisplayName("Magnum Opus")]
        [Category("Cagliostro")]
        [DefaultValue(CagliostroWeaponObjId.Magnum_Opus)]
        public CagliostroWeaponObjId Cagliostro_MagnumOpus { get; set; } = CagliostroWeaponObjId.Magnum_Opus;

        [DisplayName("Dream Atlas")]
        [Category("Cagliostro")]
        [DefaultValue(CagliostroWeaponObjId.Dream_Atlas)]
        public CagliostroWeaponObjId Cagliostro_DreamAtlas { get; set; } = CagliostroWeaponObjId.Dream_Atlas;

        [DisplayName("Transmigration Tome")]
        [Category("Cagliostro")]
        [DefaultValue(CagliostroWeaponObjId.Transmigration_Tome)]
        public CagliostroWeaponObjId Cagliostro_TransmigrationTome { get; set; } = CagliostroWeaponObjId.Transmigration_Tome;

        [DisplayName("Sacred Codex")]
        [Category("Cagliostro")]
        [DefaultValue(CagliostroWeaponObjId.Sacred_Codex)]
        public CagliostroWeaponObjId Cagliostro_SacredCodex { get; set; } = CagliostroWeaponObjId.Sacred_Codex;

        [DisplayName("Arshivelle")]
        [Category("Cagliostro")]
        [DefaultValue(CagliostroWeaponObjId.Arshivelle)]
        public CagliostroWeaponObjId Cagliostro_Arshivelle { get; set; } = CagliostroWeaponObjId.Arshivelle;

        [DisplayName("Zosimos")]
        [Category("Cagliostro")]
        [DefaultValue(CagliostroWeaponObjId.Zosimos)]
        public CagliostroWeaponObjId Cagliostro_Zosimos { get; set; } = CagliostroWeaponObjId.Zosimos;

        // 1900
        [DisplayName("Ragnarok")]
        [Category("Id")]
        [DefaultValue(IdWeaponObjId.Ragnarok)]
        public IdWeaponObjId Id_Ragnarok { get; set; } = IdWeaponObjId.Ragnarok;

        [DisplayName("Aviaeth Faussart")]
        [Category("Id")]
        [DefaultValue(IdWeaponObjId.Aviaeth_Faussart)]
        public IdWeaponObjId Id_AviaethFaussart { get; set; } = IdWeaponObjId.Aviaeth_Faussart;

        [DisplayName("Susanoo")]
        [Category("Id")]
        [DefaultValue(IdWeaponObjId.Susanoo)]
        public IdWeaponObjId Id_Susanoo { get; set; } = IdWeaponObjId.Susanoo;

        [DisplayName("Premium Sword")]
        [Category("Id")]
        [DefaultValue(IdWeaponObjId.Premium_Sword)]
        public IdWeaponObjId Id_PremiumSword { get; set; } = IdWeaponObjId.Premium_Sword;

        [DisplayName("Ecke Sachs")]
        [Category("Id")]
        [DefaultValue(IdWeaponObjId.Ecke_Sachs)]
        public IdWeaponObjId Id_EckeSachs { get; set; } = IdWeaponObjId.Ecke_Sachs;

        [DisplayName("Sword of Bahamut")]
        [Category("Id")]
        [DefaultValue(IdWeaponObjId.Sword_of_Bahamut)]
        public IdWeaponObjId Id_SwordofBahamut { get; set; } = IdWeaponObjId.Sword_of_Bahamut;

        // 2200
        [DisplayName("Sette di Spade")]
        [Category("Seofon")]
        [DefaultValue(SeofonWeaponObjId.Sette_di_Spade)]
        public SeofonWeaponObjId Seofon_SettediSpade { get; set; } = SeofonWeaponObjId.Sette_di_Spade;

        [DisplayName("Gateway-Star Sword")]
        [Category("Seofon")]
        [DefaultValue(SeofonWeaponObjId.Gateway_Star_Sword)]
        public SeofonWeaponObjId Seofon_GatewayStarSword { get; set; } = SeofonWeaponObjId.Gateway_Star_Sword;

        // 2300
        [DisplayName("Bow of Dismissal")]
        [Category("Tweyen")]
        [DefaultValue(TweyenWeaponObjId.Bow_of_Dismissal)]
        public TweyenWeaponObjId Tweyen_BowofDismissal { get; set; } = TweyenWeaponObjId.Bow_of_Dismissal;

        [DisplayName("Desolation-Crown Bow")]
        [Category("Tweyen")]
        [DefaultValue(TweyenWeaponObjId.Desolation_Crown_Bow)]
        public TweyenWeaponObjId Tweyen_DesolationCrownBow { get; set; } = TweyenWeaponObjId.Desolation_Crown_Bow;

        // 2300
        [DisplayName("Apprentice")]
        [Category("Sandalphon")]
        [DefaultValue(SandalphonWeaponObjId.Apprentice)]
        public SandalphonWeaponObjId Sandalphon_Apprentice { get; set; } = SandalphonWeaponObjId.Apprentice;

        [DisplayName("Sandalphon Placeholder2")]
        [Category("Sandalphon")]
        [DefaultValue(SandalphonWeaponObjId.WorldEnder)]
        public SandalphonWeaponObjId Sandalphon_WorldEnder { get; set; } = SandalphonWeaponObjId.WorldEnder;

    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}
