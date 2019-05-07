public abstract class _Base {
	public _Base(int arg){
		this._arg = arg;
	}
	protected int _arg;
	public abstract void show();
 
}


public class _ExtBase1 extends _Base{
 
	public _ExtBase1(int arg) {
		super(arg);
	}
 
	@Override
	public void show() {
		System.out.println("this is 1");
	}
}



public class _ExtBase2 extends _Base{
	public _ExtBase2(int arg) {
		super(arg);
	}
 
	@Override
	public void show() {
		System.out.println("this is 2");
	}
}



public class _ExtBase3 extends _Base{
 
	public _ExtBase3(int arg) {
		super(arg);
	}
	
	@Override
	public void show() {
		System.out.println("this is 3");
	}

	