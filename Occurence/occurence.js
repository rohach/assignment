function countCharacterOccurrences(inputString) {
  let charCount = {};

  for (let char of inputString) {
    charCount[char] = (charCount[char] || 0) + 1;
  }

  return charCount;
}

let inputString = "hello world";
let occurrences = countCharacterOccurrences(inputString);

console.log("String: " + inputString);
console.log("Character Occurrences: ", occurrences);
