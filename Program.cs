using System;

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

MooseSays("H I, I'M  E N T H U S I A S T I C !");
// MooseSays("I really am enthusiastic");

CanadaQuestion();
EnthusiasticQuestion();
LoveCSharpQuestion();
DavosQuestion();

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

void CanadaQuestion() 
{
    bool isTrue = MooseAsks("Is Canada Real?");
    if (isTrue)
    {
        MooseSays("Really? it seems unlikely.");
    }
    else
    {
        MooseSays("I  K N E W  I T !!!");
    }
}

void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("What a jabroni.");
    }
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}

void DavosQuestion()
{
    bool isDavosCute = MooseAsks("Is Ser Lady Davos the cutest cat you ever did see?");
    if (isDavosCute)
    {
        MooseSays("You're damn right she is!!");
    }
    else 
    {
        MooseSays("Wrong, right to jail.");
    }
}