﻿// See https://aka.ms/new-console-template for more information
using System.Linq;

Stack<string> SpendStack = new Stack<string>();
Stack<string> DoStack = new Stack<string>();
Stack<string> StayStack = new Stack<string>();
Stack<string> MakeStack = new Stack<string>();
Stack<string> EatStack = new Stack<string>();
Stack<string> HaveStack = new Stack<string>();
Stack<string> GoStack = new Stack<string>();
Stack<string> ChatStack = new Stack<string>();

Stack<string> SpendStackAnswer = new Stack<string>();
SpendStackAnswer.Push("TIME WITH RELATIVES");

Stack<string> DoStackAnswer = new Stack<string>();
DoStackAnswer.Push("SOME EXERCISE");
DoStackAnswer.Push("HOMEWORK");
DoStackAnswer.Push("THE SHOPPING");
DoStackAnswer.Push("HOME WORK");
DoStackAnswer.Push("HOUSEWORK");

Stack<string> StayStackAnswer = new Stack<string>();
StayStackAnswer.Push("IN FOR THE EVENING");

Stack<string> MakeStackAnswer = new Stack<string>();
MakeStackAnswer.Push("FUTURE PLANS");
MakeStackAnswer.Push("A TO-DO LIST");

Stack<string> EatStackAnswer = new Stack<string>();
EatStackAnswer.Push("HEALTHY FOOD");

Stack<string> HaveStackAnswer = new Stack<string>();
HaveStackAnswer.Push("FUN");
HaveStackAnswer.Push("A LIE-IN");
HaveStackAnswer.Push("A GOOD TIME");
HaveStackAnswer.Push("A FAMILY MEAL");
HaveStackAnswer.Push("AN EARLY NIGHT");

Stack<string> GoStackAnswer = new Stack<string>();
GoStackAnswer.Push("ON A TRIP");
GoStackAnswer.Push("SHOPPING");
GoStackAnswer.Push("TO BED LATE");

Stack<string> ChatStackAnswer = new Stack<string>();
ChatStackAnswer.Push("WITH FRIENDS ONLINE");

string[] arrBucketOfWordsToBeSelected = new string[] 
{ 
    "TIME WITH RELATIVES",
    "SHOPPING",
    "HEALTHY FOOD",
    "SOME EXERCISE",
    "A LIE-IN",
    "A FAMILY MEAL",
    "HOUSEWORK",
    "IN FOR THE EVENING",
    "A GOOD TIME",
    "FUN",
    "AN EARLY NIGHT",
    "TO BED LATE",
    "ON A TRIP",
    "WITH FRIENDS ONLINE",
    "FUTURE PLANS",
    "A TO-DO LIST",
    "HOUSEWORK",
    "THE SHOPPING",
    "SOME WORK"
};

string[] categories = { "SPEND", "DO", "STAY", "MAKE", "EAT", "HAVE", "GO", "CHAT" };

Dictionary<string,string> dicSelectedWords = new Dictionary<string,string>();

void checkMyAnswers(Stack<string> StackToEvaluate, Stack<string> StackWithAnswers, string CategoryName)
{
    bool b = StackToEvaluate.Any();
    if (b)
    {
        foreach (var word in StackToEvaluate)
        {
            Console.Write("(B07_Daily_Life):");
            Console.Write(" You selected the category '" + CategoryName + "' for the word: ");
            Console.Write(word + ".");
            bool bb = StackWithAnswers.Where(x => x.Equals(word.Trim())).Any();

            if (bb) Console.WriteLine($"That answer is correct!.");
            else Console.WriteLine($"That answer is incorrec!.");
        }
    }
    else
    {
        Console.WriteLine("(B07_Daily_Life): The category '" + CategoryName + "' doesn't containt any word.");
    }

}

void SubmitAnswers()
{
    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

    checkMyAnswers(SpendStack, SpendStackAnswer, "SPEND");

    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

    checkMyAnswers(DoStack, DoStackAnswer, "DO");
 
    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

    checkMyAnswers(StayStack, StayStackAnswer, "STAY");

    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

    checkMyAnswers(MakeStack, MakeStackAnswer, "MAKE");

    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

    checkMyAnswers(EatStack, EatStackAnswer, "EAT");

    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

    checkMyAnswers(HaveStack, HaveStackAnswer, "HAVE");

    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

    checkMyAnswers(GoStack, GoStackAnswer, "GO");

    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

    checkMyAnswers(ChatStack, ChatStackAnswer, "CHAT");

    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
}

