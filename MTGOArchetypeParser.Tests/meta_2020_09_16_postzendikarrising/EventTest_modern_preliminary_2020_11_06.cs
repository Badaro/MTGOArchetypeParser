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
#01 Mulldrifter: Shadow Prowess (WBR, Lurrus)
#02 DrDree: Infect (UG)
#03 fingers1991: Devoted (WG, Lurrus)
#04 RandomOctopus: Shadow Prowess (WBR, Lurrus)
#05 wambocombo2020: Temur Control (URG)
#06 Martin_Dominguez: Heliod Combo (WG)
#07 MrRaeb: UBRG Control (UBRG)
#08 Gerardo94: WURG Control (WURG)
#09 yamakiller: Obosh Aggro (R, Obosh)
#10 _IlNano_: Shadow Prowess (BRG, Lurrus)
#11 pokerswizard: Green Tron (RG)
#12 Ramp: Reclaimer Titan (WG)
#13 Jaberwocki: Jund Midrange (BRG)
#14 McWinSauce: WURG Control (WURG)
#15 Ikashy: Oops All Spells (WUBRG)
#16 SpiderSpace: Electro Balance (URG)
#17 QuaCk QuaCk: Scapeshift (URG)
#18 _Falcon_: Izzet Prowess (UR)
#19 __BMJ__: Shadow Prowess (BR, Lurrus)
#20 mmapson125: WURG Control (WURG)
#21 Tiemuuu: Izzet Control (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_06 : EventTest
    {
        [Test]
        public void Deck01_Mulldrifter_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",0),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_DrDree_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",1),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck03_fingers1991_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",2),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_RandomOctopus_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",3),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_wambocombo2020_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",4),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_MartinDominguez_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",5),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck07_MrRaeb_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",6),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",8),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_IlNano_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",9),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_pokerswizard_GreenTron_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",10),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck12_Ramp_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",11),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck13_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",12),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",13),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Ikashy_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",14),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck16_SpiderSpace_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",15),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck17_QuaCkQuaCk_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",16),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Falcon_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",17),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck19_BMJ_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",18),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_mmapson125_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",19),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-06",20),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }


    }
}
