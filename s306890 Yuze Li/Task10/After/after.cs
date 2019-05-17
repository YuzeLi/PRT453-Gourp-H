public class CarWashing
 {
		 public string WashCar()
	 {
		 return "Done!";
	 }
 }

public class Car
 {
	 private CarWashing CarWashing { get; set; }

	 public Car()
	 {
		 CarWashing = new CarWashing();
	 }
	
 	 public string WashCars()
 	 {
	 	 return CarWashing.WashCar();
 	 }
 }
