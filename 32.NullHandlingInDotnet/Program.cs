// See https://aka.ms/new-console-template for more information

User user = new User()
{
    Name = "Parham"
};

// 1
if (user != null && user.Name != null)
{
    int length1 = user.Name.Length;
}

// 2
if (user is not null && user.Name is not null)
{
    int length2 = user.Name.Length;
}

//3
int? length3 = user?.Name?.Length;

//4
int length4 = user?.Name?.Length ?? 0;

//5
ArgumentException.ThrowIfNullOrEmpty(user.Name);

class User
{
    public string Name { get; set; }
}



