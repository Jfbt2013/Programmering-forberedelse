class User
{
    constructor(name,age){
        this.name =name;
        this.age = age;
    }
}



function ButtonClicked()
{
    
    let name = document.getElementById("name").value;
    let age = document.getElementById("age").value;
    let newUser = new User(name,age);

    let listU = document.createElement("ul");
    let entryName = document.createElement("li");
    let entryAge = document.createElement("li"); 

    entryName.appendChild(document.createTextNode(newUser.name));
    entryAge.appendChild(document.createTextNode(newUser.age));
    
    listU.appendChild(entryName);
    listU.appendChild(entryAge);

    document.body.appendChild(listU);
}