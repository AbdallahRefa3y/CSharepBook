using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace InheritanceArticle
{
    public class Automobile
    {
        public Automobile(string make, string model, int year)
        {
            if (make == null)
                throw new ArgumentNullException("The make cannot be null.");
            else if (String.IsNullOrWhiteSpace(make))
                throw new ArgumentException("make cannot be an empty string or have space characters only.");
            Make = make;

            if (model == null)
                throw new ArgumentNullException("The model cannot be null.");
            else if (String.IsNullOrWhiteSpace(model))
                throw new ArgumentException("model cannot be an empty string or have space characters only.");
            Model = model;

            if (year < 1857 || year > DateTime.Now.Year + 2)
                throw new ArgumentException("The year is out of range.");
            Year = year;
        }

        public string Make { get; }

        public string Model { get; }

        public int Year { get; }

        public override string ToString() => $"{Year} {Make} {Model}";
    }


    public class SimpleClass
    { }

    public class A
    {
        private int value = 10;

        public class B : A
        {
            public int GetValue()
            {
                return this.value;
            }
        }
    }

    public class C : A
    { }


    class Program
    {
        static void Main(string[] args)
        {
            var b = new A.B();
            Console.WriteLine(b.GetValue());


            /////////////////////////////////////////

            Type t = typeof(SimpleClass);
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public |
                                 BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
            MemberInfo[] members = t.GetMembers(flags);
            Console.WriteLine($"Type {t.Name} has {members.Length} members: ");
            foreach (var member in members)
            {
                string access = "";
                string stat = "";
                var method = member as MethodBase;
                if (method != null)
                {
                    if (method.IsPublic)
                        access = " Public";
                    else if (method.IsPrivate)
                        access = " Private";
                    else if (method.IsFamily)
                        access = " Protected";
                    else if (method.IsAssembly)
                        access = " Internal";
                    else if (method.IsFamilyOrAssembly)
                        access = " Protected Internal ";
                    if (method.IsStatic)
                        stat = " Static";
                }
                var output = $"{member.Name} ({member.MemberType}): {access}{stat}, Declared by {member.DeclaringType}";
                Console.WriteLine(output);
            }

            /////////////////////////////////////////

            var packard = new Automobile("Packard", "Custom Eight", 1948);
            Console.WriteLine(packard);
        }
    }
}
