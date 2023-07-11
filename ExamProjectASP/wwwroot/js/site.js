function TestFunction() {
    //alert("Worked")
}

async function sendMessage() {
    var userInput = document.getElementById("userInput");
    var message = userInput.value;

    if (message) {
        await connection.invoke("SendChat", CurrentRoom2.name, currentUser, message);
        userInput.value = "";
    }
}


function addMessage(user, message) {
    var chatContainer = document.getElementById("chatContainer");
    var newMessage = document.createElement("div");
    if (user == currentUser) {
        user = "me"
    }
    newMessage.textContent = user + ": " + message;
    chatContainer.appendChild(newMessage);
}












function Funksiya() {
    console.log("Funksiya Worked")
    $.ajax({
        url: "/Home/GetAllOnlineUsers",
        method: "GET",
        success: function (data) {
            console.log(data)
            console.log("hello")
            let content = ``;
            for (var i = 0; i < data.length; i++) {
                if (data[i].isOnline==true) {
                    console.log(data[i].name)
                }
                console.log(data[i].isOnline);
                    content += `
                    <div  class="col-lg-3 col-sm-6" >

                        <div class="single-friends-card">
                            <div class="friends-image">
                                <a href="#">
                                    <img src="~/assets/images/friends/friends-bg-1.jpg" alt="image">
                                </a>
                                <div class="icon">
                                    <a href="#"><i class="flaticon-user"></i></a>
                                </div>
                            </div>
                            <div class="friends-content">
                                <div class="friends-info d-flex justify-content-between align-items-center">
                                    <a href="#">
                                        <img src="~/assets/images/friends/friends-1.jpg" alt="image">
                                    </a>
                                    <div class="text ms-3">
                                        
                                        <h3><a href="#">${data[i].name} ${data[i].surname}</a></h3>
                                        <span>10 Mutual Friends</span>
                                    </div>
                                </div>
                                <ul class="statistics">
                                    <li>
                                        <a href="#">
                                            <span class="item-number">862</span>
                                            <span class="item-text">Likes</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <span class="item-number">91</span>
                                            <span class="item-text">Following</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <span class="item-number">514</span>
                                            <span class="item-text">Followers</span>
                                        </a>
                                    </li>
                                </ul>
                                <div class="button-group d-flex justify-content-between align-items-center">
                                    <div class="add-friend-btn">
                                        <button type="submit">Add Friend</button>
                                    </div>
                                    <div class="send-message-btn">
                                        <button type="submit">Send Message</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                </div >
            
`;
               
            }
                $("#usersfortest").html(content);
           
        }
    })
}