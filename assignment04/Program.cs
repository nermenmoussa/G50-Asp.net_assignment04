using System;


class program
{
    //--------------------------Q3-----------------------
    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");

    }

    //----------Q4---------
    /*Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
"Clean Code".*/
    static void PrintBookTitle(string title) { Console.WriteLine($"Book Title :{title}"); }


    //----Q5-------
    static void AddBonusPages(int pages)
    {
        pages += 50;
        return ;
    }

    //--------------Q6------------
    /*Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
see, and why?
*/
    static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5;
        return;
    }

    //-------------Q7---------------
    /*Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
Call it and print pages afterward. How is the result different from question 5?
*/

    static void AddBonusPagesByRef(ref int pages)
    {
        pages += 50;
        return;
    }


    //----------Q8------------
    /*Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
    new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
    afterward*/

    static void ReplaceArray(ref double[] prices) {

        prices = new double[] { 10.0, 12.5, 15.0 };
    }


    //---------------Q9-------------
    /*Write a method bool TryGetPrice(string title, out double price) that returns true and sets
price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it and print the price if found
*/

     static bool TryGetPrice(string title, out double price)
    {
        if( title == "Clean Code")
        {
            price = 25.5;
            return true;
        }
        else
        {
            price = 0;
            return false;
        }

    }

    //-----------Q10--------------
    /*Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call it once with only a title, and once passing both a title and pages.*/

    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"Title : {title}, Pages:{pages}");
    }


    //------------------Q12--------------------
    /*Write a method PrintAllTitles(params string[] titles) that prints each title on its own line.
Call it with three book titles.*/
    static void PrintAllTitles(params string[] titles)
    {
        for(int i= 0; i < titles.Length; i++)
        {
            Console.WriteLine(titles[i]);
        }
    }

    //----------------------------------------------------------------------------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------------------------------------------------------------------------


    static void Main()
    {
        /*Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
        the second price (index 1).
        */

        Console.WriteLine("--Q1--");

double[] prices = { 25.5, 40.0, 33.75 };
    Console.WriteLine(prices[1]);



/*Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.*/

Console.WriteLine("--Q2--");
int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
    Console.WriteLine(shelfCopies[1, 0]);



/*Write a method called PrintWelcomeMessage that takes no parameters and prints
"Welcome to the Library!". Call it from Main.
*/
  
        Console.WriteLine("--Q3--");
        PrintWelcomeMessage();

        Console.WriteLine("--Q4--");
        PrintBookTitle("clean code");

        /*Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
        int pages = 400; and print pages afterward. What do you expect to see, and why?
        */
        int pages = 400;

        Console.WriteLine("--Q5--");
        AddBonusPages(pages);
        Console.WriteLine(pages);

        //i expect the value not change ,because pages changed inside the the function but at the main not change,


        Console.WriteLine("--Q6--");
        double[] prices1 = { 25.5, 40.0 };
        ApplyDiscount(prices1);
        Console.WriteLine(prices1[0]);

        //i expect the value will change because it refer to the same refrence

        //------Q7----------
        Console.WriteLine("--Q7--");
        AddBonusPagesByRef(ref pages);
        Console.WriteLine(pages);

        //the value change at both because  ref pass the argument itself 


        //---------Q8---------------

        Console.WriteLine("--------Q8-----------");
        ReplaceArray(ref prices1);
        Console.WriteLine(prices1.Length);


  //-----------------Q9-----------
  Console.WriteLine("-------------------Q9--------------");
        string title1 = "Hello";
        double price;
        bool res = TryGetPrice(title1, out price);

        Console.WriteLine($"Result : {res} , Price :{price}");

        Console.WriteLine("----------new res---------");
        title1 = "Clean Code";
        bool res2 = TryGetPrice(title1, out price);
        Console.WriteLine($"Result : {res2} , Price :{price}");

        //-----------Q10--------------

        Console.WriteLine("-------------------Q10--------------");
        PrintBookInfo("hello world");
        PrintBookInfo("Clean Code ", 7000);


        //--------------Q11------------

        Console.WriteLine("-------------------Q11--------------");
        PrintBookInfo(pages:500,title:"QUESTION 11");

        //-----------Q12------------

        Console.WriteLine("-------------------Q12--------------");
        PrintAllTitles("c#", "Java", "Node");

    }

}


