package com.gulnisaslan;

public class Main {

    public static void main(String[] args) {

        interface I{ }
        class A implements I{ }
        class B extends A{ }
        class C{ }

        Number o = 5;

        if (!(o instanceof Integer data)) {
            return;
        }
        System.out.println(data.intValue());




    }
}
