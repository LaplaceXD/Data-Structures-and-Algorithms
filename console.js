function call() {
    const something = fetch("https://jsonplaceholder.typicode.com/posts");
    if (something) {
        console.log("HI");
    }
}

call();