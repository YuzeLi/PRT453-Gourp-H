using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateConditional
{
   1: public class RemoteControl
2: {
3: private string[] Functions { get; set; }
4: private string Name { get; set; }
5: private int CreatedYear { get; set; }
6:
7: public string PerformCoolFunction(string buttonPressed)
8: {
9: // Determine if we are controlling some extra function
10: // that requires special conditions
11: if (Functions.Length > 1 && Name == "RCA" &&
CreatedYear > DateTime.Now.Year - 2)
12: return "doSomething";
13: }
14: }
}