public class Employee {
    
   
    public String name;
    public double salary;
    public int weekHour;
    public int hireYear;

    public Employee() {
    }

    public Employee(String name, double salary, int weekHour, int hireYear) {
        this.name = name;
        this.salary = salary;
        this.weekHour = weekHour;
        this.hireYear = hireYear;
    }



    //ToDo :  tax() : Maaşa uygulanan vergiyi hesaplayacaktır.
    // Çalışanın maaşı 1000 TL'den az ise vergi uygulanmayacaktır.
    // Çalışanın maaşı 1000 TL'den fazla ise maaşının %3'ü kadar vergi uygulanacaktır.
    public  Double tax(){
        Double taxSalary = null;
        Double tax = null;
        if(salary<1000){
            taxSalary = salary;
        }

        if (salary>1000) {
            taxSalary = (salary/100)*97;
            tax = salary-taxSalary;
        }

        return tax;


    }
    //ToDo  : bonus() : Eğer çalışan haftada 40 saatten fazla çalışmış ise fazladan çalıştığı
    // her saat başına 30 TL olacak şekilde bonus ücretleri hesaplayacaktır.
    public  Double bonus(){
        Double bonus=null;

        if (weekHour> 40) {
            int bonusHour= weekHour-40;
            bonus = 30.0 * bonusHour;




        }else{
            System.out.println("İşçinin alacağı ek çalışma ücreti yok.");
        }


        return bonus;
    }


    //ToDO : raiseSalary() : Çalışanın işe başlangıç yılına göre maaş artışını hesaplayacaktır. Şuan ki yılı 2021 olarak alın
    // Eğer çalışan 10 yıldan az bir süredir çalışıyorsa maaşına %5 zam yapılacaktır.
    // Eğer çalışan 9 yıldan fazla ve 20 yıldan az çalışıyorsa maaşına %10 zam yapılacaktır.
    // Eğer çalışan 19 yıldan fazla çalışıyorsa %15 zam yapılacaktır.
    // Not: raiseSalary() hesaplarken vergi ve bonusları dikkate almalısınız.
    public   Double raise(){
        int sumWorkYear = 2021 - hireYear;
        Double sumSalary = sumSalaryTaxAndBonus();
        Double interest = null;
        if (sumWorkYear <10) {
            interest = sumSalary*0.5;
        }
        if (sumWorkYear>9&&sumWorkYear<20){
            interest = sumSalary*0.10;
        }
        if (sumWorkYear>19) {
            interest = sumSalary*0.15;

        }

        return  interest;
    }

    public  Double sumSalaryTaxAndBonus (){
        Double extractionSalaryAndTax = salary-tax();
        Double sum_salary = bonus()+extractionSalaryAndTax;
        return sum_salary;
    }
    public  Double sumSalary(){
        Double sum_salary = salary + raise()+bonus();
        return sum_salary;
    }



    @Override
    public String toString() {
        return "Ad:" + name + "\n" +
                " Maas: =" + salary +"\n"+
                "Haftalık çalışma saati: " + weekHour +"\n"+
                "İşe giriş tarihi : " + hireYear +"\n"+
                "Vergi  : " + tax().toString()+ "\n"+
                "Ek Çalışma Ücreti  :"+ bonus().toString()+"\n"+
                "Maas Artısı : " + raise().toString()+"\n"+
                "Vergi ve bonuslar ile birlikte maaş: "+ sumSalaryTaxAndBonus().toString()+ "\n"+
                "Toplam Maaş: "+ sumSalary().toString();


    }
}
