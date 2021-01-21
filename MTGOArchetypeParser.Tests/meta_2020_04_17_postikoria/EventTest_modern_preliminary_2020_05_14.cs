using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 twinlesstwin: Scapeshift (URG, Yorion)
#02 BERNASTORRES: Hardened Scales (BG, Lurrus)
#03 A22en: Bant Control (WUG, Yorion)
#04 in5ano: Scapeshift (URG, Yorion)
#05 Toastxp: Mardu Prowess (WBR, Lurrus)
#06 ReturnToDust: Boros Prowess (WR, Lurrus)
#07 Ouranos139: Amulet Titan (UG)
#08 AlabasterWolfie: Saheeli Combo (WURG, Yorion)
#09 qbturtle15: Jund Midrange (BRG, Lurrus)
#10 Bishark: Merfolk (WU, Lurrus)
#11 AvocadoToast: Jund Midrange (BRG, Lurrus)
#12 pizzaslinger: Gruul Midrange (RG, Obosh)
#13 LLegend: Electro Balance (URG)
#14 kefka27: Eldrazi Tron (C)
#15 KeeperX: Zirda Combo (WRG, Zirda)
#16 MLupa: Bant Control (WUG, Yorion)
#17 HarlanMTG: Azorius Control (WU, Kaheera)
#18 patrick50: Reclamation (UBG)
#19 pmc22337: Reclamation (UBG)
#20 yamakiller: Boros Prowess (WR, Lurrus)
#21 K-sol: Humans (WUBRG, Jegantha)
#22 bgv1989: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_14 : EventTest
    {
        [Test]
        public void Deck01_twinlesstwin_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",0),
                "PostIkoria",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_BERNASTORRES_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",1),
                "PostIkoria",
                ArchetypeColor.BG,
                "HardenedScales",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_A22en_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",2),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",3),
                "PostIkoria",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_Toastxp_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",4),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_ReturnToDust_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",5),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",6),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_AlabasterWolfie_SaheeliCombo_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",7),
                "PostIkoria",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_qbturtle15_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",8),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Bishark_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",9),
                "PostIkoria",
                ArchetypeColor.WU,
                "Merfolk",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_AvocadoToast_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",10),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_pizzaslinger_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",11),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck13_LLegend_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",12),
                "PostIkoria",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck14_kefka27_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",13),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck15_KeeperX_ZirdaCombo_WRG_Zirda()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",14),
                "PostIkoria",
                ArchetypeColor.WRG,
                "ZirdaCombo",
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck16_MLupa_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",15),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck17_HarlanMTG_AzoriusControl_WU_Kaheera()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",16),
                "PostIkoria",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck18_patrick50_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",17),
                "PostIkoria",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck19_pmc22337_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",18),
                "PostIkoria",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck20_yamakiller_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",19),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Ksol_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",20),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_bgv1989_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",21),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }


    }
}
