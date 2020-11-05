using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Patxi: Omnath Saheeli (WURG, Jegantha)
#02 DavidSnake: Dredge (BRG)
#03 MTGnextlevel: Rakdos Prowess (BR, Lurrus)
#04 pbarrrgh: Simic Control (UG)
#05 Weasley: Sultai Control (UBG, Yorion)
#06 seasonofmists: Abzan Taxes (WBG)
#07 FalseMufn: U Tron (U)
#08 Capiplaf95: Burn (WR)
#09 apriolo1: Amulet Titan (WRG)
#10 Zonast: Grixis Delver (UBR, Lurrus)
#11 NHA37: Heliod Combo (W)
#12 KoKonuts: G Tron (G, Jegantha)
#13 HouseOfManaMTG: Amulet Titan (UBRG)
#14 nahuel10: Izzet Prowess (UR)
#15 Kurusu: Kiki Chord (WRG, Yorion)
#16 2jjm: Humans (WUBRG)
#17 Selfeisek: Living End (BRG)
#18 ragnarboy: Infect (BG)
#19 CarnageSLV: Gruul Midrange (RG)
#20 gyyby297: Oops All Spells (WUBRG)
#21 Amplumnox: Shadow Prowess (BR, Lurrus)
#22 bbotonline: WURG Control (WURG)
#23 The_nayr: Naya Midrange (WRG)
#24 BananaJim22: Izzet Restore Balance (UR)
#25 Magric: Mill (UB)
#26 SpicyLeche: Jund Shadow (BRG)
#27 trollasceticftw: Urza Prison (UR)
#28 TooManyCookes: Jeskai Control (WUR)
#29 khangmtg: Belcher (WURG)
#30 mashmalovsky: Titan Stompy (BRG, Gyruda)
#31 Teston: Shadow Prowess (WBR, Lurrus)
#32 PlebSwagger: Obosh Aggro (R, Obosh)
#33 wynn1006: Izzet Control (UR)
#34 oskiyaa: Devoted (WG)
#35 Gabriel_Sylar: Jund Midrange (BRG)
#36 Kenzaburo: Azorius Control (WU)
#37 balltap: Jeskai Breach (WURG, Jegantha)
#38 Beicodegeia: Gifts Storm (UR)
#39 GrandpaBiceps: Rakdos Midrange (BR)
#40 420PrayIt: Selesnya Eldrazi (WG, Jegantha)
#41 Jedermann: Snoop Goblins (BR)
#42 Hosaboy: Azorius Control (WU)
#43 122pablo: Heliod Combo (WG)
#44 SaborDeSoledad: Boros Land Destruction (WR, Zirda)
#45 BSK_hercules: Titan Shift (RG)
#46 YugiMoto: Reclaimer Titan (WRG)
#47 deathandcatmix: Mono White Taxes (W)
#48 coliobeware: Jund Midrange (BRG, Lurrus)
#49 MrSeri: Heliod Combo (WG)
#50 DoctorQueller: Bant Spirits (WUG)
#51 BSK_hercules: Sultai Control (UBG)
#52 culkey: Yawgmoth (BG)
#53 ghostx02: Mill (UB, Lurrus)
#54 mashmalovsky: Hammer Time (WR, Lurrus)
#55 Awesome7574: Bant Control (WUG, Yorion)
#56 fuma-mtgcampinas: E Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_10_16 : EventTest
    {
        [Test]
        public void Deck01_Patxi_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-16",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck02_DavidSnake_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",1),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_MTGnextlevel_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-16",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_pbarrrgh_SimicControl_UG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",3),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Weasley_SultaiControl_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-16",4),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_seasonofmists_AbzanTaxes_WBG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",5),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck07_FalseMufn_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-10-16",6),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Capiplaf95_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-16",7),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_apriolo1_AmuletTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",8),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_Zonast_GrixisDelver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-16",9),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(Delver),
                typeof(GrixisDelver),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_NHA37_HeliodCombo_W()
        {
            Test(
                GetDeck("modern-league-2020-10-16",10),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck12_KoKonuts_GTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-16",11),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_HouseOfManaMTG_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",12),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-16",13),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-16",14),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_2jjm_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",15),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Selfeisek_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",16),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck18_ragnarboy_Infect_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",17),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck19_CarnageSLV_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",18),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_gyyby297_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",19),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Amplumnox_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-16",20),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_bbotonline_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",21),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Thenayr_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",22),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_BananaJim22_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-16",23),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck25_Magric_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-16",24),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck26_SpicyLeche_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",25),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck27_trollasceticftw_UrzaPrison_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-16",26),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(UrzaPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck28_TooManyCookes_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-16",27),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_khangmtg_Belcher_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",28),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck30_mashmalovsky_TitanStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-10-16",29),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(TitanStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck31_Teston_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-16",30),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_PlebSwagger_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-10-16",31),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck33_wynn1006_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-16",32),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_oskiyaa_Devoted_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",33),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck35_GabrielSylar_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",34),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck36_Kenzaburo_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-16",35),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck37_balltap_JeskaiBreach_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-16",36),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck38_Beicodegeia_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-16",37),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck39_GrandpaBiceps_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-16",38),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck40_420PrayIt_SelesnyaEldrazi_WG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-16",39),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(SelesnyaEldrazi),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck41_Jedermann_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-16",40),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck42_Hosaboy_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-16",41),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck43_122pablo_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",42),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck44_SaborDeSoledad_BorosLandDestruction_WR_Zirda()
        {
            Test(
                GetDeck("modern-league-2020-10-16",43),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck45_BSKhercules_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",44),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck46_YugiMoto_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",45),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck47_deathandcatmix_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-16",46),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck48_coliobeware_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-16",47),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck49_MrSeri_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",48),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck50_DoctorQueller_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",49),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck51_BSKhercules_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",50),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_culkey_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-16",51),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck53_ghostx02_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-16",52),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck54_mashmalovsky_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-16",53),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck55_Awesome7574_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-16",54),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck56_fumamtgcampinas_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-10-16",55),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }


    }
}
