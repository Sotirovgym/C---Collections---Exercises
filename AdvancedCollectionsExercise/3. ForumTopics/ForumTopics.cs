using System;
using System.Collections.Generic;
using System.Linq;

class ForumTopics
{
    static void Main()
    {
        var forumTopics = new Dictionary<string, HashSet<string>>();
        var tags = new List<string>();

        while (true)
        {
            var inputData = Console.ReadLine();

            if (inputData == "filter")
            {
                inputData = Console.ReadLine();
                var token = inputData.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < token.Length; i++)
                {
                    tags.Add("#" + token[i]);
                    
                }

                break;
            }

            var tokens = inputData.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var forum = tokens[0];

            if (! forumTopics.ContainsKey(forum))
            {
                forumTopics[forum] = new HashSet<string>();
            }

            for (int i = 1; i < tokens.Length; i++)
            {
                forumTopics[forum].Add("#" + tokens[i]);
            }
        }

        foreach (var keyValue in forumTopics)
        {
            var forums = keyValue.Key;
            var topics = keyValue.Value;
            var count = 0;

            for (int i = 0; i < tags.Count; i++)
            {
                if (topics.Contains(tags[i]))
                {
                    count++;

                    if (count == tags.Count)
                    {
                        Console.WriteLine($"{forums} | {string.Join(", ", topics)}");
                        break;
                    }
                }
            }
        }
    }
}

