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
#01 EddDeedoo: Orzhov Midrange (WB)
#02 nahuel10: Gruul Midrange (RG)
#03 ZYX_Jerry: Obosh Aggro (R, Obosh)
#04 SpoonDonkey: Izzet Control (UR)
#05 DoctorQueller: Spirits (WU)
#06 PhantasmalBear: Azorius Midrange (WU)
#07 bobthedog: Heliod Sisters (W)
#08 tnequipa: Bogles (WG, Lurrus)
#09 MrQ4: Ad Nauseam (WUB)
#10 TheDuinoElegies: Boros Prowess (WR, Lurrus)
#11 IzzetSignetIsTheBest: Amulet Titan (WUBRG)
#12 Sprouts: Abzan Midrange (WBG)
#13 BigDadChad: Green Devotion (UG)
#14 olea: Heliod Combo (WG)
#15 Menoti: E Tron (C)
#16 Hipmon: Grixis Shadow (UBR)
#17 Alzik: Rakdos Prowess (BR, Lurrus)
#18 rafp: Humans (WUBRG)
#19 TLaros: Titan Shift (RG)
#20 ChaoticCamel: Jund Shadow (BRG)
#21 Jaberwocki: Jund Midrange (BRG)
#22 Bugsy69: Izzet Prowess (UR)
#23 Predicted: Yawgmoth (WBG)
#24 touto_Isle: Dredge (BRG)
#25 JRDC14: Niv To Light (WUBRG, Yorion)
#26 Rebus8: Orzhov Eldrazi Taxes (WB)
#27 tbrantl99: Reclaimer Titan (WRG)
#28 Do0mSwitch: Bant Control (WUG)
#29 BaDzIo: Mono Red Prowess (R)
#30 Elibaechan: Snoop Goblins (BRG)
#31 heyakita: Snow Saheeli (WURG, Yorion)
#32 Galanator: Azorius Control (WU)
#33 MioCid: Scapeshift (URG)
#34 Middeterminist: Simic Reclamation (UG)
#35 The french goblin: Azorius Control (WU)
#36 ferrum0728: Mardu Shadow (WBR)
#37 Kurusu: Kiki Chord (WRG, Yorion)
#38 Parrit: Selenya Eldrazi Taxes (WG)
#39 Ennuixd: Temur Reclamation (URG)
#40 kokoko098: Heliod Devoted (WBG)
#41 Maxtick: Bant Midrange (WUG)
#42 gazmon48: KGC Tron (G)
#43 m_joe: WUBG Blink (WUBG)
#44 TuggaNaxos: Sultai Reclamation (UBG)
#45 vasko19: Izzet Restore Balance (URG)
#46 Flaxh: Dimir Control (UB)
#47 Beicodegeia: Gifts Storm (UR)
#48 comradGT: Tokens (WB)
#49 Werebere: Burn (WRG)
#50 Zxrogue: Azorius Control (WU)
#51 Chaughey: Jeskai Delver (WUR)
#52 Somefellow: U Tron (U)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_08_14 : EventTest
    {
        [Test]
        public void Deck01_EddDeedoo_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-14",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_nahuel10_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",1),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ZYXJerry_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-08-14",2),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck04_SpoonDonkey_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-14",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-14",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck06_PhantasmalBear_AzoriusMidrange_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-14",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_bobthedog_HeliodSisters_W()
        {
            Test(
                GetDeck("modern-league-2020-08-14",6),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck08_tnequipa_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-14",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_MrQ4_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-14",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TheDuinoElegies_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-14",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_IzzetSignetIsTheBest_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_Sprouts_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_BigDadChad_GreenDevotion_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GreenDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck14_olea_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Menoti_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-08-14",14),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Hipmon_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-14",15),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Alzik_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-14",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_rafp_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck19_TLaros_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",18),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck20_ChaoticCamel_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",19),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",20),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Bugsy69_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-14",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck24_toutoIsle_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",23),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck25_JRDC14_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-14",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_Rebus8_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-14",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck27_tbrantl99_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck28_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_BaDzIo_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-08-14",28),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Elibaechan_SnoopGoblins_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",29),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck31_heyakita_SnowSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-14",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(SnowSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Galanator_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-14",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_MioCid_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",32),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Middeterminist_SimicReclamation_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",33),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Thefrenchgoblin_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-14",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck36_ferrum0728_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-league-2020-08-14",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-14",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck38_Parrit_SelenyaEldraziTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",37),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Ennuixd_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",38),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck40_kokoko098_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck41_Maxtick_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",40),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck42_gazmon48_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-08-14",41),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck43_mjoe_WUBGBlink_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck44_TuggaNaxos_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",43),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck45_vasko19_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",44),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck46_Flaxh_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-08-14",45),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Beicodegeia_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-14",46),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck48_comradGT_Tokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-14",47),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Werebere_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-14",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Zxrogue_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-14",49),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Chaughey_JeskaiDelver_WUR()
        {
            Test(
                GetDeck("modern-league-2020-08-14",50),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(Delver),
                typeof(JeskaiDelver),
                null
            );
        }

        [Test]
        public void Deck52_Somefellow_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-08-14",51),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }


    }
}
