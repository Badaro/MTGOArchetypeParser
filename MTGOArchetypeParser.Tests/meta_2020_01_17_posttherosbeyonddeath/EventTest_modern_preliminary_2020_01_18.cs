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
#01 Toastxp: Amulet Titan (UG)
#02 Nammersquats: Titan Shift (RG)
#03 billsive: Dice Factory Tron (C)
#04 SoulStrong: Yawgmoth (BG)
#05 xfile: Mono Red Prowess (R)
#06 karatedom: Devoted (WG)
#07 SourceOdin: Titan Shift (BG)
#08 g0ldmanzachs: Thopter Urza (UBR)
#09 sten626: Dredge (BRG)
#10 penips: Orzhov Taxes (WB)
#11 NightShadowJ: Thopter Urza (UBR)
#12 Erik157751: Crabvine (UBG)
#13 i_b_TRUE: Titan Shift (RG)
#14 fooswashere: Jund Midrange (BRG)
#15 rileydk: Amulet Titan (G)
#16 Xwhale: Gruul Midrange (RG)
#17 TheTunnelingCat: Eldrazi Tron (C)
#18 zMagic4ever: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_18 : EventTest
    {
        [Test]
        public void Deck01_Toastxp_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_Nammersquats_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck03_billsive_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(DiceFactoryTron),
                null
            );
        }

        [Test]
        public void Deck04_SoulStrong_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck05_xfile_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_karatedom_Devoted_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck07_SourceOdin_TitanShift_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck08_g0ldmanzachs_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck09_sten626_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_penips_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck11_NightShadowJ_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck12_Erik157751_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck13_ibTRUE_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck14_fooswashere_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_rileydk_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck16_Xwhale_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_zMagic4ever_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-18",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}