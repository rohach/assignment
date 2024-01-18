const numbers = [1, 3, 4, 8, 5, 2, 6, 9, 0, 7];

let max = numbers[0];
let min = numbers[0];

for (let i = 1; i < numbers.length; i++) {
  if (numbers[i] > max) {
    max = numbers[i]; // This will update max if a larger element is found
  }
  if (numbers[i] < min) {
    min = numbers[i]; // This will update min if a smaller element is found
  }
}

// Displaying the results
console.log("Maximum number: " + max);
console.log("Minimum number: " + min);
