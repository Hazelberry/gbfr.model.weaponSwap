using gbfr.model.weaponSwapNoRestrictions.Template.Configuration;

using Reloaded.Mod.Interfaces.Structs;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace gbfr.model.weaponSwapNoRestrictions.Configuration
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
        [DefaultValue(AllWeaponObjId.Captain_Travellers_Sword)]
        [Description("Gran's Defender Weapon")]
        public AllWeaponObjId Captain_TravellersSword { get; set; } = AllWeaponObjId.Captain_Travellers_Sword;

        [DisplayName("Partenza")]
        [Category("Captain")]
        [DefaultValue(AllWeaponObjId.Captain_Partenza)]
        [Description("Djeeta's Defender Weapon")]
        public AllWeaponObjId Captain_Partenza { get; set; } = AllWeaponObjId.Captain_Partenza;

        [DisplayName("Durandal")]
        [Category("Captain")]
        [DefaultValue(AllWeaponObjId.Captain_Durandal)]
        public AllWeaponObjId Captain_Durandal { get; set; } = AllWeaponObjId.Captain_Durandal;

        [DisplayName("Sword of Eos")]
        [Category("Captain")]
        [DefaultValue(AllWeaponObjId.Captain_Sword_of_Eos)]
        public AllWeaponObjId Captain_SwordofEos { get; set; } = AllWeaponObjId.Captain_Sword_of_Eos;

        [DisplayName("Albacore Blade")]
        [Category("Captain")]
        [DefaultValue(AllWeaponObjId.Captain_Albacore_Blade)]
        public AllWeaponObjId Captain_AlbacoreBlade { get; set; } = AllWeaponObjId.Captain_Albacore_Blade;

        [DisplayName("Ultima Sword")]
        [Category("Captain")]
        [DefaultValue(AllWeaponObjId.Captain_Ultima_Sword)]
        public AllWeaponObjId Captain_UltimaSword { get; set; } = AllWeaponObjId.Captain_Ultima_Sword;

        [DisplayName("Seven-Star Sword")]
        [Category("Captain")]
        [DefaultValue(AllWeaponObjId.Captain_Seven_Star_Sword)]
        public AllWeaponObjId Captain_SevenStarSword { get; set; } = AllWeaponObjId.Captain_Seven_Star_Sword;

        // 0200
        [DisplayName("Rukalsa")]
        [Category("Katalina")]
        [DefaultValue(AllWeaponObjId.Katalina_Rukalsa)]
        public AllWeaponObjId Katalina_Rukalsa { get; set; } = AllWeaponObjId.Katalina_Rukalsa;

        [DisplayName("Flame Rapier")]
        [Category("Katalina")]
        [DefaultValue(AllWeaponObjId.Katalina_Flame_Rapier)]
        public AllWeaponObjId Katalina_FlameRapier { get; set; } = AllWeaponObjId.Katalina_Flame_Rapier;

        [DisplayName("Murgleis")]
        [Category("Katalina")]
        [DefaultValue(AllWeaponObjId.Katalina_Murgleis)]
        public AllWeaponObjId Katalina_Murgleis { get; set; } = AllWeaponObjId.Katalina_Murgleis;

        [DisplayName("Luminiera Sword Omega")]
        [Category("Katalina")]
        [DefaultValue(AllWeaponObjId.Katalina_Luminiera_Sword_Omega)]
        public AllWeaponObjId Katalina_LuminieraSwordOmega { get; set; } = AllWeaponObjId.Katalina_Luminiera_Sword_Omega;

        [DisplayName("Ephemeron")]
        [Category("Katalina")]
        [DefaultValue(AllWeaponObjId.Katalina_Ephemeron)]
        public AllWeaponObjId Katalina_Ephemeron { get; set; } = AllWeaponObjId.Katalina_Ephemeron;

        [DisplayName("Blutgang")]
        [Category("Katalina")]
        [DefaultValue(AllWeaponObjId.Katalina_Blutgang)]
        public AllWeaponObjId Katalina_Blutgang { get; set; } = AllWeaponObjId.Katalina_Blutgang;

        // 0300
        [DisplayName("Flintspike")]
        [Category("Rackam")]
        [DefaultValue(AllWeaponObjId.Rackam_Flintspike)]
        public AllWeaponObjId Rackam_Flintspike { get; set; } = AllWeaponObjId.Rackam_Flintspike;

        [DisplayName("Wheellock Axe")]
        [Category("Rackam")]
        [DefaultValue(AllWeaponObjId.Rackam_Wheellock_Axe)]
        public AllWeaponObjId Rackam_WheellockAxe { get; set; } = AllWeaponObjId.Rackam_Wheellock_Axe;

        [DisplayName("Benedia")]
        [Category("Rackam")]
        [DefaultValue(AllWeaponObjId.Rackam_Benedia)]
        public AllWeaponObjId Rackam_Benedia { get; set; } = AllWeaponObjId.Rackam_Benedia;

        [DisplayName("Tiamat Bolt Omega")]
        [Category("Rackam")]
        [DefaultValue(AllWeaponObjId.Rackam_Tiamat_Bolt_Omega)]
        public AllWeaponObjId Rackam_TiamatBoltOmega { get; set; } = AllWeaponObjId.Rackam_Tiamat_Bolt_Omega;

        [DisplayName("Stormcloud")]
        [Category("Rackam")]
        [DefaultValue(AllWeaponObjId.Rackam_Stormcloud)]
        public AllWeaponObjId Rackam_Stormcloud { get; set; } = AllWeaponObjId.Rackam_Stormcloud;

        [DisplayName("Freikugel")]
        [Category("Rackam")]
        [DefaultValue(AllWeaponObjId.Rackam_Freikugel)]
        public AllWeaponObjId Rackam_Freikugel { get; set; } = AllWeaponObjId.Rackam_Freikugel;

        // 0400
        [DisplayName("Little Witch Scepter")]
        [Category("Io")]
        [DefaultValue(AllWeaponObjId.Io_Little_Witch_Scepter)]
        public AllWeaponObjId Io_LittleWitchScepter { get; set; } = AllWeaponObjId.Io_Little_Witch_Scepter;

        [DisplayName("Zhezl")]
        [Category("Io")]
        [DefaultValue(AllWeaponObjId.Io_Zhezl)]
        public AllWeaponObjId Io_Zhezl { get; set; } = AllWeaponObjId.Io_Zhezl;

        [DisplayName("Gambanteinn")]
        [Category("Io")]
        [DefaultValue(AllWeaponObjId.Io_Gambanteinn)]
        public AllWeaponObjId Io_Gambanteinn { get; set; } = AllWeaponObjId.Io_Gambanteinn;

        [DisplayName("Colossus Cane Omega")]
        [Category("Io")]
        [DefaultValue(AllWeaponObjId.Io_Colossus_Cane_Omega)]
        public AllWeaponObjId Io_ColossusCaneOmega { get; set; } = AllWeaponObjId.Io_Colossus_Cane_Omega;

        [DisplayName("Tupsmati")]
        [Category("Io")]
        [DefaultValue(AllWeaponObjId.Io_Tupsimati)]
        public AllWeaponObjId Io_Tupsimati { get; set; } = AllWeaponObjId.Io_Tupsimati;

        [DisplayName("Caduceus")]
        [Category("Io")]
        [DefaultValue(AllWeaponObjId.Io_Caduceus)]
        public AllWeaponObjId Io_Caduceus { get; set; } = AllWeaponObjId.Io_Caduceus;

        // 0500
        [DisplayName("Dreyse")]
        [Category("Eugen")]
        [DefaultValue(AllWeaponObjId.Eugen_Dreyse)]
        public AllWeaponObjId Eugen_Dreyse { get; set; } = AllWeaponObjId.Eugen_Dreyse;

        [DisplayName("Matchlock")]
        [Category("Eugen")]
        [DefaultValue(AllWeaponObjId.Eugen_Matchlock)]
        public AllWeaponObjId Eugen_Matchlock { get; set; } = AllWeaponObjId.Eugen_Matchlock;

        [DisplayName("AK-4A")]
        [Category("Eugen")]
        [DefaultValue(AllWeaponObjId.Eugen_AK4A)]
        public AllWeaponObjId Eugen_AK4A { get; set; } = AllWeaponObjId.Eugen_AK4A;

        [DisplayName("Leviathan Muzzle")]
        [Category("Eugen")]
        [DefaultValue(AllWeaponObjId.Eugen_Leviathan_Muzzle)]
        public AllWeaponObjId Eugen_LeviathanMuzzle { get; set; } = AllWeaponObjId.Eugen_Leviathan_Muzzle;

        [DisplayName("Clarion")]
        [Category("Eugen")]
        [DefaultValue(AllWeaponObjId.Eugen_Clarion)]
        public AllWeaponObjId Eugen_Clarion { get; set; } = AllWeaponObjId.Eugen_Clarion;

        [DisplayName("Draconic Fire")]
        [Category("Eugen")]
        [DefaultValue(AllWeaponObjId.Eugen_Draconic_Fire)]
        public AllWeaponObjId Eugen_DraconicFire { get; set; } = AllWeaponObjId.Eugen_Draconic_Fire;

        // 0600
        [DisplayName("Egoism")]
        [Category("Rosetta")]
        [DefaultValue(AllWeaponObjId.Rosetta_Egoism)]
        public AllWeaponObjId Rosetta_Egoism { get; set; } = AllWeaponObjId.Rosetta_Egoism;

        [DisplayName("Swordbreaker")]
        [Category("Rosetta")]
        [DefaultValue(AllWeaponObjId.Rosetta_Swordbreaker)]
        public AllWeaponObjId Rosetta_Swordbreaker { get; set; } = AllWeaponObjId.Rosetta_Swordbreaker;

        [DisplayName("Love Eternal")]
        [Category("Rosetta")]
        [DefaultValue(AllWeaponObjId.Rosetta_Love_Eternal)]
        public AllWeaponObjId Rosetta_LoveEternal { get; set; } = AllWeaponObjId.Rosetta_Love_Eternal;

        [DisplayName("Rose Crystal Knife")]
        [Category("Rosetta")]
        [DefaultValue(AllWeaponObjId.Rosetta_Rose_Crystal_Knife)]
        public AllWeaponObjId Rosetta_RoseCrystalKnife { get; set; } = AllWeaponObjId.Rosetta_Rose_Crystal_Knife;

        [DisplayName("Cortana")]
        [Category("Rosetta")]
        [DefaultValue(AllWeaponObjId.Rosetta_Cortana)]
        public AllWeaponObjId Rosetta_Cortana { get; set; } = AllWeaponObjId.Rosetta_Cortana;

        [DisplayName("Dragger of Bahamut Coda")]
        [Category("Rosetta")]
        [DefaultValue(AllWeaponObjId.Rosetta_Dagger_of_Bahamut_Coda)]
        public AllWeaponObjId Rosetta_DaggerofBahamutCoda { get; set; } = AllWeaponObjId.Rosetta_Dagger_of_Bahamut_Coda;

        // 0700
        [DisplayName("Geisterpeitche")]
        [Category("Ferry")]
        [DefaultValue(AllWeaponObjId.Ferry_Geisterpeitche)]
        public AllWeaponObjId Ferry_Geisterpeitche { get; set; } = AllWeaponObjId.Ferry_Geisterpeitche;

        [DisplayName("Leather Belt")]
        [Category("Ferry")]
        [DefaultValue(AllWeaponObjId.Ferry_Leather_Belt)]
        public AllWeaponObjId Ferry_LeatherBelt { get; set; } = AllWeaponObjId.Ferry_Leather_Belt;

        [DisplayName("Ethereal Lasher")]
        [Category("Ferry")]
        [DefaultValue(AllWeaponObjId.Ferry_Ethereal_Lasher)]
        public AllWeaponObjId Ferry_EtherealLasher { get; set; } = AllWeaponObjId.Ferry_Ethereal_Lasher;

        [DisplayName("Flame Lit Curl")]
        [Category("Ferry")]
        [DefaultValue(AllWeaponObjId.Ferry_Flame_Lit_Curl)]
        public AllWeaponObjId Ferry_FlameLitCurl { get; set; } = AllWeaponObjId.Ferry_Flame_Lit_Curl;

        [DisplayName("Live Wire")]
        [Category("Ferry")]
        [DefaultValue(AllWeaponObjId.Ferry_Live_Wire)]
        public AllWeaponObjId Ferry_LiveWire { get; set; } = AllWeaponObjId.Ferry_Live_Wire;

        [DisplayName("Erinnerung")]
        [Category("Ferry")]
        [DefaultValue(AllWeaponObjId.Ferry_Erinnerung)]
        public AllWeaponObjId Ferry_Erinnerung { get; set; } = AllWeaponObjId.Ferry_Erinnerung;

        // 0800
        [DisplayName("Altachiara")]
        [Category("Lancelot")]
        [DefaultValue(AllWeaponObjId.Lancelot_Altachiara)]
        public AllWeaponObjId Lancelot_Altachiara { get; set; } = AllWeaponObjId.Lancelot_Altachiara;

        [DisplayName("Hoarfrost Blade Persius")]
        [Category("Lancelot")]
        [DefaultValue(AllWeaponObjId.Lancelot_Hoarfrost_Blade_Persius)]
        public AllWeaponObjId Lancelot_HoarfrostBladePersius { get; set; } = AllWeaponObjId.Lancelot_Hoarfrost_Blade_Persius;

        [DisplayName("Blanc Comme Neige")]
        [Category("Lancelot")]
        [DefaultValue(AllWeaponObjId.Lancelot_Blanc_Comme_Neige)]
        public AllWeaponObjId Lancelot_BlancCommeNeige { get; set; } = AllWeaponObjId.Lancelot_Blanc_Comme_Neige;

        [DisplayName("Vegalta")]
        [Category("Lancelot")]
        [DefaultValue(AllWeaponObjId.Lancelot_Vegalta)]
        public AllWeaponObjId Lancelot_Vegalta { get; set; } = AllWeaponObjId.Lancelot_Vegalta;

        [DisplayName("Knight of Ice")]
        [Category("Lancelot")]
        [DefaultValue(AllWeaponObjId.Lancelot_Knight_of_Ice)]
        public AllWeaponObjId Lancelot_KnightOfIce { get; set; } = AllWeaponObjId.Lancelot_Knight_of_Ice;

        [DisplayName("Damascus Knife")]
        [Category("Lancelot")]
        [DefaultValue(AllWeaponObjId.Lancelot_Damascus_Knife)]
        public AllWeaponObjId Lancelot_DamascusKnife { get; set; } = AllWeaponObjId.Lancelot_Damascus_Knife;

        // 0900
        [DisplayName("Alabarda")]
        [Category("Vane")]
        [DefaultValue(AllWeaponObjId.Vane_Alabarda)]
        public AllWeaponObjId Vane_Alabarda { get; set; } = AllWeaponObjId.Vane_Alabarda;

        [DisplayName("Swan")]
        [Category("Vane")]
        [DefaultValue(AllWeaponObjId.Vane_Swan)]
        public AllWeaponObjId Vane_Swan { get; set; } = AllWeaponObjId.Vane_Swan;

        [DisplayName("Treuer Krieger")]
        [Category("Vane")]
        [DefaultValue(AllWeaponObjId.Vane_Treuer_Krieger)]
        public AllWeaponObjId Vane_TreuerKrieger { get; set; } = AllWeaponObjId.Vane_Treuer_Krieger;

        [DisplayName("Ukonvasara")]
        [Category("Vane")]
        [DefaultValue(AllWeaponObjId.Vane_Ukonvasara)]
        public AllWeaponObjId Vane_Ukonvasara { get; set; } = AllWeaponObjId.Vane_Ukonvasara;

        [DisplayName("Blossom Axe")]
        [Category("Vane")]
        [DefaultValue(AllWeaponObjId.Vane_Blossom_Axe)]
        public AllWeaponObjId Vane_BlossomAxe { get; set; } = AllWeaponObjId.Vane_Blossom_Axe;

        [DisplayName("Mjolnir")]
        [Category("Vane")]
        [DefaultValue(AllWeaponObjId.Vane_Mjolnir)]
        public AllWeaponObjId Vane_Mjolnir { get; set; } = AllWeaponObjId.Vane_Mjolnir;

        // 1000
        [DisplayName("Flamberge")]
        [Category("Percival")]
        [DefaultValue(AllWeaponObjId.Percival_Flamberge)]
        public AllWeaponObjId Percival_Flamberge { get; set; } = AllWeaponObjId.Percival_Flamberge;

        [DisplayName("Lohengrin")]
        [Category("Percival")]
        [DefaultValue(AllWeaponObjId.Percival_Lohengrin)]
        public AllWeaponObjId Percival_Lohengrin { get; set; } = AllWeaponObjId.Percival_Lohengrin;

        [DisplayName("Antwerp")]
        [Category("Percival")]
        [DefaultValue(AllWeaponObjId.Percival_Antwerp)]
        public AllWeaponObjId Percival_Antwerp { get; set; } = AllWeaponObjId.Percival_Antwerp;

        [DisplayName("Joyeuse")]
        [Category("Percival")]
        [DefaultValue(AllWeaponObjId.Percival_Joyeuse)]
        public AllWeaponObjId Percival_Joyeuse { get; set; } = AllWeaponObjId.Percival_Joyeuse;

        [DisplayName("Lord of Flames")]
        [Category("Percival")]
        [DefaultValue(AllWeaponObjId.Percival_Lord_of_Flames)]
        public AllWeaponObjId Percival_LordOfFlames { get; set; } = AllWeaponObjId.Percival_Lord_of_Flames;

        [DisplayName("Gottfried")]
        [Category("Percival")]
        [DefaultValue(AllWeaponObjId.Percival_Gottfried)]
        public AllWeaponObjId Percival_Gottfried { get; set; } = AllWeaponObjId.Percival_Gottfried;

        // 1100
        [DisplayName("Integrity")]
        [Category("Siegfried")]
        [DefaultValue(AllWeaponObjId.Siegfried_Integrity)]
        public AllWeaponObjId Siegfried_Integrity { get; set; } = AllWeaponObjId.Siegfried_Integrity;

        [DisplayName("Broadsword of Earth")]
        [Category("Siegfried")]
        [DefaultValue(AllWeaponObjId.Siegfried_Broadsword_of_Earth)]
        public AllWeaponObjId Siegfried_BroadswordofEarth { get; set; } = AllWeaponObjId.Siegfried_Broadsword_of_Earth;

        [DisplayName("Ascalon")]
        [Category("Siegfried")]
        [DefaultValue(AllWeaponObjId.Siegfried_Ascalon)]
        public AllWeaponObjId Siegfried_Ascalon { get; set; } = AllWeaponObjId.Siegfried_Ascalon;

        [DisplayName("Hrunting")]
        [Category("Siegfried")]
        [DefaultValue(AllWeaponObjId.Siegfried_Hrunting)]
        public AllWeaponObjId Siegfried_Hrunting { get; set; } = AllWeaponObjId.Siegfried_Hrunting;

        [DisplayName("Windhose")]
        [Category("Siegfried")]
        [DefaultValue(AllWeaponObjId.Siegfried_Windhose)]
        public AllWeaponObjId Siegfried_Windhose { get; set; } = AllWeaponObjId.Siegfried_Windhose;

        [DisplayName("Balmung")]
        [Category("Siegfried")]
        [DefaultValue(AllWeaponObjId.Siegfried_Balmung)]
        public AllWeaponObjId Siegfried_Balmung { get; set; } = AllWeaponObjId.Siegfried_Balmung;

        // 1200
        [DisplayName("Claiomh Solais")]
        [Category("Charlotta")]
        [DefaultValue(AllWeaponObjId.Charlotta_Claiomh_Solais)]
        public AllWeaponObjId Charlotta_ClaiomhSolais { get; set; } = AllWeaponObjId.Charlotta_Claiomh_Solais;

        [DisplayName("Arondight")]
        [Category("Charlotta")]
        [DefaultValue(AllWeaponObjId.Charlotta_Arondight)]
        public AllWeaponObjId Charlotta_Arondight { get; set; } = AllWeaponObjId.Charlotta_Arondight;

        [DisplayName("Claidheamh Soluis")]
        [Category("Charlotta")]
        [DefaultValue(AllWeaponObjId.Charlotta_Claidheamh_Soluis)]
        public AllWeaponObjId Charlotta_ClaidheamhSoluis { get; set; } = AllWeaponObjId.Charlotta_Claidheamh_Soluis;

        [DisplayName("Ushumgal")]
        [Category("Charlotta")]
        [DefaultValue(AllWeaponObjId.Charlotta_Ushumgal)]
        public AllWeaponObjId Charlotta_Ushumgal { get; set; } = AllWeaponObjId.Charlotta_Ushumgal;

        [DisplayName("Sahrivar")]
        [Category("Charlotta")]
        [DefaultValue(AllWeaponObjId.Charlotta_Sahrivar)]
        public AllWeaponObjId Charlotta_Sahrivar { get; set; } = AllWeaponObjId.Charlotta_Sahrivar;

        [DisplayName("Galatine")]
        [Category("Charlotta")]
        [DefaultValue(AllWeaponObjId.Charlotta_Galatine)]
        public AllWeaponObjId Charlotta_Galatine { get; set; } = AllWeaponObjId.Charlotta_Galatine;

        // 1300
        [DisplayName("Kiku-Ichimonji")]
        [Category("Yodarha")]
        [DefaultValue(AllWeaponObjId.Yodarha_Kiku_Ichimonji)]
        public AllWeaponObjId Yodarha_KikuIchimonji { get; set; } = AllWeaponObjId.Yodarha_Kiku_Ichimonji;

        [DisplayName("Asura")]
        [Category("Yodarha")]
        [DefaultValue(AllWeaponObjId.Yodarha_Asura)]
        public AllWeaponObjId Yodarha_Asura { get; set; } = AllWeaponObjId.Yodarha_Asura;

        [DisplayName("Fudo-Kuniyuki")]
        [Category("Yodarha")]
        [DefaultValue(AllWeaponObjId.Yodarha_Fudo_Kuniyuki)]
        public AllWeaponObjId Yodarha_FudoKuniyuki { get; set; } = AllWeaponObjId.Yodarha_Fudo_Kuniyuki;

        [DisplayName("Higurashi")]
        [Category("Yodarha")]
        [DefaultValue(AllWeaponObjId.Yodarha_Higurashi)]
        public AllWeaponObjId Yodarha_Higurashi { get; set; } = AllWeaponObjId.Yodarha_Higurashi;

        [DisplayName("Xeno Phantom Demon Blade")]
        [Category("Yodarha")]
        [DefaultValue(AllWeaponObjId.Yodarha_Xeno_Phantom_Demon_Blade)]
        public AllWeaponObjId Yodarha_XenoPhantomDemonBlade { get; set; } = AllWeaponObjId.Yodarha_Xeno_Phantom_Demon_Blade;

        [DisplayName("Swordfish")]
        [Category("Yodarha")]
        [DefaultValue(AllWeaponObjId.Yodarha_Swordfish)]
        public AllWeaponObjId Yodarha_Swordfish { get; set; } = AllWeaponObjId.Yodarha_Swordfish;

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
        [DefaultValue(AllWeaponObjId.Narmaya_Nakamaki_Nodachi)]
        public AllWeaponObjId Narmaya_NakamakiNodachi { get; set; } = AllWeaponObjId.Narmaya_Nakamaki_Nodachi;

        [DisplayName("Kotetsu")]
        [Category("Narmaya")]
        [DefaultValue(AllWeaponObjId.Narmaya_Kotetsu)]
        public AllWeaponObjId Narmaya_Kotetsu { get; set; } = AllWeaponObjId.Narmaya_Kotetsu;

        [DisplayName("Venustas")]
        [Category("Narmaya")]
        [DefaultValue(AllWeaponObjId.Narmaya_Venustas)]
        public AllWeaponObjId Narmaya_Venustas { get; set; } = AllWeaponObjId.Narmaya_Venustas;

        [DisplayName("Flourithium Blade")]
        [Category("Narmaya")]
        [DefaultValue(AllWeaponObjId.Narmaya_Flourithium_Blade)]
        public AllWeaponObjId Narmaya_Flourithium_Blade { get; set; } = AllWeaponObjId.Narmaya_Flourithium_Blade;

        [DisplayName("Blade of Purification")]
        [Category("Narmaya")]
        [DefaultValue(AllWeaponObjId.Narmaya_Blade_of_Purification)]
        public AllWeaponObjId Narmaya_BladeofPurification { get; set; } = AllWeaponObjId.Narmaya_Blade_of_Purification;

        [DisplayName("Ameno Habakiri")]
        [Category("Narmaya")]
        [DefaultValue(AllWeaponObjId.Narmaya_Ameno_Habakiri)]
        public AllWeaponObjId Narmaya_AmenoHabakiri { get; set; } = AllWeaponObjId.Narmaya_Ameno_Habakiri;

        // 1500
        [DisplayName("Brahma Gauntlet")]
        [Category("Ghandagoza")]
        [DefaultValue(AllWeaponObjId.Ghandagoza_Brahma_Gauntlet)]
        public AllWeaponObjId Ghandagoza_BrahmaGauntlet { get; set; } = AllWeaponObjId.Ghandagoza_Brahma_Gauntlet;

        [DisplayName("Rope Knuckles")]
        [Category("Ghandagoza")]
        [DefaultValue(AllWeaponObjId.Ghandagoza_Rope_Knuckles)]
        public AllWeaponObjId Ghandagoza_RopeKnuckles { get; set; } = AllWeaponObjId.Ghandagoza_Rope_Knuckles;

        [DisplayName("Crimson Finger")]
        [Category("Ghandagoza")]
        [DefaultValue(AllWeaponObjId.Ghandagoza_Crimson_Finger)]
        public AllWeaponObjId Ghandagoza_CrimsonFinger { get; set; } = AllWeaponObjId.Ghandagoza_Crimson_Finger;

        [DisplayName("Golden Fists of Ura")]
        [Category("Ghandagoza")]
        [DefaultValue(AllWeaponObjId.Ghandagoza_Golden_Fists_of_Ura)]
        public AllWeaponObjId Ghandagoza_GoldenFistsOfUra { get; set; } = AllWeaponObjId.Ghandagoza_Golden_Fists_of_Ura;

        [DisplayName("Arkab")]
        [Category("Ghandagoza")]
        [DefaultValue(AllWeaponObjId.Ghandagoza_Arkab)]
        public AllWeaponObjId Ghandagoza_Arkab { get; set; } = AllWeaponObjId.Ghandagoza_Arkab;

        [DisplayName("Sky Piercer")]
        [Category("Ghandagoza")]
        [DefaultValue(AllWeaponObjId.Ghandagoza_Sky_Piercer)]
        public AllWeaponObjId Ghandagoza_SkyPiercer { get; set; } = AllWeaponObjId.Ghandagoza_Sky_Piercer;

        // 1600
        [DisplayName("Spear of Arvess")]
        [Category("Zeta")]
        [DefaultValue(AllWeaponObjId.Zeta_Spear_of_Arvess)]
        public AllWeaponObjId Zeta_SpearofArvess { get; set; } = AllWeaponObjId.Zeta_Spear_of_Arvess;

        [DisplayName("Sunspot Spear")]
        [Category("Zeta")]
        [DefaultValue(AllWeaponObjId.Zeta_Sunspot_Spear)]
        public AllWeaponObjId Zeta_Sunspot_Spear { get; set; } = AllWeaponObjId.Zeta_Sunspot_Spear;

        [DisplayName("Brionac")]
        [Category("Zeta")]
        [DefaultValue(AllWeaponObjId.Zeta_Brionac)]
        public AllWeaponObjId Zeta_Brionac { get; set; } = AllWeaponObjId.Zeta_Brionac;

        [DisplayName("Gisla")]
        [Category("Zeta")]
        [DefaultValue(AllWeaponObjId.Zeta_Gisla)]
        public AllWeaponObjId Zeta_Gisla { get; set; } = AllWeaponObjId.Zeta_Gisla;

        [DisplayName("Huanglong Spear")]
        [Category("Zeta")]
        [DefaultValue(AllWeaponObjId.Zeta_Huanglong_Spear)]
        public AllWeaponObjId Zeta_HuanglongSpear { get; set; } = AllWeaponObjId.Zeta_Huanglong_Spear;

        [DisplayName("Gae Bulg")]
        [Category("Zeta")]
        [DefaultValue(AllWeaponObjId.Zeta_Gae_Bulg)]
        public AllWeaponObjId Zeta_GaeBulg { get; set; } = AllWeaponObjId.Zeta_Gae_Bulg;

        // 1700
        [DisplayName("Great Scythe Grynoth")]
        [Category("Vaseraga")]
        [DefaultValue(AllWeaponObjId.Vaseraga_Great_Scythe_Grynoth)]
        public AllWeaponObjId Vaseraga_GreatScytheGrynoth { get; set; } = AllWeaponObjId.Vaseraga_Great_Scythe_Grynoth;

        [DisplayName("Alsarav")]
        [Category("Vaseraga")]
        [DefaultValue(AllWeaponObjId.Vaseraga_Alsarav)]
        public AllWeaponObjId Vaseraga_Alsarav { get; set; } = AllWeaponObjId.Vaseraga_Alsarav;

        [DisplayName("Wurtzite Scythe")]
        [Category("Vaseraga")]
        [DefaultValue(AllWeaponObjId.Vaseraga_Wurtzite_Scythe)]
        public AllWeaponObjId Vaseraga_WurtziteScythe { get; set; } = AllWeaponObjId.Vaseraga_Wurtzite_Scythe;

        [DisplayName("Soul Eater")]
        [Category("Vaseraga")]
        [DefaultValue(AllWeaponObjId.Vaseraga_Soul_Eater)]
        public AllWeaponObjId Vaseraga_SoulEater { get; set; } = AllWeaponObjId.Vaseraga_Soul_Eater;

        [DisplayName("Cosmic Scythe")]
        [Category("Vaseraga")]
        [DefaultValue(AllWeaponObjId.Vaseraga_Cosmic_Scythe)]
        public AllWeaponObjId Vaseraga_CosmicScythe { get; set; } = AllWeaponObjId.Vaseraga_Cosmic_Scythe;

        [DisplayName("Ereshkigal")]
        [Category("Vaseraga")]
        [DefaultValue(AllWeaponObjId.Vaseraga_Ereshkigal)]
        public AllWeaponObjId Vaseraga_Ereshkigal { get; set; } = AllWeaponObjId.Vaseraga_Ereshkigal;

        // 1800
        [DisplayName("Magnum Opus")]
        [Category("Cagliostro")]
        [DefaultValue(AllWeaponObjId.Cagliostro_Magnum_Opus)]
        public AllWeaponObjId Cagliostro_MagnumOpus { get; set; } = AllWeaponObjId.Cagliostro_Magnum_Opus;

        [DisplayName("Dream Atlas")]
        [Category("Cagliostro")]
        [DefaultValue(AllWeaponObjId.Cagliostro_Dream_Atlas)]
        public AllWeaponObjId Cagliostro_DreamAtlas { get; set; } = AllWeaponObjId.Cagliostro_Dream_Atlas;

        [DisplayName("Transmigration Tome")]
        [Category("Cagliostro")]
        [DefaultValue(AllWeaponObjId.Cagliostro_Transmigration_Tome)]
        public AllWeaponObjId Cagliostro_TransmigrationTome { get; set; } = AllWeaponObjId.Cagliostro_Transmigration_Tome;

        [DisplayName("Sacred Codex")]
        [Category("Cagliostro")]
        [DefaultValue(AllWeaponObjId.Cagliostro_Sacred_Codex)]
        public AllWeaponObjId Cagliostro_SacredCodex { get; set; } = AllWeaponObjId.Cagliostro_Sacred_Codex;

        [DisplayName("Arshivelle")]
        [Category("Cagliostro")]
        [DefaultValue(AllWeaponObjId.Cagliostro_Arshivelle)]
        public AllWeaponObjId Cagliostro_Arshivelle { get; set; } = AllWeaponObjId.Cagliostro_Arshivelle;

        [DisplayName("Zosimos")]
        [Category("Cagliostro")]
        [DefaultValue(AllWeaponObjId.Cagliostro_Zosimos)]
        public AllWeaponObjId Cagliostro_Zosimos { get; set; } = AllWeaponObjId.Cagliostro_Zosimos;

        // 1900
        [DisplayName("Ragnarok")]
        [Category("Id")]
        [DefaultValue(AllWeaponObjId.Id_Ragnarok)]
        public AllWeaponObjId Id_Ragnarok { get; set; } = AllWeaponObjId.Id_Ragnarok;

        [DisplayName("Aviaeth Faussart")]
        [Category("Id")]
        [DefaultValue(AllWeaponObjId.Id_Aviaeth_Faussart)]
        public AllWeaponObjId Id_AviaethFaussart { get; set; } = AllWeaponObjId.Id_Aviaeth_Faussart;

        [DisplayName("Susanoo")]
        [Category("Id")]
        [DefaultValue(AllWeaponObjId.Id_Susanoo)]
        public AllWeaponObjId Id_Susanoo { get; set; } = AllWeaponObjId.Id_Susanoo;

        [DisplayName("Premium Sword")]
        [Category("Id")]
        [DefaultValue(AllWeaponObjId.Id_Premium_Sword)]
        public AllWeaponObjId Id_PremiumSword { get; set; } = AllWeaponObjId.Id_Premium_Sword;

        [DisplayName("Ecke Sachs")]
        [Category("Id")]
        [DefaultValue(AllWeaponObjId.Id_Ecke_Sachs)]
        public AllWeaponObjId Id_EckeSachs { get; set; } = AllWeaponObjId.Id_Ecke_Sachs;

        [DisplayName("Sword of Bahamut")]
        [Category("Id")]
        [DefaultValue(AllWeaponObjId.Id_Sword_of_Bahamut)]
        public AllWeaponObjId Id_SwordofBahamut { get; set; } = AllWeaponObjId.Id_Sword_of_Bahamut;

        // 2200
        [DisplayName("Sette di Spade")]
        [Category("Seofon")]
        [DefaultValue(AllWeaponObjId.Seofon_Sette_di_Spade)]
        public AllWeaponObjId Seofon_SettediSpade { get; set; } = AllWeaponObjId.Seofon_Sette_di_Spade;

        [DisplayName("Gateway-Star Sword")]
        [Category("Seofon")]
        [DefaultValue(AllWeaponObjId.Seofon_Gateway_Star_Sword)]
        public AllWeaponObjId Seofon_GatewayStarSword { get; set; } = AllWeaponObjId.Seofon_Gateway_Star_Sword;

        // 2300
        [DisplayName("Bow of Dismissal")]
        [Category("Tweyen")]
        [DefaultValue(AllWeaponObjId.Tweyen_Bow_of_Dismissal)]
        public AllWeaponObjId Tweyen_BowofDismissal { get; set; } = AllWeaponObjId.Tweyen_Bow_of_Dismissal;

        [DisplayName("Desolation-Crown Bow")]
        [Category("Tweyen")]
        [DefaultValue(AllWeaponObjId.Tweyen_Desolation_Crown_Bow)]
        public AllWeaponObjId Tweyen_DesolationCrownBow { get; set; } = AllWeaponObjId.Tweyen_Desolation_Crown_Bow;

        // 2300
        [DisplayName("Apprentice")]
        [Category("Sandalphon")]
        [DefaultValue(AllWeaponObjId.Sandalphon_Apprentice)]
        public AllWeaponObjId Sandalphon_Apprentice { get; set; } = AllWeaponObjId.Sandalphon_Apprentice;

        [DisplayName("Sandalphon Placeholder2")]
        [Category("Sandalphon")]
        [DefaultValue(AllWeaponObjId.Sandalphon_WorldEnder)]
        public AllWeaponObjId Sandalphon_WorldEnder { get; set; } = AllWeaponObjId.Sandalphon_WorldEnder;

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
