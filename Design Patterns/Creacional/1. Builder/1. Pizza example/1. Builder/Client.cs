﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Builder
{/// <remark>
/// pass that class a waiter and we will use him to construct pizza and write it
/// </remarks>
    public class Client
    {
        /// <summary>
        /// Simple method
        /// </summary>
        /// <param name="waiter">Returns waiter</param>
        public static void BuildAndDisplayPizza(Waiter waiter)
        {
            waiter.ConstructPizza();
            System.Console.WriteLine(waiter.Pizza);
        }
    }
}
