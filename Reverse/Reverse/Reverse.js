function reverseString(input) {
  // Converting the string to an array of characters
  let charArray = input.split("");

  let length = charArray.length;

  // Changing characters from the beginning and end of the array
  for (let i = 0; i < Math.floor(length / 2); i++) {
    let temp = charArray[i];
    charArray[i] = charArray[length - i - 1];
    charArray[length - i - 1] = temp;
  }

  // Converting the array back to a string
  let reversedString = charArray.join("");

  return reversedString;
}

let inputString = "Hello, World!";
let reversedString = reverseString(inputString);

console.log("Original String: " + inputString);
console.log("Reversed String: " + reversedString);
