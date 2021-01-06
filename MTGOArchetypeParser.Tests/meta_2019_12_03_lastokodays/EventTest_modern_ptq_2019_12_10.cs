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
#01 Ouranos139: Amulet Titan (UG)
#02 Sodeq: Dredge (BRG)
#03 Cherryxman: Eldrazi Tron (C)
#04 genkytoro: Jund Midrange (BRG)
#05 IvanPablo: Eldrazi Tron (C)
#06 AbelMolto: Burn (WRG)
#07 JoseCabezas: Eldrazi Tron (C)
#08 Theo_Jung: Eldrazi Tron (C)
#09 mell0n: Bant Control (WUG)
#10 THE_NARD: Mono Red Prowess (R)
#11 Graciasportanto: Thopter Urza (UG)
#12 fried-liver-attack: Crabvine (UBG)
#13 senberg: Bogles (WG)
#14 _Shatun_: Mono Red Prowess (R)
#15 dejoyjoe: Simic Control (UG)
#16 adamwasmo: Amulet Titan (WUG)
#17 sokos13: Infect (UG)
#18 dillyg10: Eldrazi Tron (C)
#19 nbdf: Dredge (BRG)
#20 Tanzo90: Grixis Shadow (UBR)
#21 Folero: Infect (UG)
#22 pepeteam: Thopter Urza (UBG)
#23 coert: Green Tron (G)
#24 szydlovski: Grixis Shadow (UBR)
#25 Chompers203: Mono Red Prowess (R)
#26 3HaLeX1: Eldrazi Tron (C)
#27 nietzreznor: Infect (UG)
#28 MMorrjr12: Burn (WR)
#29 Caveman842: Moon Stompy (R)
#30 frilund: Simic Midrange (UG)
#31 Sideshowsc: WURG Control (WURG)
#32 RancidMind: Dredge (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_03_lastokodays
{
    public class EventTest_modern_ptq_2019_12_10 : EventTest
    {
        [Test]
        public void Deck01_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",0),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",1),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Cherryxman_EldraziTron_C()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",2),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_genkytoro_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",3),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_IvanPablo_EldraziTron_C()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",4),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck06_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",5),
                new LastOkoDays(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_JoseCabezas_EldraziTron_C()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",6),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck08_TheoJung_EldraziTron_C()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",7),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_mell0n_BantControl_WUG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",8),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_THENARD_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",9),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Graciasportanto_ThopterUrza_UG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",10),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck12_friedliverattack_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",11),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck13_senberg_Bogles_WG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",12),
                new LastOkoDays(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",13),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_dejoyjoe_SimicControl_UG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",14),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_adamwasmo_AmuletTitan_WUG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",15),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck17_sokos13_Infect_UG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",16),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck18_dillyg10_EldraziTron_C()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",17),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck19_nbdf_Dredge_BRG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",18),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Tanzo90_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",19),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Folero_Infect_UG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",20),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck22_pepeteam_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",21),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck23_coert_GreenTron_G()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",22),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck24_szydlovski_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",23),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Chompers203_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",24),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_3HaLeX1_EldraziTron_C()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",25),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck27_nietzreznor_Infect_UG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",26),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck28_MMorrjr12_Burn_WR()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",27),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Caveman842_MoonStompy_R()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",28),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(MoonStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck30_frilund_SimicMidrange_UG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",29),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Sideshowsc_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",30),
                new LastOkoDays(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_RancidMind_Dredge_BRG()
        {
            Test(
                GetDeck("modern-ptq-2019-12-10",31),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }


    }
}
