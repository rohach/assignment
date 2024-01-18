const numbers = [1, 2, 3, 4, 5];

// Calling the sumArray function to calculate the sum
const sum = sumArray(numbers);

function sumArray(arr) {
  let sum = 0;
  for (let i = 0; i < arr.length; i++) {
    sum += arr[i];
  }
  return sum;
}
// Displaying the result
console.log("Sum of the array elements: " + sum);
