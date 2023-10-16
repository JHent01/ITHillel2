


using DZ_13_1;
Car car = new Car();
Vehicle move = new Vehicle();

move.print();
car.StartEngine();
move.Move(11, 12);
move.print();
move.Move(111,122);
move.print();
move.Move(5, 6);
move.print();
car.StopEngine();
