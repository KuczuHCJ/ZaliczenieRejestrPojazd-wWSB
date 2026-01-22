
var auta = [];


pokazTabele();

function zapiszPojazd() {
    
    var nr = document.getElementById("nrRej").value;
    var marka = document.getElementById("marka").value;
    var model = document.getElementById("model").value;
    var wlasciciel = document.getElementById("wlasciciel").value;

   
    if (nr == "" || marka == "") {
        alert("Musisz podać numer rejestracyjny i markę!");
        return;
    }

    
    var noweAuto = {
        nr: nr,
        marka: marka,
        model: model,
        wlasciciel: wlasciciel
    };

    
    auta.push(noweAuto);

   
    document.getElementById("nrRej").value = "";
    document.getElementById("marka").value = "";
    document.getElementById("model").value = "";
    document.getElementById("wlasciciel").value = "";

    
    var modalElement = document.getElementById('modalPojazd');
    var modalInstance = bootstrap.Modal.getInstance(modalElement);
    modalInstance.hide();

    pokazTabele();
}

function pokazTabele() {
    var tabela = document.getElementById("tabela-body");
    tabela.innerHTML = ""; 

    auta.forEach((auto, index) => {
        var wiersz = "<tr>" +
            "<td>" + auto.nr + "</td>" +
            "<td>" + auto.marka + "</td>" +
            "<td>" + auto.model + "</td>" +
            "<td>" + auto.wlasciciel + "</td>" +
            "<td>" + 
                
                "<button class='btn btn-warning btn-sm me-1'>Edytuj</button>" +
                "<button class='btn btn-danger btn-sm' onclick='usun(" + index + ")'>Usuń</button>" +
            "</td>" +
            "</tr>";

        tabela.innerHTML += wiersz;
    });
}

function usun(id) {
    if (confirm("Na pewno chcesz usunąć ten pojazd?")) {
        auta.splice(id, 1); 
        pokazTabele(); 
    }
}