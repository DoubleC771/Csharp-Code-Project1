/*Here are the conditions that your first coding project must implement:

Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.*/

string? readResult;
bool validNumber = false;
int numericValue = 0;

Console.WriteLine("Enter a number between 5 and 10:");
do
{
    readResult = Console.ReadLine();
    //capture user input in a string variable to convert to int 
    validNumber = int.TryParse(readResult, out numericValue);

        if (validNumber)
            if (numericValue >= 5 && numericValue <= 10)
            {
                Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
                validNumber = true;
            }
            else
            {
                Console.WriteLine($"You Entered {numericValue}. Please enter a number between 5 and 10.");      
                validNumber = false;
            }                
        else
           Console.WriteLine("Your input is invalid, please try again.");
}
while (!validNumber);