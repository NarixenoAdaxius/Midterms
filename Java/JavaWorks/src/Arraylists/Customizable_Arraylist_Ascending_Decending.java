package Arraylists;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

/**
 *
 * @author N4RX
 */
public class Customizable_Arraylist_Ascending_Decending {

   
    public static void main(String[] args) {
        ArrayList<String> Names = new ArrayList<String>();
        Scanner in = new Scanner(System.in);
        int Limit, counter = 1;
        
        // Get Limit of names to be stored
        System.out.printf("How many Names would like to input: ");
        Limit = in.nextInt();
        in.nextLine();// helps to not skip the first nextLine Scanner below
        
        // Loop to Get Names and Store to Arraylist
        while(counter <= Limit){
            
            System.out.printf( counter + ". Enter a Name: ");
            String n = in.nextLine();
            Names.add(n);
            counter++;
        }
        
        // Display Original ArrayList
        System.out.println("\n");
        System.out.println("ORIGINAL ORDER:");
        System.out.println(Names);
        System.out.println("\n");
        
        System.out.println("ASCENDING ORDER:");
        //Sort in Ascendng Format (A, a, B, b ...)
        Collections.sort(Names, String.CASE_INSENSITIVE_ORDER);
        System.out.println(Names);
        System.out.println("\n");
        
        System.out.println("DESCENDING ORDER:");
        // Reverse Sorted Names
        Collections.reverse(Names);
        System.out.println(Names);
        
        
    }
    
}
