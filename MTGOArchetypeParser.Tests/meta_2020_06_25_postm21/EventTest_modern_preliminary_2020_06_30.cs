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
#01 pbarrrgh: Temur Control (URG)
#02 npercario: Bant Control (WUG)
#03 staples87: Eldrazi Tron (C)
#04 Laplasjan: Devoted (WG, Lurrus)
#05 ecobaronen: Bant Control (WUG)
#06 Larry11: Gruul Midrange (RG)
#07 billsive: Reclamation (UBG)
#08 EdB: Goblins (BR)
#09 Voidpaw: Jund Midrange (BRG)
#10 RicardoMSLan: Eldrazi Tron (C)
#11 Niallghas: Goblins (BR)
#12 Boland: Dredge (BRG)
#13 Haunter_Hunter: Goblins (BR)
#14 mariogomes097: Grixis Shadow (UBR)
#15 FEARnLOATHing: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_06_30 : EventTest
    {
        [Test]
        public void Deck01_pbarrrgh_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",0),
                "PostM21",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_npercario_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",1),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_staples87_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",2),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck04_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",3),
                "PostM21",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_ecobaronen_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",4),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Larry11_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",5),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_billsive_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",6),
                "PostM21",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck08_EdB_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",7),
                "PostM21",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Voidpaw_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",8),
                "PostM21",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_RicardoMSLan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",9),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck11_Niallghas_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",10),
                "PostM21",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Boland_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",11),
                "PostM21",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck13_HaunterHunter_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",12),
                "PostM21",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck14_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",13),
                "PostM21",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck15_FEARnLOATHing_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",14),
                "PostM21",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
