import { $ } from "./HtmlElementQuery.js";
import { HttpClient } from "./HttpClient.js";
class LoginPage {
    initialize() {
        $("body").on("click", "[name='LoginButton']", this.loginButton_Click.bind(this));
    }
    loginButton_Click(target, e) {
        const p = {
            UserID: $("[name='UserID']").getValue(),
            Password: $("[name='Password']").getValue(),
        };
        const json = JSON.stringify(p);
        HttpClient.postJson("/Api/Login", p, this.loginCallback.bind(this), this.loginErrorCallback.bind(this));
    }
    loginCallback(response) {
        var result = response.jsonParse();
        if (result.success == true) {
            location.href = result.url;
        }
        else {
            alert(result.message);
        }
    }
    loginErrorCallback(response) {
    }
}
document.addEventListener("DOMContentLoaded", function () {
    const page = new LoginPage();
    page.initialize();
});
//# sourceMappingURL=Login.js.map