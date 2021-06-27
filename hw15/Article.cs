using System;
using System.Collections.Generic;
using System.Text;

namespace hw15
{
    class Article
    {
        public string Name { get; set;}
        public int Id { get; set; }
        public Article()
        {

        }
        public Article(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
    }
}
