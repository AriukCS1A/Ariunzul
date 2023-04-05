function test (){
    // oruulsan utgiig avah
    let fname  = document.getElementById("fname").value;
    let lname = document.getElementById ("lname").value;
    let uls = document.getElementById ("country").value;
    alert("first name is: " + fname +"\nlast name is: "+ lname + "\nCountry: " + uls);
    // hevleh uildel
    document.getElementById ("print").innerHTML = 
    "first name is: " + fname +"\nlast name is: "+ lname + "\nCountry: " + uls
}

