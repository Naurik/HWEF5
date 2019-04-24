using System;

namespace HWEF5
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Login { get; set; }
}
}