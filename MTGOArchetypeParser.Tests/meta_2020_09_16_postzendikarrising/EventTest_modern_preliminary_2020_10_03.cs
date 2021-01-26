using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 ilsecco14: Shadow Prowess (BR, Lurrus)
#02 Redgy: Jeskai Control (WUR)
#03 Erik157751: Shadow Prowess (BR, Lurrus)
#04 _Falcon_: Izzet Prowess (UR)
#05 AlexanderRosdahl: Sultai Control (UBG)
#06 Sodeq: Ad Nauseam (WUB)
#07 Tyerube1618: Gifts Storm (URG)
#08 timewalkinonsunshine: Taking Turns (URG)
#09 ZYURYO: WURG Control (WURG)
#10 audio336: Shadow Prowess (BR, Lurrus)
#11 Sanchez5272: Humans (WUBRG)
#12 MissTrigger: Humans (WUBRG)
#13 kiko: Mono White Taxes (W)
#14 NosonosaN: WURG Control (WURG)
#15 CavalloGoloso: Izzet Control (UR)
#16 Gerschi: Oops All Spells (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_03 : EventTest
    {
        [Test]
        public void Deck01_ilsecco14_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",0),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Redgy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",1),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Erik157751_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",2),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Falcon_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",3),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck05_AlexanderRosdahl_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",4),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",5),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Tyerube1618_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",6),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck08_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",7),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "TakingTurns",
                null,
                null
            );
        }

        [Test]
        public void Deck09_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_audio336_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",9),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Sanchez5272_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",10),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck12_MissTrigger_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",11),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck13_kiko_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",12),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck14_NosonosaN_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",13),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_CavalloGoloso_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",14),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Gerschi_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-03",15),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }


    }
}
