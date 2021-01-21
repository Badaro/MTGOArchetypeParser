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
#01 McWinSauce: Bant Control (WUG)
#02 bolov0: Humans (WUBRG)
#03 KOVU211: Thopter Urza (UBR)
#04 Do0mSwitch: Bant Control (WUG)
#05 stayrospet: Bant Control (WUG)
#06 SakeIzumo: Mono Red Prowess (R)
#07 didoguidotti1: UBRG Shadow (UBRG)
#08 Ivan_Catanduva_Br: Gruul Midrange (RG)
#09 Veveil: Temur Control (URG)
#10 AndyAWKWARD: WURG Control (WURG)
#11 al8ert.dk: Jund Midrange (BRG)
#12 Tw33Ty: Primeval Titan (BG)
#13 yamakiller: Eldrazi Tron (G)
#14 TSPJendrek: Bant Control (WUG)
#15 Lucabireskusku: Thopter Urza (UB)
#16 Mercenario: Dredge (UBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_premier_2020_03_09 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_bolov0_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck03_KOVU211_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck04_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_stayrospet_BantControl_WUG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_SakeIzumo_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck07_didoguidotti1_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck08_IvanCatanduvaBr_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Veveil_TemurControl_URG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_AndyAWKWARD_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_al8ertdk_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Tw33Ty_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck13_yamakiller_EldraziTron_G()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck14_TSPJendrek_BantControl_WUG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Lucabireskusku_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck16_Mercenario_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-premier-2020-03-09",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }


    }
}
