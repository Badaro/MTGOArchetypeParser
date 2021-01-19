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
#01 pepeisra: Thopter Urza (UB)
#02 fradev1988: Electro Balance (UR)
#03 Mariklus86: Titan Shift (RG)
#04 Nammersquats: Mono Red Prowess (R)
#05 Boland: Grixis Shadow (UBR)
#06 shadow_PT: Jund Midrange (BRG)
#07 MattiJohansson: Humans (WUBRG)
#08 ecobaronen: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_31 : EventTest
    {
        [Test]
        public void Deck01_pepeisra_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-31",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck02_fradev1988_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-31",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck03_Mariklus86_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-31",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck04_Nammersquats_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-31",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-31",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_shadowPT_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-31",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_MattiJohansson_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-31",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ecobaronen_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-31",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
