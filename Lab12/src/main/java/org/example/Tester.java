package org.example;

public class Tester {
    String name;
    String surname;
    int experienceInYears;
    String englishLevel;
    int salary;

    public Tester(String name) {
        this(name, "Unknown", 0, "Basic", 0);
    }

    public Tester(String name, String surname) {
        this(name, surname, 0, "Basic", 0);
    }

    public Tester(String name, String surname, int experienceInYears, String englishLevel, int salary) {
        this.name = name;
        this.surname = surname;
        this.experienceInYears = experienceInYears;
        this.englishLevel = englishLevel;
        this.salary = salary;
    }

    public void Info() {
        System.out.println("\nName: " + name + "\nSurname: " + surname);
    }

    public void Info(boolean includeExperience) {
        Info();
        if (includeExperience) {
            System.out.println("Experience: " + experienceInYears + " years");
        }
    }

    public void Info(boolean includeExperience, boolean includeSalary) {
        Info(includeExperience);
        if (includeSalary) {
            System.out.println("Salary: " + salary);
        }
    }

    public static void printWelcomeMessage() {
        System.out.println("Хай Серёх!");
    }
}