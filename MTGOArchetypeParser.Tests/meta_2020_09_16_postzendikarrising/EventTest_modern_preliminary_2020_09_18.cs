using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 ilsecco14: Gruul Midrange (RG)
#02 Mcleskey: Bogles (WG)
#03 TheMelkMan: Eldrazi Tron (C)
#04 Gernardi: Grixis Shadow (UBR)
#05 dani_chad: Jund Midrange (BRG)
#06 GodOfSlaughter: Gruul Midrange (RG)
#07 Redgy819: Jund Midrange (BRG)
#08 Draccon136: Mono White Taxes (W)
#09 AbelMolto: Burn (WRG)
#10 Matti: Dredge (BRG)
#11 TheEnzym: Mill (UB)
#12 pokerswizard: Humans (WUBRG)
#13 Nammersquats: Mill (UB, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_09_18 : EventTest
    {
        [Test]
        public void Deck01_ilsecco14_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",0),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Mcleskey_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",1),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck03_TheMelkMan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",2),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck04_Gernardi_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",3),
                "PostZendikarRising",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck05_danichad_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",4),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_GodOfSlaughter_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",5),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Redgy819_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",6),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Draccon136_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",7),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck09_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",8),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck10_Matti_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",9),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck11_TheEnzym_Mill_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",10),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck12_pokerswizard_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",11),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Nammersquats_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",12),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
