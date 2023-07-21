﻿using System;

namespace Store
{ 
    public class Book
    {
        public int ID { get; }

        public string Title { get; }

        public Book(int id, string title) 
        {
            ID = id;
            Title = title;
        }
    }

}

