namespace Lab_3
{
    public class PersonState
    {
        public string name { get; }
        public int age { get; }

        public PersonState(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
    }

    public class Person
    {
        public string _name = "Jokar";
        public int _age = 5;

        public PersonState GetState()
        {
            PersonState person = new PersonState(_name, _age);
            return person;
        }

        public void SetState(PersonState state)
        {
            _name = state.name;
            _age = state.age;
        }
    }
}
