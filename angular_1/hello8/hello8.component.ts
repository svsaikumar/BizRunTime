import { Component } from "@angular/core";



export class A
{
    constructor()
    {
        console.log("from class A constructor:");
    }

}
@Component ({
    selector :"hello8",
    template:'',
    styles:[]
    })
    
export class Hello8Component
{
    constructor(arg0 : A)
    {
        console.log("from hello8 component constructor");
        let obj = new A();
    }
}