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
#01 MATTOMARINAIO: Burn (WR)
#02 AnneLivleysD3ath: Amulet Titan (G)
#03 Ziojimbo: Amulet Titan (G)
#04 Roald: Green Tron (G)
#05 Diem4x: Bant Control (WUG)
#06 MdvWin: Burn (WR)
#07 SIN: Uroza (UG)
#08 Brener: Jund Midrange (BRG)
#09 signblindman: Gruul Midrange (RG)
#10 Alrawn: Green Tron (G)
#11 TrollingSaruman: Gruul Midrange (RG)
#12 LiturgijskaKnjiga: Infect (UG)
#13 JV_7777: Dredge (BRG)
#14 Jenara19: Bant Control (WUG)
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
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck02_AnneLivleysD3ath_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",1),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck03_Ziojimbo_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",2),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_Roald_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",3),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck05_Diem4x_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",4),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_MdvWin_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",5),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_SIN_Uroza_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",6),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Brener_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",7),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",8),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Alrawn_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",9),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck11_TrollingSaruman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",10),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_LiturgijskaKnjiga_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",11),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck13_JV7777_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",12),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Jenara19_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",13),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_TrueHero_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",14),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_BMJ_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",15),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_mansak_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",16),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_FatcasterMage_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",17),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck19_LaBiscia_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",18),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",19),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck21_Fnoop_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",20),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",21),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_sgkj0429_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",22),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck24_3HaLeX1_Bogles_WG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",23),
                new PostOuatBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck25_quinniac_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",24),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck26_yamakiller_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",25),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Veon1_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",26),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck28_dm95_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",27),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_swff_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",28),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",29),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_acks_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",30),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck32_FlyersIHC_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-05",31),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }


    }
}
