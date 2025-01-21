// https://www.youtube.com/playlist?list=PL82C6-O4XrHcblXkHA4dLcnb_ipVkKHch










// See https://aka.ms/new-console-template for more information
using System.Text;
using consoleApp;

Console.WriteLine("Hello, World!");

// //String>>>
// //create
// string name="sarthak";
// //concatenation
// name="i am "+ name;
// //read
// Console.WriteLine($"hello,{name}");
// //update
// string newname=name.Replace("am","Good morning");
// Console.WriteLine($"{newname}");
// //delete
// StringBuilder delname=new StringBuilder();
// delname.Append("saruthukudesu");
// Console.WriteLine(delname);
// delname.Remove(0,4);
// Console.WriteLine(delname);




// //Array>>>
// //create
// string[] names=["sarthak","saru","abc"];
// //read
// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }
// //update
// names[0]="SAARTHAK";
// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }
// var newname=names.Where((e)=>e.StartsWith("a"));
// foreach (var name in newname)
// {
//     Console.WriteLine(name);
// }




// //for loop>>>
// for(var i=0; i<10;i++){
//     Console.WriteLine(i);
// }
// string[] names=["sarthak","saru","abc"];
// for (var j=0; j<names.Length;j++){
//     Console.WriteLine(names[j]);
// }
// foreach (var name in names)
// {
//     Console.WriteLine("foreach:"+name);
// }
// names.ToList().ForEach((e)=>{
//     Console.WriteLine("ToList_foreach:"+e);
// });
// Array.ForEach(names,f=>Console.WriteLine("Array_Foreach:"+f));




//if-else>>>



// //enum>>>
// Console.WriteLine((int)Color.Green);
// enum Color {Red,Green,Blue};



// //switch-case>>>
// int number=5;
// switch (number)
// {
//     case 1:
//         Console.WriteLine("one");
//         break;
//     case 2:
//         Console.WriteLine("two");
//         break;
//     case 3:
//         Console.WriteLine("three");
//         break;
//     default:
//         Console.WriteLine("default");
//         break;
// }
// string str="sart";
// var result= str switch{
//     "sart"=> "GOTCHA",
//     "saru"=> "NO NO",
//     _=> "default"
// };
// Console.WriteLine(result);




// //OOP>>>
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// namespace consoleApp
// {
//     public class rat
//     {
//         public string name { get; set; }
//         public int number { get; set; }
//         public bool alive { get; set; }
//     }
// }
// //create
// rat wolfRat= new rat();
// wolfRat.name="wolf";
// wolfRat.number=5;
// wolfRat.alive=false;
// rat fancyRat= new rat();
// fancyRat.name="fancy";
// fancyRat.number=15;
// fancyRat.alive=true;
// //read
// Console.WriteLine(wolfRat.name);
// Console.WriteLine(fancyRat.name);
// //update
// wolfRat.name="wolfy";
// Console.WriteLine(wolfRat.name);
// //delete
// wolfRat.name="";
// Console.WriteLine(wolfRat.name);







// //Mehods>>>




// //Tuples>>>
// var value = ("1", "a", "b");
// Console.WriteLine(value.Item1);
// Console.WriteLine(value.Item2);
// Console.WriteLine(value.Item3);

// var values = (First: 1, Second: "ab");
// Console.WriteLine(values.First);
// Console.WriteLine(values.Second);

// (int x, string y) returnValues()
// {
//     return (1, "a");
// }
// Console.WriteLine(returnValues().x);
// Console.WriteLine(returnValues().y);

