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
#01 TSPJendrek: SultaiControl (UBG)
#02 Sommertroll: Humans (WUBRG)
#03 Capriccioso: BringToNiv (WUBRG)
#04 paucr5: Devoted (WG, Lurrus)
#05 ContraEgo: ThopterUrza (UBR)
#06 TheJigIsAlwaysup: ShadowProwess (BR, Lurrus)
#07 j_money10: ShadowProwess (BR, Lurrus)
#08 SKK: OopsAllSpells (WUBRG)
#09 Rinko: EnduringIdeal (WR)
#10 mansak: JundMidrange (BRG)
#11 Janh: SultaiControl (UBG)
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
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Sommertroll_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",1),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Capriccioso_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck04_paucr5_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",3),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",4),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck06_TheJigIsAlwaysup_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_jmoney10_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_SKK_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",7),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",8),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck10_mansak_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",9),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Janh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-30",10),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
