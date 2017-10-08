using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation
{
    class Program
    {

        static void Main(string[] args)
        {
            ISerializer serializer;
            var format = Console.ReadLine();
            var data = Console.ReadLine();
            if(format=="Xml") 
                serializer = new XmlSerializer();
            else
                serializer = new JsonSerializer();
            var input = serializer.Deserialize<Input>(data);
            var output = new Output
            {
                SumResult = input.K*input.Sums.Sum()
            };
            output.MulResult = 1;
            foreach (var mul in input.Muls)
            {
                output.MulResult *= mul;
            }
            output.SortedInputs = input.Sums.Concat(input.Muls.Select(x => (decimal) x)).ToArray();
            Array.Sort(output.SortedInputs);
            Console.WriteLine(serializer.Serialize(output).Replace(Environment.NewLine, "").Replace(" ",""));
        }
    }
}
