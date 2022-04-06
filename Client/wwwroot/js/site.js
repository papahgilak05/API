// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const animals = [
    { name: "garfield", species: "cat", class: { name: "mamalia" } },
    { name: "nemo", species: "fish", class: { name: "invertebrata" } },
    { name: "tom", species: "cat", class: { name: "mamalia" } },
    { name: "gary", species: "cat", class: { name: "mamalia" } },
    { name: "dory", species: "fish", class: { name: "invertebrata" } }
]
console.log(animals);

const OnlyCat = [];


for (var i = 0; i < animals.length; i++) {
    if (animals[i].species == "cat") {
        OnlyCat.push(animals[i]);
    }
    else if (animals[i].species == "fish") {
        animals[i].class.name = "Non-Mamalia";
    }

}
console.log(OnlyCat);

$.ajax({
    url: "https://pokeapi.co/api/v2/pokemon?limit=2000&offset=0",
    success: function (result) {
        console.log(result.results);
        var text = "";

        $.each(result.results, function (key, val) {
            text += `<tr>
                      <td>${key + 1}</td>
                      <td>${val.name}</td>
                      <td>
                        <button type="button" class="btn btn-primary" data-toggle="modal" onclick="detail('${val.url}')" data-target="#DetailPokemon">Detail</button>
                        </td>
                      
                     </tr>`
        });
        console.log(text);
        $("#tableSW").html(text);
    }
})

function detail(url) {
    $.ajax({
        url: url,
        success: function (result) {
            console.log(result);
            $('.picture').attr(
                'src',
                `${result.sprites.other['official-artwork'].front_default}`
            )
            $('.name').html(result.name)
            $('.abilities').empty();
            $('#type').empty();
            $('.moves1').html(result.moves[0].move.name)
            $('.moves2').html(result.moves[1].move.name)
            $('.moves3').html(result.moves[2].move.name)
            /*            $('.type').html(result.types[0].type.name)
                        $('.type2').html(result.types[1].type.name)*/
            $('.hp').css({ "width": `${result.stats[0].base_stat}%` })
            $('.ap').css({ "width": `${result.stats[1].base_stat}%` })
            $('.dp').css({ "width": `${result.stats[2].base_stat}%` })
            $('.sp').css({ "width": `${result.stats[5].base_stat}%` })

            for (var i = 0; i < result.abilities.length; i++) {
                $('.abilities').append("<li>" + `${result.abilities[i].ability.name}` + "</li>  ")
            }
            var Text = "";
            var Warna = "";
            $.each(result.types, function (key, val) {
                switch (val.type.name) {
                    case "normal":
                        Warna = "#A8A77A";
                        break;
                    case "fire":
                        Warna = "#EE8130";
                        break;
                    case "water":
                        Warna = "#6390F0";
                        break;
                    case "grass":
                        Warna = "#7AC74C";
                        break;
                    case "electric":
                        Warna = "#F7D02C";
                        break;
                    case "ice":
                        Warna = "#96D9D6";
                        break;
                    case "fighting":
                        Warna = "#C22E28";
                        break;
                    case "poison":
                        Warna = "#A33EA1";
                        break;
                    case "ground":
                        Warna = "#E2BF65";
                        break;
                    case "flying":
                        Warna = "#A98FF3";
                        break;
                    case "psychic":
                        Warna = "#F95587";
                        break;
                    case "bug":
                        Warna = "#A6B91A";
                        break;
                    case "ghost":
                        Warna = "#735797";
                        break;
                    case "dragon":
                        Warna = "#6F35FC";
                        break;
                    case "dark":
                        Warna = "#705746";
                        break;
                    case "steel":
                        Warna = "#B7B7CE";
                        break;
                    case "fairy":
                        Warna = "#D685AD";
                        break;
                    default:
                        Warna = "white";
                }
                Text += `<span 
                            class="badge badge-pill" style="background-color: ${Warna}">${val.type.name}
                        </span>`;

            });
            $('#type').html(Text);

        }
    })
}

$(document).ready(function () {
    $("#tablepoke").DataTable();
});


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////// MASTERDATA JAVASCRIPT //////////////////////////////////////////////////////////////