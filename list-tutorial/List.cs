
namespace ListTutorial{
    class List{

        public void AddBot(string botname, List<string> names){
            int i = names.Count();
            names.Add("Maria");
            names.Add("Bill");
            names.Add("Ana");
            Console.WriteLine(" \n");
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"\nMy name is {botname}");
            Console.WriteLine($"I've added {names[i]}, {names[i+1]} and {names[i+2]} to the list");
            Console.WriteLine($"The list has {names.Count} people in it");        }
        public void WhereIs(string name, List<string> names){
            var index = names.IndexOf(name);
            if (index == -1){
                Console.WriteLine($"\nWhen an item is not found, IndexOf returns {index}\n");
            }
            else{
                Console.WriteLine($"\nThe name {names[index]} is at index {index}\n");
            }
        }

        public void PrintSortedList(List<string> names){
            names.Sort();
            foreach (var name in names){
                Console.WriteLine($"Hello {name}");
            }
        }


        public static void Main(string[] args){
            List mylist = new List();
            string myname = "Bea";
            var names = new List<string> { myname , "Ana", "Felipe" };
            foreach (var name in names){
                Console.WriteLine($"Hello {name}!");
            }
            mylist.AddBot(myname, names);
            mylist.WhereIs("Felipe", names);
            mylist.WhereIs("Not Found", names);

            mylist.PrintSortedList(names);

        }
    }
}
