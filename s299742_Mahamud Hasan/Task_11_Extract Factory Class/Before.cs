using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_ExtrctMethodObject
{
public class PoliceCarController
{
public PoliceCar New(int mileage, bool serviceRequired)
{
PoliceCar policeCar = new PoliceCar();
policeCar.ServiceRequired = serviceRequired;
policeCar.Mileage = mileage;

return policeCar;
 }
 }
}
