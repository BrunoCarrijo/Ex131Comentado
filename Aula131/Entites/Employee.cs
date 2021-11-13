namespace Aula131.Entites
{
    internal class Employee
    {
        public string Name { get; set; } //atributos da classe
        public int Hours { get; set; } //atributos da classe
        public double ValuePerHour { get; set; } //atributos da classe

        public Employee() //construtor padrão
        {
        }

        public Employee(string name, int hours, double valuePerHour) //construtor com argumentos
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment() //função Payment com a operação pra definir o salário
        {                               //sobreposição do metodo: virtual para liberar a opção Payment para ser sobrescrita 
            return Hours * ValuePerHour;
        }
    }
}
