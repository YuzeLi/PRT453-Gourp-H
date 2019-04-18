
public class Base {
	public Base(int arg){
		this.arg = arg;
	}
	void show(){
		switch(arg){
		case 1:
			System.out.println("this is 1");
			break;
		case 2:
			System.out.println("this is 2");
			break;
		case 3:
			System.out.println("this is 3");
			break;
		}
	}
	private int arg;
}
