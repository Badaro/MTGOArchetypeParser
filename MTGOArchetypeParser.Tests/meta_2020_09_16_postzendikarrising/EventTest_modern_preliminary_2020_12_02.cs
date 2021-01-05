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
#01 mashmalovsky: Ad Nauseam (WUB)
#02 _Shatun_: Obosh Aggro (R, Obosh)
#03 katuo079595: Shadow Prowess (BR, Lurrus)
#04 Laplasjan: Hammer Time (WG, Lurrus)
#05 medvedev: Obosh Aggro (R, Obosh)
#06 Sommertroll: Bant Spirits (WUG)
#07 unicornparadise: Obosh Aggro (R, Obosh)
#08 Sodeq: Hammer Time (W, Lurrus)
#09 alemilan19: Heliod Combo (WG)
#10 kanister: Obosh Aggro (R, Obosh)
#11 moyashi0904: WURG Control (WURG)
#12 ZYURYO: UBRG Control (UBRG)
#13 Beenew: Obosh Aggro (R, Obosh)
#14 ACG88: KGC Tron (G)
#15 DDMeelow: WURG Control (WURG)
#16 Lord_of_Puntlantis: Izzet Control (UR)
#17 MissTrigger: Heliod Combo (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_02 : EventTest
    {
        [Test]
        public void Deck01_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",0),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Shatun_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",1),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck03_katuo079595_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Laplasjan_HammerTime_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",3),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_medvedev_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",4),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_Sommertroll_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",5),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck07_unicornparadise_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",6),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_Sodeq_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",7),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_alemilan19_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_kanister_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",9),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_moyashi0904_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",10),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ZYURYO_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",11),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Beenew_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",12),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck14_ACG88_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",13),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_DDMeelow_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",14),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_LordofPuntlantis_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",15),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_MissTrigger_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-02",16),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }


    }
}
