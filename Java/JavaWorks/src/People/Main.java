/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package People;


public class Main {

    
    public static void main(String[] args) {
        Person reference = new Person("Kian", 19, "Male");
        Student stuObj = new Student("Kian", 19, "Male", 98.91);
        Teacher teaObj = new Teacher("Taco", 30, "Male", 10000);
        

        reference.DisplayInfo("Kian");
        stuObj.DisplayInfo("Kian");
        teaObj.DisplayInfo("Taco");
    }
    
}
