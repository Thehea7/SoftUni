using System.ComponentModel.DataAnnotations;

namespace _02.Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(input[0], input[1], input[2]);
            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string[] command = Console.ReadLine().Split(": ").ToArray();
                string newContent = command[1];
                string order = command[0];
                if (order == "Edit")
                {
                    article.Edit(newContent);
                }
                else if (order == "ChangeAuthor")
                {
                    article.ChangeAuthor(newContent);
                }
                else if(order == "Rename")
                {
                    article.Rename(newContent);
                }
            }
            Console.WriteLine(article);
        }
    }
}