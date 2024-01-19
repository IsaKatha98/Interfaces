

"use strict";


var connection = new signalR.HubConnectionBuilder().withUrl("https://chathubisak.azurewebsites.net/chatHub").build();

class clsMensajeUsuario {
    constructor(NombreUsuario, MensajeUsuario) {

        this.NombreUsuario = NombreUsuario;
        this.MensajeUsuario = MensajeUsuario;

    }
}

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (objMensajeUsuario) {
        var li = document.createElement("li");
        document.getElementById("messagesList").appendChild(li);
        // We can assign user-supplied strings to an element's textContent because it
        // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${objMensajeUsuario.NombreUsuario} says ${objMensajeUsuario.MensajeUsuario}`;
    });

    connection.start().then(function () {
        document.getElementById("sendButton").disabled = false;
    }).catch(function (err) {
        return console.error(err.toString());
    });

    document.getElementById("sendButton").addEventListener("click", function (event) {

        let objMensajeUsuario = new clsMensajeUsuario()

        objMensajeUsuario.NombreUsuario = document.getElementById("userInput").value;
        objMensajeUsuario.MensajeUsuario = document.getElementById("messageInput").value;
        connection.invoke("SendMessage", objMensajeUsuario).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
    });



