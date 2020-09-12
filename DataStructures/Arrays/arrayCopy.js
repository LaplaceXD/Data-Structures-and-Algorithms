// No usage of array methods built in Javascript

// used IIFE to simulate private fields
const arrayCopy = (function () {
    let array = [];
    let count = 0;

    return function (size) {
        // I Just placed a size parameter here, since other languages need the array size to beinitialized
        return {
            insert(item) {
                array[count] = item;
                count++;
            },
            removeAt(index) {
                const buffer = [];
                let a = 0;
                let b = 0;
                while (a < array.length) {
                    if (a === index) {
                        a++;
                        continue;
                    }

                    buffer[b] = array[a];
                    a++;
                    b++;
                }

                array = buffer;
            },
            indexOf(item) {
                for (var i = 0; i < array.length; i++) {
                    if (array[i] === item) return i;
                }

                return -1;
            },
            print() {
                console.log(array);
            },
        };
    };
})();
