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
#01 toondoslav: Dredge (BRG)
#02 Gerschi: Mardu Prowess (WBR, Lurrus)
#03 liuyuchen: Jund Midrange (BRG)
#04 Thrall90: Rakdos Prowess (BR, Lurrus)
#05 Beenew: Green Tron (G)
#06 McWinSauce: Bant Control (WUG)
#07 kaikalbuquerque: Gruul Midrange (RG)
#08 Lukas261997: Amulet Titan (UG)
#09 1yo2yo: Bant Control (WUG)
#10 paucr5: Bant Control (WUG)
#11 ht991122: Reclamation (URG)
#12 FriskiFraska: Golgari Midrange (BG)
#13 chengyiw: Rakdos Prowess (BR, Lurrus)
#14 larkblue: Izzet Prowess (UR)
#15 Nekonii: Elves (BG)
#16 Tw33Ty: Bogles (WG, Lurrus)
#17 PRGJJAR: Dredge (BRG)
#18 Yanti: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_01 : EventTest
    {
        [Test]
        public void Deck01_toondoslav_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",0),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Gerschi_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",1),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_liuyuchen_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",2),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Thrall90_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",3),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Beenew_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",4),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck06_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",5),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_kaikalbuquerque_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",6),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Lukas261997_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",7),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck09_1yo2yo_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",8),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_paucr5_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",9),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_ht991122_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",10),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck12_FriskiFraska_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",11),
                "PostAstrolabeBan",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_chengyiw_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",12),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_larkblue_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",13),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck15_Nekonii_Elves_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",14),
                "PostAstrolabeBan",
                ArchetypeColor.BG,
                "Elves",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Tw33Ty_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",15),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",16),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Yanti_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",17),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }


    }
}
