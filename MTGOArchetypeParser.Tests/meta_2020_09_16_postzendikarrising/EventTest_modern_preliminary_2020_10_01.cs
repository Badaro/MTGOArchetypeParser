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
#01 nathansteuer: WURGControl (WURG)
#02 qbturtle15: MonoWhiteTaxes (W)
#03 Rav104: OopsAllSpells (WUBRG)
#04 il_matagatto: Humans (WUBRG)
#05 SunofNothing: WURGControl (WURG)
#06 Ryan100495: Dredge (BRG)
#07 Ihavethefire: JundMidrange (BRG)
#08 pokerswizard: OrzhovMidrange (WB)
#09 Bullwinkkle6705: UBRGControl (UBRG)
#10 Edel: RakdosMidrange (BR)
#11 sandydogmtg: ShadowProwess (BR, Lurrus)
#12 Draconic1: AmuletTitan (UBRG)
#13 Icteridae: GruulMidrange (RG)
#14 im2g00t4ubarn: WURGControl (WURG)
#15 hcook725: ShadowProwess (BR, Lurrus)
#16 cntrlfreak: GrixisShadow (UBR)
#17 Karolmo: Infect (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_01 : EventTest
    {
        [Test]
        public void Deck01_nathansteuer_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",1),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Rav104_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck04_ilmatagatto_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SunofNothing_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",4),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",5),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Ihavethefire_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",6),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_pokerswizard_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",7),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Bullwinkkle6705_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",8),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Edel_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_sandydogmtg_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",10),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Draconic1_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",11),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_Icteridae_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",12),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",13),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_hcook725_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",14),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_cntrlfreak_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",15),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Karolmo_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-01",16),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }


    }
}