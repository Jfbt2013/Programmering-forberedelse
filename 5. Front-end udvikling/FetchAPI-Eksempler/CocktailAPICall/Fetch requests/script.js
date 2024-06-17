//const url = 'https://the-cocktail-db.p.rapidapi.com/search.php?s=vodka';
function APIcall(){
const options = {
	method: 'GET',
	headers: {
		'content-type': 'application/octet-stream',
		'X-RapidAPI-Key': 'cbbafa038bmsh3ff7bd4b7c61168p1e7f3ajsna422c7a8f37c',
		'X-RapidAPI-Host': 'the-cocktail-db.p.rapidapi.com'
	}
};

let url = 'https://the-cocktail-db.p.rapidapi.com/search.php?s=';
let input = document.getElementById("userInput").value;
url = url + input;


fetch(url, options)
    .then(response => response.json() )
    .then(data => {
        console.log(data)
        populateDataIntoList(data)
        
    })
    .catch(err => console.error(err));
}

function populateDataIntoList(fetchedData)
{
    for (let i = 0; i < fetchedData.drinks.length; i++ )
    {
        let nameDrink = fetchedData.drinks[i].strDrink;
        let listItem = document.createElement('li');
        let textDrink = document.createTextNode(nameDrink);
        listItem.appendChild(textDrink);
        let uList = document.getElementById("list");
        uList.appendChild(listItem);
    }
}