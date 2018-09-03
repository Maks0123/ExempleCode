/*
FThe function, wich count Fibonacci numbers.
 The function use recursive method.
*/

function Fibonacci_(index){
    if( index <= 1 ){
        return 1;
    }
    return Fibonacci_(index - 1) + Fibonacci_(index - 2)
}

console.log(6);