namespace ReadingFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = args[0];
            string searchWord = args[1];
             
            string fileContent = File.ReadAllText(filePath);

            int count = 0;
            int index = fileContent.IndexOf(searchWord);
            while (index != -1)
            {
                count++;
                index = fileContent.IndexOf(searchWord, index + searchWord.Length);
            }

            Console.WriteLine($"Count of '{searchWord}' in the file : {count}");
        }
    }
}
