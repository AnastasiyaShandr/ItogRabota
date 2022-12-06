// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string text = "hello, 2, world, :)";
string[] array = text.Split(" ");
string[] newArray = new string[array.Length];
