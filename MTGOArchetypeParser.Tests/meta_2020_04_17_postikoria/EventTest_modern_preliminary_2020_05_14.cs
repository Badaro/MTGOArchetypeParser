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
#13 LLegend: Electro Balance (UR)
#14 kefka27: Eldrazi Tron (C)
#15 KeeperX: Naya Midrange (WRG, Zirda)
#16 MLupa: Bant Control (WUG, Yorion)
#17 HarlanMTG: Azorius Control (WU, Kaheera)
#18 patrick50: Sultai Control (UBG)
#19 pmc22337: Sultai Control (UBG)
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
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_BERNASTORRES_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",1),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_A22en_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",2),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",3),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_Toastxp_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",4),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_ReturnToDust_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",6),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_AlabasterWolfie_SaheeliCombo_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",7),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_qbturtle15_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",8),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Bishark_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",9),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_AvocadoToast_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",10),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_pizzaslinger_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",11),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck13_LLegend_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",12),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck14_kefka27_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",13),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_KeeperX_NayaMidrange_WRG_Zirda()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",14),
                new PostIkoria(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck16_MLupa_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",15),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck17_HarlanMTG_AzoriusControl_WU_Kaheera()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",16),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck18_patrick50_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",17),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_pmc22337_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",18),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_yamakiller_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",19),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Ksol_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",20),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_bgv1989_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-14",21),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }


    }
}
