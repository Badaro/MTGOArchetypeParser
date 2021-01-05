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
#01 ThekingFor1000years: Infect (UG)
#02 Bullwinkkle6705: Temur Control (URG)
#03 CHILLEDADED: KGC Tron (G)
#04 andrw1232: Temur Control (URG)
#05 PTarts2win: Gruul Midrange (RG)
#06 pokerswizard: Humans (WUBRG)
#07 Kazuga: Dredge (BRG)
#08 Hemsley: Hammer Time (WR, Lurrus)
#09 leclairandy: Temur Control (URG)
#10 Waumpus: Heliod Combo (WUG)
#11 jsteed: Gruul Midrange (RG)
#12 Lord_of_Puntlantis: Izzet Restore Balance (UR)
#13 Mcleskey: Humans (WUBRG)
#14 MZBlazer: Grixis Shadow (UBR)
#15 Icteridae: Mono White Taxes (W)
#16 _IlNano_: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_09_17 : EventTest
    {
        [Test]
        public void Deck01_ThekingFor1000years_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",0),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Bullwinkkle6705_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",1),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_CHILLEDADED_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",2),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck04_andrw1232_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",3),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PTarts2win_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",4),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_pokerswizard_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",5),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Kazuga_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",6),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Hemsley_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",7),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_leclairandy_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",8),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Waumpus_HeliodCombo_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",9),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_jsteed_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",10),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_LordofPuntlantis_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",11),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck13_Mcleskey_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",12),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck14_MZBlazer_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",13),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Icteridae_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",14),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck16_IlNano_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-17",15),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}
