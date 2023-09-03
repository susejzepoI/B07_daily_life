// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;

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
double curent_score = 0;
DateTime begin;
DateTime end;
void spendtTime(int diff)
{
    Console.WriteLine("(B07_Daily_Life): You started the game at: " + begin.ToString());
    Console.WriteLine("(B07_Daily_Life): You Ended the game at: " + end.ToString());
    Console.WriteLine("(B07_Daily_Life): You've took {0} seconds to ended the game.", diff);

    if( diff < 60)

    {
        curent_score += 10000;
        Console.WriteLine("(B07_Daily_Life): You've won 10000 points for ended the game in less than 60 seconds.");
    }
    else if (diff >= 60 && diff < 120)
    {
        curent_score += 5000;
        Console.WriteLine("(B07_Daily_Life): You've won 5000 points for ended the game in less than 120 seconds.");
    }
    else if (diff >= 120 && diff < 240)
    {
        curent_score += 3000;
        Console.WriteLine("(B07_Daily_Life): You've won 3000 points for ended the game in less than 240 seconds.");
    }
    else if (diff >= 240 && diff < 300)
    {
        curent_score += 1000;
        Console.WriteLine("(B07_Daily_Life): You've won 1000 points for ended the game in less than 300 seconds.");
    }
    else if (diff >= 300 && diff < 400)
    {
        curent_score += 500;
        Console.WriteLine("(B07_Daily_Life): You've won 500 points for ended the game in less than 400 seconds.");
    }
    else
    {
        curent_score += 5;
        Console.WriteLine("(B07_Daily_Life): You've won 5 points for ended the game.");
    }
}

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
            Console.Write($"That answer is ");
            if (bb)
            {
                curent_score += 1;
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine($"correct! (1P).");     
            }
            else
            {
                curent_score -= 0.5;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"incorrec!. (-0.5P).");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    else
    {
        Console.WriteLine("(B07_Daily_Life): The category '" + CategoryName + "' doesn't containt any word.");
    }

}

void SubmitAnswers()
{
    end = DateTime.Now;

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
    
    var diff = (end - begin).Seconds;
    
    spendtTime(diff);

    Console.WriteLine("(B07_Daily_Life): You've achieved {0} points on {1} seconds.",curent_score,diff);
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

Console.Title = "<<<<< Daily life >>>>>";
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("(B07_Daily_Life): Welcome back to this game!.");
Console.WriteLine("(B07_Daily_Life): Creation date:         07/08/2023.");
Console.WriteLine("(B07_Daily_Life): Modification date:     02/09/2023.");
Console.WriteLine("(B07_Daily_Life): Author:                Jesus Lopez.");
Console.WriteLine("(B07_Daily_Life): Linkedin:              https://www.linkedin.com/in/susejzepol/");
Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("(B07_Daily_Life): This game is a copy of the game: https://wordwall.net/resource/53435588/daily-life-navigate-b07-unit-1");
Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("(B07_Daily_Life): Let's begin. ");

string iWord = string.Empty;
string iCategoy = string.Empty;
string sOption = string.Empty;

void showTheWordsAndCategories()
{
    string words = string.Empty;
    Console.WriteLine("(B07_Daily_Life): >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    Console.WriteLine("(B07_Daily_Life): The words to be selected are:");
    Console.WriteLine("(B07_Daily_Life): ");

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
    foreach (var w in SpendStack) words += w + ",";
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
    Console.WriteLine("(B07_Daily_Life): (a) Enter a new word in a category.");
    Console.WriteLine("(B07_Daily_Life): (b) Remove a word in a category.");
    Console.WriteLine("(B07_Daily_Life): (c) Submit Answers.");
    Console.WriteLine("(B07_Daily_Life): (d) Save score.");
    Console.WriteLine("(B07_Daily_Life): (e) Show scores.");
    Console.WriteLine("(B07_Daily_Life): (x) Exit the game.");
}

try {

    begin = DateTime.Now;

    do
    {
        showTheWordsAndCategories();
        sOption = Console.ReadLine().ToLower();


        if (sOption == "a")
        {
            Console.WriteLine("(B07_Daily_Life): Please, select a valid word to asociate it to a valid category.");
            iWord = Console.ReadLine().ToUpper();

            Console.WriteLine("(B07_Daily_Life): Please, select a valid category.");
            iCategoy = Console.ReadLine().ToUpper();

            if (checkWordsAndCategory(iCategoy, iWord)) AsignecategoryForEachWord(iWord, iCategoy);
        }
        else if (sOption == "b")
        {
            Console.WriteLine("(B07_Daily_Life): Please, select a valid category.");
            iCategoy = Console.ReadLine().ToUpper();

            if (checkWordsAndCategory(iCategoy)) UndoCategorizateWord(iCategoy);
        }
        else if (sOption == "c")
        {
            Console.Clear();
            Console.WriteLine("(B07_Daily_Life): Ready to submit your answers.");
            SubmitAnswers();
            Console.WriteLine("(B07_Daily_Life): Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        else if (sOption == "d")
        {

        }
        else if (sOption == "e")
        {

        }
        else if (sOption == "<")
        {
            //JLopez-25082023: This method was done to test quickly the submition of anwsers.
            shorcut();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("(B07_Daily_Life): The option that you entered isn't valid. Please enter a valid option from the menu to continue.");
            Console.WriteLine("(B07_Daily_Life): Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        Console.Clear();
    } while (sOption != "x");
}
catch(InvalidCastException ecast) {

    Console.WriteLine("(B07_Daily_Life): ERROR: " + ecast.Message);
}
catch(Exception e)
{
    Console.WriteLine("(B07_Daily_Life): ERROR: " + e.Message);
}

