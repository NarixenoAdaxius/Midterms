package StacknQue;
import java.util.*;
/**
 *
 * @author N4RX
 */
public class Main {
    public static void main(String[] args) {
        Queue book = new LinkedList < String > ();
        Stack < String > Title = new Stack < > ();
        Scanner user = new Scanner(System.in);
        System.out.println("Enter four book titles.");
        int counter = 4;
        
        // Take Inputs to Stack
        for(int i=1; i<=counter;i++){
            System.out.print("Book " + i + ":");
            String Enter = user.nextLine();
            Title.push(Enter);
        }
        
        //Enqueue Stack
        for(int i=1;i<=counter;i++){
            book.offer(Title.pop());
        }
        
        // Print Queue
        System.out.println("New order of books:");
        System.out.println(book);
    }
}