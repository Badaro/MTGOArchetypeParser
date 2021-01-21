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
#01 qbturtle15: Mono White Taxes (W)
#02 Chris_Concarnage: Gruul Midrange (RG)
#03 JUJUBEAN__2004: UBRG Control (UBRG)
#04 HardcoreHenry: Shadow Prowess (WBR, Lurrus)
#05 Mcleskey: Obosh Aggro (R, Obosh)
#06 Icteridae: Gruul Midrange (RG)
#07 pokerswizard: Humans (WUBRG)
#08 Lordzedane: Gruul Midrange (RG)
#09 PTarts2win: WURG Control (WURG)
#10 Gobern: Niv To Light (WUBRG, Yorion)
#11 timewalkinonsunshine: Taking Turns (URG)
#12 karatedom: Mono White Taxes (W)
#13 ThekingFor1000years: Infect (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_08 : EventTest
    {
        [Test]
        public void Deck01_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",0),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck02_ChrisConcarnage_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",1),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_JUJUBEAN2004_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",2),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_HardcoreHenry_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",3),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Mcleskey_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",4),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_Icteridae_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",5),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_pokerswizard_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",6),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Lordzedane_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",7),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_PTarts2win_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Gobern_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",9),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",10),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "TakingTurns",
                null,
                null
            );
        }

        [Test]
        public void Deck12_karatedom_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",11),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck13_ThekingFor1000years_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-08",12),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }


    }
}
