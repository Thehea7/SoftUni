using System.ComponentModel.DataAnnotations;

namespace _03.Articles2
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
       
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            
            
            int commands = int.Parse(Console.ReadLine());
            List<Article> listOfArticles = new List<Article>();
            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                Article article = new Article(input[0], input[1], input[2]);
                listOfArticles.Add(article);
            }
            foreach (Article article in listOfArticles)
            {
            Console.WriteLine(article);
            }
        }
    }
}