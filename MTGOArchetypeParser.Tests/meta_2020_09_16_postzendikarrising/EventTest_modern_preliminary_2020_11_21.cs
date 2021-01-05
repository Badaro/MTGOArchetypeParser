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
#01 Gung: UBRG Control (UBRG)
#02 mashmalovsky: Ad Nauseam (WUB)
#03 Tiemuuu: Izzet Control (UR)
#04 gyyby297: Izzet Restore Balance (UR)
#05 VitBuk: Izzet Prowess (UR)
#06 UmekawaneikU: Shadow Prowess (BRG, Lurrus)
#07 Lavaridge: Dimir Control (UB)
#08 medvedev: KGC Tron (G)
#09 xfile: Heliod Combo (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_21 : EventTest
    {
        [Test]
        public void Deck01_Gung_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-21",0),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-21",1),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-21",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_gyyby297_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-21",3),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck05_VitBuk_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-21",4),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_UmekawaneikU_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-21",5),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Lavaridge_DimirControl_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-21",6),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_medvedev_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-21",7),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck09_xfile_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-21",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }


    }
}
