var doSomething = (function () {
    var obj;

    function makeObj() {
        return {
            hasDone: "say hello"
        };
    }
    return {
        singleInstance: function () {
            obj = !obj ? makeObj() : obj
            return obj;
        }
    }
})()

var do1 = doSomething.singleInstance();
var do2 = doSomething.singleInstance();

console.log(do1) // { hasDone: 'say hello' }
console.log(do2) // { hasDone: 'say hello' }

console.log(do1 === do2) // true
