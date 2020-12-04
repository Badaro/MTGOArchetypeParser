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
#01 Mikhathara1994: Grixis Shadow (UBR)
#02 MiguelCaster: Mono White Taxes (W, Yorion)
#03 Phill_Hellmuth: Oops All Spells (WUBG)
#04 xfile: Azorius Taxes (WU, Yorion)
#05 Violent_Outburst: Scapeshift (UBRG)
#06 Artem_Kuhtin: Azorius Taxes (WU, Yorion)
#07 mmapson125: Heliod Combo (WG)
#08 fwdr3: Shadow Prowess (BR, Lurrus)
#09 albert62: WURG Control (WURG)
#10 Damgar: KGC Tron (G)
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
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck02_MiguelCaster_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",1),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_PhillHellmuth_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck04_xfile_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",3),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_ViolentOutburst_Scapeshift_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",4),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ArtemKuhtin_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",5),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_mmapson125_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_fwdr3_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",7),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",8),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Damgar_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",9),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck11_toondoslav_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",10),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_musasabi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",11),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Loco78_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",12),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Ekeross_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",13),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Leinad972_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-25",14),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
