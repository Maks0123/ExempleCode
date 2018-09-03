/* Task for fix error
for(var i = 0; i < 3; i++){
    setTimeout(function() {
        console.log(i);
    }, 0)
}
*/

for(var i = 0; i < 3; i++){
    (function() {setTimeout(function() {
        console.log(i);
    }, 0);})();
}