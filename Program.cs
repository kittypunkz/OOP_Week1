class Program {
    public static void Main(string[] args) {
        /*
        Brand: Tesla
        Model: Model Y
        NumberOfDoors: 4
        NumberOfWheels: 4
        */
        Car myTesla = new Car();
        myTesla.brand = "Tesla";
        myTesla.model = "Model Y";
        myTesla.numberOfDoors = 4;
        myTesla.numberOfWheels = 4;

        /*
        Brand: Volvo
        Model: XC40
        NumberOfDoors: 4
        NumberOfWheels: 4
        */
        Car myVolvo = new Car();
        myVolvo.brand = "Volvo";
        myVolvo.model = "XC40";
        myVolvo.numberOfDoors = 4;
        myVolvo.numberOfWheels = 4;

        DogDoor ModelA = new DogDoor();
        ModelA.DoorSize = "XL";
        ModelA.DoorMaterial = "Plastic";
        ModelA.DoorHeight = 90;

        PrintCarInformation(myTesla);
        PrintCarInformation(myVolvo);
        PrintDogDoorInformation(ModelA);

    }

    static void PrintCarInformation(Car car) {
        Console.WriteLine("**********");
        Console.WriteLine("Brand: {0}", car.brand);
        Console.WriteLine("Model: {0}", car.model);
        Console.WriteLine("Number Of Doors: {0}", car.numberOfDoors);
        Console.WriteLine("Number Of Wheels: {0}", car.numberOfWheels);
        Console.WriteLine(car.MoveForward());
        Console.WriteLine("**********");
    }

    static void PrintDogDoorInformation(DogDoor dogdoor) {
        Console.WriteLine("**********");
        Console.WriteLine("Size: {0}", dogdoor.DoorSize);
        Console.WriteLine("Material: {0}", dogdoor.DoorMaterial);
        Console.WriteLine("Height: {0}", dogdoor.DoorHeight);
        Console.WriteLine(dogdoor.DoorOpen());
        Console.WriteLine("**********");
    }
}
