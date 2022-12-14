// console.log("Merhaba Dünya");

// let a:string;
// a="merhaba gülnisa";

// console.log(a);


/*
//static value assigment can be made;
let a : string;
let b : number;
let c : boolean;

//dynamic value assigment can made.
//example:String,number,boolean
let d : any;

a = "Merhaba Dünya";
b = 22;
c = true;

d = 22;
d = "gülnisa";
*/

/*
//Arrays 

let langs : string[];
let nums : number[];
let boolValues : Array<boolean> = [true,false, false];
let a : Array<number> = [1,2,3,4,5,6];

langs = ["php","C#","Java","C++","Python"];
nums = [1,2,3,4,5,6];

console.log(...langs);
console.log(...nums);
console.log(...boolValues);
console.log(...a);
*/

/*
//Functions
//only  parameter methods
function addNumber(num1: number,num2:number){
    console.log(num1 + num2);
}
addNumber(10,20);

//return parameter methods
function addnumber2(num1:number, num2:number):number{
    return num1 + num2;
}
console.log(addnumber2(50,60));

//optional parameter
function addNumber3(num1 : number, num2? : number):number{

    if(typeof num2 === "undefined"){
        return num1;
    }
    return num1 + num2;
}

console.log(addNumber3(10));
console.log(addNumber3(10,50));


//void parameter method

function addNumber4(num1 : number, num2 : number):void{

    console.log(num1 + num2);
    return;
}

console.log(addNumber3(10));
console.log(addNumber3(10,50));
*/
/******************************************************************** */
/*
class Person{
    name : string;
    age : number;
    phone : string;

    constructor(name :string ,age : number, phone : string){
        this.name = name;
        this.age = age;
        this.phone = phone;
        console.log("Kişi oluşturuldu...")
    }
    showInfos(){
        console.log(`İsim : ${this.name} yaş : ${this.age} phone : ${this.phone}`);
    }
}

let person1 = new Person("Gülnisa ",26,"123456789");

person1.showInfos();

//console.log(person1.name);// 


class Employee extends Person{
    salary : number;

    constructor(name : string, age : number, phone : string, salary : number){
        super(name,age,phone);
        this.salary = salary;

    }
    showInfos(): void {
        super.showInfos();
        console.log("Maaş: " + this.salary);
    }

    changeDepertment(){
        console.log("Deperatman değiştirildi...");
    }
}
let employee = new Employee("Gülnisa",26,"123456",8000);

console.log(employee);
employee.changeDepertment();
employee.showInfos();*/

/*
interface IDatabase{
    add();
    get();
    delete();
    update();
}

class Mysql implements IDatabase{
    add() {
        console.log("Mysql add");
    }
    get() {
        console.log("Mysql get");
    }
    delete() {
        console.log("Mysql delete");
    }
    update() {
        console.log("Mysql update");
    }

}
class MongoDb implements IDatabase{
    add() {
       console.log("mongodb add")
    }
    get() {
       console.log("mongodb get")
    }
    delete() {
        console.log("mongodb delete")
    }
    update() {
        console.log("mongodb update")
    }

}

function addDatabase(database:IDatabase){
    database.add();
}
addDatabase(new Mysql());
addDatabase(new MongoDb());
*/


abstract class Database{
    add(){
        console.log("database add");
    }
    get(){
        console.log("database get");
    }

    abstract delete();
    abstract update();
}

class Mysql extends Database{
    delete() {
       console.log("mysql delete")
    }
    update() {
       console.log("mysql update")
    }

}
class MongoDb extends Database{
    delete() {
       console.log("MongoDb delete")
    }
    update() {
       console.log("MongoDb update")
    }

}

function addDatabase(database:Database){
    database.add();
}
addDatabase(new Mysql());
