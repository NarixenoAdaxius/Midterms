/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package famillystacks;

import java.util.Scanner;
import java.util.Stack;

public class famstacks {
   
    public static String add(String member){
        Scanner in = new Scanner(System.in);
        
        System.out.printf("\nEnter Family member: ");
        member = in.nextLine();
        
        return member;
    }
    static void menu(){
        Scanner in = new Scanner(System.in);
        String mem = null,member;
        Stack<String> stacks = new Stack<>();
        
        OUTER:
        while (true) {
            System.out.println("\n----------------MENU----------------");
            System.out.println("[A] Add family member");
            System.out.println("[B] Remove recently added family member");
            System.out.println("[C] Display recently added family member");
            System.out.println("[D] Display saved family members");
            System.out.println("[E] Exit program");
            
            System.out.println("\nEnter Choice(A-E): ");
            char choice = in.next().charAt(0);
            
            switch (choice) {
                case 'A' -> {
                    member = add(mem);
                    stacks.push(member);
                }
                case 'B' -> {
                    stacks.pop();
                    System.out.printf("Successfull\n");
                }
                case 'C' -> {
                    String element = stacks.peek();
                    System.out.printf("Recently Added Family member\n" + element);
                }
                case 'D' -> System.out.printf("Family Members\n" + stacks);
                case 'E' -> {
                    break OUTER;
                }
                default -> System.out.printf("Invalid Input");
            }
        }
    }
    
    static void UI(){
        System.out.println("Welcome User!");
        menu();
        System.out.println("Goodbye User!");
    }
    
    public static void main(String[] args) {
        UI();
    }
    
}
