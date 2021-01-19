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
#01 Zar0s: Gruul Midrange (RG)
#02 McWinSauce: WURG Control (WURG)
#03 SgtMcMuffins: Reclaimer Titan (WRG)
#04 Redgy819: UBRG Shadow (UBRG)
#05 benchsummer: UBRG Shadow (UBRG)
#06 Humpaa: Shadow Prowess (BR, Lurrus)
#07 solaec0501: Humans (WUBRG)
#08 TheSouthDakota: Dredge (BRG)
#09 Lukas261997: Grixis Shadow (UBR)
#10 Oderus Urungus: Humans (WUBRG)
#11 andrw1232: WURG Control (WURG)
#12 wiltay0494: Neobrand (UG)
#13 kanister: WURG Control (WURG)
#14 ZYURYO: WURG Control (WURG)
#15 WhiTe TsaR: Humans (WUBRG)
#16 indianpancake: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_09_22 : EventTest
    {
        [Test]
        public void Deck01_Zar0s_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",0),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_SgtMcMuffins_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",2),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck04_Redgy819_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",3),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",4),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Humpaa_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_solaec0501_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",6),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck08_TheSouthDakota_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",7),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Lukas261997_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",8),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck10_OderusUrungus_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",9),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck11_andrw1232_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",10),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_wiltay0494_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",11),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck13_kanister_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",12),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",13),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_WhiTeTsaR_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",14),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_indianpancake_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-22",15),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
