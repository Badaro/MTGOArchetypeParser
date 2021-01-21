using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Lukas261997: Grixis Shadow (UBR)
#02 Rhianne: Dredge (BRG)
#03 Thrall90: Jund Midrange (BRG)
#04 _Ingles_: Ad Nauseam (WUB)
#05 killersuv: Temur Control (URG)
#06 fatkiddestroyers: Bant Midrange (WUG)
#07 stonepeanut: Green Tron (G)
#08 Kazuga: Obosh Aggro (R, Obosh)
#09 122pablo: Ascendancy Combo (WURG, Jegantha)
#10 Usama96: Jund Midrange (BRG)
#11 gove1931: Bant Control (WUG)
#12 Zar0s: Humans (WUBRG)
#13 hcook725: Mardu Shadow (WBR)
#14 RicardoMSLan: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_15 : EventTest
    {
        [Test]
        public void Deck01_Lukas261997_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",0),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Rhianne_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",1),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",2),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Ingles_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",3),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck05_killersuv_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",4),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_fatkiddestroyers_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",5),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_stonepeanut_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",6),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck08_Kazuga_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",7),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck09_122pablo_AscendancyCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",8),
                "PostAstrolabeBan",
                ArchetypeColor.WURG,
                "AscendancyCombo",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck10_Usama96_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",9),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_gove1931_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",10),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Zar0s_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",11),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck13_hcook725_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",12),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck14_RicardoMSLan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-15",13),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }


    }
}
