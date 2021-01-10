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
#01 ChezChelios: Green Tron (G)
#02 Matti: Dredge (BRG)
#03 pepeisra: Jund Midrange (BRG)
#04 otakkun: Green Tron (G)
#05 ScreenwriterNY: Bushwhacker Zoo (WRG)
#06 _Batutinha_: Bant Control (WUG)
#07 ForThoseWhoHaveHeart: Amulet Titan (URG)
#08 Misplacedginger: Bant Control (WUG)
#09 pmc22337: Bogles (WG)
#10 UmekawaneikU: Uroza (URG)
#11 nuikt: Grinding Breach (WUR)
#12 TennTyou: Niv To Light (WUBRG)
#13 Piglet: Bant Control (WUG)
#14 farbeyond37: Green Tron (G)
#15 RiverOfIce: Bant Blink (WUG)
#16 Playmobil: Uroza (URG)
#17 fradelrock: Eldrazi Tron (C)
#18 hikid: Amulet Titan (UG)
#19 ArchaeusDota: Eldrazi Tron (C)
#20 Cherryxman: Eldrazi Tron (C)
#21 straca3: Jund Midrange (BRG)
#22 jessy_samek: Uroza (URG)
#23 StormlightReaper: Uroza (URG)
#24 BSK_hercules: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_20 : EventTest
    {
        [Test]
        public void Deck01_ChezChelios_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",0),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck02_Matti_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",1),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_pepeisra_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",2),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",3),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck05_ScreenwriterNY_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",4),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",5),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_ForThoseWhoHaveHeart_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",6),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",7),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_pmc22337_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",8),
                new PostOuatBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck10_UmekawaneikU_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",9),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck11_nuikt_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",10),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck12_TennTyou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",11),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Piglet_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",12),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_farbeyond37_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",13),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck15_RiverOfIce_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",14),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Playmobil_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",15),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck17_fradelrock_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",16),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_hikid_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",17),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck19_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",18),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck20_Cherryxman_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",19),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck21_straca3_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",20),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_jessysamek_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",21),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck23_StormlightReaper_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",22),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck24_BSKhercules_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-20",23),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }


    }
}
