using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 TSPJendrek: Sultai Control (UBG)
#02 Sommertroll: Humans (WUBRG)
#03 Capriccioso: Niv To Light (WUBRG)
#04 paucr5: Devoted (WG, Lurrus)
#05 ContraEgo: Thopter Urza (WUBR)
#06 TheJigIsAlwaysup: Shadow Prowess (BR, Lurrus)
#07 j_money10: Shadow Prowess (BR, Lurrus)
#08 SKK: Oops All Spells (WUBRG)
#09 Rinko: Enduring Ideal (WR)
#10 mansak: Jund Midrange (BRG)
#11 Janh: Sultai Control (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_09_30 : EventTest
    {
        [Test]
        public void Deck01_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",0),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Sommertroll_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",1),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Capriccioso_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",2),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck04_paucr5_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",3),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_ContraEgo_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",4),
                "PostZendikarRising",
                ArchetypeColor.WUBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck06_TheJigIsAlwaysup_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",5),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_jmoney10_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",6),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_SKK_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",7),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",8),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "EnduringIdeal",
                null,
                null
            );
        }

        [Test]
        public void Deck10_mansak_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",9),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Janh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",10),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
