function calc(a, b, method){
    return method(a, b);
}

//function add(x, y){
  //  return x + y;
//}

function subtract(x, y){
    return x - y;
}


function add(x, y){
   for(let index in arguments){
       console.log(arguments[index]);
   }
   return x + y;
}

console.log(add(10, 30, 50, 'text', true));