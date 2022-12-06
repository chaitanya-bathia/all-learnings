const EventEmitter = require('events')
const eventEmitter = new EventEmitter();

function func1(){
    console.log("Function 1 called")
}

function func2(){
    console.log("Function 2 called")
}

eventEmitter.on('eventOne',func1);
eventEmitter.on('eventOne',func2);

console.log(eventEmitter.listenerCount('eventOne'));
console.log(eventEmitter.rawListeners('eventOne'));
