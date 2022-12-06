setTimeout(() => {
  console.log('After');
  setTimeout(() => {
    console.log('After2');
  }, 0);
}, 0);

console.log('before');

let num = 0;

let id = setInterval(() => {
  if (num == 10) {
    clearInterval(id);
  } else {
    num++;
    console.log(num);
  }
}, 100);

const done = true;

const isItDoneYet = new Promise((resolve, reject) => {
  if (done) {
    const workDone = 'Here is the thing I built';
    resolve(workDone);
  } else {
    const why = 'Still working on something else';
    reject(why);
  }
});

const checkIfItsDone = () => {
  isItDoneYet
    .then((ok) => {
      console.log(ok);
    })
    .catch((err) => {
      console.error(err);
    });
};

checkIfItsDone();

const doSomethingAsync = () => {
  return new Promise((resolve) => {
    setTimeout(() => resolve('I did something'), 3000);
  });
};

const doSomething = async () => {
  console.log(await doSomethingAsync());
};

console.log('Before');
doSomething();
console.log('After');


// Event Loop

const bar = () => console.log('bar')

const baz = () => console.log('baz')

const foo = () => {
  console.log('foo')
  setTimeout(bar, 0)
  baz()
}

foo()
