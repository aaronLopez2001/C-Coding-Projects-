

var currentDay = new Date();
var weeks = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];

var dayOfTheWeek = weeks[currentDay.getDay()]

function Click() {
    window.alert("Today is " + dayOfTheWeek)
}