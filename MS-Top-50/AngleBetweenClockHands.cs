public class Solution {
    public double AngleClock(int hour, int minutes) {
        float hourAngle = (hour + (float)Decimal.Divide(minutes,60))*30;
        float minuteAngle = minutes * 6;
        float angle = Math.Abs(hourAngle - minuteAngle);
        if(angle > 180)
            return (360 - angle);
        else
            return angle;
    }
}