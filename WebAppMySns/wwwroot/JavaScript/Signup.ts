class Page {
    public initialize() {
        const bt = document.getElementsByName("SaveButton")[0];
        bt.addEventListener("click", this.SaveButton_Click.bind(this));
    }
    private SaveButton_Click() {
        const tx = document.getElementsByName("DisplayName")[0] as HTMLInputElement;
        const tx1 = document.getElementsByName("ID")[0] as HTMLInputElement;
        const tx2 = document.getElementsByName("Twitter")[0] as HTMLInputElement;
        const tx3 = document.getElementsByName("Facebook")[0] as HTMLInputElement;
        const tx4 = document.getElementsByName("Instagram")[0] as HTMLInputElement;
        const tx5 = document.getElementsByName("Youtube")[0] as HTMLInputElement;

        var r = {
            DisplayName: tx.value,
            ID: tx1.value,
            Twitter: tx2.value,
            Facebook: tx3.value,
            Instagram: tx4.value,
            Youtube: tx5.value,
        };
        const json = JSON.stringify(r);

        const request = new XMLHttpRequest();
        request.open("POST", "/Api/Signup", true);//trueは非同期処理
        request.setRequestHeader("Content-Type", "application/json; charset=utf-8");
        //サーバーからレスポンスが返ってきたときに実行されるメソッド
        request.onload = function () {
            alert(request.responseText);
        };
        request.send(json);

    }
}


document.addEventListener("DOMContentLoaded", function () {
    const page = new Page();
    page.initialize();
});


