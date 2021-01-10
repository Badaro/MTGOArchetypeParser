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
#01 otakkun: Green Tron (G)
#02 vinnyrussian123: Primeval Titan (UG)
#03 cftsoc3: Bant Blink (WUG)
#04 ThePurpleMage: Devoted (WBG)
#05 Dafne17: Gruul Midrange (RG)
#06 HannoLee: Uroza (URG)
#07 Metal_Buddha: Jund Midrange (BRG)
#08 Chipsoss: UBRG Shadow (UBRG)
#09 2radMTG: Infect (UG)
#10 Toastxp: Amulet Titan (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_14 : EventTest
    {
        [Test]
        public void Deck01_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-14",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck02_vinnyrussian123_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-14",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck03_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-14",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck04_ThePurpleMage_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-14",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Dafne17_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-14",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_HannoLee_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-14",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck07_MetalBuddha_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-14",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Chipsoss_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-14",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck09_2radMTG_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-14",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Toastxp_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-14",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }


    }
}
