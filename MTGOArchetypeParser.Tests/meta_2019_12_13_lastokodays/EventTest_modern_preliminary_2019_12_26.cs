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
#03 Player44: Affinity (R)
#04 Digbirt: Living End (BRG)
#05 Violent_Outburst: Dredge (BRG)
#06 Albimtg: UBRG Shadow (UBRG)
#07 JustBurn420: Burn (UR)
#08 JPA93: Living End (BRG)
#09 skippy21: Jund Midrange (BRG)
#10 kefka27: Eldrazi Tron (C)
#11 albertoSD: Urza Oko (UG)
#12 Volcano666: UBRG Shadow (UBRG)
#13 VTCLA: Urza Oko (UG)
#14 last7stand: Humans (WUBRG)
#15 JMM: Urza Oko (UBRG)
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
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck02_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",1),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Player44_Affinity_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",2),
                "LastOkoDays",
                ArchetypeColor.R,
                "Affinity",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Digbirt_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",3),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "LivingEnd",
                null,
                null
            );
        }

        [Test]
        public void Deck05_ViolentOutburst_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",4),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Albimtg_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",5),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck07_JustBurn420_Burn_UR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",6),
                "LastOkoDays",
                ArchetypeColor.UR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck08_JPA93_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",7),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "LivingEnd",
                null,
                null
            );
        }

        [Test]
        public void Deck09_skippy21_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",8),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_kefka27_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",9),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck11_albertoSD_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",10),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Volcano666_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",11),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck13_VTCLA_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",12),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck14_last7stand_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",13),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck15_JMM_UrzaOko_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",14),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck16_shadowPT_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-26",15),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
