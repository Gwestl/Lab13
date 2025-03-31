package org.example;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Test test = new Test();
        test.uikal();
        Tester.printWelcomeMessage();

        Tester tester1 = new Tester("Jonny", "Big", 5, "Продвинутый", 3500);
        tester1.Info(true);
        tester1.Info(true, true);
    }
}