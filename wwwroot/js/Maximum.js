/*
The function, which find maximum in array
*/

const numsArray = [100, 0, 200, -23, 16, 45, 56, 87];

let max = numsArray[0];

for(let i = 1; i < numsArray.length; ++i){
    if (numsArray[i] > max){
        max = numsArray[i]

        //With Ternary operator
        //max = numsArray[i] > max ? nums[i] : max;
    }
}

console.log(max);