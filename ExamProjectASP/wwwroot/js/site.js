function TestFunction() {
    //alert("Worked")
}



function SendMessageAjax(recieverId, senderId) {


    var userInput = document.getElementById("user-message");
    var message = userInput.value;
    console.log(message)
    var newMessage = "";
    SendMessageHub(recieverId, message)
    var chatContainer = document.getElementById("result123");
    newMessage = `
                <div class="chat chat-left">
                    <div class="chat-avatar">
                        <a routerLink="/profile" class="d-inline-block">
                            <img src="/images/profile.png" width="50" height="50" class="rounded-circle" alt="image">
                        </a>
                    </div>

                    <div class="chat-body">
                        <div class="chat-message">
                            <p>'${message}'</p>
                            <span class="time d-block">7:45 AM</span>
                        </div>
                    </div>
                </div>
        `
    chatContainer.innerHTML += newMessage;

    //await connection.invoke("SendChat", currentUser, message);
    userInput.value = "";

    //let obj = {
    //    "recieverId" = recieverId,
    //    "senderId" = senderId,
    //    "message" = message
    //}
    //$.ajax({
    //    url: '@Url.Action("SendMessage", "Home")',
    //    type: 'POST',
    //    data: JSON.stringify(obj),
    //    success: function (response) {
    //        // Handle the successful response from the server
    //        console.log(response);
    //    },
    //    error: function (xhr, status, error) {
    //        // Handle any errors that occurred during the AJAX request
    //        console.error(error);
    //    }
    //});



}
var btnId = "";
function AddFriend(senderId, recieverId) {

    var result2 = senderId + ";" + recieverId;
    
    

    $.ajax({
        url: "/Home/AddNotification",
        type: "POST",
        dataType: 'JSON',
        data: { result: result2 },
        success: function (data) {
            console.log(data);
        },
        error:
            function (response) {
                console.log(response);
            }

    })
    let btnId2 = `btn${recieverId}`;
    var buttonelement = document.getElementById(btnId2);
    buttonelement.innerHTML = "PENDING";
    SendFriendRequest(senderId, result2.split(';')[1])
    
}

function GoChat(reciever, sender) {
    let result = reciever.split(';');
    $("#liveChatContainer").html(`
            <div class="live-chat-header d-flex justify-content-between align-items-center">
                <div class="live-chat-info">
                    <a href="#"><img src="/images/profile.png" class="rounded-circle" alt="image"></a>
                    <h3>
                            <a>'${result[1]}' </a>
                    </h3>
                </div>

                <ul class="live-chat-right">
                    <li>
                        <button class="btn d-inline-block" data-bs-toggle="tooltip" data-bs-placement="top" title="Phone" type="button"><i class="ri-phone-fill"></i></button>
                    </li>
                    <li>
                        <button class="btn d-inline-block" data-bs-toggle="tooltip" data-bs-placement="top" title="Live" type="button"><i class="ri-live-fill"></i></button>
                    </li>
                    <li>
                        <button class="btn d-inline-block" data-bs-toggle="tooltip" data-bs-placement="top" title="Delete" type="button"><i class="ri-delete-bin-line"></i></button>
                    </li>
                </ul>
            </div>

            <div class="live-chat-container">
                <div id="result123" class="chat-content">



                </div>

                <div class="chat-list-footer">
                    <div class="btn-box d-flex align-items-center me-3">
                        <button class="file-attachment-btn d-inline-block me-2" data-bs-toggle="tooltip" data-bs-placement="top" title="File Attachment" type="button"><i class="ri-attachment-2"></i></button>

                        <button class="emoji-btn d-inline-block" data-bs-toggle="tooltip" data-bs-placement="top" title="Emoji" type="button"><i class="ri-user-smile-line"></i></button>
                    </div>

                    <input id="user-message" type="text" class="form-control" placeholder="Type your message...">

                    <button onclick="SendMessageAjax('${result[0]}','${sender}')" class="send-btn d-inline-block">Send</button>
                </div>
            </div>
            `)
}


function addMessage(user, message) {
    console.log(message)
    var chatContainer = document.getElementsByClassName("chat-content");
    var newMessage = "";
    newMessage = `
        <div class="chat">
                    <div class="chat-avatar">
                        <a routerLink="/profile" class="d-inline-block">
                            <img src="/images/profile.png" width="50" height="50" class="rounded-circle" alt="image">
                        </a>
                    </div>

                    <div class="chat-body">
                        <div class="chat-message">
                            <p>'${message}'</p>
                            <span class="time d-block">7:45 AM</span>
                        </div>
                    </div>
                </div>
                `;

    chatContainer.innerHTML += newMessage;
}




function GetFriendRequest(senderId) {
    console.log("isliyir");
    let element = document.getElementById(senderId);
    element.innerHTML = `

    <section style='display:inline-block;'>
        <button  style='background-color:green;' type="submit">Accept Request</button>
        <button style='background-color:red;' type="submit">Decline Request</button>
    </section>

    

`;
}



function Funksiya(id) {
    console.log("Funksiya Worked")
    console.log("Id" + id);
    $.ajax({
        url: "/Home/GetAllOnlineUsers",
        method: "GET",
        success: function (data) {


            let content = ``;
            for (var i = 0; i < data.length; i++) {
                if (data[i].isOnline == true) {
                    btnId = `btn${data[i].id}`;
                    content += `
                    <div  class="col-lg-3 col-sm-6" >

                        <div class="single-friends-card">
                            <div class="friends-image">
                                <a href="#">
                                </a>
                                <div class="icon">
                                    <a href="#"><i class="flaticon-user"></i></a>
                                </div>
                            </div>
                            <div class="friends-content">
                                <div class="friends-info d-flex justify-content-between align-items-center">
                                    <a href="#">
                                        <img src="/images/profile.png" alt="image">
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
                                    <div id='${data[i].id}' class="add-friend-btn">
                                        <button id='${btnId}' onclick="AddFriend('${id}','${data[i].id}')" type="submit">Add Friend</button>
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
            }
            $("#usersfortest").html(content);

        }
    })
}