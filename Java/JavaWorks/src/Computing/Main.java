
package Computing;

class Arithmetic{
    //addition
        public int add(int a, int b){
            return a + b;
        }
	public int add(int a, int b, int c){
            return a + b + c ;
        }
	public int add(int a, int b, int c, int d){
            return a + b + c + d;
        }
		
		//multiplication
        public int multiply(int a, int b){
            return a * b;
        }
	public int multiply(int a, int b, int c){
            return a * b * c;
        }
	public int multiply(int a, int b, int c, int d){
            return a * b * c * d;
        }
		
		//subtraction
        public int subtract(int x, int y){
            return x - y;
        }
		
		// division
        public int divide(int x, int y){
            return x / y;
        }
}

public class Main {
    public static void main(String[] args) {
       Arithmetic compute = new Arithmetic();
       
       System.out.println(compute.add(1,3));
       System.out.println(compute.add(1,3,4,5) );
       System.out.println(compute.multiply(2,3,4));
       System.out.println(compute.multiply(1,1));
       System.out.println(compute.subtract(3,1) );
       System.out.println(compute.divide(5,2));
       
    }   
}
