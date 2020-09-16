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
#01 JacobofAmber: EnduringIdeal (W)
#02 PvtEnormous: BantControl (WUG)
#03 fistfullofmetal: GruulMidrange (RG)
#04 Ravul: KGCTron (G)
#05 andycsoto: ETron (C)
#06 qbturtle15: GruulMidrange (RG)
#07 ilsecco14: SultaiControl (UBG)
#08 JONABSF: MonoRedProwess (R)
#09 Chumba0202: IzzetProwess (UR)
#10 SebastianStueckl: GruulMidrange (RG)
#11 GombleWhop: MonoRedProwess (R, Obosh)
#12 yamakiller: MonoRedProwess (R, Obosh)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_11 : EventTest
    {
        [Test]
        public void Deck01_JacobofAmber_EnduringIdeal_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",0),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck02_PvtEnormous_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_fistfullofmetal_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",2),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Ravul_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",3),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck05_andycsoto_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",4),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",5),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_ilsecco14_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",6),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_JONABSF_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",7),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Chumba0202_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",9),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_GombleWhop_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",10),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck12_yamakiller_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",11),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }


    }
}