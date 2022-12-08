package time;

import java.util.*;

interface Comparison {
    void isGreater(long xTime, long yTime);
    void isLess(long xTime, long yTime);
    void isEqual(long xTime, long yTime);
}

class Time implements Comparison {
    @Override
    public void isGreater(long xTime, long yTime) {
        if (xTime > yTime){
             System.out.println(xTime + " is later than" +  yTime + ".");
        }
    }
    @Override
    public void isLess(long xTime, long yTime) {
        if (xTime < yTime){
             System.out.println(xTime + " is earlier than " +  yTime + ".");
        }
    }

    @Override
    public void isEqual(long xTime, long yTime) {
        if (yTime == xTime){
             System.out.println(xTime + " is Equal to " +  yTime + ".");
        }
    }
}

public class Main {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        long x, y;
          
        System.out.println("Enter your first Time (in Military time): ");
        x= in.nextLong();
        System.out.println("Enter your second Time(in Military Time:  ");
        y= in.nextLong();
        
        Time t = new Time();
        
        t.isGreater(x, y);
        t.isLess(x, y);
        t.isEqual(x, y);    
    }
}
