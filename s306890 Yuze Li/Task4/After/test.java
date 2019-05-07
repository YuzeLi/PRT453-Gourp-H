
public class _BaseTest {
 
	_Base base1 = new _ExtBase1(1);
	_Base base2 = new _ExtBase2(2);
	_Base base3 = new _ExtBase3(3);
	@Before
	public void before(){
		
	}
	@After
	public void after(){
		
	}
	@Test
	public void test() {
		base1.show();
		base2.show();
		base3.show();
	}
 
}
