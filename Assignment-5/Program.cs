﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateList a = new GenerateList();
            a.Run(57);
        }
    }
    class GenerateList
    {
        const int LEN = 100;
        ArrayList ListQ;

        public void Run(int AddUptoNumber)
        {
            Random r = new Random();

            ListQ = new ArrayList();
           
            for(int i = 0; i < LEN; i++)
            {
                ListQ.Add(r.Next(100));
                this.findTwoNumbersThatAddUpTo(AddUptoNumber);
            }
        }
        public void findTwoNumbersThatAddUpTo(int a)
        {
            
        }
    }
}
