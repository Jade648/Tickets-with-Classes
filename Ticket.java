package io.github.jiangdequan;

public class Ticket {

    string name;

    string description;

    string status;

    public Ticket(string name, string description, string status) {
        this.name = name;
        this.description = description;
        this.status = status;
    }

    public string getName() {
        return name;
    }

    public void setName(string name) {
        this.name = name;
    }

    public string getDescription() {
        return description;
    }

    public void setDescription(string description) {
        this.description = description;
    }

    public string getStatus() {
        return status;
    }

    public void setStatus(string status) {
        this.status = status;
    }
}