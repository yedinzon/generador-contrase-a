const password = document.getElementById("pass"),
      copy = document.getElementById("copy"),
      generatePassword = document.getElementById("generatePass"),
      length = 5;

const upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
      lowerCase = "abcdefghijklmnopqrstuvwxyz",
      number = "0123456789",
      symbol = "@#$%^&*()_+~|}{[]></-=",
      allChars = upperCase + lowerCase + number + symbol;
    

     generatePassword.addEventListener('click',generatePass)
     

function generatePass() {
    let pass="";
    pass += upperCase[Math.floor(Math.random() * upperCase.length)]
    pass += lowerCase[Math.floor(Math.random() * lowerCase.length)]
    pass += number[Math.floor(Math.random() * number.length)]
    pass += symbol[Math.floor(Math.random() * symbol.length)]

    while(length > pass.length) pass += allChars[Math.floor(Math.random() * allChars.length)]
    
    password.value = pass;
}

function copyPass() {
    password.select();
    document.execCommand("copy");
    
}