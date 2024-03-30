<!DOCTYPE html>
<html lang="en-US">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Car Race</title>
</head>
<body>
  <h1>Car Race</h1>
  
  <!-- Container to display car information after each turn -->
  <div id="carInfo"></div>
  
  <script>
    // Defining the Car class
    class Car {
      // Constructor to initialize car properties
      constructor(brand, model, year, color, price, gas) {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.color = color;
        this.price = price;
        this.gas = gas;
      }

      // Using Method to make the car honk and displaying the car details
      honk() {
        console.log("Tuut tuut");
        console.log(`Brand: ${this.brand}, Model: ${this.model}, Year: ${this.year}, Color: ${this.color}, Price: $${this.price}`);
      }

      // Using Method to simulate gas loss after each turn of the race
      loseGas(currentYear) {
        let loss = 5;
        // If the car is not the model of the current year, calculate additional gas loss based on its model
        if (this.year !== currentYear) {
          const yearsOld = currentYear - this.year;
          loss += yearsOld;
        }
        // Reducing the gas based on calculated loss
        this.gas -= loss;
      }
    }

    // Creating car objects for the race
    const cars = [
      new Car("Honda", "CR-V", 2023, "Red", 50000, 45),
      new Car("Ford", "F-150", 2020, "Black", 25000, 30),
      new Car("BMW", "X5", 2022, "Green", 60000, 65),
      new Car("Mazda", "CX-5", 2019, "White", 15000, 60),
      new Car("Audi", "Q7", 2018, "Silver", 52000, 47),
      new Car("Kia", "Forte", 2020, "Blue", 21000, 56)
    ];

    // Using Function to run the race
    function race() {
      const raceDuration = 7; // Defining the duration of the race
      const currentYear = new Date().getFullYear();

      // Simulating each turn of the race
      for (let turn = 1; turn <= raceDuration; turn++) {
        console.log(`Turn ${turn}`); // Display current turn
        document.getElementById('carInfo').innerHTML += `<h3>Turn ${turn}</h3>`; // Display current turn in HTML
        
        // Iterating over each car in the race
        cars.forEach(car => {
          car.loseGas(currentYear); // Simulating the gas loss for the current turn
          console.log(`${car.brand} ${car.model}: Remaining gas - ${car.gas} litres`); // Displaying the remaining gas
          document.getElementById('carInfo').innerHTML += '<p>${car.brand} ${car.model}: Remaining gas - ${car.gas} litres</p>'; // To display the remaining gas
        });

        console.log("");
        document.getElementById('carInfo').innerHTML += `<br>`; 
      }
    }

    // Option to Start the race
    race();
  </script>
</body>
</html>
