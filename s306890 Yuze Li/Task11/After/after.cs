public class VendingMachineService
	 {
		 public WorkerService WorkerService { get; set; }
	
		 public VendingMachineService(IWorkerService workerService)
		 {
			 WorkerService = workerService;
		 }
	
		 private bool VendingMachineEmpty { get; set; }
	
		 public void Replenish()
		 {
			 if (VendingMachineEmpty)
			 WorkerService.ReplenishIteam();
	
		 	// more code to replenish the Vending Machine
		 }
	 }
	
public interface IWorkerService
	 {
		 void ReplenishIteam();
	 }
	
public class WorkerService : IWorkerService
	 {
		 public void ReplenishIteam()
 		{
			 Worker.ReplenishIteam();
		 }
	 }
	
public static class Worker
	 {
		 public static void ReplenishIteam()
		 {
			 // fill up the Vending Machine
		 }
	 }