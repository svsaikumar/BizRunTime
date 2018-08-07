class Car
 { 
   
    engine:string; 
    constructor(engine:string) 
    { 
       this.engine = engine 
    }  
 
    
    disp():void 
    { 
       console.log("Engine is  :   "+this.engine) 
    } 
 }