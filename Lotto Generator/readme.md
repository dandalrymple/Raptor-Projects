The new Lotto Generator fixes problems of the old one.

Both versions let you pick numbers for both Powerball and Mega Millions, and choose the number of instances that you can run it.

The old version didn't have a way to check for duplicate numbers.

The new version does, and I have a bonus at the end of choosing a set of Pick 2, 3, 4, and 5 numbers, so even if you don't want PB or MM numbers, you're still going to get something. I haven't put in an option for how many of those numbers to run, but then I figure (and maybe wrongly so) that people tend to just use one set of numbers on those games.

The way the numbers are picked is like this - an array of 5 gets initialized to zeroes. The 6th number gets picked and saved right off the bat. The first number in the index is also picked because there's no chance for it to be a dupe. Then For each number, a check is done, and the check is different. For number 2, it only needs to check vs. the first index value. For number 3, it has to check vs. index values 2 and 1. **Note: Raptor starts its indexes at 1, don't blame me if you don't like it

So I just do that for the 5 numbers - it's just a yes/no check on down the line. Is the second value not equal to the first? IF yes, continue to find number 3, if no, reroll. For the 5th value, it asks if Value 5 is not equal to Value 4 and is Value 5 not equal to Value 3, and so on, still in one big 'yes/no'.

Then you can decrement the value for how many times the user wants that part of the program to run, and print out their numbers.

That's basically how it goes. 

After testing the Pick 2 and etc.,  I realized I'd goofed up a little by just trying to generate a random number between 0 and X, like 0 and 100K for the pick 5. You can end up with a smaller number of digits than the digits you're trying to pick.

It would be easier to generate numbers between 0 and 9 and concatenate them at the end. I'm going to fix that now.

Fixed. The "new lotto generator with pick numbers" is the fixed version.


