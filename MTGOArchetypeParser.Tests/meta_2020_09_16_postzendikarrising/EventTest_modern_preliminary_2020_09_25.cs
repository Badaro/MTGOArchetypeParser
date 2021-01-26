using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 yamakiller: Shadow Prowess (BR, Lurrus)
#02 qbturtle15: Mono White Taxes (W)
#03 NHA37: Shadow Prowess (BR, Lurrus)
#04 GGBud1717: Izzet Prowess (UR)
#05 Usama96: WURG Control (WURG)
#06 Jositoshekel: Bogles (WUG, Lurrus)
#07 andrw1232: WURG Control (WURG)
#08 HouseOfManaMTG: Amulet Titan (UG)
#09 Nammersquats: Devoted (WG, Lurrus)
#10 MindOfAKid: UBRG Shadow (UBRG)
#11 McWinSauce: WURG Control (WURG)
#12 Sanchez5272: Eldrazi Tron (C)
#13 KelMasterP: Shadow Prowess (BR, Lurrus)
#14 medvedev: Selesnya Taxes (WG)
#15 pokerswizard: Gruul Midrange (RG)
#16 _Shatun_: Gruul Midrange (RG)
#17 Snusnumrick: Eldrazi Tron (C)
#18 wambocombo2020: Humans (WUBRG)
#19 nedyahiske: Shadow Prowess (BR, Lurrus)
#20 ConnorM426: Oops All Spells (WUBRG)
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
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",1),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck03_NHA37_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",2),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_GGBud1717_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",3),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck05_Usama96_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",4),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Jositoshekel_Bogles_WUG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",5),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_andrw1232_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_HouseOfManaMTG_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",7),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck09_Nammersquats_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",8),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_MindOfAKid_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",9),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck11_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",10),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Sanchez5272_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",11),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck13_KelMasterP_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",12),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_medvedev_SelesnyaTaxes_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",13),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck15_pokerswizard_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",14),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",15),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Snusnumrick_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",16),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_wambocombo2020_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",17),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck19_nedyahiske_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",18),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_ConnorM426_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-25",19),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }


    }
}
