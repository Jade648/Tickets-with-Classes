namespace Ticket
{

        class Tickets{

            public string name;

            public string description;

           public string status;
        private string v;

        public Tickets(string v)
        {
            this.v = v;
        }

        public Tickets(string name, string description, string status)
        {
            this.name = name;
            this.description = description;
            this.status = status;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Status { get => status; set => status = value; }
    }
    }
