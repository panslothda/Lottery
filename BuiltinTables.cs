using Terraria.ID;

namespace Lottery {
    class BuiltinTables {
        // Built-in tables generation
        public static PrizeNode[] BuildEasymode () {
            PrizeNode moneyPrizes = new PrizeNode (0.40);
            moneyPrizes.AddChildren(new Prize (0.60, ItemID.CopperCoin, 1, 99),
                                    new Prize (0.35, ItemID.SilverCoin, 1, 50),
                                    new Prize (0.05, ItemID.GoldCoin, 1, 3));

            PrizeNode cratePrizes = new PrizeNode (0.25);
            cratePrizes.AddChildren(new Prize (0.50, ItemID.WoodenCrate, 1),
                                    new Prize (0.30, ItemID.IronCrate, 1),
                                    new Prize (0.20, ItemID.GoldenCrate, 1));

            PrizeNode orePrizes = new PrizeNode (0.16);
            orePrizes.AddChildren(new Prize (0.1, ItemID.TinOre, 1, 10),
                                  new Prize (0.1, ItemID.CopperOre, 1, 10),
                                  new Prize (0.1, ItemID.TungstenOre, 1, 10),
                                  new Prize (0.1, ItemID.SilverOre, 1, 10),
                                  new Prize (0.1, ItemID.GoldOre, 1, 10),
                                  new Prize (0.1, ItemID.PlatinumOre, 1, 10),
                                  new Prize (0.1, ItemID.DemoniteOre, 1, 10),
                                  new Prize (0.1, ItemID.CrimtaneOre, 1, 10));
            PrizeNode gemPrizes = new PrizeNode (0.2);
            gemPrizes.AddChildren(new Prize (0.17, ItemID.Emerald, 1, 7),
                                  new Prize (0.17, ItemID.Amethyst, 1, 7),
                                  new Prize (0.16, ItemID.Sapphire, 1, 7),
                                  new Prize (0.16, ItemID.Topaz, 1, 7),
                                  new Prize (0.14, ItemID.Diamond, 1, 7),
                                  new Prize (0.14, ItemID.Ruby, 1, 7),
                                  new Prize (0.04, ItemID.Amber, 1, 7));
            orePrizes.AddChildren(gemPrizes);

            PrizeNode ammoPrizes = new PrizeNode (0.16);
            ammoPrizes.AddChildren(new Prize (0.4, ItemID.MusketBall, 50),
                                   new Prize (0.4, ItemID.WoodenArrow, 50),
                                   new Prize (0.2, ItemID.RocketI, 5));

            PrizeNode junkPrizes = new PrizeNode (0.03);
            junkPrizes.AddChildren(new Prize (1.00, ItemID.FishingSeaweed, 1, 3));

            return new PrizeNode[] {moneyPrizes, cratePrizes, orePrizes, ammoPrizes, junkPrizes};
        }

        public static PrizeNode[] BuildHardmode () {
            PrizeNode moneyPrizes = new PrizeNode (0.40);
            moneyPrizes.AddChildren(new Prize (0.30, ItemID.SilverCoin, 1, 99),
                                    new Prize (0.55, ItemID.GoldCoin, 1, 99),
                                    new Prize (0.15, ItemID.PlatinumCoin, 1, 5));

            PrizeNode cratePrizes = new PrizeNode (0.25);
            cratePrizes.AddChildren(new Prize (0.20, ItemID.WoodenCrate, 1, 5),
                                    new Prize (0.45, ItemID.IronCrate, 1, 3),
                                    new Prize (0.35, ItemID.GoldenCrate, 1));

            PrizeNode orePrizes = new PrizeNode (0.16);
            orePrizes.AddChildren(new Prize (0.1, ItemID.TinOre, 7, 20),
                                  new Prize (0.1, ItemID.CopperOre, 7, 20),
                                  new Prize (0.1, ItemID.TungstenOre, 7, 20),
                                  new Prize (0.1, ItemID.SilverOre, 7, 20),
                                  new Prize (0.1, ItemID.GoldOre, 7, 20),
                                  new Prize (0.1, ItemID.PlatinumOre, 7, 20),
                                  new Prize (0.1, ItemID.DemoniteOre, 7, 20),
                                  new Prize (0.1, ItemID.CrimtaneOre, 7, 20));
            PrizeNode gemPrizes = new PrizeNode (0.2);
            gemPrizes.AddChildren(new Prize (0.17, ItemID.Emerald, 5, 15),
                                  new Prize (0.17, ItemID.Amethyst, 5, 15),
                                  new Prize (0.16, ItemID.Sapphire, 5, 15),
                                  new Prize (0.16, ItemID.Topaz, 5, 15),
                                  new Prize (0.14, ItemID.Diamond, 5, 15),
                                  new Prize (0.14, ItemID.Ruby, 5, 15),
                                  new Prize (0.04, ItemID.Amber, 5, 15));
            orePrizes.AddChildren(gemPrizes);

            PrizeNode ammoPrizes = new PrizeNode (0.16);
            ammoPrizes.AddChildren(new Prize (0.4, ItemID.MusketBall, 100),
                                   new Prize (0.4, ItemID.WoodenArrow, 100),
                                   new Prize (0.2, ItemID.RocketI, 25));

            PrizeNode junkPrizes = new PrizeNode (0.03);
            junkPrizes.AddChildren(new Prize (1.00, ItemID.FishingSeaweed, 1, 3));

            return new PrizeNode[] {moneyPrizes, cratePrizes, orePrizes, ammoPrizes, junkPrizes};
        }
    }
}
