// console.log("Merhaba Dünya");
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
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
var Database = /** @class */ (function () {
    function Database() {
    }
    Database.prototype.add = function () {
        console.log("database add");
    };
    Database.prototype.get = function () {
        console.log("database get");
    };
    return Database;
}());
var Mysql = /** @class */ (function (_super) {
    __extends(Mysql, _super);
    function Mysql() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Mysql.prototype["delete"] = function () {
        console.log("mysql delete");
    };
    Mysql.prototype.update = function () {
        console.log("mysql update");
    };
    return Mysql;
}(Database));
var MongoDb = /** @class */ (function (_super) {
    __extends(MongoDb, _super);
    function MongoDb() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    MongoDb.prototype["delete"] = function () {
        console.log("MongoDb delete");
    };
    MongoDb.prototype.update = function () {
        console.log("MongoDb update");
    };
    return MongoDb;
}(Database));
function addDatabase(database) {
    database.add();
}
addDatabase(new Mysql());
