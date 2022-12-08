/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package People;


public class Person { 
    public String name, gender;
    public int age;

    public Person() {
        this.name = "";
        this.age = 0;
        this.gender = "";
    }

    public Person(String name) {
        this.name = name;
        this.age = 0;
        this.gender = "";
    }

    public Person(String name, int age) {
        this.name = name;
        this.age = age;
        this.gender = "";
    }

    public Person(String name, int age, String gender) {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }

    public void DisplayInfo(){
        System.out.println("Nothing here, my guy.");
    }

    public void DisplayInfo(String name)
    {
        System.out.println("Name: " + name);
        System.out.println("Age: " + age);
        System.out.println("Gender: " + gender + "\n");
    }
   }

