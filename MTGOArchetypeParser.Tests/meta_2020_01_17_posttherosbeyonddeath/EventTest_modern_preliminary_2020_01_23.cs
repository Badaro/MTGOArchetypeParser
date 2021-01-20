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
#01 Cherryxman: Eldrazi Tron (G)
#02 cronman87: Mono Red Prowess (R)
#03 Kazuga: Dredge (BRG)
#04 Bayesta_93: Grixis Shadow (UBR)
#05 McWinSauce: Azorius Control (WU)
#06 Mogged: Mono Red Prowess (R)
#07 exoticherman: Infect (UG)
#08 SebastianStueckl: Neobrand (UG)
#09 Tiemuuu: Izzet Control (UR)
#10 shadow_PT: Azorius Control (WU)
#11 jessy_samek: Burn (WR)
#12 mitchrules25: Burn (WR)
#13 bntrusty14: Humans (WUBRG)
#14 BReal2: Mardu Midrange (WBR)
#15 urzatheplaneswalker: Mono Red Prowess (R)
#16 Oderus Urungus: Living End (BRG)
#17 caronte1991: Mono Red Prowess (R)
#18 joker10289: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_23 : EventTest
    {
        [Test]
        public void Deck01_Cherryxman_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_cronman87_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck03_Kazuga_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Bayesta93_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_McWinSauce_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Mogged_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck07_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck08_SebastianStueckl_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_shadowPT_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_jessysamek_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck12_mitchrules25_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck13_bntrusty14_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck14_BReal2_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_urzatheplaneswalker_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck16_OderusUrungus_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck17_caronte1991_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck18_joker10289_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-23",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
