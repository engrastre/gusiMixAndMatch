using System;
namespace gusiMixAndMatchSystem;
class Program {
    static void Main(string[] args)
    {
        var ListOfMain = new List<string>() { "BURGER", "SPAGHETTI", "CHICKEN" };
        var ListOfSide = new List<string>() { "FRIES", "BEVERAGE" };
        var mainBurgers = new List<string>() { "CLASSIC CHEESEBURGER", "BACON CHEESE", "MUSHROOM SWISS BURGER", "BARBECUE BURGER", "VEGGIE BURGER", "HAWAIIAN BURGER" };
        var mainSpaghetti = new List<string>() { "CLASSIC SPAGHETTI", "SPAGHETTI ALLA CARBONARA"};
        var mainChicken = new List<string>() { "FRIED CHICKEN SAANDWITCH", "CHICKEN AND RICE", "CHICKEN AND WAFFLES", "NUGGETS" };
        var sideFries = new List<string>() { "SWEET POTATO FRIES", "CHEESE FRIES", "GARLIC FRIES", "CHILI CHEESE FRIES", "REGULAR FRIES" };
        var sideBeverage = new List<string>() { "COFFEE", "SODA", "JUICE", "SMOOTHIE", "ICE CREAM" };
        var flavors = new List<string>() { "VANILLA", " ROCKY ROAD", "CHOCOLATE", "COOKIES AND CREAM", "DARK CHOCOLATE", "SALTED CARAMEL", "HAZELNUT" };
        var soda = new List<string>() { "COCA-COLA", "SPRITE", "ROYAL", "PEPSI", "7UP", "MOUNTAIN DEW", "ROOT BEER" };
        var juice = new List<string>() { "APPLE", "ORANGE", "CRANBERRY", "LEMONADE", "PINEAPPLE", "GRAPE", "TOMATO", "MANGO", "POMEGRANATE", };
        var smoothie = new List<string>() { "MIXED BERRY SMOOTHIE", "MANGI LASSI", "CHOCOLATE AVOCADO SMOOTHIE", "GREEN SMOOTHIE" };
        var sizes = new List<string>() { "Regular", "Double Scoop", "Short" };
        int number = 1;
        string combo = "Conratulations! Your Gucci Gangs combo are ";
        bool proceed = true;
        // this is where my program flow starts :)
        menu();
        while (proceed)
        {
            select();
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                mainmenu(ListOfMain, number);
                int main = Convert.ToInt32(Console.ReadLine());
                if (main == 1)
                {
                    mainBurger(mainBurgers, number);
                    int burger = Convert.ToInt32(Console.ReadLine());
                    if (burger == 1)
                    {
                        Console.WriteLine("\nYour main burger is " + mainBurgers[0]);
                        sidePart(ListOfSide, number);
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side == 1)
                        {
                            sidefries(sideFries, number);
                            int fries = Convert.ToInt32(Console.ReadLine());
                            if (fries == 1)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[0] + " and " + sideFries[1]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 2)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[0] + " and " + sideFries[2]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 3)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[0] + " and " + sideFries[3]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 4)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[0] + " and " + sideFries[4]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 5)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[0] + " and " + sideFries[5]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                        }
                        else if (side == 2)
                        {
                            beverage(sideBeverage, number);
                            int beverageType = Convert.ToInt32(Console.ReadLine());
                            if (beverageType == 1)
                            {
                                coffee(flavors, sizes, number);
                                int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                if (coffeeFlavor == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[0] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[1] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[2] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[3] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[4] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[5] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[6] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 2)
                            {
                                sodas(soda, sizes, number);
                                int sodaType = Convert.ToInt32(Console.ReadLine());
                                if (sodaType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + soda[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + soda[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + soda[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + soda[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + soda[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + soda[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + soda[6]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 3)
                            {
                                juices(juice, sizes, number);
                                int juiceType = Convert.ToInt32(Console.ReadLine());
                                if (juiceType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + juice[0] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + juice[1] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + juice[2] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + juice[3] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + juice[4] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + juice[5] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + juice[6] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 8)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + juice[7] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 9)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + juice[8] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 4)
                            {
                                smoothies(smoothie, sizes, number);
                                int smoothieType = Convert.ToInt32(Console.ReadLine());
                                if (smoothieType == 1)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + smoothie[0]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 2)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + smoothie[1]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 3)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + smoothie[2]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 4)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + smoothie[3]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 5)
                            {
                                icecream(flavors, sizes, number);
                                int icecreamType = Convert.ToInt32(Console.ReadLine());
                                if (icecreamType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                            }
                        }
                    }
                    else if (burger == 2)
                    {
                        Console.WriteLine("\nYour main burger is " + mainBurgers[1]);
                        sidePart(ListOfSide, number);
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side == 1)
                        {
                            sidefries(sideFries, number);
                            int fries = Convert.ToInt32(Console.ReadLine());
                            if (fries == 1)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[1] + " and " + sideFries[1]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 2)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[1] + " and " + sideFries[2]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 3)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[1] + " and " + sideFries[3]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 4)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[1] + " and " + sideFries[4]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 5)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[1] + " and " + sideFries[5]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                        }
                        else if (side == 2)
                        {
                            beverage(sideBeverage, number);
                            int beverageType = Convert.ToInt32(Console.ReadLine());
                            if (beverageType == 1)
                            {
                                coffee(flavors, sizes, number);
                                int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                if (coffeeFlavor == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[0] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[1] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[2] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[3] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[4] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[5] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[6] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 2)
                            {
                                sodas(soda, sizes, number);
                                int sodaType = Convert.ToInt32(Console.ReadLine());
                                if (sodaType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + soda[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + soda[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + soda[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + soda[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + soda[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + soda[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + soda[6]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 3)
                            {
                                juices(juice, sizes, number);
                                int juiceType = Convert.ToInt32(Console.ReadLine());
                                if (juiceType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + juice[0] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + juice[1] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + juice[2] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + juice[3] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + juice[4] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + juice[5] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + juice[6] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 8)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + juice[7] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 9)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + juice[8] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 4)
                            {
                                smoothies(smoothie, sizes, number);
                                int smoothieType = Convert.ToInt32(Console.ReadLine());
                                if (smoothieType == 1)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + smoothie[0]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 2)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + smoothie[1]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 3)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + smoothie[2]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 4)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + smoothie[3]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 5)
                            {
                                icecream(flavors, sizes, number);
                                int icecreamType = Convert.ToInt32(Console.ReadLine());
                                if (icecreamType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                            }
                        }

                    }
                    else if (burger == 3)
                    {
                        Console.WriteLine("\nYour main burger is " + mainBurgers[0]);
                        sidePart(ListOfSide, number);
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side == 1)
                        {
                            sidefries(sideFries, number);
                            int fries = Convert.ToInt32(Console.ReadLine());
                            if (fries == 1)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[2] + " and " + sideFries[1]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 2)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[2] + " and " + sideFries[2]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 3)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[2] + " and " + sideFries[3]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 4)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[2] + " and " + sideFries[4]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 5)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[2] + " and " + sideFries[5]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                        }
                        else if (side == 2)
                        {
                            beverage(sideBeverage, number);
                            int beverageType = Convert.ToInt32(Console.ReadLine());
                            if (beverageType == 1)
                            {
                                coffee(flavors, sizes, number);
                                int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                if (coffeeFlavor == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[0] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[1] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[2] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[3] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[4] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[5] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[6] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 2)
                            {
                                sodas(soda, sizes, number);
                                int sodaType = Convert.ToInt32(Console.ReadLine());
                                if (sodaType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + soda[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + soda[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + soda[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + soda[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + soda[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + soda[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + soda[6]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 3)
                            {
                                juices(juice, sizes, number);
                                int juiceType = Convert.ToInt32(Console.ReadLine());
                                if (juiceType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + juice[0] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + juice[1] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + juice[2] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + juice[3] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + juice[4] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + juice[5] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 7)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + juice[6] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 8)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + juice[7] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 9)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + juice[8] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 4)
                            {
                                smoothies(smoothie, sizes, number);
                                int smoothieType = Convert.ToInt32(Console.ReadLine());
                                if (smoothieType == 1)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + smoothie[0]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 2)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + smoothie[1]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 3)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + smoothie[2]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 4)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + smoothie[3]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 5)
                            {
                                icecream(flavors, sizes, number);
                                int icecreamType = Convert.ToInt32(Console.ReadLine());
                                if (icecreamType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                            }
                        }
                        if (burger == 4)
                        {
                            Console.WriteLine("\nYour main burger is " + mainBurgers[3]);
                            sidePart(ListOfSide, number);
                            side = Convert.ToInt32(Console.ReadLine());
                            if (side == 1)
                            {
                                sidefries(sideFries, number);
                                int fries = Convert.ToInt32(Console.ReadLine());
                                if (fries == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[3] + " and " + sideFries[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (fries == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[3] + " and " + sideFries[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (fries == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[3] + " and " + sideFries[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (fries == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[3] + " and " + sideFries[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (fries == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[3] + " and " + sideFries[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (side == 2)
                            {
                                beverage(sideBeverage, number);
                                int beverageType = Convert.ToInt32(Console.ReadLine());
                                if (beverageType == 1)
                                {
                                    coffee(flavors, sizes, number);
                                    int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                    if (coffeeFlavor == 1)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[0] + " " + sideBeverage[0]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (coffeeFlavor == 2)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[1] + " " + sideBeverage[0]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (coffeeFlavor == 3)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[2] + " " + sideBeverage[0]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (coffeeFlavor == 4)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[3] + " " + sideBeverage[0]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (coffeeFlavor == 5)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[4] + " " + sideBeverage[0]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (coffeeFlavor == 6)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[5] + " " + sideBeverage[0]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (coffeeFlavor == 7)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[6] + " " + sideBeverage[0]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                }
                                else if (beverageType == 2)
                                {
                                    sodas(soda, sizes, number);
                                    int sodaType = Convert.ToInt32(Console.ReadLine());
                                    if (sodaType == 1)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + soda[0]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (sodaType == 2)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + soda[1]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (sodaType == 3)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + soda[2]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (sodaType == 4)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + soda[3]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (sodaType == 5)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + soda[4]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (sodaType == 6)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + soda[5]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (sodaType == 7)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + soda[6]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                }
                                else if (beverageType == 3)
                                {
                                    juices(juice, sizes, number);
                                    int juiceType = Convert.ToInt32(Console.ReadLine());
                                    if (juiceType == 1)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + juice[0] + " " + sideBeverage[2]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (juiceType == 2)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + juice[1] + " " + sideBeverage[2]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (juiceType == 3)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + juice[2] + " " + sideBeverage[2]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (juiceType == 4)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + juice[3] + " " + sideBeverage[2]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (juiceType == 5)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + juice[4] + " " + sideBeverage[2]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (juiceType == 6)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + juice[5] + " " + sideBeverage[2]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (juiceType == 7)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + juice[6] + " " + sideBeverage[2]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (juiceType == 8)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + juice[7] + " " + sideBeverage[2]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                    else if (juiceType == 9)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + juice[8] + " " + sideBeverage[2]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    }
                                }
                                else if (beverageType == 4)
                                {
                                    smoothies(smoothie, sizes, number);
                                    int smoothieType = Convert.ToInt32(Console.ReadLine());
                                    if (smoothieType == 1)
                                    {
                                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + smoothie[0]);
                                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    }
                                    else if (smoothieType == 2)
                                    {
                                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + smoothie[1]);
                                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    }
                                    else if (smoothieType == 3)
                                    {
                                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + smoothie[2]);
                                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    }
                                    else if (smoothieType == 4)
                                    {
                                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + smoothie[3]);
                                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    }
                                }
                                else if (beverageType == 5)
                                {
                                    icecream(flavors, sizes, number);
                                    int icecreamType = Convert.ToInt32(Console.ReadLine());
                                    if (icecreamType == 1)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    }
                                    else if (icecreamType == 2)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    }
                                    else if (icecreamType == 3)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    }
                                    else if (icecreamType == 4)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    }
                                    else if (icecreamType == 5)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    }
                                    else if (icecreamType == 6)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    }
                                    else if (icecreamType == 7)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                        Console.WriteLine(combo + mainBurgers[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    }
                                }
                            }

                        }
                    }
                    else if (burger == 5)
                    {
                        Console.WriteLine("\nYour main burger is " + mainBurgers[4]);
                        sidePart(ListOfSide, number);
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side == 1)
                        {
                            sidefries(sideFries, number);
                            int fries = Convert.ToInt32(Console.ReadLine());
                            if (fries == 1)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[4] + " and " + sideFries[1]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 2)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[4] + " and " + sideFries[2]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 3)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[4] + " and " + sideFries[3]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 4)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[4] + " and " + sideFries[4]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 5)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[4] + " and " + sideFries[5]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                        }
                        else if (side == 2)
                        {
                            beverage(sideBeverage, number);
                            int beverageType = Convert.ToInt32(Console.ReadLine());
                            if (beverageType == 1)
                            {
                                coffee(flavors, sizes, number);
                                int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                if (coffeeFlavor == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[0] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[1] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[2] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[3] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[4] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[5] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[6] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 2)
                            {
                                sodas(soda, sizes, number);
                                int sodaType = Convert.ToInt32(Console.ReadLine());
                                if (sodaType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + soda[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + soda[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + soda[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + soda[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + soda[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + soda[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + soda[6]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 3)
                            {
                                juices(juice, sizes, number);
                                int juiceType = Convert.ToInt32(Console.ReadLine());
                                if (juiceType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + juice[0] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + juice[1] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + juice[2] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + juice[3] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + juice[4] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + juice[5] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + juice[6] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 8)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + juice[7] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 9)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + juice[8] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 4)
                            {
                                smoothies(smoothie, sizes, number);
                                int smoothieType = Convert.ToInt32(Console.ReadLine());
                                if (smoothieType == 1)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + smoothie[0]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 2)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + smoothie[1]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 3)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + smoothie[2]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 4)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + smoothie[3]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 5)
                            {
                                icecream(flavors, sizes, number);
                                int icecreamType = Convert.ToInt32(Console.ReadLine());
                                if (icecreamType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[4] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                            }
                        }

                    }
                    if (burger == 6)
                    {
                        Console.WriteLine("\nYour main burger is " + mainBurgers[5]);
                        sidePart(ListOfSide, number);
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side == 1)
                        {
                            sidefries(sideFries, number);
                            int fries = Convert.ToInt32(Console.ReadLine());
                            if (fries == 1)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[5] + " and " + sideFries[1]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 2)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[5] + " and " + sideFries[2]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 3)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[5] + " and " + sideFries[3]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 4)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[5] + " and " + sideFries[4]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 5)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainBurgers[5] + " and " + sideFries[5]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                        }
                        else if (side == 2)
                        {
                            beverage(sideBeverage, number);
                            int beverageType = Convert.ToInt32(Console.ReadLine());
                            if (beverageType == 1)
                            {
                                coffee(flavors, sizes, number);
                                int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                if (coffeeFlavor == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[0] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[1] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[2] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[3] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[4] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[5] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[6] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 2)
                            {
                                sodas(soda, sizes, number);
                                int sodaType = Convert.ToInt32(Console.ReadLine());
                                if (sodaType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + soda[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + soda[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + soda[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + soda[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + soda[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + soda[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + soda[6]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 3)
                            {
                                juices(juice, sizes, number);
                                int juiceType = Convert.ToInt32(Console.ReadLine());
                                if (juiceType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + juice[0] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + juice[1] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + juice[2] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + juice[3] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + juice[4] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + juice[5] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + juice[6] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 8)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + juice[7] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 9)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + juice[8] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 4)
                            {
                                smoothies(smoothie, sizes, number);
                                int smoothieType = Convert.ToInt32(Console.ReadLine());
                                if (smoothieType == 1)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + smoothie[0]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 2)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + smoothie[1]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 3)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + smoothie[2]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 4)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + smoothie[3]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 5)
                            {
                                icecream(flavors, sizes, number);
                                int icecreamType = Convert.ToInt32(Console.ReadLine());
                                if (icecreamType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainBurgers[5] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                            }
                        }

                    }
                }
                else if (main == 2)
                {
                    mainSpaghettis(mainSpaghetti, number);
                    int spaghetti = Convert.ToInt32(Console.ReadLine());
                    if (spaghetti == 1)
                    {
                        Console.WriteLine("\nYour main spaghetti is " + mainSpaghetti[0]);
                        sidePart(ListOfSide, number);
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side == 1)
                        {
                            sidefries(sideFries, number);
                            int fries = Convert.ToInt32(Console.ReadLine());
                            if (fries == 1)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainSpaghetti[0] + " and " + sideFries[1]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 2)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainSpaghetti[0] + " and " + sideFries[2]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 3)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainSpaghetti[0] + " and " + sideFries[3]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 4)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainSpaghetti[0] + " and " + sideFries[4]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 5)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainSpaghetti[0] + " and " + sideFries[5]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                        }
                        else if (side == 2)
                        {
                            beverage(sideBeverage, number);
                            int beverageType = Convert.ToInt32(Console.ReadLine());
                            if (beverageType == 1)
                            {
                                coffee(flavors, sizes, number);
                                int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                if (coffeeFlavor == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[0] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[1] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[2] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[3] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[4] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[5] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[6] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 2)
                            {
                                sodas(soda, sizes, number);
                                int sodaType = Convert.ToInt32(Console.ReadLine());
                                if (sodaType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + soda[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + soda[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + soda[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + soda[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + soda[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + soda[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + soda[6]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 3)
                            {
                                juices(juice, sizes, number);
                                int juiceType = Convert.ToInt32(Console.ReadLine());
                                if (juiceType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + juice[0] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + juice[1] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + juice[2] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + juice[3] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + juice[4] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + juice[5] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + juice[6] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 8)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + juice[7] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 9)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + juice[8] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 4)
                            {
                                smoothies(smoothie, sizes, number);
                                int smoothieType = Convert.ToInt32(Console.ReadLine());
                                if (smoothieType == 1)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + smoothie[0]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 2)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + smoothie[1]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 3)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + smoothie[2]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 4)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + smoothie[3]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 5)
                            {
                                icecream(flavors, sizes, number);
                                int icecreamType = Convert.ToInt32(Console.ReadLine());
                                if (icecreamType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                            }
                        }
                    }
                    else if (spaghetti == 2)
                    {
                        Console.WriteLine("\nYour main spaghetti is " + mainSpaghetti[1]);
                        sidePart(ListOfSide, number);
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side == 1)
                        {
                            sidefries(sideFries, number);
                            int fries = Convert.ToInt32(Console.ReadLine());
                            if (fries == 1)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainSpaghetti[1] + " and " + sideFries[1]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 2)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainSpaghetti[1] + " and " + sideFries[2]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 3)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainSpaghetti[1] + " and " + sideFries[3]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 4)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainSpaghetti[1] + " and " + sideFries[4]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 5)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainSpaghetti[1] + " and " + sideFries[5]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                        }
                        else if (side == 2)
                        {
                            beverage(sideBeverage, number);
                            int beverageType = Convert.ToInt32(Console.ReadLine());
                            if (beverageType == 1)
                            {
                                coffee(flavors, sizes, number);
                                int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                if (coffeeFlavor == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[0] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[1] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[2] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[3] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[4] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[5] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[6] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 2)
                            {
                                sodas(soda, sizes, number);
                                int sodaType = Convert.ToInt32(Console.ReadLine());
                                if (sodaType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + soda[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + soda[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + soda[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + soda[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + soda[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + soda[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + soda[6]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 3)
                            {
                                juices(juice, sizes, number);
                                int juiceType = Convert.ToInt32(Console.ReadLine());
                                if (juiceType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + juice[0] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + juice[1] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + juice[2] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + juice[3] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + juice[4] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + juice[5] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + juice[6] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 8)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + juice[7] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 9)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + juice[8] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 4)
                            {
                                smoothies(smoothie, sizes, number);
                                int smoothieType = Convert.ToInt32(Console.ReadLine());
                                if (smoothieType == 1)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + smoothie[0]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 2)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + smoothie[1]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 3)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + smoothie[2]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 4)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + smoothie[3]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 5)
                            {
                                icecream(flavors, sizes, number);
                                int icecreamType = Convert.ToInt32(Console.ReadLine());
                                if (icecreamType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainSpaghetti[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                            }
                        }

                    }
                }
                //chicken sec:
                else if (main == 3)
                {
                    mainChickens(mainChicken, number);
                    int chicken = Convert.ToInt32(Console.ReadLine());
                    if (chicken == 1)
                    {
                        Console.WriteLine("\nYour main chicken is " + mainChicken[0]);
                        sidePart(ListOfSide, number);
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side == 1)
                        {
                            sidefries(sideFries, number);
                            int fries = Convert.ToInt32(Console.ReadLine());
                            if (fries == 1)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[0] + " and " + sideFries[1]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 2)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[0] + " and " + sideFries[2]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 3)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[0] + " and " + sideFries[3]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 4)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[0] + " and " + sideFries[4]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 5)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[0] + " and " + sideFries[5]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                        }
                        else if (side == 2)
                        {
                            beverage(sideBeverage, number);
                            int beverageType = Convert.ToInt32(Console.ReadLine());
                            if (beverageType == 1)
                            {
                                coffee(flavors, sizes, number);
                                int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                if (coffeeFlavor == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[0] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[1] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[2] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[3] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[4] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[5] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[6] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 2)
                            {
                                sodas(soda, sizes, number);
                                int sodaType = Convert.ToInt32(Console.ReadLine());
                                if (sodaType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + soda[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + soda[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + soda[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + soda[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + soda[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + soda[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + soda[6]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 3)
                            {
                                juices(juice, sizes, number);
                                int juiceType = Convert.ToInt32(Console.ReadLine());
                                if (juiceType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + juice[0] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + juice[1] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + juice[2] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + juice[3] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + juice[4] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + juice[5] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + juice[6] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 8)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + juice[7] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 9)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + juice[8] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 4)
                            {
                                smoothies(smoothie, sizes, number);
                                int smoothieType = Convert.ToInt32(Console.ReadLine());
                                if (smoothieType == 1)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + smoothie[0]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 2)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + smoothie[1]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 3)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + smoothie[2]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 4)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + smoothie[3]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 5)
                            {
                                icecream(flavors, sizes, number);
                                int icecreamType = Convert.ToInt32(Console.ReadLine());
                                if (icecreamType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[0] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                            }
                        }
                    }
                    else if (chicken == 2)
                    {
                        Console.WriteLine("\nYour main chicken is " + mainChicken[1]);
                        sidePart(ListOfSide, number);
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side == 1)
                        {
                            sidefries(sideFries, number);
                            int fries = Convert.ToInt32(Console.ReadLine());
                            if (fries == 1)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[1] + " and " + sideFries[1]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 2)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[1] + " and " + sideFries[2]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 3)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[1] + " and " + sideFries[3]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 4)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[1] + " and " + sideFries[4]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 5)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[1] + " and " + sideFries[5]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                        }
                        else if (side == 2)
                        {
                            beverage(sideBeverage, number);
                            int beverageType = Convert.ToInt32(Console.ReadLine());
                            if (beverageType == 1)
                            {
                                coffee(flavors, sizes, number);
                                int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                if (coffeeFlavor == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[0] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[1] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[2] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[3] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[4] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[5] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[6] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 2)
                            {
                                sodas(soda, sizes, number);
                                int sodaType = Convert.ToInt32(Console.ReadLine());
                                if (sodaType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + soda[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + soda[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + soda[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + soda[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + soda[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + soda[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + soda[6]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 3)
                            {
                                juices(juice, sizes, number);
                                int juiceType = Convert.ToInt32(Console.ReadLine());
                                if (juiceType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + juice[0] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + juice[1] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + juice[2] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + juice[3] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + juice[4] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + juice[5] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + juice[6] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 8)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + juice[7] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 9)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + juice[8] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 4)
                            {
                                smoothies(smoothie, sizes, number);
                                int smoothieType = Convert.ToInt32(Console.ReadLine());
                                if (smoothieType == 1)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + smoothie[0]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 2)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + smoothie[1]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 3)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + smoothie[2]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 4)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + smoothie[3]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 5)
                            {
                                icecream(flavors, sizes, number);
                                int icecreamType = Convert.ToInt32(Console.ReadLine());
                                if (icecreamType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[1] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                            }
                        }
                    }
                    else if (chicken == 3)
                    {
                        Console.WriteLine("\nYour main chicken is " + mainChicken[2]);
                        sidePart(ListOfSide, number);
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side == 1)
                        {
                            sidefries(sideFries, number);
                            int fries = Convert.ToInt32(Console.ReadLine());
                            if (fries == 1)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[2] + " and " + sideFries[1]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 2)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[2] + " and " + sideFries[2]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 3)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[2] + " and " + sideFries[3]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 4)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[2] + " and " + sideFries[4]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 5)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[2] + " and " + sideFries[5]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                        }
                        else if (side == 2)
                        {
                            beverage(sideBeverage, number);
                            int beverageType = Convert.ToInt32(Console.ReadLine());
                            if (beverageType == 1)
                            {
                                coffee(flavors, sizes, number);
                                int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                if (coffeeFlavor == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[0] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[1] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[2] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[3] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[4] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[5] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[6] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 2)
                            {
                                sodas(soda, sizes, number);
                                int sodaType = Convert.ToInt32(Console.ReadLine());
                                if (sodaType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + soda[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + soda[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + soda[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + soda[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + soda[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + soda[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + soda[6]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 3)
                            {
                                juices(juice, sizes, number);
                                int juiceType = Convert.ToInt32(Console.ReadLine());
                                if (juiceType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + juice[0] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + juice[1] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + juice[2] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + juice[3] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + juice[4] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + juice[5] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + juice[6] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 8)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + juice[7] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 9)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + juice[8] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 4)
                            {
                                smoothies(smoothie, sizes, number);
                                int smoothieType = Convert.ToInt32(Console.ReadLine());
                                if (smoothieType == 1)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + smoothie[0]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 2)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + smoothie[1]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 3)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + smoothie[2]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 4)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + smoothie[3]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 5)
                            {
                                icecream(flavors, sizes, number);
                                int icecreamType = Convert.ToInt32(Console.ReadLine());
                                if (icecreamType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[2] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                            }
                        }
                    }
                    else if (chicken == 4)
                    {
                        Console.WriteLine("\nYour main chicken is " + mainChicken[3]);
                        sidePart(ListOfSide, number);
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side == 1)
                        {
                            sidefries(sideFries, number);
                            int fries = Convert.ToInt32(Console.ReadLine());
                            if (fries == 1)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[3] + " and " + sideFries[1]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 2)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[3] + " and " + sideFries[2]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 3)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[3] + " and " + sideFries[3]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 4)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[3] + " and " + sideFries[4]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                            else if (fries == 5)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                                Console.WriteLine(combo + mainChicken[3] + " and " + sideFries[5]);
                                Console.WriteLine("-----------------------------------------------------------------------------------------");
                            }
                        }
                        else if (side == 2)
                        {
                            beverage(sideBeverage, number);
                            int beverageType = Convert.ToInt32(Console.ReadLine());
                            if (beverageType == 1)
                            {
                                coffee(flavors, sizes, number);
                                int coffeeFlavor = Convert.ToInt32(Console.ReadLine());
                                if (coffeeFlavor == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[0] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[1] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[2] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[3] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[4] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[5] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (coffeeFlavor == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[6] + " " + sideBeverage[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 2)
                            {
                                sodas(soda, sizes, number);
                                int sodaType = Convert.ToInt32(Console.ReadLine());
                                if (sodaType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + soda[0]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + soda[1]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + soda[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + soda[3]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + soda[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + soda[5]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (sodaType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + soda[6]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 3)
                            {
                                juices(juice, sizes, number);
                                int juiceType = Convert.ToInt32(Console.ReadLine());
                                if (juiceType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + juice[0] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + juice[1] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + juice[2] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + juice[3] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + juice[4] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + juice[5] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + juice[6] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 8)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + juice[7] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                                else if (juiceType == 9)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + juice[8] + " " + sideBeverage[2]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 4)
                            {
                                smoothies(smoothie, sizes, number);
                                int smoothieType = Convert.ToInt32(Console.ReadLine());
                                if (smoothieType == 1)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + smoothie[0]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 2)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + smoothie[1]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 3)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + smoothie[2]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                                else if (smoothieType == 4)
                                {
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + smoothie[3]);
                                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                                }
                            }
                            else if (beverageType == 5)
                            {
                                icecream(flavors, sizes, number);
                                int icecreamType = Convert.ToInt32(Console.ReadLine());
                                if (icecreamType == 1)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 2)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 3)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 4)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 5)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 6)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                                else if (icecreamType == 7)
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                    Console.WriteLine(combo + mainChicken[3] + " and " + flavors[3] + " " + sideBeverage[4]);
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                }
                            }
                        }
                    }

                }
            }
        }
    }
        static void menu()
        {
            Console.WriteLine("**************************-WELCOME TO GUCCIGANGS MIX AND MATCH-**************************");

            Console.WriteLine();
            Console.WriteLine("                             GUCCIGANG'S MIX AND MATCH!");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Step 1: CHOOSE YOUR MAIN");
            Console.WriteLine();
            Console.WriteLine("                      BURGER              SPAGHETTI                 CHICKEN");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Step 2: CHOOSE YOUR SIDE");
            Console.WriteLine();
            Console.WriteLine("                      FRIES               ICE CREAM                 BEVERAGE  ");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }
        static void select()
        {
            Console.Write("Press 1 to create your order: ");
        }
        static void mainmenu(List<string> ListOfMain, int number)
        {
            Console.WriteLine("\nStep 1: CHOOSE YOUR MAIN");
            foreach (string main in ListOfMain)
            {
                Console.WriteLine(number + ". " + main);
                number++;
            }
            Console.Write("Select your main: ");
        }
        static void mainBurger(List<string> mainBurgers, int number)
        {

            Console.WriteLine("\nWhat kind of burger do you like?");
            foreach (string burger in mainBurgers)
            {
                Console.WriteLine(number + ". " + burger);
                number++;
            }
            Console.Write("Select your burger: ");
        }
    static void mainSpaghettis(List<string> mainSpaghetti, int number)
    {

        Console.WriteLine("\nWhat kind of spaghetti do you like?");
        foreach (string spaghetti in mainSpaghetti)
        {
            Console.WriteLine(number + ". " + spaghetti);
            number++;
        }
        Console.Write("Select your spaghetti: ");
    }
    static void mainChickens(List<string> mainChicken, int number)
    {

        Console.WriteLine("\nWhat kind of chicken do you like?");
        foreach (string chicken in mainChicken)
        {
            Console.WriteLine(number + ". " + chicken);
            number++;
        }
        Console.Write("Select your chicken: ");
    }
    static void sidePart(List<string> ListOfSide, int number)
        {
            Console.WriteLine("\nStep 2: CHOOSE YOUR SIDE");
            foreach (string side in ListOfSide)
            {
                Console.WriteLine(number + ". " + side);
                number++;
            }
            Console.Write("Select your side: ");
        }


        static void sidefries(List<string> sideFries, int number)
        {

            Console.WriteLine("\nWhat kind of fries do you like?");
            foreach (string fries in sideFries)
            {
                Console.WriteLine(number + ". " + fries);
                number++;
            }
            Console.Write("Select your fries: ");
        }
        static void beverage(List<string> sideBeverage, int number)
        {
            Console.WriteLine("\nChoose the type of beverage that you want.");
            foreach (string beverage in sideBeverage)
            {
                Console.WriteLine(number + ". " + beverage);
                number++;
            }
            Console.Write("Select your beverage: ");
        }
        static void coffee(List<string> flavors, List<string> sizes,int number)
        {
            Console.WriteLine("\nThe only available size for coffee is "+ sizes[2]);
            Console.WriteLine("What is the flavor of your coffee?");
            foreach (string flavor in flavors)
            {
                Console.WriteLine(number + ". " + flavor);
                number++;
            }
            Console.Write("Select flavor: ");
        }
        static void sodas(List<string> soda, List<string> sizes, int number)
        {
            Console.WriteLine("\nThe only available size for soda is " + sizes[0]);
            Console.WriteLine("What is the flavor of your coffee?");
            foreach (string sodaType in soda)
            {
                Console.WriteLine(number + ". " + sodaType);
                number++;
            }
            Console.Write("Select flavor: ");
        }
        static void juices(List<string> juice, List<string> sizes, int number)
        {
            Console.WriteLine("\nThe only available size for juice is " + sizes[0]);
            Console.WriteLine("What kind of juice do you like?");
            foreach (string juiceType in juice)
            {
                Console.WriteLine(number + ". " + juiceType);
                number++;
            }
            Console.Write("Select your juice: ");
        }
        static void smoothies(List<string> smothie, List<string> sizes, int number)
        {
            Console.WriteLine("\nThe only available size for smoothie is " + sizes[0]);
            Console.WriteLine("What kind of juice do you like?");
            foreach (string smoothieType in smothie)
            {
                Console.WriteLine(number + ". " + smoothieType);
                number++;
            }
            Console.Write("Select your smoothie: ");
        }
        static void icecream(List<string> flavors, List<string> sizes, int number)
        {
            Console.WriteLine("\nThe only available size for ice cream is is " + sizes[1]);
            Console.WriteLine("What kind of ice cream do you like?");
            foreach (string flavor in flavors)
            {
                Console.WriteLine(number + ". " + flavor);
            number++;
            }
            Console.Write("Select your ice cream: ");
        }
    }
