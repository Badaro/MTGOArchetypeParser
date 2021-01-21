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
#01 Violent_Outburst: Polymorph (RG)
#02 _INF_: Gifts Storm (UR)
#03 Gerschi: WURG Control (WURG)
#04 UmekawaneikU: Shadow Prowess (BRG, Lurrus)
#05 Eaglov: Amulet Titan (UG)
#06 Lukas261997: Amulet Titan (RG)
#07 ZYURYO: WURG Control (WURG)
#08 Matteso: Gifts Storm (UR)
#09 MaxCapone: Oops All Spells (WUBRG)
#10 GrandDrou: Shadow Prowess (WBR, Lurrus)
#11 SoulStrong: Reclaimer Titan (WRG)
#12 JustBurn420: Burn (RG)
#13 BSK_hercules: Sultai Control (UBG)
#14 MadMaxErnst: Jund Shadow (BRG, Lurrus)
#15 _Shatun_: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_14 : EventTest
    {
        [Test]
        public void Deck01_ViolentOutburst_Polymorph_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",0),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "Polymorph",
                null,
                null
            );
        }

        [Test]
        public void Deck02_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",1),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Gerschi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_UmekawaneikU_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",3),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Eaglov_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",4),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_Lukas261997_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",5),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck07_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Matteso_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",7),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck09_MaxCapone_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",8),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck10_GrandDrou_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",9),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_SoulStrong_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",10),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck12_JustBurn420_Burn_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",11),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck13_BSKhercules_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",12),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_MadMaxErnst_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",13),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-14",14),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
