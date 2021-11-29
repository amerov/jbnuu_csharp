namespace Solutions {
  class Task1 {
    double caloric, weight;

    public Task1(double caloric,  double weight) {
      this.caloric = caloric;
      this.weight = weight;
    }

    public double Calculate() {
      return (caloric / 100) * weight;
    }
  }
}