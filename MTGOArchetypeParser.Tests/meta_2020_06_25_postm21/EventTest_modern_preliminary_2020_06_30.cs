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
#03 staples87: E Tron (C)
#04 Laplasjan: Devoted (WG, Lurrus)
#05 ecobaronen: Bant Control (WUG)
#06 Larry11: Gruul Midrange (RG)
#07 billsive: Sultai Control (UBG)
#08 EdB: Snoop Goblins (BR)
#09 Voidpaw: Jund Midrange (BRG)
#10 RicardoMSLan: E Tron (C)
#11 Niallghas: Snoop Goblins (BR)
#12 Boland: Dredge (BRG)
#13 Haunter_Hunter: Snoop Goblins (BR)
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
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_npercario_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",1),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_staples87_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",2),
                new PostM21(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",3),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_ecobaronen_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",4),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Larry11_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",5),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_billsive_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",6),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_EdB_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",7),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Voidpaw_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",8),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_RicardoMSLan_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",9),
                new PostM21(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_Niallghas_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",10),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Boland_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",11),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck13_HaunterHunter_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",12),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck14_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",13),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_FEARnLOATHing_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-30",14),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
