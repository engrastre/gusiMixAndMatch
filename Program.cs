using System;
using System.ComponentModel.Design;
using System.Drawing;

namespace gusiMixAndMatch;
class Program
{
    static void Main(String[] args)
    {
        int choose, main, burger,spaghetti, chicken, typeOfside, friesSize, chocoIceCreamSize, chosenJuice;
        int mainDefaultPrice = 150, bill, sFries = 45, mFries = 55, lFries = 65, sIcecream = 35, mIcecream = 45, lIcecream = 55, juicePrice = 70;
        var mainBurgers = new List<string>()
           {"DOUBLE PATTY BURGER", "DOUBLE CHICKEN BURGER", "VEGIE BURGER", "ROYALE BURGER"};
        var mainSpaghetti = new List<string>()
        {"REGULAR SPAGHETTI", "SPAGHETTI W/ CHICKEN", "SPAGHETTI W/ REGULAR BURGER" };
        var mainChicken = new List<string>()
        {"CHICKEN W/ RICE", "SPICY CHICKEN W/ RICE" };
        var sides = new List<string>()
        { "GUCCI FRIES", "CHOCO ICED CREAM"};
        var sizes = new List<string>()
             { "SMALL ", "MEDIUM ", "LARGE "};
        var juiceTypes = new List<string>()
        {"ORANGE JUICE", "PINEAPPLE JUICE", "ICED TEA" };
        menu();
        Console.WriteLine("NOTE: MAIN HAS A FIXED PRICE OF 150.00 WHILE THE SIDE HAS PRICE BASED ON ITS TYPE OR SIZE!");
        Console.WriteLine("Press 'ENTER' to create your order.");
        Console.ReadKey();
        bool proceed = true;
        while (proceed)
        {
        Console.WriteLine();
        Console.WriteLine("To make an order press 1.");
        Console.WriteLine("To exit press 0 or any number.");
        Console.Write("Enter your choice: ");
        choose = Convert.ToInt32(Console.ReadLine());
       
            if (choose == 0)
            {
                exit(choose);
                break;
            }
           else if (choose == 1)
            {
                choosingMain();
                Console.Write("Select your MAIN: ");
                main = Convert.ToInt32(Console.ReadLine());
                if (main == 1)
                {
                    burgerMain();
                    burger = Convert.ToInt32(Console.ReadLine());
                    if (burger == 1)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Your main is " + mainBurgers[0]);
                        Console.WriteLine("---------------------------------------");
                        sideChoice();
                        Console.Write("Choose your Side: ");
                        typeOfside = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (typeOfside)
                        {
                            case 1:
                                sideFries();
                                friesSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (friesSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                sideIcecream();
                                chocoIceCreamSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chocoIceCreamSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[1] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[2] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[3] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                sideJuice();
                                chosenJuice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chosenJuice == 1)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[0]);
                                    Console.WriteLine("Your side is " + juiceTypes[0] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 2)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[0]);
                                    Console.WriteLine("Your side is " + juiceTypes[1] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 3)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[0]);
                                    Console.WriteLine("Your side is " + juiceTypes[2] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Oops.. invalid input! ");
                                    Console.WriteLine("Select your juice: ");
                                    chosenJuice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }

                                break;
                        }



                    }
                    else if (burger == 2)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Your main is " + mainBurgers[1]);
                        Console.WriteLine("---------------------------------------");
                        sideChoice();
                        Console.Write("Choose your Side: ");
                        typeOfside = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (typeOfside)
                        {
                            case 1:
                                sideFries();
                                friesSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (friesSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                sideIcecream();
                                chocoIceCreamSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chocoIceCreamSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[1] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[2] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[3] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                sideJuice();
                                chosenJuice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chosenJuice == 1)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[1]);
                                    Console.WriteLine("Your side is " + juiceTypes[0] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 2)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[1]);
                                    Console.WriteLine("Your side is " + juiceTypes[1] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 3)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[1]);
                                    Console.WriteLine("Your side is " + juiceTypes[2] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Oops.. invalid input! ");
                                    Console.WriteLine("Select your juice: ");
                                    chosenJuice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                        }
                    }
                    else if (burger == 3)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Your main is " + mainBurgers[2]);
                        Console.WriteLine("---------------------------------------");
                        sideChoice();
                        Console.Write("Choose your Side: ");
                        typeOfside = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (typeOfside)
                        {
                            case 1:
                                sideFries();
                                friesSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (friesSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                sideIcecream();
                                chocoIceCreamSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chocoIceCreamSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[1] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[2] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[3] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                sideJuice();
                                chosenJuice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chosenJuice == 1)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[2]);
                                    Console.WriteLine("Your side is " + juiceTypes[0] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 2)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[2]);
                                    Console.WriteLine("Your side is " + juiceTypes[1] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 3)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[2]);
                                    Console.WriteLine("Your side is " + juiceTypes[2] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Oops.. invalid input! ");
                                    Console.WriteLine("Select your juice: ");
                                    chosenJuice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                        }


                    }
                    else if (burger == 4)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Your main is " + mainBurgers[3]);
                        Console.WriteLine("---------------------------------------");
                        sideChoice();
                        Console.Write("Choose your Side: ");
                        typeOfside = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (typeOfside)
                        {
                            case 1:
                                sideFries();
                                friesSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (friesSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[3] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[3] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[3] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                sideIcecream();
                                chocoIceCreamSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chocoIceCreamSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[3] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[1] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[3] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[2] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainBurgers[3] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[3] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                sideJuice();
                                chosenJuice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chosenJuice == 1)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[3]);
                                    Console.WriteLine("Your side is " + juiceTypes[0] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 2)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[3]);
                                    Console.WriteLine("Your side is " + juiceTypes[1] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 3)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainBurgers[3]);
                                    Console.WriteLine("Your side is " + juiceTypes[2] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Oops.. invalid input! ");
                                    Console.WriteLine("Select your juice: ");
                                    chosenJuice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opps..Invalid input");
                        Console.Write("Select your burger: ");
                        burger = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }
                }
                else if (main == 2)
                {
                    spaghettiMain();
                    spaghetti = Convert.ToInt32(Console.ReadLine());
                    if (spaghetti == 1)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Your main is " + mainSpaghetti[0]);
                        Console.WriteLine("---------------------------------------");
                        sideChoice();
                        Console.Write("Choose your Side: ");
                        typeOfside = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (typeOfside)
                        {
                            case 1:
                                sideFries();
                                friesSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (friesSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                sideIcecream();
                                chocoIceCreamSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chocoIceCreamSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[1] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[2] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[3] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                sideJuice();
                                chosenJuice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chosenJuice == 1)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainSpaghetti[0]);
                                    Console.WriteLine("Your side is " + juiceTypes[0] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 2)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainSpaghetti[0]);
                                    Console.WriteLine("Your side is " + juiceTypes[1] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 3)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainSpaghetti[0]);
                                    Console.WriteLine("Your side is " + juiceTypes[2] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Oops.. invalid input! ");
                                    Console.WriteLine("Select your juice: ");
                                    chosenJuice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }

                                break;
                        }


                    }
                    else if (spaghetti == 2)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Your main is " + mainSpaghetti[1]);
                        Console.WriteLine("---------------------------------------");
                        sideChoice();
                        Console.Write("Choose your Side: ");
                        typeOfside = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (typeOfside)
                        {
                            case 1:
                                sideFries();
                                friesSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (friesSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                sideIcecream();
                                chocoIceCreamSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chocoIceCreamSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[1] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[2] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[3] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                sideJuice();
                                chosenJuice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chosenJuice == 1)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainSpaghetti[1]);
                                    Console.WriteLine("Your side is " + juiceTypes[0] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 2)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainSpaghetti[1]);
                                    Console.WriteLine("Your side is " + juiceTypes[1] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 3)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainSpaghetti[1]);
                                    Console.WriteLine("Your side is " + juiceTypes[2] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Oops.. invalid input! ");
                                    Console.WriteLine("Select your juice: ");
                                    chosenJuice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }

                                break;
                        }
                    }
                    else if (spaghetti == 3)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Your main is " + mainSpaghetti[2]);
                        Console.WriteLine("---------------------------------------");
                        sideChoice();
                        Console.Write("Choose your Side: ");
                        typeOfside = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (typeOfside)
                        {
                            case 1:
                                sideFries();
                                friesSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (friesSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                sideIcecream();
                                chocoIceCreamSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chocoIceCreamSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[1] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[2] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainSpaghetti[2] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[3] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                sideJuice();
                                chosenJuice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chosenJuice == 1)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainSpaghetti[2]);
                                    Console.WriteLine("Your side is " + juiceTypes[0] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 2)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainSpaghetti[2]);
                                    Console.WriteLine("Your side is " + juiceTypes[1] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 3)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainSpaghetti[2]);
                                    Console.WriteLine("Your side is " + juiceTypes[2] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Oops.. invalid input! ");
                                    Console.WriteLine("Select your juice: ");
                                    chosenJuice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }

                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Opps..Invalid Input");
                        Console.Write("Select your spaghetti: ");
                        spaghetti = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else if (main == 3)
                {
                    chickenMain();
                    chicken =Convert.ToInt32(Console.ReadLine());
                    if (chicken == 1)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Your main is " + mainChicken[0]);
                        Console.WriteLine("---------------------------------------");
                        sideChoice();
                        Console.Write("Choose your Side: ");
                        typeOfside = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (typeOfside)
                        {
                            case 1:
                                sideFries();
                                friesSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (friesSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[0]+ ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                sideIcecream();
                                chocoIceCreamSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chocoIceCreamSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[1] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[2] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[0] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[3] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                sideJuice();
                                chosenJuice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chosenJuice == 1)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainChicken[0]);
                                    Console.WriteLine("Your side is " + juiceTypes[0] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 2)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainChicken[0]);
                                    Console.WriteLine("Your side is " + juiceTypes[1] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 3)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainChicken[0]);
                                    Console.WriteLine("Your side is " + juiceTypes[2] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Oops.. invalid input! ");
                                    Console.WriteLine("Select your juice: ");
                                    chosenJuice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }

                                break;
                        }
                    }
                    else if (chicken == 2)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Your main is " + mainChicken[1]);
                        Console.WriteLine("---------------------------------------");
                        sideChoice();
                        Console.Write("Choose your Side: ");
                        typeOfside = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (typeOfside)
                        {
                            case 1:
                                sideFries();
                                friesSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (friesSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (friesSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[0] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lFries;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                sideIcecream();
                                chocoIceCreamSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chocoIceCreamSize == 1)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[0] + sides[1] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + sIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 2)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[1] + sides[2] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + mIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chocoIceCreamSize == 3)
                                {
                                    Console.WriteLine("=========================================");
                                    Console.WriteLine("Your main is " + mainChicken[1] + ".");
                                    Console.WriteLine("Your side is " + sizes[2] + sides[3] + ".");
                                    Console.WriteLine("-----------------------------------------");
                                    bill = mainDefaultPrice + lIcecream;
                                    Console.WriteLine("Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Opps..Invalid input.");
                                    Console.Write("Select size: ");
                                    friesSize = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                sideJuice();
                                chosenJuice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (chosenJuice == 1)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainChicken[1]);
                                    Console.WriteLine("Your side is " + juiceTypes[0] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 2)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainChicken[1]);
                                    Console.WriteLine("Your side is " + juiceTypes[1] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else if (chosenJuice == 3)
                                {
                                    Console.WriteLine("--------------------------------------------");
                                    Console.WriteLine("Your main is " + mainChicken[1]);
                                    Console.WriteLine("Your side is " + juiceTypes[2] + ".");
                                    Console.WriteLine("--------------------------------------------");
                                    bill = mainDefaultPrice + juicePrice;
                                    Console.WriteLine(" Your bill total is: " + bill);
                                    payment(bill);
                                }
                                else
                                {
                                    Console.WriteLine("Oops.. invalid input! ");
                                    Console.WriteLine("Select your juice: ");
                                    chosenJuice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                }

                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Opps..Invalid Input");
                        Console.Write("Select your chicken: ");
                        chicken = Convert.ToInt32(Console.ReadLine());
                    }
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opps..Invalid Input");
                    Console.Write("Select Main: ");
                    main = Convert.ToInt32(Console.ReadLine());

                }
          

            }
            else
            {
                Console.WriteLine("Opps..Invalid Input");
                Console.Write("Enter your choice: ");
                choose = Convert.ToInt32(Console.ReadLine());
            }
        }

    }

    static void menu()
    {
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
    }

    static void choosingMain()
    {
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("Step 1: CHOOSE YOUR MAIN w/a fixed price of 150 pesos only!");
        Console.WriteLine();
        Console.WriteLine("           BURGER              SPAGHETTI                 CHICKEN");
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("Press 1 for Burger.");
        Console.WriteLine("Press 2 for Spaghetti.");
        Console.WriteLine("Press 3 for Chicken.");
    }
    static void exit(int choose)
    {
        Console.WriteLine();
        Console.WriteLine("Thanks for visiting us! \nWe will wait for you to comeback.");
        Console.WriteLine();

    }
    static void burgerMain()
    {

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
        Console.Write("Select your burger: ");


    }
    static void spaghettiMain()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("   s1 - REGULAR SPAGHETTI");
        Console.WriteLine("   s2 - SPAGHETTI W/ CHICKEN");
        Console.WriteLine("   s3 - SPAGHETTI W/ REGULAR BURGER");
        Console.WriteLine("==================================");
        Console.WriteLine("Press 1 for s1 ");
        Console.WriteLine("Press 2 for s2 ");
        Console.WriteLine("Press 3 for s3 ");
        Console.Write("Select your spaghetti: ");
    }
    static void chickenMain()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("   c1 - CHICKEN W/ RICE ");
        Console.WriteLine("   c2 -SPICY CHICKEN W/ RICE");
        Console.WriteLine("==================================");
        Console.WriteLine("Press 1 for c1 ");
        Console.WriteLine("Press 2 for c2 ");
        Console.Write("Select your chicken: ");
    }
    static void sideChoice()
    {
        Console.Write("You are now going to select your Side. \n Press 1 to 'Continue': ");
        int side = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Step 2 choose your SIDE: ");
        Console.WriteLine("  FRIES       ICE CREAM   BEVERAGE  ");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Press 1 for Fries");
        Console.WriteLine("Press 2 for Icream");
        Console.WriteLine("Press 3 for BEVERAGE");
    }
    static void sideFries()
    {
        Console.WriteLine("YOU CHOOSE GUCCI FRIES AS YOUR SIDE.");
        Console.WriteLine("=======================================");
        Console.WriteLine("Size:            Price:");
        Console.WriteLine("SMALL            45.00");
        Console.WriteLine("MEDIUM           55.00");
        Console.WriteLine("LARGE            65.00");
        Console.WriteLine("========================================");
        Console.WriteLine("Press  1 for small.");
        Console.WriteLine("Press  2 for medium.");
        Console.WriteLine("Press  3 for large.");
        Console.Write("Select size: ");
    }
    static void sideIcecream()
    {
        Console.WriteLine("YOU CHOCO ICE CREAM AS YOUR SIDE.");
        Console.WriteLine("=======================================");
        Console.WriteLine("Size:            Price:");
        Console.WriteLine("SMALL            35.00");
        Console.WriteLine("MEDIUM           45.00");
        Console.WriteLine("LARGE            55.00");
        Console.WriteLine("========================================");
        Console.WriteLine("Press  1 for small.");
        Console.WriteLine("Press  2 for medium.");
        Console.WriteLine("Press  3 for large.");
        Console.WriteLine();
        Console.Write("Select size: ");
    }
    static void sideJuice()
    {
        Console.WriteLine("CHOOSE ANY OF THESE JUICES AS YOUR SIDE.");
        Console.WriteLine("===================================");
        Console.WriteLine("                             Price:");
        Console.WriteLine("ORANGE JUICE       500ml     70.00");
        Console.WriteLine("PINEAPPLE JUICE    500ml     70.00");
        Console.WriteLine("ICED TEA           500ml     70.00");
        Console.WriteLine("====================================");
        Console.WriteLine("Press 1 for ORANGE JUICE");
        Console.WriteLine("Press 2 for PINEAPPLE JUICE");
        Console.WriteLine("Press 3 for ICED TEA");
    }
    static void payment(int bill)
    {
        Console.Write("Enter your payment: ");
        int payment = Convert.ToInt32(Console.ReadLine());
        int change = payment - bill;
        Console.WriteLine("Change: " + change);
        Console.WriteLine("=========================================");
        Console.WriteLine("Thanks for your order!");
        Console.WriteLine();
    }
}




