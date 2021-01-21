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
#01 komattaman: Gruul Midrange (RG)
#02 Simarisu: Izzet Prowess (UR)
#03 BERNASTORRES: Bogles (WG, Lurrus)
#04 ImmanuelKantrolGod: Bant Control (WUG)
#05 Somefellow: Amulet Titan (URG)
#06 Nickburch13: Mardu Prowess (WBR, Lurrus)
#07 fling5133: Reclamation (UBG)
#08 JustBurn420: Slivers (WUBRG)
#09 lSoLlAKirA: Bant Control (WUG)
#10 Rinko: Enduring Ideal (W)
#11 MissTrigger: Merfolk (WU, Lurrus)
#12 Hyeri0418: Golgari Midrange (BG)
#13 TheBlazingKFC_mtg: Neobrand (UG)
#14 katuo079595: Reclaimer Titan (WG)
#15 Lillia: Amulet Titan (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_02 : EventTest
    {
        [Test]
        public void Deck01_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",0),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Simarisu_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",1),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck03_BERNASTORRES_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",2),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",3),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Somefellow_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",4),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_Nickburch13_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",5),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_fling5133_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",6),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck08_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",7),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck09_lSoLlAKirA_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",8),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Rinko_EnduringIdeal_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",9),
                "PostAstrolabeBan",
                ArchetypeColor.W,
                "EnduringIdeal",
                null,
                null
            );
        }

        [Test]
        public void Deck11_MissTrigger_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",10),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "Merfolk",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Hyeri0418_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",11),
                "PostAstrolabeBan",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_TheBlazingKFCmtg_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",12),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck14_katuo079595_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",13),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck15_Lillia_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",14),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }


    }
}
