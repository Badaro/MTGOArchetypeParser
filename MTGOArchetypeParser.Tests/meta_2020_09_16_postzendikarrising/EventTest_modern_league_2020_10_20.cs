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
#01 kazuhiko: Jeskai Control (WUR)
#02 Kev_1414: Dredge (BRG)
#03 yunari-456: Izzet Prowess (UR)
#04 DcNo: Humans (WUBRG)
#05 OnDutyMedic: Snoop Goblins (BR)
#06 wefaldbot: Inverter (UB)
#07 Tc1990: Bant Blink (WUG)
#08 merfolkgod: Incinerator Burn (R)
#09 Brosterman: Bant Midrange (WUG)
#10 Maccaciock: Izzet Control (UR)
#11 MartinezDP: Sultai Control (UBG, Yorion)
#12 Raptor_Nachos: Mono Red Prowess (R, Jegantha)
#13 Gakihare: Izzet Prowess (UR)
#14 fradev1988: Azorius Control (WU)
#15 crazybaloth: Devoted (WG, Lurrus)
#16 Nis2a: Hardened Scales (WG, Lurrus)
#17 lovepsy: Heliod Devoted (WG)
#18 Trellon: U Tron (U)
#19 dbroncs1: Golgari Midrange (BG)
#20 DoctorQueller: Spirits (WU)
#21 Zxrogue: Yawgmoth (BG)
#22 StreexIT: Bant Spirits (WUG)
#23 Parrit: Mono White Taxes (W)
#24 Satelitbg123: Izzet Control (UR)
#25 _Makaveli: Azorius Control (WU)
#26 Gubsly: Eight Rack (B)
#27 seasonofmists: Abzan Eldrazi Taxes (WBG)
#28 __Ghost__: Zombies (UB)
#29 AJOCHUM: WURG Control (WURG)
#30 CavalloGoloso: Azorius Control (WU)
#31 FedeG: Heliod Combo (WG)
#32 axk2: Neobrand (UG)
#33 Antoine57437: WURG Blink (WURG)
#34 Selfeisek: Living End (BRG)
#35 hugofreitas1: Izzet Restore Balance (URG)
#36 klien7: Oops All Spells (WUBRG)
#37 Salva1994: Merfolk (WU, Lurrus)
#38 TheDogFish: Merfolk (UG)
#39 IPlayBadDecks: Jeskai Breach (WURG, Jegantha)
#40 esseelle: Boros Land Destruction (WR)
#41 MadMaxErnst: Zombie Shadow (BR, Lurrus)
#42 katoriarch123: Bant Control (WUG)
#43 karavek: Amulet Titan (WUBRG)
#44 CyricCanela: Gruul Midrange (RG)
#45 4pC-AlteC: Elves (G)
#46 aspiringspike: Azorius Control (WU)
#47 Heiring: KGC Tron (G)
#48 TuggaNaxos: Dredge (UBR)
#49 mala_grinja: Belcher (RG)
#50 Mulldrifter: Shadow Prowess (BR, Lurrus)
#51 Rakdos91: Hardened Scales (G)
#52 ragnarboy: Infect (BG)
#53 N3to: Gifts Storm (UR)
#54 Alakhai: Shadow Prowess (BR, Lurrus)
#55 Pilototo: Jund Shadow (BRG)
#56 bant_is_love: Reclaimer Titan (WURG)
#57 HNmagician: Mill (UB)
#58 kensportsfan: Mono Red Prowess (R)
#59 bomberboss: Orzhov Midrange (WB)
#60 TheKG: Omnath Saheeli (WURG, Jegantha)
#61 Antoine57437: Abzan Company (WBRG)
#62 StreexIT: Spirits (WUBRG)
#63 qbturtle15: Jund Midrange (BRG)
#64 SaborDeSoledad: Boros Land Destruction (WR, Zirda)
#65 Sam_Lewin: Boros Land Destruction (WBR)
#66 pacoelflaco: Burn (WR)
#67 Hitokiri1984: Rakdos Midrange (BR)
#68 Zanman: Taking Turns (UBG)
#69 Mateusf34: E Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_10_20 : EventTest
    {
        [Test]
        public void Deck01_kazuhiko_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",0),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Kev1414_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",1),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_yunari456_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_DcNo_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_OnDutyMedic_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck06_wefaldbot_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-20",5),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Tc1990_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",6),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck08_merfolkgod_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-10-20",7),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck09_Brosterman_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",8),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Maccaciock_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",9),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_MartinezDP_SultaiControl_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-20",10),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_RaptorNachos_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-20",11),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_Gakihare_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",12),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_fradev1988_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-20",13),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_crazybaloth_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-20",14),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Nis2a_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-20",15),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_lovepsy_HeliodDevoted_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",16),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck18_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-10-20",17),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck19_dbroncs1_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",18),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-20",19),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Zxrogue_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",20),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck22_StreexIT_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",21),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck23_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-20",22),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Satelitbg123_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",23),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Makaveli_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-20",24),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Gubsly_EightRack_B()
        {
            Test(
                GetDeck("modern-league-2020-10-20",25),
                new PostZendikarRising(),
                ArchetypeColor.B,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck27_seasonofmists_AbzanEldraziTaxes_WBG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",26),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Ghost_Zombies_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-20",27),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Zombies),
                null,
                null
            );
        }

        [Test]
        public void Deck29_AJOCHUM_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",28),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_CavalloGoloso_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-20",29),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_FedeG_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",30),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck32_axk2_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",31),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Antoine57437_WURGBlink_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",32),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Selfeisek_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",33),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck35_hugofreitas1_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",34),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck36_klien7_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",35),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Salva1994_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-20",36),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck38_TheDogFish_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",37),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck39_IPlayBadDecks_JeskaiBreach_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-20",38),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck40_esseelle_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",39),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck41_MadMaxErnst_ZombieShadow_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-20",40),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ZombieShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck42_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",41),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck43_karavek_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",42),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck44_CyricCanela_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",43),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck45_4pCAlteC_Elves_G()
        {
            Test(
                GetDeck("modern-league-2020-10-20",44),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Elves),
                null,
                null
            );
        }

        [Test]
        public void Deck46_aspiringspike_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-20",45),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Heiring_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-10-20",46),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck48_TuggaNaxos_Dredge_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",47),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck49_malagrinja_Belcher_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",48),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Mulldrifter_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-20",49),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck51_Rakdos91_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-10-20",50),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck52_ragnarboy_Infect_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",51),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck53_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",52),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Alakhai_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-20",53),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck55_Pilototo_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",54),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck56_bantislove_ReclaimerTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",55),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck57_HNmagician_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-20",56),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck58_kensportsfan_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-10-20",57),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck59_bomberboss_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-10-20",58),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck60_TheKG_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-20",59),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck61_Antoine57437_AbzanCompany_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",60),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(AbzanCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck62_StreexIT_Spirits_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",61),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck63_qbturtle15_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",62),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck64_SaborDeSoledad_BorosLandDestruction_WR_Zirda()
        {
            Test(
                GetDeck("modern-league-2020-10-20",63),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck65_SamLewin_BorosLandDestruction_WBR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",64),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck66_pacoelflaco_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",65),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck67_Hitokiri1984_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-20",66),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck68_Zanman_TakingTurns_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-20",67),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck69_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-10-20",68),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }


    }
}
