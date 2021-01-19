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
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Mcleskey_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",1),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck03_TheMelkMan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",2),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_Gernardi_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",3),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_danichad_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",4),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_GodOfSlaughter_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",5),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Redgy819_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",6),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Draccon136_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",7),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck09_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",8),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Matti_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",9),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck11_TheEnzym_Mill_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",10),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck12_pokerswizard_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",11),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Nammersquats_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-18",12),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
