let a
let b

function sum(a,b){
    return a + b;
}

let arrowFunction = (i,j) => i*j;

console.log(sum(4, arrowFunction(2,3)))

let hello ="";

hello = () => {
    return "Hello World!"
}

document.getElementById("demo").innerHTML = hello();