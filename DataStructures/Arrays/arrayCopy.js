// No usage of array methods built in Javascript

const arrayCopy = function (size) {
    // I Just placed a size parameter here, since other languages need the array size to beinitialized
    let array = [];
    let count = 0;
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
            count--;
        },
        indexOf(item) {
            for (var i = 0; i < array.length; i++) if (array[i] === item) return i;
            return -1;
        },
        print() {
            for (var i = 0; i < count; i++) print(array[i]);
        },
    };
};
