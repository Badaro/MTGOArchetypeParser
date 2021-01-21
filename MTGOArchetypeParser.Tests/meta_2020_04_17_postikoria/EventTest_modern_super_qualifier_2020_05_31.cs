using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 patheus_84: Ad Nauseam (WUB)
#02 Ryan100495: Dredge (BRG)
#03 kthanakit26: Rakdos Prowess (BR, Lurrus)
#04 Toastxp: Jund Shadow (BRG, Lurrus)
#05 MATTHEWFOULKES: Jund Prowess (BRG, Lurrus)
#06 quinniac: Gruul Midrange (RG, Obosh)
#07 DarkKeeper: Ad Nauseam (WUB)
#08 AstralPlane: Boros Prowess (WR, Lurrus)
#09 mikeleee: Humans (WUBRG)
#10 Ouranos139: Amulet Titan (UG)
#11 milikin: Gruul Midrange (RG, Obosh)
#12 jled: Jund Shadow (BRG, Lurrus)
#13 eminemberry: Burn (WR, Lurrus)
#14 Dafne17: Gruul Midrange (RG, Obosh)
#15 _LSN_: Burn (WR, Lurrus)
#16 Cherryxman: Scapeshift (WUBRG, Yorion)
#17 Wtnof: Gruul Midrange (RG, Obosh)
#18 Papelucho10: Infect (UG)
#19 Lcario: Eldrazi Tron (C)
#20 MadMaxErnst: Rakdos Prowess (BR, Lurrus)
#21 ArchaeusDota: Green Tron (G, Jegantha)
#22 Wolfie98: Niv To Light (WUBRG, Yorion)
#23 GiestOfIWin: Scapeshift (WURG, Yorion)
#24 B1gDan: Jund Shadow (BRG, Lurrus)
#25 PRGJJAR: Dredge (BRG)
#26 idutra: Gruul Midrange (RG, Obosh)
#27 kaikalbuquerque: Bogles (WUG, Lurrus)
#28 selbstdenker: Scapeshift (WUBRG, Yorion)
#29 Bullwinkkle6705: Scapeshift (URG, Yorion)
#30 bozo2112: Bogles (WG, Lurrus)
#31 Navas: Azorius Control (WU, Kaheera)
#32 yuurari_yuko: Bogles (WUG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_super_qualifier_2020_05_31 : EventTest
    {
        [Test]
        public void Deck01_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",0),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",1),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck03_kthanakit26_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",2),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Toastxp_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",3),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_MATTHEWFOULKES_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",4),
                "PostIkoria",
                ArchetypeColor.BRG,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_quinniac_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",5),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_DarkKeeper_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",6),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck08_AstralPlane_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",7),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_mikeleee_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",8),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",9),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck11_milikin_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",10),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck12_jled_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",11),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_eminemberry_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",12),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Dafne17_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",13),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck15_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",14),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Cherryxman_Scapeshift_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",15),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck17_Wtnof_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",16),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck18_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",17),
                "PostIkoria",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Lcario_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",18),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck20_MadMaxErnst_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",19),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_ArchaeusDota_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",20),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_Wolfie98_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",21),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_GiestOfIWin_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",22),
                "PostIkoria",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_B1gDan_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",23),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",24),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck26_idutra_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",25),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck27_kaikalbuquerque_Bogles_WUG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",26),
                "PostIkoria",
                ArchetypeColor.WUG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_selbstdenker_Scapeshift_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",27),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_Bullwinkkle6705_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",28),
                "PostIkoria",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck30_bozo2112_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",29),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_Navas_AzoriusControl_WU_Kaheera()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",30),
                "PostIkoria",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck32_yuurariyuko_Bogles_WUG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-31",31),
                "PostIkoria",
                ArchetypeColor.WUG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
