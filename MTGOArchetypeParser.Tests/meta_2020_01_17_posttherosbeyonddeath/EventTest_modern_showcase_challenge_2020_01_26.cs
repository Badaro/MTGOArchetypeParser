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
#01 PuntThenWhine: Amulet Titan (UG)
#02 musasabi: Jund Midrange (BRG)
#03 McWinSauce: WURG Control (WURG)
#04 Naisirc: Neobrand (UG)
#05 toondoslav: Primeval Titan (UG)
#06 Cherryxman: Eldrazi Tron (G)
#07 qbturtle15: Azorius Control (WU)
#08 MATTHEWFOULKES: Mono Red Prowess (R)
#09 bolov0: Titan Shift (RG)
#10 Theo_Jung: Primeval Titan (UG)
#11 rileydk: Amulet Titan (UG)
#12 SebastianStueckl: Dredge (BRG)
#13 mell0n: Primeval Titan (UG)
#14 _Batutinha_: Mono Red Prowess (R)
#15 didoguidotti1: UBRG Shadow (UBRG)
#16 _Shatun_: Mono Red Prowess (R)
#17 palk52: UBRG Shadow (UBRG)
#18 Folero: Dredge (BRG)
#19 mechrataal: Azorius Control (WU)
#20 maxxattack: Infect (UG)
#21 karn_90: Grixis Shadow (UBR)
#22 Graciasportanto: Amulet Titan (UG)
#23 v3sp_tv: Elementals (WUBRG)
#24 Violent_Outburst: UBRG Shadow (UBRG)
#25 NightShadowJ: Jund Midrange (BRG)
#26 SourceOdin: Primeval Titan (UG)
#27 kanister: Amulet Titan (G)
#28 rksgsn: Mono Red Prowess (R)
#29 Coly2: Izzet Control (UR)
#30 Tiemuuu: Izzet Control (UR)
#31 leclairandy: Mono Red Prowess (R)
#32 starfall: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_showcase_challenge_2020_01_26 : EventTest
    {
        [Test]
        public void Deck01_PuntThenWhine_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_musasabi_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Naisirc_Neobrand_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck05_toondoslav_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Cherryxman_EldraziTron_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_MATTHEWFOULKES_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck09_bolov0_TitanShift_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck10_TheoJung_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck11_rileydk_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_SebastianStueckl_Dredge_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck13_mell0n_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Batutinha_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck15_didoguidotti1_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck17_palk52_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Folero_Dredge_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_mechrataal_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_maxxattack_Infect_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck21_karn90_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Graciasportanto_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck23_v3sptv_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck24_ViolentOutburst_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",23),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck25_NightShadowJ_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",24),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_SourceOdin_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",25),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck27_kanister_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",26),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck28_rksgsn_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",27),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck29_Coly2_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",28),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",29),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_leclairandy_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",30),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck32_starfall_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-01-26",31),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}
