if(getBasePrice()>1000){
	return getBasePrice()*0.95；
}else{
	return getBasePrice()*0.98;
}
 
public double getBasePrice(){
	return _quantity*itemPrice;
}
