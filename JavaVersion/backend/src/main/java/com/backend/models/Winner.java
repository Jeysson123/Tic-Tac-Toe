package com.backend.models;

public class Winner {
    
    private String Icon;
    
    private Boolean IsWinner;

    private String Positions;

    public Winner(String icon, Boolean isWinner, String positions) {
        Icon = icon;
        IsWinner = isWinner;
        Positions = positions;
    }

    public String getIcon() {
        return Icon;
    }


    public void setIcon(String icon) {
        Icon = icon;
    }

    
    public Boolean getIsWinner() {
        return IsWinner;
    }

    public void setIsWinner(Boolean isWinner) {
        IsWinner = isWinner;
    }

    public String getPositions() {
        return Positions;
    }

    public void setPositions(String positions) {
        Positions = positions;
    }

    @Override
    public String toString() {
        return "Winner [Icon=" + Icon + ", IsWinner=" + IsWinner + ", Positions=" + Positions + "]";
    }
   

}
