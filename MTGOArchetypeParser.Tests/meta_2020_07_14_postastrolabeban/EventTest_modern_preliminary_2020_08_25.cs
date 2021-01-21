using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Lavaridge: Reclamation (URG)
#02 SunofNothing: Dimir Shadow (UB)
#03 A22en: Goblins (BRG)
#04 kanister: Bant Control (WUG)
#05 Danker: Azorius Control (WU)
#06 SebastianStueckl: Boros Prowess (WR, Lurrus)
#07 Jack_Kashtan: Ad Nauseam (WUB)
#08 ZYURYO: Gruul Midrange (RG)
#09 Mikhathara1994: Izzet Prowess (UR)
#10 GodOfSlaughter: Green Tron (G)
#11 nykolas0507: Mono Red Prowess (R)
#12 ejcos531: Jund Midrange (BRG)
#13 Maccaciock: Azorius Control (WU)
#14 Shade_Scorpion: Amulet Titan (UG)
#15 Tsubasa_Cat: Burn (WR)
#16 Nekonii: Elves (BG)
#17 BasedCloy: Mill (UB)
#18 Tarrasque1: Elves (BG)
#19 Artem_Kuhtin: Devoted (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_25 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",0),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck02_SunofNothing_DimirShadow_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",1),
                "PostAstrolabeBan",
                ArchetypeColor.UB,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck03_A22en_Goblins_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",2),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck04_kanister_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",3),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Danker_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",4),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_SebastianStueckl_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",5),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_JackKashtan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",6),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck08_ZYURYO_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",7),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Mikhathara1994_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",8),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck10_GodOfSlaughter_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",9),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck11_nykolas0507_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",10),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck12_ejcos531_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",11),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Maccaciock_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",12),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_ShadeScorpion_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",13),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck15_TsubasaCat_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",14),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck16_Nekonii_Elves_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",15),
                "PostAstrolabeBan",
                ArchetypeColor.BG,
                "Elves",
                null,
                null
            );
        }

        [Test]
        public void Deck17_BasedCloy_Mill_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",16),
                "PostAstrolabeBan",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Tarrasque1_Elves_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",17),
                "PostAstrolabeBan",
                ArchetypeColor.BG,
                "Elves",
                null,
                null
            );
        }

        [Test]
        public void Deck19_ArtemKuhtin_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",18),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
