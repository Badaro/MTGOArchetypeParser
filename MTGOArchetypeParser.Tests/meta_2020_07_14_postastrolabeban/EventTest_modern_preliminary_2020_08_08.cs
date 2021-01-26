using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 kanister: Reclamation (URG)
#02 updraftelemental: Sultai Shadow (UBG)
#03 Gigglesworth: Bant Midrange (WUG)
#04 VampireGodric: Infect (UG)
#05 ImAFireHydrant: Ad Nauseam (WUB)
#06 DreamsOfAshiok: Eldrazi Tron (C)
#07 AlabasterWolfie: Goblins (BR)
#08 ScreenwriterNY: Azorius Taxes (WU)
#09 BERNASTORRES: Izzet Prowess (UR)
#10 Moniz0801: Amulet Titan (WG)
#11 ZYX_Jerry: Ad Nauseam (WUB)
#12 komattaman: Gruul Midrange (RG)
#13 Snusnumrick: Eldrazi Tron (C)
#14 bobthedog: White Devotion (W)
#15 buddha715: Ad Nauseam (WUB)
#16 aManatease: Eldrazi Tron (C)
#17 IntegralHDK: Goblins (BRG)
#18 Delthar: Infect (BG)
#19 SebastianStueckl: Simic Control (UG)
#20 Lord_of_Puntlantis: Electro Balance (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_08 : EventTest
    {
        [Test]
        public void Deck01_kanister_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",0),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck02_updraftelemental_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",1),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Gigglesworth_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",2),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_VampireGodric_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",3),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck05_ImAFireHydrant_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",4),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck06_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",5),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_AlabasterWolfie_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",6),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck08_ScreenwriterNY_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",7),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck09_BERNASTORRES_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",8),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck10_Moniz0801_AmuletTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",9),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck11_ZYXJerry_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",10),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck12_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",11),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Snusnumrick_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",12),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck14_bobthedog_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",13),
                "PostAstrolabeBan",
                ArchetypeColor.W,
                "WhiteDevotion",
                null,
                null
            );
        }

        [Test]
        public void Deck15_buddha715_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",14),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck16_aManatease_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",15),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck17_IntegralHDK_Goblins_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",16),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Delthar_Infect_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",17),
                "PostAstrolabeBan",
                ArchetypeColor.BG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck19_SebastianStueckl_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",18),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck20_LordofPuntlantis_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",19),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }


    }
}
