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
#01 barczek: Belcher (URG)
#02 Nextep: Sultai Control (UBG)
#03 MastaHorus: Izzet Living End (UR)
#04 Kazuga: Heliod Combo (WG)
#05 Artem_Kuhtin: Reclaimer Titan (WRG)
#06 albert62: WURG Control (WURG)
#07 yamakiller: KGC Tron (G)
#08 swiftwarkite2: Hammer Time (W, Lurrus)
#09 ChironTheMage: UBRG Control (UBRG)
#10 Poyo_del_Mal: Heliod Combo (WG)
#11 _Shatun_: Obosh Aggro (R, Obosh)
#12 sandydogmtg: Humans (WUBRG)
#13 Martin_Dominguez: Heliod Combo (WG)
#14 Antarctica: E Tron (C)
#15 Violent_Outburst: Scapeshift (UBRG)
#16 Chefen: Belcher (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_27 : EventTest
    {
        [Test]
        public void Deck01_barczek_Belcher_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",0),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Nextep_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",1),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_MastaHorus_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck04_Kazuga_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",3),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ArtemKuhtin_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",4),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck06_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_yamakiller_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",6),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_swiftwarkite2_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",7),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_ChironTheMage_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",8),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_PoyodelMal_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",9),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Shatun_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",10),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck12_sandydogmtg_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",11),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_MartinDominguez_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",12),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Antarctica_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",13),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_ViolentOutburst_Scapeshift_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",14),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Chefen_Belcher_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-27",15),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }


    }
}
