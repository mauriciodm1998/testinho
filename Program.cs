using System;
using System.Collections.Generic;
using System.Linq;
using ProjBalta.ContentContext;
using ProjBalta.SubscriptionContext;

namespace ProjBalta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("POO", "orientacao-objeto"));
            articles.Add(new Article("C#", "csharp"));
            articles.Add(new Article("Dotnet", "dotnet"));
            
            foreach(var article in articles)
            {
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            
            var courseOOP = new Course("Fundamentos csharp", "fundamentos-csharp");
            var courseCsharp = new Course("Fundamentos csharp", "fundamentos-csharp");
            var courseAsp = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAsp);

            var careers = new List<Career>();
            var careerdotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(2, "aprenda OOP", "", courseOOP);
            var careerItem2 = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "aprenda .NET", "", courseAsp);
            
            careerdotnet.Items.Add(careerItem2);
            careerdotnet.Items.Add(careerItem);
            careerdotnet.Items.Add(careerItem3);
           
            careers.Add(careerdotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderBy(x=> x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach(var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);

        }
    }
}
