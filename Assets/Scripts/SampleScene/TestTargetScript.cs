using System;

public class TestTargetScript
{
    /// <summary>
    /// Processes the value and returns calculated result or throws ArgumentException if invalid input param supplied
    /// </summary>
    /// <returns>If value <= 1000 - returns value. If value is above 1000 - returns -1</returns>
    /// <exception cref="ArgumentException">If value is below 0 - throws an ArgumentException</exception>
    public int MethodOne(int initialBallAcceleration)
    {
        if (initialBallAcceleration < 0)
            throw new ArgumentException("Initial acceleration must not be negative");

        if (initialBallAcceleration > 1000)
            return -1;

        return initialBallAcceleration;
    }
}
