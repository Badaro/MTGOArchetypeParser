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
#01 SunofNothing: Uroza (URG)
#02 ConnorM426: Bant Control (WUG)
#03 ScreenwriterNY: Bushwhacker Zoo (WRG)
#04 _Phoenix_: Amulet Titan (UG)
#05 dionykos: Bant Control (WUG)
#06 starfall: Humans (WUBRG)
#07 retiredcapivara: Titan Shift (RG)
#08 manoah: Jund Midrange (BRG)
#09 Fayrawks: Humans (WUBRG)
#10 raisans: Gruul Midrange (RG)
#11 MesklateBrother: Amulet Titan (G)
#12 TheTunnelingCat: Eldrazi Tron (C)
#13 andy_m_hovis: Green Tron (G)
#14 SlyDaniel7787: Eldrazi Tron (C)
#15 Kungpowpow: Green Tron (G)
#16 katoriarch123: Bant Control (WUG)
#17 ReturnToDust: Eldrazi Tron (C)
#18 kthanakit26: Burn (WR)
#19 D00mwake: Humans (WUBRG)
#20 Samwise_GeeGee: Scapeshift (WURG)
#21 billsive: Temur Control (URG)
#22 APAKane: Green Tron (G)
#23 instantdeath929: Amulet Titan (G)
#24 _LSN_: Burn (WR)
#25 sydneydude: Uroza (URG)
#26 AstralPlane: Mono Red Prowess (R)
#27 Laplasjan: Eldrazi Tron (C)
#28 PTarts2win: Green Tron (G)
#29 snapcaster____mage: Eldrazi Tron (C)
#30 nahuel10: Burn (WR)
#31 TSPJendrek: WUBG Control (WUBG)
#32 NoWa1: WURG Control (WURG)
#33 Darkiundsa: Bant Control (WUG)
#34 Sprouts: Jund Midrange (BRG)
#35 Andrea94: Green Tron (G)
#36 MastaHorus: Electro End (UR)
#37 ComradeCoheed: Uroza (URG)
#38 pulpo87: Jund Midrange (BRG)
#39 FreeBobby315: Mono Red Prowess (R)
#40 UsaZ: Superfriends (WUBRG)
#41 xfile: Uroza (URG)
#42 sicsmoo: Green Tron (G)
#43 LSMD: Green Tron (G)
#44 swiftwarkite2: Amulet Titan (UG)
#45 ThePainTrain9: Humans (WUBRG)
#46 max_9: Izzet Control (UR)
#47 Tarrasque1: Elementals (WUBRG)
#48 TeddyMemes: WUBG Control (WUBG)
#49 Daking3603: Mono Red Prowess (R)
#50 Dia83: Amulet Titan (G)
#51 1yo2yo: Bant Control (WUG)
#52 frylokk757: Gruul Midrange (RG)
#53 brothernova: Eldrazi Tron (C)
#54 rn17: Thopter Urza (UBR)
#55 instantQ: Burn (WR)
#56 NMT_Sco94: Electro End (UR)
#57 Moniz0801: Amulet Titan (G)
#58 Katla: Living End (UB)
#59 DayOfClutch: Burn (WR)
#60 forenmagra: Saheeli Combo (WUBRG)
#61 Blahh800: Devoted (WG)
#62 Shadowz2005: Jund Shadow (BRG)
#63 joker10289: Gruul Midrange (RG)
#64 barkjon: Gifts Storm (UR)
#65 12azor: UBRG Shadow (UBRG)
#66 tutajec: Humans (WUBRG)
#67 Sir_NhaKa: Green Tron (G)
#68 FestiFan: Saheeli Combo (WURG)
#69 hcook725: Uroza (URG)
#70 fatkiddestroyers: Bant Midrange (WUG)
#71 Do0mSwitch: Bant Control (WUG)
#72 bit_error: Burn (WR)
#73 Boin: Gruul Midrange (RG)
#74 Gernardi: Jund Midrange (BRG)
#75 markdizon: Jund Midrange (BRG)
#76 exoticherman: Jund Midrange (BRG)
#77 Misplacedginger: Bant Control (WUG)
#78 Graciasportanto: Uroza (URG)
#79 HarlanMTG: Bant Control (WUG)
#80 SourceOdin: Primeval Titan (UG)
#81 limp22: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_24 : EventTest
    {
        [Test]
        public void Deck01_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",0),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck02_ConnorM426_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",1),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ScreenwriterNY_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",2),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Phoenix_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",3),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck05_dionykos_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",4),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_starfall_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",5),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck07_retiredcapivara_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",6),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck08_manoah_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",7),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Fayrawks_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",8),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_raisans_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",9),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_MesklateBrother_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",10),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",11),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck13_andymhovis_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",12),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck14_SlyDaniel7787_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",13),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_Kungpowpow_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",14),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck16_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",15),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_ReturnToDust_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",16),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",17),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck19_D00mwake_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",18),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck20_SamwiseGeeGee_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",19),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck21_billsive_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",20),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_APAKane_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",21),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck23_instantdeath929_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",22),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",23),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck25_sydneydude_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",24),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck26_AstralPlane_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",25),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Laplasjan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",26),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck28_PTarts2win_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",27),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck29_snapcastermage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",28),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck30_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",29),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck31_TSPJendrek_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",30),
                new PostOuatBan(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_NoWa1_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",31),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Darkiundsa_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",32),
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
                GetDeck("modern-preliminary-2020-03-24",33),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Andrea94_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",34),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck36_MastaHorus_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",35),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck37_ComradeCoheed_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",36),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck38_pulpo87_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",37),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck39_FreeBobby315_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",38),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck40_UsaZ_Superfriends_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",39),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Superfriends),
                null,
                null
            );
        }

        [Test]
        public void Deck41_xfile_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",40),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck42_sicsmoo_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",41),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck43_LSMD_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",42),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck44_swiftwarkite2_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",43),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck45_ThePainTrain9_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",44),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck46_max9_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",45),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Tarrasque1_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",46),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck48_TeddyMemes_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",47),
                new PostOuatBan(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Daking3603_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",48),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Dia83_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",49),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck51_1yo2yo_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",50),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_frylokk757_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",51),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck53_brothernova_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",52),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck54_rn17_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",53),
                new PostOuatBan(),
                ArchetypeColor.UBR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck55_instantQ_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",54),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck56_NMTSco94_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",55),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck57_Moniz0801_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",56),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck58_Katla_LivingEnd_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",57),
                new PostOuatBan(),
                ArchetypeColor.UB,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck59_DayOfClutch_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",58),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck60_forenmagra_SaheeliCombo_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",59),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck61_Blahh800_Devoted_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",60),
                new PostOuatBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck62_Shadowz2005_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",61),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck63_joker10289_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",62),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck64_barkjon_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",63),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck65_12azor_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",64),
                new PostOuatBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck66_tutajec_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",65),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck67_SirNhaKa_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",66),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck68_FestiFan_SaheeliCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",67),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck69_hcook725_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",68),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck70_fatkiddestroyers_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",69),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck71_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",70),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck72_biterror_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",71),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck73_Boin_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",72),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck74_Gernardi_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",73),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck75_markdizon_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",74),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck76_exoticherman_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",75),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck77_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",76),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck78_Graciasportanto_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",77),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck79_HarlanMTG_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",78),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck80_SourceOdin_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",79),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck81_limp22_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-24",80),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
