function unio(name) {
    if (typeof name == "string") {
        console.log(name);
    }
    else {
        for (var i = 0; i < name.length; i++) {
            console.log(name[i]);
        }
    }
}
unio("hello");
