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
#01 twinlesstwin: Delver (UBR, Lurrus)
#02 Sodeq: Dredge (BRG)
#03 Fatcaster_Mage: Bant Control (WUG)
#04 bobthedog: Kiki Chord (WURG, Yorion)
#05 cftsoc3: Bant Blink (WUG)
#06 J4V13R: Golgari Midrange (BG, Lurrus)
#07 retiredcapivara: Dredge (BRG)
#08 Marvellion: Jund Midrange (BRG)
#09 jessy_samek: Burn (WR, Lurrus)
#10 Parrit: Orzhov Taxes (WB)
#11 Misplacedginger: Bant Control (WUG)
#12 CordoTwin: Mardu Shadow (WBR)
#13 GoblinK1ng: Goblins (BRG)
#14 NorrathDecay: Burn (WR)
#15 gavinwen: Humans (WUBRG)
#16 rusty_gates: Jund Midrange (BRG, Lurrus)
#17 Predict: Bant Control (WUG)
#18 Danny_Bambino: UBRG Shadow (UBRG, Lurrus)
#19 DauntedPanda: Gruul Midrange (RG)
#20 beestjes: WURG Midrange (WURG)
#21 toondoslav: Niv To Light (WUBRG)
#22 lucasensei2: Electro Balance (UR)
#23 Heir_of_Elendil15: Delver (UBR, Lurrus)
#24 TheRealRickJames: Izzet Prowess (UR)
#25 cws: Gifts Storm (UR, Jegantha)
#26 Happymil24: Mono Red Prowess (R)
#27 Yanti: Humans (WUBRG)
#28 mtgpirate: Bogles (WG, Lurrus)
#29 svessesvv: Eldrazi Tron (C)
#30 ContraEgo: Goblins (BRG)
#31 AvocadoToast: Jund Shadow (BRG, Lurrus)
#32 Moniz0801: Amulet Titan (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_04_19 : EventTest
    {
        [Test]
        public void Deck01_twinlesstwin_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",0),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",1),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_FatcasterMage_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",2),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_bobthedog_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",3),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",4),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck06_J4V13R_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",5),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_retiredcapivara_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",6),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Marvellion_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",7),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_jessysamek_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",8),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Parrit_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",9),
                new PostIkoria(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",10),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_CordoTwin_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",11),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck13_GoblinK1ng_Goblins_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",12),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck14_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",13),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck15_gavinwen_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",14),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_rustygates_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",15),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_Predict_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",16),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_DannyBambino_UBRGShadow_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",17),
                new PostIkoria(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_DauntedPanda_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",18),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_beestjes_WURGMidrange_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",19),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(DomainZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck21_toondoslav_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",20),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck22_lucasensei2_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",21),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck23_HeirofElendil15_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",22),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_TheRealRickJames_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",23),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck25_cws_GiftsStorm_UR_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",24),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck26_Happymil24_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",25),
                new PostIkoria(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Yanti_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",26),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck28_mtgpirate_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",27),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_svessesvv_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",28),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck30_ContraEgo_Goblins_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",29),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck31_AvocadoToast_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",30),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_Moniz0801_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-04-19",31),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }


    }
}
