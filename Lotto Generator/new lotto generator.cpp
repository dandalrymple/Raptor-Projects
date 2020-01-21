#include <iostream>
#include <string>

using namespace std;
int main()
{
   string raptor_prompt_variable_zzyz;
   ?? pchoice;
   ?? mchoice;
   ?? p6;
   ?? pick3;
   ?? pick2;
   ?? pick5;
   ?? pick4;
   ?? m6;
   ??[] pb = new ??[??+1];
   ??[] mm = new ??[??+1];

   while (1)
   {
      raptor_prompt_variable_zzyz ="How many Powerball entries would you like to generate?";
      cout << raptor_prompt_variable_zzyz << endl;
      cin >> pChoice;
      if (Is_Number(pChoice) && pChoice>=0 && pChoice % 1==0)) break;
   }
   while (1)
   {
      raptor_prompt_variable_zzyz ="How many Mega Millions quick picks would you like?";
      cout << raptor_prompt_variable_zzyz << endl;
      cin >> mChoice;
      if (Is_Number(mChoice) && mChoice>=0 && mChoice % 1==0)) break;
   }
   while (1)
   {
      if (pChoice==0)
      {
         if (mChoice==0)
         {
         }
         else
         {
            mm[5] = 0;
            m6 =floor((random_generator.NextDouble()*25)+1);
            mm[1] = floor((random_generator.NextDouble()*70)+1);
            while (1)
            {
               mm[2] = floor((random_generator.NextDouble()*70)+1);
               if (mm(2)!=mm(1))) break;
            }
            while (1)
            {
               mm[3] = floor((random_generator.NextDouble()*70)+1);
               if (mm(3)!=mm(2) && mm(3)!=mm(1))) break;
            }
            while (1)
            {
               mm[4] = floor((random_generator.NextDouble()*70)+1);
               if (mm(4)!=mm(3) && mm(4)!=mm(2) && mm(4)!=mm(1))) break;
            }
            while (1)
            {
               mm[5] = floor((random_generator.NextDouble()*70)+1);
               if (mm(5)!=mm(4) && mm(5)!=mm(3) && mm(5)!=mm(2) && mm(5)!=mm(1))) break;
            }
            mChoice =mChoice-1;
            cout << "Your Mega Millions numbers are "+mm(1)+" "+mm(2)+" "+mm(3)+" "+mm(4)+" "+mm(5)+" "+m6+"." << endl;         }
      }
      else
      {
         if (mChoice==0)
         {
            pb[5] = 0;
            p6 =floor((random_generator.NextDouble()*26)+1);
            pb[1] = floor((random_generator.NextDouble()*69)+1);
            while (1)
            {
               pb[2] = floor((random_generator.NextDouble()*69)+1);
               if (pb(2)!=pb(1))) break;
            }
            while (1)
            {
               pb[3] = floor((random_generator.NextDouble()*69)+1);
               if (pb(3)!=pb(2) && pb(3)!=pb(1))) break;
            }
            while (1)
            {
               pb[4] = floor((random_generator.NextDouble()*69)+1);
               if (pb(4)!=pb(3) && pb(4)!=pb(2) && pb(4)!=pb(1))) break;
            }
            while (1)
            {
               pb[5] = floor((random_generator.NextDouble()*69)+1);
               if (pb(5)!=pb(4) && pb(5)!=pb(3) && pb(5)!=pb(2) && pb(5)!=pb(1))) break;
            }
            pChoice =pChoice-1;
            cout << "Your Powerball numbers are "+pb(1)+" "+pb(2)+" "+pb(3)+" "+pb(4)+" "+pb(5)+" "+p6+"." << endl;         }
         else
         {
            pb[5] = 0;
            p6 =floor((random_generator.NextDouble()*26)+1);
            pb[1] = floor((random_generator.NextDouble()*69)+1);
            while (1)
            {
               pb[2] = floor((random_generator.NextDouble()*69)+1);
               if (pb(2)!=pb(1))) break;
            }
            while (1)
            {
               pb[3] = floor((random_generator.NextDouble()*69)+1);
               if (pb(3)!=pb(2) && pb(3)!=pb(1))) break;
            }
            while (1)
            {
               pb[4] = floor((random_generator.NextDouble()*69)+1);
               if (pb(4)!=pb(3) && pb(4)!=pb(2) && pb(4)!=pb(1))) break;
            }
            while (1)
            {
               pb[5] = floor((random_generator.NextDouble()*69)+1);
               if (pb(5)!=pb(4) && pb(5)!=pb(3) && pb(5)!=pb(2) && pb(5)!=pb(1))) break;
            }
            pChoice =pChoice-1;
            cout << "Your Powerball numbers are "+pb(1)+" "+pb(2)+" "+pb(3)+" "+pb(4)+" "+pb(5)+" "+p6+"." << endl;            mm[5] = 0;
            m6 =floor((random_generator.NextDouble()*25)+1);
            mm[1] = floor((random_generator.NextDouble()*70)+1);
            while (1)
            {
               mm[2] = floor((random_generator.NextDouble()*70)+1);
               if (mm(2)!=mm(1))) break;
            }
            while (1)
            {
               mm[3] = floor((random_generator.NextDouble()*70)+1);
               if (mm(3)!=mm(2) && mm(3)!=mm(1))) break;
            }
            while (1)
            {
               mm[4] = floor((random_generator.NextDouble()*70)+1);
               if (mm(4)!=mm(3) && mm(4)!=mm(2) && mm(4)!=mm(1))) break;
            }
            while (1)
            {
               mm[5] = floor((random_generator.NextDouble()*70)+1);
               if (mm(5)!=mm(4) && mm(5)!=mm(3) && mm(5)!=mm(2) && mm(5)!=mm(1))) break;
            }
            mChoice =mChoice-1;
            cout << "Your Mega Millions numbers are "+mm(1)+" "+mm(2)+" "+mm(3)+" "+mm(4)+" "+mm(5)+" "+m6+"." << endl;         }
      }
      if (pChoice==0 && mChoice==0)) break;
   }
   pick2 =floor(random_generator.NextDouble()*100);
   pick3 =floor(random_generator.NextDouble()*1000);
   pick4 =floor(random_generator.NextDouble()*10000);
   pick5 =floor(random_generator.NextDouble()*100000);
   cout << "I hope you enjoyed my program. Good luck to you." << endl;   cout << "Here are some bonus numbers for Pick 2, 3, 4, and 5.   "+pick2+"... "+pick3+" ..."+pick4+"... "+pick5 << endl;   cout << "Have a great day." << endl;
   return 0;
}
