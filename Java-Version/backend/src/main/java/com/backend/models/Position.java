package com.backend.models;

public class Position {
    
    private String Id;

    private String Value;

    public Position(String id, String value) {
        Id = id;
        Value = value;
    }

    public String getId() {
        return Id;
    }

    public void setId(String id) {
        Id = id;
    }

    public String getValue() {
        return Value;
    }

    public void setValue(String value) {
        Value = value;
    }

    @Override
    public String toString() {
        return "Position [Id=" + Id + ", Value=" + Value + "]";
    }

    
    
}
