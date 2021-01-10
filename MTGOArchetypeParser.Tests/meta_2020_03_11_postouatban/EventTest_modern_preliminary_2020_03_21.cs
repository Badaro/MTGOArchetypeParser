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
#01 instantdeath929: Amulet Titan (G)
#02 twinlesstwin: Uroza (URG)
#03 Mordeka1ser: Niv To Light (WUBRG)
#04 sydneydude: Uroza (URG)
#05 bigjc00: Eldrazi Tron (C)
#06 yamakiller: Titan Shift (RG)
#07 Parrotlet: Amulet Titan (UG)
#08 Rav104: Primeval Titan (UG)
#09 PRGJJAR: Dredge (BRG)
#10 Sungjin: Scapeshift (WURG)
#11 phol: Bant Control (WUG)
#12 BlindNavigator: Green Tron (G)
#13 ThePainTrain9: Eldrazi Tron (C)
#14 The_NotSure: Green Tron (G)
#15 bradyoo: Ad Nauseam (WUB)
#16 Dafne17: Gruul Midrange (RG)
#17 Rockbard_13: Humans (WUBRG)
#18 leclairandy: Green Tron (G)
#19 gyyby297: Thopter Urza (UB)
#20 derk714: Bant Control (WUG)
#21 MiamiKidz: Green Tron (G)
#22 HarlanMTG: Bant Control (WUG)
#23 VampireGodric: Green Tron (G)
#24 RogerSteady: Grixis Midrange (UBR)
#25 saluman: Ad Nauseam (WUB)
#26 bubblebathing: Hollow One (BR)
#27 Mobog: Jund Midrange (BRG)
#28 Lord_of_Puntlantis: Ad Nauseam (WUB)
#29 andrehicks: Dredge (BRG)
#30 xXxL3G10NxXx: Infect (UG)
#31 Finalnub: Green Tron (G)
#32 Fayrawks: Thopter Urza (WUR)
#33 Lavaridge: Bant Control (WUG)
#34 Sprouts: Jund Midrange (BRG)
#35 ltldude123: Grinding Breach (WUR)
#36 futiboladex: Bant Control (WUG)
#37 dstathis: Eight Rack (B)
#38 _Tim: Grinding Breach (WUR)
#39 Icteridae: Devoted (WUG)
#40 Nammersquats: Titan Shift (RG)
#41 Critchkn: Infect (UG)
#42 exoticherman: Sultai Midrange (UBG)
#43 kthanakit26: Green Tron (G)
#44 ComradeCoheed: Uroza (URG)
#45 Shadowz2005: Jund Shadow (BRG)
#46 bamzing: Eldrazi Tron (C)
#47 _INF_: Jund Midrange (BRG)
#48 Draconic1: Phoenix (UR)
#49 WingedHussar: Neobrand (UG)
#50 luxcel: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_21 : EventTest
    {
        [Test]
        public void Deck01_instantdeath929_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",0),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_twinlesstwin_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",1),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Mordeka1ser_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",2),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck04_sydneydude_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",3),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck05_bigjc00_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",4),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck06_yamakiller_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",5),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck07_Parrotlet_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",6),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_Rav104_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",7),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck09_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",8),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Sungjin_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",9),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck11_phol_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",10),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_BlindNavigator_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",11),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck13_ThePainTrain9_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",12),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_TheNotSure_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",13),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck15_bradyoo_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",14),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Dafne17_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",15),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Rockbard13_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",16),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck18_leclairandy_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",17),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck19_gyyby297_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",18),
                new PostOuatBan(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck20_derk714_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",19),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_MiamiKidz_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",20),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck22_HarlanMTG_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",21),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_VampireGodric_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",22),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck24_RogerSteady_GrixisMidrange_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",23),
                new PostOuatBan(),
                ArchetypeColor.UBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_saluman_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",24),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck26_bubblebathing_HollowOne_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",25),
                new PostOuatBan(),
                ArchetypeColor.BR,
                typeof(HollowOne),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Mobog_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",26),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_LordofPuntlantis_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",27),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck29_andrehicks_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",28),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck30_xXxL3G10NxXx_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",29),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Finalnub_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",30),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck32_Fayrawks_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",31),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck33_Lavaridge_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",32),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Sprouts_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",33),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck35_ltldude123_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",34),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck36_futiboladex_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",35),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck37_dstathis_EightRack_B()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",36),
                new PostOuatBan(),
                ArchetypeColor.B,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Tim_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",37),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",38),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Nammersquats_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",39),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck41_Critchkn_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",40),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck42_exoticherman_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",41),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck43_kthanakit26_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",42),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck44_ComradeCoheed_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",43),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Shadowz2005_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",44),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck46_bamzing_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",45),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck47_INF_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",46),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Draconic1_Phoenix_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",47),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(Phoenix),
                null,
                null
            );
        }

        [Test]
        public void Deck49_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",48),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck50_luxcel_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-21",49),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}
