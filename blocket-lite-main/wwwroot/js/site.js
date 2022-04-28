function show_car() {
    let category = document.getElementById("category").value;

    switch (category) {

        case "vehicle":
            document.querySelector(".forms_div").style.display = "block";
            document.getElementById("clothing").style.display = "none";
            break;
        case "cloths":
            document.getElementById("clothing").style.display = "block";
            document.getElementById("forms_div").style.display = "block";
            break;
        default:
            document.querySelector(".forms_div").style.display = "none";
            break;

    }
}