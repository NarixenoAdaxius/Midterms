package Arraylists;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;

/**
 *
 * @author N4RX
 */
public class Fixed_Descending_Ascending {

    
    public static void main(String[] args) {
        //Inititialize ArrayList with Fixed Strings
        ArrayList<String> Names = new ArrayList<>(Arrays.asList("Agustin", 
                "Alejandro", "Avila", "Baguio", "Billones", "Birol", "Bolado",
                "Villianueva", "Briza", "Catubig", "Centeno", "Ciacico", "Dagamac", 
                "Dauis", "Pipo", "Rayos", "Reformado", "Roldan","Octaviano", 
                "Pascual", "Mabale", "Mallari", "Mancol","Marable", "Mendoza", 
                "De Borja", "Dionisio", "Flora", "Jose", "Layones", "Lozanes", 
                 "Moises","Sibal", "Tencio", "Torralba", "Ynopia"));
        
        // Display Original ArrayList
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
