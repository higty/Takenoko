import { $ } from "./HtmlElementQuery.js";
import { HttpClient, HttpResponse } from "./HttpClient.js";

class LoginPage {
    public initialize() {
        $("body").on("click", "[name='LoginButton']", this.loginButton_Click.bind(this));
    }
    private loginButton_Click(target: Element, e: Event) {
        const p = {
            UserID: $("[name='UserID']").getValue(),
            Password: $("[name='Password']").getValue(),
        };
        const json = JSON.stringify(p);

        HttpClient.postJson("/Api/Login", p, this.loginCallback.bind(this), this.loginErrorCallback.bind(this));
    }
    private loginCallback(response: HttpResponse) {
        var result = response.jsonParse();

        if (result.success == true) {
            location.href = result.url;
        }
        else {
            alert(result.message);
        }
    }
    private loginErrorCallback(response: HttpResponse) {

    }
}


document.addEventListener("DOMContentLoaded", function () {
    const page = new LoginPage();
    page.initialize();
});


