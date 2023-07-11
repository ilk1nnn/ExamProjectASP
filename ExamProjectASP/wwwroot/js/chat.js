"use strict"

var connection = new signalR.HubConnectionBuilder().withUrl("/chathub").build();

connection.start().then(function () {

}).catch(function (err) {
    return console.error(err.toString());
})


connection.on("Connect", function (info) {
    var li = document.createElement("li");
    //document.getElementById("messagesList").appendChild(li);
    //li.innerHTML = `<span style='color:springgreen;'>${info}</span>`;

    //alert("Worked 2 Connected");

    //Diger js faylinda GetAllUser Deye Bir Funksiya Yaradilmalidir
    connection.invoke("Funksiya")
})

connection.on("Disconnect", function (info) {
    var li = document.createElement("li");
    //document.getElementById("messagesList").appendChild(li);
    //li.innerHTML = `<span style='color:red;'>${info}</span>`;


    //Diger js faylinda GetAllUser Deye Bir Funksiya Yaradilmalidir
    connection.invoke("Funksiya")
})


// EXAMPLE FUNCTIOn
//connection.on("ReceiveNotification", function () {
//    GetMyRequests();
//    GetAllUsers();
//})

connection.on("Test2", function () {
    //alert("Test2 Worked");
    TestFunction();
})

connection.on("GetAllOnline", function () {
    //alert("Test2 Worked");
    Funksiya();
})

async function Test(id) {
    console.log("Test Function Is Worked")
    console.log(id)
    await connection.invoke("SendFollow",id)
}

async function SendMessageHub(senderId, message) {
    await connection.invoke("SendChat");
}


//------------Chat

connection.on("GetMessage", (user, message) => {
    addMessage(user, message)
})






