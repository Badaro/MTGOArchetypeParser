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
#01 Cherryxman: Dice Factory Tron (G)
#02 GYBA: Jund Midrange (BRG)
#03 ProTourFreddie: Mono Red Prowess (R)
#04 cftsoc3: Bant Blink (WUG)
#05 fradev1988: Electro Balance (UR)
#06 Lucabireskusku: Uroza (URG)
#07 Searzist: Mono Red Prowess (R)
#08 Strondons: Titan Shift (RG)
#09 McWinSauce: WURG Control (WURG)
#10 MATTHEWFOULKES: Mono Red Prowess (R)
#11 helvetti: Izzet Control (UR)
#12 Lilguy1991: Grixis Shadow (UBR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_30 : EventTest
    {
        [Test]
        public void Deck01_Cherryxman_DiceFactoryTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(DiceFactoryTron),
                null
            );
        }

        [Test]
        public void Deck02_GYBA_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30",1),
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
                GetDeck("modern-preliminary-2020-01-30",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck04_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30",3),
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
                GetDeck("modern-preliminary-2020-01-30",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck06_Lucabireskusku_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Searzist_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck08_Strondons_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck09_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_MATTHEWFOULKES_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck11_helvetti_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-30",10),
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
                GetDeck("modern-preliminary-2020-01-30",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }


    }
}