void shorcut()
{
    //JLopez-25082023: This method was done to test quickly the submition of anwsers.
    SpendStack.Push("TIME WITH RELATIVES");
    HaveStack.Push("HOMEWORK");
    SpendStack.Push("THE SHOPPING");
    DoStack.Push("SOME EXERCISE");
    DoStack.Push("HOME WORK");
    GoStack.Push("HOUSEWORK");
    EatStack.Push("IN FOR THE EVENING");
    MakeStack.Push("FUTURE PLANS");
    MakeStack.Push("A TO-DO LIST");
    EatStack.Push("HEALTHY FOOD");
    HaveStack.Push("FUN");
    GoStack.Push("A LIE-IN");
    ChatStack.Push("A GOOD TIME");
    HaveStack.Push("A FAMILY MEAL");
    HaveStack.Push("AN EARLY NIGHT");
    DoStack.Push("ON A TRIP");
    GoStack.Push("SHOPPING");
    GoStack.Push("TO BED LATE");
    ChatStack.Push("WITH FRIENDS ONLINE");
    arrBucketOfWordsToBeSelected = new string[] { };
}

void AsignecategoryForEachWord(string word,string category)
{
    switch (category)
    {
        case "SPEND":   SpendStack.Push(word);  break;
        case "DO":      DoStack.Push(word);     break;
        case "STAY":    StayStack.Push(word);   break;
        case "MAKE":    MakeStack.Push(word);   break;
        case "EAT":     EatStack.Push(word);    break;
        case "HAVE":    HaveStack.Push(word);   break;
        case "GO":      GoStack.Push(word);     break;
        case "CHAT":    ChatStack.Push(word);   break;
        default:                                break;
    }

    //JLopez: Removing the element from the initial array
    arrBucketOfWordsToBeSelected = arrBucketOfWordsToBeSelected.Where((x) => x != word).ToArray();
}

bool checkWordsAndCategory(string category, string word = "")
{
    bool bWord = false;
    bool bCategory = false;

    bWord = arrBucketOfWordsToBeSelected.Any(x => x.Equals(word));
    bCategory = categories.Any(x => x.Equals(category));

    if (!bWord && word != "") 
    {
        Console.Clear();
        Console.WriteLine("(B07_Daily_Life): The word that you entered isn't a valid word. Please enter a valid word to continue.");
        Console.WriteLine("(B07_Daily_Life): Press any key to continue...");
        Console.ReadLine();
        Console.Clear();

        return false;
    }
    else if (!bCategory) 
    { 
        Console.Clear();
        Console.WriteLine("(B07_Daily_Life): The category that you entered isn't a valid category. Please enter a valid category to continue.");
        Console.WriteLine("(B07_Daily_Life): Press any key to continue...");
        Console.ReadLine();
        Console.Clear();
        return false;
    }
    else
    {
        return true;
    }
}

void UndoCategorizateWord(string category)
{
    string aux = "";
    int i = 0;

    switch (category)
    {
        case "SPEND":   aux = SpendStack.Pop();     break;
        case "DO":      aux = DoStack.Pop();        break;
        case "STAY":    aux = StayStack.Pop();      break;
        case "MAKE":    aux = MakeStack.Pop();      break;
        case "EAT":     aux = EatStack.Pop();       break;
        case "HAVE":    aux = HaveStack.Pop();      break;
        case "GO":      aux = GoStack.Pop();        break;
        case "CHAT":    aux = ChatStack.Pop();      break;
        default: break;
    }

    //JLopez: Add the element from the stack to the array
    i = arrBucketOfWordsToBeSelected.Length + 1;

    //Jlopez: I Resize it because I need an extra position to put the new word? because removed it before reduce the lenght of the Array¿¿¿¿????
    Array.Resize(ref arrBucketOfWordsToBeSelected, i);
    arrBucketOfWordsToBeSelected[i-1] = aux;
}

Console.Title = "<<<<<<<<<< Daily life >>>>>>>>>>>>>";
Console.BackgroundColor = ConsoleColor.DarkBlue;

Console.WriteLine("(B07_Daily_Life): Welcome back to this game!.");
Console.WriteLine("(B07_Daily_Life): Creation date:         07/08/2023.");
Console.WriteLine("(B07_Daily_Life): Modification date:     20/08/2023.");
Console.WriteLine("(B07_Daily_Life): Author:                Jesus Lopez.");
Console.WriteLine("(B07_Daily_Life): Linkedin:              https://www.linkedin.com/in/susejzepol/");
Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("(B07_Daily_Life): This game is a copy of the game: https://wordwall.net/resource/53435588/daily-life-navigate-b07-unit-1");
Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("(B07_Daily_Life): Let's begin. ");

