using System;

namespace BlabberApp.Domain.Entities {
    public class Blab : Model {
        public String Message { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
    }
}