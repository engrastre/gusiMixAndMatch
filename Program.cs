using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace guccigangsMixandMatch
{
    class Program
    {
        static void Main(String[] args)
        {


            int choose, main, burger, spaghetti, chicken, side, typeOfside, friesSize, iceCreamsize, pay,
            bill, payment, change, mainPrice = 150, smallFries = 45, mediumFries = 55, largeFries = 65, smallIcecream = 35, mediumIcecream = 40, largeIcecream = 45, chocoFloatPrice = 55, cokeFloatPrice = 60, icedTeaPrice = 40, icedCoffeePrice = 50, cokePrice = 25, pineAppleJuicePrice = 25;
            string mainBurger1 = "DOUBLE PATTY BURGER", mainBurger2 = "DOUBLE CHICKEN BURGER", mainBurger3 = "VEGGIE BURGER", mainBurger4 = "ROYALE BURGER",
                  sideFries = "GUCCIFRIES", sideIcecream = "ICE CREAM", sideBeverage = "BEVERAGE", copyOfreceipt, mainSpaghetti = "SPAGHETTI ", mainSpaghetti2 = "SPAGHETTI w/ chicken",
                  mainChicken = "CHICKEN w/ 1pc of PATTY BURGER", mainChicken2 = "CHICKEN w/ RICE", sideBeverageChocoFloat = "CHOCO FLOAT", sideBeverageCokeFloat = "CHOKE FLOAT", sideBeverageIcedTea = "ICED TEA", sideBeverageIcedCoffe = "CHOCO FLOAT", sideBeverageCoke = "COKE", sideBeveragePaJuice = "PINEAPPLE JUICE";

            Console.WriteLine(" ***************-WELCOME TO GUCCIGANGS MIX AND MATCH-***************");
            Console.WriteLine();
            Console.WriteLine("                    GUCCIGANG'S MIX AND MATCH!");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Step 1: CHOOSE YOUR MAIN w/a fixed price of 150 pesos only!");
            Console.WriteLine();
            Console.WriteLine("           BURGER              SPAGHETTI                 CHICKEN");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Step 2: CHOOSE YOUR SIDE");
            Console.WriteLine();
            Console.WriteLine("           FRIES               ICE CREAM                 BEVERAGE  ");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("NOTE: MAIN HAS A FIXED PRICE OF 150.00 WHILE THE SIDE HAS PRICE BASED ON ITS TYPE OR SIZE!");
            Console.WriteLine("Press 'ENTER' to create your order.");
            Console.ReadKey();
            bool proceed = true;
            while (proceed)
            {
                Console.WriteLine();
                Console.WriteLine("To make an order press 1 or 0 to exit."); ;
                Console.Write("Enter your choice: ");
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thanks for visiting us! \nWe will wait for you to comeback.");
                }

                else if (choose == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("MAIN HAS A FIXED PRICE OF 150.00");
                    Console.WriteLine("Step 1 choose your MAIN: ");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("  BURGER      SPAGHETTI   CHICKEN");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Press 1 for BURGER");
                    Console.WriteLine("Press 2 for SPAGHETTI");
                    Console.WriteLine("Press 3 for CHICKEN");
                    Console.WriteLine();
                    Console.Write("Select your MAIN: ");
                    main = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (main)
                    {
                        case 1:
                            Console.WriteLine("==================================");

                            Console.WriteLine("   b1 - DOUBLE PATTY BURGER ");
                            Console.WriteLine("   b2 - DOUBLE CHICKEN BURGER");
                            Console.WriteLine("   b3 - VEGGIE BURGER");
                            Console.WriteLine("   b4 - ROYALE BURGER");
                            Console.WriteLine("==================================");
                            Console.WriteLine("Press 1 for b1 ");
                            Console.WriteLine("Press 2 for b2 ");
                            Console.WriteLine("Press 3 for b3 ");
                            Console.WriteLine("Press 4 for b4 ");
                            Console.WriteLine();
                            Console.Write("Choose your burger: ");
                            burger = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (burger == 1)
                            {
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("   Your main is DOUBLE PATTY BURGER");
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine();
                                Console.Write("You are now going to select your Side. \n Press 1 to 'Continue': ");
                                side = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();

                                switch (side)
                                {
                                    case 1:
                                        Console.WriteLine("---------------------------------");
                                        Console.WriteLine("Step 2 choose your SIDE: ");
                                        Console.WriteLine("  FRIES       ICE CREAM   BEVERAGE  ");
                                        Console.WriteLine("---------------------------------");
                                        Console.WriteLine("Press 1 for Fries");
                                        Console.WriteLine("Press 2 for Icream");
                                        Console.WriteLine("Press 3 for BEVERAGE");
                                        Console.WriteLine();
                                        Console.Write("Choose your Side: ");
                                        typeOfside = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine();


                                        if (typeOfside == 1)
                                        {
                                            Console.WriteLine("What is the size of your GUCCIFRIES?");
                                            Console.WriteLine("=======================================");
                                            Console.WriteLine("Size:            Price:");
                                            Console.WriteLine("SMALL            45.00");
                                            Console.WriteLine("MEDIUM           55.00");
                                            Console.WriteLine("LARGE            65.00");
                                            Console.WriteLine("========================================");
                                            Console.WriteLine("Press  1 for small.");
                                            Console.WriteLine("Press  2 for medium.");
                                            Console.WriteLine("Press  3 for large.");
                                            Console.WriteLine();
                                            Console.Write("Select the size of your fries: ");
                                            friesSize = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine();

                                            switch (friesSize)
                                            {
                                                case 1:
                                                    Console.WriteLine("-------------------------------.");
                                                    Console.WriteLine("Your GUCCIFRIES is small.");
                                                    Console.WriteLine("-------------------------------.");
                                                    Console.WriteLine();
                                                    Console.Write("Press 1 to Continue: ");
                                                    pay = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine();

                                                    while (proceed)
                                                    {
                                                        if (pay == 1)
                                                        {
                                                            bill = mainPrice + smallFries;
                                                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                                            Console.WriteLine("Your select " + mainBurger1 + " and small " + sideFries + " with a total of " + bill + ".00 pesos only.");
                                                            Console.WriteLine();
                                                            Console.WriteLine("Enter your payment below.");
                                                            Console.WriteLine("-----------------------");
                                                            Console.Write("PHP: ");
                                                            payment = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("-----------------------");
                                                            change = payment - bill;
                                                            Console.Write("Change: " + change);
                                                            Console.WriteLine();
                                                            Console.WriteLine("Do you want to have a copy of your receipt? (y/n): ");
                                                            copyOfreceipt = Console.ReadLine();
                                                            Console.WriteLine();
                                                            while (proceed)
                                                            {
                                                                if (copyOfreceipt == "n" || copyOfreceipt == "N")
                                                                {
                                                                    Console.WriteLine("Thanks for your order!");

                                                                    Console.WriteLine();
                                                                }

                                                                else if (copyOfreceipt == "y" || copyOfreceipt == "Y")
                                                                {
                                                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                                                    Console.WriteLine("                                 GUCCIGANG MIX AND MATCH      ");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("                                     RECEIPT");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("YOUR GUCCIGANG'S PARTNERS:                              PRICE :");
                                                                    Console.WriteLine("         " + mainBurger1 + "                                    " + mainPrice + ".00");
                                                                    Console.WriteLine("         " + sideFries + "                   small                     " + smallFries + ".00");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("Total                                                        : " + bill + ".00");
                                                                    Console.WriteLine("Payment                                                      : " + payment + ".00");
                                                                    Console.WriteLine("Change                                                       : " + change + ".00");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Thanks! for your order.");
                                                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                                                    Console.WriteLine();
                                                                    break;

                                                                }


                                                                else
                                                                {
                                                                    Console.WriteLine("Thanks for your order!\n We will wait for you to comeback!");
                                                                    Console.WriteLine();
                                                                }
                                                                break;

                                                            }


                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine("Sorry but we cannot cancel your oder.");
                                                            Console.WriteLine("Kindly, Press 1 to finished your payment.");
                                                            pay = Convert.ToInt32(Console.ReadLine());
                                                        }
                                                        break;
                                                    }


                                                    break;
                                                case 2:
                                                    Console.WriteLine("-------------------------------.");
                                                    Console.WriteLine("Your GUCCIFRIES is medium.");
                                                    Console.WriteLine("-------------------------------.");
                                                    Console.WriteLine();
                                                    Console.Write("Press 1 to Continue: ");
                                                    pay = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine();

                                                    while (proceed)
                                                    {
                                                        if (pay == 1)
                                                        {
                                                            bill = mainPrice + mediumFries;
                                                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                                            Console.WriteLine("Your select " + mainBurger1 + " and medium " + sideFries + " with a total of " + bill + ".00 pesos only.");
                                                            Console.WriteLine();
                                                            Console.WriteLine("Enter your payment below.");
                                                            Console.WriteLine("-----------------------");
                                                            Console.Write("PHP: ");
                                                            payment = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("-----------------------");
                                                            change = payment - bill;
                                                            Console.Write("Change: " + change);
                                                            Console.WriteLine();
                                                            Console.WriteLine("Do you want to have a copy of your receipt? (y/n): ");
                                                            copyOfreceipt = Console.ReadLine();
                                                            Console.WriteLine();
                                                            while (proceed)
                                                            {
                                                                if (copyOfreceipt == "n" || copyOfreceipt == "N")
                                                                {
                                                                    Console.WriteLine("Thanks for your order!");

                                                                    Console.WriteLine();
                                                                }

                                                                else if (copyOfreceipt == "y" || copyOfreceipt == "Y")
                                                                {
                                                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                                                    Console.WriteLine("                                 GUCCIGANG MIX AND MATCH      ");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("                                     RECEIPT");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("YOUR GUCCIGANG'S PARTNERS:                              PRICE :");
                                                                    Console.WriteLine("         " + mainBurger1 + "                                    " + mainPrice + ".00");
                                                                    Console.WriteLine("         " + sideFries + "                  medium                     " + mediumFries + ".00");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("Total                                                        : " + bill + ".00");
                                                                    Console.WriteLine("Payment                                                      : " + payment + ".00");
                                                                    Console.WriteLine("Change                                                       : " + change + ".00");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Thanks! for your order.");
                                                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                                                    Console.WriteLine();
                                                                    break;

                                                                }


                                                                else
                                                                {
                                                                    Console.WriteLine("Thanks for your order!\n We will wait for you to comeback!");
                                                                    Console.WriteLine();
                                                                }
                                                                break;

                                                            }


                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine("Sorry but we cannot cancel your oder.");
                                                            Console.WriteLine("Kindly, Press 1 to finished your payment.");
                                                            pay = Convert.ToInt32(Console.ReadLine());
                                                        }
                                                        break;
                                                    }


                                                    break;
                                                case 3:
                                                    Console.WriteLine("-------------------------------.");
                                                    Console.WriteLine("Your GUCCIFRIES is large.");
                                                    Console.WriteLine("-------------------------------.");
                                                    Console.WriteLine();
                                                    Console.Write("Press 1 to Continue: ");
                                                    pay = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine();

                                                    while (proceed)
                                                    {
                                                        if (pay == 1)
                                                        {
                                                            bill = mainPrice + largeFries;
                                                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                                            Console.WriteLine("Your select " + mainBurger1 + " and large " + sideFries + " with a total of " + bill + ".00 pesos only.");
                                                            Console.WriteLine();
                                                            Console.WriteLine("Enter your payment below.");
                                                            Console.WriteLine("-----------------------");
                                                            Console.Write("PHP: ");
                                                            payment = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("-----------------------");
                                                            change = payment - bill;
                                                            Console.Write("Change: " + change);
                                                            Console.WriteLine();
                                                            Console.WriteLine("Do you want to have a copy of your receipt? (y/n): ");
                                                            copyOfreceipt = Console.ReadLine();
                                                            Console.WriteLine();
                                                            while (proceed)
                                                            {
                                                                if (copyOfreceipt == "n" || copyOfreceipt == "N")
                                                                {
                                                                    Console.WriteLine("Thanks for your order!");

                                                                    Console.WriteLine();
                                                                }

                                                                else if (copyOfreceipt == "y" || copyOfreceipt == "Y")
                                                                {
                                                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                                                    Console.WriteLine("                                 GUCCIGANG MIX AND MATCH      ");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("                                     RECEIPT");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("YOUR GUCCIGANG'S PARTNERS:                              PRICE :");
                                                                    Console.WriteLine("         " + mainBurger1 + "                                    " + mainPrice + ".00");
                                                                    Console.WriteLine("         " + sideFries + "                   large                     " + largeFries + ".00");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("Total                                                        : " + bill + ".00");
                                                                    Console.WriteLine("Payment                                                      : " + payment + ".00");
                                                                    Console.WriteLine("Change                                                       : " + change + ".00");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Thanks! for your order.");
                                                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                                                    Console.WriteLine();
                                                                    break;

                                                                }


                                                                else
                                                                {
                                                                    Console.WriteLine("Thanks for your order!\n We will wait for you to comeback!");
                                                                    Console.WriteLine();
                                                                }
                                                                break;

                                                            }


                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine("Sorry but we cannot cancel your oder.");
                                                            Console.WriteLine("Kindly, Press 1 to finished your payment.");
                                                            pay = Convert.ToInt32(Console.ReadLine());
                                                        }
                                                        break;
                                                    }


                                                    break;



                                            }








                                        }
                                        else if (typeOfside == 2)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("What the size of your CHOCO ICECREAM");
                                            Console.WriteLine("=======================================");
                                            Console.WriteLine("Size:            Price:");
                                            Console.WriteLine("SMALL            35.00");
                                            Console.WriteLine("MEDIUM           40.00");
                                            Console.WriteLine("LARGE            45.00");
                                            Console.WriteLine("========================================");
                                            Console.WriteLine("Press  1 for small.");
                                            Console.WriteLine("Press  2 for medium.");
                                            Console.WriteLine("Press  3 for large.");
                                            Console.WriteLine();
                                            Console.Write("Select the size of icecream: ");
                                            iceCreamsize = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine();

                                            switch (iceCreamsize)
                                            {

                                                case 1:
                                                    Console.WriteLine("===============================");
                                                    Console.WriteLine(" Your choco ICE CREAM is small.");
                                                    Console.WriteLine("===============================");
                                                    Console.WriteLine();
                                                    Console.WriteLine("Press 1 to Continue");
                                                    pay = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine();
                                                    while (proceed)
                                                    {
                                                        if (pay == 1)
                                                        {
                                                            bill = mainPrice + smallIcecream;
                                                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                                            Console.WriteLine("Your select " + mainBurger1 + " and small " + sideIcecream + " with a total of " + bill + ".00 pesos only.");
                                                            Console.WriteLine();
                                                            Console.WriteLine("Enter your payment below.");
                                                            Console.WriteLine("-----------------------");
                                                            Console.Write("PHP: ");
                                                            payment = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("-----------------------");
                                                            change = payment - bill;
                                                            Console.Write("Change: " + change);
                                                            Console.WriteLine();
                                                            Console.WriteLine("Do you want to have a copy of your receipt? (y/n): ");
                                                            copyOfreceipt = Console.ReadLine();
                                                            Console.WriteLine();
                                                            while (proceed)
                                                            {
                                                                if (copyOfreceipt == "n" || copyOfreceipt == "N")
                                                                {
                                                                    Console.WriteLine("Thanks for your order!");

                                                                    Console.WriteLine();
                                                                }

                                                                else if (copyOfreceipt == "y" || copyOfreceipt == "Y")
                                                                {
                                                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                                                    Console.WriteLine("                                 GUCCIGANG MIX AND MATCH      ");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("                                     RECEIPT");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("YOUR GUCCIGANG'S PARTNERS:                              PRICE :");
                                                                    Console.WriteLine("         " + mainBurger1 + "                                    " + mainPrice + ".00");
                                                                    Console.WriteLine("         " + sideIcecream + "                         small                " + smallIcecream + ".00");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("Total                                                        : " + bill + ".00");
                                                                    Console.WriteLine("Payment                                                      : " + payment + ".00");
                                                                    Console.WriteLine("Change                                                       : " + change + ".00");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Thanks! for your order.");
                                                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                                                    Console.WriteLine();
                                                                    break;

                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Thanks for your order!\n We will wait for you to comeback!");
                                                                    Console.WriteLine();
                                                                }
                                                                break;

                                                            }


                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine("Sorry but we cannot cancel your oder.");
                                                            Console.WriteLine("Kindly, Press 1 to finished your payment.");
                                                            pay = Convert.ToInt32(Console.ReadLine());
                                                        }


                                                        break;
                                                    }


                                                    break;
                                                case 2:
                                                    Console.WriteLine("-------------------------------.");
                                                    Console.WriteLine("   Your ICE CREAM is medium.");
                                                    Console.WriteLine("-------------------------------.");
                                                    Console.WriteLine();
                                                    Console.Write("Press 1 to Continue: ");
                                                    pay = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine();

                                                    
                                                        if (pay == 1)
                                                        {
                                                            bill = mainPrice + mediumIcecream;
                                                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                                            Console.WriteLine("Your select " + mainBurger1 + " and medium " + sideIcecream + " with a total of " + bill + ".00 pesos only.");
                                                            Console.WriteLine();
                                                            Console.WriteLine("Enter your payment below.");
                                                            Console.WriteLine("-----------------------");
                                                            Console.Write("PHP: ");
                                                            payment = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("-----------------------");
                                                            change = payment - bill;
                                                            Console.Write("Change: " + change);
                                                            Console.WriteLine();
                                                            Console.WriteLine("Do you want to have a copy of your receipt? (y/n): ");
                                                            copyOfreceipt = Console.ReadLine();
                                                            Console.WriteLine();
                                                            
                                                            
                                                                if (copyOfreceipt == "n" || copyOfreceipt == "N")
                                                                {
                                                                    Console.WriteLine("Thanks for your order!");

                                                                    Console.WriteLine();
                                                                }

                                                                else if (copyOfreceipt == "y" || copyOfreceipt == "Y")
                                                                {
                                                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                                                    Console.WriteLine("                                 GUCCIGANG MIX AND MATCH      ");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("                                     RECEIPT");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("YOUR GUCCIGANG'S PARTNERS:                              PRICE :");
                                                                    Console.WriteLine("         " + mainBurger1 + "                                    " + mainPrice + ".00");
                                                                    Console.WriteLine("         " + sideIcecream + "                  medium                      " + mediumIcecream + ".00");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine("Total                                                        : " + bill + ".00");
                                                                    Console.WriteLine("Payment                                                      : " + payment + ".00");
                                                                    Console.WriteLine("Change                                                       : " + change + ".00");
                                                                    Console.WriteLine("=============================================================================");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Thanks! for your order.");
                                                                    Console.WriteLine("-----------------------------------------------------------------------------");
                                                                    Console.WriteLine();
                                                                    break;

                                                                }


                                                                else
                                                                {
                                                                    Console.WriteLine("Thanks for your order!\n We will wait for you to comeback!");
                                                                    Console.WriteLine();
                                                                }
                                                                break;

                                                            


                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine("Sorry but we cannot cancel your oder.");
                                                            Console.WriteLine("Kindly, Press 1 to finished your payment.");
                                                            pay = Convert.ToInt32(Console.ReadLine());
                                                        }
                                                        break;
                                                    


                                                    break;
                                                case 3:
                                                    Console.WriteLine("-------------------------------.");
                                                    Console.WriteLine("Your ICE CREAM is large.");
                                                    Console.WriteLine("-------------------------------.");
                                                    Console.WriteLine();
                                                    Console.Write("Press 1 to Continue: ");
                                                    pay = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine();
                                                    if (pay == 1)
                                                    {
                                                        bill = mainPrice + largeIcecream;
                                                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                                        Console.WriteLine("Your select " + mainBurger1 + " and large " + sideIcecream + " with a total of " + bill + ".00 pesos only.");
                                                        Console.WriteLine();
                                                        Console.WriteLine("Enter your payment below.");
                                                        Console.WriteLine("-----------------------");
                                                        Console.Write("PHP: ");
                                                        payment = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("-----------------------");
                                                        change = payment - bill;
                                                        Console.Write("Change: " + change);
                                                        Console.WriteLine();
                                                        Console.WriteLine("Do you want to have a copy of your receipt? (y/n): ");
                                                        copyOfreceipt = Console.ReadLine();
                                                        Console.WriteLine();
                                                        while (proceed)
                                                        {
                                                            if (copyOfreceipt == "n" || copyOfreceipt == "N")
                                                            {
                                                                Console.WriteLine("Thanks for your order!");

                                                                Console.WriteLine();
                                                            }

                                                            else if (copyOfreceipt == "y" || copyOfreceipt == "Y")
                                                            {
                                                                Console.WriteLine("-----------------------------------------------------------------------------");
                                                                Console.WriteLine("                                 GUCCIGANG MIX AND MATCH      ");
                                                                Console.WriteLine();
                                                                Console.WriteLine("=============================================================================");
                                                                Console.WriteLine("                                     RECEIPT");
                                                                Console.WriteLine("=============================================================================");
                                                                Console.WriteLine("YOUR GUCCIGANG'S PARTNERS:                              PRICE :");
                                                                Console.WriteLine("         " + mainBurger1 + "                                    " + mainPrice + ".00");
                                                                Console.WriteLine("         " + sideIcecream + "                   large                     " + largeIcecream + ".00");
                                                                Console.WriteLine("=============================================================================");
                                                                Console.WriteLine("Total                                                        : " + bill + ".00");
                                                                Console.WriteLine("Payment                                                      : " + payment + ".00");
                                                                Console.WriteLine("Change                                                       : " + change + ".00");
                                                                Console.WriteLine("=============================================================================");
                                                                Console.WriteLine();
                                                                Console.WriteLine("Thanks! for your order.");
                                                                Console.WriteLine("-----------------------------------------------------------------------------");
                                                                Console.WriteLine();
                                                                break;

                                                            }


                                                            else
                                                            {
                                                                Console.WriteLine("Thanks for your order!\n We will wait for you to comeback!");
                                                                Console.WriteLine();
                                                            }
                                                            break;

                                                        }


                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine();
                                                        Console.WriteLine("Sorry but we cannot cancel your oder.");
                                                        Console.WriteLine("Kindly, Press 1 to finished your payment.");
                                                        pay = Convert.ToInt32(Console.ReadLine());
                                                    }

                                                    break;
                                            }
                                        }

                                        else if (typeOfside == 3)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("                                            BEVERAGE                                        ");
                                            Console.WriteLine("============================================================================================");
                                            Console.WriteLine("CHOCO FLOAT    PHP 55.00       ICED TEA      PHP 40.00         COKE               PHP 25.00");
                                            Console.WriteLine("COKE FLOAT     PHP 60.00       ICED COFFEE   PHP 50.00         PINEAPPLE JUICE    PHP 25.00");
                                            Console.WriteLine("============================================================================================");
                                            Console.WriteLine();
                                            Console.WriteLine("Press  2 for coke float");
                                            Console.WriteLine("Press  3 for iced tea");
                                            Console.WriteLine("Press  4 for iced coffee");
                                            Console.WriteLine("Press  5 for coke");
                                            Console.WriteLine("Press  6 for pineapple juice");
                                            Console.WriteLine();
                                            Console.WriteLine("Your beverage: ");
                                            iceCreamsize = Convert.ToInt32(Console.ReadLine());

                                            switch (iceCreamsize)
                                            {

                                                case 1:
                                                    Console.WriteLine();
                                                    Console.WriteLine("==========================================");
                                                    Console.WriteLine(" Your choose CHOCO FLOAT as your beverage.");
                                                    Console.WriteLine("===========================================");
                                                    Console.Write("Press 1 to Continue: ");
                                                    pay = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine();
                                                    bill = mainPrice + smallFries;
                                                    pay = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine();


                                                    if (pay == 1)     
                                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                                    Console.WriteLine("Your select " + mainBurger2 + " and small " + sideFries + " with a total of " + bill + ".00 pesos only.");
                                                    Console.WriteLine();
                                                    Console.WriteLine("Enter your payment below.");
                                                    Console.WriteLine("-----------------------");
                                                    Console.Write("PHP: ");
                                                    payment = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("-----------------------");
                                                    change = payment - bill;
                                                    Console.Write("Change: " + change);
                                                    Console.WriteLine();
                                                    Console.WriteLine("Do you want to have a copy of your receipt? (y/n): ");
                                                    copyOfreceipt = Console.ReadLine();
                                                    Console.WriteLine();
                                                    if (copyOfreceipt == "n" || copyOfreceipt == "N")
                                                    {
                                                        Console.WriteLine("Thanks for your order!");

                                                        Console.WriteLine();
                                                    }

                                                    else if (copyOfreceipt == "y" || copyOfreceipt == "Y")
                                                    {
                                                        Console.WriteLine("-----------------------------------------------------------------------------");
                                                        Console.WriteLine("                                 GUCCIGANG MIX AND MATCH      ");
                                                        Console.WriteLine();
                                                        Console.WriteLine("=============================================================================");
                                                        Console.WriteLine("                                     RECEIPT");
                                                        Console.WriteLine("=============================================================================");
                                                        Console.WriteLine("YOUR GUCCIGANG'S PARTNERS:                              PRICE :");
                                                        Console.WriteLine("         " + mainBurger1 + "                                  " + mainPrice + ".00");
                                                        Console.WriteLine("         " + side + "                   small                     " + smallFries + ".00");
                                                        Console.WriteLine("=============================================================================");
                                                        Console.WriteLine("Total                                                        : " + bill + ".00");
                                                        Console.WriteLine("Payment                                                      : " + payment + ".00");
                                                        Console.WriteLine("Change                                                       : " + change + ".00");
                                                        Console.WriteLine("=============================================================================");
                                                        Console.WriteLine();
                                                        Console.WriteLine("Thanks! for your order.");
                                                        Console.WriteLine("-----------------------------------------------------------------------------");
                                                        Console.WriteLine();
                                                        break;

                                                    }




                                                    break;

                                                    // dito
                                            }
                                            break;
                                        }
                                        break;

                                }
                            
                               
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Press 1 to order.");
                                Console.WriteLine("Press 0 to exit.");
                                Console.Write("Enter your choice: ");
                                choose = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();

                            }
                     break;
                    }
                }
            }
        }
    }
}
