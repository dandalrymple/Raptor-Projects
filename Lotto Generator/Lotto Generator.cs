using System;
using System.IO;
using System.Text;

namespace Lotto Generator
{
   public class main_class
   {
      static System.Random random_generator = new System.Random();
      public static void Main(string[] args)
      {
         string raptor_prompt_variable_zzyz;
         ?? mmchoice;
         ?? pbchoice;
         ?? mresult;
         ?? presult;
         ??[] marray = new ??[??+1];
         ??[] parray = new ??[??+1];
      
         pbChoice =0;
         mmChoice =0;
         while (1)
         {
            raptor_prompt_variable_zzyz ="How many Powerball results do you want? Whole numbers only. If you don't want any, type in '0'.";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            pbChoice= Double.Parse(Console.ReadLine());
            if (Is_Number(pbChoice) && pbChoice>=0 && pbChoice % 1==0)) break;
         }
         while (1)
         {
            raptor_prompt_variable_zzyz ="How many Mega Millions results do you want? Again, if you don't want any, you can always choose 0.";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            mmChoice= Double.Parse(Console.ReadLine());
            if (Is_Number(mmChoice) && mmChoice>=0 && mmChoice % 1==0)) break;
         }
         while (1)
         {
            if (pbChoice==0)
            {
               if (mmChoice==0)
               {
               }
               else
               {
                  mArray[6] = 0;
                  mResult =floor((random_generator.NextDouble()*70)+1);
                  mArray[1] = mResult;
                  mResult =floor((random_generator.NextDouble()*70)+1);
                  mArray[2] = mResult;
                  mResult =floor((random_generator.NextDouble()*70)+1);
                  mArray[3] = mResult;
                  mResult =floor((random_generator.NextDouble()*70)+1);
                  mArray[4] = mResult;
                  mResult =floor((random_generator.NextDouble()*70)+1);
                  mArray[5] = mResult;
                  mResult =floor((random_generator.NextDouble()*25)+1);
                  mArray[6] = mResult;
                  mmChoice =mmChoice-1;
                  Console.WriteLine("Your Mega Millions numbers are:"+" "+mArray(1)+" "+mArray(2)+" "+mArray(3)+" "+mArray(4)+" "+mArray(5)+" and "+mArray(6));
               }
            }
            else
            {
               if (mmChoice==0)
               {
                  pArray[6] = 0;
                  pResult =floor((random_generator.NextDouble()*69)+1);
                  pArray[1] = pResult;
                  pResult =floor((random_generator.NextDouble()*69)+1);
                  pArray[2] = pResult;
                  pResult =floor((random_generator.NextDouble()*69)+1);
                  pArray[3] = pResult;
                  pResult =floor((random_generator.NextDouble()*69)+1);
                  pArray[4] = pResult;
                  pResult =floor((random_generator.NextDouble()*69)+1);
                  pArray[5] = pResult;
                  pResult =floor((random_generator.NextDouble()*26)+1);
                  pArray[6] = pResult;
                  pbChoice =pbChoice-1;
                  Console.WriteLine("Your Powerball numbers are:"+" "+pArray(1)+" "+pArray(2)+" "+pArray(3)+" "+pArray(4)+" "+pArray(5)+" and "+pArray(6));
               }
               else
               {
                  pArray[6] = 0;
                  pResult =floor((random_generator.NextDouble()*69)+1);
                  pArray[1] = pResult;
                  pResult =floor((random_generator.NextDouble()*69)+1);
                  pArray[2] = pResult;
                  pResult =floor((random_generator.NextDouble()*69)+1);
                  pArray[3] = pResult;
                  pResult =floor((random_generator.NextDouble()*69)+1);
                  pArray[4] = pResult;
                  pResult =floor((random_generator.NextDouble()*69)+1);
                  pArray[5] = pResult;
                  pResult =floor((random_generator.NextDouble()*26)+1);
                  pArray[6] = pResult;
                  pbChoice =pbChoice-1;
                  Console.WriteLine("Your Powerball numbers are:"+" "+pArray(1)+" "+pArray(2)+" "+pArray(3)+" "+pArray(4)+" "+pArray(5)+" and "+pArray(6));
                  mArray[6] = 0;
                  mResult =floor((random_generator.NextDouble()*70)+1);
                  mArray[1] = mResult;
                  mResult =floor((random_generator.NextDouble()*70)+1);
                  mArray[2] = mResult;
                  mResult =floor((random_generator.NextDouble()*70)+1);
                  mArray[3] = mResult;
                  mResult =floor((random_generator.NextDouble()*70)+1);
                  mArray[4] = mResult;
                  mResult =floor((random_generator.NextDouble()*70)+1);
                  mArray[5] = mResult;
                  mResult =floor((random_generator.NextDouble()*25)+1);
                  mArray[6] = mResult;
                  mmChoice =mmChoice-1;
                  Console.WriteLine("Your Mega Millions numbers are:"+" "+mArray(1)+" "+mArray(2)+" "+mArray(3)+" "+mArray(4)+" "+mArray(5)+" and "+mArray(6));
               }
            }
            if (pbChoice==0 && mmChoice==0)) break;
         }
         Console.WriteLine("I hope you enjoyed this little program.");
      }
   }
}
