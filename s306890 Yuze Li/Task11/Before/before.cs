public class VendingMachineService
 {
	 private bool VendingMachineEmpty { get; set; }

	 public void Replenish()
	 {
		 if (VendingMachineEmpty)
		 Worker.ReplenishIteam();
	
		 // more code to replenish the Vending Machine
	 }
 }

 public static class Worker
 {
	 public static void ReplenishIteam()
	 {
		 // fill up the Vending Machine
	 }
 }