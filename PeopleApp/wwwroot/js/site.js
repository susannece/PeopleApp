﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function getLastPerson(actionUrl) {
    $.get(actionUrl, function (response) {
        console.log("Response", response);
        document.getElementById("result").innerHTML = response;
    });
}

function getLastPersonJSON(actionUrl) {
    $.get(actionUrl, function (response) {
        console.log("Response", response);
        document.getElementById("result").innerHTML = response;
    });
}

function getPeople(actionUrl) {
    $.get(actionUrl, function (response) {
        console.log("Response", response);
        document.getElementById("result").innerHTML = response;
    });
}