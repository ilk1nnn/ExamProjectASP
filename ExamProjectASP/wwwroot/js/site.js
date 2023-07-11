function TestFunction() {
    //alert("Worked")
}




function addMessage(user, message) {
    var chatContainer = document.getElementById("chat-content");
    var newMessage = "";
    if (user == currentUser) {
        newMessage = `
                <div class="chat chat-left">
                    <div class="chat-avatar">
                        <a routerLink="/profile" class="d-inline-block">
                            <img src="~/assets/images/user/user-2.jpg" width="50" height="50" class="rounded-circle" alt="image">
                        </a>
                    </div>

                    <div class="chat-body">
                        <div class="chat-message">
                            <p>`${ message } `</p>
                            <span class="time d-block">7:45 AM</span>
                        </div>
                    </div>
                </div>
        `
    }
    else {
        newMessage = `
        <div class="chat">
                    <div class="chat-avatar">
                        <a routerLink="/profile" class="d-inline-block">
                            <img src="~/assets/images/user/user-11.jpg" width="50" height="50" class="rounded-circle" alt="image">
                        </a>
                    </div>

                    <div class="chat-body">
                        <div class="chat-message">
                            <p>`${ message} `</p>
                            <span class="time d-block">7:45 AM</span>
                        </div>
                    </div>
                </div>
                `
    }
    
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
                if (data[i].isOnline == true) {

                    content += `
                    <div  class="col-lg-3 col-sm-6" >

                        <div class="single-friends-card">
                            <div class="friends-image">
                                <a href="#">
                                    <img src="/assets/images/friends/friends-bg-1.jpg" alt="image">
                                </a>
                                <div class="icon">
                                    <a href="#"><i class="flaticon-user"></i></a>
                                </div>
                            </div>
                            <div class="friends-content">
                                <div class="friends-info d-flex justify-content-between align-items-center">
                                    <a href="#">
                                        <img src="/assets/images/friends/friends-1.jpg" alt="image">
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
            }
            $("#usersfortest").html(content);

        }
    })
}