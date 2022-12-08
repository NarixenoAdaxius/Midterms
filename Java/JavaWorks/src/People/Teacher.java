/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package People;

/**
 *
 * @author arion
 */
public class Teacher extends Person {
        
        private final double salary;
    
        public double Teacher(){
            return salary;
        }
    
        public Teacher(String name, int age, String gender, double nsalary){
            this.salary = nsalary;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    
        @Override
        public void DisplayInfo(String name){
            super.DisplayInfo(name);
            System.out.println("Salary: " + this.salary+"\n");
        }
    }
