using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

bool restart = true;


Console.WriteLine("Time to learn your squares and cubes!");

do
{
    restart = StartProgram();
}
while (restart == true);


// method Start the Program

static bool StartProgram()
{
    bool validate = true;
    int usernum;

    do
    {
        Console.WriteLine("Enter an integer: ");
        usernum = int.Parse(Console.ReadLine());

        {
            if (usernum <= 0 || (usernum) > Math.Cbrt(int.MaxValue) )  // makes it so that the code doesnt overflow
            {
                Console.WriteLine("Incorrect Try Again");
                
                validate = true;
                

            }
            else
            {
                validate = false;
            }

        }


    }
    while (validate == true);

   


  

    Console.WriteLine("Number\t\tSquared\t\tCubed");
    Console.WriteLine("=======\t\t======\t\t======");
    for(int i = 1; i <= usernum; i++)
    {
        
        int square = i * i;
        int cube = i * i * i;
    //    Console.WriteLine($"{i}\t\t{square}\t\t{cube}");
        Console.WriteLine(string.Format("{0,10} {1,10} {2,10}", i,square,cube));

        //  Console.WriteLine(string.Format("{0,10} {1,10} {2,10}", i, Square(i), Cube(i))); //this is the right align code



    }



    Console.WriteLine("Would you like to try again y/n?");
    string tryAgain = Console.ReadLine();


    if (tryAgain == "y" || tryAgain == "Y")
    {
        return true;
    }

    else
    {
        return false;
    }




}