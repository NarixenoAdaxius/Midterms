/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package People;

/**
 *
 * @author arion
 */
public class Student extends Person {
        
    private  double grade;

    public double Student(){
        return grade;
    }

    public Student(String name, int age, String gender,double grade){
        this.grade = grade;
        this.name = name;
        this.age = age;
        this.gender = gender;
    }
    
    public void DisplayInfo(String name){
        super.DisplayInfo(name);
        System.out.println("Grade: " + this.grade+"\n");
    }
}