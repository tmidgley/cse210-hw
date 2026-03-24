class Program
{
    static void Main(string[] args)
    /*ADDED MULTIPLE SCRIPTURES AND RANDOMLY SELECTS ONE*/
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(new Reference("Moses", 1, 39), "For behold this is my work and my glory to bring to pass the immortality and eternal life of man"
        ));

        scriptures.Add(new Scripture(new Reference("Matthew", 5, 14, 16), "Ye are the light of the world a city that is set on an hill cannot be hid Let your light so shine before men that they may see your good works and glorify your Father which is in heaven"
        ));

        scriptures.Add(new Scripture(new Reference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way for them that they may accomplish the thing which he commandeth them"
        ));

        scriptures.Add(new Scripture(new Reference("Doctrine and Covenants", 1, 37, 38), "Search these commandments for they are true and faithful and the prophecies and promises which are in them shall all be fulfilled What I the Lord have spoken I have spoken and I excuse not myself and though the heavens and the earth pass away my word shall not pass away but shall all be fulfilled whether by mine own voice or by the voice of my servants it is the same"
        ));

        Random random = new Random();
        int index = random.Next(scriptures.Count);

        Scripture scripture = scriptures[index];

        string input = "";

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram ended.");
    }
}