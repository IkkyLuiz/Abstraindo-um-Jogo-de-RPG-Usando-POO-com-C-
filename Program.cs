﻿using System;
using dotnet.src.Models;

namespace dotnet__poo

{
class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Knight("Arus",23, "Knight");
         Wizard wizard = new Wizard("Jenica",23, "White Wizard");
     
    Console.WriteLine(wizard.Attack(1));
    Console.WriteLine(wizard.Attack(7));
    }
}

}
