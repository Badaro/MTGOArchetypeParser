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
#01 Eaglov: Amulet Titan (RG)
#02 xfile: Heliod Combo (WG)
#03 Vansguy: UBRG Control (UBRG)
#04 Ivc: Azorius Control (WU)
#05 Poyo_del_Mal: Belcher (URG)
#06 barczek: Oops All Spells (WUBRG)
#07 _Shatun_: Shadow Prowess (BR, Lurrus)
#08 ZYURYO: Devoted (WG, Lurrus)
#09 gyyby297: Oops All Spells (WUBRG)
#10 _Falcon_: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_18 : EventTest
    {
        [Test]
        public void Deck01_Eaglov_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-18",0),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_xfile_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-18",1),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Vansguy_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-18",2),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-18",3),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_PoyodelMal_Belcher_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-18",4),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck06_barczek_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-18",5),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Shatun_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-18",6),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_ZYURYO_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-18",7),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_gyyby297_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-18",8),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Falcon_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-18",9),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
