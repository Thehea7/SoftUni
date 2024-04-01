using onlineTesting;


Student student2  = new();
Lawyer lawyer  = new();
Sportsman sportsman  = new();

Swimmer swimer = new()
{
    Address = default,
        FirstName = default,
        LastName = default,
        Sport = default,
        Pool = default
};

swimer.Father = lawyer;
swimer.Father.Sleep();