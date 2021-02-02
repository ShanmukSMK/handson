/*let headers = ['Title', 'BoxOffice', 'Active', 'DateofLaunch','Genre','HasTeaser'];
var movie = [{ Title: 'Avatar', BoxOffice: '$200bn', Active: 'Yes', DateofLaunch: '15/03/2017', Genre: 'Science Fiction', HasTeaser: 'Yes' },
{ Title: 'The Avengers', BoxOffice: '$1000bn', Active: 'Yes', DateofLaunch: '23/12/2017', Genre: 'Superhero', HasTeaser: 'No' },
{ Title: 'Titanic', BoxOffice: '$2500bn', Active: 'Yes', DateofLaunch: '21/08/2017', Genre: 'Romance', HasTeaser: 'Yes' },
{ Title: 'Jurassic Park', BoxOffice: '$400bn', Active: 'No', DateofLaunch: '21/08/2017', Genre: 'science Fiction', HasTeaser: 'No' },
    { Title: 'Avengers:End Game', Box Office: '$30000bn', Active: 'Yes', Date of Launch: '30/11/2017', Genre: 'SuperHero', Has teaser: 'Yes' } ];

function CreateTable()
{

    for (var i = 0; i < movie.length; i++) {
        var table = document.getElementById("t1");

        newRow = table.insertRow(i);
        cell1 = newRow.insertCell(0);
        cell2 = newRow.insertCell(1);
        cell3 = newRow.insertCell(2);
        cell4 = newRow.insertCell(3);
        cell5 = newRow.insertCell(4);
        cell6 = newRow.insertCell(5);
        cell1.innerHTML = movie[i].Title;
        cell2.innerHTML = movie[i].BoxOffice;
        cell4.innerHTML = movie[i].DateofLaunch;
        cell3.innerHTML = movie[i].Active;
        cell5.innerHTML = movie[i].Genre;
        cell6.innerHTML = movie[i].HasTeaser;


    }
}*/

    let headers = ['Title', 'BoxOffice', 'Active', 'DateofLaunch', 'Genre', 'HasTeaser'];
        var movie = [{
        id:'1', Title: 'Avatar', BoxOffice: '$2,787,965,087', Active: 'Yes', DateofLaunch: '15/03/2017', Genre: 'Science Fiction', HasTeaser: 'Yes'
        }

            ,
        {
        id:'2', Title: 'The Avengers', BoxOffice: '$1,518,812,988', Active: 'Yes', DateofLaunch: '23/12/2017', Genre: 'Superhero', HasTeaser: 'No'
        }

            ,
        {
        id:'3',  Title: 'Titanic', BoxOffice: '$2,187,463,944', Active: 'Yes', DateofLaunch: '21/08/2017', Genre: 'Romance', HasTeaser: 'No'
        }

            ,
        {
        id:'4',  Title: 'Jurassic Park', BoxOffice: '$1,671,713,208', Active: 'No', DateofLaunch: '02/07/2017', Genre: 'science Fiction', HasTeaser: 'Yes'
        }

            ,
        {
        id:'5',  Title: 'Avengers:End Game', BoxOffice: '$2,750,760,348', Active: 'Yes', DateofLaunch: '02/11/2022', Genre: 'SuperHero', HasTeaser: 'Yes'
        }

        ];

        function CreateTable() {
            for (var i = 0; i < movie.length; i++) {
                var table = document.getElementById("t1");
                newRow = table.insertRow(i+1);
                cell1 = newRow.insertCell(0);
                cell2 = newRow.insertCell(1);
                cell3 = newRow.insertCell(2);
                cell4 = newRow.insertCell(3);
                cell5 = newRow.insertCell(4);
                cell6 = newRow.insertCell(5);
                cell7 = newRow.insertCell(6);
                cell1.innerHTML = movie[i].Title;
                cell2.innerHTML = movie[i].BoxOffice;
                cell3.innerHTML = movie[i].Active;
                cell4.innerHTML = movie[i].DateofLaunch;
                cell5.innerHTML = movie[i].Genre;
                cell6.innerHTML = movie[i].HasTeaser;
                localStorage.setItem("id", movie[i].Title);
                cell7.innerHTML = '<a href="edit-movie.html">Edit</a>';
            }

        }
function CreateTableCust() { //this function is used for creating customer list
    for (var i = 0; i < movie.length - 2; i++) {
        var table = document.getElementById("t1");
        newRow = table.insertRow(i + 1);
        cell1 = newRow.insertCell(0);
        cell2 = newRow.insertCell(1);
        cell3 = newRow.insertCell(2);
        cell4 = newRow.insertCell(3);
        cell5 = newRow.insertCell(4);
        //cell6 = newRow.insertCell(5);
        //cell7 = newRow.insertCell(6);
        cell1.innerHTML = movie[i].Title;
        cell2.innerHTML = movie[i].BoxOffice;
        cell3.innerHTML = movie[i].Genre;
        cell4.innerHTML = movie[i].HasTeaser;
        // cell5.innerHTML = movie[i].HasTeaser;
        //cell6.innerHTML = movie[i].;
        localStorage.setItem("id", movie[i].Title);
        cell5.innerHTML = '<a href="movie-list-customer-notification.html">AddtoFavourites</a>';
    }
    
}
function CreateTableFav() { //this table is used for creating favourite movies
    for (var i = 0; i < movie.length - 2; i++) {
        var table = document.getElementById("t1");
        newRow = table.insertRow(i + 1);
        cell1 = newRow.insertCell(0);
        cell2 = newRow.insertCell(1);
        cell3 = newRow.insertCell(2);
        cell4 = newRow.insertCell(3);
        cell1.innerHTML = movie[i].Title;
        cell2.innerHTML = movie[i].BoxOffice;
        cell3.innerHTML = movie[i].Genre;
        localStorage.setItem("id", movie[i].Title);
        cell4.innerHTML = '<a href="favorites-notification.html">Delete</a>'
    }
}
function CreateTableFav1() {//this table is used for deleting favourites
    for (var i = 0; i < movie.length - 3; i++) {
        var table = document.getElementById("t1");
        newRow = table.insertRow(i + 1);
        cell1 = newRow.insertCell(0);
        cell2 = newRow.insertCell(1);
        cell3 = newRow.insertCell(2);
        cell4 = newRow.insertCell(3);
        cell1.innerHTML = movie[i].Title;
        cell2.innerHTML = movie[i].BoxOffice;
        cell3.innerHTML = movie[i].Genre;
        localStorage.setItem("id", movie[i].Title);
        cell4.innerHTML = '<a href="favorites-notification.html">Delete</a>'
    }
}
function validateForm() {
    var title = document.forms["myForm"]["title"].value;
    var gross = document.forms["myForm"]["gross"].value;
    var date = document.forms["myForm"]["date"].value;
    if (title == "") {
        alert("Name must be filled");
        return false;
       
    }
    if (title.length < 2 || title.length > 100) {
        alert("Minimum 2 characters is required");
        return false;
    }
    if (gross == "") {
        alert("BoxOffice must be filled");
        return false;
        
    }
    if (date == "") {
        alert("Date must be filled");
        return false;
        
    }
}
function display() {//this function is used to display movie details in edit form
    document.getElementById("title").value = movie[1].Title;
     document.getElementById("gross").value= movie[1].BoxOffice;
    document.getElementById("date").value = movie[1].DateofLaunch;
} 