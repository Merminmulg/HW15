using System;
using System.Collections.Generic;
using System.Text;

namespace hw15
{
    class ArticleList
    {
        public List<Article> Articles { get; set; }
        public ArticleList()
        {

        }
        public ArticleList(Article article)
        {
            Articles = new List<Article>();
            Articles.Add(article);
        }
        public void ArticleAdd(Article article)
        {
            try
            {
                Articles.Add(article);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "ArticleAddError", nameof(article));
            }
        }
        public void ArticleLogOut()
        {
            try
            {
                foreach(Article a in Articles)
                {
                    Console.WriteLine($"{a.Name}  ---  {a.Id}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message, "ArticleLogOut");
            }
        }
        //public Article FindArticlesByName()
        //{
        //    //ArticleList.
        //    //return 
        //}
    }
}
