using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 JacobofAmber: Enduring Ideal (W)
#02 PvtEnormous: Bant Control (WUG)
#03 fistfullofmetal: Gruul Midrange (RG)
#04 Ravul: Green Tron (G)
#05 andycsoto: Eldrazi Tron (C)
#06 qbturtle15: Gruul Midrange (RG)
#07 ilsecco14: Sultai Control (UBG)
#08 JONABSF: Mono Red Prowess (R)
#09 Chumba0202: Izzet Prowess (UR)
#10 SebastianStueckl: Gruul Midrange (RG)
#11 GombleWhop: Obosh Aggro (R, Obosh)
#12 yamakiller: Obosh Aggro (R, Obosh)
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
                "PostAstrolabeBan",
                ArchetypeColor.W,
                "EnduringIdeal",
                null,
                null
            );
        }

        [Test]
        public void Deck02_PvtEnormous_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",1),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_fistfullofmetal_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",2),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Ravul_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",3),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck05_andycsoto_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",4),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",5),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_ilsecco14_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",6),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_JONABSF_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",7),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_Chumba0202_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",8),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck10_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",9),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_GombleWhop_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",10),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck12_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-11",11),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }


    }
}
