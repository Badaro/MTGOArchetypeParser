using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 PTarts2win: WURG Control (WURG)
#02 IntegralHDK: Jund Midrange (BRG)
#03 Zar0s: Jund Midrange (BRG)
#04 trunks132: Shadow Prowess (BR, Lurrus)
#05 koudai_iwatou: Tokens (WB, Lurrus)
#06 otakkun: Eldrazi Tron (C)
#07 SIMONEFIERRO: Burn (WR, Lurrus)
#08 mansak: Jund Midrange (BRG)
#09 _Shatun_: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_09_26 : EventTest
    {
        [Test]
        public void Deck01_PTarts2win_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",0),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_IntegralHDK_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",1),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Zar0s_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",2),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_trunks132_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",3),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_koudaiiwatou_Tokens_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",4),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "Tokens",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_otakkun_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",5),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_SIMONEFIERRO_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",6),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_mansak_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",7),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",8),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
