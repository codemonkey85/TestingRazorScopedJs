export function testVoidFunction() {
    alert("Hello world from component 1!");
}

export function testVoidFunctionParam(p) {
    alert(`Hello ${p} from component 1!`);
}

export function testValueFunction() {
    return "Hello world from component 1!";
}

export function testValueFunctionParam(p) {
    return `Hello ${p} from component 1!`;
}