string iWord = string.Empty;
string iCategoy = string.Empty;
int iNum = 1;

do
{
    string words = string.Empty;
    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    Console.WriteLine("(B07_Daily_Life): The words to be selected are:");
    Console.Write("(B07_Daily_Life): ");

    foreach (var i in arrBucketOfWordsToBeSelected)
    {
        words += i + ", ";
    }

    if (words.Length > 0)
    {
        words = words.Substring(0, words.Length - 2) + ".";
        Console.WriteLine(words);

        Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    }

    Console.WriteLine("(B07_Daily_Life): The valid categories are:");
    
    words = " [ ";

    Console.Write("(B07_Daily_Life): SPEND");
    foreach(var w in SpendStack) words += w + ",";
    words = words.Substring(0, words.Length - 1);
    Console.WriteLine(words + " ].");

    words = " [ ";
    Console.Write("(B07_Daily_Life): DO");
    foreach (var w in DoStack) words += w + ",";
    words = words.Substring(0, words.Length - 1);
    Console.WriteLine(words + " ].");

    words = " [ ";
    Console.Write("(B07_Daily_Life): STAY");
    foreach (var w in StayStack) words += w + ",";
    words = words.Substring(0, words.Length - 1);
    Console.WriteLine(words + " ].");

    words = " [ ";
    Console.Write("(B07_Daily_Life): MAKE");
    foreach (var w in MakeStack) words += w + ",";
    words = words.Substring(0, words.Length - 1);
    Console.WriteLine(words + " ].");

    words = " [ ";
    Console.Write("(B07_Daily_Life): EAT");
    foreach (var w in EatStack) words += w + ",";
    words = words.Substring(0, words.Length - 1);
    Console.WriteLine(words + " ].");

    words = " [ ";
    Console.Write("(B07_Daily_Life): HAVE");
    foreach (var w in HaveStack) words += w + ",";
    words = words.Substring(0, words.Length - 1);
    Console.WriteLine(words + " ].");

    words = " [ ";
    Console.Write("(B07_Daily_Life): GO");
    foreach (var w in GoStack) words += w + ",";
    words = words.Substring(0, words.Length - 1);
    Console.WriteLine(words + " ].");

    words = " [ ";
    Console.Write("(B07_Daily_Life): CHAT");
    foreach (var w in ChatStack) words += w + ",";
    words = words.Substring(0, words.Length - 1);
    Console.WriteLine(words + " ].");

    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

    Console.WriteLine("(B07_Daily_Life): What will you do?");
    Console.WriteLine("(B07_Daily_Life): (1) Enter a new word in a category.");
    Console.WriteLine("(B07_Daily_Life): (2) Remove a word in a category.");
    Console.WriteLine("(B07_Daily_Life): (3) Submit Answers.");
    Console.WriteLine("(B07_Daily_Life): (4) Exit the game.");

    bool success = int.TryParse(Console.ReadLine(), out iNum);

    if (success)
    {
        if (iNum == 1)
        {
            Console.WriteLine("(B07_Daily_Life): Please, select a valid word to asociate it to a valid category.");
            iWord = Console.ReadLine().ToUpper();

            Console.WriteLine("(B07_Daily_Life): Please, select a valid category.");
            iCategoy = Console.ReadLine().ToUpper();

            if (checkWordsAndCategory(iCategoy, iWord)) AsignecategoryForEachWord(iWord, iCategoy);
        }
        else if (iNum == 2)
        {
            Console.WriteLine("(B07_Daily_Life): Please, select a valid category.");
            iCategoy = Console.ReadLine().ToUpper();

            if (checkWordsAndCategory(iCategoy)) UndoCategorizateWord(iCategoy);
        }
        else if (iNum == 3)
        {
            Console.Clear();
            Console.WriteLine("(B07_Daily_Life): Ready to submit your answers.");
            SubmitAnswers();
            Console.WriteLine("(B07_Daily_Life): Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }else if (iNum == 100)
        {
            //JLopez-25082023: This method was done to test quickly the submition of anwsers.
            shorcut();
        }
        Console.Clear();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("(B07_Daily_Life): The option that you entered isn't a valid number. Please enter a valid number from 1 to 3 to continue.");
        Console.WriteLine("(B07_Daily_Life): Press any key to continue...");
        Console.ReadLine();
        Console.Clear();
    }

} while(iNum != 4);