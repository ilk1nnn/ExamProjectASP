function TestFunction() {
    //alert("Worked")
}

function Funksiya() {
    $.ajax({
        url: "/Home/GetAllOnlineUsers",
        method: "GET",
        success: function (data) {
            console.log(data)
        }
    })
}