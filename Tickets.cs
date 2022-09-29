namespace Ticket
{

        class Tickets{

            string name;

            string description;

            string status;

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
