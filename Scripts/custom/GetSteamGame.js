function GetSteamGame() {
    jQuery.post("/test/GetGame", { ID: $("#SearchGameID").val() }, function (data) {
        $("#SteamGameDesc-Name").text(data.game.Name);
        $("#SteamGameDesc-ShortDesc").text(data.game.ShortDesc);
        $("#SteamGameDesc-Dev").text(data.game.Dev);
    });
}