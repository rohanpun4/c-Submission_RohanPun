<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Account Management</title>
</head>
<body>
  <h1>Account Management</h1>
  
  <div>
    <label for="accountHolder">Account Holder:</label>
    <input type="text" id="accountHolder">
  </div>
  <div>
    <label for="accountType">Account Type:</label>
    <input type="text" id="accountType">
  </div>
  <div>
    <label for="amount">Amount:</label>
    <input type="number" id="amount">
  </div>
  <div>
    <button onclick="deposit()">Deposit</button>
    <button onclick="withdraw()">Withdraw</button>
    <button onclick="showSummary()">Show Summary</button>
  </div>
  
  <script>
    // Defining Account object using the syntax class
    class Account {
      constructor(accountHolder, accountType) {
        this.accountHolder = accountHolder;
        this.accountType = accountType;
        this.balance = 0;
      }

      // Using Method to deposit money into the account
      deposit(amount) {
        if (amount > 0) {
          this.balance += amount;
          console.log('The amount is Successfully deposited ${amount} into ${this.accountHolder}'s account. New balance for the account: ${this.balance}');
        } else {
          console.log("Please enter a valid deposit amount. The amount must be greater than 0.");
        }
      }

      // Using Method to withdraw money from the account
      withdraw(amount) {
        if (0 < amount <= this.balance) {
          this.balance -= amount;
          console.log('The amount is Successfully withdrawed ${amount} from ${this.accountHol
} else {
          console.log("Insufficient funds in the Account or invalid withdrawal amount. Please check your account balance and try again.");
        }
      }

      // Using Method to get a summary of the account details
      summary() {
        return {
          "Account Holder": this.accountHolder,
          "Account Type": this.accountType,
          "Balance": this.balance
        };
      }
    }

    // Using Function to handle deposit
    function deposit() {
      var accountHolder = document.getElementById("accountHolder").value;
      var accountType = document.getElementById("accountType").value;
      var amount = parseFloat(document.getElementById("amount").value);
      
      var account = new Account(accountHolder, accountType);
      account.deposit(amount);
    }

    // Using Function to handle withdrawal
    function withdraw() {
      var accountHolder = document.getElementById("accountHolder").value;
      var accountType = document.getElementById("accountType").value;
      var amount = parseFloat(document.getElementById("amount").value);
      
      var account = new Account(accountHolder, accountType);
      account.withdraw(amount);
    }

    // Using Function to show account summary
    function showSummary() {
      var accountHolder = document.getElementById("accountHolder").value;
      var accountType = document.getElementById("accountType").value;
      
      var account = new Account(accountHolder, accountType);
      var summary = account.summary();
      console.log(summary);
    }
  </script>
</body>
</html>