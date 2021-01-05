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
#01 PTarts2win: WURG Control (WURG)
#02 IntegralHDK: Jund Midrange (BRG)
#03 Zar0s: Jund Midrange (BRG)
#04 trunks132: Shadow Prowess (BR, Lurrus)
#05 koudai_iwatou: Tokens (WB, Lurrus)
#06 otakkun: E Tron (C)
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
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_IntegralHDK_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",1),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Zar0s_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_trunks132_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",3),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_koudaiiwatou_Tokens_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",4),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_otakkun_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",5),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_SIMONEFIERRO_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",6),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_mansak_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",7),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-26",8),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
