namespace MoloWorld
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please kindly insert a sentence");
            string userSentence = Console.ReadLine();

            int numberOfWords = LanguageFunctions.GetWordCountInSentence(userSentence);
            Console.WriteLine($"The amount of words in the sentence is {numberOfWords} .");
        }
    }
}
