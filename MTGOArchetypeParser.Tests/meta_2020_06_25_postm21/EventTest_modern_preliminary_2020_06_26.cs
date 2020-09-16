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
#01 MindOfAKid: Burn (WR, Lurrus)
#02 Trisky: GruulMidrange (RG)
#03 staples87: ETron (C)
#04 Misplacedginger: BantControl (WUG)
#05 samslam: Burn (WR)
#06 yamakiller: Neobrand (UG)
#07 qbturtle15: GruulMidrange (RG, Obosh)
#08 no_lyfe: MonoRedProwess (R)
#09 tyty123: GruulMidrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_06_26 : EventTest
    {
        [Test]
        public void Deck01_MindOfAKid_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",0),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Trisky_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",1),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_staples87_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",2),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",3),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_samslam_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",4),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck06_yamakiller_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",5),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck07_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",6),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_nolyfe_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",7),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_tyty123_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",8),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
