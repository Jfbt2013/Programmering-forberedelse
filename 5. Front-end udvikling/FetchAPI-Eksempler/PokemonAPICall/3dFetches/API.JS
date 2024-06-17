let pokemonlist = [];
function Print(){
fetch('https://pokeapi.co/api/v2/pokemon?limit=20&offset=0')
    .then(response => response.json())
    .then(data => {
        console.log(data);
        ListNames(data);

    })
    .catch(err => console.error(err));
}
function ListNames(data){
    for(let i = 0; i< data.results.length; i++){
        pokemonlist.push(data.results[i].name);
        console.log(pokemonlist[i]);
        
        let Pokename = data.results[i].name;
         let listItem = document.createElement('li');
         let textname = document.createTextNode(Pokename);
         listItem.appendChild(textname);
         let uList = document.getElementById('list');
         uList.appendChild(listItem);
    }
}


