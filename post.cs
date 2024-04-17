// creating a Base class representing a generic mail
abstract class Mail
{
    protected double weight;
    protected bool express;
    protected string destinationAddress;

    // Creating a Constructor to initialize the mail properties
    public Mail(double weight, bool express, string destinationAddress)
    {
        this.weight = weight;
        this.express = express;
        this.destinationAddress = destinationAddress;
    }

    // Using Abstract method to calculate the postage (which is to be implemented by the derived classes)
    public abstract double CalculatePostage();
}

// Creating a derived class for the letter
class Letter : Mail
{
    private string format; 

    // Creating a Constructor for initializing the properties of the letter
    public Letter(double weight, bool express, string destinationAddress, string format) : base(weight, express, destinationAddress)
    {
        this.format = format;
    }

    // Implementation of CalculatePostage method for letters
    public override double CalculatePostage()
    {
        double baseFare = (format == "A4") ? 2.50 : 3.50; 
        double postage = (express ? 2 : 1) * (baseFare + 0.001 * weight); 
        return postage;
    }
}

// Creating a Derived class for the parcel
class Parcel : Mail
{
    private double volume; 

    // Creating Constructor for initializign the parcel properties
    public Parcel(double weight, bool express, string destinationAddress, double volume) : base(weight, express, destinationAddress)
    {
        this.volume = volume;
    }

    // Implementation of CalculatePostage method for parcels
    public override double CalculatePostage()
    {
        // Checking if the destination address is empty(null) or the volume exceeds limit
        if (destinationAddress == "" || volume > 50)
            return 0; // The Parcel is invalid, no postage is required

        // Calculating Postage based on the weight and volume
        double postage = (express ? 2 : 1) * (0.25 * volume + weight); 
        return postage;
    }
}

// Creating a Derived class for advertisement
class Advertisement : Mail
{
    // Creating a Constructor for initializing advertisement properties
    public Advertisement(double weight, bool express, string destinationAddress) : base(weight, express, destinationAddress)
    {
    }

    // Implementation of CalculatePostage method for advertisements
    public override double CalculatePostage()
    {
        // Checking if the destination address is empty(null)
        if (destinationAddress == "")
            return 0; // The given Advertisement is invalid, no postage is required

        // Postage calculation based on the weight
        double postage = (express ? 2 : 1) * 5 * (weight / 1000); 
        return postage;
    }
}

// Creating a Class representing a mailbox
class Box
{
    private Mail[] mails; // Array for storing mails
    private int size; 
    private int count; 

    // Creating Constructor for initializing mailbox properties
    public Box(int size)
    {
        this.size = size;
        mails = new Mail[size]; 
        count = 0; 
    }

    // Method for adding mail to the mailbox
    public void AddMail(Mail mail)
    {
        if (count < size)
        {
            mails[count] = mail; 
            count++; 
        }
    }

    // Method for calculating the total postage for all the mails in the mailbox
    public double Stamp()
    {
        double totalPostage = 0;
        foreach (Mail mail in mails)
        {
            if (mail != null)
                totalPostage += mail.CalculatePostage(); // Calculating postage for each mail
        }
        return totalPostage;
    }

    // Using Method for counting the total number of invalid mails in the mailbox
    public int InvalidMails()
    {
        int invalidCount = 0;
        foreach (Mail mail in mails)
        {
            if (mail != null && mail.CalculatePostage() == 0)
                invalidCount++; 
        }
        return invalidCount;
    }

    // Method to display contents of the mailbox
    public void Display()
    {
        foreach (Mail mail in mails)
        {
            if (mail != null)
            {
                double postage = mail.CalculatePostage();
                if (postage == 0)
                {
                    // Printing information for invalid mails
                    Console.WriteLine(mail.GetType().Name);
                    Console.WriteLine("(Invalid courier)");
                }
                else
                {
                    // Printing information for the mails which are valid
                    Console.WriteLine(mail.GetType().Name);
                    Console.WriteLine($"Weight: {mail.weight} grams");
                    Console.WriteLine($"Express: {(mail.express ? "yes" : "no")}");
                    Console.WriteLine($"Destination: {mail.destinationAddress}");
                    Console.WriteLine($"Price: ${postage}");
                }
            }
        }
    }
}
