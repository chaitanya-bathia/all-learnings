const EventEmitter = require('events');

const eventEmitter = new EventEmitter();

eventEmitter.on('start',(number)=>{
    console.log(`Started ${number}`)
})

eventEmitter.emit('start',23);