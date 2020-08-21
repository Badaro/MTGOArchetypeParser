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
#01 kanister: TemurReclamation (URG)
#02 updraftelemental: TraverseShadow (UBG)
#03 Gigglesworth: BantMidrange (WUG)
#04 VampireGodric: Infect (UG)
#05 ImAFireHydrant: AdNauseam (WUB)
#06 DreamsOfAshiok: ETron (C)
#07 AlabasterWolfie: SnoopGoblins (BR)
#08 ScreenwriterNY: DeathAndTaxes (WU)
#09 BERNASTORRES: IzzetProwess (UR)
#10 Moniz0801: AmuletTitan (WURG)
#11 ZYX_Jerry: AdNauseam (WUB)
#12 komattaman: Ponza (RG)
#13 Snusnumrick: ETron (C)
#14 bobthedog: WhiteDevotion (W)
#15 buddha715: AdNauseam (WUB)
#16 aManatease: ETron (C)
#17 IntegralHDK: SnoopGoblins (BRG)
#18 Delthar: Infect (BG)
#19 SebastianStueckl: SnowControl (UG)
#20 Lord_of_Puntlantis: IzzetRestoreBalance (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_08 : EventTest
    {
        [Test]
        public void Deck01_kanister_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",0),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck02_updraftelemental_DeathsShadow_TraverseShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
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
                typeof(BantMidrange),
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
        public void Deck06_DreamsOfAshiok_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",5),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck07_AlabasterWolfie_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck08_ScreenwriterNY_DeathAndTaxes_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck09_BERNASTORRES_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck10_Moniz0801_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
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
        public void Deck12_komattaman_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",11),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Snusnumrick_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",12),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
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
        public void Deck16_aManatease_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",15),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_IntegralHDK_Goblins_SnoopGoblins_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                typeof(SnoopGoblins),
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
        public void Deck19_SebastianStueckl_SnowControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_LordofPuntlantis_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-08",19),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }


    }
}
