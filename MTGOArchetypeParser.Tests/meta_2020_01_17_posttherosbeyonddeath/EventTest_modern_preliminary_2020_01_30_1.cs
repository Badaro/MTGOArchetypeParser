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
#01 Cherryxman: Dice Factory Tron (C)
#02 GYBA: Jund Midrange (BRG)
#03 ProTourFreddie: Mono Red Prowess (R)
#04 cftsoc3: Bant Blink (WUG)
#05 fradev1988: Electro Balance (UR)
#06 Lucabireskusku: Uroza (UG)
#07 Searzist: Mono Red Prowess (R)
#08 Strondons: Titan Shift (RG)
#09 McWinSauce: Bant Control (WUG)
#10 MATTHEWFOULKES: Mono Red Prowess (R)
#11 helvetti: Izzet Control (UR)
#12 Lilguy1991: Grixis Shadow (UBR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_30_1 : EventTest
    {
        [Test]
        public void Deck01_Cherryxman_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(DiceFactoryTron),
                null
            );
        }

        [Test]
        public void Deck02_GYBA_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ProTourFreddie_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck05_fradev1988_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck06_Lucabireskusku_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Searzist_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Strondons_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck09_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_MATTHEWFOULKES_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_helvetti_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Lilguy1991_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30-1",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }


    }
}
