public class CarWashing
 {
		 public string WashCar()
	 {
		 return "Done!";
	 }
 }

public class Child
 {
	 private CarWashing CarWashing { get; set; }

	 public Car()
	 {
		 CarWashing = new CarWashing();
	 }
	
 	 public string WashHands()
 	 {
	 	 return CarWashing.WashCar();
 	 }
 }