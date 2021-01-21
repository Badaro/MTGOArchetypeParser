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
#01 JoshicallsmeFabo: Humans (WUBRG)
#02 PuntThenWhine: Amulet Titan (UG)
#03 helvetti: Dredge (BRG)
#04 Jositoshekel: Burn (WR)
#05 Matti: Dredge (BRG)
#06 ecobaronen: Bant Control (WUG)
#07 timewalkinonsunshine: Taking Turns (URG)
#08 NorrathDecay: Burn (WR)
#09 Masumaro: Temur Midrange (URG)
#10 Mlgb92: Jund Midrange (BRG)
#11 sff_mtg: Green Tron (G)
#12 MATTOMARINAIO: Uroza (URG)
#13 SIKOSLOVAKE: Mono Red Prowess (R)
#14 oskiyaa: Humans (WUBRG)
#15 Hampuse1: Eldrazi Tron (C)
#16 Tycko_D: Mono Red Prowess (R)
#17 matyo804: Titan Shift (RG)
#18 Game_Night: Green Tron (G)
#19 Trid0n: Humans (WUBRG)
#20 Metal_Buddha: Rakdos Midrange (BR)
#21 ComradeKahla: Bant Control (WUG)
#22 Oscar_Franco: Titan Shift (RG)
#23 Team5c: Thopter Urza (UB)
#24 SakeIzumo: Mono Red Prowess (R)
#25 ArchaeusDota: Eldrazi Tron (C)
#26 brainstorm39: WURG Control (WURG)
#27 genmatsu: Infect (UG)
#28 WhiTe TsaR: Bant Control (WUG)
#29 MesklateBrother: Amulet Titan (UG)
#30 idutra: Gruul Midrange (RG)
#31 TFTIjhub: Eldrazi Tron (C)
#32 selbstdenker: Amulet Titan (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_super_qualifier_2020_03_22 : EventTest
    {
        [Test]
        public void Deck01_JoshicallsmeFabo_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",0),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck02_PuntThenWhine_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",1),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck03_helvetti_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",2),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Jositoshekel_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",3),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck05_Matti_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",4),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck06_ecobaronen_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",5),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",6),
                "PostOuatBan",
                ArchetypeColor.URG,
                "TakingTurns",
                null,
                null
            );
        }

        [Test]
        public void Deck08_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",7),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck09_Masumaro_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",8),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Mlgb92_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",9),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_sffmtg_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",10),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck12_MATTOMARINAIO_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",11),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck13_SIKOSLOVAKE_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",12),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck14_oskiyaa_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",13),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Hampuse1_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",14),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck16_TyckoD_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",15),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck17_matyo804_TitanShift_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",16),
                "PostOuatBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck18_GameNight_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",17),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck19_Trid0n_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",18),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck20_MetalBuddha_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",19),
                "PostOuatBan",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_ComradeKahla_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",20),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_OscarFranco_TitanShift_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",21),
                "PostOuatBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck23_Team5c_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",22),
                "PostOuatBan",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck24_SakeIzumo_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",23),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck25_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",24),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck26_brainstorm39_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",25),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck27_genmatsu_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",26),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck28_WhiTeTsaR_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",27),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck29_MesklateBrother_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",28),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck30_idutra_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",29),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck31_TFTIjhub_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",30),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck32_selbstdenker_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-22",31),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }


    }
}
