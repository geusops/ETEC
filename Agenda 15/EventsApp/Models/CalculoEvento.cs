namespace EventsApp.Models;

public class CalculoEvento
{
    public string NomeEvento { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }

    public int DuracaoDias 
    { 
        get => DataTermino.Subtract(DataInicio).Days;
    }
    public double CustoPorParticipante { get; set; }
    public int NumeroParticipantes { get; set; }
    public double CustoTotal 
    { 
        get
        {

            double ValorTotal = CustoPorParticipante * NumeroParticipantes;
            return ValorTotal;
        }
    }
    
}
