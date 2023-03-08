public class oneToTen {
    public static void main(String []args) {
        for (int i = 0; i <= 10; i++)
        System.out.println(i);
    }
}


public class naturalSum {
    public static void main (String []args) {
        int sum = 0;
        //init sum first in sum = 0 in order to access it within for loop
        for(int i = 1; i <= 10; i++) {
            sum += i;
        }
        System.out.println("Sum: " + sum);
    }
}


public class Nested {
    public static void main(String []args) {
        for (int i = 1; i <= 3; i++) {
            for (int j = 1; j <= 3; j++){
                System.out.print(i + "" + j);
                System.out.print("\t");
            }
            System.out.println();
        }
    }
}


public class NestedPattern{
    public static void main(String[] args) {
        for (int i = 1; i <= 15; i += 2) {
            for (int k = 0; k < (7 - i / 2); k++) {
                System.out.print(" ");
            }
            for (int j = 1; j <= i; j++) {
                System.out.print("*");
            }
        System.out.println();
        }
    }
}


