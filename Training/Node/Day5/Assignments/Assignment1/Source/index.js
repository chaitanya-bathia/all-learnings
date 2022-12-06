const EventEmitter = require('events');
const eventEmitter = new EventEmitter();

function start()
{
    console.log("Exam Started");

    setTimeout(() => {
        process.nextTick(()=>{
            console.log("Exam Over");
        })
    }, 10000000);
}

eventEmitter.on('eventOne',start);

eventEmitter.emit('eventOne');