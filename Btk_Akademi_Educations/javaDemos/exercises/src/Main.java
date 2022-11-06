public class Main {

    public static void main(String[] args) {
	   char grade='B';
	    switch (grade){
            case 'A':
                System.out.println("Mükemmel: Geçtiniz.");
                break;
            case 'B':
                System.out.println("İyi: Geçtiniz.");
                break;
            case 'C':
                System.out.println("İyi: Geçtiniz.");
                break;
            case 'D':
                System.out.println("İdare eder: Geçtiniz.");
                break;
            case 'F':
                System.out.println("Sınıfta kalınız");
                break;
            default:
                System.out.println("Geçersiz not girdiniz.");
        }

        String student1="Gülnisa";
	    String student2="Derin";
	    String student3="Hale";

	    System.out.println(student1);
        System.out.println(student2);
        System.out.println(student3);
        System.out.println("************************");
        String[] students=new String[4];
        students[0]="Gülnisa";
        students[1]="Nisagül";
        students[2]="Gül";
        students[3]="Nisa";

        for (int i=0; i<students.length; i++){
            System.out.println(students[i]);
        }
        System.out.println("************************");
        for (String student :students){
            System.out.println(student);
        }
        System.out.println("************************");
        int numbers=24;
        if (numbers<20){
            System.out.println("Sayı 20 den küçüktür.");
        }else if(numbers==20){
            System.out.println("Sayı 20'ye eşitir.");
        }else{
            System.out.println("Sayı 20'den küçük değildir.");
        }
        System.out.println("************************");
        //for
        //int i = 1;
       // for(int i=1;i<=10;i+=4){
          //  System.out.println(i);
        //}

        int k=10;
        while (k<10){
            System.out.println(k);
            k++;
        }
        System.out.println("************************");
        int j=100;
        do {
            System.out.println("Loglandı.");
            System.out.println(j);
            j+=2;
        }while (j<10);
        System.out.println("do-while döngüsü bitti.");
        System.out.println("************************");
 








    }
}
