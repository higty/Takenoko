const bt = document.getElementsByName("SaveButton")[0];
bt.addEventListener("click", function () {

    const tx = document.getElementsByName("DisplayName")[0];
    const tx1 = document.getElementsByName("Twitter")[0];
    const tx2 = document.getElementsByName("Facebook")[0];

    var r = {};
    r.DisplayName = tx.value;
    r.Twitter = tx1.value;
    r.Facebook = tx2.value;

    const json = JSON.stringify(r);

    const request = new XMLHttpRequest();
    request.open("POST", "/Api/Signup", true);//trueは非同期処理
    request.setRequestHeader("Content-Type", "application/json; charset=utf-8");
    //サーバーからレスポンスが返ってきたときに実行されるメソッド
    request.onload = function () {
        alert(request.responseText);
    };
    request.send(json);
});




