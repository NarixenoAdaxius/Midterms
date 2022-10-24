/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package Numberdeclarer;
import java.util.*;
/**
 *
 * @author arion
 */
public class NumberDeclare {

    static void UI(){
        System.out.println("Welcome User!");
        Enter();
        System.out.println("Exiting...");
    }
    
    static void Enter(){
        
        int number;
        char choice;
        Scanner in = new Scanner(System.in);
            
        do{
            System.out.printf("Enter a Number from 1-10: ");
            number = in.nextInt();
        
            switch(number){
                case 1 -> System.out.println("One");
                case 2 -> System.out.println("Two");
                case 3 -> System.out.println("Three");
                case 4 -> System.out.println("Four");
                case 5 -> System.out.println("Five");
                case 6 -> System.out.println("Six");
                case 7 -> System.out.println("Seven");
                case 8 -> System.out.println("Eight");
                case 9 -> System.out.println("Nine");
                case 10 -> System.out.println("Ten");
                default -> {
                        System.out.println("Invalid Number");
                }
            }
            System.out.printf("Do you want to try again? (Y/N): ");
            choice = in.next().charAt(0);
            
        }while (choice == 'y' || choice == 'Y'); 
    }
    
    public static void main(String[] args) {
        UI();
    }
    
}
