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
#01 Samlg01: Amulet Titan (WUBRG)
#02 HardcoreHenry: Abzan Midrange (WBG)
#03 Gobern: Sultai Reclamation (UBG)
#04 _LSN_: Burn (WR)
#05 PRGJJAR: Dredge (BRG)
#06 SKK: Shadow Prowess (BR, Lurrus)
#07 JUJUBEAN__2004: UBRG Control (UBRG)
#08 pokerswizard: Shadow Prowess (BR, Lurrus)
#09 Soondubu: Heliod Combo (WG)
#10 TerminalJustice: Gifts Storm (UR)
#11 Lordzedane: Oops All Spells (WUBRG)
#12 CitrusD: Yawgmoth (BG)
#13 MikeSoles: Rakdos Prowess (BR, Lurrus)
#14 Icteridae: Gruul Midrange (RG)
#15 yumad3988: Esper Shadow (WUB)
#16 ZYURYO: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_22 : EventTest
    {
        [Test]
        public void Deck01_Samlg01_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",0),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_HardcoreHenry_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",1),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Gobern_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",2),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",3),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",4),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SKK_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_JUJUBEAN2004_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",6),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_pokerswizard_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",7),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Soondubu_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TerminalJustice_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",9),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Lordzedane_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",10),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck12_CitrusD_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",11),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck13_MikeSoles_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",12),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Icteridae_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",13),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_yumad3988_EsperShadow_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",14),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck16_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-22",15),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
