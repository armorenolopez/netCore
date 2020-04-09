using System;

public class CarSalesman
    {
        private string _firstName;
        private string _lastName;

        public string fullName 
        {
            get {
                return string.Format("{0} {1}", this._firstName, this._lastName);
            }
        }
        public CarSalesman(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }
    public void sell() => Console.WriteLine(string.Format("Hello {0} this is a test", fullName));
}
