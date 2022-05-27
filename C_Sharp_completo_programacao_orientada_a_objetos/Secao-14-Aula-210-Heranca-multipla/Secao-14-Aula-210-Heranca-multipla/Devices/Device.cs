
namespace Secao_14_Aula_210_Heranca_multipla.Devices
{
    internal abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}