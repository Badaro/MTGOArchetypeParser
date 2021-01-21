using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 PietroSas: Devoted (WG, Lurrus)
#02 SunofNothing: Uroza (URG, Yorion)
#03 Searzist: Boros Prowess (WR, Lurrus)
#04 AvocadoToast: Jund Midrange (BRG, Lurrus)
#05 quinniac: Devoted (WG, Lurrus)
#06 ManavonRX: Amulet Titan (UG)
#07 Capitano_CL: Neobrand (UG)
#08 Finalnub: Neobrand (UBG)
#09 AlfredoTorres: Hardened Scales (WG, Lurrus)
#10 TerminalJustice: Humans (WUBRG)
#11 McWinSauce: WURG Control (WURG, Yorion)
#12 Papelucho10: Infect (UG)
#13 triosk: Uroza (URG, Yorion)
#14 in5ano: Uroza (URG, Yorion)
#15 karatedom: Gruul Midrange (RG, Obosh)
#16 grinderA: Gruul Midrange (RG, Obosh)
#17 Store_Shop5: Mono Red Prowess (R)
#18 SourceOdin: Uroza (URG, Yorion)
#19 Icteridae: Devoted (WUG)
#20 DayAtTheShrine: Infect (UG)
#21 MdvWin: Boros Prowess (WR, Lurrus)
#22 AbelMolto: Burn (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_04_30 : EventTest
    {
        [Test]
        public void Deck01_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",0),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_SunofNothing_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",1),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_Searzist_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",2),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_AvocadoToast_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",3),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_quinniac_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",4),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_ManavonRX_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",5),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck07_CapitanoCL_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",6),
                "PostIkoria",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Finalnub_Neobrand_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",7),
                "PostIkoria",
                ArchetypeColor.UBG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck09_AlfredoTorres_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",8),
                "PostIkoria",
                ArchetypeColor.WG,
                "HardenedScales",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_TerminalJustice_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",9),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck11_McWinSauce_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",10),
                "PostIkoria",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",11),
                "PostIkoria",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck13_triosk_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",12),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck14_in5ano_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",13),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_karatedom_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",14),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck16_grinderA_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",15),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck17_StoreShop5_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",16),
                "PostIkoria",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck18_SourceOdin_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",17),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",18),
                "PostIkoria",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck20_DayAtTheShrine_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",19),
                "PostIkoria",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck21_MdvWin_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",20),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-30",21),
                "PostIkoria",
                ArchetypeColor.WRG,
                "RedAggro",
                "Burn",
                null
            );
        }


    }
}
