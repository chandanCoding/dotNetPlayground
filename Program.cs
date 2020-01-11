using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ConsoleSketch
{
    public class MySketch
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Beginning Execution...");
            SketchModel output = TestAnonymous();
            var JsonRes = JsonSerializer.Serialize(output);
            Console.WriteLine(JsonRes);
            Console.WriteLine("Processing Successful");
        }
        public static SketchModel TestAnonymous()
        {
            List<object> MyList1 = new List<object>();
            List<object> MyList2 = new List<object>();
            List<object> MyList3 = new List<object>();
            MyList1.Add("MyValue1");
            MyList2.Add("MyValue2");
            MyList3.Add("MyValue3");

            return new SketchModel()
            {
                MyList1 = MyList1,
                MyList2 = MyList2,
                MyList3 = MyList3,
                AnonymousBoolean = true
            };
        }
    }
}
