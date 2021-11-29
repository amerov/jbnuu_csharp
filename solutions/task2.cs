namespace Solutions {
  class Task2 {

    int hours, minutes, seconds;
    System.TimeSpan interval;

    public Task2(int hours,  int minutes, int seconds) {
      interval = new System.TimeSpan(hours, minutes, seconds);
    }

    public double CalculateSeconds() {
      return interval.TotalSeconds;
    }

    public System.TimeSpan Add5Sec() {
      return interval.Add(new System.TimeSpan(0, 0, 5));
    }
  }
}