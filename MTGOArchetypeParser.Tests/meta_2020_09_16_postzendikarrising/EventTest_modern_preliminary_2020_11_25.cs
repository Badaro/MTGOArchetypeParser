using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Mikhathara1994: Grixis Shadow (UBR)
#02 MiguelCaster: Boros Taxes (WR, Yorion)
#03 Phill_Hellmuth: Oops All Spells (WUBRG)
#04 xfile: Azorius Taxes (WU, Yorion)
#05 Violent_Outburst: Scapeshift (UBRG)
#06 Artem_Kuhtin: Azorius Taxes (WU, Yorion)
#07 mmapson125: Heliod Combo (WG)
#08 fwdr3: Shadow Prowess (BR, Lurrus)
#09 albert62: WURG Control (WURG)
#10 Damgar: Green Tron (G)
#11 toondoslav: Dredge (BRG)
#12 musasabi: Shadow Prowess (BR, Lurrus)
#13 Loco78: Jund Midrange (BRG)
#14 Ekeross: Shadow Prowess (BR, Lurrus)
#15 Leinad972: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_25 : EventTest
    {
        [Test]
        public void Deck01_Mikhathara1994_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",0),
                "PostZendikarRising",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck02_MiguelCaster_BorosTaxes_WR_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",1),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "Taxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_PhillHellmuth_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",2),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck04_xfile_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",3),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Taxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_ViolentOutburst_Scapeshift_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",4),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck06_ArtemKuhtin_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",5),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Taxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_mmapson125_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",6),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck08_fwdr3_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",7),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Damgar_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",9),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck11_toondoslav_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",10),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck12_musasabi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",11),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Loco78_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",12),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Ekeross_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",13),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Leinad972_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",14),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
