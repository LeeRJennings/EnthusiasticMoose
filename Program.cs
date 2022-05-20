using System;

Main();

void Main()
{
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

MooseSays("H I, I'M  E N T H U S I A S T I C !");
// MooseSays("I really am enthusiastic");

QuestionToAsk("Is it Friday?", "HOORAY FRIDAY!!!", "Wrong. Right to jail.");
QuestionToAsk("Is it actually Friday?", "I  K N E W  I T", "Enthusiastic Moose is now Authoritarian Moose. Right to jail.");
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): "); //asks the question passed into the function 
    string answer = Console.ReadLine().ToLower(); //stores the answer in a variable

    while (answer != "y" && answer != "n") //while the answer is neither y or n does the same as above
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y") //returns true when the answer is y
    {
        return true;
    }
    else //returns false when the answer is n
    {
        return false;
    }
}

void QuestionToAsk(string question, string answerYes, string answerNo)
{
    bool questionBool = MooseAsks(question);
    if (questionBool)
    {
        MooseSays(answerYes);
    }
    else 
    {
        MooseSays(answerNo);
    }
}