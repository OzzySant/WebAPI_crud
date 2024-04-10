namespace WebAPI_Video.Models
{
    public class ServiceResponse<T> // ServiceResponse pode receber qualquer tipo de objeto
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;
    }
}
