using System;
using System.IO;
using System.Text;

namespace fallout 4 SPECIAL randomizer plus
{
   public class main_class
   {
      static System.Random random_generator = new System.Random();
      public static void Main(string[] args)
      {
         string raptor_prompt_variable_zzyz;
         ?? per;
         ?? flipresult;
         ?? cha;
         ?? end;
         ?? progiters;
         ?? str;
         ?? luc;
         ?? specpool;
         ?? agi;
         ?? int;
      
         specPool =21;
         Str =1;
         Per =1;
         End =1;
         Cha =1;
         Int =1;
         Agi =1;
         Luc =1;
         flipResult =0;
         while (1)
         {
            progIters =0;
            raptor_prompt_variable_zzyz ="How many times do you want to randomize SPECIAL stats? Please enter a number greater than or equal to Zero.";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            progIters= Double.Parse(Console.ReadLine());
            if (Is_Number(progIters) && progIters>=0 && progIters % 1==0)) break;
         }
         while (1)
         {
            flipResult =0;
            specPool =21;
            Str =1;
            Per =1;
            End =1;
            Cha =1;
            Int =1;
            Agi =1;
            Luc =1;
            if (progIters<=0)) break;
            while (1)
            {
               flipResult =floor((random_generator.NextDouble()*7)+1);
               if (flipResult==7)
               {
                  if (Str>=10)
                  {
                  }
                  else
                  {
                     Str =Str+1;
                     specPool =specPool-1;
                  }
               }
               else
               {
                  if (flipResult==6)
                  {
                     if (Per>=10)
                     {
                     }
                     else
                     {
                        Per =Per+1;
                        specPool =specPool-1;
                     }
                  }
                  else
                  {
                     if (flipResult==5)
                     {
                        if (End>=10)
                        {
                        }
                        else
                        {
                           End =End+1;
                           specPool =specPool-1;
                        }
                     }
                     else
                     {
                        if (flipResult==4)
                        {
                           if (Cha>=10)
                           {
                           }
                           else
                           {
                              Cha =Cha+1;
                              specPool =specPool-1;
                           }
                        }
                        else
                        {
                           if (flipResult==3)
                           {
                              if (Int>=10)
                              {
                              }
                              else
                              {
                                 Int =Int+1;
                                 specPool =specPool-1;
                              }
                           }
                           else
                           {
                              if (flipResult==2)
                              {
                                 if (Agi>=10)
                                 {
                                 }
                                 else
                                 {
                                    Agi =Agi+1;
                                    specPool =specPool-1;
                                 }
                              }
                              else
                              {
                                 if (flipResult==1)
                                 {
                                    if (Luc>=10)
                                    {
                                    }
                                    else
                                    {
                                       Luc =Luc+1;
                                       specPool =specPool-1;
                                    }
                                 }
                                 else
                                 {
                                 }
                              }
                           }
                        }
                     }
                  }
               }
               if (specPool==0)) break;
            }
            progIters =progIters-1;
            Console.WriteLine("Your SPECIAL stats are as follows: "+"Strength: "+Str+" Perception: "+Per+" Endurance: "+End+" Charisma: "+Cha+" Intelligence: "+Int+" Agility: "+Agi+" Luck: "+Luc);
         }
         Console.WriteLine("Thanks for using my program. I hope you found it interesting.");
      }
   }
}
