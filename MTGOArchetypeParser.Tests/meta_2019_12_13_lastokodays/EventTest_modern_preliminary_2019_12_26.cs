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
#01 Mulldrifter: Eldrazi Tron (C)
#02 McWinSauce: Bant Control (WUG)
#03 Player44: Affinity (C)
#04 Digbirt: Living End (BRG)
#05 Violent_Outburst: Dredge (RG)
#06 Albimtg: Sultai Shadow (UBG)
#07 JustBurn420: Burn (UR)
#08 JPA93: Living End (BRG)
#09 skippy21: Jund Midrange (BRG)
#10 kefka27: Eldrazi Tron (C)
#11 albertoSD: Simic Control (UG)
#12 Volcano666: Sultai Shadow (UBG)
#13 VTCLA: Simic Control (UG)
#14 last7stand: Humans (WUBRG)
#15 JMM: Simic Prowess (UG)
#16 shadow_PT: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_26 : EventTest
    {
        [Test]
        public void Deck01_Mulldrifter_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",0),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",1),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Player44_Affinity_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",2),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Affinity),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Digbirt_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",3),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ViolentOutburst_Dredge_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",4),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Albimtg_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",5),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_JustBurn420_Burn_UR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",6),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck08_JPA93_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",7),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck09_skippy21_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",8),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_kefka27_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",9),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_albertoSD_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",10),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Volcano666_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",11),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck13_VTCLA_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",12),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_last7stand_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",13),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck15_JMM_SimicProwess_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",14),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck16_shadowPT_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",15),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
