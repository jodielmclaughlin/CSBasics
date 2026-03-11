using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSBasics
{
    internal class Book
    {
        public string Title { get; }
        public int Pages { get;  }

        public int CurrentPage { get; private set;  }

        //constructor
        public Book(string title, int pages)
        { 
            Title = title; 
            Pages = pages;
            CurrentPage = 1;
            
        }

        public void TurnPage()
        {
            if (CurrentPage < Pages)
            {
                CurrentPage++;
            }
           
        }
        
    }
   
}
