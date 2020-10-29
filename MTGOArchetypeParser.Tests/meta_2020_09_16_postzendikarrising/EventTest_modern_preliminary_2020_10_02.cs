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
#01 Phill_Hellmuth: WURG Control (WURG)
#02 BERNASTORRES: WURG Control (WURG)
#03 Rav104: Oops All Spells (WUBRG)
#04 im2g00t4ubarn: WURG Control (WURG)
#05 Humpaa: Orzhov Midrange (WB)
#06 eclipse4343: Azorius Control (WU)
#07 Graciasportanto: WURG Control (WURG)
#08 Traft: WURG Control (WURG)
#09 nedyahiske: Sultai Control (UBG)
#10 Samcaster-Mage: E Tron (C)
#11 _IlNano_: Shadow Prowess (BR, Lurrus)
#12 Nammersquats: Humans (WUBRG)
#13 Mcleskey: Izzet Prowess (UR)
#14 joetru: Bring To Niv (WUBRG)
#15 yamakiller: Shadow Prowess (BR, Lurrus)
#16 dani_chad: Jund Midrange (BRG)
#17 DreamsOfAshiok: E Tron (C)
#18 benjamin13: Bushwhacker Zoo (WRG)
#19 nathanb1992: Orzhov Midrange (WB)
#20 ilsecco14: Shadow Prowess (BR, Lurrus)
#21 NewHJ: Obosh Aggro (R, Obosh)
#22 coert: Merfolk (U)
#23 trader08111: Gruul Midrange (RG)
#24 qbturtle15: Mono White Taxes (W)
#25 j_money10: Shadow Prowess (BR, Lurrus)
#26 AbelMolto: Burn (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_02 : EventTest
    {
        [Test]
        public void Deck01_PhillHellmuth_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_BERNASTORRES_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Rav104_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck04_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Humpaa_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",4),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",5),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Graciasportanto_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Traft_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_nedyahiske_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",8),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SamcasterMage_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",9),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_IlNano_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",10),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Nammersquats_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",11),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Mcleskey_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",12),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_joetru_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",13),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck15_yamakiller_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",14),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_danichad_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",15),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_DreamsOfAshiok_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",16),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_benjamin13_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",17),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck19_nathanb1992_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",18),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ilsecco14_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",19),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_NewHJ_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",20),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck22_coert_Merfolk_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",21),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck23_trader08111_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",22),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",23),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck25_jmoney10_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",24),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-02",25),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }


    }
}
