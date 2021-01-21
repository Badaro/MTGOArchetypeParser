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
#01 PRGJJAR: Dredge (BRG)
#02 FrancusAurelius: Gruul Midrange (RG)
#03 MrPolite: Amulet Titan (UG)
#04 GGoggles: Eldrazi Tron (G)
#05 Xwhale: Primeval Titan (WG)
#06 Accelerator_GTR: Jund Midrange (BRG)
#07 sandydogmtg: Burn (R)
#08 AvocadoToast: Primeval Titan (WG)
#09 Tyerube1618: Gifts Storm (UR)
#10 Piglet: WURG Control (WURG)
#11 quinniac: Grixis Shadow (UBR)
#12 markdm: Thopter Urza (UBR)
#13 _goblinlackey: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_11_0 : EventTest
    {
        [Test]
        public void Deck01_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck02_FrancusAurelius_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_MrPolite_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_GGoggles_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck05_Xwhale_PrimevalTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.WG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck06_AcceleratorGTR_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck08_AvocadoToast_PrimevalTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.WG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Tyerube1618_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Piglet_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_quinniac_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck12_markdm_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck13_goblinlackey_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11-0",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }


    }
}
