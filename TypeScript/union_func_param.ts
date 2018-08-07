function unio(name : string | string [])
{
    if(typeof name == "string")
    {
        console.log(name);
    }
    else{
        for(var i = 0; i < name.length; i ++)
        {
            console.log(name[i]);
        }
    }
}
unio("hello");
console.log("================");
unio(["hello", "world", "java"]);