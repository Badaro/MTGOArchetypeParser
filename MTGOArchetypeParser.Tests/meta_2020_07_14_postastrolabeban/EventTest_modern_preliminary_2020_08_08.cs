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
#01 kanister: Temur Control (URG)
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
        public void Deck01_kanister_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",0),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_updraftelemental_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Gigglesworth_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_VampireGodric_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ImAFireHydrant_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck06_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",5),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_AlabasterWolfie_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ScreenwriterNY_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck09_BERNASTORRES_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Moniz0801_AmuletTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck11_ZYXJerry_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck12_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",11),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Snusnumrick_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",12),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_bobthedog_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",13),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck15_buddha715_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck16_aManatease_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",15),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck17_IntegralHDK_Goblins_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Delthar_Infect_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck19_SebastianStueckl_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_LordofPuntlantis_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",19),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }


    }
}
