var Page = /** @class */ (function () {
    function Page() {
    }
    Page.prototype.initialize = function () {
        var bt = document.getElementsByName("SaveButton")[0];
        bt.addEventListener("click", this.SaveButton_Click.bind(this));
    };
    Page.prototype.SaveButton_Click = function () {
        var tx = document.getElementsByName("DisplayName")[0];
        var tx1 = document.getElementsByName("Twitter")[0];
        var tx2 = document.getElementsByName("Facebook")[0];
        var tx3 = document.getElementsByName("Instagram")[0];
        var tx4 = document.getElementsByName("Youtube")[0];
        var r = {
            DisplayName: tx.value,
            Twitter: tx1.value,
            Facebook: tx2.value,
            Instagram: tx3.value,
            Youtube: tx4.value,
        };
        var json = JSON.stringify(r);
        var request = new XMLHttpRequest();
        request.open("POST", "/Api/Signup", true); //trueは非同期処理
        request.setRequestHeader("Content-Type", "application/json; charset=utf-8");
        //サーバーからレスポンスが返ってきたときに実行されるメソッド
        request.onload = function () {
            alert(request.responseText);
        };
        request.send(json);
    };
    return Page;
}());
document.addEventListener("DOMContentLoaded", function () {
    var page = new Page();
    page.initialize();
});
//# sourceMappingURL=Signup.js.map