using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 MATTOMARINAIO: Burn (WR)
#02 AnneLivleysD3ath: Amulet Titan (UG)
#03 Ziojimbo: Amulet Titan (UG)
#04 Roald: Green Tron (G)
#05 Diem4x: Bant Control (WUG)
#06 MdvWin: Burn (WR)
#07 SIN: Uroza (URG)
#08 Brener: Jund Midrange (BRG)
#09 signblindman: Gruul Midrange (RG)
#10 Alrawn: Green Tron (G)
#11 TrollingSaruman: Gruul Midrange (RG)
#12 LiturgijskaKnjiga: Infect (UG)
#13 JV_7777: Dredge (UBRG)
#14 Jenara19: Uroza (WUG)
#15 TrueHero: Temur Midrange (URG)
#16 __BMJ__: Gruul Midrange (RG)
#17 mansak: Jund Midrange (BRG)
#18 Fatcaster_Mage: Thopter Urza (WUR)
#19 La_Biscia: Gruul Midrange (RG)
#20 Mateusf34: Eldrazi Tron (C)
#21 Fnoop: Infect (UG)
#22 _Batutinha_: Bant Control (WUG)
#23 sgkj0429: Ad Nauseam (WUB)
#24 3HaLeX1: Bogles (WG)
#25 quinniac: Burn (WR)
#26 yamakiller: Gruul Midrange (RG)
#27 Veon1: Dredge (BRG)
#28 dm95: Bant Control (WUG)
#29 swff: Bant Control (WUG)
#30 albert62: Jund Midrange (BRG)
#31 ack_s: Primeval Titan (BG)
#32 FlyersIHC: Infect (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_super_qualifier_2020_04_05 : EventTest
    {
        [Test]
        public void Deck01_MATTOMARINAIO_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",0),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck02_AnneLivleysD3ath_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",1),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck03_Ziojimbo_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",2),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_Roald_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",3),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck05_Diem4x_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",4),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_MdvWin_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",5),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck07_SIN_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",6),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Brener_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",7),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",8),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Alrawn_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",9),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck11_TrollingSaruman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",10),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck12_LiturgijskaKnjiga_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",11),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck13_JV7777_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",12),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Jenara19_Uroza_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",13),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck15_TrueHero_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",14),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_BMJ_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",15),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck17_mansak_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",16),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck18_FatcasterMage_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",17),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck19_LaBiscia_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",18),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",19),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck21_Fnoop_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",20),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",21),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_sgkj0429_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",22),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck24_3HaLeX1_Bogles_WG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",23),
                "PostOuatBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck25_quinniac_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",24),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck26_yamakiller_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",25),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Veon1_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",26),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck28_dm95_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",27),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck29_swff_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",28),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck30_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",29),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck31_acks_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",30),
                "PostOuatBan",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck32_FlyersIHC_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",31),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }


    }
}
