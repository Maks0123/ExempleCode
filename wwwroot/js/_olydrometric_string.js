/*
The function with find a polydrometric string in array
*/

const string =['abc', 'bci', 'aba', 'bcc'];

string.forEach(function(string){
    let reverced = '';

    for(let i = string.length - 1; i >= 0; i--){
        reverced += string[i];
    }

    if(reverced === string){
        console.log(`${string} is polindrom`);
    }
});