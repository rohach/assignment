function getUniqueElements(inputArray) {
  // Useing a Set to store unique elements
  let uniqueSet = new Set(inputArray);

  // Converting the Set back to an array
  let uniqueArray = Array.from(uniqueSet);

  return uniqueArray;
}

let inputArray = [1, 2, 3, 4, 2, 3, 5, 6, 7, 8, 1];
let uniqueElements = getUniqueElements(inputArray);

console.log("Original Array: " + inputArray);
console.log("Array with Unique Elements: " + uniqueElements);
