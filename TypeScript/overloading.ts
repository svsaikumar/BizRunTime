class parent1
{
   test1() : void
   {
        console.log("i am from parent");
   }
}


class child1 extends parent1
{
    test1() : void
    {
        console.log(" i am child1")
    }
}
var p1 = new parent1();
p1.test1();
var p2 = new child1();
p2.test1();
