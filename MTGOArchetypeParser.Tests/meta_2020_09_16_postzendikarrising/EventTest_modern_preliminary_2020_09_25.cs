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
#01 yamakiller: ShadowProwess (BR, Lurrus)
#02 qbturtle15: MonoWhiteTaxes (W)
#03 NHA37: RakdosShadow (BR, Lurrus)
#04 GGBud1717: IzzetProwess (UR)
#05 Usama96: WURGControl (WURG)
#06 Jositoshekel: Bogles (WUG, Lurrus)
#07 andrw1232: WURGControl (WURG)
#08 HouseOfManaMTG: AmuletTitan (UBRG)
#09 Nammersquats: Devoted (WG, Lurrus)
#10 MindOfAKid: UBRGMidrange (UBRG)
#11 McWinSauce: WURGControl (WURG)
#12 Sanchez5272: ETron (C)
#13 KelMasterP: ShadowProwess (BR, Lurrus)
#14 medvedev: MonoWhiteTaxes (W)
#15 pokerswizard: GruulMidrange (RG)
#16 _Shatun_: GruulMidrange (RG)
#17 Snusnumrick: ETron (C)
#18 wambocombo2020: Humans (WUBRG)
#19 nedyahiske: ShadowProwess (BR, Lurrus)
#20 ConnorM426: OopsAllSpells (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_09_25 : EventTest
    {
        [Test]
        public void Deck01_yamakiller_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",0),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",1),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck03_NHA37_RakdosShadow_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_GGBud1717_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",3),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Usama96_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",4),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Jositoshekel_Bogles_WUG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",5),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_andrw1232_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_HouseOfManaMTG_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",7),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_Nammersquats_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_MindOfAKid_UBRGMidrange_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",9),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",10),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Sanchez5272_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",11),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck13_KelMasterP_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",12),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_medvedev_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",13),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck15_pokerswizard_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",14),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",15),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Snusnumrick_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",16),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_wambocombo2020_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",17),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck19_nedyahiske_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",18),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_ConnorM426_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",19),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }


    }
}
