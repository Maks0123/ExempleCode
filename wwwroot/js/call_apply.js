/* The function for test call and apply */

const Tank = {
    brand:"Katusha"
};

const car = {
    brand: "BMW",
    move: function(){
        console.log("I moving by  " + this.brand);
    }
}

car.move.call(Tank);
car.move.apply(Tank);



