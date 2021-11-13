namespace Aula131.Entites
{
    internal class OutsourcedEmployee : Employee //herdando a classe Employee
    {
        public double AdditionalCharge { get; set; }//atributo incluído na classe OutsourcedEmployee 

        public OutsourcedEmployee()//construtor padrão
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)//construtor com argumentos
            : base(name, hours, valuePerHour) //base para sobrepor o construtor da classe Employee
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()//sobrescrevendo a função Payment da classe Employee 
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
