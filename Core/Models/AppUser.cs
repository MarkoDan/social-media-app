namespace Core.Models
{
    public class AppUser
    {
        public int Id {get; set;}
        public string Username {get; set;} = string.Empty;
        public byte[] ?PasswordHash {get ; set;}
        public byte[] ?PasswordSalt {get; set;}
        public DateOnly DateOfBirth {get ; set;}
        public DateTime Created {get; set;} = DateTime.UtcNow;
        public string Name {get; set;} = string.Empty;
        public List<Post> Posts {get ; set;} = new List<Post>();
        // public List<Photo> Photos {get ; set;} = new List<Photo>();
        

    }
}