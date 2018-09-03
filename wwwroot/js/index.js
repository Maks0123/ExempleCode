const elem = document.getElementsByTagName('div').item(0);
console.log(elem);

/*
const divStyle = {
    width: '100px',
    height: '100px',
    border: '3px solid green',
    borderRadius: '50%',
    background: 'red'

};

const elem2 = document.getElementsByTagName('div').item(1);

for (let key in divStyle){
    elem2.style[key] = divStyle[key];
}
*/

const elem2 = document.getElementsByTagName('div').item(1);
const divStyle = {
    width: '100px',
    height: '100px',
    border: '3px solid green',
    borderRadius: '50%',
    background: 'red'

};

for (let key in divStyle){
    elem2.style[key] = divStyle[key];
}

console.log(elem2.getAttribute('class'));
/*
Class div element chenging
*/
elem2.setAttribute('class', elem2.getAttribute('class') + ' bla bla bla');
console.log(elem2.getAttribute('class'));


const div = document.querySelector('div');
console.log(div.dataset)