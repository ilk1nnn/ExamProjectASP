function TestFunction() {
    //alert("Worked")
}

function Funksiya2() {
    $.ajax({
        url: "/Home/GetAllOnlineUsers",
        method: "GET",
        success: function (data) {
            let content = ``;
            for (var i = 0; i < data.length; i++) {
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