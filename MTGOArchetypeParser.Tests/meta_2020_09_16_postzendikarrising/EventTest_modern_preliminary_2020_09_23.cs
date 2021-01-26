using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 ZYURYO: WURG Control (WURG)
#02 Rinko: Enduring Ideal (WR)
#03 kanister: Shadow Prowess (BR, Lurrus)
#04 Kurusu: Kiki Chord (WRG, Yorion)
#05 Bohnz: Gruul Midrange (RG)
#06 Humpaa: Shadow Prowess (BR, Lurrus)
#07 ImmanuelKantrolGod: Jeskai Control (WUR)
#08 spellvine: Izzet Prowess (UR)
#09 HouseOfManaMTG: Amulet Titan (G)
#10 tagosaku: Burn (WR)
#11 coert: Heliod Combo (WG)
#12 medvedev: Selesnya Taxes (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_09_23 : EventTest
    {
        [Test]
        public void Deck01_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",0),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",1),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "EnduringIdeal",
                null,
                null
            );
        }

        [Test]
        public void Deck03_kanister_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",2),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",3),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "KikiChord",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_Bohnz_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",4),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Humpaa_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",5),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_ImmanuelKantrolGod_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",6),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_spellvine_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",7),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_HouseOfManaMTG_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",8),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck10_tagosaku_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",9),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck11_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",10),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck12_medvedev_SelesnyaTaxes_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",11),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Taxes",
                null,
                null
            );
        }


    }
}
