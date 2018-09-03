/*
This function deciding task Hanoi Tower
*/

const car1 = [300, 200, 100];
const buffer = [];
const car2 = [];

let slabNumber = car1.length;

function crane(stack, A, B, C){
    if (stack >= 1){
        crane(stack -1, A, C, B);
        moveSlack(A, B);
        crane(stack - 1, C, B, A);
    }
}

function moveSlack(from, to){
    to.push(from.pop());
}

crane(slabNumber, car1, car2, buffer );
console.log(car1, buffer, car2);