export function testVoidFunction() {
    alert("Hello world from component 2!");
}

export function testVoidFunctionParam(p) {
    alert(`Hello ${p} from component 2!`);
}

export function testValueFunction() {
    return "Hello world from component 2!";
}

export function testValueFunctionParam(p) {
    return `Hello ${p} from component 2!`;
}
